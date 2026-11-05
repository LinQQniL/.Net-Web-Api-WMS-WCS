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
[Migration("20260610123214_InitUserTable")]
public class InitUserTable : Migration
{
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.CreateTable("Users", (ColumnsBuilder table) =>
		{
			OperationBuilder<AddColumnOperation> id = table.Column<int>("integer").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
			int? maxLength = 50;
			OperationBuilder<AddColumnOperation> userName = table.Column<string>("character varying(50)", null, maxLength);
			maxLength = 200;
			OperationBuilder<AddColumnOperation> password = table.Column<string>("character varying(200)", null, maxLength);
			maxLength = 50;
			return new
			{
				Id = id,
				UserName = userName,
				Password = password,
				Name = table.Column<string>("character varying(50)", null, maxLength, rowVersion: false, null, nullable: true),
				CreateTime = table.Column<DateTime>("timestamp with time zone")
			};
		}, null, table =>
		{
			table.PrimaryKey("PK_Users", x => x.Id);
		});
		migrationBuilder.InsertData("Users", new string[5] { "Id", "CreateTime", "Name", "Password", "UserName" }, new object[5]
		{
			1,
			new DateTime(2026, 6, 9, 0, 0, 0, 0, DateTimeKind.Utc),
			"管理员",
			"123456",
			"admin"
		});
		migrationBuilder.CreateIndex("IX_Users_UserName", "Users", "UserName", null, unique: true);
	}

	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropTable("Users");
	}

	protected override void BuildTargetModel(ModelBuilder modelBuilder)
	{
		modelBuilder.HasAnnotation("ProductVersion", "10.0.9").HasAnnotation("Relational:MaxIdentifierLength", 63);
		modelBuilder.UseIdentityByDefaultColumns();
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
				CreateTime = new DateTime(2026, 6, 9, 0, 0, 0, 0, DateTimeKind.Utc),
				Name = "管理员",
				Password = "123456",
				UserName = "admin"
			});
		});
	}
}
