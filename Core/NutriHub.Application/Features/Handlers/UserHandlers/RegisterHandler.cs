﻿using AutoMapper;
using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.DTOs.User;
using NutriHub.Application.Features.Commands.UserCommands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.UserHandlers
{
    public class RegisterHandler : IRequestHandler<RegisterCommand>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public RegisterHandler(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var userDto = _mapper.Map<CreateUserDto>(request);
            await _userService.CreateAsync(userDto);
        }
    }
}