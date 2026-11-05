using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// PLC连接信息表
/// </summary>
public partial class PlcConnInfo
{
    /// <summary>
    /// PLC连接字符串ID
    /// </summary>
    public string PlcConnId { get; set; } = null!;

    /// <summary>
    /// PLC连接编码
    /// </summary>
    public string PlcConnCode { get; set; } = null!;

    /// <summary>
    /// PLC连接命名
    /// </summary>
    public string PlcConnName { get; set; } = null!;

    /// <summary>
    /// PLC类型(Siemens、Omron、Modbus)
    /// </summary>
    public string? PlcType { get; set; }

    /// <summary>
    /// IP地址
    /// </summary>
    public string Ip { get; set; } = null!;

    /// <summary>
    /// 端口号
    /// </summary>
    public int? Port { get; set; }

    /// <summary>
    /// CPU类型(1=S1200,2=S300,3=S400,4=S1500,5=S200smart,6=S200)
    /// </summary>
    public int PlcCpuType { get; set; }

    /// <summary>
    /// 机架号
    /// </summary>
    public short? Rack { get; set; }

    /// <summary>
    /// 插槽号
    /// </summary>
    public short? Slot { get; set; }

    /// <summary>
    /// PLC-DB块
    /// </summary>
    public int? PlcDb { get; set; }

    /// <summary>
    /// WCS-DB块
    /// </summary>
    public int? WcsDb { get; set; }

    /// <summary>
    /// 心跳开始
    /// </summary>
    public int? HeartStart { get; set; }

    /// <summary>
    /// 心跳长度
    /// </summary>
    public int? HeartLength { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

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
