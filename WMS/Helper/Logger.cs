using System;
using NLog;

namespace MiddlewareDemo.Helper;

public static class Logger
{
	private static NLog.Logger _logger = LogManager.GetCurrentClassLogger();

	public static void Info(string message)
	{
		try
		{
			_logger.Info(message);
		}
		catch
		{
		}
	}

	public static void Debug(string message)
	{
		try
		{
			_logger.Debug(message);
		}
		catch
		{
		}
	}

	public static void Warn(string message)
	{
		try
		{
			_logger.Warn(message);
		}
		catch
		{
		}
	}

	public static void Error(Exception ex)
	{
		try
		{
			_logger.Error(ex);
		}
		catch
		{
		}
	}

	public static void Error(string message, Exception ex)
	{
		try
		{
			_logger.Error(ex, message);
		}
		catch
		{
		}
	}
}
