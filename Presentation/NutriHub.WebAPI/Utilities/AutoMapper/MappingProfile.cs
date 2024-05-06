using AutoMapper;
using NutriHub.Application.DTOs.SubcategoryDtos;
using NutriHub.Application.DTOs.User;
using NutriHub.Application.Features.Commands.AppUserCommands;
using NutriHub.Domain.Entities;

namespace NutriHub.WebAPI.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserDto, AppUser>();
            CreateMap<CreateAppUserCommand, CreateUserDto>();

            CreateMap<Subcategory, SubcategoryOfMenuDto>();
        }
    }
}
