using System;
using System.Collections.Generic;

namespace MiddlewareDemo.Helper;

/// <summary>
/// 图标名转换：数据库 MenuInfo.Icon 存的是 Ant Design 图标名
///（如 HomeOutlined、SettingOutlined），而前端使用 Element Plus 图标库
///（如 House、Setting）。两者命名完全不同，直接透传会导致
/// 前端 ElementPlusIcons[iconName] 取不到组件，全部回退成同一个默认图标。
///
/// 这里在返回给前端之前统一转换成 Element Plus 组件名。
/// 未在映射表中的名字原样返回，前端仍会走兜底逻辑。
/// </summary>
public static class IconNameMapper
{
	/// <summary>
	/// Ant Design 图标名 -> Element Plus 图标名
	/// </summary>
	private static readonly Dictionary<string, string> Map = new(StringComparer.OrdinalIgnoreCase)
	{
		// ===== 导航 / 首页 =====
		["HomeOutlined"] = "House",
		["HomeFilled"] = "HomeFilled",
		["DashboardOutlined"] = "DataBoard",
		["DashboardFilled"] = "DataBoard",
		["AppstoreOutlined"] = "Grid",
		["AppstoreFilled"] = "Grid",
		["AppstoreAddOutlined"] = "Grid",
		["MenuOutlined"] = "Menu",
		["BarsOutlined"] = "Menu",
		["ControlOutlined"] = "Operation",
		["SettingOutlined"] = "Setting",
		["SettingFilled"] = "Setting",
		["ToolOutlined"] = "Tools",
		["ToolFilled"] = "Tools",
		["BuildOutlined"] = "Tools",

		// ===== 用户 / 权限 =====
		["UserOutlined"] = "User",
		["UserAddOutlined"] = "User",
		["UsergroupAddOutlined"] = "UserFilled",
		["TeamOutlined"] = "UserFilled",
		["ContactsOutlined"] = "User",
		["ContactsFilled"] = "UserFilled",
		["SolutionOutlined"] = "User",
		["IdcardOutlined"] = "Postcard",
		["SafetyCertificateOutlined"] = "Lock",
		["LockOutlined"] = "Lock",
		["KeyOutlined"] = "Key",

		// ===== 文档 / 单据 =====
		["FileTextOutlined"] = "Document",
		["FileOutlined"] = "Document",
		["ProfileOutlined"] = "Document",
		["SnippetsOutlined"] = "Document",
		["FormOutlined"] = "EditPen",
		["EditOutlined"] = "Edit",
		["CopyOutlined"] = "CopyDocument",
		["AuditOutlined"] = "Tickets",
		["BookOutlined"] = "Notebook",
		["BookFilled"] = "Notebook",
		["AccountBookOutlined"] = "Notebook",
		["SaveOutlined"] = "Files",
		["FolderOpenTwoTone"] = "FolderOpened",
		["FolderViewOutlined"] = "Folder",
		["FolderOutlined"] = "Folder",
		["FolderFilled"] = "FolderOpened",
		["ReadOutlined"] = "Reading",

		// ===== 仓储 / 库存 =====
		["DatabaseOutlined"] = "Coin",
		["InboxOutlined"] = "Box",
		["DropboxOutlined"] = "Box",
		["HddOutlined"] = "Files",
		["HddFilled"] = "Files",
		["CodepenOutlined"] = "Box",
		["CodeSandboxOutlined"] = "Box",
		["BorderOutlined"] = "Grid",
		["BorderlessTableOutlined"] = "Grid",
		["BorderHorizontalOutlined"] = "Grid",
		["BorderOuterOutlined"] = "Grid",
		["ColumnWidthOutlined"] = "Grid",
		["ColumnHeightOutlined"] = "Grid",
		["InsertRowBelowOutlined"] = "Grid",
		["InsertRowAboveOutlined"] = "Grid",
		["DeleteRowOutlined"] = "Delete",
		["DisconnectOutlined"] = "Link",

		// ===== 物流 / 调度 =====
		["CarOutlined"] = "Van",
		["CarFilled"] = "Van",
		["TruckOutlined"] = "Van",
		["DeliveredProcedureOutlined"] = "Van",
		["SendOutlined"] = "Promotion",
		["PullRequestOutlined"] = "Connection",
		["ApartmentOutlined"] = "Share",
		["DeploymentUnitOutlined"] = "Share",
		["PartitionOutlined"] = "Share",
		["NodeCollapseOutlined"] = "Share",
		["BranchesOutlined"] = "Share",
		["GroupOutlined"] = "Share",
		["ForkOutlined"] = "Share",
		["OneToOneOutlined"] = "Connection",

		// ===== 统计 / 图表 =====
		["BarChartOutlined"] = "Histogram",
		["LineChartOutlined"] = "TrendCharts",
		["AreaChartOutlined"] = "TrendCharts",
		["PieChartOutlined"] = "PieChart",
		["FundOutlined"] = "TrendCharts",
		["RiseOutlined"] = "Top",
		["FallOutlined"] = "Bottom",
		["StockOutlined"] = "TrendCharts",
		["DotChartOutlined"] = "PieChart",
		["HeatMapOutlined"] = "DataAnalysis",
		["RadarChartOutlined"] = "DataAnalysis",

		// ===== 状态 / 提示 =====
		["CheckCircleOutlined"] = "CircleCheck",
		["CloseCircleOutlined"] = "CircleClose",
		["ExclamationCircleOutlined"] = "Warning",
		["AlertOutlined"] = "Warning",
		["AlertFilled"] = "WarningFilled",
		["BugFilled"] = "Warning",
		["BugOutlined"] = "Warning",
		["InfoCircleOutlined"] = "InfoFilled",
		["QuestionCircleOutlined"] = "QuestionFilled",
		["AimOutlined"] = "Aim",
		["CopyrightCircleOutlined"] = "InfoFilled",

		// ===== 操作 =====
		["SearchOutlined"] = "Search",
		["PlusOutlined"] = "Plus",
		["MinusOutlined"] = "Minus",
		["CloseOutlined"] = "Close",
		["CloseSquareOutlined"] = "CloseBold",
		["MinusSquareOutlined"] = "Minus",
		["DeleteOutlined"] = "Delete",
		["ExportOutlined"] = "Download",
		["ImportOutlined"] = "Upload",
		["DownloadOutlined"] = "Download",
		["UploadOutlined"] = "Upload",
		["PrinterOutlined"] = "Printer",
		["PrinterFilled"] = "Printer",
		["FilterOutlined"] = "Filter",
		["SyncOutlined"] = "Refresh",
		["ReloadOutlined"] = "Refresh",
		["UndoOutlined"] = "RefreshLeft",
		["RedoOutlined"] = "RefreshRight",
		["CompressOutlined"] = "Fold",
		["ExpandOutlined"] = "Expand",
		["FullscreenOutlined"] = "FullScreen",

		// ===== 箭头 / 方向 =====
		["ArrowUpOutlined"] = "Top",
		["ArrowDownOutlined"] = "Bottom",
		["ArrowLeftOutlined"] = "Back",
		["ArrowRightOutlined"] = "Right",
		["CaretLeftOutlined"] = "ArrowLeft",
		["CaretRightOutlined"] = "ArrowRight",
		["CaretUpOutlined"] = "ArrowUp",
		["CaretDownOutlined"] = "ArrowDown",
		["DownSquareOutlined"] = "ArrowDown",
		["UpSquareOutlined"] = "ArrowUp",
		["VerticalAlignMiddleOutlined"] = "Sort",
		["AlignLeftOutlined"] = "Tickets",
		["AlignRightOutlined"] = "Tickets",
		["AlignCenterOutlined"] = "Tickets",
		["PicRightOutlined"] = "Tickets",
		["ItalicOutlined"] = "EditPen",

		// ===== 时间 =====
		["CalendarOutlined"] = "Calendar",
		["CalendarTwoTone"] = "Calendar",
		["ClockCircleOutlined"] = "Clock",
		["HistoryOutlined"] = "Timer",

		// ===== 通讯 / 通知 =====
		["BellOutlined"] = "Bell",
		["BellFilled"] = "BellFilled",
		["MailOutlined"] = "Message",
		["MessageOutlined"] = "ChatDotRound",
		["PhoneOutlined"] = "Phone",
		["MobileFilled"] = "Iphone",
		["MobileOutlined"] = "Iphone",

		// ===== 品牌 / 其他 =====
		["AppleOutlined"] = "Apple",
		["AndroidOutlined"] = "Iphone",
		["ChromeOutlined"] = "ChromeFilled",
		["WindowsOutlined"] = "Monitor",
		["AliwangwangOutlined"] = "Service",
		["AlibabaOutlined"] = "Shop",
		["AliyunOutlined"] = "Cloudy",
		["AntDesignOutlined"] = "ElementPlus",
		["AntCloudOutlined"] = "Cloudy",
		["DingtalkOutlined"] = "ChatDotSquare",
		["DribbbleCircleFilled"] = "Basketball",
		["CodepenCircleOutlined"] = "Box",
		["GithubOutlined"] = "Link",
		["QqOutlined"] = "ChatRound",
		["WechatOutlined"] = "ChatLineRound",
		["WeiboOutlined"] = "ChatSquare",

		// ===== 物体 / 杂项 =====
		["RocketOutlined"] = "Promotion",
		["GiftOutlined"] = "Present",
		["GiftTwoTone"] = "Present",
		["LikeOutlined"] = "Star",
		["HeartOutlined"] = "Star",
		["StarOutlined"] = "Star",
		["StarFilled"] = "StarFilled",
		["FireOutlined"] = "Sunny",
		["SunOutlined"] = "Sunny",
		["RestFilled"] = "Coffee",
		["CoffeeOutlined"] = "Coffee",
		["CreditCardOutlined"] = "CreditCard",
		["BankOutlined"] = "OfficeBuilding",
		["BankFilled"] = "OfficeBuilding",
		["ShopOutlined"] = "Shop",
		["ShopFilled"] = "Shop",
		["ShoppingOutlined"] = "ShoppingBag",
		["ShoppingCartOutlined"] = "ShoppingCart",
		["ShoppingCartFilled"] = "ShoppingCartFull",
		["TagsOutlined"] = "CollectionTag",
		["TagOutlined"] = "PriceTag",
		["SwitcherFilled"] = "Switch",
		["SwitcherOutlined"] = "Switch",
		["BarcodeOutlined"] = "Postcard",
		["QrcodeOutlined"] = "Postcard",
		["ScanOutlined"] = "Aim",
		["ExperimentOutlined"] = "Cpu",
		["RobotOutlined"] = "Cpu",
		["ThunderboltOutlined"] = "Lightning",
		["EnvironmentOutlined"] = "Location",
		["GlobalOutlined"] = "Compass",
		["CompassOutlined"] = "Compass",
		["StopOutlined"] = "VideoPause",
		["PlayCircleOutlined"] = "VideoPlay",
		["PauseCircleOutlined"] = "VideoPause",
		["MoneyCollectOutlined"] = "Money",
		["PayCircleOutlined"] = "Wallet",
		["WalletOutlined"] = "Wallet",
		["CarryOutOutlined"] = "Checked",
		["ContainerOutlined"] = "TakeawayBox",
		["ProjectOutlined"] = "Files",
		["ScheduleOutlined"] = "Calendar",
		["OrderedListOutlined"] = "List",
		["UnorderedListOutlined"] = "List",
		["TableOutlined"] = "Grid",
		["BlockOutlined"] = "Grid",
		["ClusterOutlined"] = "Share",
		["MergeCellsOutlined"] = "Grid",
		["SmallDashOutlined"] = "More",
		["MoreOutlined"] = "MoreFilled",
		["EllipsisOutlined"] = "MoreFilled",
	};

	/// <summary>
	/// 把数据库中的图标名转成 Element Plus 组件名。
	/// 已是 Element Plus 名字或无法识别的，原样返回。
	/// </summary>
	/// <param name="iconName">数据库 MenuInfo.Icon 的值</param>
	/// <returns>Element Plus 图标组件名</returns>
	public static string? ToElementPlus(string? iconName)
	{
		if (string.IsNullOrWhiteSpace(iconName))
		{
			return iconName;
		}

		string trimmed = iconName.Trim();
		return Map.TryGetValue(trimmed, out string? mapped) ? mapped : trimmed;
	}
}
