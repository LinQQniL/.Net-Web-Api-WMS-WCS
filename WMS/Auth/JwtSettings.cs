namespace MiddlewareDemo.Auth;

public class JwtSettings
{
	public string SecurityKey { get; set; } = "ThisIsASecretKeyForDemo123456789!";

	public string Issuer { get; set; } = "MiddlewareDemo";

	public string Audience { get; set; } = "MiddlewareDemo";

	public int ExpireMinutes { get; set; } = 60;
}
