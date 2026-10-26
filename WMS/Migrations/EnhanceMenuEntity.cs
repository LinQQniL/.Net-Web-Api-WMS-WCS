using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using MiddlewareDemo.Data;

namespace MiddlewareDemo.Migrations;

[DbContext(typeof(AppDbContext))]
[Migration("20260625103705_EnhanceMenuEntity")]
public class EnhanceMenuEntity : Migration
{
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DeleteData("Menus", "Id", 7);
		migrationBuilder.DeleteData("Menus", "Id", 8);
		migrationBuilder.DeleteData("Menus", "Id", 9);
		migrationBuilder.DeleteData("Menus", "Id", 12);
		migrationBuilder.AddColumn<bool>("Close", "Menus", "boolean", null, null, rowVersion: false, null, nullable: false, false);
		int? maxLength = 100;
		migrationBuilder.AddColumn<string>("ComponentName", "Menus", "character varying(100)", null, maxLength, rowVersion: false, null, nullable: true);
		maxLength = 200;
		migrationBuilder.AddColumn<string>("Description", "Menus", "character varying(200)", null, maxLength, rowVersion: false, null, nullable: true);
		migrationBuilder.AddColumn<bool>("KeepAlive", "Menus", "boolean", null, null, rowVersion: false, null, nullable: false, false);
		migrationBuilder.AddColumn<bool>("Show", "Menus", "boolean", null, null, rowVersion: false, null, nullable: false, false);
		migrationBuilder.AddColumn<bool>("State", "Menus", "boolean", null, null, rowVersion: false, null, nullable: false, false);
		migrationBuilder.UpdateData("Menus", "Id", 1, new string[6] { "Close", "ComponentName", "Description", "KeepAlive", "Show", "State" }, new object[6] { false, "Dashboard", "系统首页仪表盘", false, true, true });
		migrationBuilder.UpdateData("Menus", "Id", 2, new string[9] { "Close", "ComponentName", "Description", "Icon", "KeepAlive", "Name", "Path", "Show", "State" }, new object[9] { true, null, "入库业务管理", "Download", false, "入库管理", "/home/inbound", true, true });
		migrationBuilder.UpdateData("Menus", "Id", 3, new string[9] { "Close", "ComponentName", "Description", "Icon", "KeepAlive", "Name", "Path", "Show", "State" }, new object[9] { true, null, "出库业务管理", "Upload", false, "出库管理", "/home/outbound", true, true });
		migrationBuilder.UpdateData("Menus", "Id", 4, new string[9] { "Close", "ComponentName", "Description", "Icon", "KeepAlive", "Name", "Path", "Show", "State" }, new object[9] { true, null, "库存信息管理", "Box", false, "库存管理", "/home/inventory", true, true });
		migrationBuilder.UpdateData("Menus", "Id", 5, new string[11]
		{
			"Close", "ComponentName", "Description", "Icon", "KeepAlive", "Name", "ParentId", "Path", "Show", "SortOrder",
			"State"
		}, new object[11]
		{
			true, null, "物流调度管理", "Van", false, "调度管理", null, "/home/dispatch", true, 5,
			true
		});
		migrationBuilder.UpdateData("Menus", "Id", 6, new string[11]
		{
			"Close", "ComponentName", "Description", "Icon", "KeepAlive", "Name", "ParentId", "Path", "Show", "SortOrder",
			"State"
		}, new object[11]
		{
			true, null, "系统配置管理", "Setting", false, "系统管理", null, "/home/system", true, 6,
			true
		});
		migrationBuilder.UpdateData("Menus", "Id", 10, new string[11]
		{
			"Close", "ComponentName", "Description", "Icon", "KeepAlive", "Name", "ParentId", "Path", "Show", "SortOrder",
			"State"
		}, new object[11]
		{
			true, "InboundList", "查看和管理入库单", "Document", true, "入库单列表", 2, "/home/inbound/list", true, 1,
			true
		});
		migrationBuilder.UpdateData("Menus", "Id", 11, new string[11]
		{
			"Close", "ComponentName", "Description", "Icon", "KeepAlive", "Name", "ParentId", "Path", "Show", "SortOrder",
			"State"
		}, new object[11]
		{
			true, "InboundCreate", "创建新的入库单", "Plus", false, "入库单创建", 2, "/home/inbound/create", true, 2,
			true
		});
		migrationBuilder.InsertData("Menus", new string[13]
		{
			"Id", "Close", "ComponentName", "CreateTime", "Description", "Icon", "KeepAlive", "Name", "ParentId", "Path",
			"Show", "SortOrder", "State"
		}, new object[10, 13]
		{
			{
				20,
				true,
				"OutboundList",
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"查看和管理出库单",
				"Document",
				true,
				"出库单列表",
				3,
				"/home/outbound/list",
				true,
				1,
				true
			},
			{
				21,
				true,
				"OutboundCreate",
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"创建新的出库单",
				"Plus",
				false,
				"出库单创建",
				3,
				"/home/outbound/create",
				true,
				2,
				true
			},
			{
				30,
				true,
				"InventoryQuery",
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"查询库存信息",
				"Search",
				true,
				"库存查询",
				4,
				"/home/inventory/query",
				true,
				1,
				true
			},
			{
				31,
				true,
				"InventoryWarning",
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"库存预警监控",
				"Warning",
				true,
				"库存预警",
				4,
				"/home/inventory/warning",
				true,
				2,
				true
			},
			{
				32,
				true,
				"InventoryCheck",
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"库存盘点管理",
				"Finished",
				true,
				"库存盘点",
				4,
				"/home/inventory/check",
				true,
				3,
				true
			},
			{
				40,
				true,
				"DispatchAssign",
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"调度任务分配",
				"Operation",
				true,
				"任务分配",
				5,
				"/home/dispatch/assign",
				true,
				1,
				true
			},
			{
				41,
				true,
				"DispatchMonitor",
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"调度执行监控",
				"Monitor",
				true,
				"执行监控",
				5,
				"/home/dispatch/monitor",
				true,
				2,
				true
			},
			{
				50,
				true,
				"UserManage",
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"系统用户管理",
				"User",
				true,
				"用户管理",
				6,
				"/home/system/users",
				true,
				1,
				true
			},
			{
				51,
				true,
				"RoleManage",
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"系统角色管理",
				"Avatar",
				true,
				"角色管理",
				6,
				"/home/system/roles",
				true,
				2,
				true
			},
			{
				52,
				true,
				"MenuManage",
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"系统菜单管理",
				"Menu",
				true,
				"菜单管理",
				6,
				"/home/system/menus",
				true,
				3,
				true
			}
		});
	}

	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DeleteData("Menus", "Id", 20);
		migrationBuilder.DeleteData("Menus", "Id", 21);
		migrationBuilder.DeleteData("Menus", "Id", 30);
		migrationBuilder.DeleteData("Menus", "Id", 31);
		migrationBuilder.DeleteData("Menus", "Id", 32);
		migrationBuilder.DeleteData("Menus", "Id", 40);
		migrationBuilder.DeleteData("Menus", "Id", 41);
		migrationBuilder.DeleteData("Menus", "Id", 50);
		migrationBuilder.DeleteData("Menus", "Id", 51);
		migrationBuilder.DeleteData("Menus", "Id", 52);
		migrationBuilder.DropColumn("Close", "Menus");
		migrationBuilder.DropColumn("ComponentName", "Menus");
		migrationBuilder.DropColumn("Description", "Menus");
		migrationBuilder.DropColumn("KeepAlive", "Menus");
		migrationBuilder.DropColumn("Show", "Menus");
		migrationBuilder.DropColumn("State", "Menus");
		migrationBuilder.UpdateData("Menus", "Id", 2, new string[3] { "Icon", "Name", "Path" }, new object[3] { "Box", "库存管理", "/home/inventory" });
		migrationBuilder.UpdateData("Menus", "Id", 3, new string[3] { "Icon", "Name", "Path" }, new object[3] { "ShoppingCart", "出入库管理", "/home/flow" });
		migrationBuilder.UpdateData("Menus", "Id", 4, new string[3] { "Icon", "Name", "Path" }, new object[3] { "Setting", "系统管理", "/home/system" });
		migrationBuilder.UpdateData("Menus", "Id", 5, new string[5] { "Icon", "Name", "ParentId", "Path", "SortOrder" }, new object[5] { "Box", "库存查询", 2, "/home/inventory/query", 1 });
		migrationBuilder.UpdateData("Menus", "Id", 6, new string[5] { "Icon", "Name", "ParentId", "Path", "SortOrder" }, new object[5] { "Goods", "库存预警", 2, "/home/inventory/warning", 2 });
		migrationBuilder.UpdateData("Menus", "Id", 10, new string[5] { "Icon", "Name", "ParentId", "Path", "SortOrder" }, new object[5] { "Location", "出入库记录", 3, "/home/flow/record", 3 });
		migrationBuilder.UpdateData("Menus", "Id", 11, new string[5] { "Icon", "Name", "ParentId", "Path", "SortOrder" }, new object[5] { "User", "用户管理", 4, "/home/system/users", 1 });
		migrationBuilder.InsertData("Menus", new string[7] { "Id", "CreateTime", "Icon", "Name", "ParentId", "Path", "SortOrder" }, new object[4, 7]
		{
			{
				7,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"List",
				"库存盘点",
				2,
				"/home/inventory/check",
				3
			},
			{
				8,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"Download",
				"入库管理",
				3,
				"/home/inbound/list",
				1
			},
			{
				9,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"Upload",
				"出库管理",
				3,
				"/home/outbound/list",
				2
			},
			{
				12,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"Avatar",
				"角色管理",
				4,
				"/home/system/roles",
				2
			}
		});
	}

	protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
			b.Property<string>("Name").IsRequired().HasMaxLength(50)
				.HasColumnType("character varying(50)");
			b.Property<int?>("ParentId").HasColumnType("integer");
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
			b.Property<string>("Name").HasMaxLength(50).HasColumnType("character varying(50)");
			b.Property<string>("Password").IsRequired().HasMaxLength(200)
				.HasColumnType("character varying(200)");
			b.Property<string>("UserName").IsRequired().HasMaxLength(50)
				.HasColumnType("character varying(50)");
			b.HasKey("Id");
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
	}
}
