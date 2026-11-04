using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 配料拉动需求单
/// </summary>
public partial class MaterialDemandPlan
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string MaterialDemandPlanId { get; set; } = null!;

    /// <summary>
    /// 同步时间（请求WMS接口时间）
    /// </summary>
    public DateTime IWmsrequestTime { get; set; }

    /// <summary>
    /// 工厂代码
    /// </summary>
    public string Werks { get; set; } = null!;

    /// <summary>
    /// 配料单号
    /// </summary>
    public string? BurdenSheetNo { get; set; }

    /// <summary>
    /// 行项目号
    /// </summary>
    public int? BurdenSheetId { get; set; }

    /// <summary>
    /// 车系
    /// </summary>
    public string? CarSeries { get; set; }

    /// <summary>
    /// 车系批次
    /// </summary>
    public string? CarSeriesBatch { get; set; }

    /// <summary>
    /// 生产订单号
    /// </summary>
    public string? SapNo { get; set; }

    /// <summary>
    /// 整车物料号
    /// </summary>
    public string? SapMaterial { get; set; }

    /// <summary>
    /// 整车物料号描述
    /// </summary>
    public string? SapMaterialDesc { get; set; }

    /// <summary>
    /// 零件物料号
    /// </summary>
    public string? ComSapMaterial { get; set; }

    /// <summary>
    /// 零件物料号描述
    /// </summary>
    public string? ComSapMaterialDesc { get; set; }

    /// <summary>
    /// 生产数量
    /// </summary>
    public decimal? Qty { get; set; }

    /// <summary>
    /// 生效时间
    /// </summary>
    public DateTime? ExecDate { get; set; }

    /// <summary>
    /// 项目号
    /// </summary>
    public string? ProiectNum { get; set; }

    /// <summary>
    /// 工位
    /// </summary>
    public string? SortId { get; set; }

    /// <summary>
    /// 有效性(0:无效 1:有效)
    /// </summary>
    public short? IsEnable { get; set; }

    /// <summary>
    /// 产线
    /// </summary>
    public string? Line { get; set; }

    /// <summary>
    /// 需求计划时间
    /// </summary>
    public DateTime? DemandDate { get; set; }

    /// <summary>
    /// 版本号
    /// </summary>
    public string? CalId { get; set; }

    /// <summary>
    /// 状态 1：未创建 2：已创建 3：发布提交 4：已发布 5：发布失败 6:计划修改
    /// </summary>
    public short? State { get; set; }

    /// <summary>
    /// 供应商名称
    /// </summary>
    public string? SupplineName { get; set; }

    /// <summary>
    /// 供应商代码
    /// </summary>
    public string? Lifnr { get; set; }

    /// <summary>
    /// 组建计量单位
    /// </summary>
    public string? Meins { get; set; }

    /// <summary>
    /// 物料供应标识
    /// </summary>
    public string? Beikz { get; set; }

    /// <summary>
    /// 库存地点
    /// </summary>
    public string? Lgort { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// 是否系统创建   1：系统创建 0：人工新增
    /// </summary>
    public short? IsNew { get; set; }

    /// <summary>
    /// 储位
    /// </summary>
    public string? Area { get; set; }

    /// <summary>
    /// 库位地点
    /// </summary>
    public string? Location { get; set; }

    /// <summary>
    /// 实发数量
    /// </summary>
    public string? RealQty { get; set; }

    /// <summary>
    /// sap 组件状态 0：未创建 1：创建中2：已创建3：创建失败， 4：已修改 ，默认值为 0
    /// </summary>
    public short? SapStatus { get; set; }

    /// <summary>
    /// 生产订单的整车料号数量
    /// </summary>
    public string? PlanQty { get; set; }

    /// <summary>
    /// 需要出库翻包的数量
    /// </summary>
    public int? NeedNumber { get; set; }

    /// <summary>
    /// 已分配翻包数量
    /// </summary>
    public int? CompleteNumber { get; set; }

    /// <summary>
    /// 是否已完成分配 0未完成  1已完成  2已关闭
    /// </summary>
    public short? IsComplete { get; set; }

    /// <summary>
    /// 导入数据是否已处理
    /// </summary>
    public bool? IsDeal { get; set; }
}
