﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Users.Commands
{
    public class RemoveUserCommand
    {
        public string Id { get; set; }

        public RemoveUserCommand(string ıd)
        {
            Id = ıd;
        }
    }
}
