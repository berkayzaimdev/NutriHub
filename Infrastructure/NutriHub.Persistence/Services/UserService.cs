using AutoMapper;
using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.DTOs.User;
using NutriHub.Domain.Entities;

namespace NutriHub.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<User> CreateAsync(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<User>(createUserDto);
            var result = await _userManager.CreateAsync(user, createUserDto.Password);
            return user;
        }

        public async Task DeleteAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            await _userManager.DeleteAsync(user);
        }
    }
}
