using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 仓库信息表
/// </summary>
public partial class WarehouseInfo
{
    /// <summary>
    /// 仓库ID
    /// </summary>
    public string WarehouseId { get; set; } = null!;

    /// <summary>
    /// 仓库代码
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 仓库名称
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 上位编码
    /// </summary>
    public string SysCode { get; set; } = null!;

    /// <summary>
    /// 仓库所在地址
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// 仓库所在地邮编
    /// </summary>
    public string PostCode { get; set; } = null!;

    /// <summary>
    /// 顺序号
    /// </summary>
    public int SequenceNumber { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 状态（0：删除1：激活9：停用）
    /// </summary>
    public short StateCode { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public string Creator { get; set; } = null!;

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 修改人
    /// </summary>
    public string Updator { get; set; } = null!;

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime UpdateTime { get; set; }
}
