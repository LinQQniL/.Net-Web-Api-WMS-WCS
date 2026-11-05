using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 堆垛机作业模式
/// </summary>
public partial class StackerWorkMode
{
    /// <summary>
    /// 堆垛机工作模式ID
    /// </summary>
    public string StackerWorkModeId { get; set; } = null!;

    /// <summary>
    /// 堆垛机编号
    /// </summary>
    public string StackerCode { get; set; } = null!;

    /// <summary>
    /// 工作模式
    /// </summary>
    public string WorkMode { get; set; } = null!;

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

    /// <summary>
    /// 状态：0正常；1不可用(人工禁用)；
    /// </summary>
    public short? State { get; set; }
}
