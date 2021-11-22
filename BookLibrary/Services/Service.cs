using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
namespace BookLibrary.Services
{
    public class Service:IService
    {
        public string GenerateToken()
        {
            var claims = new List<Claim>();
            var claim = new Claim(ClaimTypes.NameIdentifier, "1");
            claims.Add(claim);

            var Key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("should not be hacked by buhari"));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256Signature),
                Expires = DateTime.Now.AddDays(2)


            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var t = tokenHandler.WriteToken(token);
            return t;
        }
    }
}
