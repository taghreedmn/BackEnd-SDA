using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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
        public string GenerateToken()
        {
            var key =new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("Jwt:Key").Value));
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature); 
            var issuer = _config.GetSection("Jwt:Issuer").Value;
            var audience = _config.GetSection("Jwt:Audience").Value;

            var descriptor = new SecurityTokenDescriptor
            {
                Issuer = issuer,
                Audience = audience,
                Expires = DateTime.Now.AddSeconds(10),
                Subject = new ClaimsIdentity(),
                SigningCredentials = signingCredentials 
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(descriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}