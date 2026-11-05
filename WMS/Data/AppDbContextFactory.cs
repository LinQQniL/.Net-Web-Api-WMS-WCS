using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MiddlewareDemo.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
	public AppDbContext CreateDbContext(string[] args)
	{
		DbContextOptionsBuilder<AppDbContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
		dbContextOptionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=123456");
		return new AppDbContext(dbContextOptionsBuilder.Options);
	}
}
