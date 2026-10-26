using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using MiddlewareDemo.Data;

namespace MiddlewareDemo.Migrations;

[DbContext(typeof(AppDbContext))]
[Migration("20260624104400_UpdateMenuPaths")]
public class UpdateMenuPaths : Migration
{
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.UpdateData("Menus", "Id", 2, "Path", "/home/inventory");
		migrationBuilder.UpdateData("Menus", "Id", 3, "Path", "/home/flow");
		migrationBuilder.UpdateData("Menus", "Id", 4, "Path", "/home/system");
		migrationBuilder.UpdateData("Menus", "Id", 5, "Path", "/home/inventory/query");
		migrationBuilder.UpdateData("Menus", "Id", 6, "Path", "/home/inventory/warning");
		migrationBuilder.UpdateData("Menus", "Id", 7, "Path", "/home/inventory/check");
		migrationBuilder.UpdateData("Menus", "Id", 8, "Path", "/home/inbound/list");
		migrationBuilder.UpdateData("Menus", "Id", 9, "Path", "/home/outbound/list");
		migrationBuilder.UpdateData("Menus", "Id", 10, "Path", "/home/flow/record");
		migrationBuilder.UpdateData("Menus", "Id", 11, "Path", "/home/system/users");
		migrationBuilder.UpdateData("Menus", "Id", 12, "Path", "/home/system/roles");
	}

	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.UpdateData("Menus", "Id", 2, "Path", "/inventory");
		migrationBuilder.UpdateData("Menus", "Id", 3, "Path", "/flow");
		migrationBuilder.UpdateData("Menus", "Id", 4, "Path", "/system");
		migrationBuilder.UpdateData("Menus", "Id", 5, "Path", "/inventory/query");
		migrationBuilder.UpdateData("Menus", "Id", 6, "Path", "/inventory/warning");
		migrationBuilder.UpdateData("Menus", "Id", 7, "Path", "/inventory/check");
		migrationBuilder.UpdateData("Menus", "Id", 8, "Path", "/inbound/list");
		migrationBuilder.UpdateData("Menus", "Id", 9, "Path", "/outbound/list");
		migrationBuilder.UpdateData("Menus", "Id", 10, "Path", "/flow/record");
		migrationBuilder.UpdateData("Menus", "Id", 11, "Path", "/system/users");
		migrationBuilder.UpdateData("Menus", "Id", 12, "Path", "/system/roles");
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
				Path = "/home/inventory",
				SortOrder = 2
			}, new
			{
				Id = 3,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "ShoppingCart",
				Name = "出入库管理",
				Path = "/home/flow",
				SortOrder = 3
			}, new
			{
				Id = 4,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Setting",
				Name = "系统管理",
				Path = "/home/system",
				SortOrder = 4
			}, new
			{
				Id = 5,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Box",
				Name = "库存查询",
				ParentId = 2,
				Path = "/home/inventory/query",
				SortOrder = 1
			}, new
			{
				Id = 6,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Goods",
				Name = "库存预警",
				ParentId = 2,
				Path = "/home/inventory/warning",
				SortOrder = 2
			}, new
			{
				Id = 7,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "List",
				Name = "库存盘点",
				ParentId = 2,
				Path = "/home/inventory/check",
				SortOrder = 3
			}, new
			{
				Id = 8,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Download",
				Name = "入库管理",
				ParentId = 3,
				Path = "/home/inbound/list",
				SortOrder = 1
			}, new
			{
				Id = 9,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Upload",
				Name = "出库管理",
				ParentId = 3,
				Path = "/home/outbound/list",
				SortOrder = 2
			}, new
			{
				Id = 10,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Location",
				Name = "出入库记录",
				ParentId = 3,
				Path = "/home/flow/record",
				SortOrder = 3
			}, new
			{
				Id = 11,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "User",
				Name = "用户管理",
				ParentId = 4,
				Path = "/home/system/users",
				SortOrder = 1
			}, new
			{
				Id = 12,
				CreateTime = new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
				Icon = "Avatar",
				Name = "角色管理",
				ParentId = 4,
				Path = "/home/system/roles",
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
