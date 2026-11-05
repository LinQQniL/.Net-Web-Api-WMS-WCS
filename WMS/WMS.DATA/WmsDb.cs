using System;
using Microsoft.EntityFrameworkCore;
using WMS.DATA.Entities;

namespace WMS.DATA;

/// <summary>
/// 数据访问上下文（WMS.DATA 层）。
///
/// 当前映射登录与菜单权限所需的 5 张表：
///   UserInfo / RoleInfo / MenuInfo / MenuPowerInfo / RoleMenuInfo
///
/// 【主键说明】
/// MenuPowerInfo 与 RoleMenuInfo 原先在库中无主键，EF 只能用 HasNoKey 映射，
/// 导致无法做实体引用比较（报 Cannot translate '==' on keyless entity）。
/// 现已在数据库中补充联合主键：
///   MenuPowerInfo  PRIMARY KEY (MenuId, MenuPowerId)
///   RoleMenuInfo   PRIMARY KEY (RoleId, MenuId, MenuPowerId)
/// 因此这里改用 HasKey 联合主键映射。
///
/// 【按需扩展说明】
/// 完整库结构见 backend\WMS\GeneratedModels\（Scaffold 反向工程产物，122 个实体）。
/// 新增业务表时：
///   1. 从 GeneratedModels 复制对应实体到本项目的 Entities 目录
///   2. 把 namespace 改为 WMS.DATA.Entities
///   3. 在下方加一个 DbSet，并参照 GeneratedContext 的写法补充映射
///
/// 已明确排除：PgStatStatement（pg_stat_statements 系统扩展视图，业务不使用）
/// </summary>
public class WmsDbContext : DbContext
{
	public DbSet<UserInfo> UserInfos { get; set; } = null!;

	public DbSet<RoleInfo> RoleInfos { get; set; } = null!;

	public DbSet<MenuInfo> MenuInfos { get; set; } = null!;

	public DbSet<MenuPowerInfo> MenuPowerInfos { get; set; } = null!;

	public DbSet<RoleMenuInfo> RoleMenuInfos { get; set; } = null!;

	/// <summary>
	/// 使用泛型选项构造，适用于直接 new WmsDbContext(new DbContextOptionsBuilder&lt;WmsDbContext&gt;()...)。
	/// </summary>
	public WmsDbContext(DbContextOptions<WmsDbContext> options)
		: base(options)
	{
	}

	/// <summary>
	/// 使用非泛型基类选项构造。
	///
	/// DbContextOptions&lt;T&gt; 的泛型参数是不变的（invariant），
	/// DbContextOptions&lt;AppDbContext&gt; 无法隐式转成 DbContextOptions&lt;WmsDbContext&gt;。
	/// 派生上下文（AppDbContext）通过这个重载传参，即可避开 CS1503。
	/// </summary>
	public WmsDbContext(DbContextOptions options)
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

		modelBuilder.Entity<MenuPowerInfo>(entity =>
		{
			// 新增的联合主键：(MenuId, MenuPowerId) 组合唯一
			entity.HasKey(e => new { e.MenuId, e.MenuPowerId }).HasName("MenuPowerInfo_pkey");
			entity.ToTable("MenuPowerInfo", tb => tb.HasComment("菜单权限实体"));
			entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
			entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
			entity.Property(e => e.Operates).HasMaxLength(5000);
		});

		modelBuilder.Entity<RoleMenuInfo>(entity =>
		{
			// 新增的联合主键：(RoleId, MenuId, MenuPowerId) 组合唯一
			entity.HasKey(e => new { e.RoleId, e.MenuId, e.MenuPowerId }).HasName("RoleMenuInfo_pkey");
			entity.ToTable("RoleMenuInfo", tb => tb.HasComment("角色菜单实体"));
			entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
			entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
		});
	}
}
