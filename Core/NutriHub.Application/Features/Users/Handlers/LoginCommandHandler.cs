using MediatR;
using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Features.Users.Commands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Users.Handlers
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly UserManager<User> _manager;
        private readonly ITokenService _tokenService;

        public LoginCommandHandler(UserManager<User> manager, ITokenService tokenService)
        {
            _manager = manager;
            _tokenService = tokenService;
        }

        public async Task<string> Handle(LoginCommand command, CancellationToken cancellationToken)
        {
            var user = await _manager.FindByEmailAsync(command.Email);
            string token;

            if (await _manager.CheckPasswordAsync(user, command.Password))
            {
                token = _tokenService.CreateToken(user);
                return token;
            }

            return string.Empty;
        }
    }
}
