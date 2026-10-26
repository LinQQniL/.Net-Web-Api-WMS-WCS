using System;
using Microsoft.EntityFrameworkCore;
using MiddlewareDemo.Entities;

namespace MiddlewareDemo.Data;

public class AppDbContext : DbContext
{
	public DbSet<User> Users { get; set; }

	public DbSet<Menu> Menus { get; set; }

	public AppDbContext(DbContextOptions<AppDbContext> options)
		: base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<User>().HasIndex((User u) => u.UserName).IsUnique();
		modelBuilder.Entity<User>().HasData(new User
		{
			Id = 1,
			UserName = "admin",
			Password = "123456",
			Name = "管理员",
			CreateTime = new DateTime(2026, 6, 9)
		});
		DateTime createTime = new DateTime(2026, 6, 24, 0, 0, 0, DateTimeKind.Utc);
		modelBuilder.Entity<Menu>().HasData(new Menu
		{
			Id = 1,
			ParentId = null,
			Name = "首页",
			Path = "/home",
			Icon = "DataBoard",
			SortOrder = 1,
			ComponentName = "Dashboard",
			Show = true,
			KeepAlive = false,
			Close = false,
			State = true,
			Description = "系统首页仪表盘",
			CreateTime = createTime
		}, new Menu
		{
			Id = 2,
			ParentId = null,
			Name = "入库管理",
			Path = "/home/inbound",
			Icon = "Download",
			SortOrder = 2,
			ComponentName = null,
			Show = true,
			KeepAlive = false,
			Close = true,
			State = true,
			Description = "入库业务管理",
			CreateTime = createTime
		}, new Menu
		{
			Id = 3,
			ParentId = null,
			Name = "出库管理",
			Path = "/home/outbound",
			Icon = "Upload",
			SortOrder = 3,
			ComponentName = null,
			Show = true,
			KeepAlive = false,
			Close = true,
			State = true,
			Description = "出库业务管理",
			CreateTime = createTime
		}, new Menu
		{
			Id = 4,
			ParentId = null,
			Name = "库存管理",
			Path = "/home/inventory",
			Icon = "Box",
			SortOrder = 4,
			ComponentName = null,
			Show = true,
			KeepAlive = false,
			Close = true,
			State = true,
			Description = "库存信息管理",
			CreateTime = createTime
		}, new Menu
		{
			Id = 5,
			ParentId = null,
			Name = "调度管理",
			Path = "/home/dispatch",
			Icon = "Van",
			SortOrder = 5,
			ComponentName = null,
			Show = true,
			KeepAlive = false,
			Close = true,
			State = true,
			Description = "物流调度管理",
			CreateTime = createTime
		}, new Menu
		{
			Id = 6,
			ParentId = null,
			Name = "系统管理",
			Path = "/home/system",
			Icon = "Setting",
			SortOrder = 6,
			ComponentName = null,
			Show = true,
			KeepAlive = false,
			Close = true,
			State = true,
			Description = "系统配置管理",
			CreateTime = createTime
		}, new Menu
		{
			Id = 10,
			ParentId = 2,
			Name = "入库单列表",
			Path = "/home/inbound/list",
			Icon = "Document",
			SortOrder = 1,
			ComponentName = "InboundList",
			Show = true,
			KeepAlive = true,
			Close = true,
			State = true,
			Description = "查看和管理入库单",
			CreateTime = createTime
		}, new Menu
		{
			Id = 11,
			ParentId = 2,
			Name = "入库单创建",
			Path = "/home/inbound/create",
			Icon = "Plus",
			SortOrder = 2,
			ComponentName = "InboundCreate",
			Show = true,
			KeepAlive = false,
			Close = true,
			State = true,
			Description = "创建新的入库单",
			CreateTime = createTime
		}, new Menu
		{
			Id = 20,
			ParentId = 3,
			Name = "出库单列表",
			Path = "/home/outbound/list",
			Icon = "Document",
			SortOrder = 1,
			ComponentName = "OutboundList",
			Show = true,
			KeepAlive = true,
			Close = true,
			State = true,
			Description = "查看和管理出库单",
			CreateTime = createTime
		}, new Menu
		{
			Id = 21,
			ParentId = 3,
			Name = "出库单创建",
			Path = "/home/outbound/create",
			Icon = "Plus",
			SortOrder = 2,
			ComponentName = "OutboundCreate",
			Show = true,
			KeepAlive = false,
			Close = true,
			State = true,
			Description = "创建新的出库单",
			CreateTime = createTime
		}, new Menu
		{
			Id = 30,
			ParentId = 4,
			Name = "库存查询",
			Path = "/home/inventory/query",
			Icon = "Search",
			SortOrder = 1,
			ComponentName = "InventoryQuery",
			Show = true,
			KeepAlive = true,
			Close = true,
			State = true,
			Description = "查询库存信息",
			CreateTime = createTime
		}, new Menu
		{
			Id = 31,
			ParentId = 4,
			Name = "库存预警",
			Path = "/home/inventory/warning",
			Icon = "Warning",
			SortOrder = 2,
			ComponentName = "InventoryWarning",
			Show = true,
			KeepAlive = true,
			Close = true,
			State = true,
			Description = "库存预警监控",
			CreateTime = createTime
		}, new Menu
		{
			Id = 32,
			ParentId = 4,
			Name = "库存盘点",
			Path = "/home/inventory/check",
			Icon = "Finished",
			SortOrder = 3,
			ComponentName = "InventoryCheck",
			Show = true,
			KeepAlive = true,
			Close = true,
			State = true,
			Description = "库存盘点管理",
			CreateTime = createTime
		}, new Menu
		{
			Id = 40,
			ParentId = 5,
			Name = "任务分配",
			Path = "/home/dispatch/assign",
			Icon = "Operation",
			SortOrder = 1,
			ComponentName = "DispatchAssign",
			Show = true,
			KeepAlive = true,
			Close = true,
			State = true,
			Description = "调度任务分配",
			CreateTime = createTime
		}, new Menu
		{
			Id = 41,
			ParentId = 5,
			Name = "执行监控",
			Path = "/home/dispatch/monitor",
			Icon = "Monitor",
			SortOrder = 2,
			ComponentName = "DispatchMonitor",
			Show = true,
			KeepAlive = true,
			Close = true,
			State = true,
			Description = "调度执行监控",
			CreateTime = createTime
		}, new Menu
		{
			Id = 50,
			ParentId = 6,
			Name = "用户管理",
			Path = "/home/system/users",
			Icon = "User",
			SortOrder = 1,
			ComponentName = "UserManage",
			Show = true,
			KeepAlive = true,
			Close = true,
			State = true,
			Description = "系统用户管理",
			CreateTime = createTime
		}, new Menu
		{
			Id = 51,
			ParentId = 6,
			Name = "角色管理",
			Path = "/home/system/roles",
			Icon = "Avatar",
			SortOrder = 2,
			ComponentName = "RoleManage",
			Show = true,
			KeepAlive = true,
			Close = true,
			State = true,
			Description = "系统角色管理",
			CreateTime = createTime
		}, new Menu
		{
			Id = 52,
			ParentId = 6,
			Name = "菜单管理",
			Path = "/home/system/menus",
			Icon = "Menu",
			SortOrder = 3,
			ComponentName = "MenuManage",
			Show = true,
			KeepAlive = true,
			Close = true,
			State = true,
			Description = "系统菜单管理",
			CreateTime = createTime
		});
	}
}
