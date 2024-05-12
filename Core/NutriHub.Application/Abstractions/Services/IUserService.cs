using NutriHub.Application.DTOs.User;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<User> CreateAsync(CreateUserDto createUserDto);
        Task DeleteAsync(string id);
    }
}
