using MediatR;
using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Orders.Commands;
using NutriHub.Application.Helpers;
using NutriHub.Domain.Entities;

namespace NutriHub.Application.Features.Orders.Handlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {
        private readonly IProductRepository _productRepository;
        private readonly ICartItemRepository _cartItemRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IAppliedCouponRepository _appliedCouponRepository;
        private readonly UserManager<User> _userManager;

        public CreateOrderCommandHandler(IProductRepository productRepository, ICartItemRepository cartItemRepository, IOrderRepository orderRepository, IOrderItemRepository orderItemRepository, IAppliedCouponRepository appliedCouponRepository, UserManager<User> userManager)
        {
            _productRepository = productRepository;
            _cartItemRepository = cartItemRepository;
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            _appliedCouponRepository = appliedCouponRepository;
            _userManager = userManager;
        }

        public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var coupon = await _appliedCouponRepository.GetWithCouponAsync(request.UserId);
            var amount = await _cartItemRepository.GetCartAmountByUserIdAsync(request.UserId);
            var currentAmount = amount;

            decimal couponDiscount = 0;
            if(coupon != null)
            {
                couponDiscount = currentAmount * (coupon.Coupon.Discount / 100);
                currentAmount -= couponDiscount;
            }
      

            var role = await GetUserSingleRoleAsync(request.UserId);
            decimal membershipDiscount = 0;
            decimal membershipDiscountRate = AmountHelper.GetMembershipDiscountRate(role);
            if (membershipDiscountRate != 0)
            {
                membershipDiscount = currentAmount * (AmountHelper.GetMembershipDiscountRate(role) / 100); // TODO: fix
                currentAmount -= membershipDiscount;
            }

            var productDiscount = currentAmount*50;
            currentAmount -= productDiscount;


            var paymentMethodDiscount = AmountHelper.GetPaymentMethodDiscountRate(request.PaymentMethod);
            if(currentAmount - paymentMethodDiscount < 0)
            {
                paymentMethodDiscount = currentAmount;
            }


            var newOrder = new Order
            {
                Note = request.Note,
                PaymentMethod = request.PaymentMethod,
                Amount = amount,
                CouponDiscount = couponDiscount,
                MembershipDiscount = membershipDiscount,
                ProductDiscount = productDiscount,
                PaymentMethodDiscount = paymentMethodDiscount,
                DeliveredDate = DateTime.Now.AddDays(GetAddedDeliveredDay()),
                AddressId = request.AddressId,
                CouponId = coupon is not null ? coupon.CouponId : null,
                UserId = request.UserId,
            };

            var cartItems = await _cartItemRepository.GetCartItemsByUserIdAsync(request.UserId);
            var dictionary = cartItems.ToDictionary(x => x.ProductId, x => x.Quantity);
            await _productRepository.DecreaseStockByCartItemsAsync(dictionary);
        
            await _orderRepository.CreateAsync(newOrder);

            var orderItems = cartItems.Select(ci => new OrderItem
            {
                OrderId = newOrder.Id,
                ProductId = ci.ProductId,
                Quantity = ci.Quantity,
            });


            await _orderItemRepository.CreateAllAsync(orderItems);
            var tempCartItems = cartItems.ToList();
            await _cartItemRepository.DeleteAllAsync(cartItems);
            await _cartItemRepository.RemoveCartItemsIfOutOfStockAsync(tempCartItems.Select(x => x.ProductId));
        }

        private async Task<string> GetUserSingleRoleAsync(string userId) 
        {
            var user = await _userManager.FindByIdAsync(userId);
            var roles = await _userManager.GetRolesAsync(user);
            return roles.Any() ? roles[0] : string.Empty;
        }

        private int GetAddedDeliveredDay() 
        {
            return DateTime.Now.DayOfWeek switch // 2 gün gecikmeli teslimden dolayı, gün aralığını kontrol ettik
            {
                DayOfWeek.Thursday => 4,
                DayOfWeek.Friday => 3,
                _ => 2,
            };
        }
    }
}
