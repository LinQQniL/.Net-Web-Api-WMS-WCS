using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace MiddlewareDemo.Auth;

public class TokenHelper
{
	private readonly JwtSettings _jwtSettings;

	public TokenHelper(IOptions<JwtSettings> jwtSettings)
	{
		_jwtSettings = jwtSettings.Value;
	}

	public string GenerateToken(string userId, string userName)
	{
		Claim[] claims = new Claim[3]
		{
			new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", userId),
			new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", userName),
			new Claim("jti", Guid.NewGuid().ToString())
		};
		SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecurityKey));
		SigningCredentials signingCredentials = new SigningCredentials(key, "HS256");
		string issuer = _jwtSettings.Issuer;
		string audience = _jwtSettings.Audience;
		DateTime? expires = DateTime.UtcNow.AddMinutes(_jwtSettings.ExpireMinutes);
		SigningCredentials signingCredentials2 = signingCredentials;
		JwtSecurityToken token = new JwtSecurityToken(issuer, audience, claims, null, expires, signingCredentials2);
		return new JwtSecurityTokenHandler().WriteToken(token);
	}
}
