using MediatR;
using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Enums;
using NutriHub.Application.Features.Orders.Commands;
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
        private readonly IPointRepository _pointRepository;
        private readonly IDiscountService _discountService;
        private readonly IEmailService _emailService;
        private readonly UserManager<User> _userManager;

        public CreateOrderCommandHandler(IProductRepository productRepository, ICartItemRepository cartItemRepository, IOrderRepository orderRepository, IOrderItemRepository orderItemRepository, IAppliedCouponRepository appliedCouponRepository, IDiscountService discountService, UserManager<User> userManager, IPointRepository pointRepository, IEmailService emailService)
        {
            _productRepository = productRepository;
            _cartItemRepository = cartItemRepository;
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            _appliedCouponRepository = appliedCouponRepository;
            _discountService = discountService;
            _userManager = userManager;
            _pointRepository = pointRepository;
            _emailService = emailService;
        }

        public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var coupon = await _appliedCouponRepository.GetWithCouponAsync(request.UserId);
            var amount = await _cartItemRepository.GetCartAmountByUserIdAsync(request.UserId);

            var discounts = await _discountService.CalculateDiscountsAsync(request.UserId, request.PaymentMethod, coupon, amount);

            var newOrder = new Order
            {
                Note = request.Note,
                OrderCode = GenerateRandomOrderCode(),
                PaymentMethod = request.PaymentMethod,
                Amount = amount,
                CouponDiscount = discounts.CouponDiscount,
                MembershipDiscount = discounts.MembershipDiscount,
                ProductDiscount = discounts.ProductDiscount,
                PaymentMethodDiscount = discounts.PaymentMethodDiscount,
                EarnedPoints = (int)Math.Ceiling(amount*3),
                DeliveredDate = DateTime.Now.AddDays(GetAddedDeliveredDay()),
                AddressId = request.AddressId,
                CouponId = coupon is not null ? coupon.CouponId : null,
                UserId = request.UserId,
            };

            await CreateOrderAsync(newOrder, request.UserId);

            await UpdateUserPointsAndRankAsync(request.UserId, newOrder.EarnedPoints);

            if (coupon is not null)
            {
                await _appliedCouponRepository.DeleteAsync(coupon);

            }
        }

        private async Task CreateOrderAsync(Order order, string userId)
        {
            var cartItems = await _cartItemRepository.GetCartItemsByUserIdAsync(userId);
            var productQuantities = cartItems.ToDictionary(x => x.ProductId, x => x.Quantity);

            await _productRepository.DecreaseStockByCartItemsAsync(productQuantities);
            await _orderRepository.CreateAsync(order);

            var orderItems = cartItems.Select(ci => new OrderItem
            {
                OrderId = order.Id,
                ProductId = ci.ProductId,
                Quantity = ci.Quantity,
            });

            await _orderItemRepository.CreateAllAsync(orderItems);
            var cartItemProductIds = cartItems.Select(x => x.ProductId);

            await _cartItemRepository.DeleteAllAsync(cartItems);
            await _cartItemRepository.RemoveCartItemsIfOutOfStockAsync(cartItemProductIds);
        }

        private static string GenerateRandomOrderCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return $"S-{randomString}";
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

        private async Task UpdateUserPointsAndRankAsync(string userId, int earnedPoints)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null) return;

            // Admin kontrolü
            var roles = await _userManager.GetRolesAsync(user);
            if (roles.Contains("Admin")) return;

            var point = await _pointRepository.GetAsync(userId);

            int totalPoints;

            if(point is null)
            {
                await _pointRepository.CreateAsync(new Point
                {
                    UserId = userId,
                    Points = earnedPoints
                });

                totalPoints = earnedPoints;
            }

            else
            {
                point.Points += earnedPoints;
                await _pointRepository.UpdateAsync(point);
                totalPoints = point.Points;
            }


            string newRole = string.Empty;

            if (totalPoints >= 50000 && !await _userManager.IsInRoleAsync(user, RoleType.Star))
            {
                newRole = RoleType.Star;
            }

            else if (totalPoints >= 30000 && !await _userManager.IsInRoleAsync(user, RoleType.Platin))
            {
                newRole = RoleType.Platin;
            }

            else if (totalPoints >= 15000 && !await _userManager.IsInRoleAsync(user, RoleType.Gold))
            {
                newRole = RoleType.Gold;
            }

            else if (totalPoints >= 10000 && !await _userManager.IsInRoleAsync(user, RoleType.Silver))
            {
                newRole = RoleType.Silver;
            }

            if (!string.IsNullOrEmpty(newRole))
            {
                await UpdateUserRoleAsync(user, newRole);
                await _emailService.SendRankUpEmailAsync(user.Email, newRole); // Rütbe atladığında e-posta gönder
            }
        }

        private async Task UpdateUserRoleAsync(User user, string newRole)
        {
            var currentRoles = await _userManager.GetRolesAsync(user);
            var rolesToRemove = currentRoles.Where(role => role != newRole);

            if (rolesToRemove.Any())
            {
                await _userManager.RemoveFromRolesAsync(user, rolesToRemove);
            }

            if (!await _userManager.IsInRoleAsync(user, newRole))
            {
                await _userManager.AddToRoleAsync(user, newRole);
            }
        }
    }
}
