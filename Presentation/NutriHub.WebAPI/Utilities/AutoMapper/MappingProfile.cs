using AutoMapper;
using NutriHub.Application.DTOs.SubcategoryDtos;
using NutriHub.Application.DTOs.User;
using NutriHub.Application.Features.Addresses.Commands;
using NutriHub.Application.Features.Addresses.Results;
using NutriHub.Application.Features.Brands.Commands;
using NutriHub.Application.Features.Brands.Results;
using NutriHub.Application.Features.Categories.Commands;
using NutriHub.Application.Features.Coupons.Commands;
using NutriHub.Application.Features.Coupons.Results;
using NutriHub.Application.Features.Products.Commands;
using NutriHub.Application.Features.Products.Results;
using NutriHub.Application.Features.Subcategories.Commands;
using NutriHub.Application.Features.Users.Commands;
using NutriHub.Domain.Entities;

namespace NutriHub.WebAPI.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Address Mappings
            CreateMap<CreateAddressCommand, Address>();
            CreateMap<UpdateAddressCommand, Address>();
            CreateMap<Address, GetAddressesByUserIdQueryResult>();

            // Brand Mappings
            CreateMap<CreateBrandCommand, Brand>();
            CreateMap<UpdateBrandCommand, Brand>();
            CreateMap<Brand, GetAllBrandsQueryResult>();

            // Category Mappings
            CreateMap<UpdateCategoryCommand, Category>();
            CreateMap<CreateCategoryCommand, Category>();

            // Coupon Mappings
            CreateMap<UpdateCouponCommand, Coupon>();
            CreateMap<CreateCouponCommand, Coupon>();
            CreateMap<Coupon, GetCouponsQueryResult>();

            // Product Mappings
            CreateMap<UpdateProductCommand, Product>();

            // User Mappings
            CreateMap<RegisterCommand, CreateUserDto>();
            CreateMap<CreateUserDto, User>();

            // Subcategory Mappings
            CreateMap<Subcategory, SubcategoryOfMenuDto>();
            CreateMap<UpdateSubcategoryCommand, Subcategory>();
            CreateMap<CreateSubcategoryCommand, Subcategory>();
        }
    }
}
