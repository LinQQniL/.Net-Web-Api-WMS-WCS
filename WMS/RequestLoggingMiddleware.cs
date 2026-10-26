using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

public class RequestLoggingMiddleware
{
	private readonly RequestDelegate _next;

	private readonly ILogger<RequestLoggingMiddleware> _logger;

	public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
	{
		_next = next;
		_logger = logger;
	}

	public async Task InvokeAsync(HttpContext context)
	{
		_logger.LogInformation("--> 请求: {Method} {Path}", context.Request.Method, context.Request.Path);
		await _next(context);
		_logger.LogInformation("<-- 响应状态: {StatusCode}", context.Response.StatusCode);
	}
}
