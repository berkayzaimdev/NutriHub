using MediatR;
using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Features.Commands.UserCommands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.UserHandlers
{
    public class LoginHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly UserManager<User> _manager;
        private readonly ITokenService _tokenService;

        public LoginHandler(UserManager<User> manager, ITokenService tokenService)
        {
            _manager = manager;
            _tokenService = tokenService;
        }

        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _manager.FindByNameAsync(request.UserName);
            string token;

            if (await _manager.CheckPasswordAsync(user, request.Password))
            {
                token = _tokenService.CreateToken(user);
                return token;
            }

            return string.Empty;
        }
    }
}
