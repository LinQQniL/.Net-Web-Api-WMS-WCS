using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 主从关系表
/// </summary>
public partial class MasterSlaveSetting
{
    /// <summary>
    /// 主从表关联ID
    /// </summary>
    public string MasterSlaveId { get; set; } = null!;

    /// <summary>
    /// 主从表编码
    /// </summary>
    public string MasterSlaveCode { get; set; } = null!;

    /// <summary>
    /// 主表
    /// </summary>
    public string MasterTable { get; set; } = null!;

    /// <summary>
    /// 从表
    /// </summary>
    public string SlaveTable { get; set; } = null!;

    /// <summary>
    /// 关联字段
    /// </summary>
    public string SlaveRelation { get; set; } = null!;

    /// <summary>
    /// 创建人
    /// </summary>
    public string? Creator { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 修改人
    /// </summary>
    public string? Updator { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
