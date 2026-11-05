using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class OutHisStoreOrder
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string OutStoreOrderId { get; set; } = null!;

    /// <summary>
    /// 工厂代码
    /// </summary>
    public string Werks { get; set; } = null!;

    /// <summary>
    /// 仓库号
    /// </summary>
    public string WhNumber { get; set; } = null!;

    /// <summary>
    /// 立库标识
    /// </summary>
    public string Sysnod { get; set; } = null!;

    /// <summary>
    /// 需求类型
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// 出库需求号
    /// </summary>
    public string RequirementNo { get; set; } = null!;

    /// <summary>
    /// 出库需求行号
    /// </summary>
    public string RequirementItemNo { get; set; } = null!;

    /// <summary>
    /// 物料号
    /// </summary>
    public string Matnr { get; set; } = null!;

    /// <summary>
    /// 物料描述
    /// </summary>
    public string Maktx { get; set; } = null!;

    /// <summary>
    /// 供应商代码
    /// </summary>
    public string? Lifnr { get; set; }

    /// <summary>
    /// 库位
    /// </summary>
    public string? Lgort { get; set; }

    /// <summary>
    /// 批次
    /// </summary>
    public string? Batch { get; set; }

    /// <summary>
    /// 需求数量
    /// </summary>
    public decimal? Qty { get; set; }

    /// <summary>
    /// 下架数量
    /// </summary>
    public decimal? QtyXj { get; set; }

    /// <summary>
    /// 单位
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// 特殊库存类型
    /// </summary>
    public string? Sobkz { get; set; }

    /// <summary>
    /// 交接数量
    /// </summary>
    public decimal? QtyReal { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? EditDate { get; set; }

    /// <summary>
    /// 业务类型名称
    /// </summary>
    public string? BusinessName { get; set; }

    /// <summary>
    /// 业务类型
    /// </summary>
    public string? BusinessType { get; set; }

    /// <summary>
    /// 核销标识
    /// </summary>
    public string? HxFlag { get; set; }

    /// <summary>
    /// 行项目状态
    /// </summary>
    public string? ReqItemStatus { get; set; }

    /// <summary>
    /// SAP物料凭证号
    /// </summary>
    public string? SapMatdocNo { get; set; }

    /// <summary>
    /// SAP物料凭证行项目号
    /// </summary>
    public string? SapMatdocItemNo { get; set; }

    /// <summary>
    /// WBS元素号
    /// </summary>
    public string? Wbs { get; set; }

    /// <summary>
    /// 成本中心
    /// </summary>
    public string? CostCenter { get; set; }

    /// <summary>
    /// 配送单号
    /// </summary>
    public string? DispatchingNo { get; set; }

    /// <summary>
    /// 配送单行号
    /// </summary>
    public string? ItemNo { get; set; }

    /// <summary>
    /// 生产线
    /// </summary>
    public string? Demandfrom { get; set; }

    /// <summary>
    /// 工段
    /// </summary>
    public string? DispatchingSection { get; set; }

    /// <summary>
    /// 工位
    /// </summary>
    public string? WorkingLogation { get; set; }

    /// <summary>
    /// 线边储位
    /// </summary>
    public string? Bin { get; set; }

    /// <summary>
    /// SPS拣配储位
    /// </summary>
    public string? Abbr { get; set; }

    /// <summary>
    /// 配送单类型
    /// </summary>
    public string? DispatchingType { get; set; }

    /// <summary>
    /// 优先级（类型A时必填 
    /// 1紧急  0正常）
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// 接受类型
    /// </summary>
    public string? Receivetype { get; set; }

    /// <summary>
    /// 线别标记产生需求的线别，便于需求的
    /// </summary>
    public string? LineCategory { get; set; }

    /// <summary>
    /// 接受库位
    /// </summary>
    public string? Receivelgort { get; set; }

    /// <summary>
    /// 包装条码
    /// </summary>
    public string? Barcode { get; set; }

    /// <summary>
    /// 最晚交接时间
    /// </summary>
    public DateTime? HandoverDate { get; set; }

    /// <summary>
    /// 线边需求时间
    /// </summary>
    public DateTime? LineRequirementDate { get; set; }

    /// <summary>
    /// 出库状态
    /// 状态，01:待发布；
    /// 02:发布；
    /// 03:拣配中；
    /// 04:已打印；
    /// 05:已下架；
    /// 06:配送中；
    /// 07:关闭；
    /// 08:已交接;
    /// 09:配送完成
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 需求数量
    /// </summary>
    public decimal? RequiredQty { get; set; }

    /// <summary>
    /// 需求箱号数量
    /// </summary>
    public decimal? RequiredPackQty { get; set; }

    /// <summary>
    /// 完成数量
    /// </summary>
    public decimal? CompleteQty { get; set; }

    /// <summary>
    /// 完成箱数
    /// </summary>
    public decimal? CompletePackQty { get; set; }

    /// <summary>
    /// 上线包装器具
    /// </summary>
    public string? OnlinePack { get; set; }

    /// <summary>
    /// 上线装载量
    /// </summary>
    public decimal? OnlineStanLoadQty { get; set; }

    /// <summary>
    /// 完成时间
    /// </summary>
    public DateTime? FinshDate { get; set; }

    /// <summary>
    /// 装配工位
    /// </summary>
    public string? UrnPackStation { get; set; }

    /// <summary>
    /// 车型
    /// </summary>
    public string? CarType { get; set; }

    /// <summary>
    /// 配置
    /// </summary>
    public string? Config { get; set; }

    /// <summary>
    /// 任务号
    /// </summary>
    public string? TaskNum { get; set; }

    /// <summary>
    /// 目标储位
    /// </summary>
    public string? ToBinCode { get; set; }

    /// <summary>
    /// 车身号
    /// </summary>
    public string? Bodyno { get; set; }

    /// <summary>
    /// 颜色
    /// </summary>
    public string? CarColor { get; set; }

    /// <summary>
    /// VIN码
    /// </summary>
    public string? Vin { get; set; }

    /// <summary>
    /// PBS 排序号
    /// </summary>
    public string? Spssort { get; set; }

    /// <summary>
    /// 移储库存标识
    /// </summary>
    public string? StockRmk { get; set; }

    /// <summary>
    /// 发货地点
    /// </summary>
    public string? Routestatusfrom { get; set; }

    /// <summary>
    /// 需求规则
    /// </summary>
    public string? Demandrule { get; set; }

    /// <summary>
    /// 是否全部出库完成(默认值0，完成后改成1)
    /// </summary>
    public string? IsComplete { get; set; }

    /// <summary>
    /// 是否推送出库完成结果(默认值0，完成后改成1)
    /// </summary>
    public string? IsPushResult { get; set; }

    /// <summary>
    /// 物料类别
    /// </summary>
    public string? Partgroup { get; set; }

    /// <summary>
    /// JIS 单序号
    /// </summary>
    public string? Seq { get; set; }

    /// <summary>
    /// 原始补货数量
    /// </summary>
    public string? OrigReplenishmentQty { get; set; }

    /// <summary>
    /// AGV 上线策略
    /// </summary>
    public short? AgvOnlineStrategy { get; set; }

    /// <summary>
    /// 配送地址
    /// </summary>
    public string? DispatchingAddress { get; set; }

    /// <summary>
    /// 实际需求数量
    /// </summary>
    public decimal? OriginalQty { get; set; }

    /// <summary>
    /// 试装标识
    /// </summary>
    public string? TrialFlag { get; set; }

    /// <summary>
    /// AGV路线
    /// </summary>
    public string? Agvroute { get; set; }

    /// <summary>
    /// 导入数据是否已处理
    /// </summary>
    public bool? IsDeal { get; set; }
}
