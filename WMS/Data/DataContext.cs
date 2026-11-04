using Microsoft.EntityFrameworkCore;
using WMS.DATA;

namespace MiddlewareDemo.Data;

/// <summary>
/// Web 层数据库上下文。
///
/// 实体与映射统一由 WMS.DATA 层的 <see cref="WmsDbContext"/> 提供，这里只做继承，
/// 保证 Program.cs 里的 AddDbContext&lt;AppDbContext&gt; 注册保持不变。
///
/// 业务开发需要新增表时，请到 WMS.DATA\WmsDbContext.cs 按需添加 DbSet 与映射，
/// 不要在 Web 层重复定义上下文。
///
/// 【关于构造函数参数类型】
/// DbContextOptions&lt;T&gt; 的泛型参数不协变，DbContextOptions&lt;AppDbContext&gt;
/// 无法转换成 DbContextOptions&lt;WmsDbContext&gt;，参数写成 WmsDbContext 会报 CS1503。
/// 这里传 AppDbContext，由基类 WmsDbContext(DbContextOptions) 非泛型重载接住。
/// </summary>
public class AppDbContext : WmsDbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options)
		: base(options)
	{
	}
}
