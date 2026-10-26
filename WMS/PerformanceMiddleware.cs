using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

public class PerformanceMiddleware
{
	private readonly RequestDelegate _next;

	private readonly ILogger<PerformanceMiddleware> _logger;

	public PerformanceMiddleware(RequestDelegate next, ILogger<PerformanceMiddleware> logger)
	{
		_next = next;
		_logger = logger;
	}

	public async Task InvokeAsync(HttpContext context)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		await _next(context);
		stopwatch.Stop();
		_logger.LogInformation("性能: {Path} 耗时 {ElapsedMilliseconds} ms", context.Request.Path, stopwatch.ElapsedMilliseconds);
	}
}
