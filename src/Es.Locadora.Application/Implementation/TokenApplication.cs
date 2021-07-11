﻿using Es.Locadora.Application.Interfaces;
using Es.Locadora.Application.Models;
using Es.Locadora.Domain.Core.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Es.Locadora.Application.Implementation
{
    public class TokenApplication : ITokenApplication
    {
        private readonly IEnviromentConfiguration _enviromentConfiguration;

        public TokenApplication(IEnviromentConfiguration enviromentConfiguration)
        {
            _enviromentConfiguration = enviromentConfiguration;
        }

        public string Generate(UserModel user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_enviromentConfiguration.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Username.ToString()),
                    new Claim(ClaimTypes.Role, user.Role.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
