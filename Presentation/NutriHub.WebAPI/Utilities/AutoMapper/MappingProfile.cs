using AutoMapper;
using NutriHub.Application.DTOs.SubcategoryDtos;
using NutriHub.Application.DTOs.User;
using NutriHub.Application.Features.Addresses.Commands;
using NutriHub.Application.Features.Addresses.Results;
using NutriHub.Application.Features.Brands.Commands;
using NutriHub.Application.Features.Brands.Results;
using NutriHub.Application.Features.Products.Results;
using NutriHub.Application.Features.Users.Commands;
using NutriHub.Domain.Entities;

namespace NutriHub.WebAPI.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserDto, User>();
            CreateMap<RegisterCommand, CreateUserDto>();

            CreateMap<Subcategory, SubcategoryOfMenuDto>();

            CreateMap<CreateAddressCommand, Address>();
            CreateMap<UpdateAddressCommand, Address>();
            CreateMap<Address, GetAddressesByUserIdQueryResult>();

            CreateMap<CreateBrandCommand, Brand>();
            CreateMap<UpdateBrandCommand, Brand>();
            CreateMap<Brand, GetAllBrandsQueryResult>();
        }
    }
}
