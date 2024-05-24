using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.DTOs.User
{
    public record CreateUserDto
    (string FirstName, string LastName, string Email, string Password)
    { }
}
