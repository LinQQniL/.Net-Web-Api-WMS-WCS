using System.Collections.Generic;

namespace MiddlewareDemo.Models
{
    /// <summary>
    /// 用户菜单权限聚合结果：用户信息 + 角色信息 + 树状菜单 + 扁平权限列表
    /// </summary>
    public class ResultUserMenuDto
    {
        /// <summary>用户显示名</summary>
        public string? Name { get; set; }

        /// <summary>登录账号</summary>
        public string? UserName { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        /// <summary>角色编码</summary>
        public string? RoleCode { get; set; }

        /// <summary>角色名称</summary>
        public string? RoleName { get; set; }

        /// <summary>树状菜单（一级 + children）</summary>
        public List<MenusDto> Menus { get; set; } = new();

        /// <summary>扁平权限列表，前端据此控制按钮显隐</summary>
        public List<MenuPowerDto> MenuPowers { get; set; } = new();
    }
}
