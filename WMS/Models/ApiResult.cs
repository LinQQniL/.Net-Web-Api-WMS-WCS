namespace MiddlewareDemo.Models
{
	/// <summary>
	/// 统一 API 响应包装，替代原代码中不存在的 Info()/Error&lt;T&gt;() 基类方法
	/// </summary>
	public class ApiResult<T>
	{
		public bool Success { get; set; }

		public string? Message { get; set; }

		public T? Data { get; set; }

		public static ApiResult<T> Ok(T data, string? message = null)
		{
			return new ApiResult<T>
			{
				Success = true,
				Message = message,
				Data = data
			};
		}

		public static ApiResult<T> Fail(string message)
		{
			return new ApiResult<T>
			{
				Success = false,
				Message = message,
				Data = default
			};
		}
	}
}
