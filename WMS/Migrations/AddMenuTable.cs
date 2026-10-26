using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using MiddlewareDemo.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MiddlewareDemo.Migrations;

[DbContext(typeof(AppDbContext))]
[Migration("20260624103801_AddMenuTable")]
public class AddMenuTable : Migration
{
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.CreateTable("Menus", (ColumnsBuilder table) =>
		{
			OperationBuilder<AddColumnOperation> id = table.Column<int>("integer").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
			OperationBuilder<AddColumnOperation> parentId = table.Column<int>("integer", null, null, rowVersion: false, null, nullable: true);
			int? maxLength = 50;
			OperationBuilder<AddColumnOperation> name = table.Column<string>("character varying(50)", null, maxLength);
			maxLength = 200;
			OperationBuilder<AddColumnOperation> path = table.Column<string>("character varying(200)", null, maxLength);
			maxLength = 50;
			return new
			{
				Id = id,
				ParentId = parentId,
				Name = name,
				Path = path,
				Icon = table.Column<string>("character varying(50)", null, maxLength, rowVersion: false, null, nullable: true),
				SortOrder = table.Column<int>("integer"),
				CreateTime = table.Column<DateTime>("timestamp with time zone")
			};
		}, null, table =>
		{
			table.PrimaryKey("PK_Menus", x => x.Id);
		});
		migrationBuilder.InsertData("Menus", new string[7] { "Id", "CreateTime", "Icon", "Name", "ParentId", "Path", "SortOrder" }, new object[12, 7]
		{
			{
				1,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"DataBoard",
				"首页",
				null,
				"/home",
				1
			},
			{
				2,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"Box",
				"库存管理",
				null,
				"/inventory",
				2
			},
			{
				3,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"ShoppingCart",
				"出入库管理",
				null,
				"/flow",
				3
			},
			{
				4,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"Setting",
				"系统管理",
				null,
				"/system",
				4
			},
			{
				5,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"Box",
				"库存查询",
				2,
				"/inventory/query",
				1
			},
			{
				6,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"Goods",
				"库存预警",
				2,
				"/inventory/warning",
				2
			},
			{
				7,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"List",
				"库存盘点",
				2,
				"/inventory/check",
				3
			},
			{
				8,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"Download",
				"入库管理",
				3,
				"/inbound/list",
				1
			},
			{
				9,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"Upload",
				"出库管理",
				3,
				"/outbound/list",
				2
			},
			{
				10,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"Location",
				"出入库记录",
				3,
				"/flow/record",
				3
			},
			{
				11,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"User",
				"用户管理",
				4,
				"/system/users",
				1
			},
			{
				12,
				new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				"Avatar",
				"角色管理",
				4,
				"/system/roles",
				2
			}
		});
	}

	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropTable("Menus");
	}

	protected override void BuildTargetModel(ModelBuilder modelBuilder)
	{
		modelBuilder.HasAnnotation("ProductVersion", "10.0.9").HasAnnotation("Relational:MaxIdentifierLength", 63);
		modelBuilder.UseIdentityByDefaultColumns();
		modelBuilder.Entity("MiddlewareDemo.Entities.Menu", (EntityTypeBuilder b) =>
		{
			b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("integer");
			b.Property<int>("Id").UseIdentityByDefaultColumn();
			b.Property<DateTime>("CreateTime").HasColumnType("timestamp with time zone");
			b.Property<string>("Icon").HasMaxLength(50).HasColumnType("character varying(50)");
			b.Property<string>("Name").IsRequired().HasMaxLength(50)
				.HasColumnType("character varying(50)");
			b.Property<int?>("ParentId").HasColumnType("integer");
			b.Property<string>("Path").IsRequired().HasMaxLength(200)
				.HasColumnType("character varying(200)");
			b.Property<int>("SortOrder").HasColumnType("integer");
			b.HasKey("Id");
			b.ToTable("Menus");
			b.HasData(new
			{
				Id = 1,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "DataBoard",
				Name = "首页",
				Path = "/home",
				SortOrder = 1
			}, new
			{
				Id = 2,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Box",
				Name = "库存管理",
				Path = "/inventory",
				SortOrder = 2
			}, new
			{
				Id = 3,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "ShoppingCart",
				Name = "出入库管理",
				Path = "/flow",
				SortOrder = 3
			}, new
			{
				Id = 4,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Setting",
				Name = "系统管理",
				Path = "/system",
				SortOrder = 4
			}, new
			{
				Id = 5,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Box",
				Name = "库存查询",
				ParentId = 2,
				Path = "/inventory/query",
				SortOrder = 1
			}, new
			{
				Id = 6,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Goods",
				Name = "库存预警",
				ParentId = 2,
				Path = "/inventory/warning",
				SortOrder = 2
			}, new
			{
				Id = 7,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "List",
				Name = "库存盘点",
				ParentId = 2,
				Path = "/inventory/check",
				SortOrder = 3
			}, new
			{
				Id = 8,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Download",
				Name = "入库管理",
				ParentId = 3,
				Path = "/inbound/list",
				SortOrder = 1
			}, new
			{
				Id = 9,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Upload",
				Name = "出库管理",
				ParentId = 3,
				Path = "/outbound/list",
				SortOrder = 2
			}, new
			{
				Id = 10,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Location",
				Name = "出入库记录",
				ParentId = 3,
				Path = "/flow/record",
				SortOrder = 3
			}, new
			{
				Id = 11,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "User",
				Name = "用户管理",
				ParentId = 4,
				Path = "/system/users",
				SortOrder = 1
			}, new
			{
				Id = 12,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Avatar",
				Name = "角色管理",
				ParentId = 4,
				Path = "/system/roles",
				SortOrder = 2
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
