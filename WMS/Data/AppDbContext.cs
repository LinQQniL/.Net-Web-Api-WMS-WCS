using System;
using Microsoft.EntityFrameworkCore;
using MiddlewareDemo.Entities;

namespace MiddlewareDemo.Data;

/// <summary>
/// 业务数据库上下文。
///
/// 映射到项目中实际存在的 PostgreSQL 表（由 Scaffold 反向工程确认）：
///   UserInfo / RoleInfo / MenuInfo / MenuPowerInfo / RoleMenuInfo
///
/// 主键统一为 string（长度 36 的 GUID），MenuPowerInfo 与 RoleMenuInfo 无主键。
/// 只映射登录与菜单权限所需的最小表集合，其余 117 张业务表暂不纳入，
/// 需要时再逐步加入，避免一次性引入过多无关模型拖慢启动。
/// </summary>
public class AppDbContext : DbContext
{
	public DbSet<UserInfo> UserInfos { get; set; } = null!;

	public DbSet<RoleInfo> RoleInfos { get; set; } = null!;

	public DbSet<MenuInfo> MenuInfos { get; set; } = null!;

	public DbSet<MenuPowerInfo> MenuPowerInfos { get; set; } = null!;

	public DbSet<RoleMenuInfo> RoleMenuInfos { get; set; } = null!;

	public AppDbContext(DbContextOptions<AppDbContext> options)
		: base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<UserInfo>(entity =>
		{
			entity.HasKey(e => e.UserId).HasName("UserInfo_pkey");
			entity.ToTable("UserInfo");
			entity.Property(e => e.CreateTime).HasColumnType("timestamp without time zone");
			entity.Property(e => e.LastLoginTime).HasColumnType("timestamp without time zone");
			entity.Property(e => e.UpdateTime).HasColumnType("timestamp without time zone");
		});

		modelBuilder.Entity<RoleInfo>(entity =>
		{
			entity.HasKey(e => e.RoleId).HasName("RoleInfo_pkey");
			entity.ToTable("RoleInfo", tb => tb.HasComment("角色信息表"));
			entity.Property(e => e.CreateTime).HasColumnType("timestamp without time zone");
			entity.Property(e => e.UpdateTime).HasColumnType("timestamp without time zone");
		});

		modelBuilder.Entity<MenuInfo>(entity =>
		{
			entity.HasKey(e => e.MenuId).HasName("MenuInfo_pkey");
			entity.ToTable("MenuInfo", tb => tb.HasComment("菜单按钮"));
			entity.Property(e => e.CreateTime).HasColumnType("timestamp without time zone");
			entity.Property(e => e.UpdateTime).HasColumnType("timestamp without time zone");
		});

		// 这两张表在你的库里没有主键，EF 必须用 HasNoKey 映射
		modelBuilder.Entity<MenuPowerInfo>(entity =>
		{
			entity.HasNoKey();
			entity.ToTable("MenuPowerInfo", tb => tb.HasComment("菜单权限实体"));
			entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
			entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
			entity.Property(e => e.Operates).HasMaxLength(5000);
		});

		modelBuilder.Entity<RoleMenuInfo>(entity =>
		{
			entity.HasNoKey();
			entity.ToTable("RoleMenuInfo", tb => tb.HasComment("角色菜单实体"));
			entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
			entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
		});
	}
}
