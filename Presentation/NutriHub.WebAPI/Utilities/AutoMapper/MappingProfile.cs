using AutoMapper;
using NutriHub.Application.DTOs.SubcategoryDtos;
using NutriHub.Application.DTOs.User;
using NutriHub.Application.Features.Commands.AddressCommands;
using NutriHub.Application.Features.Commands.BrandCommands;
using NutriHub.Application.Features.Commands.UserCommands;
using NutriHub.Application.Features.Results.AddressResults;
using NutriHub.Application.Features.Results.BrandResults;
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
