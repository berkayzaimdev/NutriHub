using AutoMapper;
using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.DTOs.User;
using NutriHub.Application.Features.Commands.AppUserCommands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public UserService(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task CreateAsync(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<AppUser>(createUserDto);
            var result = await _userManager.CreateAsync(user, createUserDto.Password);
            var test = 1;
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
