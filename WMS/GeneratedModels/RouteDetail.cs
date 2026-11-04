using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class RouteDetail
{
    /// <summary>
    /// 路径明细ID
    /// </summary>
    public string DetailId { get; set; } = null!;

    /// <summary>
    /// 路径ID
    /// </summary>
    public string RouteId { get; set; } = null!;

    /// <summary>
    /// 路径类型
    /// </summary>
    public string RouteType { get; set; } = null!;

    /// <summary>
    /// 起始设备
    /// </summary>
    public string FromEquipment { get; set; } = null!;

    /// <summary>
    /// 目标设备
    /// </summary>
    public string ToEquipment { get; set; } = null!;

    /// <summary>
    /// 起始地址
    /// </summary>
    public string? FromAddress { get; set; }

    /// <summary>
    /// 目标地址
    /// </summary>
    public string? ToAddress { get; set; }

    /// <summary>
    /// 排序序号
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// 业务类型
    /// </summary>
    public string? BusinessType { get; set; }

    /// <summary>
    /// 业务参数
    /// </summary>
    public string? Parameter { get; set; }

    /// <summary>
    /// 路径-任务限制数量
    /// </summary>
    public int? TaskNum { get; set; }

    /// <summary>
    /// 最后任务时间
    /// </summary>
    public DateTime? LastTaskTime { get; set; }

    public bool? IsNotTransfer { get; set; }
}
