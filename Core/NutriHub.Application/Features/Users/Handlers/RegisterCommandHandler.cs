using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.DTOs.User;
using NutriHub.Application.Features.Users.Commands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Users.Handlers
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;

        public RegisterCommandHandler(IUserService userService, IMapper mapper, IEmailService emailService)
        {
            _userService = userService;
            _mapper = mapper;
            _emailService = emailService;
        }

        public async Task Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var userDto = _mapper.Map<CreateUserDto>(request);
            var user = await _userService.CreateAsync(userDto);

            await _emailService.SendConfirmationMailAsync(user.Email,"test");
        }
    }
}
