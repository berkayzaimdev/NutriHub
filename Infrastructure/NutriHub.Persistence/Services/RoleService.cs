using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Enums;
using NutriHub.Domain.Entities;

namespace NutriHub.Persistence.Services
{
    public class RoleService : IRoleService
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleService(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public string DetermineNewRole(int totalPoints, User user, UserManager<User> userManager)
        {
            if (totalPoints >= 50000 && !userManager.IsInRoleAsync(user, RoleType.Star).Result)
            {
                return RoleType.Star;
            }
            else if (totalPoints >= 30000 && !userManager.IsInRoleAsync(user, RoleType.Platin).Result)
            {
                return RoleType.Platin;
            }
            else if (totalPoints >= 15000 && !userManager.IsInRoleAsync(user, RoleType.Gold).Result)
            {
                return RoleType.Gold;
            }
            else if (totalPoints >= 10000 && !userManager.IsInRoleAsync(user, RoleType.Silver).Result)
            {
                return RoleType.Silver;
            }

            return string.Empty;
        }

        public async Task UpdateUserRoleAsync(User user, string newRole)
        {
            var currentRoles = await _userManager.GetRolesAsync(user);
            var rolesToRemove = currentRoles.Where(role => role != newRole);

            if (rolesToRemove.Any())
            {
                await _userManager.RemoveFromRolesAsync(user, rolesToRemove);
            }

            if (!await _userManager.IsInRoleAsync(user, newRole))
            {
                await _userManager.AddToRoleAsync(user, newRole);
            }
        }

        public async Task<string> GetRoleIdAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var roles = await _userManager.GetRolesAsync(user);
            var role = await _roleManager.FindByNameAsync(roles.FirstOrDefault());
            return role.Id;
        }
    }
}
