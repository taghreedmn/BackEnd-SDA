using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace FusionTech.src.Utils
{
    public class TokenUtils
    {
         private readonly IConfiguration _config;
            public TokenUtils(IConfiguration config)
            {
                _config = config; 

            }
        public String GenrateToken()
        {
             var key = new SymmetricSecurityKey (Encoding.UTF8.GetBytes(_config.GetSection("Jwt:key").Value));
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature );

            var issuer = _config.GetSection("Jwt:Issuer").Value;
            var audience = _config.GetSection("Jwt:Audience").Value;
           

            var descriptor = new SecurityTokenDescriptor
            {
                Issuer = issuer,
                Audience = audience,
                Expires = DateTime.Now.AddMinutes(10) ,
                Subject = new ClaimsIdentity(),
                SigningCredentials = signingCredentials,
            };

           var tokenHandler = new JwtSecurityTokenHandler();
           var token = tokenHandler.CreateToken(descriptor);
           return tokenHandler.WriteToken(token);
        }
    }
}