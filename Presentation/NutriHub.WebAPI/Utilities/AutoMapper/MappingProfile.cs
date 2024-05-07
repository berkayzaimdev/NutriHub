using AutoMapper;
using NutriHub.Application.DTOs.SubcategoryDtos;
using NutriHub.Application.DTOs.User;
using NutriHub.Application.Features.Commands.UserCommands;
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
        }
    }
}
