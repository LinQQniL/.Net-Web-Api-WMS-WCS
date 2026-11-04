using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class UserInfo
{
    public string UserId { get; set; } = null!;

    public string RoleId { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserNumber { get; set; } = null!;

    public string? Password { get; set; }

    public string Name { get; set; } = null!;

    public string? Sex { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? Description { get; set; }

    public DateTime? LastLoginTime { get; set; }

    public short StateCode { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }
}
