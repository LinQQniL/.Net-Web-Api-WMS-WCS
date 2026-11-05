using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 按钮设置表
/// </summary>
public partial class ButtonSetting
{
    /// <summary>
    /// 按钮ID
    /// </summary>
    public string ButtonId { get; set; } = null!;

    /// <summary>
    /// 中文标题
    /// </summary>
    public string Caption { get; set; } = null!;

    /// <summary>
    /// 英文标题
    /// </summary>
    public string? EnCaption { get; set; }

    public string? ThirdCaption { get; set; }

    /// <summary>
    /// 组件名称
    /// </summary>
    public string ComponentName { get; set; } = null!;

    /// <summary>
    /// 按钮方法类型
    /// </summary>
    public string ButtonMethodType { get; set; } = null!;

    /// <summary>
    /// 方法名称
    /// </summary>
    public string MethodName { get; set; } = null!;

    /// <summary>
    /// 操作类型
    /// </summary>
    public string OperationType { get; set; } = null!;

    /// <summary>
    /// 主从关系
    /// </summary>
    public string? MasterSlave { get; set; }

    /// <summary>
    /// 排序序号
    /// </summary>
    public int Sequence { get; set; }

    public string? Message { get; set; }

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
