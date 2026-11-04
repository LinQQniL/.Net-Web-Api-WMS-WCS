using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WMS.WebApi.GeneratedModels;

namespace WMS.WebApi.GeneratedData;

public partial class ScaffoldContext : DbContext
{
    public ScaffoldContext(DbContextOptions<ScaffoldContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AbnormalTask> AbnormalTasks { get; set; }

    public virtual DbSet<AgvSynvHisStation> AgvSynvHisStations { get; set; }

    public virtual DbSet<AreaInfo> AreaInfos { get; set; }

    public virtual DbSet<BigTrayColumnInfo> BigTrayColumnInfos { get; set; }

    public virtual DbSet<BindingDetail> BindingDetails { get; set; }

    public virtual DbSet<BindingDetailLog> BindingDetailLogs { get; set; }

    public virtual DbSet<BindingMain> BindingMains { get; set; }

    public virtual DbSet<BindingMainLog> BindingMainLogs { get; set; }

    public virtual DbSet<ButtonSetting> ButtonSettings { get; set; }

    public virtual DbSet<ChangeContainerLog> ChangeContainerLogs { get; set; }

    public virtual DbSet<ChartSettingInfo> ChartSettingInfos { get; set; }

    public virtual DbSet<ColumnHeatSet> ColumnHeatSets { get; set; }

    public virtual DbSet<ContainerInfo> ContainerInfos { get; set; }

    public virtual DbSet<ContainerTypeInfo> ContainerTypeInfos { get; set; }

    public virtual DbSet<DictDataInfo> DictDataInfos { get; set; }

    public virtual DbSet<DiscontinuousColumnInfo> DiscontinuousColumnInfos { get; set; }

    public virtual DbSet<ErrorInterfaceLogInfo> ErrorInterfaceLogInfos { get; set; }

    public virtual DbSet<EucallHisLog> EucallHisLogs { get; set; }

    public virtual DbSet<EucallLog> EucallLogs { get; set; }

    public virtual DbSet<EucomeBack> EucomeBacks { get; set; }

    public virtual DbSet<EventLogInfo> EventLogInfos { get; set; }

    public virtual DbSet<Factory> Factories { get; set; }

    public virtual DbSet<FaultCodeInfo> FaultCodeInfos { get; set; }

    public virtual DbSet<FaultLogInfo> FaultLogInfos { get; set; }

    public virtual DbSet<FieldSetting> FieldSettings { get; set; }

    public virtual DbSet<HeatSet> HeatSets { get; set; }

    public virtual DbSet<InBoundDetailInfo> InBoundDetailInfos { get; set; }

    public virtual DbSet<InBoundHeaderHisInfo> InBoundHeaderHisInfos { get; set; }

    public virtual DbSet<InBoundHeaderInfo> InBoundHeaderInfos { get; set; }

    public virtual DbSet<InBoundHisDetailInfo> InBoundHisDetailInfos { get; set; }

    public virtual DbSet<InterfaceInfo> InterfaceInfos { get; set; }

    public virtual DbSet<InterfaceLogInfo> InterfaceLogInfos { get; set; }

    public virtual DbSet<InventoryLocationInfo> InventoryLocationInfos { get; set; }

    public virtual DbSet<InventoryLocationInfoCopy1> InventoryLocationInfoCopy1s { get; set; }

    public virtual DbSet<LabelStationInfo> LabelStationInfos { get; set; }

    public virtual DbSet<LayerInfo> LayerInfos { get; set; }

    public virtual DbSet<LocationGroupInfo> LocationGroupInfos { get; set; }

    public virtual DbSet<LocationInfo> LocationInfos { get; set; }

    public virtual DbSet<LogKeyWord> LogKeyWords { get; set; }

    public virtual DbSet<MasterSlaveSetting> MasterSlaveSettings { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<MaterialDemandPlan> MaterialDemandPlans { get; set; }

    public virtual DbSet<MaterialTypeInfo> MaterialTypeInfos { get; set; }

    public virtual DbSet<MenuInfo> MenuInfos { get; set; }

    public virtual DbSet<MenuPowerInfo> MenuPowerInfos { get; set; }

    public virtual DbSet<MonitorInfo> MonitorInfos { get; set; }

    public virtual DbSet<OutBoundDetailHisInfo> OutBoundDetailHisInfos { get; set; }

    public virtual DbSet<OutBoundDetailInfo> OutBoundDetailInfos { get; set; }

    public virtual DbSet<OutBoundHeaderHisInfo> OutBoundHeaderHisInfos { get; set; }

    public virtual DbSet<OutBoundHeaderInfo> OutBoundHeaderInfos { get; set; }

    public virtual DbSet<OutHisStoreOrder> OutHisStoreOrders { get; set; }

    public virtual DbSet<OutStoreDetailAllocateHisInfo> OutStoreDetailAllocateHisInfos { get; set; }

    public virtual DbSet<OutStoreDetailAllocateInfo> OutStoreDetailAllocateInfos { get; set; }

    public virtual DbSet<OutStoreOrder> OutStoreOrders { get; set; }

    public virtual DbSet<Pack> Packs { get; set; }

    public virtual DbSet<PgStatStatement> PgStatStatements { get; set; }

    public virtual DbSet<PickingStation> PickingStations { get; set; }

    public virtual DbSet<PlcConnInfo> PlcConnInfos { get; set; }

    public virtual DbSet<ProgramEquipmentInfo> ProgramEquipmentInfos { get; set; }

    public virtual DbSet<ProgramInfo> ProgramInfos { get; set; }

    public virtual DbSet<ProgramJobInfo> ProgramJobInfos { get; set; }

    public virtual DbSet<PushReturnMaterial> PushReturnMaterials { get; set; }

    public virtual DbSet<RcvinfoCreateReq> RcvinfoCreateReqs { get; set; }

    public virtual DbSet<Receipt> Receipts { get; set; }

    public virtual DbSet<ReceiptHisInfo> ReceiptHisInfos { get; set; }

    public virtual DbSet<ReceiveMaterial> ReceiveMaterials { get; set; }

    public virtual DbSet<RobotCarInfo> RobotCarInfos { get; set; }

    public virtual DbSet<RoleInfo> RoleInfos { get; set; }

    public virtual DbSet<RoleMenuInfo> RoleMenuInfos { get; set; }

    public virtual DbSet<RouteDetail> RouteDetails { get; set; }

    public virtual DbSet<RoutePolicyDetail> RoutePolicyDetails { get; set; }

    public virtual DbSet<RoutePolicyTemplate> RoutePolicyTemplates { get; set; }

    public virtual DbSet<RouteSection> RouteSections { get; set; }

    public virtual DbSet<RouteSectionTemplate> RouteSectionTemplates { get; set; }

    public virtual DbSet<RouteSetting> RouteSettings { get; set; }

    public virtual DbSet<RouteStationInfo> RouteStationInfos { get; set; }

    public virtual DbSet<ShuttleCarInterInfo> ShuttleCarInterInfos { get; set; }

    public virtual DbSet<StackerWorkMode> StackerWorkModes { get; set; }

    public virtual DbSet<StandingInfo> StandingInfos { get; set; }

    public virtual DbSet<StationCacheSet> StationCacheSets { get; set; }

    public virtual DbSet<StockInfo> StockInfos { get; set; }

    public virtual DbSet<StockInfoChange> StockInfoChanges { get; set; }

    public virtual DbSet<StockingLog> StockingLogs { get; set; }

    public virtual DbSet<StockingPlan> StockingPlans { get; set; }

    public virtual DbSet<StockingTable> StockingTables { get; set; }

    public virtual DbSet<StorageChangeList> StorageChangeLists { get; set; }

    public virtual DbSet<StoreInLog> StoreInLogs { get; set; }

    public virtual DbSet<SubTaskHisInfo> SubTaskHisInfos { get; set; }

    public virtual DbSet<SubTaskInfo> SubTaskInfos { get; set; }

    public virtual DbSet<SupplierInfo> SupplierInfos { get; set; }

    public virtual DbSet<SystemConfig> SystemConfigs { get; set; }

    public virtual DbSet<TaskHisInfo> TaskHisInfos { get; set; }

    public virtual DbSet<TaskInfo> TaskInfos { get; set; }

    public virtual DbSet<UserInfo> UserInfos { get; set; }

    public virtual DbSet<UserLogInfo> UserLogInfos { get; set; }

    public virtual DbSet<UserLogInfoCopy1> UserLogInfoCopy1s { get; set; }

    public virtual DbSet<UtlFileDir> UtlFileDirs { get; set; }

    public virtual DbSet<VConfirmNumber> VConfirmNumbers { get; set; }

    public virtual DbSet<VEmergencyInfo> VEmergencyInfos { get; set; }

    public virtual DbSet<VInBoundDetail> VInBoundDetails { get; set; }

    public virtual DbSet<VLocationUsageRate> VLocationUsageRates { get; set; }

    public virtual DbSet<VLocationUsageRateOld> VLocationUsageRateOlds { get; set; }

    public virtual DbSet<VMinSaftyStockInfo> VMinSaftyStockInfos { get; set; }

    public virtual DbSet<VMonitorInfo> VMonitorInfos { get; set; }

    public virtual DbSet<VOutBoundBill> VOutBoundBills { get; set; }

    public virtual DbSet<VOutboundDetial> VOutboundDetials { get; set; }

    public virtual DbSet<VReceiptWaitingClose> VReceiptWaitingCloses { get; set; }

    public virtual DbSet<VStockInfo> VStockInfos { get; set; }

    public virtual DbSet<VStockPlan> VStockPlans { get; set; }

    public virtual DbSet<VStockingLogBill> VStockingLogBills { get; set; }

    public virtual DbSet<VStockingReport> VStockingReports { get; set; }

    public virtual DbSet<VTaskInfo> VTaskInfos { get; set; }

    public virtual DbSet<VUnClosed> VUnCloseds { get; set; }

    public virtual DbSet<ViewPartsWarehouseBreakdown> ViewPartsWarehouseBreakdowns { get; set; }

    public virtual DbSet<ViewPendingOutboundOrder> ViewPendingOutboundOrders { get; set; }

    public virtual DbSet<ViewSumStock2> ViewSumStock2s { get; set; }

    public virtual DbSet<ViewSumStockDetail> ViewSumStockDetails { get; set; }

    public virtual DbSet<ViewWarehousingEntrySummary> ViewWarehousingEntrySummaries { get; set; }

    public virtual DbSet<WarehouseInfo> WarehouseInfos { get; set; }

    public virtual DbSet<WorkStation> WorkStations { get; set; }

    public virtual DbSet<WorkStationModeSet> WorkStationModeSets { get; set; }

    public virtual DbSet<WorkStationTypeSet> WorkStationTypeSets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AbnormalTask>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AbnormalTask", tb => tb.HasComment("异常任务"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AbnormalTaskId)
                .HasMaxLength(50)
                .HasComment("唯一码")
                .HasColumnName("AbnormalTaskID");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("库区编号");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(50)
                .HasComment("容器条码");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Desc)
                .HasMaxLength(800)
                .HasComment("异常描述");
            entity.Property(e => e.StationCode)
                .HasMaxLength(50)
                .HasComment("异常排出口");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasComment("状态（待处理、已处理、无效）");
            entity.Property(e => e.SubTaskId)
                .HasMaxLength(50)
                .HasComment("子任务ID")
                .HasColumnName("SubTaskID");
            entity.Property(e => e.TaskId)
                .HasMaxLength(50)
                .HasComment("主任务ID")
                .HasColumnName("TaskID");
            entity.Property(e => e.TaskType)
                .HasMaxLength(100)
                .HasComment("任务类型（入库异常、出库异常）");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(120)
                .HasComment("仓库编号");
        });

        modelBuilder.Entity<AgvSynvHisStation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AgvSynvHisStation")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(100);
            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.StationCode).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasDefaultValueSql("'1'::character varying");
            entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator).HasMaxLength(100);
            entity.Property(e => e.WorkStationType).HasMaxLength(100);
        });

        modelBuilder.Entity<AreaInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AreaInfo", tb => tb.HasComment("库区表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaId)
                .HasMaxLength(36)
                .HasComment("唯一标识");
            entity.Property(e => e.Code).HasComment("区域编码");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.Description).HasComment("描述");
            entity.Property(e => e.Name).HasComment("区域名称");
            entity.Property(e => e.StateCode).HasComment("状态");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
            entity.Property(e => e.WarehouseId)
                .HasMaxLength(36)
                .HasComment("仓库");
        });

        modelBuilder.Entity<BigTrayColumnInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BigTrayColumnInfo", tb => tb.HasComment("托盘库大托盘列设置表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.BigTrayColumn).HasComment("列号");
            entity.Property(e => e.BigTrayColumnInfoId)
                .HasMaxLength(120)
                .HasComment("唯一标识")
                .HasColumnName("BigTrayColumnInfoID");
            entity.Property(e => e.LaneCode)
                .HasMaxLength(50)
                .HasComment("巷道编号");
            entity.Property(e => e.LayerEnd).HasComment("层结束");
            entity.Property(e => e.LayerStart).HasComment("层开始");
            entity.Property(e => e.RowEnd).HasComment("行结束");
            entity.Property(e => e.RowStart).HasComment("行开始");
        });

        modelBuilder.Entity<BindingDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BindingDetail", tb => tb.HasComment("托盘库PDA组盘明细表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.BindingDetailId)
                .HasMaxLength(100)
                .HasComment("唯一码")
                .HasColumnName("BindingDetailID");
            entity.Property(e => e.BindingId)
                .HasMaxLength(50)
                .HasComment("绑定主ID")
                .HasColumnName("BindingID");
            entity.Property(e => e.NewNumber)
                .HasPrecision(18, 2)
                .HasComment("当前单箱装载数量");
            entity.Property(e => e.OldContainerNo)
                .HasMaxLength(255)
                .HasComment("原箱号");
            entity.Property(e => e.OldMaterialQrcode)
                .HasMaxLength(1000)
                .HasComment("原箱物料标签二维码")
                .HasColumnName("OldMaterialQRCode");
            entity.Property(e => e.OldNumber)
                .HasPrecision(18, 2)
                .HasComment("来料单箱装载数量");
        });

        modelBuilder.Entity<BindingDetailLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BindingDetailLog")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.BindingDetailId)
                .HasMaxLength(100)
                .HasColumnName("BindingDetailID");
            entity.Property(e => e.BindingId)
                .HasMaxLength(50)
                .HasColumnName("BindingID");
            entity.Property(e => e.NewNumber).HasPrecision(18, 2);
            entity.Property(e => e.OldContainerNo).HasMaxLength(255);
            entity.Property(e => e.OldMaterialQrcode)
                .HasMaxLength(1000)
                .HasColumnName("OldMaterialQRCode");
            entity.Property(e => e.OldNumber).HasPrecision(18, 2);
        });

        modelBuilder.Entity<BindingMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BindingMain", tb => tb.HasComment("托盘库PDA组盘主表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("库区编号");
            entity.Property(e => e.Batch)
                .HasMaxLength(255)
                .HasComment("批次");
            entity.Property(e => e.BillItemNo)
                .HasMaxLength(255)
                .HasComment("行号")
                .HasColumnName("Bill_Item_NO");
            entity.Property(e => e.BillNo)
                .HasMaxLength(255)
                .HasComment("单号（可以是收货单号，移储入库单号，退料入库单号）")
                .HasColumnName("Bill_NO");
            entity.Property(e => e.BindingId)
                .HasMaxLength(100)
                .HasComment("唯一码")
                .HasColumnName("BindingID");
            entity.Property(e => e.CacheLocationNo)
                .HasMaxLength(50)
                .HasComment("收货组盘缓存位编号");
            entity.Property(e => e.ChildContainerCode)
                .HasMaxLength(50)
                .HasComment("子托盘流水号");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(50)
                .HasComment("母托盘号（自动绑定时填入母托盘号）");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .HasComment("工厂编码");
            entity.Property(e => e.IsBindChildContainerCode)
                .HasMaxLength(100)
                .HasComment("是否绑定子托条码(1为不绑定子托)");
            entity.Property(e => e.IsCallAgv).HasComment("是否已呼叫AGV(0未呼叫，1为已成功呼叫，2为人工模式无需呼叫AGV)");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(255)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.Liktx)
                .HasMaxLength(255)
                .HasComment("供应商描述")
                .HasColumnName("LIKTX");
            entity.Property(e => e.MadeDate)
                .HasComment("生产日期")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.MaterialType)
                .HasMaxLength(50)
                .HasComment("物料类型(物料、母托垛、子托垛、空包装、围板)");
            entity.Property(e => e.Matnr)
                .HasMaxLength(255)
                .HasComment("物料号")
                .HasColumnName("MATNR");
            entity.Property(e => e.NewNumberTotal)
                .HasPrecision(18, 2)
                .HasComment("整托当前装载数量（组盘后在线翻包后会改变）");
            entity.Property(e => e.OldNumberTotal)
                .HasPrecision(18, 2)
                .HasComment("整托来料装载数量（组盘后不会再发生改变）");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasComment("状态(有效、无效)");
            entity.Property(e => e.StockInType)
                .HasMaxLength(50)
                .HasComment("入库类别（收货入库、移储入库、退料入库）");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(120)
                .HasComment("仓库编号");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("BYD仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<BindingMainLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BindingMainLog")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.Batch).HasMaxLength(255);
            entity.Property(e => e.BillItemNo)
                .HasMaxLength(255)
                .HasColumnName("Bill_Item_NO");
            entity.Property(e => e.BillNo)
                .HasMaxLength(255)
                .HasColumnName("Bill_NO");
            entity.Property(e => e.BindingId)
                .HasMaxLength(100)
                .HasColumnName("BindingID");
            entity.Property(e => e.CacheLocationNo).HasMaxLength(50);
            entity.Property(e => e.ChildContainerCode).HasMaxLength(50);
            entity.Property(e => e.ContainerCode).HasMaxLength(50);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(50);
            entity.Property(e => e.FactoryNo).HasMaxLength(50);
            entity.Property(e => e.IsBindChildContainerCode).HasMaxLength(100);
            entity.Property(e => e.Lifnr)
                .HasMaxLength(255)
                .HasColumnName("LIFNR");
            entity.Property(e => e.Liktx)
                .HasMaxLength(255)
                .HasColumnName("LIKTX");
            entity.Property(e => e.MadeDate).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.MaterialType).HasMaxLength(50);
            entity.Property(e => e.Matnr)
                .HasMaxLength(255)
                .HasColumnName("MATNR");
            entity.Property(e => e.NewNumberTotal).HasPrecision(18, 2);
            entity.Property(e => e.OldNumberTotal).HasPrecision(18, 2);
            entity.Property(e => e.Status).HasMaxLength(2);
            entity.Property(e => e.StockInType).HasMaxLength(50);
            entity.Property(e => e.WarehouseCode).HasMaxLength(120);
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<ButtonSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ButtonSetting", tb => tb.HasComment("按钮设置表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ButtonId)
                .HasMaxLength(36)
                .HasComment("按钮ID");
            entity.Property(e => e.ButtonMethodType)
                .HasMaxLength(50)
                .HasComment("按钮方法类型");
            entity.Property(e => e.Caption)
                .HasMaxLength(50)
                .HasComment("中文标题");
            entity.Property(e => e.ComponentName)
                .HasMaxLength(50)
                .HasComment("组件名称");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.EnCaption)
                .HasMaxLength(50)
                .HasComment("英文标题");
            entity.Property(e => e.MasterSlave)
                .HasMaxLength(50)
                .HasComment("主从关系");
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.MethodName)
                .HasMaxLength(500)
                .HasComment("方法名称");
            entity.Property(e => e.OperationType)
                .HasMaxLength(50)
                .HasComment("操作类型");
            entity.Property(e => e.Sequence).HasComment("排序序号");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<ChangeContainerLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChangeContainerLog", tb => tb.HasComment("来料原箱翻包日志"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("库区编号");
            entity.Property(e => e.Batch)
                .HasMaxLength(255)
                .HasComment("批次");
            entity.Property(e => e.BeginTime)
                .HasComment("开始翻包时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.BillItemNo)
                .HasMaxLength(16)
                .HasComment("单行号");
            entity.Property(e => e.BillNo)
                .HasMaxLength(50)
                .HasComment("单号");
            entity.Property(e => e.ChangeContainerDate)
                .HasComment("翻包时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.ChangeContainerLogId)
                .HasMaxLength(100)
                .HasComment("唯一码")
                .HasColumnName("ChangeContainerLogID");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(255)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.Liktx)
                .HasMaxLength(255)
                .HasComment("供应商描述")
                .HasColumnName("LIKTX");
            entity.Property(e => e.MadeDate)
                .HasComment("生产日期")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Matnr)
                .HasMaxLength(255)
                .HasComment("物料号")
                .HasColumnName("MATNR");
            entity.Property(e => e.NewContainerNo)
                .HasMaxLength(255)
                .HasComment("EU箱号");
            entity.Property(e => e.NewNumber)
                .HasPrecision(32)
                .HasDefaultValue(0m)
                .HasComment("EU箱装载数量");
            entity.Property(e => e.OldContainerHigh)
                .HasMaxLength(255)
                .HasComment("原箱高");
            entity.Property(e => e.OldContainerLong)
                .HasMaxLength(255)
                .HasComment("原箱长");
            entity.Property(e => e.OldContainerNo)
                .HasMaxLength(255)
                .HasComment("原箱号");
            entity.Property(e => e.OldContainerWidth)
                .HasMaxLength(255)
                .HasComment("原箱宽");
            entity.Property(e => e.OldMaterialQrcode)
                .HasMaxLength(1000)
                .HasComment("原箱物料标签二维码")
                .HasColumnName("OldMaterialQRCode");
            entity.Property(e => e.OldNumber)
                .HasPrecision(32)
                .HasDefaultValue(0m)
                .HasComment("来料装载数量");
            entity.Property(e => e.Operator)
                .HasMaxLength(50)
                .HasComment("操作人");
            entity.Property(e => e.StationNo)
                .HasMaxLength(255)
                .HasComment("翻包台编号");
            entity.Property(e => e.UrnPackStation)
                .HasMaxLength(255)
                .HasComment("装配工位")
                .HasColumnName("URN_Pack_Station");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(120)
                .HasComment("仓库编号");
            entity.Property(e => e.Werks)
                .HasMaxLength(100)
                .HasComment("工厂代码")
                .HasColumnName("WERKS");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(100)
                .HasComment("仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<ChartSettingInfo>(entity =>
        {
            entity.HasKey(e => e.ChartId).HasName("ChartSettingInfo_pkey");

            entity
                .ToTable("ChartSettingInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ChartId).HasMaxLength(36);
            entity.Property(e => e.ChartSpan).HasMaxLength(50);
            entity.Property(e => e.ChartType).HasMaxLength(50);
            entity.Property(e => e.Sql).HasMaxLength(2000);
            entity.Property(e => e.TitleName).HasMaxLength(50);
        });

        modelBuilder.Entity<ColumnHeatSet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ColumnHeatSet", tb => tb.HasComment("列热度设置表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("库区编号");
            entity.Property(e => e.ColumnEnd).HasComment("列结束");
            entity.Property(e => e.ColumnHeat).HasComment("热度值");
            entity.Property(e => e.ColumnInfoId)
                .HasMaxLength(120)
                .HasComment("唯一标识")
                .HasColumnName("ColumnInfoID");
            entity.Property(e => e.ColumnStart).HasComment("列开始");
            entity.Property(e => e.LayerEnd).HasComment("层结束");
            entity.Property(e => e.LayerStart).HasComment("层开始");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(120)
                .HasComment("仓库编号");
        });

        modelBuilder.Entity<ContainerInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ContainerInfo", tb => tb.HasComment("容器表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ContainerCode)
                .HasMaxLength(50)
                .HasComment("容器号");
            entity.Property(e => e.ContainerId)
                .HasMaxLength(36)
                .HasComment("唯一码");
            entity.Property(e => e.ContainerType)
                .HasMaxLength(50)
                .HasComment("容器类型");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
        });

        modelBuilder.Entity<ContainerTypeInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ContainerTypeInfo", tb => tb.HasComment("容器类型表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ContainerCodeRule)
                .HasMaxLength(200)
                .HasComment("容器规则");
            entity.Property(e => e.ContainerTypeCode)
                .HasMaxLength(50)
                .HasComment("类型编码");
            entity.Property(e => e.ContainerTypeId)
                .HasMaxLength(36)
                .HasComment("唯一码");
            entity.Property(e => e.ContainerTypeName)
                .HasMaxLength(50)
                .HasComment("类型名称");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasComment("描述");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<DictDataInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DictDataInfo", tb => tb.HasComment("数据字典"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AlternateData)
                .HasMaxLength(500)
                .HasComment("备用");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.DictCode)
                .HasMaxLength(200)
                .HasComment("字典编码");
            entity.Property(e => e.DictGroup)
                .HasMaxLength(200)
                .HasComment("字典分组");
            entity.Property(e => e.DictId)
                .HasMaxLength(36)
                .HasComment("字典标识");
            entity.Property(e => e.DictName)
                .HasMaxLength(500)
                .HasComment("字典名称");
            entity.Property(e => e.DictType)
                .HasMaxLength(50)
                .HasComment("字典类型");
            entity.Property(e => e.Sequence).HasComment("字典排序");
            entity.Property(e => e.StateCode).HasComment("状态");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<DiscontinuousColumnInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DiscontinuousColumnInfo", tb => tb.HasComment("料箱库有阻挡列设置表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.DiscontinuousColumn).HasComment("列号");
            entity.Property(e => e.DiscontinuousColumnInfoId)
                .HasMaxLength(50)
                .HasComment("唯一标识")
                .HasColumnName("DiscontinuousColumnInfoID");
            entity.Property(e => e.LaneEnd).HasComment("巷道结束");
            entity.Property(e => e.LaneStart).HasComment("巷道开始");
            entity.Property(e => e.LayerEnd).HasComment("层结束");
            entity.Property(e => e.LayerStart).HasComment("层开始");
            entity.Property(e => e.RowEnd).HasComment("行结束");
            entity.Property(e => e.RowStart).HasComment("行开始");
        });

        modelBuilder.Entity<ErrorInterfaceLogInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ErrorInterfaceLogInfo", tb => tb.HasComment("BYD-WMS接口异常日志表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.InterfaceCode)
                .HasMaxLength(50)
                .HasComment("接口编码");
            entity.Property(e => e.InterfaceName)
                .HasMaxLength(50)
                .HasComment("接口名称");
            entity.Property(e => e.Keyword1)
                .HasMaxLength(50)
                .HasComment("关键词1");
            entity.Property(e => e.Keyword2)
                .HasMaxLength(50)
                .HasComment("关键词2");
            entity.Property(e => e.LogId)
                .HasMaxLength(50)
                .HasComment("唯一标识");
            entity.Property(e => e.RequestBody).HasComment("请求内容");
            entity.Property(e => e.ResponseBody).HasComment("响应内容");
            entity.Property(e => e.State).HasComment("状态");
            entity.Property(e => e.Stopwatch).HasComment("计时");
        });

        modelBuilder.Entity<EucallHisLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EUCallHisLog")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CallNum).HasComment("呼叫数量");
            entity.Property(e => e.CallStation)
                .HasMaxLength(50)
                .HasComment("呼叫站点");
            entity.Property(e => e.CallTime)
                .HasComment("呼叫时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.CompleteNum).HasComment("已完成数量");
            entity.Property(e => e.ContainerType)
                .HasMaxLength(50)
                .HasComment("EU箱类型");
            entity.Property(e => e.EuContainerCodes)
                .HasMaxLength(1000)
                .HasComment("呼叫的EU箱号(多个)");
            entity.Property(e => e.EucallLogId)
                .HasMaxLength(50)
                .HasComment("唯一编码")
                .HasColumnName("EUCallLogID");
            entity.Property(e => e.IsComplete).HasComment("是否已完成 0未完成 1已完成");
            entity.Property(e => e.TargetEquipmentCode)
                .HasMaxLength(50)
                .HasComment("目标设备");
            entity.Property(e => e.TrayContainerCode)
                .HasMaxLength(50)
                .HasComment("呼叫托盘号");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(50)
                .HasComment("仓库编号");
        });

        modelBuilder.Entity<EucallLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EUCallLog", tb => tb.HasComment("空EU箱呼叫记录"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CallNum).HasComment("呼叫数量");
            entity.Property(e => e.CallStation)
                .HasMaxLength(50)
                .HasComment("呼叫站点");
            entity.Property(e => e.CallTime)
                .HasComment("呼叫时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.CompleteNum).HasComment("已完成数量");
            entity.Property(e => e.ContainerType)
                .HasMaxLength(50)
                .HasComment("EU箱类型");
            entity.Property(e => e.EuContainerCodes)
                .HasMaxLength(1000)
                .HasComment("呼叫的EU箱号(多个)");
            entity.Property(e => e.EucallLogId)
                .HasMaxLength(50)
                .HasComment("唯一编码")
                .HasColumnName("EUCallLogID");
            entity.Property(e => e.IsComplete).HasComment("是否已完成 0未完成 1已完成");
            entity.Property(e => e.TargetEquipmentCode)
                .HasMaxLength(50)
                .HasComment("目标设备");
            entity.Property(e => e.TrayContainerCode)
                .HasMaxLength(50)
                .HasComment("呼叫托盘号");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(50)
                .HasComment("仓库编号");
        });

        modelBuilder.Entity<EucomeBack>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EUComeBack", tb => tb.HasComment("回库空EU箱列表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ArriveTime)
                .HasComment("扫码时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.CallFlag).HasComment("是否已匹配呼叫 0未匹配 1已匹配");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(50)
                .HasComment("空箱条码");
            entity.Property(e => e.ContainerType)
                .HasMaxLength(50)
                .HasComment("EU箱类型");
            entity.Property(e => e.EucomeBackId)
                .HasMaxLength(50)
                .HasComment("唯一编码")
                .HasColumnName("EUComeBackID");
            entity.Property(e => e.TargetEquipmentCode)
                .HasMaxLength(50)
                .HasComment("目标设备");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(50)
                .HasComment("仓库编号");
        });

        modelBuilder.Entity<EventLogInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EventLogInfo", tb => tb.HasComment("事件日志"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ContainerBarcode)
                .HasMaxLength(8000)
                .HasComment("料箱码/托盘号");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.EquipmentCode)
                .HasMaxLength(50)
                .HasComment("设备编码");
            entity.Property(e => e.EventLevel).HasComment("级别");
            entity.Property(e => e.EventLog)
                .HasMaxLength(8000)
                .HasComment("日志内容");
            entity.Property(e => e.EventLogEn).HasMaxLength(8000);
            entity.Property(e => e.EventLogId)
                .HasMaxLength(36)
                .HasComment("唯一标识");
            entity.Property(e => e.EventLogThird).HasMaxLength(4000);
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
        });

        modelBuilder.Entity<Factory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Factory", tb => tb.HasComment("工厂表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("立库区域编号");
            entity.Property(e => e.ChildFactoryNo)
                .HasMaxLength(2000)
                .HasComment("关联的分厂代码");
            entity.Property(e => e.FactoryId)
                .HasMaxLength(50)
                .HasComment("唯一标识");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .HasComment("工厂编码");
            entity.Property(e => e.IsBranchFactory).HasComment("是否分厂");
            entity.Property(e => e.SysCode)
                .HasMaxLength(50)
                .HasComment("立库标识");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(50)
                .HasComment("立库仓库编号");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(50)
                .HasComment("BYD仓库编号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<FaultCodeInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FaultCodeInfo", tb => tb.HasComment("故障代码表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasComment("描述");
            entity.Property(e => e.EquipmentType)
                .HasMaxLength(50)
                .HasComment("设备类型(0、平面设备1、堆垛机设备2、机械手)");
            entity.Property(e => e.FaultCode)
                .HasMaxLength(50)
                .HasComment("故障代码");
            entity.Property(e => e.FaultCodeId)
                .HasMaxLength(36)
                .HasComment("故障代码表ID");
            entity.Property(e => e.FaultName)
                .HasMaxLength(500)
                .HasComment("故障名称");
            entity.Property(e => e.IsEnable).HasComment("是否启用");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<FaultLogInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FaultLogInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.EndTime)
                .HasComment("结束时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.EquipmentCode)
                .HasMaxLength(50)
                .HasComment("设备号");
            entity.Property(e => e.EquipmentType)
                .HasMaxLength(50)
                .HasComment("设备类型");
            entity.Property(e => e.FaultCode)
                .HasMaxLength(50)
                .HasComment("报警代码");
            entity.Property(e => e.FaultLogId)
                .HasMaxLength(36)
                .HasComment("唯一ID");
            entity.Property(e => e.IsEnd)
                .HasComment("是否结束")
                .HasColumnType("bit(255)");
            entity.Property(e => e.IsPushResult)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'::character varying")
                .HasComment(" 是否推送完成结果(待推送0，推送完成1)");
            entity.Property(e => e.IsPushfixTimeResult)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'::character varying")
                .HasComment(" 是否推送修复时间完成结果(待推送0，推送完成1)");
        });

        modelBuilder.Entity<FieldSetting>(entity =>
        {
            entity.HasKey(e => e.FieldId).HasName("FieldSetting_pkey");

            entity
                .ToTable("FieldSetting", tb => tb.HasComment("字段设置表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.FieldId)
                .HasMaxLength(36)
                .HasComment("字段设置表ID");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(500)
                .HasComment("默认值");
            entity.Property(e => e.EnTitle)
                .HasMaxLength(200)
                .HasComment("字段英文名称");
            entity.Property(e => e.EnableType)
                .HasMaxLength(50)
                .HasComment("是否可用");
            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .HasComment("字段名");
            entity.Property(e => e.Format)
                .HasMaxLength(200)
                .HasComment("显示格式");
            entity.Property(e => e.IsSave).HasComment("是否保存");
            entity.Property(e => e.IsSummary).HasComment("是否汇总，1是，0否");
            entity.Property(e => e.Linkage)
                .HasMaxLength(500)
                .HasComment("链接页面");
            entity.Property(e => e.PrimaryKey).HasComment("是否主键");
            entity.Property(e => e.QueryDefault)
                .HasMaxLength(500)
                .HasComment("查询默认值");
            entity.Property(e => e.QueryType)
                .HasMaxLength(50)
                .HasComment("查询类型");
            entity.Property(e => e.Required).HasComment("是否必须");
            entity.Property(e => e.SelectSetting)
                .HasMaxLength(2000)
                .HasComment("选择设置信息");
            entity.Property(e => e.SelectType)
                .HasMaxLength(20)
                .HasComment("选择类型");
            entity.Property(e => e.Sequence).HasComment("排序编号");
            entity.Property(e => e.SortSequence).HasComment("排序编号");
            entity.Property(e => e.SortType)
                .HasMaxLength(50)
                .HasComment("排序类型");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .HasComment("表名");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasComment("字段名称");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasComment("字段类型");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
            entity.Property(e => e.VisibleType)
                .HasMaxLength(50)
                .HasComment("是否显示");
            entity.Property(e => e.Width).HasComment("字段宽度");
        });

        modelBuilder.Entity<HeatSet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HeatSet", tb => tb.HasComment("热度设置表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("区域编码");
            entity.Property(e => e.ColumnEnd).HasComment("列结束");
            entity.Property(e => e.ColumnStart).HasComment("列开始");
            entity.Property(e => e.Heat).HasComment("热度值");
            entity.Property(e => e.HeatSetId)
                .HasMaxLength(50)
                .HasComment("唯一标识");
            entity.Property(e => e.LayerEnd).HasComment("层结束");
            entity.Property(e => e.LayerStart).HasComment("层开始");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(50)
                .HasComment("仓库编码");
        });

        modelBuilder.Entity<InBoundDetailInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InBoundDetailInfo", tb => tb.HasComment("入库单明细表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ActualQty)
                .HasPrecision(18, 2)
                .HasComment("实发数量");
            entity.Property(e => e.BillLineNo)
                .HasMaxLength(50)
                .HasComment("单行号");
            entity.Property(e => e.BillNo)
                .HasMaxLength(50)
                .HasComment("单号");
            entity.Property(e => e.BillQty)
                .HasPrecision(18, 2)
                .HasComment("原单数量");
            entity.Property(e => e.BillType)
                .HasMaxLength(50)
                .HasComment("单据类别");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.DetailStatus).HasComment("0：已创建 、1：已完成组盘、2：已部分回传、3：已全部回传、4：已关闭");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .HasComment("工厂编码");
            entity.Property(e => e.InBoundDetailInfoId)
                .HasMaxLength(50)
                .HasComment("唯一码");
            entity.Property(e => e.InBoundHeaderInfoId)
                .HasMaxLength(50)
                .HasComment("入库主单Id");
            entity.Property(e => e.Lgort)
                .HasMaxLength(50)
                .HasComment("库存地点")
                .HasColumnName("LGORT");
            entity.Property(e => e.LotNo)
                .HasMaxLength(50)
                .HasComment("批次号");
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(50)
                .HasComment("物料编码");
            entity.Property(e => e.MaterialId)
                .HasMaxLength(100)
                .HasComment("物料ID");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(100)
                .HasComment("物料名称");
            entity.Property(e => e.PostCount)
                .HasPrecision(18, 2)
                .HasComment("已上报数量");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("备注");
            entity.Property(e => e.StockType)
                .HasMaxLength(50)
                .HasComment("库存类型");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(100)
                .HasComment("供应商代码");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(100)
                .HasComment("供应商名称");
            entity.Property(e => e.UnitCode)
                .HasMaxLength(50)
                .HasComment("基本计量单位");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(32)
                .HasComment("BYD仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<InBoundHeaderHisInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InBoundHeaderHisInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("区域编号");
            entity.Property(e => e.BillFrom)
                .HasMaxLength(10)
                .HasComment("单据来源");
            entity.Property(e => e.BillNo)
                .HasMaxLength(100)
                .HasComment("单号");
            entity.Property(e => e.BillStatus).HasComment("0：已创建 、1：已完成组盘、2：已部分回传、4：已关闭、5：已完成");
            entity.Property(e => e.BillType)
                .HasMaxLength(100)
                .HasComment("单据类型");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.FinishTime)
                .HasComment("完成时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.InBoundHeaderInfoId)
                .HasMaxLength(100)
                .HasComment("唯一码");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("备注");
            entity.Property(e => e.UpdateTime)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("更新人");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(50)
                .HasComment("仓库编号");
        });

        modelBuilder.Entity<InBoundHeaderInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InBoundHeaderInfo", tb => tb.HasComment("入库单主表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("区域编号");
            entity.Property(e => e.BillFrom)
                .HasMaxLength(10)
                .HasComment("单据来源");
            entity.Property(e => e.BillNo)
                .HasMaxLength(100)
                .HasComment("单号");
            entity.Property(e => e.BillStatus).HasComment("0：已创建 、1：已完成组盘、2：已部分回传、4：已关闭、5：已完成");
            entity.Property(e => e.BillType)
                .HasMaxLength(100)
                .HasComment("单据类型");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.FinishTime)
                .HasComment("完成时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.InBoundHeaderInfoId)
                .HasMaxLength(100)
                .HasComment("唯一码");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("备注");
            entity.Property(e => e.UpdateTime)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("更新人");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(50)
                .HasComment("仓库编号");
        });

        modelBuilder.Entity<InBoundHisDetailInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InBoundHisDetailInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ActualQty)
                .HasPrecision(18, 2)
                .HasComment("实发数量");
            entity.Property(e => e.BillLineNo)
                .HasMaxLength(50)
                .HasComment("单行号");
            entity.Property(e => e.BillNo)
                .HasMaxLength(50)
                .HasComment("单号");
            entity.Property(e => e.BillQty)
                .HasPrecision(18, 2)
                .HasComment("原单数量");
            entity.Property(e => e.BillType)
                .HasMaxLength(50)
                .HasComment("单据类别");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.DetailStatus).HasComment("0：已创建 、1：已完成组盘、2：已部分回传、3：已全部回传、4：已关闭");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .HasComment("工厂编码");
            entity.Property(e => e.InBoundDetailInfoId)
                .HasMaxLength(50)
                .HasComment("唯一码");
            entity.Property(e => e.InBoundHeaderInfoId)
                .HasMaxLength(50)
                .HasComment("入库主单Id");
            entity.Property(e => e.Lgort)
                .HasMaxLength(50)
                .HasComment("库存地点")
                .HasColumnName("LGORT");
            entity.Property(e => e.LotNo)
                .HasMaxLength(50)
                .HasComment("批次号");
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(50)
                .HasComment("物料编码");
            entity.Property(e => e.MaterialId)
                .HasMaxLength(100)
                .HasComment("物料ID");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(100)
                .HasComment("物料名称");
            entity.Property(e => e.PostCount)
                .HasPrecision(18, 2)
                .HasComment("已上报数量");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("备注");
            entity.Property(e => e.StockType)
                .HasMaxLength(50)
                .HasComment("库存类型");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(100)
                .HasComment("供应商代码");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(100)
                .HasComment("供应商名称");
            entity.Property(e => e.UnitCode)
                .HasMaxLength(50)
                .HasComment("基本计量单位");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("BYD仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<InterfaceInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InterfaceInfo", tb => tb.HasComment("接口设置表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasComment("描述");
            entity.Property(e => e.InterfaceCode)
                .HasMaxLength(50)
                .HasComment("接口编码");
            entity.Property(e => e.InterfaceId)
                .HasMaxLength(36)
                .HasComment("唯一标识");
            entity.Property(e => e.InterfaceName)
                .HasMaxLength(50)
                .HasComment("接口名称");
            entity.Property(e => e.InterfaceUrl)
                .HasMaxLength(100)
                .HasComment("接口地址");
            entity.Property(e => e.IsEnable).HasComment("是否启用");
            entity.Property(e => e.RequestMethod)
                .HasMaxLength(50)
                .HasComment("请求方法");
            entity.Property(e => e.Timeout).HasComment("是否超时");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<InterfaceLogInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InterfaceLogInfo", tb => tb.HasComment("接口日志表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.InterfaceCode)
                .HasMaxLength(50)
                .HasComment("接口编码");
            entity.Property(e => e.InterfaceName)
                .HasMaxLength(50)
                .HasComment("接口名称");
            entity.Property(e => e.Keyword1)
                .HasMaxLength(50)
                .HasComment("关键词1");
            entity.Property(e => e.Keyword2)
                .HasMaxLength(50)
                .HasComment("关键词2");
            entity.Property(e => e.LogId)
                .HasMaxLength(50)
                .HasComment("唯一标识");
            entity.Property(e => e.RequestBody).HasComment("请求内容");
            entity.Property(e => e.ResponseBody).HasComment("响应内容");
            entity.Property(e => e.State).HasComment("状态");
            entity.Property(e => e.Stopwatch).HasComment("计时");
        });

        modelBuilder.Entity<InventoryLocationInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InventoryLocationInfo", tb => tb.HasComment("库位和容器对应表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ContainerCode)
                .HasMaxLength(50)
                .HasComment("容器ID");
            entity.Property(e => e.InventoryId)
                .HasMaxLength(36)
                .HasComment("库存ID");
            entity.Property(e => e.InventoryLocationId)
                .HasMaxLength(36)
                .HasComment("唯一标识");
            entity.Property(e => e.LocationId)
                .HasMaxLength(36)
                .HasComment("库位ID");
        });

        modelBuilder.Entity<InventoryLocationInfoCopy1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InventoryLocationInfo_copy1", tb => tb.HasComment("库位和容器对应表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ContainerCode)
                .HasMaxLength(50)
                .HasComment("容器ID");
            entity.Property(e => e.InventoryId)
                .HasMaxLength(36)
                .HasComment("库存ID");
            entity.Property(e => e.InventoryLocationId)
                .HasMaxLength(36)
                .HasComment("唯一标识");
            entity.Property(e => e.LocationId)
                .HasMaxLength(36)
                .HasComment("库位ID");
        });

        modelBuilder.Entity<LabelStationInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LabelStationInfo", tb => tb.HasComment("标签打印机配置"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasComment("创建人");
            entity.Property(e => e.Id)
                .HasMaxLength(120)
                .HasComment("唯一标识");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(120)
                .HasComment("IP地址")
                .HasColumnName("IPAddress");
            entity.Property(e => e.Ipport)
                .HasMaxLength(120)
                .HasComment("IP端口")
                .HasColumnName("IPPort");
            entity.Property(e => e.IsCheckEnable).HasComment("是否启用");
            entity.Property(e => e.LabelName)
                .HasMaxLength(200)
                .HasComment("贴标机名称");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("打印机名称");
            entity.Property(e => e.StationId)
                .HasMaxLength(120)
                .HasComment("工位编号");
        });

        modelBuilder.Entity<LayerInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LayerInfo", tb => tb.HasComment("料箱库层状态表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasComment("创建人");
            entity.Property(e => e.HasCar).HasComment("是否有车");
            entity.Property(e => e.Height).HasComment("层高");
            entity.Property(e => e.IsCompatible).HasComment("是否兼容多尺寸料箱");
            entity.Property(e => e.LayerCode).HasComment("层号");
            entity.Property(e => e.LayerInfoId)
                .HasMaxLength(120)
                .HasComment("唯一标识")
                .HasColumnName("LayerInfoID");
            entity.Property(e => e.SpecialEu)
                .HasMaxLength(50)
                .HasComment("专用料箱类型比如：EU8628,86代表800*600,28代表高度280")
                .HasColumnName("SpecialEU");
            entity.Property(e => e.StackerCode)
                .HasMaxLength(120)
                .HasComment("巷道号");
            entity.Property(e => e.State).HasComment("层状态：1正常；2不可用(人工禁用)；");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(100)
                .HasComment("修改人");
        });

        modelBuilder.Entity<LocationGroupInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LocationGroupInfo", tb => tb.HasComment("库位分组表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.EquipmentCode)
                .HasMaxLength(50)
                .HasComment("巷道编号");
            entity.Property(e => e.IsEnable).HasComment("是否启用");
            entity.Property(e => e.LocationColumnEnd).HasComment("终止列");
            entity.Property(e => e.LocationColumnStart).HasComment("起始列");
            entity.Property(e => e.LocationGroupCode)
                .HasMaxLength(50)
                .HasComment("货位分组编号");
            entity.Property(e => e.LocationGroupId)
                .HasMaxLength(36)
                .HasComment("唯一标识")
                .HasColumnName("LocationGroupID");
            entity.Property(e => e.LocationGroupName)
                .HasMaxLength(50)
                .HasComment("货位分组名称");
            entity.Property(e => e.LocationLayerEnd).HasComment("终止层");
            entity.Property(e => e.LocationLayerStart).HasComment("起始层");
            entity.Property(e => e.LocationRowEnd).HasComment("终止行");
            entity.Property(e => e.LocationRowStart).HasComment("起始行");
            entity.Property(e => e.Priority).HasComment("优先级");
        });

        modelBuilder.Entity<LocationInfo>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("LocationInfo_pkey");

            entity
                .ToTable("LocationInfo", tb => tb.HasComment("库位表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasComment("唯一标识");
            entity.Property(e => e.AreaId)
                .HasMaxLength(50)
                .HasComment("区域");
            entity.Property(e => e.ContainerBarcode)
                .HasMaxLength(50)
                .HasComment("料箱号");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.EquipmentCode)
                .HasMaxLength(50)
                .HasComment("巷道编号");
            entity.Property(e => e.FireState).HasComment("检测柜状态");
            entity.Property(e => e.InboundTime)
                .HasComment("入库时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.IsEnable).HasComment("是否可用");
            entity.Property(e => e.LocationColumn).HasComment("列");
            entity.Property(e => e.LocationDepth).HasComment("深度");
            entity.Property(e => e.LocationLayer).HasComment("层");
            entity.Property(e => e.LocationLine).HasComment("行");
            entity.Property(e => e.LocationNumber)
                .HasMaxLength(50)
                .HasComment("货位编号");
            entity.Property(e => e.LocationState)
                .HasMaxLength(50)
                .HasComment("货位状态");
            entity.Property(e => e.LocationType)
                .HasMaxLength(50)
                .HasComment("货位类型");
            entity.Property(e => e.LocationUse)
                .HasMaxLength(50)
                .HasComment("货位用途");
            entity.Property(e => e.OutboundTime)
                .HasComment("出库时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.StatusCode).HasComment("检测柜状态");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
            entity.Property(e => e.WarehouseId)
                .HasMaxLength(50)
                .HasComment("仓库");
        });

        modelBuilder.Entity<LogKeyWord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LogKeyWord")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AlternateData).HasMaxLength(500);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(50);
            entity.Property(e => e.KeyWord).HasMaxLength(200);
            entity.Property(e => e.KeyWordEn).HasMaxLength(200);
            entity.Property(e => e.KeyWordGroup).HasMaxLength(200);
            entity.Property(e => e.KeyWordId).HasMaxLength(36);
            entity.Property(e => e.KeyWordThird).HasMaxLength(200);
            entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator).HasMaxLength(50);
        });

        modelBuilder.Entity<MasterSlaveSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MasterSlaveSetting", tb => tb.HasComment("主从关系表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.MasterSlaveCode)
                .HasMaxLength(50)
                .HasComment("主从表编码");
            entity.Property(e => e.MasterSlaveId)
                .HasMaxLength(36)
                .HasComment("主从表关联ID");
            entity.Property(e => e.MasterTable)
                .HasMaxLength(50)
                .HasComment("主表");
            entity.Property(e => e.SlaveRelation)
                .HasMaxLength(50)
                .HasComment("关联字段");
            entity.Property(e => e.SlaveTable)
                .HasMaxLength(50)
                .HasComment("从表");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Material", tb => tb.HasComment("物料主数据表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(120)
                .HasComment("区域编码");
            entity.Property(e => e.BasePackingTypeCode)
                .HasMaxLength(120)
                .HasComment("计量单位");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(50)
                .HasDefaultValueSql("0")
                .HasComment("是否可用");
            entity.Property(e => e.IsSmallPiece).HasComment("是否料箱库物料(0是未设置，1是料箱库，2不是料箱库物料)");
            entity.Property(e => e.IsThrough).HasComment("是否直通");
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(150)
                .HasComment("物料编码");
            entity.Property(e => e.MaterialDescription)
                .HasMaxLength(150)
                .HasComment("物料型号");
            entity.Property(e => e.MaterialHeat).HasComment("物料热度(0-3)值越大，热度越高，离入库口出库口最近");
            entity.Property(e => e.MaterialId)
                .HasMaxLength(120)
                .HasComment("唯一标识");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(180)
                .HasComment("物料名称");
            entity.Property(e => e.MaterialPriority).HasComment("物料优先级(值越大，出库优先级越高)");
            entity.Property(e => e.MaterialSpec)
                .HasMaxLength(150)
                .HasComment("物料规格");
            entity.Property(e => e.MaterialTypeCode)
                .HasMaxLength(120)
                .HasComment("类型名称");
            entity.Property(e => e.MaxSaftyStock)
                .HasPrecision(18, 2)
                .HasComment("料箱库区安全库存下警戒位");
            entity.Property(e => e.MinSaftyStock)
                .HasPrecision(18, 2)
                .HasComment("料箱库区安全库存上警戒位");
            entity.Property(e => e.UpdateTime)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.WeightLowerLimit)
                .HasPrecision(18, 2)
                .HasComment("重量下限");
            entity.Property(e => e.WeightUpperLimit)
                .HasPrecision(18, 2)
                .HasComment("重量上限");
        });

        modelBuilder.Entity<MaterialDemandPlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MaterialDemandPlan", tb => tb.HasComment("配料拉动需求单"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.Area)
                .HasMaxLength(32)
                .HasComment("储位")
                .HasColumnName("AREA");
            entity.Property(e => e.Beikz)
                .HasMaxLength(32)
                .HasComment("物料供应标识")
                .HasColumnName("BEIKZ");
            entity.Property(e => e.BurdenSheetId)
                .HasComment("行项目号")
                .HasColumnName("BURDEN_SHEET_ID");
            entity.Property(e => e.BurdenSheetNo)
                .HasMaxLength(32)
                .HasComment("配料单号")
                .HasColumnName("BURDEN_SHEET_NO");
            entity.Property(e => e.CalId)
                .HasMaxLength(32)
                .HasComment("版本号")
                .HasColumnName("CAL_ID");
            entity.Property(e => e.CarSeries)
                .HasMaxLength(32)
                .HasComment("车系")
                .HasColumnName("CAR_SERIES");
            entity.Property(e => e.CarSeriesBatch)
                .HasMaxLength(32)
                .HasComment("车系批次")
                .HasColumnName("CAR_SERIES_BATCH");
            entity.Property(e => e.ComSapMaterial)
                .HasMaxLength(32)
                .HasComment("零件物料号")
                .HasColumnName("COM_SAP_MATERIAL");
            entity.Property(e => e.ComSapMaterialDesc)
                .HasMaxLength(200)
                .HasComment("零件物料号描述")
                .HasColumnName("COM_SAP_MATERIAL_DESC");
            entity.Property(e => e.CompleteNumber).HasComment("已分配翻包数量");
            entity.Property(e => e.CreateDate)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.DemandDate)
                .HasComment("需求计划时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("DEMAND_DATE");
            entity.Property(e => e.ExecDate)
                .HasComment("生效时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("EXEC_DATE");
            entity.Property(e => e.IWmsrequestTime)
                .HasComment("同步时间（请求WMS接口时间）")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("iWMSRequestTime");
            entity.Property(e => e.IsComplete).HasComment("是否已完成分配 0未完成  1已完成  2已关闭");
            entity.Property(e => e.IsDeal).HasComment("导入数据是否已处理");
            entity.Property(e => e.IsEnable)
                .HasComment("有效性(0:无效 1:有效)")
                .HasColumnName("IS_ENABLE");
            entity.Property(e => e.IsNew)
                .HasComment("是否系统创建   1：系统创建 0：人工新增")
                .HasColumnName("IS_NEW");
            entity.Property(e => e.Lgort)
                .HasMaxLength(32)
                .HasComment("库存地点")
                .HasColumnName("LGORT");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(32)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.Line)
                .HasMaxLength(32)
                .HasComment("产线")
                .HasColumnName("LINE");
            entity.Property(e => e.Location)
                .HasMaxLength(32)
                .HasComment("库位地点")
                .HasColumnName("LOCATION");
            entity.Property(e => e.MaterialDemandPlanId)
                .HasMaxLength(50)
                .HasComment("唯一标识")
                .HasColumnName("MaterialDemandPlanID");
            entity.Property(e => e.Meins)
                .HasMaxLength(32)
                .HasComment("组建计量单位")
                .HasColumnName("MEINS");
            entity.Property(e => e.NeedNumber).HasComment("需要出库翻包的数量");
            entity.Property(e => e.PlanQty)
                .HasMaxLength(32)
                .HasComment("生产订单的整车料号数量")
                .HasColumnName("PLAN_QTY");
            entity.Property(e => e.ProiectNum)
                .HasMaxLength(32)
                .HasComment("项目号")
                .HasColumnName("PROIECT_NUM");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 2)
                .HasComment("生产数量")
                .HasColumnName("QTY");
            entity.Property(e => e.RealQty)
                .HasMaxLength(32)
                .HasComment("实发数量")
                .HasColumnName("REAL_QTY");
            entity.Property(e => e.SapMaterial)
                .HasMaxLength(32)
                .HasComment("整车物料号")
                .HasColumnName("SAP_MATERIAL");
            entity.Property(e => e.SapMaterialDesc)
                .HasMaxLength(200)
                .HasComment("整车物料号描述")
                .HasColumnName("SAP_MATERIAL_DESC");
            entity.Property(e => e.SapNo)
                .HasMaxLength(32)
                .HasComment("生产订单号")
                .HasColumnName("SAP_NO");
            entity.Property(e => e.SapStatus)
                .HasComment("sap 组件状态 0：未创建 1：创建中2：已创建3：创建失败， 4：已修改 ，默认值为 0")
                .HasColumnName("SAP_STATUS");
            entity.Property(e => e.SortId)
                .HasMaxLength(32)
                .HasComment("工位")
                .HasColumnName("SORT_ID");
            entity.Property(e => e.State)
                .HasComment("状态 1：未创建 2：已创建 3：发布提交 4：已发布 5：发布失败 6:计划修改")
                .HasColumnName("STATE");
            entity.Property(e => e.SupplineName)
                .HasMaxLength(32)
                .HasComment("供应商名称")
                .HasColumnName("SUPPLINE_NAME");
            entity.Property(e => e.Werks)
                .HasMaxLength(8)
                .HasComment("工厂代码")
                .HasColumnName("WERKS");
        });

        modelBuilder.Entity<MaterialTypeInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MaterialTypeInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Field1).HasMaxLength(50);
            entity.Property(e => e.Field10).HasMaxLength(50);
            entity.Property(e => e.Field2).HasMaxLength(50);
            entity.Property(e => e.Field3).HasMaxLength(50);
            entity.Property(e => e.Field4).HasMaxLength(50);
            entity.Property(e => e.Field5).HasMaxLength(50);
            entity.Property(e => e.Field6).HasMaxLength(50);
            entity.Property(e => e.Field7).HasMaxLength(50);
            entity.Property(e => e.Field8).HasMaxLength(50);
            entity.Property(e => e.Field9).HasMaxLength(50);
            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.MaterialTypeCode).HasMaxLength(100);
            entity.Property(e => e.MaterialTypeDescription).HasMaxLength(100);
            entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
        });

        modelBuilder.Entity<MenuInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MenuInfo", tb => tb.HasComment("菜单按钮"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.Close).HasComment("是否关闭");
            entity.Property(e => e.ComponentName)
                .HasMaxLength(50)
                .HasComment("组件名称");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasComment("描述");
            entity.Property(e => e.EnName)
                .HasMaxLength(200)
                .HasComment("英文名称");
            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .HasComment("图标");
            entity.Property(e => e.JumpUrl)
                .HasMaxLength(200)
                .HasComment("跳转地址");
            entity.Property(e => e.KeepAlive).HasComment("是否持活");
            entity.Property(e => e.LevelCode)
                .HasMaxLength(50)
                .HasComment("权限等级");
            entity.Property(e => e.MenuId)
                .HasMaxLength(36)
                .HasComment("菜单信息表ID(主键、非空)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("菜单名称");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .HasComment("编号(1：一级菜单栏2：二级菜单栏)");
            entity.Property(e => e.ParentId)
                .HasMaxLength(36)
                .HasComment("父级菜单ID");
            entity.Property(e => e.ParentName)
                .HasMaxLength(50)
                .HasComment("父级菜单名称");
            entity.Property(e => e.Router)
                .HasMaxLength(200)
                .HasComment("路由");
            entity.Property(e => e.Show).HasComment("是否展示");
            entity.Property(e => e.State).HasComment("是否声明");
            entity.Property(e => e.ThirdName)
                .HasMaxLength(200)
                .HasComment("第三方语言名称");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .HasComment("URL地址");
        });

        modelBuilder.Entity<MenuPowerInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MenuPowerInfo", tb => tb.HasComment("菜单权限实体"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Delete).HasComment("删除权限");
            entity.Property(e => e.Display).HasComment("显示权限");
            entity.Property(e => e.Export).HasComment("导出权限");
            entity.Property(e => e.Import).HasComment("导入权限");
            entity.Property(e => e.Insert).HasComment("添加权限");
            entity.Property(e => e.MenuId)
                .HasMaxLength(36)
                .HasComment("菜单ID");
            entity.Property(e => e.MenuPowerId)
                .HasMaxLength(36)
                .HasComment("菜单权限表ID");
            entity.Property(e => e.Operates)
                .HasMaxLength(5000)
                .HasComment("操作权限");
            entity.Property(e => e.Print).HasComment("打印权限");
            entity.Property(e => e.Save).HasComment("保存权限");
            entity.Property(e => e.Search).HasComment("检索权限");
            entity.Property(e => e.Update).HasComment("修改权限");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
        });

        modelBuilder.Entity<MonitorInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MonitorInfo", tb => tb.HasComment("监控布局信息表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.Data).HasComment("监控配置信息");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.MonitorId)
                .HasMaxLength(36)
                .HasComment("监控页面配置表ID");
            entity.Property(e => e.MonitorName)
                .HasMaxLength(50)
                .HasComment("监控页面名称");
            entity.Property(e => e.ProgramCode).HasMaxLength(50);
            entity.Property(e => e.ProgramUrl).HasMaxLength(50);
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<OutBoundDetailHisInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OutBoundDetailHisInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ActualQty)
                .HasPrecision(18, 2)
                .HasComment("实发数量");
            entity.Property(e => e.BillLineNo)
                .HasMaxLength(100)
                .HasComment("发货单行号");
            entity.Property(e => e.BillNo)
                .HasMaxLength(100)
                .HasComment("发货单号");
            entity.Property(e => e.BillQty)
                .HasPrecision(18, 2)
                .HasComment("发货单数量");
            entity.Property(e => e.BillType)
                .HasMaxLength(50)
                .HasComment("单据类型");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.DetailStatus).HasComment("0：已创建 、1：已部分分配、2、已全部分配、3：已部分回传、4：已全部回传、5、已关闭");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .HasComment("工厂编码");
            entity.Property(e => e.Lgort)
                .HasMaxLength(200)
                .HasComment("库存地点")
                .HasColumnName("LGORT");
            entity.Property(e => e.LotNo)
                .HasMaxLength(50)
                .HasComment("批次号");
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(50)
                .HasComment("物料编码");
            entity.Property(e => e.MaterialId)
                .HasMaxLength(100)
                .HasComment("物料ID");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(200)
                .HasComment("物料名称");
            entity.Property(e => e.OutBoundDetailInfoId)
                .HasMaxLength(100)
                .HasComment("唯一码");
            entity.Property(e => e.OutBoundHeaderInfoId)
                .HasMaxLength(50)
                .HasComment("出库主单Id");
            entity.Property(e => e.PostCount).HasComment("已上报数量");
            entity.Property(e => e.Priority).HasComment("优先级");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("备注");
            entity.Property(e => e.StockType)
                .HasMaxLength(50)
                .HasComment("库存类型");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(100)
                .HasComment("供应商代码");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(100)
                .HasComment("供应商名称");
            entity.Property(e => e.UnitCode)
                .HasMaxLength(50)
                .HasComment("基本计量单位");
            entity.Property(e => e.UpdateTime)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("更新人");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("BYD仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<OutBoundDetailInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OutBoundDetailInfo", tb => tb.HasComment("出库单明细表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ActualQty)
                .HasPrecision(18, 2)
                .HasComment("实发数量");
            entity.Property(e => e.BillLineNo)
                .HasMaxLength(100)
                .HasComment("发货单行号");
            entity.Property(e => e.BillNo)
                .HasMaxLength(100)
                .HasComment("发货单号");
            entity.Property(e => e.BillQty)
                .HasPrecision(18, 2)
                .HasComment("发货单数量");
            entity.Property(e => e.BillType)
                .HasMaxLength(50)
                .HasComment("单据类型");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.DetailStatus).HasComment("0：已创建 、1：已部分分配、2、已全部分配、3：已部分回传、4：已全部回传、5、已关闭");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .HasComment("工厂编码");
            entity.Property(e => e.Lgort)
                .HasMaxLength(200)
                .HasComment("库存地点")
                .HasColumnName("LGORT");
            entity.Property(e => e.LotNo)
                .HasMaxLength(50)
                .HasComment("批次号");
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(50)
                .HasComment("物料编码");
            entity.Property(e => e.MaterialId)
                .HasMaxLength(100)
                .HasComment("物料ID");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(200)
                .HasComment("物料名称");
            entity.Property(e => e.OutBoundDetailInfoId)
                .HasMaxLength(100)
                .HasComment("唯一码");
            entity.Property(e => e.OutBoundHeaderInfoId)
                .HasMaxLength(50)
                .HasComment("出库主单Id");
            entity.Property(e => e.PostCount).HasComment("已上报数量");
            entity.Property(e => e.Priority).HasComment("优先级");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("备注");
            entity.Property(e => e.StockType)
                .HasMaxLength(50)
                .HasComment("库存类型");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(100)
                .HasComment("供应商代码");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(100)
                .HasComment("供应商名称");
            entity.Property(e => e.UnitCode)
                .HasMaxLength(50)
                .HasComment("基本计量单位");
            entity.Property(e => e.UpdateTime)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("更新人");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("BYD仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<OutBoundHeaderHisInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OutBoundHeaderHisInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("区域编号");
            entity.Property(e => e.BillFrom)
                .HasMaxLength(10)
                .HasComment("单据来源");
            entity.Property(e => e.BillNo)
                .HasMaxLength(50)
                .HasComment("单号");
            entity.Property(e => e.BillStatus).HasComment("0：已创建 、1：已部分分配、2、已全部分配、3：已部分回传、4：已全部回传、5、已关闭");
            entity.Property(e => e.BillType)
                .HasMaxLength(50)
                .HasComment("单据类型");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.FinishTime)
                .HasComment("完成时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.OutBoundHeaderId)
                .HasMaxLength(50)
                .HasComment("唯一码");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("备注");
            entity.Property(e => e.UpdateTime)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasComment("更新人")
                .HasColumnType("character varying");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(50)
                .HasComment("仓库编号");
        });

        modelBuilder.Entity<OutBoundHeaderInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OutBoundHeaderInfo", tb => tb.HasComment("出库单主表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("区域编号");
            entity.Property(e => e.BillFrom)
                .HasMaxLength(10)
                .HasComment("单据来源");
            entity.Property(e => e.BillNo)
                .HasMaxLength(50)
                .HasComment("单号");
            entity.Property(e => e.BillStatus).HasComment("0：已创建 、1：已部分分配、2、已全部分配、3：已部分回传、4：已全部回传、5、已关闭");
            entity.Property(e => e.BillType)
                .HasMaxLength(50)
                .HasComment("单据类型");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.FinishTime)
                .HasComment("完成时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.OutBoundHeaderId)
                .HasMaxLength(50)
                .HasComment("唯一码");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("备注");
            entity.Property(e => e.UpdateTime)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasComment("更新人")
                .HasColumnType("character varying");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(50)
                .HasComment("仓库编号");
        });

        modelBuilder.Entity<OutHisStoreOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OutHisStoreOrder")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.Abbr)
                .HasMaxLength(255)
                .HasComment("SPS拣配储位")
                .HasColumnName("ABBR");
            entity.Property(e => e.AgvOnlineStrategy)
                .HasComment("AGV 上线策略")
                .HasColumnName("AGV_ONLINE_STRATEGY");
            entity.Property(e => e.Agvroute)
                .HasMaxLength(50)
                .HasComment("AGV路线")
                .HasColumnName("AGVROUTE");
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .HasComment("包装条码")
                .HasColumnName("BARCODE");
            entity.Property(e => e.Batch)
                .HasMaxLength(255)
                .HasComment("批次")
                .HasColumnName("BATCH");
            entity.Property(e => e.Bin)
                .HasMaxLength(255)
                .HasComment("线边储位")
                .HasColumnName("BIN");
            entity.Property(e => e.Bodyno)
                .HasMaxLength(255)
                .HasComment("车身号")
                .HasColumnName("BODYNO");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(255)
                .HasComment("业务类型名称")
                .HasColumnName("BUSINESS_NAME");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(255)
                .HasComment("业务类型")
                .HasColumnName("BUSINESS_TYPE");
            entity.Property(e => e.CarColor)
                .HasMaxLength(255)
                .HasComment("颜色")
                .HasColumnName("CAR_COLOR");
            entity.Property(e => e.CarType)
                .HasMaxLength(255)
                .HasComment("车型")
                .HasColumnName("CAR_TYPE");
            entity.Property(e => e.CompletePackQty)
                .HasPrecision(18, 2)
                .HasComment("完成箱数")
                .HasColumnName("COMPLETE_PACK_QTY");
            entity.Property(e => e.CompleteQty)
                .HasPrecision(18, 2)
                .HasComment("完成数量")
                .HasColumnName("COMPLETE_QTY");
            entity.Property(e => e.Config)
                .HasMaxLength(255)
                .HasComment("配置")
                .HasColumnName("CONFIG");
            entity.Property(e => e.CostCenter)
                .HasMaxLength(255)
                .HasComment("成本中心")
                .HasColumnName("COST_CENTER");
            entity.Property(e => e.CreateDate)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Demandfrom)
                .HasMaxLength(255)
                .HasComment("生产线")
                .HasColumnName("DEMANDFROM");
            entity.Property(e => e.Demandrule)
                .HasMaxLength(255)
                .HasComment("需求规则")
                .HasColumnName("DEMANDRULE");
            entity.Property(e => e.DispatchingAddress)
                .HasMaxLength(50)
                .HasComment("配送地址")
                .HasColumnName("DISPATCHING_ADDRESS");
            entity.Property(e => e.DispatchingNo)
                .HasMaxLength(255)
                .HasComment("配送单号")
                .HasColumnName("DISPATCHING_NO");
            entity.Property(e => e.DispatchingSection)
                .HasMaxLength(255)
                .HasComment("工段")
                .HasColumnName("DISPATCHING_SECTION");
            entity.Property(e => e.DispatchingType)
                .HasMaxLength(255)
                .HasComment("配送单类型")
                .HasColumnName("DISPATCHING_TYPE");
            entity.Property(e => e.EditDate)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("EDIT_DATE");
            entity.Property(e => e.FinshDate)
                .HasComment("完成时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("FINSH_DATE");
            entity.Property(e => e.HandoverDate)
                .HasComment("最晚交接时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("HANDOVER_DATE");
            entity.Property(e => e.HxFlag)
                .HasMaxLength(255)
                .HasComment("核销标识")
                .HasColumnName("HX_FLAG");
            entity.Property(e => e.IsComplete)
                .HasMaxLength(2)
                .HasDefaultValueSql("0")
                .HasComment("是否全部出库完成(默认值0，完成后改成1)");
            entity.Property(e => e.IsDeal).HasComment("导入数据是否已处理");
            entity.Property(e => e.IsPushResult)
                .HasMaxLength(2)
                .HasDefaultValueSql("0")
                .HasComment("是否推送出库完成结果(默认值0，完成后改成1)");
            entity.Property(e => e.ItemNo)
                .HasMaxLength(255)
                .HasComment("配送单行号")
                .HasColumnName("ITEM_NO");
            entity.Property(e => e.Lgort)
                .HasMaxLength(255)
                .HasComment("库位")
                .HasColumnName("LGORT");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(100)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.LineCategory)
                .HasMaxLength(20)
                .HasComment("线别标记产生需求的线别，便于需求的")
                .HasColumnName("LINE_CATEGORY");
            entity.Property(e => e.LineRequirementDate)
                .HasComment("线边需求时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("LINE_REQUIREMENT_DATE");
            entity.Property(e => e.Maktx)
                .HasMaxLength(100)
                .HasComment("物料描述")
                .HasColumnName("MAKTX");
            entity.Property(e => e.Matnr)
                .HasMaxLength(32)
                .HasComment("物料号")
                .HasColumnName("MATNR");
            entity.Property(e => e.OnlinePack)
                .HasMaxLength(50)
                .HasComment("上线包装器具")
                .HasColumnName("ONLINE_PACK");
            entity.Property(e => e.OnlineStanLoadQty)
                .HasPrecision(18, 2)
                .HasComment("上线装载量")
                .HasColumnName("ONLINE_STAN_LOAD_QTY");
            entity.Property(e => e.OrigReplenishmentQty)
                .HasMaxLength(32)
                .HasComment("原始补货数量")
                .HasColumnName("ORIG_REPLENISHMENT_QTY");
            entity.Property(e => e.OriginalQty)
                .HasPrecision(18, 2)
                .HasDefaultValue(0m)
                .HasComment("实际需求数量")
                .HasColumnName("ORIGINAL_QTY");
            entity.Property(e => e.OutStoreOrderId)
                .HasMaxLength(100)
                .HasComment("唯一标识")
                .HasColumnName("OutStoreOrderID");
            entity.Property(e => e.Partgroup)
                .HasMaxLength(60)
                .HasComment("物料类别")
                .HasColumnName("PARTGROUP");
            entity.Property(e => e.Priority)
                .HasMaxLength(50)
                .HasComment("优先级（类型A时必填 \n1紧急  0正常）")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 2)
                .HasComment("需求数量")
                .HasColumnName("QTY");
            entity.Property(e => e.QtyReal)
                .HasPrecision(18, 2)
                .HasComment("交接数量")
                .HasColumnName("QTY_REAL");
            entity.Property(e => e.QtyXj)
                .HasPrecision(18, 2)
                .HasComment("下架数量")
                .HasColumnName("QTY_XJ");
            entity.Property(e => e.Receivelgort)
                .HasMaxLength(20)
                .HasComment("接受库位")
                .HasColumnName("RECEIVELGORT");
            entity.Property(e => e.Receivetype)
                .HasMaxLength(20)
                .HasComment("接受类型")
                .HasColumnName("RECEIVETYPE");
            entity.Property(e => e.ReqItemStatus)
                .HasMaxLength(32)
                .HasComment("行项目状态")
                .HasColumnName("REQ_ITEM_STATUS");
            entity.Property(e => e.RequiredPackQty)
                .HasPrecision(18, 2)
                .HasComment("需求箱号数量")
                .HasColumnName("REQUIRED_PACK_QTY");
            entity.Property(e => e.RequiredQty)
                .HasPrecision(18, 2)
                .HasComment("需求数量")
                .HasColumnName("REQUIRED_QTY");
            entity.Property(e => e.RequirementItemNo)
                .HasMaxLength(255)
                .HasComment("出库需求行号")
                .HasColumnName("REQUIREMENT_ITEM_NO");
            entity.Property(e => e.RequirementNo)
                .HasMaxLength(255)
                .HasComment("出库需求号")
                .HasColumnName("REQUIREMENT_NO");
            entity.Property(e => e.Routestatusfrom)
                .HasMaxLength(255)
                .HasComment("发货地点")
                .HasColumnName("ROUTESTATUSFROM");
            entity.Property(e => e.SapMatdocItemNo)
                .HasMaxLength(255)
                .HasComment("SAP物料凭证行项目号")
                .HasColumnName("SAP_MATDOC_ITEM_NO");
            entity.Property(e => e.SapMatdocNo)
                .HasMaxLength(255)
                .HasComment("SAP物料凭证号")
                .HasColumnName("SAP_MATDOC_NO");
            entity.Property(e => e.Seq)
                .HasMaxLength(30)
                .HasComment("JIS 单序号")
                .HasColumnName("SEQ");
            entity.Property(e => e.Sobkz)
                .HasMaxLength(255)
                .HasComment("特殊库存类型")
                .HasColumnName("SOBKZ");
            entity.Property(e => e.Spssort)
                .HasMaxLength(255)
                .HasComment("PBS 排序号")
                .HasColumnName("SPSSORT");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasComment("出库状态\n状态，01:待发布；\n02:发布；\n03:拣配中；\n04:已打印；\n05:已下架；\n06:配送中；\n07:关闭；\n08:已交接;\n09:配送完成")
                .HasColumnName("STATUS");
            entity.Property(e => e.StockRmk)
                .HasMaxLength(255)
                .HasComment("移储库存标识")
                .HasColumnName("STOCK_RMK");
            entity.Property(e => e.Sysnod)
                .HasMaxLength(16)
                .HasComment("立库标识")
                .HasColumnName("SYSNOD");
            entity.Property(e => e.TaskNum)
                .HasMaxLength(255)
                .HasComment("任务号")
                .HasColumnName("TASK_NUM");
            entity.Property(e => e.ToBinCode)
                .HasMaxLength(255)
                .HasComment("目标储位")
                .HasColumnName("TO_BIN_CODE");
            entity.Property(e => e.TrialFlag)
                .HasMaxLength(50)
                .HasComment("试装标识")
                .HasColumnName("TRIAL_FLAG");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasComment("需求类型")
                .HasColumnName("TYPE");
            entity.Property(e => e.Unit)
                .HasMaxLength(255)
                .HasComment("单位")
                .HasColumnName("UNIT");
            entity.Property(e => e.UrnPackStation)
                .HasMaxLength(50)
                .HasComment("装配工位")
                .HasColumnName("URN_PACK_STATION");
            entity.Property(e => e.Vin)
                .HasMaxLength(255)
                .HasComment("VIN码")
                .HasColumnName("VIN");
            entity.Property(e => e.Wbs)
                .HasMaxLength(255)
                .HasComment("WBS元素号")
                .HasColumnName("WBS");
            entity.Property(e => e.Werks)
                .HasMaxLength(8)
                .HasComment("工厂代码")
                .HasColumnName("WERKS");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("仓库号")
                .HasColumnName("WH_NUMBER");
            entity.Property(e => e.WorkingLogation)
                .HasMaxLength(255)
                .HasComment("工位")
                .HasColumnName("WORKING_LOGATION");
        });

        modelBuilder.Entity<OutStoreDetailAllocateHisInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OutStoreDetailAllocateHisInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AllocateType)
                .HasMaxLength(16)
                .HasComment("分配类别(总装出库/移储出库/普通出库/退库出库/小件翻包出库/盘点/抽检/拆箱)");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("区域编码");
            entity.Property(e => e.BarcodeNo)
                .HasMaxLength(160)
                .HasComment("条码编号");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(150)
                .HasComment("箱号/托盘号");
            entity.Property(e => e.ContainerId)
                .HasMaxLength(150)
                .HasComment("箱号ID/托盘号");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.EndEquipmentCode)
                .HasMaxLength(120)
                .HasComment("终点设备编号(拣配口)");
            entity.Property(e => e.EquipmentCode)
                .HasMaxLength(50)
                .HasComment("托盘库小件翻包工位设备编号");
            entity.Property(e => e.FactQuantity)
                .HasPrecision(18, 2)
                .HasComment("实际拣配数量");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .HasComment("工厂编码");
            entity.Property(e => e.FinishTime)
                .HasComment("完成时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Id)
                .HasMaxLength(120)
                .HasComment("唯一标识");
            entity.Property(e => e.IsPushResult)
                .HasMaxLength(2)
                .HasDefaultValueSql("0")
                .HasComment("是否推送出库完成结果(待推送0，1次推送后改成1，无需推送或推送完成2)");
            entity.Property(e => e.Lgort)
                .HasMaxLength(32)
                .HasColumnName("LGORT");
            entity.Property(e => e.LockQuantity)
                .HasPrecision(18, 2)
                .HasComment("预约锁定拣配数量");
            entity.Property(e => e.LotNo)
                .HasMaxLength(150)
                .HasComment("物料批次");
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(150)
                .HasComment("物料编码");
            entity.Property(e => e.MaterialId)
                .HasMaxLength(150)
                .HasComment("物料ID");
            entity.Property(e => e.OutBoundDetailInfoId)
                .HasMaxLength(160)
                .HasComment("出库需求明细表ID");
            entity.Property(e => e.PickBy)
                .HasMaxLength(120)
                .HasComment("分拣人");
            entity.Property(e => e.PickInTime)
                .HasComment("分拣时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.PostBackTime)
                .HasComment("上传时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Priority).HasComment("优先级");
            entity.Property(e => e.Remark)
                .HasMaxLength(120)
                .HasComment("备注");
            entity.Property(e => e.RequirementItemNo)
                .HasMaxLength(255)
                .HasComment("出库需求行号")
                .HasColumnName("REQUIREMENT_ITEM_NO");
            entity.Property(e => e.RequirementNo)
                .HasMaxLength(255)
                .HasComment("出库需求号")
                .HasColumnName("REQUIREMENT_NO");
            entity.Property(e => e.SplitBarcodeNo)
                .HasMaxLength(150)
                .HasComment("拆分条码");
            entity.Property(e => e.StationCode)
                .HasMaxLength(100)
                .HasComment("拣配口编号");
            entity.Property(e => e.StationId)
                .HasMaxLength(120)
                .HasComment("出库工位ID");
            entity.Property(e => e.Status)
                .HasMaxLength(120)
                .HasComment("状态（创建、已完成、部分完成）");
            entity.Property(e => e.StockType).HasMaxLength(32);
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(150)
                .HasComment("供应商代码");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(120)
                .HasComment("仓库编号");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(32)
                .HasComment("BYD仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<OutStoreDetailAllocateInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OutStoreDetailAllocateInfo_pkey");

            entity
                .ToTable("OutStoreDetailAllocateInfo", tb => tb.HasComment("出库分拣分配表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.Id)
                .HasMaxLength(120)
                .HasComment("唯一标识");
            entity.Property(e => e.AllocateType)
                .HasMaxLength(16)
                .HasComment("分配类别(总装出库/移储出库/普通出库/退库出库/小件翻包出库/盘点/抽检/拆箱)");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("区域编码");
            entity.Property(e => e.BarcodeNo)
                .HasMaxLength(1024)
                .HasComment("条码编号");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(150)
                .HasComment("箱号/托盘号");
            entity.Property(e => e.ContainerId)
                .HasMaxLength(150)
                .HasComment("箱号ID/托盘号");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.EndEquipmentCode)
                .HasMaxLength(120)
                .HasComment("终点设备编号(拣配口)");
            entity.Property(e => e.EquipmentCode)
                .HasMaxLength(50)
                .HasComment("托盘库小件翻包工位设备编号");
            entity.Property(e => e.FactQuantity)
                .HasPrecision(18, 2)
                .HasComment("实际拣配数量");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .HasComment("工厂编码");
            entity.Property(e => e.FinishTime)
                .HasComment("完成时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.IsPushResult)
                .HasMaxLength(2)
                .HasDefaultValueSql("0")
                .HasComment("是否推送出库完成结果(待推送0，1次推送后改成1，无需推送或推送完成2)");
            entity.Property(e => e.KeyId).HasMaxLength(50);
            entity.Property(e => e.Lgort)
                .HasMaxLength(32)
                .HasColumnName("LGORT");
            entity.Property(e => e.LockQuantity)
                .HasPrecision(18, 2)
                .HasComment("预约锁定拣配数量");
            entity.Property(e => e.LotNo)
                .HasMaxLength(150)
                .HasComment("物料批次");
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(150)
                .HasComment("物料编码");
            entity.Property(e => e.MaterialId)
                .HasMaxLength(150)
                .HasComment("物料ID");
            entity.Property(e => e.OutBoundDetailInfoId)
                .HasMaxLength(160)
                .HasComment("出库需求明细表ID");
            entity.Property(e => e.PickBy)
                .HasMaxLength(120)
                .HasComment("分拣人");
            entity.Property(e => e.PickInTime)
                .HasComment("分拣时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.PostBackTime)
                .HasComment("上传时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Priority).HasComment("优先级");
            entity.Property(e => e.Remark)
                .HasMaxLength(120)
                .HasComment("备注");
            entity.Property(e => e.RequirementItemNo)
                .HasMaxLength(255)
                .HasComment("出库需求行号")
                .HasColumnName("REQUIREMENT_ITEM_NO");
            entity.Property(e => e.RequirementNo)
                .HasMaxLength(255)
                .HasComment("出库需求号")
                .HasColumnName("REQUIREMENT_NO");
            entity.Property(e => e.SplitBarcodeNo)
                .HasMaxLength(150)
                .HasComment("拆分条码");
            entity.Property(e => e.StationCode)
                .HasMaxLength(100)
                .HasComment("拣配口编号");
            entity.Property(e => e.StationId)
                .HasMaxLength(120)
                .HasComment("出库工位ID");
            entity.Property(e => e.Status)
                .HasMaxLength(120)
                .HasComment("状态（创建、已完成、部分完成）");
            entity.Property(e => e.StockType).HasMaxLength(32);
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(150)
                .HasComment("供应商代码");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(120)
                .HasComment("仓库编号");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(32)
                .HasComment("BYD仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<OutStoreOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OutStoreOrder", tb => tb.HasComment("出库需求单"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.Abbr)
                .HasMaxLength(255)
                .HasComment("SPS拣配储位")
                .HasColumnName("ABBR");
            entity.Property(e => e.AgvOnlineStrategy)
                .HasComment("AGV 上线策略")
                .HasColumnName("AGV_ONLINE_STRATEGY");
            entity.Property(e => e.Agvroute)
                .HasMaxLength(50)
                .HasComment("AGV路线")
                .HasColumnName("AGVROUTE");
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .HasComment("包装条码")
                .HasColumnName("BARCODE");
            entity.Property(e => e.Batch)
                .HasMaxLength(255)
                .HasComment("批次")
                .HasColumnName("BATCH");
            entity.Property(e => e.Bin)
                .HasMaxLength(255)
                .HasComment("线边储位")
                .HasColumnName("BIN");
            entity.Property(e => e.Bodyno)
                .HasMaxLength(255)
                .HasComment("车身号")
                .HasColumnName("BODYNO");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(255)
                .HasComment("业务类型名称")
                .HasColumnName("BUSINESS_NAME");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(255)
                .HasComment("业务类型")
                .HasColumnName("BUSINESS_TYPE");
            entity.Property(e => e.CarColor)
                .HasMaxLength(255)
                .HasComment("颜色")
                .HasColumnName("CAR_COLOR");
            entity.Property(e => e.CarType)
                .HasMaxLength(255)
                .HasComment("车型")
                .HasColumnName("CAR_TYPE");
            entity.Property(e => e.CompletePackQty)
                .HasPrecision(18, 2)
                .HasComment("完成箱数")
                .HasColumnName("COMPLETE_PACK_QTY");
            entity.Property(e => e.CompleteQty)
                .HasPrecision(18, 2)
                .HasComment("完成数量")
                .HasColumnName("COMPLETE_QTY");
            entity.Property(e => e.Config)
                .HasMaxLength(255)
                .HasComment("配置")
                .HasColumnName("CONFIG");
            entity.Property(e => e.CostCenter)
                .HasMaxLength(255)
                .HasComment("成本中心")
                .HasColumnName("COST_CENTER");
            entity.Property(e => e.CreateDate)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Demandfrom)
                .HasMaxLength(255)
                .HasComment("生产线")
                .HasColumnName("DEMANDFROM");
            entity.Property(e => e.Demandrule)
                .HasMaxLength(255)
                .HasComment("需求规则")
                .HasColumnName("DEMANDRULE");
            entity.Property(e => e.DispatchingAddress)
                .HasMaxLength(50)
                .HasComment("配送地址")
                .HasColumnName("DISPATCHING_ADDRESS");
            entity.Property(e => e.DispatchingNo)
                .HasMaxLength(255)
                .HasComment("配送单号")
                .HasColumnName("DISPATCHING_NO");
            entity.Property(e => e.DispatchingSection)
                .HasMaxLength(255)
                .HasComment("工段")
                .HasColumnName("DISPATCHING_SECTION");
            entity.Property(e => e.DispatchingType)
                .HasMaxLength(255)
                .HasComment("配送单类型")
                .HasColumnName("DISPATCHING_TYPE");
            entity.Property(e => e.EditDate)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("EDIT_DATE");
            entity.Property(e => e.FinshDate)
                .HasComment("完成时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("FINSH_DATE");
            entity.Property(e => e.HandoverDate)
                .HasComment("最晚交接时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("HANDOVER_DATE");
            entity.Property(e => e.HxFlag)
                .HasMaxLength(255)
                .HasComment("核销标识")
                .HasColumnName("HX_FLAG");
            entity.Property(e => e.IsComplete)
                .HasMaxLength(2)
                .HasDefaultValueSql("0")
                .HasComment("是否全部出库完成(默认值0，完成后改成1)");
            entity.Property(e => e.IsDeal).HasComment("导入数据是否已处理");
            entity.Property(e => e.IsPushResult)
                .HasMaxLength(2)
                .HasDefaultValueSql("0")
                .HasComment("是否推送出库完成结果(默认值0，完成后改成1)");
            entity.Property(e => e.ItemNo)
                .HasMaxLength(255)
                .HasComment("配送单行号")
                .HasColumnName("ITEM_NO");
            entity.Property(e => e.Lgort)
                .HasMaxLength(255)
                .HasComment("库位")
                .HasColumnName("LGORT");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(100)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.LineCategory)
                .HasMaxLength(20)
                .HasComment("线别标记产生需求的线别，便于需求的")
                .HasColumnName("LINE_CATEGORY");
            entity.Property(e => e.LineRequirementDate)
                .HasComment("线边需求时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("LINE_REQUIREMENT_DATE");
            entity.Property(e => e.Maktx)
                .HasMaxLength(100)
                .HasComment("物料描述")
                .HasColumnName("MAKTX");
            entity.Property(e => e.Matnr)
                .HasMaxLength(32)
                .HasComment("物料号")
                .HasColumnName("MATNR");
            entity.Property(e => e.OnlinePack)
                .HasMaxLength(50)
                .HasComment("上线包装器具")
                .HasColumnName("ONLINE_PACK");
            entity.Property(e => e.OnlineStanLoadQty)
                .HasPrecision(18, 2)
                .HasComment("上线装载量")
                .HasColumnName("ONLINE_STAN_LOAD_QTY");
            entity.Property(e => e.OrigReplenishmentQty)
                .HasMaxLength(32)
                .HasComment("原始补货数量")
                .HasColumnName("ORIG_REPLENISHMENT_QTY");
            entity.Property(e => e.OriginalQty)
                .HasPrecision(18, 2)
                .HasDefaultValue(0m)
                .HasComment("实际需求数量")
                .HasColumnName("ORIGINAL_QTY");
            entity.Property(e => e.OutStoreOrderId)
                .HasMaxLength(100)
                .HasComment("唯一标识")
                .HasColumnName("OutStoreOrderID");
            entity.Property(e => e.Partgroup)
                .HasMaxLength(60)
                .HasComment("物料类别")
                .HasColumnName("PARTGROUP");
            entity.Property(e => e.Priority)
                .HasMaxLength(50)
                .HasComment("优先级（类型A时必填 \n1紧急  0正常）")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 2)
                .HasComment("需求数量")
                .HasColumnName("QTY");
            entity.Property(e => e.QtyReal)
                .HasPrecision(18, 2)
                .HasComment("交接数量")
                .HasColumnName("QTY_REAL");
            entity.Property(e => e.QtyXj)
                .HasPrecision(18, 2)
                .HasComment("下架数量")
                .HasColumnName("QTY_XJ");
            entity.Property(e => e.Receivelgort)
                .HasMaxLength(20)
                .HasComment("接受库位")
                .HasColumnName("RECEIVELGORT");
            entity.Property(e => e.Receivetype)
                .HasMaxLength(20)
                .HasComment("接受类型")
                .HasColumnName("RECEIVETYPE");
            entity.Property(e => e.ReqItemStatus)
                .HasMaxLength(32)
                .HasComment("行项目状态")
                .HasColumnName("REQ_ITEM_STATUS");
            entity.Property(e => e.RequiredPackQty)
                .HasPrecision(18, 2)
                .HasComment("需求箱号数量")
                .HasColumnName("REQUIRED_PACK_QTY");
            entity.Property(e => e.RequiredQty)
                .HasPrecision(18, 2)
                .HasComment("需求数量")
                .HasColumnName("REQUIRED_QTY");
            entity.Property(e => e.RequirementItemNo)
                .HasMaxLength(255)
                .HasComment("出库需求行号")
                .HasColumnName("REQUIREMENT_ITEM_NO");
            entity.Property(e => e.RequirementNo)
                .HasMaxLength(255)
                .HasComment("出库需求号")
                .HasColumnName("REQUIREMENT_NO");
            entity.Property(e => e.Routestatusfrom)
                .HasMaxLength(255)
                .HasComment("发货地点")
                .HasColumnName("ROUTESTATUSFROM");
            entity.Property(e => e.SapMatdocItemNo)
                .HasMaxLength(255)
                .HasComment("SAP物料凭证行项目号")
                .HasColumnName("SAP_MATDOC_ITEM_NO");
            entity.Property(e => e.SapMatdocNo)
                .HasMaxLength(255)
                .HasComment("SAP物料凭证号")
                .HasColumnName("SAP_MATDOC_NO");
            entity.Property(e => e.Seq)
                .HasMaxLength(30)
                .HasComment("JIS 单序号")
                .HasColumnName("SEQ");
            entity.Property(e => e.Sobkz)
                .HasMaxLength(255)
                .HasComment("特殊库存类型")
                .HasColumnName("SOBKZ");
            entity.Property(e => e.Spssort)
                .HasMaxLength(255)
                .HasComment("PBS 排序号")
                .HasColumnName("SPSSORT");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasComment("出库状态\n状态，01:待发布；\n02:发布；\n03:拣配中；\n04:已打印；\n05:已下架；\n06:配送中；\n07:关闭；\n08:已交接;\n09:配送完成")
                .HasColumnName("STATUS");
            entity.Property(e => e.StockRmk)
                .HasMaxLength(255)
                .HasComment("移储库存标识")
                .HasColumnName("STOCK_RMK");
            entity.Property(e => e.Sysnod)
                .HasMaxLength(16)
                .HasComment("立库标识")
                .HasColumnName("SYSNOD");
            entity.Property(e => e.TaskNum)
                .HasMaxLength(255)
                .HasComment("任务号")
                .HasColumnName("TASK_NUM");
            entity.Property(e => e.ToBinCode)
                .HasMaxLength(255)
                .HasComment("目标储位")
                .HasColumnName("TO_BIN_CODE");
            entity.Property(e => e.TrialFlag)
                .HasMaxLength(50)
                .HasComment("试装标识")
                .HasColumnName("TRIAL_FLAG");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasComment("需求类型")
                .HasColumnName("TYPE");
            entity.Property(e => e.Unit)
                .HasMaxLength(255)
                .HasComment("单位")
                .HasColumnName("UNIT");
            entity.Property(e => e.UrnPackStation)
                .HasMaxLength(50)
                .HasComment("装配工位")
                .HasColumnName("URN_PACK_STATION");
            entity.Property(e => e.Vin)
                .HasMaxLength(255)
                .HasComment("VIN码")
                .HasColumnName("VIN");
            entity.Property(e => e.Wbs)
                .HasMaxLength(255)
                .HasComment("WBS元素号")
                .HasColumnName("WBS");
            entity.Property(e => e.Werks)
                .HasMaxLength(8)
                .HasComment("工厂代码")
                .HasColumnName("WERKS");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("仓库号")
                .HasColumnName("WH_NUMBER");
            entity.Property(e => e.WorkingLogation)
                .HasMaxLength(255)
                .HasComment("工位")
                .HasColumnName("WORKING_LOGATION");
        });

        modelBuilder.Entity<Pack>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pack", tb => tb.HasComment("包装代码主数据表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateDate)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(100)
                .HasComment("创建人")
                .HasColumnName("CREATE_USER");
            entity.Property(e => e.Editor)
                .HasMaxLength(100)
                .HasComment("编辑人")
                .HasColumnName("EDITOR");
            entity.Property(e => e.Height)
                .HasPrecision(18, 2)
                .HasComment("高度")
                .HasColumnName("HEIGHT");
            entity.Property(e => e.Length)
                .HasPrecision(18, 2)
                .HasComment("长度")
                .HasColumnName("LENGTH");
            entity.Property(e => e.MaterialQuality)
                .HasMaxLength(100)
                .HasComment("材质")
                .HasColumnName("MATERIAL_QUALITY");
            entity.Property(e => e.PackCode)
                .HasMaxLength(100)
                .HasComment("包装代码")
                .HasColumnName("PACK_CODE");
            entity.Property(e => e.PackDescribe)
                .HasMaxLength(100)
                .HasComment("描述")
                .HasColumnName("PACK_DESCRIBE");
            entity.Property(e => e.PackType)
                .HasMaxLength(100)
                .HasComment("包装类型")
                .HasColumnName("PACK_TYPE");
            entity.Property(e => e.Packid)
                .HasMaxLength(100)
                .HasComment("唯一标识")
                .HasColumnName("PACKID");
            entity.Property(e => e.Slot)
                .HasMaxLength(100)
                .HasComment("格口(无细分时默认是1)")
                .HasColumnName("SLOT");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasComment("状态")
                .HasColumnName("STATE");
            entity.Property(e => e.Sysnod)
                .HasMaxLength(16)
                .HasComment("立库标识")
                .HasColumnName("SYSNOD");
            entity.Property(e => e.UpdateDate)
                .HasComment("编辑时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Weight)
                .HasPrecision(18, 2)
                .HasComment("重量")
                .HasColumnName("WEIGHT");
            entity.Property(e => e.Werks)
                .HasMaxLength(8)
                .HasComment("工厂代码")
                .HasColumnName("WERKS");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("仓库号")
                .HasColumnName("WH_NUMBER");
            entity.Property(e => e.Width)
                .HasPrecision(18, 2)
                .HasComment("宽度")
                .HasColumnName("WIDTH");
        });

        modelBuilder.Entity<PgStatStatement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("pg_stat_statements");

            entity.Property(e => e.BlkReadTime).HasColumnName("blk_read_time");
            entity.Property(e => e.BlkWriteTime).HasColumnName("blk_write_time");
            entity.Property(e => e.Calls).HasColumnName("calls");
            entity.Property(e => e.Dbid)
                .HasColumnType("oid")
                .HasColumnName("dbid");
            entity.Property(e => e.LocalBlksDirtied).HasColumnName("local_blks_dirtied");
            entity.Property(e => e.LocalBlksHit).HasColumnName("local_blks_hit");
            entity.Property(e => e.LocalBlksRead).HasColumnName("local_blks_read");
            entity.Property(e => e.LocalBlksWritten).HasColumnName("local_blks_written");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.Rows).HasColumnName("rows");
            entity.Property(e => e.SharedBlksDirtied).HasColumnName("shared_blks_dirtied");
            entity.Property(e => e.SharedBlksHit).HasColumnName("shared_blks_hit");
            entity.Property(e => e.SharedBlksRead).HasColumnName("shared_blks_read");
            entity.Property(e => e.SharedBlksWritten).HasColumnName("shared_blks_written");
            entity.Property(e => e.TempBlksRead).HasColumnName("temp_blks_read");
            entity.Property(e => e.TempBlksWritten).HasColumnName("temp_blks_written");
            entity.Property(e => e.TotalTime).HasColumnName("total_time");
            entity.Property(e => e.Userid)
                .HasColumnType("oid")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<PickingStation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PickingStation")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AgvRoute)
                .HasMaxLength(100)
                .HasComment("Agv路线");
            entity.Property(e => e.Bin)
                .HasMaxLength(255)
                .HasComment("线边储位")
                .HasColumnName("BIN");
            entity.Property(e => e.Demandfrom)
                .HasMaxLength(255)
                .HasComment("生产线")
                .HasColumnName("DEMANDFROM");
            entity.Property(e => e.DispatchingSection)
                .HasMaxLength(255)
                .HasComment("工段")
                .HasColumnName("DISPATCHING_SECTION");
            entity.Property(e => e.PickingStationD)
                .HasMaxLength(100)
                .HasComment("唯一码");
            entity.Property(e => e.StationCode)
                .HasMaxLength(100)
                .HasComment("站点编号");
        });

        modelBuilder.Entity<PlcConnInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PlcConnInfo", tb => tb.HasComment("PLC连接信息表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasComment("描述");
            entity.Property(e => e.HeartLength).HasComment("心跳长度");
            entity.Property(e => e.HeartStart).HasComment("心跳开始");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .HasComment("IP地址");
            entity.Property(e => e.PlcConnCode)
                .HasMaxLength(50)
                .HasComment("PLC连接编码");
            entity.Property(e => e.PlcConnId)
                .HasMaxLength(36)
                .HasComment("PLC连接字符串ID");
            entity.Property(e => e.PlcConnName)
                .HasMaxLength(50)
                .HasComment("PLC连接命名");
            entity.Property(e => e.PlcCpuType).HasComment("CPU类型(1=S1200,2=S300,3=S400,4=S1500,5=S200smart,6=S200)");
            entity.Property(e => e.PlcDb)
                .HasComment("PLC-DB块")
                .HasColumnName("PlcDB");
            entity.Property(e => e.PlcType)
                .HasMaxLength(50)
                .HasComment("PLC类型(Siemens、Omron、Modbus)");
            entity.Property(e => e.Port).HasComment("端口号");
            entity.Property(e => e.Rack).HasComment("机架号");
            entity.Property(e => e.Slot).HasComment("插槽号");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
            entity.Property(e => e.WcsDb)
                .HasComment("WCS-DB块")
                .HasColumnName("WcsDB");
        });

        modelBuilder.Entity<ProgramEquipmentInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProgramEquipmentInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasComment("描述");
            entity.Property(e => e.EquipmentCode)
                .HasMaxLength(50)
                .HasComment("设备编码");
            entity.Property(e => e.EquipmentType)
                .HasMaxLength(50)
                .HasComment("设备类型");
            entity.Property(e => e.PlcConnId)
                .HasMaxLength(36)
                .HasComment("Plc连接ID");
            entity.Property(e => e.PlcLength).HasComment("Plc长度");
            entity.Property(e => e.PlcModel)
                .HasMaxLength(50)
                .HasComment("Plc模式");
            entity.Property(e => e.PlcStart).HasComment("Plc偏移量开始位置");
            entity.Property(e => e.ProgramEquipmentId)
                .HasMaxLength(36)
                .HasComment("PLC设备ID");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(36)
                .HasComment("Wcs程序ID");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
            entity.Property(e => e.WcsLength).HasComment("Wcs偏移量长度");
            entity.Property(e => e.WcsModel)
                .HasMaxLength(50)
                .HasComment("Wcs模式");
            entity.Property(e => e.WcsStart).HasComment("Wcs偏移量开始位置");
        });

        modelBuilder.Entity<ProgramInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProgramInfo", tb => tb.HasComment("WCS程序表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasDefaultValueSql("NULL::character varying")
                .HasComment("描述");
            entity.Property(e => e.ProgramCode)
                .HasMaxLength(50)
                .HasComment("程序代码");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(36)
                .HasComment("WCS程序表ID");
            entity.Property(e => e.ProgramName)
                .HasMaxLength(50)
                .HasComment("程序名称");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<ProgramJobInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProgramJobInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.CronExp).HasMaxLength(50);
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasComment("描述");
            entity.Property(e => e.IsEnable).HasComment("是否启用");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(36)
                .HasComment("WCS程序ID");
            entity.Property(e => e.ProgramJobId)
                .HasMaxLength(36)
                .HasComment("WCS程序JopID");
            entity.Property(e => e.ProgramJobName)
                .HasMaxLength(50)
                .HasComment("WCS程序Jop名称");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<PushReturnMaterial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PushReturnMaterial", tb => tb.HasComment("退料入库推送单"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ApprovalComments)
                .HasMaxLength(255)
                .HasComment("审批意见")
                .HasColumnName("APPROVAL_COMMENTS");
            entity.Property(e => e.Batch)
                .HasMaxLength(255)
                .HasComment("批次")
                .HasColumnName("BATCH");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(255)
                .HasComment("业务名称")
                .HasColumnName("BUSINESS_NAME");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(255)
                .HasComment("业务类型")
                .HasColumnName("BUSINESS_TYPE");
            entity.Property(e => e.CompleteNumber)
                .HasPrecision(18, 2)
                .HasComment("完成退货入库数量");
            entity.Property(e => e.CreateDate)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.EditDate)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("EDIT_DATE");
            entity.Property(e => e.IsComplete)
                .HasMaxLength(2)
                .HasComment("退货入库是否完成");
            entity.Property(e => e.IsDeal).HasComment("导入数据是否已处理");
            entity.Property(e => e.IsPushResult)
                .HasMaxLength(2)
                .HasComment("是否推送退料入库结果");
            entity.Property(e => e.Lgort)
                .HasMaxLength(255)
                .HasComment("库存地点")
                .HasColumnName("LGORT");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(255)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.Maktx)
                .HasMaxLength(255)
                .HasComment("物料描述")
                .HasColumnName("MAKTX");
            entity.Property(e => e.Matnr)
                .HasMaxLength(255)
                .HasComment("物料编码")
                .HasColumnName("MATNR");
            entity.Property(e => e.PostCount)
                .HasPrecision(18, 2)
                .HasComment("已推送给WMS数量");
            entity.Property(e => e.PushReturnMaterialId)
                .HasMaxLength(100)
                .HasComment("唯一码")
                .HasColumnName("PushReturnMaterialID");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 2)
                .HasComment("数量")
                .HasColumnName("QTY");
            entity.Property(e => e.ReceiptItemNo)
                .HasMaxLength(255)
                .HasComment("收货行号")
                .HasColumnName("RECEIPT_ITEM_NO");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(255)
                .HasComment("收货号")
                .HasColumnName("RECEIPT_NO");
            entity.Property(e => e.RequriementItemNo)
                .HasMaxLength(255)
                .HasComment("需求行号")
                .HasColumnName("REQURIEMENT_ITEM_NO");
            entity.Property(e => e.RequriementNo)
                .HasMaxLength(255)
                .HasComment("需求号")
                .HasColumnName("REQURIEMENT_NO");
            entity.Property(e => e.ResponsibleParty)
                .HasMaxLength(255)
                .HasComment("责任方")
                .HasColumnName("RESPONSIBLE_PARTY");
            entity.Property(e => e.ReturnItemNo)
                .HasMaxLength(255)
                .HasComment("退料行编号")
                .HasColumnName("RETURN_ITEM_NO");
            entity.Property(e => e.ReturnNo)
                .HasMaxLength(255)
                .HasComment("退料编号")
                .HasColumnName("RETURN_NO");
            entity.Property(e => e.ReturnPeople)
                .HasMaxLength(255)
                .HasComment("退货人")
                .HasColumnName("RETURN_PEOPLE");
            entity.Property(e => e.ReturnReasonDesc)
                .HasMaxLength(255)
                .HasComment("退货原因")
                .HasColumnName("RETURN_REASON_DESC");
            entity.Property(e => e.SapOutItemNo)
                .HasMaxLength(255)
                .HasComment("STO退货单行号")
                .HasColumnName("SAP_OUT_ITEM_NO");
            entity.Property(e => e.SapOutNo)
                .HasMaxLength(255)
                .HasComment("STO退货单号")
                .HasColumnName("SAP_OUT_NO");
            entity.Property(e => e.Sobkz)
                .HasMaxLength(255)
                .HasComment("库存类型")
                .HasColumnName("SOBKZ");
            entity.Property(e => e.Sysnod)
                .HasMaxLength(32)
                .HasComment("立库标识")
                .HasColumnName("SYSNOD");
            entity.Property(e => e.Unit)
                .HasMaxLength(255)
                .HasComment("单位")
                .HasColumnName("UNIT");
            entity.Property(e => e.Werks)
                .HasMaxLength(8)
                .HasComment("工厂代码")
                .HasColumnName("WERKS");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<RcvinfoCreateReq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RCVInfoCreateReq", tb => tb.HasComment("接收移储单信息"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.Batch)
                .HasMaxLength(255)
                .HasComment("批次")
                .HasColumnName("BATCH");
            entity.Property(e => e.BinCode)
                .HasMaxLength(255)
                .HasComment("源储位")
                .HasColumnName("BIN_CODE");
            entity.Property(e => e.BoxQty)
                .HasPrecision(18, 2)
                .HasDefaultValue(0m)
                .HasComment("满箱数量(若未传值，默认与“数量”相等)")
                .HasColumnName("BOX_QTY");
            entity.Property(e => e.CompleteNumber)
                .HasPrecision(18, 2)
                .HasComment("完成移储入库数量");
            entity.Property(e => e.IsComplete)
                .HasMaxLength(2)
                .HasComment("移储入库是否完成");
            entity.Property(e => e.KeyId)
                .HasMaxLength(255)
                .HasComment("全局ID(IWMS系统号+流水号)")
                .HasColumnName("KEY_ID");
            entity.Property(e => e.Lgort)
                .HasMaxLength(255)
                .HasComment("库位")
                .HasColumnName("LGORT");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(100)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.Matnr)
                .HasMaxLength(32)
                .HasComment("物料号")
                .HasColumnName("MATNR");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 2)
                .HasComment("数量")
                .HasColumnName("QTY");
            entity.Property(e => e.RcvinfoCreateReqCode)
                .HasMaxLength(100)
                .HasComment("移储单号")
                .HasColumnName("RCVInfoCreateReqCode");
            entity.Property(e => e.RcvinfoCreateReqId)
                .HasMaxLength(100)
                .HasComment("唯一码")
                .HasColumnName("RCVInfoCreateReqID");
            entity.Property(e => e.ReceivingBinCode)
                .HasMaxLength(255)
                .HasComment("接收储位")
                .HasColumnName("RECEIVING_BIN_CODE");
            entity.Property(e => e.Sysnod)
                .HasMaxLength(16)
                .HasComment("立库标识")
                .HasColumnName("SYSNOD");
            entity.Property(e => e.Werks)
                .HasMaxLength(8)
                .HasComment("工厂代码")
                .HasColumnName("WERKS");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<Receipt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Receipt", tb => tb.HasComment("收货单表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.Afnam)
                .HasMaxLength(32)
                .HasComment("申请人")
                .HasColumnName("AFNAM");
            entity.Property(e => e.Asnitm)
                .HasMaxLength(32)
                .HasComment("SCM 送货单行项目号")
                .HasColumnName("ASNITM");
            entity.Property(e => e.Asnno)
                .HasMaxLength(255)
                .HasComment("SCM/云平台送货单号")
                .HasColumnName("ASNNO");
            entity.Property(e => e.Batch)
                .HasMaxLength(32)
                .HasComment("WMS 批次")
                .HasColumnName("BATCH");
            entity.Property(e => e.Bednr)
                .HasMaxLength(32)
                .HasComment("需求跟踪号")
                .HasColumnName("BEDNR");
            entity.Property(e => e.BoxCount)
                .HasPrecision(18)
                .HasComment("箱数")
                .HasColumnName("BOX_COUNT");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(32)
                .HasComment("业务类型")
                .HasColumnName("BUSINESS_NAME");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(32)
                .HasComment("wms 业务类型")
                .HasColumnName("BUSINESS_TYPE");
            entity.Property(e => e.CheckedQty)
                .HasPrecision(18, 2)
                .HasComment("抽检数量")
                .HasColumnName("CHECKED_QTY");
            entity.Property(e => e.Creator)
                .HasMaxLength(32)
                .HasComment("记录创建人")
                .HasColumnName("CREATOR");
            entity.Property(e => e.Del)
                .HasMaxLength(32)
                .HasComment("删除标识")
                .HasColumnName("DEL");
            entity.Property(e => e.FBatch)
                .HasMaxLength(32)
                .HasComment("发货批次")
                .HasColumnName("F_BATCH");
            entity.Property(e => e.FLgort)
                .HasMaxLength(32)
                .HasComment("发货库位")
                .HasColumnName("F_LGORT");
            entity.Property(e => e.FWerks)
                .HasMaxLength(32)
                .HasComment("发货工厂代码")
                .HasColumnName("F_WERKS");
            entity.Property(e => e.FWhNumber)
                .HasMaxLength(32)
                .HasComment("发货仓库号")
                .HasColumnName("F_WH_NUMBER");
            entity.Property(e => e.FullBoxQty)
                .HasPrecision(18)
                .HasComment("满箱数量")
                .HasColumnName("FULL_BOX_QTY");
            entity.Property(e => e.GrArea)
                .HasMaxLength(32)
                .HasComment("收料房存放区")
                .HasColumnName("GR_AREA");
            entity.Property(e => e.InQty)
                .HasPrecision(18, 2)
                .HasComment("进仓数量")
                .HasColumnName("IN_QTY");
            entity.Property(e => e.InableQty)
                .HasPrecision(18, 2)
                .HasComment("可进仓数量（质检判断结果为可进仓）")
                .HasColumnName("INABLE_QTY");
            entity.Property(e => e.InbounStatus)
                .HasMaxLength(2)
                .HasComment("状态")
                .HasColumnName("INBOUN_STATUS");
            entity.Property(e => e.InboundItemNo)
                .HasMaxLength(32)
                .HasComment("进仓单行号")
                .HasColumnName("INBOUND_ITEM_NO");
            entity.Property(e => e.InboundNo)
                .HasMaxLength(32)
                .HasComment("进仓单号")
                .HasColumnName("INBOUND_NO");
            entity.Property(e => e.IsComplete).HasComment("是否全部完成");
            entity.Property(e => e.IsDeal).HasComment("导入数据是否已处理");
            entity.Property(e => e.IsValid)
                .HasMaxLength(2)
                .HasComment("是否有效");
            entity.Property(e => e.Lgort)
                .HasMaxLength(32)
                .HasComment("收货库位")
                .HasColumnName("LGORT");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(100)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.Liktx)
                .HasMaxLength(100)
                .HasComment("供应商描述")
                .HasColumnName("LIKTX");
            entity.Property(e => e.Maktx)
                .HasMaxLength(100)
                .HasComment("物料描述")
                .HasColumnName("MAKTX");
            entity.Property(e => e.Matnr)
                .HasMaxLength(32)
                .HasComment("物料号")
                .HasColumnName("MATNR");
            entity.Property(e => e.PartNo)
                .HasMaxLength(50)
                .HasComment("零件编号")
                .HasColumnName("PART_NO");
            entity.Property(e => e.PoItemNo)
                .HasMaxLength(255)
                .HasComment("采购订单行项目号")
                .HasColumnName("PO_ITEM_NO");
            entity.Property(e => e.PoNo)
                .HasMaxLength(255)
                .HasComment("采购订单号")
                .HasColumnName("PO_NO");
            entity.Property(e => e.ProjectOreder)
                .HasMaxLength(32)
                .HasComment("项目编号")
                .HasColumnName("PROJECT_OREDER");
            entity.Property(e => e.QcResultCode)
                .HasMaxLength(32)
                .HasComment("质检结果")
                .HasColumnName("QC_RESULT_CODE");
            entity.Property(e => e.ReceiptDate)
                .HasComment("收料日期")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("RECEIPT_DATE");
            entity.Property(e => e.ReceiptId)
                .HasMaxLength(100)
                .HasComment("唯一标识")
                .HasColumnName("ReceiptID");
            entity.Property(e => e.ReceiptItemNo)
                .HasMaxLength(32)
                .HasComment("收货单行号")
                .HasColumnName("RECEIPT_ITEM_NO");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(32)
                .HasComment("收货单号")
                .HasColumnName("RECEIPT_NO");
            entity.Property(e => e.ReceiptQty)
                .HasPrecision(18, 2)
                .HasComment("实收数量")
                .HasColumnName("RECEIPT_QTY");
            entity.Property(e => e.Receiver)
                .HasMaxLength(32)
                .HasComment("收料员")
                .HasColumnName("RECEIVER");
            entity.Property(e => e.ReturnQty)
                .HasPrecision(18, 2)
                .HasComment("收料房冲销/退货数理 104+124 数量")
                .HasColumnName("RETURN_QTY");
            entity.Property(e => e.SapMatdocItemNo)
                .HasMaxLength(32)
                .HasComment("SAP303 凭证行项目号")
                .HasColumnName("SAP_MATDOC_ITEM_NO");
            entity.Property(e => e.SapMatdocNo)
                .HasMaxLength(32)
                .HasComment("SAP303 凭证号")
                .HasColumnName("SAP_MATDOC_NO");
            entity.Property(e => e.SapNo)
                .HasMaxLength(32)
                .HasComment("SAP 凭证")
                .HasColumnName("SAP_NO");
            entity.Property(e => e.SapOutItemNo)
                .HasMaxLength(255)
                .HasComment("SAP 交货单行项目号")
                .HasColumnName("SAP_OUT_ITEM_NO");
            entity.Property(e => e.SapOutNo)
                .HasMaxLength(32)
                .HasComment("SAP 交货单号")
                .HasColumnName("SAP_OUT_NO");
            entity.Property(e => e.SapQty)
                .HasPrecision(18)
                .HasComment("SAP 交货数量")
                .HasColumnName("SAP_QTY");
            entity.Property(e => e.SapStatus)
                .HasMaxLength(32)
                .HasComment("是否 SAP 过\n账用于先\n实物")
                .HasColumnName("SAP_STATUS");
            entity.Property(e => e.Sobkz)
                .HasMaxLength(32)
                .HasComment("库存类型")
                .HasColumnName("SOBKZ");
            entity.Property(e => e.StoreBinCode)
                .HasMaxLength(100)
                .HasComment("收货储位")
                .HasColumnName("STORE_BIN_CODE");
            entity.Property(e => e.Sysnod)
                .HasMaxLength(32)
                .HasComment("立库标识")
                .HasColumnName("SYSNOD");
            entity.Property(e => e.TestFlag)
                .HasMaxLength(32)
                .HasComment("质检标识(00质检、01免检、02无需质检的收料房库存可进仓也可退货)")
                .HasColumnName("TEST_FLAG");
            entity.Property(e => e.Type)
                .HasMaxLength(8)
                .HasComment("请求类型")
                .HasColumnName("TYPE");
            entity.Property(e => e.Unit)
                .HasMaxLength(32)
                .HasComment("单位")
                .HasColumnName("UNIT");
            entity.Property(e => e.UpdateDate)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Wbs)
                .HasMaxLength(32)
                .HasComment("WBS 元素号")
                .HasColumnName("WBS");
            entity.Property(e => e.Werks)
                .HasMaxLength(8)
                .HasComment("工厂代码")
                .HasColumnName("WERKS");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(32)
                .HasComment("仓库号")
                .HasColumnName("WH_NUMBER");
            entity.Property(e => e.WmsNo)
                .HasMaxLength(32)
                .HasComment("WMS 凭证")
                .HasColumnName("WMS_NO");
        });

        modelBuilder.Entity<ReceiptHisInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReceiptHisInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.Afnam)
                .HasMaxLength(32)
                .HasComment("申请人")
                .HasColumnName("AFNAM");
            entity.Property(e => e.Asnitm)
                .HasMaxLength(32)
                .HasComment("SCM 送货单行项目号")
                .HasColumnName("ASNITM");
            entity.Property(e => e.Asnno)
                .HasMaxLength(255)
                .HasComment("SCM/云平台送货单号")
                .HasColumnName("ASNNO");
            entity.Property(e => e.Batch)
                .HasMaxLength(32)
                .HasComment("WMS 批次")
                .HasColumnName("BATCH");
            entity.Property(e => e.Bednr)
                .HasMaxLength(32)
                .HasComment("需求跟踪号")
                .HasColumnName("BEDNR");
            entity.Property(e => e.BoxCount)
                .HasPrecision(18)
                .HasComment("箱数")
                .HasColumnName("BOX_COUNT");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(32)
                .HasComment("业务类型")
                .HasColumnName("BUSINESS_NAME");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(32)
                .HasComment("wms 业务类型")
                .HasColumnName("BUSINESS_TYPE");
            entity.Property(e => e.CheckedQty)
                .HasPrecision(18, 2)
                .HasComment("抽检数量")
                .HasColumnName("CHECKED_QTY");
            entity.Property(e => e.Creator)
                .HasMaxLength(32)
                .HasComment("记录创建人")
                .HasColumnName("CREATOR");
            entity.Property(e => e.Del)
                .HasMaxLength(32)
                .HasComment("删除标识")
                .HasColumnName("DEL");
            entity.Property(e => e.FBatch)
                .HasMaxLength(32)
                .HasComment("发货批次")
                .HasColumnName("F_BATCH");
            entity.Property(e => e.FLgort)
                .HasMaxLength(32)
                .HasComment("发货库位")
                .HasColumnName("F_LGORT");
            entity.Property(e => e.FWerks)
                .HasMaxLength(32)
                .HasComment("发货工厂代码")
                .HasColumnName("F_WERKS");
            entity.Property(e => e.FWhNumber)
                .HasMaxLength(32)
                .HasComment("发货仓库号")
                .HasColumnName("F_WH_NUMBER");
            entity.Property(e => e.FullBoxQty)
                .HasPrecision(18)
                .HasComment("满箱数量")
                .HasColumnName("FULL_BOX_QTY");
            entity.Property(e => e.GrArea)
                .HasMaxLength(32)
                .HasComment("收料房存放区")
                .HasColumnName("GR_AREA");
            entity.Property(e => e.InQty)
                .HasPrecision(18, 2)
                .HasComment("进仓数量")
                .HasColumnName("IN_QTY");
            entity.Property(e => e.InableQty)
                .HasPrecision(18, 2)
                .HasComment("可进仓数量（质检判断结果为可进仓）")
                .HasColumnName("INABLE_QTY");
            entity.Property(e => e.InbounStatus)
                .HasMaxLength(2)
                .HasComment("状态")
                .HasColumnName("INBOUN_STATUS");
            entity.Property(e => e.InboundItemNo)
                .HasMaxLength(32)
                .HasComment("进仓单行号")
                .HasColumnName("INBOUND_ITEM_NO");
            entity.Property(e => e.InboundNo)
                .HasMaxLength(32)
                .HasComment("进仓单号")
                .HasColumnName("INBOUND_NO");
            entity.Property(e => e.IsComplete).HasComment("是否全部完成");
            entity.Property(e => e.IsDeal).HasComment("导入数据是否已处理");
            entity.Property(e => e.IsValid)
                .HasMaxLength(2)
                .HasComment("是否有效");
            entity.Property(e => e.Lgort)
                .HasMaxLength(32)
                .HasComment("收货库位")
                .HasColumnName("LGORT");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(100)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.Liktx)
                .HasMaxLength(100)
                .HasComment("供应商描述")
                .HasColumnName("LIKTX");
            entity.Property(e => e.Maktx)
                .HasMaxLength(100)
                .HasComment("物料描述")
                .HasColumnName("MAKTX");
            entity.Property(e => e.Matnr)
                .HasMaxLength(32)
                .HasComment("物料号")
                .HasColumnName("MATNR");
            entity.Property(e => e.PartNo)
                .HasMaxLength(50)
                .HasComment("零件编号")
                .HasColumnName("PART_NO");
            entity.Property(e => e.PoItemNo)
                .HasMaxLength(255)
                .HasComment("采购订单行项目号")
                .HasColumnName("PO_ITEM_NO");
            entity.Property(e => e.PoNo)
                .HasMaxLength(255)
                .HasComment("采购订单号")
                .HasColumnName("PO_NO");
            entity.Property(e => e.ProjectOreder)
                .HasMaxLength(32)
                .HasComment("项目编号")
                .HasColumnName("PROJECT_OREDER");
            entity.Property(e => e.QcResultCode)
                .HasMaxLength(32)
                .HasComment("质检结果")
                .HasColumnName("QC_RESULT_CODE");
            entity.Property(e => e.ReceiptDate)
                .HasComment("收料日期")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("RECEIPT_DATE");
            entity.Property(e => e.ReceiptId)
                .HasMaxLength(100)
                .HasComment("唯一标识")
                .HasColumnName("ReceiptID");
            entity.Property(e => e.ReceiptItemNo)
                .HasMaxLength(32)
                .HasComment("收货单行号")
                .HasColumnName("RECEIPT_ITEM_NO");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(32)
                .HasComment("收货单号")
                .HasColumnName("RECEIPT_NO");
            entity.Property(e => e.ReceiptQty)
                .HasPrecision(18, 2)
                .HasComment("实收数量")
                .HasColumnName("RECEIPT_QTY");
            entity.Property(e => e.Receiver)
                .HasMaxLength(32)
                .HasComment("收料员")
                .HasColumnName("RECEIVER");
            entity.Property(e => e.ReturnQty)
                .HasPrecision(18, 2)
                .HasComment("收料房冲销/退货数理 104+124 数量")
                .HasColumnName("RETURN_QTY");
            entity.Property(e => e.SapMatdocItemNo)
                .HasMaxLength(32)
                .HasComment("SAP303 凭证行项目号")
                .HasColumnName("SAP_MATDOC_ITEM_NO");
            entity.Property(e => e.SapMatdocNo)
                .HasMaxLength(32)
                .HasComment("SAP303 凭证号")
                .HasColumnName("SAP_MATDOC_NO");
            entity.Property(e => e.SapNo)
                .HasMaxLength(32)
                .HasComment("SAP 凭证")
                .HasColumnName("SAP_NO");
            entity.Property(e => e.SapOutItemNo)
                .HasMaxLength(255)
                .HasComment("SAP 交货单行项目号")
                .HasColumnName("SAP_OUT_ITEM_NO");
            entity.Property(e => e.SapOutNo)
                .HasMaxLength(32)
                .HasComment("SAP 交货单号")
                .HasColumnName("SAP_OUT_NO");
            entity.Property(e => e.SapQty)
                .HasPrecision(18)
                .HasComment("SAP 交货数量")
                .HasColumnName("SAP_QTY");
            entity.Property(e => e.SapStatus)
                .HasMaxLength(32)
                .HasComment("是否 SAP 过\n账用于先\n实物")
                .HasColumnName("SAP_STATUS");
            entity.Property(e => e.Sobkz)
                .HasMaxLength(32)
                .HasComment("库存类型")
                .HasColumnName("SOBKZ");
            entity.Property(e => e.StoreBinCode)
                .HasMaxLength(100)
                .HasComment("收货储位")
                .HasColumnName("STORE_BIN_CODE");
            entity.Property(e => e.Sysnod)
                .HasMaxLength(32)
                .HasComment("立库标识")
                .HasColumnName("SYSNOD");
            entity.Property(e => e.TestFlag)
                .HasMaxLength(32)
                .HasComment("质检标识(00质检、01免检、02无需质检的收料房库存可进仓也可退货)")
                .HasColumnName("TEST_FLAG");
            entity.Property(e => e.Type)
                .HasMaxLength(8)
                .HasComment("请求类型")
                .HasColumnName("TYPE");
            entity.Property(e => e.Unit)
                .HasMaxLength(32)
                .HasComment("单位")
                .HasColumnName("UNIT");
            entity.Property(e => e.UpdateDate)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Wbs)
                .HasMaxLength(32)
                .HasComment("WBS 元素号")
                .HasColumnName("WBS");
            entity.Property(e => e.Werks)
                .HasMaxLength(8)
                .HasComment("工厂代码")
                .HasColumnName("WERKS");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(32)
                .HasComment("仓库号")
                .HasColumnName("WH_NUMBER");
            entity.Property(e => e.WmsNo)
                .HasMaxLength(32)
                .HasComment("WMS 凭证")
                .HasColumnName("WMS_NO");
        });

        modelBuilder.Entity<ReceiveMaterial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReceiveMaterial", tb => tb.HasComment("接收到的物料主数据表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CarTypy)
                .HasMaxLength(250)
                .HasComment("车型信息")
                .HasColumnName("CAR_TYPY");
            entity.Property(e => e.DispatchingSection)
                .HasMaxLength(250)
                .HasComment("线体（工段）")
                .HasColumnName("DISPATCHING_SECTION");
            entity.Property(e => e.DispatchingType)
                .HasMaxLength(250)
                .HasComment("上线方式")
                .HasColumnName("DISPATCHING_TYPE");
            entity.Property(e => e.IncomPackCode)
                .HasMaxLength(250)
                .HasComment("来料包装代码")
                .HasColumnName("INCOM_PACK_CODE");
            entity.Property(e => e.IncomStanLoadQty)
                .HasPrecision(18, 2)
                .HasComment("来料标准装载量")
                .HasColumnName("INCOM_STAN_LOAD_QTY");
            entity.Property(e => e.IncomStanTranQty)
                .HasPrecision(18, 2)
                .HasComment("来料标装运载量")
                .HasColumnName("INCOM_STAN_TRAN_QTY");
            entity.Property(e => e.IsDeal).HasComment("导入数据是否已处理");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(100)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.Liktx)
                .HasMaxLength(250)
                .HasComment("供应商描述")
                .HasColumnName("LIKTX");
            entity.Property(e => e.LikuFlag)
                .HasMaxLength(2)
                .HasComment("是否上立库标识")
                .HasColumnName("LIKU_FLAG");
            entity.Property(e => e.Maktx)
                .HasMaxLength(250)
                .HasComment("物料描述")
                .HasColumnName("MAKTX");
            entity.Property(e => e.MaterialInventoryLimit)
                .HasPrecision(18, 2)
                .HasComment("物料库存上限")
                .HasColumnName("MATERIAL_INVENTORY_LIMIT");
            entity.Property(e => e.MaterialInventoryMinimum)
                .HasPrecision(18, 2)
                .HasComment("物料库存下限")
                .HasColumnName("MATERIAL_INVENTORY_MINIMUM");
            entity.Property(e => e.Matnr)
                .HasMaxLength(250)
                .HasComment("物料号")
                .HasColumnName("MATNR");
            entity.Property(e => e.Meins)
                .HasMaxLength(250)
                .HasComment("物料单位")
                .HasColumnName("MEINS");
            entity.Property(e => e.OnlineStanLoadQty)
                .HasPrecision(18, 2)
                .HasComment("上线标装装载量")
                .HasColumnName("ONLINE_STAN_LOAD_QTY");
            entity.Property(e => e.OnlineStanTranQty)
                .HasPrecision(18, 2)
                .HasComment("上线标准运载量")
                .HasColumnName("ONLINE_STAN_TRAN_QTY");
            entity.Property(e => e.PackCode)
                .HasMaxLength(250)
                .HasComment("包装代码")
                .HasColumnName("PACK_CODE");
            entity.Property(e => e.PartWeight)
                .HasMaxLength(32)
                .HasComment("零件重量")
                .HasColumnName("PART_WEIGHT");
            entity.Property(e => e.PerAuto)
                .HasMaxLength(100)
                .HasComment("单车用量")
                .HasColumnName("PER_AUTO");
            entity.Property(e => e.ReceiveMaterialId)
                .HasMaxLength(100)
                .HasComment("唯一标识")
                .HasColumnName("ReceiveMaterialID");
            entity.Property(e => e.SendnoOut)
                .HasMaxLength(250)
                .HasComment("出立库编码")
                .HasColumnName("SENDNO_OUT");
            entity.Property(e => e.Site)
                .HasMaxLength(250)
                .HasComment("站点")
                .HasColumnName("SITE");
            entity.Property(e => e.StandardBoxQty)
                .HasPrecision(18)
                .HasComment("标准码托箱数")
                .HasColumnName("STANDARD_BOX_QTY");
            entity.Property(e => e.Station)
                .HasMaxLength(250)
                .HasComment("工位")
                .HasColumnName("STATION");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasComment("有效状态x（有效）0 （无效）")
                .HasColumnName("STATUS");
            entity.Property(e => e.Sysnod)
                .HasMaxLength(250)
                .HasComment("入立库编码")
                .HasColumnName("SYSNOD");
            entity.Property(e => e.TurnPack)
                .HasMaxLength(2)
                .HasComment("是否翻包")
                .HasColumnName("TURN_PACK");
            entity.Property(e => e.TurnPackRegion)
                .HasMaxLength(250)
                .HasComment("集中翻包区")
                .HasColumnName("TURN_PACK_REGION");
            entity.Property(e => e.TurnPackStation)
                .HasMaxLength(250)
                .HasComment("集中翻包工位")
                .HasColumnName("TURN_PACK_STATION");
            entity.Property(e => e.TurnPackType)
                .HasMaxLength(250)
                .HasComment("翻包模式")
                .HasColumnName("TURN_PACK_TYPE");
            entity.Property(e => e.UpdateDate)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.UseBoxing)
                .HasMaxLength(2)
                .HasComment("是否套箱")
                .HasColumnName("USE_BOXING");
            entity.Property(e => e.Werks)
                .HasMaxLength(100)
                .HasComment("工厂代码")
                .HasColumnName("WERKS");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(100)
                .HasComment("仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<RobotCarInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RobotCarInfo", tb => tb.HasComment("穿梭车表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasComment("创建人");
            entity.Property(e => e.CurrentLayer).HasComment("所在当前层");
            entity.Property(e => e.CurrentRoadway)
                .HasMaxLength(120)
                .HasComment("所在当前巷道");
            entity.Property(e => e.CurrentStorage).HasComment("当前车内货位状态：1有货；2无货");
            entity.Property(e => e.CurrentTravel).HasComment("当前行走位置（第多少个货位）");
            entity.Property(e => e.RobotCarId)
                .HasMaxLength(120)
                .HasComment("唯一标识")
                .HasColumnName("RobotCarID");
            entity.Property(e => e.RobotCarIno)
                .HasMaxLength(50)
                .HasComment("小车号")
                .HasColumnName("RobotCarINo");
            entity.Property(e => e.State).HasComment("小车状态：1正常；2不可用(人工禁用)；15故障");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(100)
                .HasComment("修改人");
        });

        modelBuilder.Entity<RoleInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RoleInfo", tb => tb.HasComment("角色信息表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasComment("角色代码");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasComment("描述");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("角色名称");
            entity.Property(e => e.RoleId)
                .HasMaxLength(36)
                .HasComment("角色信息表ID（主键、非空）");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
        });

        modelBuilder.Entity<RoleMenuInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RoleMenuInfo", tb => tb.HasComment("角色菜单实体"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.MenuId)
                .HasMaxLength(36)
                .HasComment("菜单ID");
            entity.Property(e => e.MenuPowerId)
                .HasMaxLength(36)
                .HasComment("菜单权限表ID");
            entity.Property(e => e.RoleId)
                .HasMaxLength(36)
                .HasComment("角色ID");
            entity.Property(e => e.RoleMenuId)
                .HasMaxLength(36)
                .HasComment("角色菜单ID");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
        });

        modelBuilder.Entity<RouteDetail>(entity =>
        {
            entity.HasKey(e => e.DetailId).HasName("RouteDetail_pkey");

            entity
                .ToTable("RouteDetail")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.DetailId)
                .HasMaxLength(36)
                .HasComment("路径明细ID");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(50)
                .HasComment("业务类型");
            entity.Property(e => e.FromAddress)
                .HasMaxLength(50)
                .HasComment("起始地址");
            entity.Property(e => e.FromEquipment)
                .HasMaxLength(50)
                .HasComment("起始设备");
            entity.Property(e => e.LastTaskTime)
                .HasComment("最后任务时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Parameter)
                .HasMaxLength(500)
                .HasComment("业务参数");
            entity.Property(e => e.RouteId)
                .HasMaxLength(36)
                .HasComment("路径ID");
            entity.Property(e => e.RouteType)
                .HasMaxLength(50)
                .HasComment("路径类型");
            entity.Property(e => e.Sequence).HasComment("排序序号");
            entity.Property(e => e.TaskNum).HasComment("路径-任务限制数量");
            entity.Property(e => e.ToAddress)
                .HasMaxLength(50)
                .HasComment("目标地址");
            entity.Property(e => e.ToEquipment)
                .HasMaxLength(50)
                .HasComment("目标设备");
        });

        modelBuilder.Entity<RoutePolicyDetail>(entity =>
        {
            entity.HasKey(e => e.PolicyDetailId).HasName("RoutePolicyDetail_pkey");

            entity
                .ToTable("RoutePolicyDetail")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.PolicyDetailId).HasMaxLength(36);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(50);
            entity.Property(e => e.MethodName).HasMaxLength(500);
            entity.Property(e => e.MethodType).HasMaxLength(50);
            entity.Property(e => e.Parameter).HasMaxLength(2000);
            entity.Property(e => e.PolicyDetailName).HasMaxLength(150);
            entity.Property(e => e.TemplateId).HasMaxLength(36);
            entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator).HasMaxLength(50);
        });

        modelBuilder.Entity<RoutePolicyTemplate>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("RoutePolicyTemplate_pkey");

            entity
                .ToTable("RoutePolicyTemplate")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.TemplateId).HasMaxLength(36);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.RouteType).HasMaxLength(50);
            entity.Property(e => e.TemplateName).HasMaxLength(200);
            entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator).HasMaxLength(50);
        });

        modelBuilder.Entity<RouteSection>(entity =>
        {
            entity.HasKey(e => e.SectionId).HasName("RouteSection_pkey");

            entity
                .ToTable("RouteSection")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.SectionId).HasMaxLength(36);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(50);
            entity.Property(e => e.EquipmentCode).HasMaxLength(50);
            entity.Property(e => e.EquipmentType).HasMaxLength(50);
            entity.Property(e => e.RouteId).HasMaxLength(36);
            entity.Property(e => e.SectionName).HasMaxLength(50);
            entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator).HasMaxLength(50);
        });

        modelBuilder.Entity<RouteSectionTemplate>(entity =>
        {
            entity.HasKey(e => e.SectionTemplateId).HasName("RouteSectionTemplate_pkey");

            entity
                .ToTable("RouteSectionTemplate")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.SectionTemplateId).HasMaxLength(36);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(50);
            entity.Property(e => e.EquipmentCode).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.RouteId).HasMaxLength(36);
            entity.Property(e => e.RouteType).HasMaxLength(50);
            entity.Property(e => e.TemplateId).HasMaxLength(50);
            entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator).HasMaxLength(50);
        });

        modelBuilder.Entity<RouteSetting>(entity =>
        {
            entity.HasKey(e => e.RouteId).HasName("RouteSetting_pkey");

            entity
                .ToTable("RouteSetting")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.RouteId).HasMaxLength(36);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastUseTime)
                .HasComment("最后一次使用时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.ProgramId).HasMaxLength(36);
            entity.Property(e => e.RouteCode).HasMaxLength(50);
            entity.Property(e => e.RouteName).HasMaxLength(50);
            entity.Property(e => e.TaskType).HasMaxLength(50);
            entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator).HasMaxLength(50);
        });

        modelBuilder.Entity<RouteStationInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RouteStationInfo", tb => tb.HasComment("自定义路径表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Field1)
                .HasMaxLength(50)
                .HasComment("预留字段1");
            entity.Property(e => e.Field2)
                .HasMaxLength(50)
                .HasComment("预留字段2");
            entity.Property(e => e.Field3)
                .HasMaxLength(50)
                .HasComment("预留字段3");
            entity.Property(e => e.Field4)
                .HasMaxLength(50)
                .HasComment("预留字段4");
            entity.Property(e => e.Field5)
                .HasMaxLength(50)
                .HasComment("预留字段5");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasComment("唯一码");
            entity.Property(e => e.MidStationId)
                .HasMaxLength(50)
                .HasComment("可以到达站点码");
            entity.Property(e => e.StationId)
                .HasMaxLength(50)
                .HasComment("站点码");
            entity.Property(e => e.StationType).HasComment("站点类型");
            entity.Property(e => e.VitStationId)
                .HasMaxLength(50)
                .HasComment("虚拟站点码");
        });

        modelBuilder.Entity<ShuttleCarInterInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ShuttleCarInterInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.InterfaceName).HasMaxLength(50);
            entity.Property(e => e.Keyword1).HasMaxLength(50);
            entity.Property(e => e.Keyword2).HasMaxLength(50);
            entity.Property(e => e.LogId).HasMaxLength(50);
            entity.Property(e => e.RobotCarTaskType).HasMaxLength(50);
            entity.Property(e => e.State).HasDefaultValue(0);
            entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
        });

        modelBuilder.Entity<StackerWorkMode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StackerWorkMode", tb => tb.HasComment("堆垛机作业模式"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.StackerCode)
                .HasMaxLength(50)
                .HasComment("堆垛机编号");
            entity.Property(e => e.StackerWorkModeId)
                .HasMaxLength(36)
                .HasComment("堆垛机工作模式ID");
            entity.Property(e => e.State).HasComment("状态：0正常；1不可用(人工禁用)；");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
            entity.Property(e => e.WorkMode)
                .HasMaxLength(50)
                .HasComment("工作模式");
        });

        modelBuilder.Entity<StandingInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StandingInfo", tb => tb.HasComment("静置信息表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ActualEndTime)
                .HasComment("实际结束时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(50)
                .HasComment("托盘编码");
            entity.Property(e => e.Duration).HasComment("静置时长");
            entity.Property(e => e.DurationMax).HasComment("最大静置时长");
            entity.Property(e => e.ExpectEndTime)
                .HasComment("预计结束时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.InboundFinishTime)
                .HasComment("入库完成时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.InboundStartTime)
                .HasComment("入库开始时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.InventoryId)
                .HasMaxLength(36)
                .HasComment("托盘ID");
            entity.Property(e => e.IsEnd).HasComment("是否结束");
            entity.Property(e => e.IsOut).HasComment("是否出库");
            entity.Property(e => e.LocationNumber)
                .HasMaxLength(50)
                .HasComment("货位编码");
            entity.Property(e => e.OutboundFinishTime)
                .HasComment("出库完成时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.OutboundStartTime)
                .HasComment("出库开始时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.ProcessCaseNodeId)
                .HasMaxLength(36)
                .HasComment("流程实例节点ID");
            entity.Property(e => e.ProcessNodeName)
                .HasMaxLength(50)
                .HasComment("流程节点名称");
            entity.Property(e => e.StandingId)
                .HasMaxLength(36)
                .HasComment("静置信息表ID");
            entity.Property(e => e.StartTime)
                .HasComment("开始时间")
                .HasColumnType("timestamp(6) without time zone");
        });

        modelBuilder.Entity<StationCacheSet>(entity =>
        {
            entity.HasKey(e => e.StationCacheSetId).HasName("StationCacheSet_pkey");

            entity
                .ToTable("StationCacheSet", tb => tb.HasComment("站台缓存线体设置表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.StationCacheSetId)
                .HasMaxLength(100)
                .HasComment("唯一标识")
                .HasColumnName("StationCacheSetID");
            entity.Property(e => e.AddCacheLocationNum).HasComment("增加的虚拟缓存位数量(可以调整数量来提升效率)");
            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.CacheLocationNum).HasComment("缓存位数量");
            entity.Property(e => e.EquipmentCode)
                .HasMaxLength(100)
                .HasComment("终点设备编号");
            entity.Property(e => e.FreeLocationNum).HasComment("空闲数量");
            entity.Property(e => e.IsAgvStation).HasComment("是否AGV接驳台（1是，其他否）");
            entity.Property(e => e.IsFull).HasComment("空箱（托）线还是满箱（托）线（空箱是0，满箱是1，空满兼用则是2）");
            entity.Property(e => e.StationCode)
                .HasMaxLength(100)
                .HasComment("站点编号");
            entity.Property(e => e.Status).HasComment("状态（0无效，1有效）");
            entity.Property(e => e.WarehouseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<StockInfo>(entity =>
        {
            entity.HasKey(e => e.StockInfoId).HasName("StockInfo_pkey");

            entity
                .ToTable("StockInfo", tb => tb.HasComment("库存表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.StockInfoId)
                .HasMaxLength(50)
                .HasComment("库存ID");
            entity.Property(e => e.AllocatedQty)
                .HasPrecision(18, 3)
                .HasComment("已分配数量");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("库区编号");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(50)
                .HasComment("托盘号");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.ExpireDate)
                .HasComment("过期时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .HasComment("工厂编码");
            entity.Property(e => e.Field1)
                .HasMaxLength(50)
                .HasComment("预留字段1");
            entity.Property(e => e.Field10)
                .HasMaxLength(50)
                .HasComment("预留字段10");
            entity.Property(e => e.Field2)
                .HasMaxLength(50)
                .HasComment("预留字段2");
            entity.Property(e => e.Field3)
                .HasMaxLength(50)
                .HasComment("预留字段3");
            entity.Property(e => e.Field4)
                .HasMaxLength(50)
                .HasComment("预留字段4");
            entity.Property(e => e.Field5)
                .HasMaxLength(50)
                .HasComment("预留字段5");
            entity.Property(e => e.Field6)
                .HasMaxLength(50)
                .HasComment("预留字段6");
            entity.Property(e => e.Field7)
                .HasMaxLength(50)
                .HasComment("预留字段7");
            entity.Property(e => e.Field8)
                .HasMaxLength(50)
                .HasComment("预留字段8");
            entity.Property(e => e.Field9)
                .HasMaxLength(50)
                .HasComment("预留字段9");
            entity.Property(e => e.FreezeStatus)
                .HasComment("冻结状态（0解冻、1冻结）")
                .HasColumnName("Freeze_Status");
            entity.Property(e => e.InventoryState).HasComment("库存状态（ 0正常、1在途、2质检不合格、3盘点中、4盘亏、5盘盈）");
            entity.Property(e => e.ItemQty)
                .HasPrecision(18, 3)
                .HasComment("数量");
            entity.Property(e => e.LabelBarcode)
                .HasMaxLength(500)
                .HasComment("标签条码");
            entity.Property(e => e.LockQty)
                .HasPrecision(18, 3)
                .HasComment("锁定数量");
            entity.Property(e => e.LockRemark)
                .HasMaxLength(200)
                .HasComment("冻结备注");
            entity.Property(e => e.LockUser)
                .HasMaxLength(50)
                .HasComment("冻结人");
            entity.Property(e => e.LotNo)
                .HasMaxLength(100)
                .HasComment("批次");
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(100)
                .HasComment("物料编码");
            entity.Property(e => e.MaterialId)
                .HasMaxLength(100)
                .HasComment("物料ID");
            entity.Property(e => e.ProductionDate)
                .HasComment("生产日期")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.QualityStatus)
                .HasDefaultValue(1)
                .HasComment("质检状态(0正常，6待质检，7质检不合格)")
                .HasColumnName("Quality_Status");
            entity.Property(e => e.SequenceNo)
                .HasMaxLength(50)
                .HasComment("序列号,唯一标识符,用于确定商品的唯一性");
            entity.Property(e => e.StockingStatus)
                .HasDefaultValue(0)
                .HasComment("盘点状态(0正常、3盘点预约中、4盘亏、5盘盈)")
                .HasColumnName("Stocking_Status");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(100)
                .HasComment("供应商编号");
            entity.Property(e => e.UpdateTime)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(120)
                .HasComment("仓库编号");
            entity.Property(e => e.Weight)
                .HasPrecision(18, 3)
                .HasComment("重量");
        });

        modelBuilder.Entity<StockInfoChange>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockInfoChange", tb => tb.HasComment("库存变动记录"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("库区编号");
            entity.Property(e => e.BillItemNo)
                .HasMaxLength(255)
                .HasComment("行号")
                .HasColumnName("Bill_Item_NO");
            entity.Property(e => e.BillNo)
                .HasMaxLength(255)
                .HasComment("单号")
                .HasColumnName("Bill_NO");
            entity.Property(e => e.BillType)
                .HasMaxLength(50)
                .HasComment("单据类别（收货入库、移储入库、退料入库、非生产物料入库、拆零入库、总装出库）");
            entity.Property(e => e.ChangeQty)
                .HasPrecision(18, 3)
                .HasDefaultValue(0m)
                .HasComment("改变后库存数量");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(50)
                .HasComment("箱号/托盘号");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .HasComment("工厂编码");
            entity.Property(e => e.ItemQty)
                .HasPrecision(18, 3)
                .HasComment("改变前库存数量");
            entity.Property(e => e.Lgort)
                .HasMaxLength(100)
                .HasComment("库存地点（WMS）")
                .HasColumnName("LGORT");
            entity.Property(e => e.LotNo)
                .HasMaxLength(100)
                .HasComment("批次号");
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(100)
                .HasComment("物料编码");
            entity.Property(e => e.StockInfoChangeId)
                .HasMaxLength(50)
                .HasComment("唯一码")
                .HasColumnName("StockInfoChangeID");
            entity.Property(e => e.StockInfoId)
                .HasMaxLength(100)
                .HasComment("库存ID");
            entity.Property(e => e.StockType)
                .HasMaxLength(50)
                .HasComment("库存类型");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(100)
                .HasComment("供应商编号");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(120)
                .HasComment("仓库编号");
        });

        modelBuilder.Entity<StockingLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockingLog", tb => tb.HasComment("库存盘点日志"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.Batch)
                .HasMaxLength(255)
                .HasComment("批次")
                .HasColumnName("BATCH");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(255)
                .HasComment("箱号");
            entity.Property(e => e.CreateTime)
                .HasComment("盘点时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasComment("盘点人");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .HasComment("工厂编码");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(100)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.Liktx)
                .HasMaxLength(100)
                .HasComment("供应商描述")
                .HasColumnName("LIKTX");
            entity.Property(e => e.Matnr)
                .HasMaxLength(32)
                .HasComment("物料号")
                .HasColumnName("MATNR");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 3)
                .HasComment("系统库存数量")
                .HasColumnName("QTY");
            entity.Property(e => e.StockingLogId)
                .HasMaxLength(50)
                .HasComment("唯一码")
                .HasColumnName("StockingLogID");
            entity.Property(e => e.StockingPlanId)
                .HasMaxLength(50)
                .HasComment("盘点计划ID")
                .HasColumnName("StockingPlanID");
            entity.Property(e => e.StockingQty)
                .HasPrecision(18, 3)
                .HasComment("实际盘点数量")
                .HasColumnName("StockingQTY");
            entity.Property(e => e.StockingResultState)
                .HasMaxLength(50)
                .HasComment("盘点结果状态");
            entity.Property(e => e.UrnPackStation)
                .HasMaxLength(50)
                .HasComment("装配工位")
                .HasColumnName("URN_PACK_STATION");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("BYD仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<StockingPlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockingPlan", tb => tb.HasComment("库存盘点计划表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("库区编号");
            entity.Property(e => e.BeginTime)
                .HasComment("实际开始时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("now()")
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.EndTime)
                .HasComment("实际结束时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.IsLight)
                .HasMaxLength(2)
                .HasComment("0表示暗盘，1表示明盘，默认暗盘（盘点时不显示系统数量）");
            entity.Property(e => e.IsStatic)
                .HasMaxLength(2)
                .HasComment("是否冻结出入库(1表示冻结出入库，0表示可以出入库)，全盘是冻结出入库");
            entity.Property(e => e.PlanBeginTime)
                .HasComment("计划开始时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.PlanEndTime)
                .HasComment("计划结束时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasComment("状态（创建、盘点中、盘点暂停、盘点完成、盘点结果已上报、已确认盘点结果）");
            entity.Property(e => e.StockingPercent)
                .HasPrecision(18, 2)
                .HasComment("盘点类型是部分盘点，需设置盘点比例");
            entity.Property(e => e.StockingPlanId)
                .HasMaxLength(50)
                .HasComment("唯一码")
                .HasColumnName("StockingPlanID");
            entity.Property(e => e.StockingPlanName)
                .HasMaxLength(100)
                .HasComment("计划名称");
            entity.Property(e => e.StockingType)
                .HasMaxLength(50)
                .HasComment("盘点类型");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(120)
                .HasComment("仓库编号");
        });

        modelBuilder.Entity<StockingTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockingTable", tb => tb.HasComment("库存盘点表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.Batch)
                .HasMaxLength(255)
                .HasComment("批次")
                .HasColumnName("BATCH");
            entity.Property(e => e.IsCommitResult)
                .HasMaxLength(2)
                .HasComment("盘点结果是否已上报WMS");
            entity.Property(e => e.IsCreateTask)
                .HasMaxLength(2)
                .HasComment("是否已创建盘点任务");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(100)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.Liktx)
                .HasMaxLength(100)
                .HasComment("供应商描述")
                .HasColumnName("LIKTX");
            entity.Property(e => e.Matnr)
                .HasMaxLength(32)
                .HasComment("物料号")
                .HasColumnName("MATNR");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 2)
                .HasComment("系统库存数量（开始盘点时冻结数量）")
                .HasColumnName("QTY");
            entity.Property(e => e.StockingPlanId)
                .HasMaxLength(50)
                .HasComment("盘点计划ID")
                .HasColumnName("StockingPlanID");
            entity.Property(e => e.StockingPlanName)
                .HasMaxLength(100)
                .HasComment("盘点计划名称");
            entity.Property(e => e.StockingQty)
                .HasPrecision(18, 2)
                .HasComment("实际盘点数量")
                .HasColumnName("StockingQTY");
            entity.Property(e => e.StockingResultState)
                .HasMaxLength(50)
                .HasComment("盘点结果状态");
            entity.Property(e => e.StockingTableId)
                .HasMaxLength(50)
                .HasComment("唯一码")
                .HasColumnName("StockingTableID");
            entity.Property(e => e.UrnPackStation)
                .HasMaxLength(50)
                .HasComment("装配工位")
                .HasColumnName("URN_PACK_STATION");
            entity.Property(e => e.Werks)
                .HasMaxLength(8)
                .HasComment("工厂代码")
                .HasColumnName("WERKS");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<StorageChangeList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StorageChangeList")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AddOrRemove)
                .HasMaxLength(50)
                .HasComment("变动类型");
            entity.Property(e => e.Batch)
                .HasMaxLength(255)
                .HasComment("批次")
                .HasColumnName("BATCH");
            entity.Property(e => e.ChangeNumber)
                .HasPrecision(18, 2)
                .HasComment("变动数量");
            entity.Property(e => e.ContainerNo)
                .HasMaxLength(100)
                .HasComment("EU箱号/原箱号");
            entity.Property(e => e.CreateTime)
                .HasComment("变动时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Event)
                .HasMaxLength(50)
                .HasComment("变动事件");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(100)
                .HasComment("供应商代码")
                .HasColumnName("LIFNR");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .HasComment("库位");
            entity.Property(e => e.Matnr)
                .HasMaxLength(255)
                .HasComment("物料号")
                .HasColumnName("MATNR");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 2)
                .HasComment("数量")
                .HasColumnName("QTY");
            entity.Property(e => e.StoarageArea)
                .HasMaxLength(100)
                .HasComment("库区");
            entity.Property(e => e.StorageChangeId)
                .HasMaxLength(100)
                .HasColumnName("StorageChangeID");
            entity.Property(e => e.TaskNo)
                .HasMaxLength(50)
                .HasComment("任务号");
            entity.Property(e => e.TaskType)
                .HasMaxLength(50)
                .HasComment("任务类别");
            entity.Property(e => e.Werks)
                .HasMaxLength(8)
                .HasComment("工厂代码")
                .HasColumnName("WERKS");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<StoreInLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StoreInLog", tb => tb.HasComment("入库分配表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(120)
                .HasComment("库区编号");
            entity.Property(e => e.BillItemNo)
                .HasMaxLength(255)
                .HasComment("行号")
                .HasColumnName("Bill_Item_NO");
            entity.Property(e => e.BillNo)
                .HasMaxLength(255)
                .HasComment("单号")
                .HasColumnName("Bill_NO");
            entity.Property(e => e.CompleteDate)
                .HasComment("完成时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(100)
                .HasComment("箱号");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .HasComment("工厂编码");
            entity.Property(e => e.InStoreQty)
                .HasPrecision(18, 2)
                .HasComment("入库数量");
            entity.Property(e => e.IsOuterIdle).HasComment("是否外侧空闲");
            entity.Property(e => e.IsPushResult).HasComment("入库完成后是否推送BYD WMS(0表示未推送，1表示已推送，2表示无需推送)");
            entity.Property(e => e.IsZeroBox).HasComment("是否零头托/箱(1代表零头箱，默认是0代表整箱)");
            entity.Property(e => e.KeyId).HasMaxLength(50);
            entity.Property(e => e.Lgort)
                .HasMaxLength(50)
                .HasComment("库存地点（WMS）")
                .HasColumnName("LGORT");
            entity.Property(e => e.LocationType)
                .HasMaxLength(50)
                .HasComment("料箱货位类型（64表示600*400，86表示800*600,43表示400*300）或托盘货位类型");
            entity.Property(e => e.StationCode)
                .HasMaxLength(50)
                .HasComment("工作站台编号");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasComment("单据状态（创建、完成、取消）");
            entity.Property(e => e.StockInType)
                .HasMaxLength(50)
                .HasComment("入库类别（收货入库、移储入库、退料入库）");
            entity.Property(e => e.StockInfoId)
                .HasMaxLength(50)
                .HasComment("库存外键")
                .HasColumnName("StockInfoID");
            entity.Property(e => e.StockType)
                .HasMaxLength(50)
                .HasComment("库存类型");
            entity.Property(e => e.StoreInLogId)
                .HasMaxLength(50)
                .HasComment("唯一码")
                .HasColumnName("StoreInLogID");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(120)
                .HasComment("仓库编号");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasComment("BYD仓库号")
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<SubTaskHisInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SubTaskHisInfo", tb => tb.HasComment("任务历史子表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.DetailId)
                .HasMaxLength(36)
                .HasComment("业务明细ID");
            entity.Property(e => e.EndTime)
                .HasComment("结束时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.FallbackTime)
                .HasComment("取消时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.FromAddress)
                .HasMaxLength(50)
                .HasComment("起始货位");
            entity.Property(e => e.FromEquipmentCode)
                .HasMaxLength(50)
                .HasComment("起始设备");
            entity.Property(e => e.InsertTime)
                .HasComment("添加时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.OtherSystemTaskNo)
                .HasMaxLength(50)
                .HasComment("第三方任务号");
            entity.Property(e => e.PreviousSubTaskId)
                .HasMaxLength(36)
                .HasComment("下一个任务明细ID");
            entity.Property(e => e.RouteId)
                .HasMaxLength(36)
                .HasComment("路径ID");
            entity.Property(e => e.RouteType).HasMaxLength(50);
            entity.Property(e => e.StartTime)
                .HasComment("开始时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.SubTaskHisId)
                .HasMaxLength(36)
                .HasComment("任务明细历史ID");
            entity.Property(e => e.SubTaskId)
                .HasMaxLength(36)
                .HasComment("任务明细ID");
            entity.Property(e => e.SubTaskState)
                .HasMaxLength(50)
                .HasComment("任务明细状态");
            entity.Property(e => e.TaskId)
                .HasMaxLength(36)
                .HasComment("任务ID");
            entity.Property(e => e.TaskNumber).HasComment("任务号");
            entity.Property(e => e.ToAddress)
                .HasMaxLength(50)
                .HasComment("目标货位");
            entity.Property(e => e.ToEquipmentCode)
                .HasMaxLength(50)
                .HasComment("目标设备");
        });

        modelBuilder.Entity<SubTaskInfo>(entity =>
        {
            entity.HasKey(e => e.SubTaskId).HasName("SubTaskInfo_pkey");

            entity
                .ToTable("SubTaskInfo", tb => tb.HasComment("任务子表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.SubTaskId)
                .HasMaxLength(36)
                .HasComment("任务明细表ID");
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.DetailId)
                .HasMaxLength(36)
                .HasComment("业务明细ID");
            entity.Property(e => e.EndTime)
                .HasComment("结束时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.FallbackTime)
                .HasComment("取消时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.FromAddress)
                .HasMaxLength(50)
                .HasComment("起始货位");
            entity.Property(e => e.FromEquipmentCode)
                .HasMaxLength(50)
                .HasComment("起始设备");
            entity.Property(e => e.OtherSystemTaskNo)
                .HasMaxLength(50)
                .HasComment("第三方任务号");
            entity.Property(e => e.PreviousSubTaskId)
                .HasMaxLength(36)
                .HasComment("下一个任务明细ID");
            entity.Property(e => e.RouteId)
                .HasMaxLength(36)
                .HasComment("路径ID");
            entity.Property(e => e.RouteType).HasMaxLength(50);
            entity.Property(e => e.StartTime)
                .HasComment("开始时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.SubTaskState)
                .HasMaxLength(50)
                .HasComment("任务明细状态");
            entity.Property(e => e.TaskId)
                .HasMaxLength(36)
                .HasComment("任务ID");
            entity.Property(e => e.TaskNumber).HasComment("任务号");
            entity.Property(e => e.ToAddress)
                .HasMaxLength(50)
                .HasComment("目标货位");
            entity.Property(e => e.ToEquipmentCode)
                .HasMaxLength(50)
                .HasComment("目标设备");
        });

        modelBuilder.Entity<SupplierInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SupplierInfo")
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasComment("唯一标识");
            entity.Property(e => e.IsDeleted).HasComment("是否可用");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(50)
                .HasComment("供应商编码");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(150)
                .HasComment("供应商名称");
            entity.Property(e => e.UpdateTime)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone");
        });

        modelBuilder.Entity<SystemConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SystemConfig", tb => tb.HasComment("系统配置表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.ConfigCode)
                .HasMaxLength(50)
                .HasComment("配置编码");
            entity.Property(e => e.ConfigName)
                .HasMaxLength(100)
                .HasComment("配置名称");
            entity.Property(e => e.ConfigValue)
                .HasMaxLength(2000)
                .HasComment("配置值");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasComment("描述");
            entity.Property(e => e.SystemConfigId)
                .HasMaxLength(36)
                .HasComment("系统配置ID");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<TaskHisInfo>(entity =>
        {
            entity.HasKey(e => e.TaskHisId).HasName("TaskHisInfo_pkey");

            entity
                .ToTable("TaskHisInfo", tb => tb.HasComment("任务历史主表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.TaskHisId)
                .HasMaxLength(36)
                .HasComment("任务历史信息ID");
            entity.Property(e => e.BusinessDetailId)
                .HasMaxLength(36)
                .HasComment("业务明细ID");
            entity.Property(e => e.BusinessId)
                .HasMaxLength(36)
                .HasComment("业务标识ID");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(50)
                .HasComment("业务类型");
            entity.Property(e => e.CancelTime)
                .HasComment("取消时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(50)
                .HasComment("托盘编码");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.CurrentEquipment)
                .HasMaxLength(50)
                .HasComment("当前设备");
            entity.Property(e => e.DependTask)
                .HasMaxLength(50)
                .HasComment("依赖任务号");
            entity.Property(e => e.EndtEquipment)
                .HasMaxLength(50)
                .HasComment("终点设备");
            entity.Property(e => e.FinishTime)
                .HasComment("完成时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.FromAddress)
                .HasMaxLength(50)
                .HasComment("起始货位");
            entity.Property(e => e.InsertTime)
                .HasComment("添加时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Priority).HasComment("优先级");
            entity.Property(e => e.PriorityChangeTime)
                .HasComment("优先级改变时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Remark).HasMaxLength(2000);
            entity.Property(e => e.RouteId)
                .HasMaxLength(36)
                .HasComment("路径ID");
            entity.Property(e => e.SourceEquipment)
                .HasMaxLength(50)
                .HasComment("起始设备");
            entity.Property(e => e.StartTime)
                .HasComment("开始时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.TargetEquipment)
                .HasMaxLength(50)
                .HasComment("目标设备");
            entity.Property(e => e.TaskId)
                .HasMaxLength(36)
                .HasComment("任务ID");
            entity.Property(e => e.TaskNumber).HasComment("任务号");
            entity.Property(e => e.TaskState)
                .HasMaxLength(50)
                .HasComment("任务状态");
            entity.Property(e => e.TaskType)
                .HasMaxLength(50)
                .HasComment("任务类型");
            entity.Property(e => e.ToAddress)
                .HasMaxLength(50)
                .HasComment("目标货位");
            entity.Property(e => e.UpdateTime)
                .HasComment("更新时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<TaskInfo>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("TaskInfo_pkey");

            entity
                .ToTable("TaskInfo", tb => tb.HasComment("任务主表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.TaskId).HasMaxLength(36);
            entity.Property(e => e.BusinessDetailId)
                .HasMaxLength(36)
                .HasComment("业务明细ID");
            entity.Property(e => e.BusinessId)
                .HasMaxLength(36)
                .HasComment("业务标识ID");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(50)
                .HasComment("业务类型");
            entity.Property(e => e.CancelTime)
                .HasComment("取消时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(50)
                .HasComment("托盘编码");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.CurrentEquipment)
                .HasMaxLength(50)
                .HasComment("当前设备");
            entity.Property(e => e.DependTask)
                .HasMaxLength(50)
                .HasComment("依赖任务号");
            entity.Property(e => e.EndtEquipment).HasMaxLength(50);
            entity.Property(e => e.FinishTime)
                .HasComment("完成时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.FromAddress)
                .HasMaxLength(50)
                .HasComment("起始货位");
            entity.Property(e => e.Priority).HasComment("优先级");
            entity.Property(e => e.PriorityChangeTime)
                .HasComment("优先级改变时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Remark).HasMaxLength(2000);
            entity.Property(e => e.RouteId)
                .HasMaxLength(36)
                .HasComment("路径ID");
            entity.Property(e => e.SourceEquipment)
                .HasMaxLength(50)
                .HasComment("起始设备");
            entity.Property(e => e.StartTime)
                .HasComment("开始时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.TargetEquipment)
                .HasMaxLength(50)
                .HasComment("目标设备");
            entity.Property(e => e.TaskNumber).HasComment("任务号");
            entity.Property(e => e.TaskState)
                .HasMaxLength(50)
                .HasComment("任务状态");
            entity.Property(e => e.TaskType)
                .HasMaxLength(50)
                .HasComment("任务类型");
            entity.Property(e => e.ToAddress)
                .HasMaxLength(50)
                .HasComment("目标货位");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<UserInfo>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("UserInfo_pkey");

            entity.ToTable("UserInfo");

            entity.Property(e => e.CreateTime).HasColumnType("timestamp without time zone");
            entity.Property(e => e.LastLoginTime).HasColumnType("timestamp without time zone");
            entity.Property(e => e.UpdateTime).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<UserLogInfo>(entity =>
        {
            entity.HasKey(e => e.UserLogId).HasName("UserLogInfo_pkey");

            entity
                .ToTable("UserLogInfo", tb => tb.HasComment("用户操作日志表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.UserLogId)
                .HasMaxLength(36)
                .HasComment("用户操作日志表ID");
            entity.Property(e => e.ActionBody)
                .HasMaxLength(100)
                .HasComment("请求体中的所有值");
            entity.Property(e => e.ActionIp)
                .HasMaxLength(50)
                .HasComment("请求方IP地址");
            entity.Property(e => e.ActionMethod)
                .HasMaxLength(50)
                .HasComment("请求方法");
            entity.Property(e => e.ActionName)
                .HasMaxLength(50)
                .HasComment("操作方法名");
            entity.Property(e => e.ActionPara).HasComment("请求参数");
            entity.Property(e => e.ActionResult)
                .HasMaxLength(8000)
                .HasComment("响应结果");
            entity.Property(e => e.ActionType).HasComment("操作类型(0、添加1、删除2、修改)");
            entity.Property(e => e.ActionUrl)
                .HasMaxLength(300)
                .HasComment("接口地址(URL)");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasComment("描述");
            entity.Property(e => e.RequestTime)
                .HasComment("请求时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.ResponseTime)
                .HasComment("响应时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Stopwatch).HasComment("响应时长");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .HasComment("操作表名");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasComment("操作用户--token");
        });

        modelBuilder.Entity<UserLogInfoCopy1>(entity =>
        {
            entity.HasKey(e => e.UserLogId).HasName("UserLogInfo_copy1_pkey");

            entity
                .ToTable("UserLogInfo_copy1", tb => tb.HasComment("用户操作日志表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.UserLogId)
                .HasMaxLength(36)
                .HasComment("用户操作日志表ID");
            entity.Property(e => e.ActionBody)
                .HasMaxLength(100)
                .HasComment("请求体中的所有值");
            entity.Property(e => e.ActionIp)
                .HasMaxLength(50)
                .HasComment("请求方IP地址");
            entity.Property(e => e.ActionMethod)
                .HasMaxLength(50)
                .HasComment("请求方法");
            entity.Property(e => e.ActionName)
                .HasMaxLength(50)
                .HasComment("操作方法名");
            entity.Property(e => e.ActionPara).HasComment("请求参数");
            entity.Property(e => e.ActionResult)
                .HasMaxLength(8000)
                .HasComment("响应结果");
            entity.Property(e => e.ActionType).HasComment("操作类型(0、添加1、删除2、修改)");
            entity.Property(e => e.ActionUrl)
                .HasMaxLength(300)
                .HasComment("接口地址(URL)");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasComment("描述");
            entity.Property(e => e.RequestTime)
                .HasComment("请求时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.ResponseTime)
                .HasComment("响应时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Stopwatch).HasComment("响应时长");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .HasComment("操作表名");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasComment("操作用户--token");
        });

        modelBuilder.Entity<UtlFileDir>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("utl_file_dir");

            entity.Property(e => e.Dir).HasColumnName("dir");
        });

        modelBuilder.Entity<VConfirmNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ConfirmNumber");

            entity.Property(e => e.Count).HasColumnName("count");
        });

        modelBuilder.Entity<VEmergencyInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_EmergencyInfo");

            entity.Property(e => e.AllocatedQty).HasPrecision(18, 3);
            entity.Property(e => e.AreaId).HasMaxLength(50);
            entity.Property(e => e.BasePackingTypeCode).HasMaxLength(120);
            entity.Property(e => e.BillItemNo)
                .HasMaxLength(255)
                .HasColumnName("Bill_Item_NO");
            entity.Property(e => e.BillNo)
                .HasMaxLength(255)
                .HasColumnName("Bill_NO");
            entity.Property(e => e.ContainerId).HasMaxLength(50);
            entity.Property(e => e.ContainerType).HasMaxLength(50);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.EquipmentCode).HasMaxLength(50);
            entity.Property(e => e.ExpireDate).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.FactoryNo).HasMaxLength(50);
            entity.Property(e => e.Field1).HasMaxLength(50);
            entity.Property(e => e.Field10).HasMaxLength(50);
            entity.Property(e => e.Field2).HasMaxLength(50);
            entity.Property(e => e.Field3).HasMaxLength(50);
            entity.Property(e => e.Field4).HasMaxLength(50);
            entity.Property(e => e.Field5).HasMaxLength(50);
            entity.Property(e => e.Field6).HasMaxLength(50);
            entity.Property(e => e.Field7).HasMaxLength(50);
            entity.Property(e => e.Field8).HasMaxLength(50);
            entity.Property(e => e.Field9).HasMaxLength(50);
            entity.Property(e => e.FreezeStatus).HasColumnName("Freeze_Status");
            entity.Property(e => e.InventoryId).HasMaxLength(50);
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.ItemQty).HasPrecision(18, 3);
            entity.Property(e => e.LabelBarcode).HasMaxLength(500);
            entity.Property(e => e.Lgort)
                .HasMaxLength(50)
                .HasColumnName("LGORT");
            entity.Property(e => e.LocationNumber).HasMaxLength(50);
            entity.Property(e => e.LocationState).HasMaxLength(50);
            entity.Property(e => e.LocationType).HasMaxLength(50);
            entity.Property(e => e.LocationUse).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.MaterialCode).HasMaxLength(150);
            entity.Property(e => e.MaterialDescription).HasMaxLength(150);
            entity.Property(e => e.MaterialId).HasMaxLength(100);
            entity.Property(e => e.MaterialName).HasMaxLength(180);
            entity.Property(e => e.MaterialSpec).HasMaxLength(150);
            entity.Property(e => e.MaterialTypeCode).HasMaxLength(120);
            entity.Property(e => e.ProductionDate).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.QualityStatus).HasColumnName("Quality_Status");
            entity.Property(e => e.StockInType).HasMaxLength(50);
            entity.Property(e => e.StockType).HasMaxLength(50);
            entity.Property(e => e.StockingStatus).HasColumnName("Stocking_Status");
            entity.Property(e => e.SupplierCode).HasMaxLength(100);
            entity.Property(e => e.SupplierName).HasMaxLength(150);
            entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.WarehouseId).HasMaxLength(50);
            entity.Property(e => e.WeightLowerLimit).HasPrecision(18, 2);
            entity.Property(e => e.WeightNum).HasPrecision(18, 3);
            entity.Property(e => e.WeightUpperLimit).HasPrecision(18, 2);
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<VInBoundDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_InBoundDetail");

            entity.Property(e => e.ActualQty).HasPrecision(18, 2);
            entity.Property(e => e.BillLineNo).HasMaxLength(50);
            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.BillQty).HasPrecision(18, 2);
            entity.Property(e => e.BillType).HasMaxLength(50);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(50);
            entity.Property(e => e.FactoryNo).HasMaxLength(50);
            entity.Property(e => e.Lgort)
                .HasMaxLength(50)
                .HasColumnName("LGORT");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.MaterialCode).HasMaxLength(50);
            entity.Property(e => e.MaterialName).HasMaxLength(100);
            entity.Property(e => e.PostCount).HasPrecision(18, 2);
            entity.Property(e => e.StockType).HasMaxLength(50);
            entity.Property(e => e.SupplierCode).HasMaxLength(100);
            entity.Property(e => e.SupplierName).HasMaxLength(100);
            entity.Property(e => e.WhNumber)
                .HasMaxLength(32)
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<VLocationUsageRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_LocationUsageRate");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<VLocationUsageRateOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_LocationUsageRateOld");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<VMinSaftyStockInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MinSaftyStockInfo");

            entity.Property(e => e.MaterialCode).HasMaxLength(100);
            entity.Property(e => e.MaterialName).HasMaxLength(180);
        });

        modelBuilder.Entity<VMonitorInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MonitorInfo");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.MonitorId).HasMaxLength(36);
            entity.Property(e => e.MonitorName).HasMaxLength(50);
            entity.Property(e => e.ProgramCode).HasMaxLength(50);
        });

        modelBuilder.Entity<VOutBoundBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_OutBoundBill");

            entity.Property(e => e.BillLineNo).HasMaxLength(100);
            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(50);
            entity.Property(e => e.MaterialCode).HasMaxLength(50);
            entity.Property(e => e.MaterialName).HasMaxLength(200);
            entity.Property(e => e.Remark).HasMaxLength(200);
        });

        modelBuilder.Entity<VOutboundDetial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_OutboundDetial");

            entity.Property(e => e.ActualQty).HasPrecision(18, 2);
            entity.Property(e => e.Agvroute)
                .HasMaxLength(50)
                .HasColumnName("AGVROUTE");
            entity.Property(e => e.BillLineNo).HasMaxLength(100);
            entity.Property(e => e.BillNo).HasMaxLength(100);
            entity.Property(e => e.BillQty).HasPrecision(18, 2);
            entity.Property(e => e.BillType).HasMaxLength(50);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(50);
            entity.Property(e => e.FactoryNo).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.MaterialCode).HasMaxLength(50);
            entity.Property(e => e.MaterialName).HasMaxLength(200);
            entity.Property(e => e.Remark).HasMaxLength(200);
            entity.Property(e => e.SupplierCode).HasMaxLength(100);
        });

        modelBuilder.Entity<VReceiptWaitingClose>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ReceiptWaitingClose");

            entity.Property(e => e.Afnam)
                .HasMaxLength(32)
                .HasColumnName("AFNAM");
            entity.Property(e => e.Asnitm)
                .HasMaxLength(32)
                .HasColumnName("ASNITM");
            entity.Property(e => e.Asnno)
                .HasMaxLength(255)
                .HasColumnName("ASNNO");
            entity.Property(e => e.Batch)
                .HasMaxLength(32)
                .HasColumnName("BATCH");
            entity.Property(e => e.Bednr)
                .HasMaxLength(32)
                .HasColumnName("BEDNR");
            entity.Property(e => e.BoxCount)
                .HasPrecision(18)
                .HasColumnName("BOX_COUNT");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(32)
                .HasColumnName("BUSINESS_NAME");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(32)
                .HasColumnName("BUSINESS_TYPE");
            entity.Property(e => e.CheckedQty)
                .HasPrecision(18, 2)
                .HasColumnName("CHECKED_QTY");
            entity.Property(e => e.Creator)
                .HasMaxLength(32)
                .HasColumnName("CREATOR");
            entity.Property(e => e.Del)
                .HasMaxLength(32)
                .HasColumnName("DEL");
            entity.Property(e => e.FBatch)
                .HasMaxLength(32)
                .HasColumnName("F_BATCH");
            entity.Property(e => e.FLgort)
                .HasMaxLength(32)
                .HasColumnName("F_LGORT");
            entity.Property(e => e.FWerks)
                .HasMaxLength(32)
                .HasColumnName("F_WERKS");
            entity.Property(e => e.FWhNumber)
                .HasMaxLength(32)
                .HasColumnName("F_WH_NUMBER");
            entity.Property(e => e.FullBoxQty)
                .HasPrecision(18)
                .HasColumnName("FULL_BOX_QTY");
            entity.Property(e => e.GrArea)
                .HasMaxLength(32)
                .HasColumnName("GR_AREA");
            entity.Property(e => e.InQty)
                .HasPrecision(18, 2)
                .HasColumnName("IN_QTY");
            entity.Property(e => e.InableQty)
                .HasPrecision(18, 2)
                .HasColumnName("INABLE_QTY");
            entity.Property(e => e.InbounStatus)
                .HasMaxLength(2)
                .HasColumnName("INBOUN_STATUS");
            entity.Property(e => e.InboundItemNo)
                .HasMaxLength(32)
                .HasColumnName("INBOUND_ITEM_NO");
            entity.Property(e => e.InboundNo)
                .HasMaxLength(32)
                .HasColumnName("INBOUND_NO");
            entity.Property(e => e.IsValid).HasMaxLength(2);
            entity.Property(e => e.Lgort)
                .HasMaxLength(32)
                .HasColumnName("LGORT");
            entity.Property(e => e.Lifnr)
                .HasMaxLength(100)
                .HasColumnName("LIFNR");
            entity.Property(e => e.Liktx)
                .HasMaxLength(100)
                .HasColumnName("LIKTX");
            entity.Property(e => e.Maktx)
                .HasMaxLength(100)
                .HasColumnName("MAKTX");
            entity.Property(e => e.Matnr)
                .HasMaxLength(32)
                .HasColumnName("MATNR");
            entity.Property(e => e.PartNo)
                .HasMaxLength(50)
                .HasColumnName("PART_NO");
            entity.Property(e => e.PoItemNo)
                .HasMaxLength(255)
                .HasColumnName("PO_ITEM_NO");
            entity.Property(e => e.PoNo)
                .HasMaxLength(255)
                .HasColumnName("PO_NO");
            entity.Property(e => e.ProjectOreder)
                .HasMaxLength(32)
                .HasColumnName("PROJECT_OREDER");
            entity.Property(e => e.QcResultCode)
                .HasMaxLength(32)
                .HasColumnName("QC_RESULT_CODE");
            entity.Property(e => e.ReceiptDate)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("RECEIPT_DATE");
            entity.Property(e => e.ReceiptId)
                .HasMaxLength(100)
                .HasColumnName("ReceiptID");
            entity.Property(e => e.ReceiptItemNo)
                .HasMaxLength(32)
                .HasColumnName("RECEIPT_ITEM_NO");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(32)
                .HasColumnName("RECEIPT_NO");
            entity.Property(e => e.ReceiptQty)
                .HasPrecision(18, 2)
                .HasColumnName("RECEIPT_QTY");
            entity.Property(e => e.Receiver)
                .HasMaxLength(32)
                .HasColumnName("RECEIVER");
            entity.Property(e => e.ReturnQty)
                .HasPrecision(18, 2)
                .HasColumnName("RETURN_QTY");
            entity.Property(e => e.SapMatdocItemNo)
                .HasMaxLength(32)
                .HasColumnName("SAP_MATDOC_ITEM_NO");
            entity.Property(e => e.SapMatdocNo)
                .HasMaxLength(32)
                .HasColumnName("SAP_MATDOC_NO");
            entity.Property(e => e.SapNo)
                .HasMaxLength(32)
                .HasColumnName("SAP_NO");
            entity.Property(e => e.SapOutItemNo)
                .HasMaxLength(255)
                .HasColumnName("SAP_OUT_ITEM_NO");
            entity.Property(e => e.SapOutNo)
                .HasMaxLength(32)
                .HasColumnName("SAP_OUT_NO");
            entity.Property(e => e.SapQty)
                .HasPrecision(18)
                .HasColumnName("SAP_QTY");
            entity.Property(e => e.SapStatus)
                .HasMaxLength(32)
                .HasColumnName("SAP_STATUS");
            entity.Property(e => e.Sobkz)
                .HasMaxLength(32)
                .HasColumnName("SOBKZ");
            entity.Property(e => e.StoreBinCode)
                .HasMaxLength(100)
                .HasColumnName("STORE_BIN_CODE");
            entity.Property(e => e.Sysnod)
                .HasMaxLength(32)
                .HasColumnName("SYSNOD");
            entity.Property(e => e.TestFlag)
                .HasMaxLength(32)
                .HasColumnName("TEST_FLAG");
            entity.Property(e => e.Type)
                .HasMaxLength(8)
                .HasColumnName("TYPE");
            entity.Property(e => e.Unit)
                .HasMaxLength(32)
                .HasColumnName("UNIT");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Wbs)
                .HasMaxLength(32)
                .HasColumnName("WBS");
            entity.Property(e => e.Werks)
                .HasMaxLength(8)
                .HasColumnName("WERKS");
            entity.Property(e => e.WhNumber)
                .HasMaxLength(32)
                .HasColumnName("WH_NUMBER");
            entity.Property(e => e.WmsNo)
                .HasMaxLength(32)
                .HasColumnName("WMS_NO");
        });

        modelBuilder.Entity<VStockInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_StockInfo");

            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.ContainerCode).HasMaxLength(50);
            entity.Property(e => e.FactoryNo).HasMaxLength(50);
            entity.Property(e => e.FreezeStatus).HasColumnName("Freeze_Status");
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.MaterialCode).HasMaxLength(150);
            entity.Property(e => e.MaterialDescription).HasMaxLength(150);
            entity.Property(e => e.MaterialName).HasMaxLength(180);
            entity.Property(e => e.OutboundQty).HasPrecision(18, 3);
            entity.Property(e => e.StockInfoId).HasMaxLength(50);
            entity.Property(e => e.SupplierCode).HasMaxLength(100);
        });

        modelBuilder.Entity<VStockPlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_StockPlan");

            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.ContainerCode).HasMaxLength(50);
            entity.Property(e => e.EquipmentCode).HasMaxLength(50);
            entity.Property(e => e.FactoryNo).HasMaxLength(50);
            entity.Property(e => e.FreezeStatus).HasColumnName("Freeze_Status");
            entity.Property(e => e.ItemQty).HasPrecision(18, 3);
            entity.Property(e => e.LocationNumber).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.MaterialCode).HasMaxLength(100);
            entity.Property(e => e.MaterialName).HasMaxLength(180);
            entity.Property(e => e.StockInfoId).HasMaxLength(50);
            entity.Property(e => e.SupplierCode).HasMaxLength(100);
        });

        modelBuilder.Entity<VStockingLogBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_StockingLogBill");

            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.Batch)
                .HasMaxLength(255)
                .HasColumnName("BATCH");
            entity.Property(e => e.ContainerCode).HasMaxLength(255);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(100);
            entity.Property(e => e.IsLight).HasMaxLength(2);
            entity.Property(e => e.IsStatic).HasMaxLength(2);
            entity.Property(e => e.Lifnr)
                .HasMaxLength(100)
                .HasColumnName("LIFNR");
            entity.Property(e => e.Liktx)
                .HasMaxLength(100)
                .HasColumnName("LIKTX");
            entity.Property(e => e.Matnr)
                .HasMaxLength(32)
                .HasColumnName("MATNR");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 3)
                .HasColumnName("QTY");
            entity.Property(e => e.ShowQty)
                .HasColumnType("character varying")
                .HasColumnName("ShowQTY");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StockingLogId)
                .HasMaxLength(50)
                .HasColumnName("StockingLogID");
            entity.Property(e => e.StockingPlanId)
                .HasMaxLength(50)
                .HasColumnName("StockingPlanID");
            entity.Property(e => e.StockingPlanName).HasMaxLength(100);
            entity.Property(e => e.StockingQty)
                .HasPrecision(18, 3)
                .HasColumnName("StockingQTY");
            entity.Property(e => e.StockingResultState).HasMaxLength(50);
            entity.Property(e => e.StockingType).HasMaxLength(50);
            entity.Property(e => e.UrnPackStation)
                .HasMaxLength(50)
                .HasColumnName("URN_PACK_STATION");
            entity.Property(e => e.WarehouseCode).HasMaxLength(120);
        });

        modelBuilder.Entity<VStockingReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_StockingReport");

            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.Batch)
                .HasMaxLength(255)
                .HasColumnName("BATCH");
            entity.Property(e => e.FactoryNo).HasMaxLength(50);
            entity.Property(e => e.Lifnr)
                .HasMaxLength(100)
                .HasColumnName("LIFNR");
            entity.Property(e => e.Matnr)
                .HasMaxLength(32)
                .HasColumnName("MATNR");
            entity.Property(e => e.Qty).HasColumnName("QTY");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StockingPlanName).HasMaxLength(100);
            entity.Property(e => e.StockingQty).HasColumnName("StockingQTY");
            entity.Property(e => e.StockingResultState).HasMaxLength(50);
            entity.Property(e => e.WarehouseCode).HasMaxLength(120);
        });

        modelBuilder.Entity<VTaskInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TaskInfo");

            entity.Property(e => e.BusinessDetailId).HasMaxLength(36);
            entity.Property(e => e.BusinessId).HasMaxLength(36);
            entity.Property(e => e.BusinessType).HasMaxLength(50);
            entity.Property(e => e.CancelTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.ContainerCode).HasMaxLength(50);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator).HasMaxLength(50);
            entity.Property(e => e.CurrentEquipment).HasMaxLength(50);
            entity.Property(e => e.DependTask).HasMaxLength(50);
            entity.Property(e => e.EndtEquipment).HasMaxLength(50);
            entity.Property(e => e.FinishTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.FromAddress).HasMaxLength(50);
            entity.Property(e => e.MaterialCode).HasMaxLength(150);
            entity.Property(e => e.PriorityChangeTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Remark).HasMaxLength(2000);
            entity.Property(e => e.RequirementItemNo)
                .HasMaxLength(255)
                .HasColumnName("REQUIREMENT_ITEM_NO");
            entity.Property(e => e.RequirementNo)
                .HasMaxLength(255)
                .HasColumnName("REQUIREMENT_NO");
            entity.Property(e => e.RouteId).HasMaxLength(36);
            entity.Property(e => e.SourceEquipment).HasMaxLength(50);
            entity.Property(e => e.StartTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.TargetEquipment).HasMaxLength(50);
            entity.Property(e => e.TaskId).HasMaxLength(36);
            entity.Property(e => e.TaskState).HasMaxLength(50);
            entity.Property(e => e.TaskType).HasMaxLength(50);
            entity.Property(e => e.ToAddress).HasMaxLength(50);
            entity.Property(e => e.UpdateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator).HasMaxLength(50);
        });

        modelBuilder.Entity<VUnClosed>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_UnClosed");

            entity.Property(e => e.ActualQty).HasPrecision(18, 2);
            entity.Property(e => e.BillLineNo).HasMaxLength(100);
            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.BillQty).HasPrecision(18, 2);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.MaterialCode).HasMaxLength(50);
            entity.Property(e => e.MaterialName).HasMaxLength(200);
            entity.Property(e => e.OutBoundDetailInfoId).HasMaxLength(100);
            entity.Property(e => e.Remark).HasMaxLength(200);
        });

        modelBuilder.Entity<ViewPartsWarehouseBreakdown>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewPartsWarehouseBreakdown");

            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.ContainerCode).HasMaxLength(150);
            entity.Property(e => e.FactQuantity).HasPrecision(18, 2);
            entity.Property(e => e.FactoryNo).HasMaxLength(50);
            entity.Property(e => e.Id).HasMaxLength(120);
            entity.Property(e => e.LotNo).HasMaxLength(150);
            entity.Property(e => e.MaterialCode).HasMaxLength(150);
            entity.Property(e => e.RequirementNo)
                .HasMaxLength(255)
                .HasColumnName("REQUIREMENT_NO");
            entity.Property(e => e.SupplierCode).HasMaxLength(150);
            entity.Property(e => e.WarehouseCode).HasMaxLength(120);
        });

        modelBuilder.Entity<ViewPendingOutboundOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewPendingOutboundOrders");

            entity.Property(e => e.ActualQty).HasPrecision(18, 2);
            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.BillLineNo).HasMaxLength(100);
            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.BillQty).HasPrecision(18, 2);
            entity.Property(e => e.BillType).HasMaxLength(50);
            entity.Property(e => e.CreateTime).HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.FactoryNo).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.MaterialCode).HasMaxLength(50);
            entity.Property(e => e.MaterialName).HasMaxLength(200);
            entity.Property(e => e.OutBoundDetailInfoId).HasMaxLength(100);
            entity.Property(e => e.OutBoundHeaderId).HasMaxLength(50);
            entity.Property(e => e.SupplierCode).HasMaxLength(100);
            entity.Property(e => e.SupplierName).HasMaxLength(100);
            entity.Property(e => e.Sysnod)
                .HasMaxLength(16)
                .HasColumnName("SYSNOD");
            entity.Property(e => e.WarehouseCode).HasMaxLength(50);
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<ViewSumStock2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewSumStock2");

            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.MaterialCode).HasMaxLength(100);
            entity.Property(e => e.MaterialName).HasMaxLength(180);
            entity.Property(e => e.SupplierCode).HasMaxLength(100);
            entity.Property(e => e.SupplierName).HasMaxLength(150);
        });

        modelBuilder.Entity<ViewSumStockDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewSumStockDetail");

            entity.Property(e => e.FactoryNo).HasMaxLength(50);
            entity.Property(e => e.LotNo).HasMaxLength(100);
            entity.Property(e => e.MaterialCode).HasMaxLength(100);
            entity.Property(e => e.MaterialName).HasMaxLength(180);
            entity.Property(e => e.SupplierCode).HasMaxLength(100);
            entity.Property(e => e.WarehouseCode).HasMaxLength(120);
        });

        modelBuilder.Entity<ViewWarehousingEntrySummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewWarehousingEntrySummary");

            entity.Property(e => e.AreaCode).HasMaxLength(120);
            entity.Property(e => e.BillNo)
                .HasMaxLength(255)
                .HasColumnName("Bill_NO");
            entity.Property(e => e.ContainerCode).HasMaxLength(100);
            entity.Property(e => e.Lgort)
                .HasMaxLength(50)
                .HasColumnName("LGORT");
            entity.Property(e => e.MaterialCode).HasMaxLength(100);
            entity.Property(e => e.StockInType).HasMaxLength(50);
            entity.Property(e => e.StockType).HasMaxLength(50);
            entity.Property(e => e.Sum).HasColumnName("sum");
            entity.Property(e => e.SupplierCode).HasMaxLength(100);
            entity.Property(e => e.WhNumber)
                .HasMaxLength(16)
                .HasColumnName("WH_NUMBER");
        });

        modelBuilder.Entity<WarehouseInfo>(entity =>
        {
            entity.HasKey(e => e.WarehouseId).HasName("WarehouseInfo_pkey");

            entity
                .ToTable("WarehouseInfo", tb => tb.HasComment("仓库信息表"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.WarehouseId)
                .HasMaxLength(36)
                .HasComment("仓库ID");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasComment("仓库所在地址");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasComment("仓库代码");
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .HasComment("创建人");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasDefaultValueSql("NULL::character varying")
                .HasComment("描述");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("仓库名称");
            entity.Property(e => e.PostCode)
                .HasMaxLength(100)
                .HasComment("仓库所在地邮编");
            entity.Property(e => e.SequenceNumber).HasComment("顺序号");
            entity.Property(e => e.StateCode).HasComment("状态（0：删除1：激活9：停用）");
            entity.Property(e => e.SysCode)
                .HasMaxLength(50)
                .HasComment("上位编码");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(50)
                .HasComment("修改人");
        });

        modelBuilder.Entity<WorkStation>(entity =>
        {
            entity.HasKey(e => e.StationId).HasName("WorkStation_pkey");

            entity
                .ToTable("WorkStation", tb => tb.HasComment("工作站台（翻包台/整箱拣配口/拆零拣配口/入库异常口/出库异常口）\n作业模式设置"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.StationId)
                .HasMaxLength(100)
                .HasComment("唯一码")
                .HasColumnName("StationID");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .HasComment("库区编号");
            entity.Property(e => e.CountType).HasMaxLength(50);
            entity.Property(e => e.CreateTime)
                .HasComment("创建时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasComment("创建人");
            entity.Property(e => e.CurrentContainerType)
                .HasMaxLength(50)
                .HasComment("当前箱型");
            entity.Property(e => e.CurrentMode)
                .HasMaxLength(100)
                .HasComment("当前作业模式");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .HasComment("站点电脑IP地址");
            entity.Property(e => e.StationCode)
                .HasMaxLength(50)
                .HasComment("站点编号");
            entity.Property(e => e.StationName)
                .HasMaxLength(100)
                .HasComment("站点名称");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasDefaultValueSql("1")
                .HasComment("状态（0无效，1有效）");
            entity.Property(e => e.UpdateTime)
                .HasComment("修改时间")
                .HasColumnType("timestamp(6) without time zone");
            entity.Property(e => e.Updator)
                .HasMaxLength(100)
                .HasComment("修改人");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(120)
                .HasComment("仓库编号");
        });

        modelBuilder.Entity<WorkStationModeSet>(entity =>
        {
            entity.HasKey(e => e.WorkStationModeSetId).HasName("WorkStationModeSet_pkey");

            entity
                .ToTable("WorkStationModeSet", tb => tb.HasComment("站台可切换模式"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.WorkStationModeSetId)
                .HasMaxLength(255)
                .HasComment("唯一码")
                .HasColumnName("WorkStationModeSetID");
            entity.Property(e => e.CanChangeMode)
                .HasMaxLength(255)
                .HasComment("支持模式");
            entity.Property(e => e.StationCode)
                .HasMaxLength(255)
                .HasComment("站点编号");
        });

        modelBuilder.Entity<WorkStationTypeSet>(entity =>
        {
            entity.HasKey(e => e.WorkStationTypeSetId).HasName("WorkStationTypeSet_pkey");

            entity
                .ToTable("WorkStationTypeSet", tb => tb.HasComment("站台类型配置"))
                .HasAnnotation("Npgsql:StorageParameter:fillfactor", "80");

            entity.Property(e => e.WorkStationTypeSetId)
                .HasMaxLength(100)
                .HasComment("唯一码")
                .HasColumnName("WorkStationTypeSetID");
            entity.Property(e => e.AgvTargetAddress)
                .HasMaxLength(100)
                .HasComment("Agv目标地点或区域");
            entity.Property(e => e.PostBydWmstimes)
                .HasComment("出库是1\n次上报还是2次上报(下拉选择3项，未设置，1次，2次1")
                .HasColumnName("PostBydWMSTimes");
            entity.Property(e => e.StationCode)
                .HasMaxLength(100)
                .HasComment("站点编号");
            entity.Property(e => e.Status).HasComment("状态（0无效，1有效）");
            entity.Property(e => e.WorkStationType)
                .HasMaxLength(100)
                .HasComment("工作站台类型（人工叉车翻包出库台/整箱拣配口/拆零拣配口/入库异常口/出库异常口/非生产领料口）");
        });
        modelBuilder.HasSequence("tasknumber")
            .HasMax(2000000000L)
            .IsCyclic();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
