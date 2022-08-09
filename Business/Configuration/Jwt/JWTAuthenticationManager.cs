using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Jwt
{
    public class JWTAuthenticationManager : IJwtAuthenticationService
    {
        private readonly string _tokenKey;

        public JWTAuthenticationManager(string tokenKey)
        {
            _tokenKey = tokenKey;
        }

        public string Authenticate(string userId, string apartmentInfoId,string role)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim("id",userId),
                        new Claim("role",role),
                        new Claim("apartmentInfoId",apartmentInfoId)
                    }),
                Expires = DateTime.Now.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_tokenKey)), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
