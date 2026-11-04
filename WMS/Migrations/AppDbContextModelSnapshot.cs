using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiddlewareDemo.Data;

namespace MiddlewareDemo.Migrations;

[DbContext(typeof(AppDbContext))]
internal class AppDbContextModelSnapshot : ModelSnapshot
{
	protected override void BuildModel(ModelBuilder modelBuilder)
	{
		modelBuilder.HasAnnotation("ProductVersion", "10.0.9").HasAnnotation("Relational:MaxIdentifierLength", 63);
		modelBuilder.UseIdentityByDefaultColumns();
		modelBuilder.Entity("MiddlewareDemo.Entities.Menu", (EntityTypeBuilder b) =>
		{
			b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("integer");
			b.Property<int>("Id").UseIdentityByDefaultColumn();
			b.Property<bool>("Close").HasColumnType("boolean");
			b.Property<string>("ComponentName").HasMaxLength(100).HasColumnType("character varying(100)");
			b.Property<DateTime>("CreateTime").HasColumnType("timestamp with time zone");
			b.Property<string>("Description").HasMaxLength(200).HasColumnType("character varying(200)");
			b.Property<string>("Icon").HasMaxLength(50).HasColumnType("character varying(50)");
			b.Property<bool>("KeepAlive").HasColumnType("boolean");
			b.Property<string>("LevelCode").HasMaxLength(50).HasColumnType("character varying(50)");
			b.Property<string>("Name").IsRequired().HasMaxLength(50)
				.HasColumnType("character varying(50)");
			b.Property<int?>("ParentId").HasColumnType("integer");
			b.Property<string>("ParentName").HasMaxLength(50).HasColumnType("character varying(50)");
			b.Property<string>("Path").IsRequired().HasMaxLength(200)
				.HasColumnType("character varying(200)");
			b.Property<bool>("Show").HasColumnType("boolean");
			b.Property<int>("SortOrder").HasColumnType("integer");
			b.Property<bool>("State").HasColumnType("boolean");
			b.HasKey("Id");
			b.ToTable("Menus");
			b.HasData(new
			{
				Id = 1,
				Close = false,
				ComponentName = "Dashboard",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "系统首页仪表盘",
				Icon = "DataBoard",
				KeepAlive = false,
				Name = "首页",
				Path = "/home",
				Show = true,
				SortOrder = 1,
				State = true
			}, new
			{
				Id = 2,
				Close = true,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "入库业务管理",
				Icon = "Download",
				KeepAlive = false,
				Name = "入库管理",
				Path = "/home/inbound",
				Show = true,
				SortOrder = 2,
				State = true
			}, new
			{
				Id = 3,
				Close = true,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "出库业务管理",
				Icon = "Upload",
				KeepAlive = false,
				Name = "出库管理",
				Path = "/home/outbound",
				Show = true,
				SortOrder = 3,
				State = true
			}, new
			{
				Id = 4,
				Close = true,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "库存信息管理",
				Icon = "Box",
				KeepAlive = false,
				Name = "库存管理",
				Path = "/home/inventory",
				Show = true,
				SortOrder = 4,
				State = true
			}, new
			{
				Id = 5,
				Close = true,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "物流调度管理",
				Icon = "Van",
				KeepAlive = false,
				Name = "调度管理",
				Path = "/home/dispatch",
				Show = true,
				SortOrder = 5,
				State = true
			}, new
			{
				Id = 6,
				Close = true,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "系统配置管理",
				Icon = "Setting",
				KeepAlive = false,
				Name = "系统管理",
				Path = "/home/system",
				Show = true,
				SortOrder = 6,
				State = true
			}, new
			{
				Id = 10,
				Close = true,
				ComponentName = "InboundList",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "查看和管理入库单",
				Icon = "Document",
				KeepAlive = true,
				Name = "入库单列表",
				ParentId = 2,
				Path = "/home/inbound/list",
				Show = true,
				SortOrder = 1,
				State = true
			}, new
			{
				Id = 11,
				Close = true,
				ComponentName = "InboundCreate",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "创建新的入库单",
				Icon = "Plus",
				KeepAlive = false,
				Name = "入库单创建",
				ParentId = 2,
				Path = "/home/inbound/create",
				Show = true,
				SortOrder = 2,
				State = true
			}, new
			{
				Id = 20,
				Close = true,
				ComponentName = "OutboundList",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "查看和管理出库单",
				Icon = "Document",
				KeepAlive = true,
				Name = "出库单列表",
				ParentId = 3,
				Path = "/home/outbound/list",
				Show = true,
				SortOrder = 1,
				State = true
			}, new
			{
				Id = 21,
				Close = true,
				ComponentName = "OutboundCreate",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "创建新的出库单",
				Icon = "Plus",
				KeepAlive = false,
				Name = "出库单创建",
				ParentId = 3,
				Path = "/home/outbound/create",
				Show = true,
				SortOrder = 2,
				State = true
			}, new
			{
				Id = 30,
				Close = true,
				ComponentName = "InventoryQuery",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "查询库存信息",
				Icon = "Search",
				KeepAlive = true,
				Name = "库存查询",
				ParentId = 4,
				Path = "/home/inventory/query",
				Show = true,
				SortOrder = 1,
				State = true
			}, new
			{
				Id = 31,
				Close = true,
				ComponentName = "InventoryWarning",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "库存预警监控",
				Icon = "Warning",
				KeepAlive = true,
				Name = "库存预警",
				ParentId = 4,
				Path = "/home/inventory/warning",
				Show = true,
				SortOrder = 2,
				State = true
			}, new
			{
				Id = 32,
				Close = true,
				ComponentName = "InventoryCheck",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "库存盘点管理",
				Icon = "Finished",
				KeepAlive = true,
				Name = "库存盘点",
				ParentId = 4,
				Path = "/home/inventory/check",
				Show = true,
				SortOrder = 3,
				State = true
			}, new
			{
				Id = 40,
				Close = true,
				ComponentName = "DispatchAssign",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "调度任务分配",
				Icon = "Operation",
				KeepAlive = true,
				Name = "任务分配",
				ParentId = 5,
				Path = "/home/dispatch/assign",
				Show = true,
				SortOrder = 1,
				State = true
			}, new
			{
				Id = 41,
				Close = true,
				ComponentName = "DispatchMonitor",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "调度执行监控",
				Icon = "Monitor",
				KeepAlive = true,
				Name = "执行监控",
				ParentId = 5,
				Path = "/home/dispatch/monitor",
				Show = true,
				SortOrder = 2,
				State = true
			}, new
			{
				Id = 50,
				Close = true,
				ComponentName = "UserManage",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "系统用户管理",
				Icon = "User",
				KeepAlive = true,
				Name = "用户管理",
				ParentId = 6,
				Path = "/home/system/users",
				Show = true,
				SortOrder = 1,
				State = true
			}, new
			{
				Id = 51,
				Close = true,
				ComponentName = "RoleManage",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "系统角色管理",
				Icon = "Avatar",
				KeepAlive = true,
				Name = "角色管理",
				ParentId = 6,
				Path = "/home/system/roles",
				Show = true,
				SortOrder = 2,
				State = true
			}, new
			{
				Id = 52,
				Close = true,
				ComponentName = "MenuManage",
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Description = "系统菜单管理",
				Icon = "Menu",
				KeepAlive = true,
				Name = "菜单管理",
				ParentId = 6,
				Path = "/home/system/menus",
				Show = true,
				SortOrder = 3,
				State = true
			});
		});
		modelBuilder.Entity("MiddlewareDemo.Entities.User", (EntityTypeBuilder b) =>
		{
			b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("integer");
			b.Property<int>("Id").UseIdentityByDefaultColumn();
			b.Property<DateTime>("CreateTime").HasColumnType("timestamp with time zone");
			b.Property<string>("Email").HasMaxLength(100).HasColumnType("character varying(100)");
			b.Property<string>("Name").HasMaxLength(50).HasColumnType("character varying(50)");
			b.Property<string>("Password").IsRequired().HasMaxLength(200)
				.HasColumnType("character varying(200)");
			b.Property<string>("Phone").HasMaxLength(20).HasColumnType("character varying(20)");
			b.Property<int?>("RoleId").HasColumnType("integer");
			b.Property<bool>("State").HasColumnType("boolean");
			b.Property<string>("UserName").IsRequired().HasMaxLength(50)
				.HasColumnType("character varying(50)");
			b.HasKey("Id");
			b.HasIndex("RoleId");
			b.HasIndex("UserName").IsUnique();
			b.ToTable("Users");
			b.HasData(new
			{
				Id = 1,
				CreateTime = new DateTime(2026, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
				Name = "管理员",
				Password = "123456",
				UserName = "admin"
			});
		});

		// ---- 角色权限体系（AddRoleMenuPermission 迁移新增）----
		modelBuilder.Entity("MiddlewareDemo.Entities.Role", (EntityTypeBuilder b) =>
		{
			b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("integer");
			b.Property<int>("Id").UseIdentityByDefaultColumn();
			b.Property<string>("Code").IsRequired().HasMaxLength(50).HasColumnType("character varying(50)");
			b.Property<string>("Name").IsRequired().HasMaxLength(50).HasColumnType("character varying(50)");
			b.Property<string>("Description").HasMaxLength(200).HasColumnType("character varying(200)");
			b.Property<bool>("State").HasColumnType("boolean");
			b.Property<DateTime>("CreateTime").HasColumnType("timestamp with time zone");
			b.HasKey("Id");
			b.HasIndex("Code").IsUnique();
			b.ToTable("Roles");
		});

		modelBuilder.Entity("MiddlewareDemo.Entities.RoleMenu", (EntityTypeBuilder b) =>
		{
			b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("integer");
			b.Property<int>("Id").UseIdentityByDefaultColumn();
			b.Property<int>("RoleId").HasColumnType("integer");
			b.Property<int>("MenuId").HasColumnType("integer");
			b.Property<bool>("Display").HasColumnType("boolean");
			b.Property<bool>("Insert").HasColumnType("boolean");
			b.Property<bool>("Update").HasColumnType("boolean");
			b.Property<bool>("Delete").HasColumnType("boolean");
			b.Property<bool>("Save").HasColumnType("boolean");
			b.Property<bool>("Search").HasColumnType("boolean");
			b.Property<bool>("Export").HasColumnType("boolean");
			b.Property<bool>("Print").HasColumnType("boolean");
			b.Property<bool>("Import").HasColumnType("boolean");
			b.Property<string>("Operates").HasMaxLength(500).HasColumnType("character varying(500)");
			b.Property<DateTime>("CreateTime").HasColumnType("timestamp with time zone");
			b.HasKey("Id");
			b.HasIndex("MenuId");
			b.HasIndex("RoleId", "MenuId").IsUnique();
			b.ToTable("RoleMenus");
		});

		modelBuilder.Entity("MiddlewareDemo.Entities.MenuPower", (EntityTypeBuilder b) =>
		{
			b.Property<int>("MenuPowerId").ValueGeneratedOnAdd().HasColumnType("integer");
			b.Property<int>("MenuPowerId").UseIdentityByDefaultColumn();
			b.Property<int>("MenuId").HasColumnType("integer");
			b.Property<string>("Code").IsRequired().HasMaxLength(50).HasColumnType("character varying(50)");
			b.Property<string>("Name").IsRequired().HasMaxLength(50).HasColumnType("character varying(50)");
			b.Property<string>("Description").HasMaxLength(200).HasColumnType("character varying(200)");
			b.Property<int>("SortOrder").HasColumnType("integer");
			b.Property<DateTime>("CreateTime").HasColumnType("timestamp with time zone");
			b.HasKey("MenuPowerId");
			b.HasIndex("MenuId");
			b.ToTable("MenuPowers");
		});
	}
}
