using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class StorageChangeList
{
    public string StorageChangeId { get; set; } = null!;

    /// <summary>
    /// EU箱号/原箱号
    /// </summary>
    public string? ContainerNo { get; set; }

    /// <summary>
    /// 工厂代码
    /// </summary>
    public string? Werks { get; set; }

    /// <summary>
    /// 仓库号
    /// </summary>
    public string? WhNumber { get; set; }

    /// <summary>
    /// 供应商代码
    /// </summary>
    public string? Lifnr { get; set; }

    /// <summary>
    /// 物料号
    /// </summary>
    public string? Matnr { get; set; }

    /// <summary>
    /// 批次
    /// </summary>
    public string? Batch { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    public decimal? Qty { get; set; }

    /// <summary>
    /// 任务号
    /// </summary>
    public string? TaskNo { get; set; }

    /// <summary>
    /// 任务类别
    /// </summary>
    public string? TaskType { get; set; }

    /// <summary>
    /// 变动事件
    /// </summary>
    public string? Event { get; set; }

    /// <summary>
    /// 变动类型
    /// </summary>
    public string? AddOrRemove { get; set; }

    /// <summary>
    /// 变动数量
    /// </summary>
    public decimal? ChangeNumber { get; set; }

    /// <summary>
    /// 库区
    /// </summary>
    public string? StoarageArea { get; set; }

    /// <summary>
    /// 库位
    /// </summary>
    public string? Location { get; set; }

    /// <summary>
    /// 变动时间
    /// </summary>
    public DateTime? CreateTime { get; set; }
}
