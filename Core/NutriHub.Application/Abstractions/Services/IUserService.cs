using NutriHub.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task CreateAsync(CreateUserDto createUserDto);
        Task DeleteAsync();
    }
}
