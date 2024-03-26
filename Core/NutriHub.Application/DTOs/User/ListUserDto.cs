using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.DTOs.User
{
    public record ListUserDto
    (string Name, string Surname, string Gender, string Username, string Email);
}
