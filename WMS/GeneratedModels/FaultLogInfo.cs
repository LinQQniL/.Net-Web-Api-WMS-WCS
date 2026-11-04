using System;
using System.Collections;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class FaultLogInfo
{
    /// <summary>
    /// 唯一ID
    /// </summary>
    public string FaultLogId { get; set; } = null!;

    /// <summary>
    /// 设备号
    /// </summary>
    public string? EquipmentCode { get; set; }

    /// <summary>
    /// 设备类型
    /// </summary>
    public string? EquipmentType { get; set; }

    /// <summary>
    /// 报警代码
    /// </summary>
    public string? FaultCode { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 结束时间
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// 是否结束
    /// </summary>
    public BitArray? IsEnd { get; set; }

    /// <summary>
    ///  是否推送完成结果(待推送0，推送完成1)
    /// </summary>
    public string? IsPushResult { get; set; }

    /// <summary>
    ///  是否推送修复时间完成结果(待推送0，推送完成1)
    /// </summary>
    public string? IsPushfixTimeResult { get; set; }
}
