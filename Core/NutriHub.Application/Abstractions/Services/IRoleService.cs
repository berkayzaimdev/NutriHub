using Microsoft.AspNetCore.Identity;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Services
{
    public interface IRoleService
    {
        string DetermineNewRole(int totalPoints, User user, UserManager<User> userManager);
        Task UpdateUserRoleAsync(User user, string newRole);
        Task<string> GetRoleIdAsync(string userId);
    }
}
