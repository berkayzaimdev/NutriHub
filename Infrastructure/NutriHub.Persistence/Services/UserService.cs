using AutoMapper;
using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.DTOs.User;
using NutriHub.Domain.Entities;
using System.Globalization;

namespace NutriHub.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IPointRepository _pointRepository;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager, IMapper mapper, IPointRepository pointRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _pointRepository = pointRepository;
        }

        public async Task<User> CreateAsync(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<User>(createUserDto);
            var lowerName = user.FirstName.ToLower();
            var lowerSurname = user.LastName.ToLower();
            user.UserName = string.Concat(ReplaceTurkishCharacters(lowerName), ReplaceTurkishCharacters(lowerSurname));

            try 
            {
                var result = await _userManager.CreateAsync(user, createUserDto.Password);
                await _userManager.AddToRoleAsync(user, "BRONZE");
                await _pointRepository.CreateAsync(new Point
                {
                    Points = 0,
                    UserId = user.Id
                });
            }
            catch(Exception ex)
            {
                
            }
            return user;
        }

        public async Task DeleteAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            await _userManager.DeleteAsync(user);
        }

        private string ReplaceTurkishCharacters(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return input
                .Replace('ç', 'c')
                .Replace('ı', 'i')
                .Replace('ğ', 'g')
                .Replace('ö', 'o')
                .Replace('ş', 's')
                .Replace('ü', 'u');
        }
    }
}
