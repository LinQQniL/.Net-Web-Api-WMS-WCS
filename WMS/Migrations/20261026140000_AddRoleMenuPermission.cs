using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using MiddlewareDemo.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MiddlewareDemo.Migrations;

/// <summary>
/// 新增角色权限体系：Roles、RoleMenus、MenuPowers 三张表，
/// 并给 Users 补 RoleId/Phone/Email/State，给 Menus 补 LevelCode/ParentName。
/// </summary>
[DbContext(typeof(AppDbContext))]
[Migration("20261026140000_AddRoleMenuPermission")]
public class AddRoleMenuPermission : Migration
{
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		// ---------- Roles ----------
		migrationBuilder.CreateTable(
			name: "Roles",
			columns: table => new
			{
				Id = table.Column<int>(type: "integer", nullable: false)
					.Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
				Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
				Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
				Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
				State = table.Column<bool>(type: "boolean", nullable: false),
				CreateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_Roles", x => x.Id);
			});

		migrationBuilder.CreateIndex(name: "IX_Roles_Code", table: "Roles", column: "Code", unique: true);

		// ---------- Users 扩展列 ----------
		migrationBuilder.AddColumn<int>(name: "RoleId", table: "Users", type: "integer", nullable: true);
		migrationBuilder.AddColumn<string>(name: "Phone", table: "Users", type: "character varying(20)", maxLength: 20, nullable: true);
		migrationBuilder.AddColumn<string>(name: "Email", table: "Users", type: "character varying(100)", maxLength: 100, nullable: true);
		migrationBuilder.AddColumn<bool>(name: "State", table: "Users", type: "boolean", nullable: false, defaultValue: true);
		migrationBuilder.CreateIndex(name: "IX_Users_RoleId", table: "Users", column: "RoleId");
		migrationBuilder.AddForeignKey(
			name: "FK_Users_Roles_RoleId",
			table: "Users",
			column: "RoleId",
			principalTable: "Roles",
			principalColumn: "Id",
			onDelete: ReferentialAction.SetNull);

		// ---------- Menus 扩展列 ----------
		migrationBuilder.AddColumn<string>(name: "LevelCode", table: "Menus", type: "character varying(50)", maxLength: 50, nullable: true);
		migrationBuilder.AddColumn<string>(name: "ParentName", table: "Menus", type: "character varying(50)", maxLength: 50, nullable: true);

		// 回填既有菜单的层级编码
		migrationBuilder.Sql(@"UPDATE ""Menus"" SET ""LevelCode"" = ""Id""::text WHERE ""ParentId"" IS NULL;");
		migrationBuilder.Sql(@"UPDATE ""c"" SET ""LevelCode"" = p.""LevelCode"" || '.' || ""c"".""SortOrder""::text,
       ""ParentName"" = p.""Name""
FROM ""Menus"" c
JOIN ""Menus"" p ON p.""Id"" = c.""ParentId""
WHERE c.""ParentId"" IS NOT NULL;");

		// ---------- RoleMenus ----------
		migrationBuilder.CreateTable(
			name: "RoleMenus",
			columns: table => new
			{
				Id = table.Column<int>(type: "integer", nullable: false)
					.Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
				RoleId = table.Column<int>(type: "integer", nullable: false),
				MenuId = table.Column<int>(type: "integer", nullable: false),
				Display = table.Column<bool>(type: "boolean", nullable: false),
				Insert = table.Column<bool>(type: "boolean", nullable: false),
				Update = table.Column<bool>(type: "boolean", nullable: false),
				Delete = table.Column<bool>(type: "boolean", nullable: false),
				Save = table.Column<bool>(type: "boolean", nullable: false),
				Search = table.Column<bool>(type: "boolean", nullable: false),
				Export = table.Column<bool>(type: "boolean", nullable: false),
				Print = table.Column<bool>(type: "boolean", nullable: false),
				Import = table.Column<bool>(type: "boolean", nullable: false),
				Operates = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
				CreateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_RoleMenus", x => x.Id);
				table.ForeignKey(
					name: "FK_RoleMenus_Roles_RoleId",
					column: x => x.RoleId,
					principalTable: "Roles",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
				table.ForeignKey(
					name: "FK_RoleMenus_Menus_MenuId",
					column: x => x.MenuId,
					principalTable: "Menus",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateIndex(name: "IX_RoleMenus_RoleId_MenuId", table: "RoleMenus", columns: new[] { "RoleId", "MenuId" }, unique: true);
		migrationBuilder.CreateIndex(name: "IX_RoleMenus_MenuId", table: "RoleMenus", column: "MenuId");

		// ---------- MenuPowers ----------
		migrationBuilder.CreateTable(
			name: "MenuPowers",
			columns: table => new
			{
				MenuPowerId = table.Column<int>(type: "integer", nullable: false)
					.Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
				MenuId = table.Column<int>(type: "integer", nullable: false),
				Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
				Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
				Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
				SortOrder = table.Column<int>(type: "integer", nullable: false),
				CreateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_MenuPowers", x => x.MenuPowerId);
				table.ForeignKey(
					name: "FK_MenuPowers_Menus_MenuId",
					column: x => x.MenuId,
					principalTable: "Menus",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateIndex(name: "IX_MenuPowers_MenuId", table: "MenuPowers", column: "MenuId");

		// ---------- 初始角色数据 ----------
		migrationBuilder.InsertData(
			table: "Roles",
			columns: new[] { "Id", "Code", "CreateTime", "Description", "Name", "State" },
			values: new object[,]
			{
				{ 1, "Admin", new DateTime(2026, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "拥有全部菜单与操作权限", "超级管理员", true },
				{ 2, "Warehouse", new DateTime(2026, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "只负责入库、出库与库存操作", "仓库作业员", true }
			});

		// 管理员账号挂到超级管理员角色
		migrationBuilder.Sql(@"UPDATE ""Users"" SET ""RoleId"" = 1 WHERE ""UserName"" = 'admin';");

		// ---------- 超级管理员：授权全部菜单 ----------
		migrationBuilder.Sql(@"
INSERT INTO ""RoleMenus"" (""RoleId"", ""MenuId"", ""Display"", ""Insert"", ""Update"", ""Delete"", ""Save"", ""Search"", ""Export"", ""Print"", ""Import"", ""CreateTime"")
SELECT 1, m.""Id"", true, true, true, true, true, true, true, true, true, (now() AT TIME ZONE 'UTC')
FROM ""Menus"" m
ON CONFLICT DO NOTHING;");

		// ---------- 仓库作业员：仅业务菜单 ----------
		migrationBuilder.Sql(@"
INSERT INTO ""RoleMenus"" (""RoleId"", ""MenuId"", ""Display"", ""Insert"", ""Update"", ""Delete"", ""Save"", ""Search"", ""Export"", ""Print"", ""Import"", ""CreateTime"")
SELECT 2, m.""Id"", true, true, true, false, true, true, true, false, false, (now() AT TIME ZONE 'UTC')
FROM ""Menus"" m
WHERE m.""Id"" IN (1, 2, 3, 4, 10, 11, 20, 21, 30, 31, 32)
ON CONFLICT DO NOTHING;");

		// ---------- 每个菜单的权限点字典 ----------
		migrationBuilder.Sql(@"
INSERT INTO ""MenuPowers"" (""MenuId"", ""Code"", ""Name"", ""SortOrder"", ""CreateTime"")
SELECT m.""Id"", p.code, p.name, p.sort_order, (now() AT TIME ZONE 'UTC')
FROM ""Menus"" m
CROSS JOIN (VALUES
    ('view',   '查看', 1),
    ('insert', '新增', 2),
    ('update', '修改', 3),
    ('delete', '删除', 4),
    ('export', '导出', 5),
    ('import', '导入', 6)
) AS p(code, name, sort_order);");
	}

	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropTable(name: "MenuPowers");
		migrationBuilder.DropTable(name: "RoleMenus");
		migrationBuilder.DropForeignKey(name: "FK_Users_Roles_RoleId", table: "Users");
		migrationBuilder.DropIndex(name: "IX_Users_RoleId", table: "Users");
		migrationBuilder.DropColumn(name: "RoleId", table: "Users");
		migrationBuilder.DropColumn(name: "Phone", table: "Users");
		migrationBuilder.DropColumn(name: "Email", table: "Users");
		migrationBuilder.DropColumn(name: "State", table: "Users");
		migrationBuilder.DropColumn(name: "LevelCode", table: "Menus");
		migrationBuilder.DropColumn(name: "ParentName", table: "Menus");
		migrationBuilder.DropTable(name: "Roles");
	}
}
