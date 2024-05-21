﻿using MediatR;
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
        private readonly IPdfService _pdfService;
        private readonly IAddressRepository _addressRepository;
        private readonly IRoleService _roleService;
        private readonly UserManager<User> _userManager;
        private User _user;

        public CreateOrderCommandHandler(IProductRepository productRepository, ICartItemRepository cartItemRepository, IOrderRepository orderRepository, IOrderItemRepository orderItemRepository, IAppliedCouponRepository appliedCouponRepository, IDiscountService discountService, UserManager<User> userManager, IPointRepository pointRepository, IEmailService emailService, IPdfService pdfService, IAddressRepository addressRepository, IRoleService roleService)
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
            _pdfService = pdfService;
            _addressRepository = addressRepository;
            _roleService = roleService;
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
                EarnedPoints = (int)Math.Ceiling(amount * 3),
                DeliveredDate = DateTime.Now.AddDays(GetAddedDeliveredDay()),
                AddressId = request.AddressId,
                CouponId = coupon is not null ? coupon.CouponId : null,
                UserId = request.UserId,
            };

            _user = await _userManager.FindByIdAsync(request.UserId);

            if(_user is null)
            {
                throw new NullReferenceException();
            }

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

            var orderWithDetails = await _orderRepository.GetDetailsAsync(order.Id);

            var pdfReceipt = _pdfService.GenerateOrderReceipt(orderWithDetails);
            await _emailService.SendOrderReceiptEmailAsync(string.Concat(_user.FirstName," ",_user.LastName), _user.Email, pdfReceipt);

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
            // Admin kontrolü
            var roles = await _userManager.GetRolesAsync(_user);
            if (roles.Contains("Admin")) return;

            var point = await _pointRepository.GetAsync(userId);

            int totalPoints;

            if (point is null)
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

            string newRole = _roleService.DetermineNewRole(totalPoints, _user, _userManager);

            if (!string.IsNullOrEmpty(newRole))
            {
                await _roleService.UpdateUserRoleAsync(_user, newRole);
                await _emailService.SendRankUpEmailAsync(_user.Email, newRole); // Rütbe atladığında e-posta gönder
            }
        }
    }
}