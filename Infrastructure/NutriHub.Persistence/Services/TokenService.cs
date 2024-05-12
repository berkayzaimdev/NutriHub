using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        private User _user;
        private List<Claim> _claims;
        private SigningCredentials _creds;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateToken(User user)
        {
            _user = user;
            _claims = GetClaims();
            _creds = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:secretKey"])),SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = GetTokenDescriptor();

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        private List<Claim> GetClaims() 
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, _user.Id),
                new Claim(JwtRegisteredClaimNames.Email, _user.Email),
                new Claim(JwtRegisteredClaimNames.GivenName, _user.UserName)
            };

            return claims;
        }

        private SecurityTokenDescriptor GetTokenDescriptor() 
        {
            return new() {
                Subject = new ClaimsIdentity(_claims),
                Expires = DateTime.Now.AddHours(20),
                SigningCredentials = _creds,
                Issuer = _configuration["JwtSettings:validIssuer"],
                Audience = _configuration["JwtSettings:validAudience"]
            };
        }
    }
}
