using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class ProgramEquipmentInfo
{
    /// <summary>
    /// PLC设备ID
    /// </summary>
    public string ProgramEquipmentId { get; set; } = null!;

    /// <summary>
    /// Wcs程序ID
    /// </summary>
    public string ProgramId { get; set; } = null!;

    /// <summary>
    /// 设备编码
    /// </summary>
    public string EquipmentCode { get; set; } = null!;

    /// <summary>
    /// 设备类型
    /// </summary>
    public string EquipmentType { get; set; } = null!;

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Plc连接ID
    /// </summary>
    public string PlcConnId { get; set; } = null!;

    /// <summary>
    /// Plc偏移量开始位置
    /// </summary>
    public int PlcStart { get; set; }

    /// <summary>
    /// Plc长度
    /// </summary>
    public int PlcLength { get; set; }

    /// <summary>
    /// Plc模式
    /// </summary>
    public string PlcModel { get; set; } = null!;

    /// <summary>
    /// Wcs偏移量开始位置
    /// </summary>
    public int WcsStart { get; set; }

    /// <summary>
    /// Wcs偏移量长度
    /// </summary>
    public int WcsLength { get; set; }

    /// <summary>
    /// Wcs模式
    /// </summary>
    public string WcsModel { get; set; } = null!;

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
