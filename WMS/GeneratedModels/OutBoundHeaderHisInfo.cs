using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class OutBoundHeaderHisInfo
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string OutBoundHeaderId { get; set; } = null!;

    /// <summary>
    /// 单号
    /// </summary>
    public string BillNo { get; set; } = null!;

    /// <summary>
    /// 单据类型
    /// </summary>
    public string BillType { get; set; } = null!;

    /// <summary>
    /// 创建人
    /// </summary>
    public string Creator { get; set; } = null!;

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 更新人
    /// </summary>
    public string? Updator { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 完成时间
    /// </summary>
    public DateTime? FinishTime { get; set; }

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// 区域编号
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 0：已创建 、1：已部分分配、2、已全部分配、3：已部分回传、4：已全部回传、5、已关闭
    /// </summary>
    public short BillStatus { get; set; }

    /// <summary>
    /// 单据来源
    /// </summary>
    public string? BillFrom { get; set; }
}
