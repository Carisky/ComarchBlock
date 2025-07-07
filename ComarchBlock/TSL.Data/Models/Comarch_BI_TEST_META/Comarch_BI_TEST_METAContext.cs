using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class Comarch_BI_TEST_METAContext : DbContext
{
    public Comarch_BI_TEST_METAContext(DbContextOptions<Comarch_BI_TEST_METAContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnalyticObject> AnalyticObjects { get; set; }

    public virtual DbSet<AnalyticObjectAttachInfo> AnalyticObjectAttachInfos { get; set; }

    public virtual DbSet<AnalyticObjectType> AnalyticObjectTypes { get; set; }

    public virtual DbSet<ApiService> ApiServices { get; set; }

    public virtual DbSet<ApplicationGroup> ApplicationGroups { get; set; }

    public virtual DbSet<ApplicationRight> ApplicationRights { get; set; }

    public virtual DbSet<ApplicationRightsTranslation> ApplicationRightsTranslations { get; set; }

    public virtual DbSet<ApplicationRole> ApplicationRoles { get; set; }

    public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

    public virtual DbSet<ApplicationUsersRole> ApplicationUsersRoles { get; set; }

    public virtual DbSet<ApplicationUsersTable> ApplicationUsersTables { get; set; }

    public virtual DbSet<Correction> Corrections { get; set; }

    public virtual DbSet<CorrectionFilter> CorrectionFilters { get; set; }

    public virtual DbSet<CorrectionMapping> CorrectionMappings { get; set; }

    public virtual DbSet<CorrectionMeasure> CorrectionMeasures { get; set; }

    public virtual DbSet<CorrectionRule> CorrectionRules { get; set; }

    public virtual DbSet<CorrectionRuleValueToReplace> CorrectionRuleValueToReplaces { get; set; }

    public virtual DbSet<CorrectionRulesType> CorrectionRulesTypes { get; set; }

    public virtual DbSet<CorrectionState> CorrectionStates { get; set; }

    public virtual DbSet<CorrectionType> CorrectionTypes { get; set; }

    public virtual DbSet<DataMiningConfiguration> DataMiningConfigurations { get; set; }

    public virtual DbSet<DataMiningModel> DataMiningModels { get; set; }

    public virtual DbSet<DataMiningModelViewParameter> DataMiningModelViewParameters { get; set; }

    public virtual DbSet<DataMiningParameter> DataMiningParameters { get; set; }

    public virtual DbSet<DataMiningParameterType> DataMiningParameterTypes { get; set; }

    public virtual DbSet<DataMiningStructure> DataMiningStructures { get; set; }

    public virtual DbSet<DataMiningTransaltion> DataMiningTransaltions { get; set; }

    public virtual DbSet<DataMiningViewSql> DataMiningViewSqls { get; set; }

    public virtual DbSet<DataType> DataTypes { get; set; }

    public virtual DbSet<DatabaseAccess> DatabaseAccesses { get; set; }

    public virtual DbSet<DatabaseAuthorizationType> DatabaseAuthorizationTypes { get; set; }

    public virtual DbSet<DatabaseName> DatabaseNames { get; set; }

    public virtual DbSet<DatabaseSchema> DatabaseSchemas { get; set; }

    public virtual DbSet<DatabaseType> DatabaseTypes { get; set; }

    public virtual DbSet<DbVersion> DbVersions { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DimensionFieldKind> DimensionFieldKinds { get; set; }

    public virtual DbSet<DimensionStructureType> DimensionStructureTypes { get; set; }

    public virtual DbSet<DimensionType> DimensionTypes { get; set; }

    public virtual DbSet<DynamicColumnNode> DynamicColumnNodes { get; set; }

    public virtual DbSet<EnumeratorValue> EnumeratorValues { get; set; }

    public virtual DbSet<EtlComponent> EtlComponents { get; set; }

    public virtual DbSet<EtlComponent1> EtlComponents1 { get; set; }

    public virtual DbSet<EtlNode> EtlNodes { get; set; }

    public virtual DbSet<EtlNode1> EtlNodes1 { get; set; }

    public virtual DbSet<EtlNodeType> EtlNodeTypes { get; set; }

    public virtual DbSet<EtlPackageConfiguration> EtlPackageConfigurations { get; set; }

    public virtual DbSet<EtlPackageConfigurationNode> EtlPackageConfigurationNodes { get; set; }

    public virtual DbSet<EtlParameter> EtlParameters { get; set; }

    public virtual DbSet<EtlParameterDataType> EtlParameterDataTypes { get; set; }

    public virtual DbSet<EtlParameterSet> EtlParameterSets { get; set; }

    public virtual DbSet<EtlParameterValue> EtlParameterValues { get; set; }

    public virtual DbSet<ExecutionGraph> ExecutionGraphs { get; set; }

    public virtual DbSet<ExecutionGraphNode> ExecutionGraphNodes { get; set; }

    public virtual DbSet<FactFieldKind> FactFieldKinds { get; set; }

    public virtual DbSet<Field> Fields { get; set; }

    public virtual DbSet<Field1> Fields1 { get; set; }

    public virtual DbSet<FieldLink> FieldLinks { get; set; }

    public virtual DbSet<FieldSettingsForUser> FieldSettingsForUsers { get; set; }

    public virtual DbSet<FillMode> FillModes { get; set; }

    public virtual DbSet<ForeignKeyDisplay> ForeignKeyDisplays { get; set; }

    public virtual DbSet<FtpConfiguration> FtpConfigurations { get; set; }

    public virtual DbSet<FtpConfigurationExpectedFile> FtpConfigurationExpectedFiles { get; set; }

    public virtual DbSet<FtpConfigurationLoadFilesType> FtpConfigurationLoadFilesTypes { get; set; }

    public virtual DbSet<FtpConfigurationType> FtpConfigurationTypes { get; set; }

    public virtual DbSet<HistoricalChange> HistoricalChanges { get; set; }

    public virtual DbSet<HistoricalChangesCollectionValue> HistoricalChangesCollectionValues { get; set; }

    public virtual DbSet<HistoricalChangesEntitesValue> HistoricalChangesEntitesValues { get; set; }

    public virtual DbSet<HistoricalChangesEntity> HistoricalChangesEntities { get; set; }

    public virtual DbSet<Index> Indexes { get; set; }

    public virtual DbSet<IndexField> IndexFields { get; set; }

    public virtual DbSet<IndexIncludedField> IndexIncludedFields { get; set; }

    public virtual DbSet<Input> Inputs { get; set; }

    public virtual DbSet<Key> Keys { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LogicalSource> LogicalSources { get; set; }

    public virtual DbSet<LogicalSource1> LogicalSources1 { get; set; }

    public virtual DbSet<MeasureObjectAttachInfo> MeasureObjectAttachInfos { get; set; }

    public virtual DbSet<MessageTranslation> MessageTranslations { get; set; }

    public virtual DbSet<NextHighVaue> NextHighVaues { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<PackageProcess> PackageProcesses { get; set; }

    public virtual DbSet<PhysicalSource> PhysicalSources { get; set; }

    public virtual DbSet<PhysicalSource1> PhysicalSources1 { get; set; }

    public virtual DbSet<PrimaryKey> PrimaryKeys { get; set; }

    public virtual DbSet<PrimaryKeyField> PrimaryKeyFields { get; set; }

    public virtual DbSet<Process> Processes { get; set; }

    public virtual DbSet<ProcessAuthorizationType> ProcessAuthorizationTypes { get; set; }

    public virtual DbSet<ProcessesKey> ProcessesKeys { get; set; }

    public virtual DbSet<RealTimeWarehouseSetting> RealTimeWarehouseSettings { get; set; }

    public virtual DbSet<Relation> Relations { get; set; }

    public virtual DbSet<Relation1> Relations1 { get; set; }

    public virtual DbSet<Server> Servers { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<SourceType> SourceTypes { get; set; }

    public virtual DbSet<StackColumnValue> StackColumnValues { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<Table1> Tables1 { get; set; }

    public virtual DbSet<TableGroup> TableGroups { get; set; }

    public virtual DbSet<TableLink> TableLinks { get; set; }

    public virtual DbSet<TableLink1> TableLinks1 { get; set; }

    public virtual DbSet<TableType> TableTypes { get; set; }

    public virtual DbSet<Target> Targets { get; set; }

    public virtual DbSet<TargetFktTable> TargetFktTables { get; set; }

    public virtual DbSet<ThresholdUnit> ThresholdUnits { get; set; }

    public virtual DbSet<ToolTipField> ToolTipFields { get; set; }

    public virtual DbSet<ToolTipTable> ToolTipTables { get; set; }

    public virtual DbSet<Version> Versions { get; set; }

    public virtual DbSet<WarehouseSchema> WarehouseSchemas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnalyticObject>(entity =>
        {
            entity.HasKey(e => e.AobId).HasName("PK_AnalyticObjects_AOB_ID");

            entity.Property(e => e.AobId).HasColumnName("AOB_ID");
            entity.Property(e => e.AobAotid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AOB_AOTID");
            entity.Property(e => e.AobImport).HasColumnName("AOB_Import");
            entity.Property(e => e.AobIsAvailable).HasColumnName("AOB_IsAvailable");
            entity.Property(e => e.AobIsImported).HasColumnName("AOB_IsImported");
            entity.Property(e => e.AobIsTranslationsSqlEnabled).HasColumnName("AOB_IsTranslationsSqlEnabled");
            entity.Property(e => e.AobLevels).HasColumnName("AOB_Levels");
            entity.Property(e => e.AobLsrcid).HasColumnName("AOB_LSRCID");
            entity.Property(e => e.AobName)
                .HasMaxLength(256)
                .HasColumnName("AOB_Name");
            entity.Property(e => e.AobNormName)
                .HasMaxLength(256)
                .HasColumnName("AOB_NormName");
            entity.Property(e => e.AobOrgId)
                .HasMaxLength(256)
                .HasColumnName("AOB_OrgID");
            entity.Property(e => e.AobRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("AOB_RowVersion");
            entity.Property(e => e.AobStructName)
                .HasMaxLength(256)
                .HasColumnName("AOB_StructName");
            entity.Property(e => e.AobTranslationsSql).HasColumnName("AOB_TranslationsSql");
            entity.Property(e => e.AobTsInsert)
                .HasColumnType("datetime")
                .HasColumnName("AOB_TsInsert");
            entity.Property(e => e.AobTsUpdate)
                .HasColumnType("datetime")
                .HasColumnName("AOB_TsUpdate");

            entity.HasOne(d => d.AobAot).WithMany(p => p.AnalyticObjects)
                .HasForeignKey(d => d.AobAotid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalyticObjects_AOB_AOTID__AnalyticObjectTypes_AOT_ID");

            entity.HasOne(d => d.AobLsrc).WithMany(p => p.AnalyticObjects)
                .HasForeignKey(d => d.AobLsrcid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalyticObjects_AOB_LSRCID__LogicalSources_LSRT_ID");
        });

        modelBuilder.Entity<AnalyticObjectAttachInfo>(entity =>
        {
            entity.HasKey(e => e.AoaiId).HasName("PK_AnalyticObjectAttachInfos_AOAI_ID");

            entity.Property(e => e.AoaiId).HasColumnName("AOAI_ID");
            entity.Property(e => e.AoaiAotid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AOAI_AOTID");
            entity.Property(e => e.AoaiAttachedToObjId)
                .HasMaxLength(600)
                .HasColumnName("AOAI_AttachedToObjID");
            entity.Property(e => e.AoaiAttachedToObjName)
                .HasMaxLength(600)
                .HasColumnName("AOAI_AttachedToObjName");
            entity.Property(e => e.AoaiData).HasColumnName("AOAI_Data");
            entity.Property(e => e.AoaiInfoKind)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("AOAI_InfoKind");
            entity.Property(e => e.AoaiIsAttached).HasColumnName("AOAI_IsAttached");
            entity.Property(e => e.AoaiIsVisible).HasColumnName("AOAI_IsVisible");
            entity.Property(e => e.AoaiObjId)
                .HasMaxLength(600)
                .HasColumnName("AOAI_ObjID");
            entity.Property(e => e.AoaiObjName)
                .HasMaxLength(600)
                .HasColumnName("AOAI_ObjName");
            entity.Property(e => e.AoaiParentId)
                .HasMaxLength(600)
                .HasColumnName("AOAI_ParentID");
            entity.Property(e => e.AoaiParentName)
                .HasMaxLength(600)
                .HasColumnName("AOAI_ParentName");
            entity.Property(e => e.AoaiTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("AOAI_TSInsert");
            entity.Property(e => e.AoaiTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("AOAI_TSUpdate");
        });

        modelBuilder.Entity<AnalyticObjectType>(entity =>
        {
            entity.HasKey(e => e.AotId).HasName("PK_AnalyticObjectTypes_AOT_ID");

            entity.Property(e => e.AotId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AOT_ID");
            entity.Property(e => e.AotName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AOT_Name");
        });

        modelBuilder.Entity<ApiService>(entity =>
        {
            entity.HasKey(e => e.ApsId).HasName("PK_ApiServices_APS_ID");

            entity.ToTable("ApiServices", "esv");

            entity.HasIndex(e => e.ApsGuid, "UQ_ApiServices_APS_GUID").IsUnique();

            entity.Property(e => e.ApsId).HasColumnName("APS_ID");
            entity.Property(e => e.ApsFullAddress)
                .HasMaxLength(100)
                .HasColumnName("APS_FullAddress");
            entity.Property(e => e.ApsGrpcPort).HasColumnName("APS_GrpcPort");
            entity.Property(e => e.ApsGuid)
                .HasMaxLength(255)
                .HasColumnName("APS_GUID");
            entity.Property(e => e.ApsIsDefault).HasColumnName("APS_IsDefault");
            entity.Property(e => e.ApsName)
                .HasMaxLength(50)
                .HasColumnName("APS_Name");
            entity.Property(e => e.ApsPort).HasColumnName("APS_Port");
            entity.Property(e => e.ApsProtocol)
                .HasMaxLength(10)
                .HasColumnName("APS_Protocol");
            entity.Property(e => e.ApsServerAddress)
                .HasMaxLength(50)
                .HasColumnName("APS_ServerAddress");
            entity.Property(e => e.ApsServiceType)
                .HasMaxLength(30)
                .HasColumnName("APS_ServiceType");
            entity.Property(e => e.ApsTsinsert).HasColumnName("APS_TSInsert");
            entity.Property(e => e.ApsUser)
                .HasMaxLength(50)
                .HasColumnName("APS_User");
        });

        modelBuilder.Entity<ApplicationGroup>(entity =>
        {
            entity.HasKey(e => e.GrpId).HasName("PK_ApplicationGroups_GRP_Id");

            entity.Property(e => e.GrpId).HasColumnName("GRP_Id");
            entity.Property(e => e.GrpName)
                .HasMaxLength(128)
                .HasColumnName("GRP_Name");
            entity.Property(e => e.GrpOwnerId).HasColumnName("GRP_OwnerId");

            entity.HasMany(d => d.AgrRoles).WithMany(p => p.AgrGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "ApplicationGroupsRole",
                    r => r.HasOne<ApplicationRole>().WithMany()
                        .HasForeignKey("AgrRoleId")
                        .HasConstraintName("FK_ApplicationGroupsRoles_AGR_RoleId__ApplicationRoles_ARL_Id"),
                    l => l.HasOne<ApplicationGroup>().WithMany()
                        .HasForeignKey("AgrGroupId")
                        .HasConstraintName("FK_ApplicationGroupsRoles_AGR_GroupId__ApplicationGroups_GRP_Id"),
                    j =>
                    {
                        j.HasKey("AgrGroupId", "AgrRoleId").HasName("PK_ApplicationGroupsRoles_AGR_GroupId_AGR_RoleId");
                        j.ToTable("ApplicationGroupsRoles");
                        j.IndexerProperty<int>("AgrGroupId").HasColumnName("AGR_GroupId");
                        j.IndexerProperty<int>("AgrRoleId").HasColumnName("AGR_RoleId");
                    });

            entity.HasMany(d => d.GruUsers).WithMany(p => p.GruGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "ApplicationGroupsUser",
                    r => r.HasOne<ApplicationUser>().WithMany()
                        .HasForeignKey("GruUserId")
                        .HasConstraintName("FK_GroupsUsers_GRU_UserId__ApplicationUsers_USR_Id"),
                    l => l.HasOne<ApplicationGroup>().WithMany()
                        .HasForeignKey("GruGroupId")
                        .HasConstraintName("FK_GroupsUsers_GRU_GroupId__ApplicationGroups_GRP_Id"),
                    j =>
                    {
                        j.HasKey("GruGroupId", "GruUserId").HasName("PK_GroupsUsers_GRU_GroupId_GRU_UserId");
                        j.ToTable("ApplicationGroupsUsers");
                        j.IndexerProperty<int>("GruGroupId").HasColumnName("GRU_GroupId");
                        j.IndexerProperty<int>("GruUserId").HasColumnName("GRU_UserId");
                    });
        });

        modelBuilder.Entity<ApplicationRight>(entity =>
        {
            entity.HasKey(e => e.AprId).HasName("PK_ApplicationRights_APR_Id");

            entity.Property(e => e.AprId)
                .ValueGeneratedNever()
                .HasColumnName("APR_Id");
            entity.Property(e => e.AprName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APR_Name");
        });

        modelBuilder.Entity<ApplicationRightsTranslation>(entity =>
        {
            entity.HasKey(e => e.ArtId).HasName("PK_ApplicationRolesTranslations_ART_Id");

            entity.Property(e => e.ArtId).HasColumnName("ART_Id");
            entity.Property(e => e.ArtLocaleId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ART_LocaleId");
            entity.Property(e => e.ArtRightId).HasColumnName("ART_RightId");
            entity.Property(e => e.ArtTranslation)
                .HasMaxLength(50)
                .HasColumnName("ART_Translation");

            entity.HasOne(d => d.ArtRight).WithMany(p => p.ApplicationRightsTranslations)
                .HasForeignKey(d => d.ArtRightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationRolesTranslations_ART_RightId__ApplicationRights_APR_Id");
        });

        modelBuilder.Entity<ApplicationRole>(entity =>
        {
            entity.HasKey(e => e.ArlId).HasName("PK_ApplicationRoles_ARL_Id");

            entity.Property(e => e.ArlId).HasColumnName("ARL_Id");
            entity.Property(e => e.ArlName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARL_Name");

            entity.HasMany(d => d.ArrRights).WithMany(p => p.ArrRoles)
                .UsingEntity<Dictionary<string, object>>(
                    "ApplicationRolesRight",
                    r => r.HasOne<ApplicationRight>().WithMany()
                        .HasForeignKey("ArrRightId")
                        .HasConstraintName("FK_ApplicationRolesRights_ARR_RightId__ApplicationRights_APR_Id"),
                    l => l.HasOne<ApplicationRole>().WithMany()
                        .HasForeignKey("ArrRoleId")
                        .HasConstraintName("FK_ApplicationRolesRights_ARR_RoleId__ApplicationRoles_ARL_Id"),
                    j =>
                    {
                        j.HasKey("ArrRoleId", "ArrRightId").HasName("PK_ApplicationRolesRights_ARR_RoleId_ARR_RightId");
                        j.ToTable("ApplicationRolesRights");
                        j.IndexerProperty<int>("ArrRoleId").HasColumnName("ARR_RoleId");
                        j.IndexerProperty<int>("ArrRightId").HasColumnName("ARR_RightId");
                    });
        });

        modelBuilder.Entity<ApplicationUser>(entity =>
        {
            entity.HasKey(e => e.UsrId).HasName("PK_Users_USR_Id");

            entity.Property(e => e.UsrId).HasColumnName("USR_Id");
            entity.Property(e => e.RowVer).HasDefaultValue(1);
            entity.Property(e => e.UsrEmail)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("USR_Email");
            entity.Property(e => e.UsrIsDeleted).HasColumnName("USR_IsDeleted");
            entity.Property(e => e.UsrIsDomain).HasColumnName("USR_IsDomain");
            entity.Property(e => e.UsrLastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("USR_LastUpdate");
            entity.Property(e => e.UsrName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("USR_Name");
            entity.Property(e => e.UsrPasswordHash)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("USR_PasswordHash");
            entity.Property(e => e.UsrSid)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USR_SID");
            entity.Property(e => e.UsrSurname)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("USR_Surname");
            entity.Property(e => e.UsrWinAccount)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("USR_WinAccount");
        });

        modelBuilder.Entity<ApplicationUsersRole>(entity =>
        {
            entity.HasKey(e => new { e.AurUserId, e.AurRoleId }).HasName("PK_ApplicationUsersRoles_AUR_UserId_AUR_RoleId");

            entity.Property(e => e.AurUserId).HasColumnName("AUR_UserId");
            entity.Property(e => e.AurRoleId).HasColumnName("AUR_RoleId");
            entity.Property(e => e.AurDateFrom)
                .HasColumnType("datetime")
                .HasColumnName("AUR_DateFrom");
            entity.Property(e => e.AurDateTo)
                .HasColumnType("datetime")
                .HasColumnName("AUR_DateTo");

            entity.HasOne(d => d.AurRole).WithMany(p => p.ApplicationUsersRoles)
                .HasForeignKey(d => d.AurRoleId)
                .HasConstraintName("FK_ApplicationUsersRoles_AUR_RoleId__ApplicationRoles_ARL_Id");

            entity.HasOne(d => d.AurUser).WithMany(p => p.ApplicationUsersRoles)
                .HasForeignKey(d => d.AurUserId)
                .HasConstraintName("FK_ApplicationUsersRoles_AUR_UserId__ApplicationUsers_USR_Id");
        });

        modelBuilder.Entity<ApplicationUsersTable>(entity =>
        {
            entity.HasKey(e => e.AutId).HasName("PK_ApplicationUsersTables_AUT_ID");

            entity.HasIndex(e => new { e.AutTblid, e.AutUsrid }, "UQ_ApplicationUsersTables_AUT_TBLID_AUT_USRID").IsUnique();

            entity.Property(e => e.AutId).HasColumnName("AUT_ID");
            entity.Property(e => e.AutReadOnly).HasColumnName("AUT_ReadOnly");
            entity.Property(e => e.AutTblid).HasColumnName("AUT_TBLID");
            entity.Property(e => e.AutUsrid).HasColumnName("AUT_USRID");

            entity.HasOne(d => d.AutTbl).WithMany(p => p.ApplicationUsersTables)
                .HasForeignKey(d => d.AutTblid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationUsersTables_AUT_TBLID__Tables_TBL_ID");

            entity.HasOne(d => d.AutUsr).WithMany(p => p.ApplicationUsersTables)
                .HasForeignKey(d => d.AutUsrid)
                .HasConstraintName("FK_ApplicationUsersTables_AUT_USRID__ApplicationUsers_USR_Id");
        });

        modelBuilder.Entity<Correction>(entity =>
        {
            entity.HasKey(e => e.CorId).HasName("PK_Corrections_COR_ID");

            entity.Property(e => e.CorId).HasColumnName("COR_ID");
            entity.Property(e => e.CorCreator)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COR_Creator");
            entity.Property(e => e.CorCstid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COR_CSTID");
            entity.Property(e => e.CorCtpid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COR_CTPID");
            entity.Property(e => e.CorDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("COR_Description");
            entity.Property(e => e.CorFrom)
                .HasColumnType("datetime")
                .HasColumnName("COR_From");
            entity.Property(e => e.CorIsGenerated).HasColumnName("COR_IsGenerated");
            entity.Property(e => e.CorName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("COR_Name");
            entity.Property(e => e.CorRequester)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COR_Requester");
            entity.Property(e => e.CorRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("COR_RowVersion");
            entity.Property(e => e.CorTblid).HasColumnName("COR_TBLID");
            entity.Property(e => e.CorTo)
                .HasColumnType("datetime")
                .HasColumnName("COR_To");
            entity.Property(e => e.CorTsInsert)
                .HasColumnType("datetime")
                .HasColumnName("COR_TsInsert");
            entity.Property(e => e.CorTsUpdate)
                .HasColumnType("datetime")
                .HasColumnName("COR_TsUpdate");
            entity.Property(e => e.CorUpdater)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COR_Updater");

            entity.HasOne(d => d.CorCst).WithMany(p => p.Corrections)
                .HasForeignKey(d => d.CorCstid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Corrections_COR_CSTID__CorrectionStates_CST_ID");

            entity.HasOne(d => d.CorCtp).WithMany(p => p.Corrections)
                .HasForeignKey(d => d.CorCtpid)
                .HasConstraintName("FK_Corrections_COR_CTPID__CorrectionTypes_CTP_ID");

            entity.HasOne(d => d.CorTbl).WithMany(p => p.Corrections)
                .HasForeignKey(d => d.CorTblid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Corrections_COR_TBLID__Tables_TBL_ID");
        });

        modelBuilder.Entity<CorrectionFilter>(entity =>
        {
            entity.HasKey(e => e.CfiId).HasName("PK_CorrectionFilters_CFI_ID");

            entity.Property(e => e.CfiId).HasColumnName("CFI_ID");
            entity.Property(e => e.CfiCorid).HasColumnName("CFI_CORID");
            entity.Property(e => e.CfiDfldid).HasColumnName("CFI_DFLDID");
            entity.Property(e => e.CfiFldid).HasColumnName("CFI_FLDID");
            entity.Property(e => e.CfiIsEnabled).HasColumnName("CFI_IsEnabled");
            entity.Property(e => e.CfiRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("CFI_RowVersion");
            entity.Property(e => e.CfiTsInsert)
                .HasColumnType("datetime")
                .HasColumnName("CFI_TsInsert");
            entity.Property(e => e.CfiTsUpdate)
                .HasColumnType("datetime")
                .HasColumnName("CFI_TsUpdate");
            entity.Property(e => e.CfiValue)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CFI_Value");

            entity.HasOne(d => d.CfiCor).WithMany(p => p.CorrectionFilters)
                .HasForeignKey(d => d.CfiCorid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorrectionFilters_CFT_CORID__Corrections_COR_ID");

            entity.HasOne(d => d.CfiDfld).WithMany(p => p.CorrectionFilterCfiDflds)
                .HasForeignKey(d => d.CfiDfldid)
                .HasConstraintName("FK_CorrectionFilters_CFI_DFLDID__Fields_FLD_ID");

            entity.HasOne(d => d.CfiFld).WithMany(p => p.CorrectionFilterCfiFlds)
                .HasForeignKey(d => d.CfiFldid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorrectionFilters_CFI_FLDID__Fields_FLD_ID");
        });

        modelBuilder.Entity<CorrectionMapping>(entity =>
        {
            entity.HasKey(e => e.CmaId).HasName("PK_CorrectionMappings_CMA_ID");

            entity.Property(e => e.CmaId).HasColumnName("CMA_ID");
            entity.Property(e => e.CmaCorid).HasColumnName("CMA_CORID");
            entity.Property(e => e.CmaDfldid).HasColumnName("CMA_DFLDID");
            entity.Property(e => e.CmaFldid).HasColumnName("CMA_FLDID");
            entity.Property(e => e.CmaIsEnabled).HasColumnName("CMA_IsEnabled");
            entity.Property(e => e.CmaNewValue)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CMA_NewValue");
            entity.Property(e => e.CmaOldValue)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CMA_OldValue");
            entity.Property(e => e.CmaRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("CMA_RowVersion");
            entity.Property(e => e.CmaTsInsert)
                .HasColumnType("datetime")
                .HasColumnName("CMA_TsInsert");
            entity.Property(e => e.CmaTsUpdate)
                .HasColumnType("datetime")
                .HasColumnName("CMA_TsUpdate");

            entity.HasOne(d => d.CmaCor).WithMany(p => p.CorrectionMappings)
                .HasForeignKey(d => d.CmaCorid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorrectionMappings_CMA_CORID__Corrections_COR_ID");

            entity.HasOne(d => d.CmaDfld).WithMany(p => p.CorrectionMappingCmaDflds)
                .HasForeignKey(d => d.CmaDfldid)
                .HasConstraintName("FK_CorrectionMappings_CMA_DFLDID__Fields_FLD_ID");

            entity.HasOne(d => d.CmaFld).WithMany(p => p.CorrectionMappingCmaFlds)
                .HasForeignKey(d => d.CmaFldid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorrectionMappings_CMA_FLDID__Fields_FLD_ID");
        });

        modelBuilder.Entity<CorrectionMeasure>(entity =>
        {
            entity.HasKey(e => e.CmeId).HasName("PK_CorrectionMeasures_CME_ID");

            entity.Property(e => e.CmeId).HasColumnName("CME_ID");
            entity.Property(e => e.CmeCorid).HasColumnName("CME_CORID");
            entity.Property(e => e.CmeExpression)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CME_Expression");
            entity.Property(e => e.CmeFldid).HasColumnName("CME_FLDID");
            entity.Property(e => e.CmeIsEnabled).HasColumnName("CME_IsEnabled");
            entity.Property(e => e.CmeRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("CME_RowVersion");
            entity.Property(e => e.CmeTsInsert)
                .HasColumnType("datetime")
                .HasColumnName("CME_TsInsert");
            entity.Property(e => e.CmeTsUpdate)
                .HasColumnType("datetime")
                .HasColumnName("CME_TsUpdate");

            entity.HasOne(d => d.CmeCor).WithMany(p => p.CorrectionMeasures)
                .HasForeignKey(d => d.CmeCorid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorrectionMeasures_CME_CORID__Corrections_COR_ID");

            entity.HasOne(d => d.CmeFld).WithMany(p => p.CorrectionMeasures)
                .HasForeignKey(d => d.CmeFldid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorrectionMeasures_CME_FLDID__Fields_FLD_ID");
        });

        modelBuilder.Entity<CorrectionRule>(entity =>
        {
            entity.HasKey(e => e.CrrId).HasName("PK_CorrectionRules_CRR_ID");

            entity.Property(e => e.CrrId).HasColumnName("CRR_ID");
            entity.Property(e => e.CrrCrrtid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRR_CRRTID");
            entity.Property(e => e.CrrDateFrom)
                .HasColumnType("datetime")
                .HasColumnName("CRR_DateFrom");
            entity.Property(e => e.CrrDateTo)
                .HasColumnType("datetime")
                .HasColumnName("CRR_DateTo");
            entity.Property(e => e.CrrEnabled).HasColumnName("CRR_Enabled");
            entity.Property(e => e.CrrFieldId).HasColumnName("CRR_FieldID");
            entity.Property(e => e.CrrRuleDate)
                .HasColumnType("datetime")
                .HasColumnName("CRR_RuleDate");
            entity.Property(e => e.CrrRuleDisabledDate)
                .HasColumnType("datetime")
                .HasColumnName("CRR_RuleDisabledDate");
            entity.Property(e => e.CrrUsrid).HasColumnName("CRR_USRID");
            entity.Property(e => e.CrrValueAfter)
                .HasMaxLength(250)
                .HasColumnName("CRR_ValueAfter");
            entity.Property(e => e.CrrWhere).HasColumnName("CRR_Where");

            entity.HasOne(d => d.CrrField).WithMany(p => p.CorrectionRules)
                .HasForeignKey(d => d.CrrFieldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorrectionRules_CRR_FieldID__Fields_FLD_ID");

            entity.HasOne(d => d.CrrUsr).WithMany(p => p.CorrectionRules)
                .HasForeignKey(d => d.CrrUsrid)
                .HasConstraintName("FK_CorrectionRules_CRR_USRID__ApplicationUsers_USR_Id");
        });

        modelBuilder.Entity<CorrectionRuleValueToReplace>(entity =>
        {
            entity.HasKey(e => e.CrvId).HasName("PK_CorrectionRuleValueToReplace_CRV_ID");

            entity.ToTable("CorrectionRuleValueToReplace");

            entity.Property(e => e.CrvId).HasColumnName("CRV_ID");
            entity.Property(e => e.CrvCrrid).HasColumnName("CRV_CRRID");
            entity.Property(e => e.CrvDirtyOrgId)
                .HasMaxLength(250)
                .HasColumnName("CRV_DirtyOrgID");
            entity.Property(e => e.CrvDtdgid)
                .HasMaxLength(25)
                .HasColumnName("CRV_DTDGID");
            entity.Property(e => e.CrvEnabled).HasColumnName("CRV_Enabled");
            entity.Property(e => e.CrvValueBefore)
                .HasMaxLength(250)
                .HasColumnName("CRV_ValueBefore");

            entity.HasOne(d => d.CrvCrr).WithMany(p => p.CorrectionRuleValueToReplaces)
                .HasForeignKey(d => d.CrvCrrid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorrectionRuleValueToReplace_CRV_CRRID__CorrectionRules_CRR_ID");
        });

        modelBuilder.Entity<CorrectionRulesType>(entity =>
        {
            entity.HasKey(e => e.CrrtId).HasName("PK_CorrectionRulesTypes_CRRT_ID");

            entity.Property(e => e.CrrtId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRRT_ID");
            entity.Property(e => e.CrrtName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CRRT_Name");
        });

        modelBuilder.Entity<CorrectionState>(entity =>
        {
            entity.HasKey(e => e.CstId).HasName("PK_CorrectionStates_CST_ID");

            entity.Property(e => e.CstId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CST_ID");
            entity.Property(e => e.CstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CST_Name");
        });

        modelBuilder.Entity<CorrectionType>(entity =>
        {
            entity.HasKey(e => e.CtpId).HasName("PK_CorrectionTypes_CTP_ID");

            entity.Property(e => e.CtpId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CTP_ID");
            entity.Property(e => e.CtpName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTP_Name");
        });

        modelBuilder.Entity<DataMiningConfiguration>(entity =>
        {
            entity.HasKey(e => e.DmcId).HasName("PK_DataMiningConfiguration_DMC_ID");

            entity.ToTable("DataMiningConfiguration");

            entity.Property(e => e.DmcId).HasColumnName("DMC_ID");
            entity.Property(e => e.DmcDescription).HasColumnName("DMC_Description");
            entity.Property(e => e.DmcDmmid).HasColumnName("DMC_DMMID");
            entity.Property(e => e.DmcIsActive).HasColumnName("DMC_IsActive");
            entity.Property(e => e.DmcName)
                .HasMaxLength(100)
                .HasColumnName("DMC_Name");

            entity.HasOne(d => d.DmcDmm).WithMany(p => p.DataMiningConfigurations)
                .HasForeignKey(d => d.DmcDmmid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataMiningConfiguration_DMC_DMMID__DataMiningModel_DMM_ID");
        });

        modelBuilder.Entity<DataMiningModel>(entity =>
        {
            entity.HasKey(e => e.DmmId).HasName("PK_DataMiningModel_DMM_ID");

            entity.ToTable("DataMiningModel");

            entity.HasIndex(e => e.DmmName, "UQ_DataMiningModel_DMM_Name").IsUnique();

            entity.Property(e => e.DmmId).HasColumnName("DMM_ID");
            entity.Property(e => e.DmmAlgorithmName)
                .HasMaxLength(255)
                .HasColumnName("DMM_AlgorithmName");
            entity.Property(e => e.DmmDescription).HasColumnName("DMM_Description");
            entity.Property(e => e.DmmDmsid).HasColumnName("DMM_DMSID");
            entity.Property(e => e.DmmName)
                .HasMaxLength(100)
                .HasColumnName("DMM_Name");

            entity.HasOne(d => d.DmmDms).WithMany(p => p.DataMiningModels)
                .HasForeignKey(d => d.DmmDmsid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataMiningModel_DMM_DMSID__DataMiningStructure_DMS_ID");
        });

        modelBuilder.Entity<DataMiningModelViewParameter>(entity =>
        {
            entity.HasKey(e => e.DmmvpId).HasName("PK_DataMiningModelViewParameter_DMMVP_ID");

            entity.ToTable("DataMiningModelViewParameter");

            entity.Property(e => e.DmmvpId).HasColumnName("DMMVP_ID");
            entity.Property(e => e.DmmvpDatid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DMMVP_DATID");
            entity.Property(e => e.DmmvpDefaultValue).HasColumnName("DMMVP_DefaultValue");
            entity.Property(e => e.DmmvpDescription).HasColumnName("DMMVP_Description");
            entity.Property(e => e.DmmvpDmmname)
                .HasMaxLength(100)
                .HasColumnName("DMMVP_DMMName");
            entity.Property(e => e.DmmvpFriendlyName)
                .HasMaxLength(100)
                .HasColumnName("DMMVP_FriendlyName");
            entity.Property(e => e.DmmvpName)
                .HasMaxLength(100)
                .HasColumnName("DMMVP_Name");
            entity.Property(e => e.DmmvpValue).HasColumnName("DMMVP_Value");
        });

        modelBuilder.Entity<DataMiningParameter>(entity =>
        {
            entity.HasKey(e => e.DmpId).HasName("PK_DataMiningParameter_DMP_ID");

            entity.ToTable("DataMiningParameter");

            entity.Property(e => e.DmpId).HasColumnName("DMP_ID");
            entity.Property(e => e.DmpDatid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DMP_DATID");
            entity.Property(e => e.DmpDecription).HasColumnName("DMP_Decription");
            entity.Property(e => e.DmpDefaultValue).HasColumnName("DMP_DefaultValue");
            entity.Property(e => e.DmpDmcid).HasColumnName("DMP_DMCID");
            entity.Property(e => e.DmpDmptid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DMP_DMPTID");
            entity.Property(e => e.DmpFriendlyName)
                .HasMaxLength(100)
                .HasColumnName("DMP_FriendlyName");
            entity.Property(e => e.DmpName)
                .HasMaxLength(100)
                .HasColumnName("DMP_Name");
            entity.Property(e => e.DmpOperator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DMP_Operator");
            entity.Property(e => e.DmpValue).HasColumnName("DMP_Value");

            entity.HasOne(d => d.DmpDat).WithMany(p => p.DataMiningParameters)
                .HasForeignKey(d => d.DmpDatid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataMiningParameter_DMP_DATID__DataTypes_DAT_ID");

            entity.HasOne(d => d.DmpDmc).WithMany(p => p.DataMiningParameters)
                .HasForeignKey(d => d.DmpDmcid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataMiningParameter_DMP_DMCID__DataMiningConfiguration_DMC_ID");

            entity.HasOne(d => d.DmpDmpt).WithMany(p => p.DataMiningParameters)
                .HasForeignKey(d => d.DmpDmptid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataMiningParameter_DMP_DMPTID__DataMiningParameterType_DMPT_ID");
        });

        modelBuilder.Entity<DataMiningParameterType>(entity =>
        {
            entity.HasKey(e => e.DmptId).HasName("PK_DataMiningParameterType_DMPT_ID");

            entity.ToTable("DataMiningParameterType");

            entity.Property(e => e.DmptId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DMPT_ID");
            entity.Property(e => e.DmptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DMPT_Name");
        });

        modelBuilder.Entity<DataMiningStructure>(entity =>
        {
            entity.HasKey(e => e.DmsId).HasName("PK_DataMiningStructure_DMS_ID");

            entity.ToTable("DataMiningStructure");

            entity.Property(e => e.DmsId).HasColumnName("DMS_ID");
            entity.Property(e => e.DmsDescription).HasColumnName("DMS_Description");
            entity.Property(e => e.DmsName)
                .HasMaxLength(100)
                .HasColumnName("DMS_Name");
        });

        modelBuilder.Entity<DataMiningTransaltion>(entity =>
        {
            entity.HasKey(e => e.DmtId).HasName("PK_DataMiningTransaltions_DMT_ID");

            entity.Property(e => e.DmtId).HasColumnName("DMT_ID");
            entity.Property(e => e.DmtCollationName)
                .HasMaxLength(5)
                .HasColumnName("DMT_Collation_Name");
            entity.Property(e => e.DmtDescriptionTranslated).HasColumnName("DMT_Description_Translated");
            entity.Property(e => e.DmtFriendlyNameTranslated)
                .HasMaxLength(100)
                .HasColumnName("DMT_Friendly_Name_Translated");
            entity.Property(e => e.DmtModelName)
                .HasMaxLength(100)
                .HasColumnName("DMT_Model_Name");
            entity.Property(e => e.DmtName)
                .HasMaxLength(100)
                .HasColumnName("DMT_Name");
            entity.Property(e => e.DmtObjectType)
                .HasMaxLength(100)
                .HasColumnName("DMT_Object_Type");
            entity.Property(e => e.DmtStructureName)
                .HasMaxLength(100)
                .HasColumnName("DMT_Structure_Name");
        });

        modelBuilder.Entity<DataMiningViewSql>(entity =>
        {
            entity.HasKey(e => e.DmvsId).HasName("PK_DataMiningViewSql_DMVS_ID");

            entity.ToTable("DataMiningViewSql");

            entity.Property(e => e.DmvsId).HasColumnName("DMVS_ID");
            entity.Property(e => e.DmvsDefaultSqlStatement).HasColumnName("DMVS_DefaultSqlStatement");
            entity.Property(e => e.DmvsDescription).HasColumnName("DMVS_Description");
            entity.Property(e => e.DmvsDmmname)
                .HasMaxLength(100)
                .HasColumnName("DMVS_DMMName");
            entity.Property(e => e.DmvsName)
                .HasMaxLength(100)
                .HasColumnName("DMVS_Name");
            entity.Property(e => e.DmvsSqlStatement).HasColumnName("DMVS_SqlStatement");
        });

        modelBuilder.Entity<DataType>(entity =>
        {
            entity.HasKey(e => e.DatId).HasName("PK_DataTypes_DAT_ID");

            entity.Property(e => e.DatId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DAT_ID");
            entity.Property(e => e.DatName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DAT_Name");
        });

        modelBuilder.Entity<DatabaseAccess>(entity =>
        {
            entity.HasKey(e => e.DbaId).HasName("PK_DatabaseAccess_DBA_ID");

            entity.ToTable("DatabaseAccess");

            entity.HasIndex(e => e.DbaDbtid, "UQ_DatabaseAccess_DBA_DBTID").IsUnique();

            entity.Property(e => e.DbaId).HasColumnName("DBA_ID");
            entity.Property(e => e.DbaDatabaseName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBA_DatabaseName");
            entity.Property(e => e.DbaDatid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DBA_DATID");
            entity.Property(e => e.DbaDbtid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DBA_DBTID");
            entity.Property(e => e.DbaServerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBA_ServerName");
            entity.Property(e => e.DbaUserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBA_UserName");
            entity.Property(e => e.DbaUserPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBA_UserPassword");

            entity.HasOne(d => d.DbaDat).WithMany(p => p.DatabaseAccesses)
                .HasForeignKey(d => d.DbaDatid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DatabaseAccess_DBA_DATID__DatabaseAuthorizationType_DAT_ID");

            entity.HasOne(d => d.DbaDbt).WithOne(p => p.DatabaseAccess)
                .HasForeignKey<DatabaseAccess>(d => d.DbaDbtid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DatabaseAccess_DBA_DBTID__DatabaseType_DBT_ID");
        });

        modelBuilder.Entity<DatabaseAuthorizationType>(entity =>
        {
            entity.HasKey(e => e.DatId).HasName("PK_DatabaseAuthorizationType_DAT_ID");

            entity.ToTable("DatabaseAuthorizationType");

            entity.Property(e => e.DatId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DAT_ID");
            entity.Property(e => e.DatName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DAT_Name");
        });

        modelBuilder.Entity<DatabaseName>(entity =>
        {
            entity.HasKey(e => e.DbnId).HasName("PK_DatabaseName_DBN_ID");

            entity.ToTable("DatabaseName", "de");

            entity.Property(e => e.DbnId).HasColumnName("DBN_ID");
            entity.Property(e => e.DbnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBN_Name");
            entity.Property(e => e.DbnSrvid).HasColumnName("DBN_SRVID");

            entity.HasOne(d => d.DbnSrv).WithMany(p => p.DatabaseNames)
                .HasForeignKey(d => d.DbnSrvid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DatabaseName_DBN_SRVID__Server_SRV_ID");
        });

        modelBuilder.Entity<DatabaseSchema>(entity =>
        {
            entity.HasKey(e => e.DbsId).HasName("PK_DatabaseSchema_DBS_ID");

            entity.ToTable("DatabaseSchema", "de");

            entity.Property(e => e.DbsId).HasColumnName("DBS_ID");
            entity.Property(e => e.DbsDbnid).HasColumnName("DBS_DBNID");
            entity.Property(e => e.DbsSchema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBS_Schema");

            entity.HasOne(d => d.DbsDbn).WithMany(p => p.DatabaseSchemas)
                .HasForeignKey(d => d.DbsDbnid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DatabaseSchema_DBS_DBNID__DatabaseName_DBN_ID");
        });

        modelBuilder.Entity<DatabaseType>(entity =>
        {
            entity.HasKey(e => e.DbtId).HasName("PK_DatabaseType_DBT_ID");

            entity.ToTable("DatabaseType");

            entity.Property(e => e.DbtId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DBT_ID");
            entity.Property(e => e.DbtName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DBT_Name");
        });

        modelBuilder.Entity<DbVersion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DbVersion", "meta");

            entity.Property(e => e.PatchCreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PatchExecutionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Release)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("0.0.0.0");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepId).HasName("PK_Departments_DEP_ID");

            entity.Property(e => e.DepId).HasColumnName("DEP_ID");
            entity.Property(e => e.DepAdministratorEmail)
                .HasMaxLength(50)
                .HasColumnName("DEP_AdministratorEmail");
            entity.Property(e => e.DepAdministratorName)
                .HasMaxLength(25)
                .HasColumnName("DEP_AdministratorName");
            entity.Property(e => e.DepDatabaseLogin)
                .HasMaxLength(50)
                .HasColumnName("DEP_DatabaseLogin");
            entity.Property(e => e.DepIntegratedLogin).HasColumnName("DEP_IntegratedLogin");
            entity.Property(e => e.DepIsCentral).HasColumnName("DEP_IsCentral");
            entity.Property(e => e.DepLogDatabaseName)
                .HasMaxLength(100)
                .HasColumnName("DEP_LogDatabaseName");
            entity.Property(e => e.DepMetaDatabaseName)
                .HasMaxLength(100)
                .HasColumnName("DEP_MetaDatabaseName");
            entity.Property(e => e.DepName)
                .HasMaxLength(50)
                .HasColumnName("DEP_Name");
            entity.Property(e => e.DepPassword)
                .HasMaxLength(20)
                .HasColumnName("DEP_Password");
            entity.Property(e => e.DepRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("DEP_RowVersion");
            entity.Property(e => e.DepServerName)
                .HasMaxLength(100)
                .HasColumnName("DEP_ServerName");
            entity.Property(e => e.DepTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("DEP_TSInsert");
            entity.Property(e => e.DepTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("DEP_TSUpdate");
            entity.Property(e => e.DepWarehouseDatabaseName)
                .HasMaxLength(100)
                .HasColumnName("DEP_WarehouseDatabaseName");
        });

        modelBuilder.Entity<DimensionFieldKind>(entity =>
        {
            entity.HasKey(e => e.DfkId).HasName("PK_DimensionFieldKinds_DFK_ID");

            entity.Property(e => e.DfkId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DFK_ID");
            entity.Property(e => e.DfkName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DFK_Name");
        });

        modelBuilder.Entity<DimensionStructureType>(entity =>
        {
            entity.HasKey(e => e.DstId).HasName("PK_DimensionStructureTypes_DST_ID");

            entity.Property(e => e.DstId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DST_ID");
            entity.Property(e => e.DstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DST_Name");
        });

        modelBuilder.Entity<DimensionType>(entity =>
        {
            entity.HasKey(e => e.DitId).HasName("PK_DimensionTypes_DIT_ID");

            entity.Property(e => e.DitId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DIT_ID");
            entity.Property(e => e.DitName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIT_Name");
        });

        modelBuilder.Entity<DynamicColumnNode>(entity =>
        {
            entity.HasKey(e => e.DcnId).HasName("PK_DynamicColumnNodes_DCN_ID");

            entity.Property(e => e.DcnId).HasColumnName("DCN_ID");
            entity.Property(e => e.DcnAobid).HasColumnName("DCN_AOBID");
            entity.Property(e => e.DcnAotid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DCN_AOTID");
            entity.Property(e => e.DcnImport).HasColumnName("DCN_Import");
            entity.Property(e => e.DcnIsImported).HasColumnName("DCN_IsImported");
            entity.Property(e => e.DcnName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DCN_Name");
            entity.Property(e => e.DcnOlapParentObjId)
                .HasMaxLength(256)
                .HasColumnName("DCN_OlapParentObjID");
            entity.Property(e => e.DcnOlapParentObjType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("DCN_OlapParentObjType");
            entity.Property(e => e.DcnTblid).HasColumnName("DCN_TBLID");

            entity.HasOne(d => d.DcnAob).WithMany(p => p.DynamicColumnNodes)
                .HasForeignKey(d => d.DcnAobid)
                .HasConstraintName("FK_DynamicColumnNodes_DCN_AOBID__AnalyticObjects_AOB_ID");

            entity.HasOne(d => d.DcnAot).WithMany(p => p.DynamicColumnNodes)
                .HasForeignKey(d => d.DcnAotid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DynamicColumnNodes_DCN_AOTID__AnalyticObjectTypes_AOT_ID");

            entity.HasOne(d => d.DcnTbl).WithMany(p => p.DynamicColumnNodes)
                .HasForeignKey(d => d.DcnTblid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DynamicColumnNodes_DCN_TBLID__Tables_TBL_ID");
        });

        modelBuilder.Entity<EnumeratorValue>(entity =>
        {
            entity.HasKey(e => e.EnumId).HasName("PK_EnumeratorValues_ENUM_ID");

            entity.Property(e => e.EnumId).HasColumnName("ENUM_ID");
            entity.Property(e => e.EnumEnumeratorName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ENUM_EnumeratorName");
            entity.Property(e => e.EnumValue)
                .HasMaxLength(500)
                .HasColumnName("ENUM_Value");
        });

        modelBuilder.Entity<EtlComponent>(entity =>
        {
            entity.HasKey(e => e.EtlcId).HasName("PK_EtlComponents_ETLC_ID");

            entity.Property(e => e.EtlcId).HasColumnName("ETLC_ID");
            entity.Property(e => e.EtlcConfigurationSupported).HasColumnName("ETLC_ConfigurationSupported");
            entity.Property(e => e.EtlcDescription)
                .HasMaxLength(500)
                .HasColumnName("ETLC_Description");
            entity.Property(e => e.EtlcEctid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ETLC_ECTID");
            entity.Property(e => e.EtlcExecInSourceDb).HasColumnName("ETLC_ExecInSourceDb");
            entity.Property(e => e.EtlcJsonFilePath)
                .HasMaxLength(255)
                .HasColumnName("ETLC_JsonFilePath");
            entity.Property(e => e.EtlcMainUrl)
                .HasMaxLength(500)
                .HasColumnName("ETLC_MainUrl");
            entity.Property(e => e.EtlcName)
                .HasMaxLength(50)
                .HasColumnName("ETLC_Name");
            entity.Property(e => e.EtlcPsrcid).HasColumnName("ETLC_PSRCID");
            entity.Property(e => e.EtlcQueryUrlExpression)
                .HasMaxLength(500)
                .HasColumnName("ETLC_QueryUrlExpression");
            entity.Property(e => e.EtlcRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ETLC_RowVersion");
            entity.Property(e => e.EtlcSchemaName)
                .HasMaxLength(255)
                .HasColumnName("ETLC_SchemaName");
            entity.Property(e => e.EtlcSqlCommandText).HasColumnName("ETLC_SqlCommandText");
            entity.Property(e => e.EtlcSqlCommandType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ETLC_SqlCommandType");
            entity.Property(e => e.EtlcTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("ETLC_TSInsert");
            entity.Property(e => e.EtlcTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("ETLC_TSUpdate");
            entity.Property(e => e.EtlcUseRest).HasColumnName("ETLC_UseRest");
            entity.Property(e => e.EtlcWritebackPsrcid).HasColumnName("ETLC_WritebackPSRCID");

            entity.HasOne(d => d.EtlcPsrc).WithMany(p => p.EtlComponentEtlcPsrcs)
                .HasForeignKey(d => d.EtlcPsrcid)
                .HasConstraintName("FK_EtlComponents_ETLC_PSRCID__PhysicalSources_PSRC_ID");

            entity.HasOne(d => d.EtlcWritebackPsrc).WithMany(p => p.EtlComponentEtlcWritebackPsrcs)
                .HasForeignKey(d => d.EtlcWritebackPsrcid)
                .HasConstraintName("FK_EtlComponents_ETLC_WritebackPSRCID__PhysicalSources_PSRC_ID");
        });

        modelBuilder.Entity<EtlComponent1>(entity =>
        {
            entity.HasKey(e => e.MecId).HasName("PK_EtlComponents_MEC_ID");

            entity.ToTable("EtlComponents", "migrate");

            entity.Property(e => e.MecId).HasColumnName("MEC_ID");
            entity.Property(e => e.MecAction)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("MEC_Action");
            entity.Property(e => e.MecEcid).HasColumnName("MEC_ECID");
            entity.Property(e => e.MecIsMigrated).HasColumnName("MEC_IsMigrated");
            entity.Property(e => e.MecModifiedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MEC_ModifiedBy");
            entity.Property(e => e.MecName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MEC_Name");
            entity.Property(e => e.MecNameOld)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MEC_NameOld");
            entity.Property(e => e.MecTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("MEC_TSInsert");
            entity.Property(e => e.MecTsmigrate)
                .HasColumnType("datetime")
                .HasColumnName("MEC_TSMigrate");
        });

        modelBuilder.Entity<EtlNode>(entity =>
        {
            entity.HasKey(e => e.EtlnId).HasName("PK_EtlNodes_ETLN_ID");

            entity.Property(e => e.EtlnId).HasColumnName("ETLN_ID");
            entity.Property(e => e.EtlnDtlnid).HasColumnName("ETLN_DTLNID");
            entity.Property(e => e.EtlnEntid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ETLN_ENTID");
            entity.Property(e => e.EtlnEtlcid).HasColumnName("ETLN_ETLCID");
            entity.Property(e => e.EtlnIndex).HasColumnName("ETLN_Index");
            entity.Property(e => e.EtlnIsDisabled).HasColumnName("ETLN_IsDisabled");
            entity.Property(e => e.EtlnMaxConcurrentExecutables).HasColumnName("ETLN_MaxConcurrentExecutables");
            entity.Property(e => e.EtlnName)
                .HasMaxLength(255)
                .HasColumnName("ETLN_Name");
            entity.Property(e => e.EtlnParallelPackagesSavePath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ETLN_ParallelPackagesSavePath");
            entity.Property(e => e.EtlnParentEtlnid).HasColumnName("ETLN_ParentETLNID");
            entity.Property(e => e.EtlnPsrcid).HasColumnName("ETLN_PSRCID");
            entity.Property(e => e.EtlnRelatedOlapCubes)
                .HasDefaultValue("")
                .HasColumnName("ETLN_RelatedOlapCubes");
            entity.Property(e => e.EtlnRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ETLN_RowVersion");
            entity.Property(e => e.EtlnTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("ETLN_TSInsert");
            entity.Property(e => e.EtlnTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("ETLN_TSUpdate");

            entity.HasOne(d => d.EtlnDtln).WithMany(p => p.EtlNodes)
                .HasForeignKey(d => d.EtlnDtlnid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EtlNodes_ETLN_DTLNID__TableLinks_TLN_ID");

            entity.HasOne(d => d.EtlnEnt).WithMany(p => p.EtlNodes)
                .HasForeignKey(d => d.EtlnEntid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EtlNodes_ETLN_ENTID__EtlNodeTypes_ENT_ID");

            entity.HasOne(d => d.EtlnEtlc).WithMany(p => p.EtlNodes)
                .HasForeignKey(d => d.EtlnEtlcid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EtlNodes_ETLN_ETLCID__EtlComponents_ETLC_ID");

            entity.HasOne(d => d.EtlnParentEtln).WithMany(p => p.InverseEtlnParentEtln)
                .HasForeignKey(d => d.EtlnParentEtlnid)
                .HasConstraintName("FK_EtlNodes_ETLN_ParentETLNID__EtlNodes_ETLN_ID");

            entity.HasOne(d => d.EtlnPsrc).WithMany(p => p.EtlNodes)
                .HasForeignKey(d => d.EtlnPsrcid)
                .HasConstraintName("FK_EtlNodes_ETLN_PSRCID__PhysicalSources_PSRC_ID");
        });

        modelBuilder.Entity<EtlNode1>(entity =>
        {
            entity.HasKey(e => e.MenId).HasName("PK_EtlNodes_MEN_ID");

            entity.ToTable("EtlNodes", "migrate");

            entity.Property(e => e.MenId).HasColumnName("MEN_ID");
            entity.Property(e => e.MenAction)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("MEN_Action");
            entity.Property(e => e.MenEnid).HasColumnName("MEN_ENID");
            entity.Property(e => e.MenIndex).HasColumnName("MEN_Index");
            entity.Property(e => e.MenIndexOld).HasColumnName("MEN_IndexOld");
            entity.Property(e => e.MenIsMigrated).HasColumnName("MEN_IsMigrated");
            entity.Property(e => e.MenModifiedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MEN_ModifiedBy");
            entity.Property(e => e.MenName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MEN_Name");
            entity.Property(e => e.MenNameOld)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MEN_NameOld");
            entity.Property(e => e.MenParentEtlid).HasColumnName("MEN_ParentETLID");
            entity.Property(e => e.MenParentOldEtlid).HasColumnName("MEN_ParentOldETLID");
            entity.Property(e => e.MenTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("MEN_TSInsert");
            entity.Property(e => e.MenTsmigrate)
                .HasColumnType("datetime")
                .HasColumnName("MEN_TSMigrate");
        });

        modelBuilder.Entity<EtlNodeType>(entity =>
        {
            entity.HasKey(e => e.EntId).HasName("PK_EtlNodeTypes_ENT_ID");

            entity.Property(e => e.EntId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ENT_ID");
            entity.Property(e => e.EntName)
                .HasMaxLength(255)
                .HasColumnName("ENT_Name");
        });

        modelBuilder.Entity<EtlPackageConfiguration>(entity =>
        {
            entity.HasKey(e => e.EtlpcId).HasName("PK_EtlPackageConfigurations_ETLPC_ID");

            entity.ToTable(tb => tb.HasTrigger("TRIG_UpdateParentConfiguration"));

            entity.Property(e => e.EtlpcId).HasColumnName("ETLPC_ID");
            entity.Property(e => e.EtlpcEpsid).HasColumnName("ETLPC_EPSID");
            entity.Property(e => e.EtlpcEtlcnid).HasColumnName("ETLPC_ETLCNID");
            entity.Property(e => e.EtlpcLsrid).HasColumnName("ETLPC_LSRID");
            entity.Property(e => e.EtlpcName)
                .HasMaxLength(255)
                .HasColumnName("ETLPC_Name");
            entity.Property(e => e.EtlpcRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ETLPC_RowVersion");
            entity.Property(e => e.EtlpcTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("ETLPC_TSInsert");
            entity.Property(e => e.EtlpcTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("ETLPC_TSUpdate");

            entity.HasOne(d => d.EtlpcEps).WithMany(p => p.EtlPackageConfigurations)
                .HasForeignKey(d => d.EtlpcEpsid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EtlPackageConfigurations_ETLPC_EPSID__EtlParameterSets_EPS_ID");

            entity.HasOne(d => d.EtlpcEtlcn).WithMany(p => p.EtlPackageConfigurations)
                .HasForeignKey(d => d.EtlpcEtlcnid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EtlPackageConfigurations_ETLPC_ETLCNID__EtlPackageConfigurationNodes_ETLCN_ID");

            entity.HasOne(d => d.EtlpcLsr).WithMany(p => p.EtlPackageConfigurations)
                .HasForeignKey(d => d.EtlpcLsrid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EtlPackageConfigurations_ETLPC_LSRID__LogicalSources_LSRT_ID");
        });

        modelBuilder.Entity<EtlPackageConfigurationNode>(entity =>
        {
            entity.HasKey(e => e.EtlcnId).HasName("PK_EtlPackageConfigurationNodes_ETLCN_ID");

            entity.Property(e => e.EtlcnId).HasColumnName("ETLCN_ID");
            entity.Property(e => e.EtlcnEtlcnidparent).HasColumnName("ETLCN_ETLCNIDParent");
            entity.Property(e => e.EtlcnEtlnid).HasColumnName("ETLCN_ETLNID");
            entity.Property(e => e.EtlcnEtlpcid)
                .HasDefaultValue(-1)
                .HasColumnName("ETLCN_ETLPCID");
            entity.Property(e => e.EtlcnExecInSourceDb).HasColumnName("ETLCN_ExecInSourceDb");
            entity.Property(e => e.EtlcnIsEnabled).HasColumnName("ETLCN_IsEnabled");
            entity.Property(e => e.EtlcnRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ETLCN_RowVersion");
            entity.Property(e => e.EtlcnSqlCommandText).HasColumnName("ETLCN_SqlCommandText");
            entity.Property(e => e.EtlcnTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("ETLCN_TSInsert");
            entity.Property(e => e.EtlcnTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("ETLCN_TSUpdate");

            entity.HasOne(d => d.EtlcnEtlcnidparentNavigation).WithMany(p => p.InverseEtlcnEtlcnidparentNavigation)
                .HasForeignKey(d => d.EtlcnEtlcnidparent)
                .HasConstraintName("FK_EtlPackageConfigurationNodes_ETLCN_ETLCNIDParent__EtlPackageConfigurationNodes_ETLCN_ID");

            entity.HasOne(d => d.EtlcnEtln).WithMany(p => p.EtlPackageConfigurationNodes)
                .HasForeignKey(d => d.EtlcnEtlnid)
                .HasConstraintName("FK_EtlPackageConfigurationNodes_ETLCN_ETLNID__EtlNodes_ETLN_ID");
        });

        modelBuilder.Entity<EtlParameter>(entity =>
        {
            entity.HasKey(e => e.EprmId).HasName("PK_EtlParameters_EPRM_ID");

            entity.Property(e => e.EprmId).HasColumnName("EPRM_ID");
            entity.Property(e => e.EprmDefaultValue).HasColumnName("EPRM_DefaultValue");
            entity.Property(e => e.EprmDesc)
                .HasMaxLength(512)
                .HasColumnName("EPRM_Desc");
            entity.Property(e => e.EprmEpdtid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("r")
                .IsFixedLength()
                .HasColumnName("EPRM_EPDTID");
            entity.Property(e => e.EprmIsVisibleToEndUser)
                .HasDefaultValue(true)
                .HasColumnName("EPRM_IsVisibleToEndUser");
            entity.Property(e => e.EprmName)
                .HasMaxLength(100)
                .HasColumnName("EPRM_Name");
            entity.Property(e => e.EprmRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("EPRM_RowVersion");
            entity.Property(e => e.EprmTechnicalName)
                .HasMaxLength(100)
                .HasColumnName("EPRM_TechnicalName");
            entity.Property(e => e.EprmTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("EPRM_TSInsert");
            entity.Property(e => e.EprmTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("EPRM_TSUpdate");
        });

        modelBuilder.Entity<EtlParameterDataType>(entity =>
        {
            entity.HasKey(e => e.EpdtId).HasName("PK_EtlParameterData_EPDT_ID");

            entity.ToTable("EtlParameterDataType");

            entity.Property(e => e.EpdtId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EPDT_ID");
            entity.Property(e => e.EpdtName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EPDT_Name");
        });

        modelBuilder.Entity<EtlParameterSet>(entity =>
        {
            entity.HasKey(e => e.EpsId).HasName("PK_EtlParameterSets_EPS_ID");

            entity.Property(e => e.EpsId).HasColumnName("EPS_ID");
            entity.Property(e => e.EpsDescription)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("EPS_Description");
            entity.Property(e => e.EpsName)
                .HasMaxLength(200)
                .HasColumnName("EPS_Name");
            entity.Property(e => e.EpsRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("EPS_RowVersion");
            entity.Property(e => e.EpsTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("EPS_TSInsert");
            entity.Property(e => e.EpsTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("EPS_TSUpdate");
        });

        modelBuilder.Entity<EtlParameterValue>(entity =>
        {
            entity.HasKey(e => e.EpvId).HasName("PK_EtlParameterValues_EPV_ID");

            entity.Property(e => e.EpvId).HasColumnName("EPV_ID");
            entity.Property(e => e.EpvEprmid).HasColumnName("EPV_EPRMID");
            entity.Property(e => e.EpvEpsid).HasColumnName("EPV_EPSID");
            entity.Property(e => e.EpvIsValueChanged).HasColumnName("EPV_IsValueChanged");
            entity.Property(e => e.EpvRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("EPV_RowVersion");
            entity.Property(e => e.EpvTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("EPV_TSInsert");
            entity.Property(e => e.EpvTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("EPV_TSUpdate");
            entity.Property(e => e.EpvValue).HasColumnName("EPV_Value");

            entity.HasOne(d => d.EpvEprm).WithMany(p => p.EtlParameterValues)
                .HasForeignKey(d => d.EpvEprmid)
                .HasConstraintName("FK_EtlParameterValues_EPV_EPRMID__EtlParameters_EPRM_ID");

            entity.HasOne(d => d.EpvEps).WithMany(p => p.EtlParameterValues)
                .HasForeignKey(d => d.EpvEpsid)
                .HasConstraintName("FK_EtlParameterValues_EPV_EPSID__EtlParameterSets_EPS_ID");
        });

        modelBuilder.Entity<ExecutionGraph>(entity =>
        {
            entity.HasKey(e => e.ExgId).HasName("PK_ExecutionGraphs_EXG_ID");

            entity.Property(e => e.ExgId).HasColumnName("EXG_ID");
            entity.Property(e => e.ExgEtlPackage).HasColumnName("EXG_EtlPackage");
            entity.Property(e => e.ExgIsDefault).HasColumnName("EXG_IsDefault");
            entity.Property(e => e.ExgMaxDegreeOfParallelism).HasColumnName("EXG_MaxDegreeOfParallelism");
            entity.Property(e => e.ExgName)
                .HasMaxLength(255)
                .HasColumnName("EXG_Name");
            entity.Property(e => e.ExgTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("EXG_TSInsert");
            entity.Property(e => e.ExgTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("EXG_TSUpdate");

            entity.HasOne(d => d.ExgEtlPackageNavigation).WithMany(p => p.ExecutionGraphs)
                .HasForeignKey(d => d.ExgEtlPackage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExecutionGraphs_EXG_EtlPackage__EtlNodes_ETLN_ID");
        });

        modelBuilder.Entity<ExecutionGraphNode>(entity =>
        {
            entity.HasKey(e => e.ExgnId).HasName("PK_ExecutionGraphNodes_EXGN_ID");

            entity.Property(e => e.ExgnId).HasColumnName("EXGN_ID");
            entity.Property(e => e.ExgnExgid).HasColumnName("EXGN_EXGID");
            entity.Property(e => e.ExgnPackage).HasColumnName("EXGN_Package");
            entity.Property(e => e.ExgnTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("EXGN_TSInsert");
            entity.Property(e => e.ExgnTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("EXGN_TSUpdate");

            entity.HasOne(d => d.ExgnExg).WithMany(p => p.ExecutionGraphNodes)
                .HasForeignKey(d => d.ExgnExgid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExecutionGraphNodes_EXGN_EXGID__ExecutionGraph_EXG_ID");

            entity.HasOne(d => d.ExgnPackageNavigation).WithMany(p => p.ExecutionGraphNodes)
                .HasForeignKey(d => d.ExgnPackage)
                .HasConstraintName("FK_ExecutionGraphNodes_EXGN_Package__EtlNodes_ETLN_ID");

            entity.HasMany(d => d.EgnsExgnidAntecedents).WithMany(p => p.EgnsExgns)
                .UsingEntity<Dictionary<string, object>>(
                    "ExecutionGraphNodeSuccesion",
                    r => r.HasOne<ExecutionGraphNode>().WithMany()
                        .HasForeignKey("EgnsExgnidAntecedent")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ExecutionGraphNodesSuccesion_EGNS_EXGNID_Antecedent__ExecutionGraphNodes_EXGN_ID"),
                    l => l.HasOne<ExecutionGraphNode>().WithMany()
                        .HasForeignKey("EgnsExgnid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ExecutionGraphNodesSuccesion_EGNS_EXGNID__ExecutionGraphNodes_EXGN_ID"),
                    j =>
                    {
                        j.HasKey("EgnsExgnid", "EgnsExgnidAntecedent").HasName("PK_ExecutionGraphNodeSuccesion_EGNS_EXGNID_EGNS_EXGNID_Antecedent");
                        j.ToTable("ExecutionGraphNodeSuccesion");
                        j.IndexerProperty<int>("EgnsExgnid").HasColumnName("EGNS_EXGNID");
                        j.IndexerProperty<int>("EgnsExgnidAntecedent").HasColumnName("EGNS_EXGNID_Antecedent");
                    });

            entity.HasMany(d => d.EgnsExgns).WithMany(p => p.EgnsExgnidAntecedents)
                .UsingEntity<Dictionary<string, object>>(
                    "ExecutionGraphNodeSuccesion",
                    r => r.HasOne<ExecutionGraphNode>().WithMany()
                        .HasForeignKey("EgnsExgnid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ExecutionGraphNodesSuccesion_EGNS_EXGNID__ExecutionGraphNodes_EXGN_ID"),
                    l => l.HasOne<ExecutionGraphNode>().WithMany()
                        .HasForeignKey("EgnsExgnidAntecedent")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ExecutionGraphNodesSuccesion_EGNS_EXGNID_Antecedent__ExecutionGraphNodes_EXGN_ID"),
                    j =>
                    {
                        j.HasKey("EgnsExgnid", "EgnsExgnidAntecedent").HasName("PK_ExecutionGraphNodeSuccesion_EGNS_EXGNID_EGNS_EXGNID_Antecedent");
                        j.ToTable("ExecutionGraphNodeSuccesion");
                        j.IndexerProperty<int>("EgnsExgnid").HasColumnName("EGNS_EXGNID");
                        j.IndexerProperty<int>("EgnsExgnidAntecedent").HasColumnName("EGNS_EXGNID_Antecedent");
                    });
        });

        modelBuilder.Entity<FactFieldKind>(entity =>
        {
            entity.HasKey(e => e.FfkId).HasName("PK_FactFieldKinds_FFK_ID");

            entity.Property(e => e.FfkId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FFK_ID");
            entity.Property(e => e.FfkName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FFK_Name");
        });

        modelBuilder.Entity<Field>(entity =>
        {
            entity.HasKey(e => e.FldId).HasName("PK_Fields_FLD_ID");

            entity.Property(e => e.FldId).HasColumnName("FLD_ID");
            entity.Property(e => e.FldAllowCorrections).HasColumnName("FLD_AllowCorrections");
            entity.Property(e => e.FldAtDestinationDerivedExpression)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("FLD_AtDestinationDerivedExpression");
            entity.Property(e => e.FldAtSourceDerivedExpression)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("FLD_AtSourceDerivedExpression");
            entity.Property(e => e.FldCtkind)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FLD_CTKIND");
            entity.Property(e => e.FldDataEditorFieldName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FLD_DataEditorFieldName");
            entity.Property(e => e.FldDatid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLD_DATID");
            entity.Property(e => e.FldDefaultValue)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FLD_DefaultValue");
            entity.Property(e => e.FldDescription)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("FLD_Description");
            entity.Property(e => e.FldDfkid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLD_DFKID");
            entity.Property(e => e.FldDisplayOrder).HasColumnName("FLD_DisplayOrder");
            entity.Property(e => e.FldFfkid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLD_FFKID");
            entity.Property(e => e.FldIsCorrectionFilter).HasColumnName("FLD_IsCorrectionFilter");
            entity.Property(e => e.FldIsCorrectionMapping).HasColumnName("FLD_IsCorrectionMapping");
            entity.Property(e => e.FldIsCorrectionObligatory).HasColumnName("FLD_IsCorrectionObligatory");
            entity.Property(e => e.FldIsIdentity).HasColumnName("FLD_IsIdentity");
            entity.Property(e => e.FldIsNullable).HasColumnName("FLD_IsNullable");
            entity.Property(e => e.FldIsReadOnly).HasColumnName("FLD_IsReadOnly");
            entity.Property(e => e.FldIsSourceField).HasColumnName("FLD_IsSourceField");
            entity.Property(e => e.FldIsTranslationField).HasColumnName("FLD_IsTranslationField");
            entity.Property(e => e.FldIsVisible).HasColumnName("FLD_IsVisible");
            entity.Property(e => e.FldLength).HasColumnName("FLD_Length");
            entity.Property(e => e.FldLogicalName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FLD_LogicalName");
            entity.Property(e => e.FldMergeWithSourceOrgId).HasColumnName("FLD_MergeWithSourceOrgID");
            entity.Property(e => e.FldMigrationGuid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("FLD_MigrationGUID");
            entity.Property(e => e.FldName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FLD_Name");
            entity.Property(e => e.FldOlapId)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("FLD_OlapID");
            entity.Property(e => e.FldRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("FLD_RowVersion");
            entity.Property(e => e.FldScale).HasColumnName("FLD_Scale");
            entity.Property(e => e.FldSourceFieldExpression)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FLD_SourceFieldExpression");
            entity.Property(e => e.FldSourceFieldName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FLD_SourceFieldName");
            entity.Property(e => e.FldTblid).HasColumnName("FLD_TBLID");
            entity.Property(e => e.FldTbtid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLD_TBTID");
            entity.Property(e => e.FldTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("FLD_TSInsert");
            entity.Property(e => e.FldTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("FLD_TSUpdate");
            entity.Property(e => e.FldUseAtDestinationDerivedExpression).HasColumnName("FLD_UseAtDestinationDerivedExpression");
            entity.Property(e => e.FldUseAtSourceDerivedExpression).HasColumnName("FLD_UseAtSourceDerivedExpression");

            entity.HasOne(d => d.FldDat).WithMany(p => p.Fields)
                .HasForeignKey(d => d.FldDatid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Fields_FLD_DATID__DataTypes_DAT_ID");

            entity.HasOne(d => d.FldDfk).WithMany(p => p.Fields)
                .HasForeignKey(d => d.FldDfkid)
                .HasConstraintName("FK_Fields_FLD_DFKID__DimensionFieldKinds_DFK_ID");

            entity.HasOne(d => d.FldFfk).WithMany(p => p.Fields)
                .HasForeignKey(d => d.FldFfkid)
                .HasConstraintName("FK_Fields_FLD_FFKID__FactFieldKinds_FFK_ID");

            entity.HasOne(d => d.FldTbl).WithMany(p => p.Fields)
                .HasForeignKey(d => d.FldTblid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Fields_FLD_TBLID__Tables_TBL_ID");

            entity.HasOne(d => d.FldTbt).WithMany(p => p.Fields)
                .HasForeignKey(d => d.FldTbtid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Fields_FLD_TBTID__TableTypes_TBT_ID");
        });

        modelBuilder.Entity<Field1>(entity =>
        {
            entity.HasKey(e => e.MflId).HasName("PK_Fields_MFL_ID");

            entity.ToTable("Fields", "migrate");

            entity.Property(e => e.MflId).HasColumnName("MFL_ID");
            entity.Property(e => e.MflAction)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("MFL_Action");
            entity.Property(e => e.MflFieldNameNew)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MFL_FieldNameNew");
            entity.Property(e => e.MflFieldNameOld)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MFL_FieldNameOld");
            entity.Property(e => e.MflFldid).HasColumnName("MFL_FLDID");
            entity.Property(e => e.MflIsMigrated).HasColumnName("MFL_IsMigrated");
            entity.Property(e => e.MflModifiedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MFL_ModifiedBy");
            entity.Property(e => e.MflTblid).HasColumnName("MFL_TBLID");
            entity.Property(e => e.MflTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("MFL_TSInsert");
            entity.Property(e => e.MflTsmigrate)
                .HasColumnType("datetime")
                .HasColumnName("MFL_TSMigrate");
        });

        modelBuilder.Entity<FieldLink>(entity =>
        {
            entity.HasKey(e => e.FllId).HasName("PK_FieldLinks_FLL_ID");

            entity.Property(e => e.FllId).HasColumnName("FLL_ID");
            entity.Property(e => e.FllAtDestinationDerivedExpression)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("FLL_AtDestinationDerivedExpression");
            entity.Property(e => e.FllAtSourceDerivedExpression)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("FLL_AtSourceDerivedExpression");
            entity.Property(e => e.FllFldid).HasColumnName("FLL_FLDID");
            entity.Property(e => e.FllIsSourceField).HasColumnName("FLL_IsSourceField");
            entity.Property(e => e.FllPsrcid).HasColumnName("FLL_PSRCID");
            entity.Property(e => e.FllRelationLookUpFieldId).HasColumnName("FLL_RelationLookUpFieldID");
            entity.Property(e => e.FllRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("FLL_RowVersion");
            entity.Property(e => e.FllSourceFieldExpression)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FLL_SourceFieldExpression");
            entity.Property(e => e.FllSourceFieldName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FLL_SourceFieldName");
            entity.Property(e => e.FllTlnid).HasColumnName("FLL_TLNID");
            entity.Property(e => e.FllTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("FLL_TSInsert");
            entity.Property(e => e.FllTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("FLL_TSUpdate");
            entity.Property(e => e.FllUpdtatePriority).HasColumnName("FLL_UpdtatePriority");
            entity.Property(e => e.FllUseAtDestinationDerivedExpression).HasColumnName("FLL_UseAtDestinationDerivedExpression");
            entity.Property(e => e.FllUseAtSourceDerivedExpression).HasColumnName("FLL_UseAtSourceDerivedExpression");

            entity.HasOne(d => d.FllFld).WithMany(p => p.FieldLinkFllFlds)
                .HasForeignKey(d => d.FllFldid)
                .HasConstraintName("FK_FieldLinks_FLL_FLDID__Fields_FLD_ID");

            entity.HasOne(d => d.FllPsrc).WithMany(p => p.FieldLinks)
                .HasForeignKey(d => d.FllPsrcid)
                .HasConstraintName("FK_FieldLinks_FLL_PSRCID__PhysicalSources_PSRC_ID");

            entity.HasOne(d => d.FllRelationLookUpField).WithMany(p => p.FieldLinkFllRelationLookUpFields)
                .HasForeignKey(d => d.FllRelationLookUpFieldId)
                .HasConstraintName("FK_FieldLinks_FLL_RelationLookUpFieldID__Fields_FLD_ID");

            entity.HasOne(d => d.FllTln).WithMany(p => p.FieldLinks)
                .HasForeignKey(d => d.FllTlnid)
                .HasConstraintName("FK_FieldLinks_FLL_TLNID__TableLinks_TLN_ID");
        });

        modelBuilder.Entity<FieldSettingsForUser>(entity =>
        {
            entity.HasKey(e => e.FseId).HasName("PK_FieldSettingsForUser_FSE_ID");

            entity.ToTable("FieldSettingsForUser", "de");

            entity.Property(e => e.FseId).HasColumnName("FSE_ID");
            entity.Property(e => e.FseFldid).HasColumnName("FSE_FLDID");
            entity.Property(e => e.FseInsert)
                .HasColumnType("datetime")
                .HasColumnName("FSE_Insert");
            entity.Property(e => e.FseReadOnly).HasColumnName("FSE_ReadOnly");
            entity.Property(e => e.FseUpdate)
                .HasColumnType("datetime")
                .HasColumnName("FSE_Update");
            entity.Property(e => e.FseUsrid).HasColumnName("FSE_USRID");
            entity.Property(e => e.FseVisible).HasColumnName("FSE_Visible");

            entity.HasOne(d => d.FseFld).WithMany(p => p.FieldSettingsForUsers)
                .HasForeignKey(d => d.FseFldid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FieldSettingsForUser_FSE_FLDID__Fields_FLD_ID");

            entity.HasOne(d => d.FseUsr).WithMany(p => p.FieldSettingsForUsers)
                .HasForeignKey(d => d.FseUsrid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FieldSettingsForUser_FSE_USRID__ApplicationUsers_USR_Id");
        });

        modelBuilder.Entity<FillMode>(entity =>
        {
            entity.HasKey(e => e.FmdId).HasName("PK_FillModes_FMD_ID");

            entity.Property(e => e.FmdId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FMD_ID");
            entity.Property(e => e.FmdName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FMD_Name");
        });

        modelBuilder.Entity<ForeignKeyDisplay>(entity =>
        {
            entity.HasKey(e => e.FkdId).HasName("PK_ForeignKeyDisplay_FKD_ID");

            entity.ToTable("ForeignKeyDisplay", "de");

            entity.Property(e => e.FkdId).HasColumnName("FKD_ID");
            entity.Property(e => e.FkdDisplayOrder).HasColumnName("FKD_DisplayOrder");
            entity.Property(e => e.FkdFldid).HasColumnName("FKD_FLDID");
            entity.Property(e => e.FkdTblid).HasColumnName("FKD_TBLID");

            entity.HasOne(d => d.FkdFld).WithMany(p => p.ForeignKeyDisplays)
                .HasForeignKey(d => d.FkdFldid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForeignKeyDisplay_FKD_FLDID__Fields_FLD_ID");

            entity.HasOne(d => d.FkdTbl).WithMany(p => p.ForeignKeyDisplays)
                .HasForeignKey(d => d.FkdTblid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForeignKeyDisplay_FKD_TBLID__Tables_TBL_ID");
        });

        modelBuilder.Entity<FtpConfiguration>(entity =>
        {
            entity.HasKey(e => e.FcfId).HasName("PK_FtpConfiguration_FCF_ID");

            entity.Property(e => e.FcfId).HasColumnName("FCF_ID");
            entity.Property(e => e.FcfAnalizeDirectoryStructure)
                .HasDefaultValue(true)
                .HasColumnName("FCF_AnalizeDirectoryStructure");
            entity.Property(e => e.FcfAnalizeExtensions)
                .HasDefaultValue(true)
                .HasColumnName("FCF_AnalizeExtensions");
            entity.Property(e => e.FcfAnalizeFileHeaders).HasColumnName("FCF_AnalizeFileHeaders");
            entity.Property(e => e.FcfAnalizePrefixes)
                .HasDefaultValue(true)
                .HasColumnName("FCF_AnalizePrefixes");
            entity.Property(e => e.FcfContinueOnError).HasColumnName("FCF_ContinueOnError");
            entity.Property(e => e.FcfDaysBackwardInMainInterval).HasColumnName("FCF_DaysBackwardInMainInterval");
            entity.Property(e => e.FcfDaysBackwardInSubIntervalDown).HasColumnName("FCF_DaysBackwardInSubIntervalDown");
            entity.Property(e => e.FcfDaysBackwardInSubIntervalUp).HasColumnName("FCF_DaysBackwardInSubIntervalUp");
            entity.Property(e => e.FcfDescription)
                .IsUnicode(false)
                .HasColumnName("FCF_Description");
            entity.Property(e => e.FcfFcfeidmain)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FCF_FCFEIDMain");
            entity.Property(e => e.FcfFcfeidsub)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FCF_FCFEIDSub");
            entity.Property(e => e.FcfFcflidmain)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FCF_FCFLIDMain");
            entity.Property(e => e.FcfFcflidsub)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FCF_FCFLIDSub");
            entity.Property(e => e.FcfFcftid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FCF_FCFTID");
            entity.Property(e => e.FcfIsActive).HasColumnName("FCF_IsActive");
            entity.Property(e => e.FcfIsGlobalConfiguration).HasColumnName("FCF_IsGlobalConfiguration");
            entity.Property(e => e.FcfIsStatic).HasColumnName("FCF_IsStatic");
            entity.Property(e => e.FcfIsSystematic).HasColumnName("FCF_IsSystematic");
            entity.Property(e => e.FcfName)
                .IsUnicode(false)
                .HasColumnName("FCF_Name");
            entity.Property(e => e.FcfRemoveFromSourceFolder).HasColumnName("FCF_RemoveFromSourceFolder");

            entity.HasOne(d => d.FcfFcfeidmainNavigation).WithMany(p => p.FtpConfigurationFcfFcfeidmainNavigations)
                .HasForeignKey(d => d.FcfFcfeidmain)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FtpConfigurations_FCF_FCFEIDMain__FtpConfigurationExpectedFiles_FCFE_ID");

            entity.HasOne(d => d.FcfFcfeidsubNavigation).WithMany(p => p.FtpConfigurationFcfFcfeidsubNavigations)
                .HasForeignKey(d => d.FcfFcfeidsub)
                .HasConstraintName("FK_FtpConfigurations_FCF_FCFEIDSub__FtpConfigurationExpectedFiles_FCFE_ID");

            entity.HasOne(d => d.FcfFcflidmainNavigation).WithMany(p => p.FtpConfigurationFcfFcflidmainNavigations)
                .HasForeignKey(d => d.FcfFcflidmain)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FtpConfigurations_FCF_FCFLIDMain__FtpConfigurationLoadFilesTypes_FCFL_ID");

            entity.HasOne(d => d.FcfFcflidsubNavigation).WithMany(p => p.FtpConfigurationFcfFcflidsubNavigations)
                .HasForeignKey(d => d.FcfFcflidsub)
                .HasConstraintName("FK_FtpConfigurations_FCF_FCFLIDSub__FtpConfigurationLoadFilesTypes_FCFL_ID");

            entity.HasOne(d => d.FcfFcft).WithMany(p => p.FtpConfigurations)
                .HasForeignKey(d => d.FcfFcftid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FtpConfigurations_FCF_FCFTID__FtpConfigurationTypes_FCFT_ID");
        });

        modelBuilder.Entity<FtpConfigurationExpectedFile>(entity =>
        {
            entity.HasKey(e => e.FcfeId).HasName("PK_FtpConfigurationExpectedFiles_FCFE_ID");

            entity.Property(e => e.FcfeId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FCFE_ID");
            entity.Property(e => e.FcfeName)
                .IsUnicode(false)
                .HasColumnName("FCFE_Name");
        });

        modelBuilder.Entity<FtpConfigurationLoadFilesType>(entity =>
        {
            entity.HasKey(e => e.FcflId).HasName("PK_FtpConfigurationLoadFilesTypes_FCFL_ID");

            entity.Property(e => e.FcflId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FCFL_ID");
            entity.Property(e => e.FcflName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FCFL_Name");
        });

        modelBuilder.Entity<FtpConfigurationType>(entity =>
        {
            entity.HasKey(e => e.FcftId).HasName("PK_FtpConfigurationTypes_FCFT_ID");

            entity.Property(e => e.FcftId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FCFT_ID");
            entity.Property(e => e.FcftName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FCFT_Name");
        });

        modelBuilder.Entity<HistoricalChange>(entity =>
        {
            entity.HasKey(e => e.HiscId).HasName("PK_HistoricalChanges_HISC_ID");

            entity.ToTable("HistoricalChanges", "meta");

            entity.Property(e => e.HiscId)
                .ValueGeneratedNever()
                .HasColumnName("HISC_ID");
            entity.Property(e => e.HiscDescription).HasColumnName("HISC_Description");
            entity.Property(e => e.HiscEntityPaths).HasColumnName("HISC_EntityPaths");
            entity.Property(e => e.HiscTsinsert)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("HISC_TSInsert");
            entity.Property(e => e.HiscUser)
                .HasMaxLength(100)
                .HasColumnName("HISC_User");
        });

        modelBuilder.Entity<HistoricalChangesCollectionValue>(entity =>
        {
            entity.HasKey(e => e.HcvcId).HasName("PK_HistoricalChangesCollectionValues_HCVC_ID");

            entity.ToTable("HistoricalChangesCollectionValues", "meta");

            entity.Property(e => e.HcvcId)
                .ValueGeneratedNever()
                .HasColumnName("HCVC_ID");
            entity.Property(e => e.HcvcDiscriminator).HasColumnName("HCVC_Discriminator");
            entity.Property(e => e.HcvcHiscid).HasColumnName("HCVC_HISCID");
            entity.Property(e => e.HcvcIdentifier)
                .HasMaxLength(150)
                .HasColumnName("HCVC_Identifier");
            entity.Property(e => e.HcvcIndex)
                .HasMaxLength(150)
                .HasColumnName("HCVC_Index");
            entity.Property(e => e.HcvcNewValue).HasColumnName("HCVC_NewValue");
            entity.Property(e => e.HcvcOldValue).HasColumnName("HCVC_OldValue");
            entity.Property(e => e.HcvcOperationType)
                .HasMaxLength(16)
                .HasColumnName("HCVC_OperationType");
            entity.Property(e => e.HcvcOwnerEntityName)
                .HasMaxLength(150)
                .HasColumnName("HCVC_OwnerEntityName");
            entity.Property(e => e.HcvcOwnerPrimaryKey).HasColumnName("HCVC_OwnerPrimaryKey");
            entity.Property(e => e.HcvcOwnerPropertyName)
                .HasMaxLength(150)
                .HasColumnName("HCVC_OwnerPropertyName");
            entity.Property(e => e.HcvcPropertyName)
                .HasMaxLength(150)
                .HasColumnName("HCVC_PropertyName");

            entity.HasOne(d => d.HcvcHisc).WithMany(p => p.HistoricalChangesCollectionValues)
                .HasForeignKey(d => d.HcvcHiscid)
                .HasConstraintName("FK_HistoricalChangesCollectionValues_HCVC_HISCID__HistoricalChanges_HISC_ID");
        });

        modelBuilder.Entity<HistoricalChangesEntitesValue>(entity =>
        {
            entity.HasKey(e => e.HcevId).HasName("PK_HistoricalChangesEntitesValues_HCEV_ID");

            entity.ToTable("HistoricalChangesEntitesValues", "meta");

            entity.Property(e => e.HcevId)
                .ValueGeneratedNever()
                .HasColumnName("HCEV_ID");
            entity.Property(e => e.HcevDescription).HasColumnName("HCEV_Description");
            entity.Property(e => e.HcevHsceid).HasColumnName("HCEV_HSCEID");
            entity.Property(e => e.HcevNewValue).HasColumnName("HCEV_NewValue");
            entity.Property(e => e.HcevOldValue).HasColumnName("HCEV_OldValue");
            entity.Property(e => e.HcevPropertyName)
                .HasMaxLength(150)
                .HasColumnName("HCEV_PropertyName");

            entity.HasOne(d => d.HcevHsce).WithMany(p => p.HistoricalChangesEntitesValues)
                .HasForeignKey(d => d.HcevHsceid)
                .HasConstraintName("FK_HistoricalChangesEntitesValues_HCEV_HSCEID__HistoricalChangesEntities_HSCE_ID");
        });

        modelBuilder.Entity<HistoricalChangesEntity>(entity =>
        {
            entity.HasKey(e => e.HsceId).HasName("PK_HistoricalChangesEntities_HSCE_ID");

            entity.ToTable("HistoricalChangesEntities", "meta");

            entity.Property(e => e.HsceId)
                .ValueGeneratedNever()
                .HasColumnName("HSCE_ID");
            entity.Property(e => e.HsceBusinessKey).HasColumnName("HSCE_BusinessKey");
            entity.Property(e => e.HsceDescription).HasColumnName("HSCE_Description");
            entity.Property(e => e.HsceEntityName)
                .HasMaxLength(150)
                .HasColumnName("HSCE_EntityName");
            entity.Property(e => e.HsceHiscid).HasColumnName("HSCE_HISCID");
            entity.Property(e => e.HsceOperationType)
                .HasMaxLength(255)
                .HasColumnName("HSCE_OperationType");
            entity.Property(e => e.HscePrimaryKey).HasColumnName("HSCE_PrimaryKey");

            entity.HasOne(d => d.HsceHisc).WithMany(p => p.HistoricalChangesEntities)
                .HasForeignKey(d => d.HsceHiscid)
                .HasConstraintName("FK_HistoricalChangesEntities_HSCE_HISCID__HistoricalChanges_HISC_ID");
        });

        modelBuilder.Entity<Index>(entity =>
        {
            entity.HasKey(e => e.IndId).HasName("PK_Indexes_IND_ID");

            entity.Property(e => e.IndId).HasColumnName("IND_ID");
            entity.Property(e => e.IndLogicalName)
                .HasMaxLength(100)
                .HasColumnName("IND_LogicalName");
            entity.Property(e => e.IndTblid).HasColumnName("IND_TBLID");

            entity.HasOne(d => d.IndTbl).WithMany(p => p.Indices)
                .HasForeignKey(d => d.IndTblid)
                .HasConstraintName("FK_Indexes_IND_TBLID__Tables_TBL_ID");
        });

        modelBuilder.Entity<IndexField>(entity =>
        {
            entity.HasKey(e => e.IndfId).HasName("PK_IndexFields_INDF_ID");

            entity.Property(e => e.IndfId).HasColumnName("INDF_ID");
            entity.Property(e => e.IndfFldid).HasColumnName("INDF_FLDID");
            entity.Property(e => e.IndfIndid).HasColumnName("INDF_INDID");
            entity.Property(e => e.IndfOrder).HasColumnName("INDF_Order");

            entity.HasOne(d => d.IndfFld).WithMany(p => p.IndexFields)
                .HasForeignKey(d => d.IndfFldid)
                .HasConstraintName("FK_IndexFields_INDF_FLDID__Fields_FLD_ID");

            entity.HasOne(d => d.IndfInd).WithMany(p => p.IndexFields)
                .HasForeignKey(d => d.IndfIndid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IndexFields_INDF_INDID__Indexes_IND_ID");
        });

        modelBuilder.Entity<IndexIncludedField>(entity =>
        {
            entity.HasKey(e => e.IndiId).HasName("PK_IndexIncludedFields_INDI_ID");

            entity.Property(e => e.IndiId).HasColumnName("INDI_ID");
            entity.Property(e => e.IndiFldid).HasColumnName("INDI_FLDID");
            entity.Property(e => e.IndiIndid).HasColumnName("INDI_INDID");

            entity.HasOne(d => d.IndiFld).WithMany(p => p.IndexIncludedFields)
                .HasForeignKey(d => d.IndiFldid)
                .HasConstraintName("FK_IndexIncludedFields_INDI_FLDID__Fields_FLD_ID");

            entity.HasOne(d => d.IndiInd).WithMany(p => p.IndexIncludedFields)
                .HasForeignKey(d => d.IndiIndid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IndexIncludedFields_INDI_INDID__Indexes_IND_ID");
        });

        modelBuilder.Entity<Input>(entity =>
        {
            entity.HasKey(e => e.InId).HasName("PK_Input_IN_Id");

            entity.ToTable("Input", "dca");

            entity.Property(e => e.InId).HasColumnName("IN_Id");
            entity.Property(e => e.InCubeName)
                .HasMaxLength(100)
                .HasColumnName("IN_CubeName");
            entity.Property(e => e.InDatabase)
                .HasMaxLength(100)
                .HasColumnName("IN_Database");
            entity.Property(e => e.InDate)
                .HasColumnType("datetime")
                .HasColumnName("IN_Date");
            entity.Property(e => e.InDefinition).HasColumnName("IN_Definition");
            entity.Property(e => e.InInputTableName)
                .HasMaxLength(128)
                .HasColumnName("IN_InputTableName");
            entity.Property(e => e.InName)
                .HasMaxLength(50)
                .HasColumnName("IN_Name");
            entity.Property(e => e.InServer)
                .HasMaxLength(100)
                .HasColumnName("IN_Server");
            entity.Property(e => e.InType)
                .HasMaxLength(10)
                .HasColumnName("IN_Type");
            entity.Property(e => e.InXmlDefinition)
                .HasDefaultValue("")
                .HasColumnName("IN_XmlDefinition");
        });

        modelBuilder.Entity<Key>(entity =>
        {
            entity.HasKey(e => e.KeyId).HasName("PK_Keys_KEY_Id");

            entity.ToTable("Keys", "dca");

            entity.Property(e => e.KeyId).HasColumnName("KEY_Id");
            entity.Property(e => e.KeyCubeName)
                .HasMaxLength(50)
                .HasColumnName("KEY_CubeName");
            entity.Property(e => e.KeyDatabase)
                .HasMaxLength(100)
                .HasColumnName("KEY_Database");
            entity.Property(e => e.KeyDate)
                .HasColumnType("datetime")
                .HasColumnName("KEY_Date");
            entity.Property(e => e.KeyDefinition).HasColumnName("KEY_Definition");
            entity.Property(e => e.KeyDimension)
                .HasMaxLength(50)
                .HasColumnName("KEY_Dimension");
            entity.Property(e => e.KeyName)
                .HasMaxLength(50)
                .HasColumnName("KEY_Name");
            entity.Property(e => e.KeyServer)
                .HasMaxLength(100)
                .HasColumnName("KEY_Server");
            entity.Property(e => e.KeyStatus)
                .HasMaxLength(10)
                .HasColumnName("KEY_Status");
            entity.Property(e => e.KeyType)
                .HasMaxLength(10)
                .HasColumnName("KEY_Type");
            entity.Property(e => e.KeyXmlDefinition)
                .HasDefaultValue("")
                .HasColumnName("KEY_XmlDefinition");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.LanId).HasName("PK_Language_LAN_ID");

            entity.ToTable("Language", "de");

            entity.Property(e => e.LanId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LAN_ID");
            entity.Property(e => e.LanName)
                .HasMaxLength(50)
                .HasColumnName("LAN_Name");
        });

        modelBuilder.Entity<LogicalSource>(entity =>
        {
            entity.HasKey(e => e.LsrtId).HasName("PK_LogicalSources_LSRT_ID");

            entity.Property(e => e.LsrtId).HasColumnName("LSRT_ID");
            entity.Property(e => e.LsrtAcronym)
                .HasMaxLength(4)
                .HasColumnName("LSRT_Acronym");
            entity.Property(e => e.LsrtDecription)
                .HasMaxLength(500)
                .HasColumnName("LSRT_Decription");
            entity.Property(e => e.LsrtDepid).HasColumnName("LSRT_DEPID");
            entity.Property(e => e.LsrtHaspServerName)
                .HasMaxLength(40)
                .HasColumnName("LSRT_HaspServerName");
            entity.Property(e => e.LsrtIsCentral).HasColumnName("LSRT_IsCentral");
            entity.Property(e => e.LsrtIsPattern)
                .HasDefaultValue(true)
                .HasColumnName("LSRT_IsPattern");
            entity.Property(e => e.LsrtIsXlcTemplate).HasColumnName("LSRT_IsXlcTemplate");
            entity.Property(e => e.LsrtName)
                .HasMaxLength(100)
                .HasColumnName("LSRT_Name");
            entity.Property(e => e.LsrtRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("LSRT_RowVersion");
            entity.Property(e => e.LsrtSrcorgId)
                .HasMaxLength(50)
                .HasColumnName("LSRT_SRCOrgID");
            entity.Property(e => e.LsrtTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("LSRT_TSInsert");
            entity.Property(e => e.LsrtTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("LSRT_TSUpdate");

            entity.HasOne(d => d.LsrtDep).WithMany(p => p.LogicalSources)
                .HasForeignKey(d => d.LsrtDepid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogicalSources_LSRT_DEPID__Departments_DEP_ID");
        });

        modelBuilder.Entity<LogicalSource1>(entity =>
        {
            entity.HasKey(e => e.MlsId).HasName("PK_LogicalSources_MLS_ID");

            entity.ToTable("LogicalSources", "migrate");

            entity.Property(e => e.MlsId).HasColumnName("MLS_ID");
            entity.Property(e => e.MlsAction)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("MLS_Action");
            entity.Property(e => e.MlsDepid).HasColumnName("MLS_DEPID");
            entity.Property(e => e.MlsIsMigrated).HasColumnName("MLS_IsMigrated");
            entity.Property(e => e.MlsLsid).HasColumnName("MLS_LSID");
            entity.Property(e => e.MlsModifiedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MLS_ModifiedBy");
            entity.Property(e => e.MlsName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MLS_Name");
            entity.Property(e => e.MlsNameOld)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MLS_NameOld");
            entity.Property(e => e.MlsTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("MLS_TSInsert");
            entity.Property(e => e.MlsTsmigrate)
                .HasColumnType("datetime")
                .HasColumnName("MLS_TSMigrate");
        });

        modelBuilder.Entity<MeasureObjectAttachInfo>(entity =>
        {
            entity.HasKey(e => e.MoaiId).HasName("PK_MeasureObjectAttachInfos_MOAI_ID");

            entity.ToTable("MeasureObjectAttachInfos", "dca");

            entity.Property(e => e.MoaiId).HasColumnName("MOAI_ID");
            entity.Property(e => e.MoaiAotid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MOAI_AOTID");
            entity.Property(e => e.MoaiAttachedToObjId)
                .HasMaxLength(255)
                .HasColumnName("MOAI_AttachedToObjID");
            entity.Property(e => e.MoaiAttachedToObjName)
                .HasMaxLength(255)
                .HasColumnName("MOAI_AttachedToObjName");
            entity.Property(e => e.MoaiData).HasColumnName("MOAI_Data");
            entity.Property(e => e.MoaiInfoKind)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("MOAI_InfoKind");
            entity.Property(e => e.MoaiIsAttached).HasColumnName("MOAI_IsAttached");
            entity.Property(e => e.MoaiIsVisible).HasColumnName("MOAI_IsVisible");
            entity.Property(e => e.MoaiObjId)
                .HasMaxLength(255)
                .HasColumnName("MOAI_ObjID");
            entity.Property(e => e.MoaiObjName)
                .HasMaxLength(255)
                .HasColumnName("MOAI_ObjName");
            entity.Property(e => e.MoaiParentId)
                .HasMaxLength(255)
                .HasColumnName("MOAI_ParentID");
            entity.Property(e => e.MoaiParentName)
                .HasMaxLength(255)
                .HasColumnName("MOAI_ParentName");
            entity.Property(e => e.MoaiTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("MOAI_TSInsert");
            entity.Property(e => e.MoaiTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("MOAI_TSUpdate");
        });

        modelBuilder.Entity<MessageTranslation>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK_MessageTranslations_TRANS_ID");

            entity.Property(e => e.TransId).HasColumnName("TRANS_ID");
            entity.Property(e => e.TransIsssisvariable)
                .HasDefaultValue(true)
                .HasColumnName("TRANS_ISSSISVARIABLE");
            entity.Property(e => e.TransIstech).HasColumnName("TRANS_ISTECH");
            entity.Property(e => e.TransLangid).HasColumnName("TRANS_LANGID");
            entity.Property(e => e.TransLangname)
                .HasMaxLength(255)
                .HasColumnName("TRANS_LANGNAME");
            entity.Property(e => e.TransName)
                .HasMaxLength(255)
                .HasColumnName("TRANS_NAME");
            entity.Property(e => e.TransParid)
                .HasMaxLength(255)
                .HasColumnName("TRANS_PARID");
            entity.Property(e => e.TransTables)
                .HasMaxLength(255)
                .HasColumnName("TRANS_TABLES");
        });

        modelBuilder.Entity<NextHighVaue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NextHighVaues", "meta");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.PacId).HasName("PK_Package_PAC_Id");

            entity.ToTable("Package", "dca");

            entity.Property(e => e.PacId).HasColumnName("PAC_Id");
            entity.Property(e => e.PacCreatorName)
                .HasMaxLength(50)
                .HasColumnName("PAC_CreatorName");
            entity.Property(e => e.PacCreatorSourceSystemId).HasColumnName("PAC_CreatorSourceSystemId");
            entity.Property(e => e.PacDateCreate)
                .HasColumnType("datetime")
                .HasColumnName("PAC_DateCreate");
            entity.Property(e => e.PacDateLastEdited)
                .HasColumnType("datetime")
                .HasColumnName("PAC_DateLastEdited");
            entity.Property(e => e.PacLastEditorName)
                .HasMaxLength(50)
                .HasColumnName("PAC_LastEditorName");
            entity.Property(e => e.PacName)
                .HasMaxLength(50)
                .HasColumnName("PAC_Name");
            entity.Property(e => e.PacRefreshData)
                .HasDefaultValue(0)
                .HasColumnName("PAC_RefreshData");
            entity.Property(e => e.PacState).HasColumnName("PAC_State");
            entity.Property(e => e.PacXmlDefinition)
                .HasDefaultValue("")
                .HasColumnName("PAC_XmlDefinition");
        });

        modelBuilder.Entity<PackageProcess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PackageProcesses", "dca");

            entity.Property(e => e.PapPacId).HasColumnName("PAP_PAC_Id");
            entity.Property(e => e.PapPrcId).HasColumnName("PAP_PRC_Id");

            entity.HasOne(d => d.PapPac).WithMany()
                .HasForeignKey(d => d.PapPacId)
                .HasConstraintName("FK_PackageProcesses_PAP_PAC_Id__Package_PAC_Id");

            entity.HasOne(d => d.PapPrc).WithMany()
                .HasForeignKey(d => d.PapPrcId)
                .HasConstraintName("FK_PackageProcesses_PAP_PRC_Id__Processes_PRC_Id");
        });

        modelBuilder.Entity<PhysicalSource>(entity =>
        {
            entity.HasKey(e => e.PsrcId).HasName("PK_PhysicalSources_PSRC_ID");

            entity.Property(e => e.PsrcId).HasColumnName("PSRC_ID");
            entity.Property(e => e.PsrcConnectionString)
                .HasMaxLength(500)
                .HasColumnName("PSRC_ConnectionString");
            entity.Property(e => e.PsrcDescription)
                .HasMaxLength(500)
                .HasColumnName("PSRC_Description");
            entity.Property(e => e.PsrcFolderName)
                .HasMaxLength(255)
                .HasColumnName("PSRC_FolderName");
            entity.Property(e => e.PsrcIsCentral).HasColumnName("PSRC_IsCentral");
            entity.Property(e => e.PsrcIsPattern)
                .HasDefaultValue(true)
                .HasColumnName("PSRC_IsPattern");
            entity.Property(e => e.PsrcIsUnicode).HasColumnName("PSRC_IsUnicode");
            entity.Property(e => e.PsrcIsWarehouse).HasColumnName("PSRC_IsWarehouse");
            entity.Property(e => e.PsrcLsrcid).HasColumnName("PSRC_LSRCID");
            entity.Property(e => e.PsrcMainUrl)
                .HasMaxLength(255)
                .HasColumnName("PSRC_MainUrl");
            entity.Property(e => e.PsrcMustBeArchived).HasColumnName("PSRC_MustBeArchived");
            entity.Property(e => e.PsrcMustBeBackuped).HasColumnName("PSRC_MustBeBackuped");
            entity.Property(e => e.PsrcName)
                .HasMaxLength(255)
                .HasColumnName("PSRC_Name");
            entity.Property(e => e.PsrcQualifier)
                .HasMaxLength(500)
                .HasColumnName("PSRC_Qualifier");
            entity.Property(e => e.PsrcRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("PSRC_RowVersion");
            entity.Property(e => e.PsrcSrtid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PSRC_SRTID");
            entity.Property(e => e.PsrcTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("PSRC_TSInsert");
            entity.Property(e => e.PsrcTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("PSRC_TSUpdate");
            entity.Property(e => e.PsrcType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("u")
                .IsFixedLength()
                .HasColumnName("PSRC_Type");
            entity.Property(e => e.PsrcUseCustomPatternConfiguration).HasColumnName("PSRC_UseCustomPatternConfiguration");

            entity.HasOne(d => d.PsrcLsrc).WithMany(p => p.PhysicalSources)
                .HasForeignKey(d => d.PsrcLsrcid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicalSources_PSRC_LSRCID__LogicalSources_LSRT_ID");

            entity.HasOne(d => d.PsrcSrt).WithMany(p => p.PhysicalSources)
                .HasForeignKey(d => d.PsrcSrtid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicalSources_PSRC_SRTID__SourceTypes_SRT_ID");
        });

        modelBuilder.Entity<PhysicalSource1>(entity =>
        {
            entity.HasKey(e => e.MpsId).HasName("PK_PhysicalSources_MPS_ID");

            entity.ToTable("PhysicalSources", "migrate");

            entity.Property(e => e.MpsId).HasColumnName("MPS_ID");
            entity.Property(e => e.MpsAction)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("MPS_Action");
            entity.Property(e => e.MpsConnectionString)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MPS_ConnectionString");
            entity.Property(e => e.MpsConnectionStringOld)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MPS_ConnectionStringOld");
            entity.Property(e => e.MpsFolderName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MPS_FolderName");
            entity.Property(e => e.MpsFolderNameOld)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MPS_FolderNameOld");
            entity.Property(e => e.MpsIsMigrated).HasColumnName("MPS_IsMigrated");
            entity.Property(e => e.MpsLsid).HasColumnName("MPS_LSID");
            entity.Property(e => e.MpsModifiedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MPS_ModifiedBy");
            entity.Property(e => e.MpsPsid).HasColumnName("MPS_PSID");
            entity.Property(e => e.MpsTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("MPS_TSInsert");
            entity.Property(e => e.MpsTsmigrate)
                .HasColumnType("datetime")
                .HasColumnName("MPS_TSMigrate");
        });

        modelBuilder.Entity<PrimaryKey>(entity =>
        {
            entity.HasKey(e => e.PrkId).HasName("PK_PrimaryKeys_PRK_ID");

            entity.Property(e => e.PrkId).HasColumnName("PRK_ID");
            entity.Property(e => e.PrkLogicalName)
                .HasMaxLength(100)
                .HasColumnName("PRK_LogicalName");
            entity.Property(e => e.PrkTblid).HasColumnName("PRK_TBLID");

            entity.HasOne(d => d.PrkTbl).WithMany(p => p.PrimaryKeys)
                .HasForeignKey(d => d.PrkTblid)
                .HasConstraintName("FK_PrimaryKeys_PRK_TBLID__Tables_TBL_ID");
        });

        modelBuilder.Entity<PrimaryKeyField>(entity =>
        {
            entity.HasKey(e => e.PrkfId).HasName("PK_PrimaryKeyFields_PRKF_ID");

            entity.Property(e => e.PrkfId).HasColumnName("PRKF_ID");
            entity.Property(e => e.PrkfFldid).HasColumnName("PRKF_FLDID");
            entity.Property(e => e.PrkfIndex).HasColumnName("PRKF_Index");
            entity.Property(e => e.PrkfPrkid).HasColumnName("PRKF_PRKID");

            entity.HasOne(d => d.PrkfFld).WithMany(p => p.PrimaryKeyFields)
                .HasForeignKey(d => d.PrkfFldid)
                .HasConstraintName("FK_PrimaryKeyFields_PRKF_FLDID__Fields_FLD_ID");

            entity.HasOne(d => d.PrkfPrk).WithMany(p => p.PrimaryKeyFields)
                .HasForeignKey(d => d.PrkfPrkid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrimaryKeyFields_PRKF_PRKID__PrimaryKeys_PRK_ID");
        });

        modelBuilder.Entity<Process>(entity =>
        {
            entity.HasKey(e => e.PrcId).HasName("PK_Processes_PRC_Id");

            entity.ToTable("Processes", "dca");

            entity.Property(e => e.PrcId).HasColumnName("PRC_Id");
            entity.Property(e => e.PrcCreatorSourceSystemId).HasColumnName("PRC_CreatorSourceSystemId");
            entity.Property(e => e.PrcDateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PRC_DateCreate");
            entity.Property(e => e.PrcDateLastEdit)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PRC_DateLastEdit");
            entity.Property(e => e.PrcInId).HasColumnName("PRC_IN_Id");
            entity.Property(e => e.PrcLastEditUserName)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("PRC_LastEditUserName");
            entity.Property(e => e.PrcName)
                .HasMaxLength(50)
                .HasColumnName("PRC_Name");
            entity.Property(e => e.PrcState).HasColumnName("PRC_State");
            entity.Property(e => e.PrcUserName)
                .HasMaxLength(50)
                .HasColumnName("PRC_UserName");
            entity.Property(e => e.PrcXmlDefinition)
                .HasDefaultValue("")
                .HasColumnName("PRC_XmlDefinition");

            entity.HasOne(d => d.PrcIn).WithMany(p => p.Processes)
                .HasForeignKey(d => d.PrcInId)
                .HasConstraintName("FK_Processes_PRC_IN_Id__Input_IN_Id");
        });

        modelBuilder.Entity<ProcessAuthorizationType>(entity =>
        {
            entity.HasKey(e => e.PatId);

            entity.ToTable("ProcessAuthorizationType");

            entity.Property(e => e.PatId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAT_ID");
            entity.Property(e => e.PatName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PAT_Name");
        });

        modelBuilder.Entity<ProcessesKey>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProcessesKeys", "dca");

            entity.Property(e => e.PrkKeyId).HasColumnName("PRK_KEY_Id");
            entity.Property(e => e.PrkKeyTableName)
                .HasMaxLength(128)
                .HasColumnName("PRK_KeyTableName");
            entity.Property(e => e.PrkPrcId).HasColumnName("PRK_PRC_Id");

            entity.HasOne(d => d.PrkKey).WithMany()
                .HasForeignKey(d => d.PrkKeyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcessesKeys_PRK_KEY_Id__Keys_KEY_Id");

            entity.HasOne(d => d.PrkPrc).WithMany()
                .HasForeignKey(d => d.PrkPrcId)
                .HasConstraintName("FK_ProcessesKeys_PRK_PRC_Id__Processes_PRC_Id");
        });

        modelBuilder.Entity<RealTimeWarehouseSetting>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.RwsCustomValue)
                .HasMaxLength(500)
                .HasColumnName("RWS_CustomValue");
            entity.Property(e => e.RwsId).HasColumnName("RWS_ID");
            entity.Property(e => e.RwsName)
                .HasMaxLength(50)
                .HasColumnName("RWS_Name");
            entity.Property(e => e.RwsRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("RWS_RowVersion");
            entity.Property(e => e.RwsTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("RWS_TSInsert");
            entity.Property(e => e.RwsTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("RWS_TSUpdate");
        });

        modelBuilder.Entity<Relation>(entity =>
        {
            entity.HasKey(e => e.RelId).HasName("PK_Relations_REL_ID");

            entity.Property(e => e.RelId).HasColumnName("REL_ID");
            entity.Property(e => e.RelBetweenFirstFieldId).HasColumnName("REL_BetweenFirstFieldID");
            entity.Property(e => e.RelBetweenSecondFieldId).HasColumnName("REL_BetweenSecondFieldID");
            entity.Property(e => e.RelClauseOrderBy)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("REL_ClauseOrderBy");
            entity.Property(e => e.RelClauseWhere)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("REL_ClauseWhere");
            entity.Property(e => e.RelCreateDatabaseConstraint)
                .HasDefaultValue(true)
                .HasColumnName("REL_CreateDatabaseConstraint");
            entity.Property(e => e.RelCreateOnDw).HasColumnName("REL_CreateOnDW");
            entity.Property(e => e.RelFirstFieldId).HasColumnName("REL_FirstFieldID");
            entity.Property(e => e.RelInputFieldId).HasColumnName("REL_InputFieldID");
            entity.Property(e => e.RelMappingLookupFieldId).HasColumnName("REL_MappingLookupFieldID");
            entity.Property(e => e.RelMappingLookupTableId).HasColumnName("REL_MappingLookupTableID");
            entity.Property(e => e.RelMappingRetrievedFieldId).HasColumnName("REL_MappingRetrievedFieldID");
            entity.Property(e => e.RelNextId).HasColumnName("REL_NextID");
            entity.Property(e => e.RelOutputFieldId).HasColumnName("REL_OutputFieldID");
            entity.Property(e => e.RelRelatedFieldId).HasColumnName("REL_RelatedFieldID");
            entity.Property(e => e.RelRelationDescriptionFieldId).HasColumnName("REL_RelationDescriptionFieldID");
            entity.Property(e => e.RelRelationNameFieldId).HasColumnName("REL_RelationNameFieldID");
            entity.Property(e => e.RelRetrievedFieldId).HasColumnName("REL_RetrievedFieldID");
            entity.Property(e => e.RelRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("REL_RowVersion");
            entity.Property(e => e.RelTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("REL_TSInsert");
            entity.Property(e => e.RelTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("REL_TSUpdate");
            entity.Property(e => e.RelUseAdvancedLookup).HasColumnName("REL_UseAdvancedLookup");
            entity.Property(e => e.RelUseBetweenCondition).HasColumnName("REL_UseBetweenCondition");
            entity.Property(e => e.RelUseMappingLookup).HasColumnName("REL_UseMappingLookup");

            entity.HasOne(d => d.RelFirstField).WithMany(p => p.RelationRelFirstFields)
                .HasForeignKey(d => d.RelFirstFieldId)
                .HasConstraintName("FK_Relations_REL_FirstFieldID__Fields_FLD_ID");

            entity.HasOne(d => d.RelInputField).WithMany(p => p.RelationRelInputFields)
                .HasForeignKey(d => d.RelInputFieldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Relations_REL_InputFieldID__Fields_FLD_ID");

            entity.HasOne(d => d.RelMappingLookupField).WithMany(p => p.RelationRelMappingLookupFields)
                .HasForeignKey(d => d.RelMappingLookupFieldId)
                .HasConstraintName("FK_Relations_REL_MappingLookupFieldID__Fields_FLD_ID");

            entity.HasOne(d => d.RelMappingLookupTable).WithMany(p => p.Relations)
                .HasForeignKey(d => d.RelMappingLookupTableId)
                .HasConstraintName("FK_Relations_REL_MappingLookupTableID__Tables_TBL_ID");

            entity.HasOne(d => d.RelMappingRetrievedField).WithMany(p => p.RelationRelMappingRetrievedFields)
                .HasForeignKey(d => d.RelMappingRetrievedFieldId)
                .HasConstraintName("FK_Relations_REL_MappingRetrievedFieldID__Fields_FLD_ID");

            entity.HasOne(d => d.RelNext).WithMany(p => p.InverseRelNext)
                .HasForeignKey(d => d.RelNextId)
                .HasConstraintName("FK_Relations_REL_NextID__Relations_REL_ID");

            entity.HasOne(d => d.RelOutputField).WithMany(p => p.RelationRelOutputFields)
                .HasForeignKey(d => d.RelOutputFieldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Relations_REL_OutputFieldID__Fields_FLD_ID");

            entity.HasOne(d => d.RelRelatedField).WithMany(p => p.RelationRelRelatedFields)
                .HasForeignKey(d => d.RelRelatedFieldId)
                .HasConstraintName("FK_Relations_REL_RelatedFieldID__Fields_FLD_ID");

            entity.HasOne(d => d.RelRelationDescriptionField).WithMany(p => p.RelationRelRelationDescriptionFields)
                .HasForeignKey(d => d.RelRelationDescriptionFieldId)
                .HasConstraintName("FK_Relations_REL_RelationDescriptionFieldID__Fields_FLD_ID");

            entity.HasOne(d => d.RelRelationNameField).WithMany(p => p.RelationRelRelationNameFields)
                .HasForeignKey(d => d.RelRelationNameFieldId)
                .HasConstraintName("FK_Relations_REL_RelationNameFieldID__Fields_FLD_ID");

            entity.HasOne(d => d.RelRetrievedField).WithMany(p => p.RelationRelRetrievedFields)
                .HasForeignKey(d => d.RelRetrievedFieldId)
                .HasConstraintName("FK_Relations_REL_RetrievedFieldID__Fields_FLD_ID");
        });

        modelBuilder.Entity<Relation1>(entity =>
        {
            entity.HasKey(e => e.MreId).HasName("PK_Relations_MRE_ID");

            entity.ToTable("Relations", "migrate");

            entity.Property(e => e.MreId).HasColumnName("MRE_ID");
            entity.Property(e => e.MreAction)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("MRE_Action");
            entity.Property(e => e.MreFirstFieldId).HasColumnName("MRE_FirstFieldID");
            entity.Property(e => e.MreIsMigrated).HasColumnName("MRE_IsMigrated");
            entity.Property(e => e.MreModifiedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MRE_ModifiedBy");
            entity.Property(e => e.MreRelid).HasColumnName("MRE_RELID");
            entity.Property(e => e.MreTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("MRE_TSInsert");
            entity.Property(e => e.MreTsmigrate)
                .HasColumnType("datetime")
                .HasColumnName("MRE_TSMigrate");
        });

        modelBuilder.Entity<Server>(entity =>
        {
            entity.HasKey(e => e.SrvId).HasName("PK_Server_SRV_ID");

            entity.ToTable("Server", "de");

            entity.Property(e => e.SrvId).HasColumnName("SRV_ID");
            entity.Property(e => e.SrvInstanceName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRV_InstanceName");
            entity.Property(e => e.SrvPrivateIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRV_PrivateIP");
            entity.Property(e => e.SrvPublicIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRV_PublicIP");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.SetId).HasName("PK_Settings_SET_ID");

            entity.ToTable(tb => tb.HasTrigger("ResetPackageBuildNumber"));

            entity.Property(e => e.SetId).HasColumnName("SET_ID");
            entity.Property(e => e.SetCustomValue).HasColumnName("SET_CustomValue");
            entity.Property(e => e.SetDatid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SET_DATID");
            entity.Property(e => e.SetDepid).HasColumnName("SET_DEPID");
            entity.Property(e => e.SetEnumid).HasColumnName("SET_ENUMID");
            entity.Property(e => e.SetName)
                .HasMaxLength(50)
                .HasColumnName("SET_Name");
            entity.Property(e => e.SetRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SET_RowVersion");
            entity.Property(e => e.SetTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("SET_TSInsert");
            entity.Property(e => e.SetTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("SET_TSUpdate");

            entity.HasOne(d => d.SetDep).WithMany(p => p.Settings)
                .HasForeignKey(d => d.SetDepid)
                .HasConstraintName("FK_Settings_SET_DEPID__Departments_DEP_ID");

            entity.HasOne(d => d.SetEnum).WithMany(p => p.Settings)
                .HasForeignKey(d => d.SetEnumid)
                .HasConstraintName("FK_Settings_SET_ENUMID__EnumeratorValues_ENUM_ID");
        });

        modelBuilder.Entity<SourceType>(entity =>
        {
            entity.HasKey(e => e.SrtId).HasName("PK_SourceTypes_SRT_ID");

            entity.Property(e => e.SrtId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SRT_ID");
            entity.Property(e => e.SrtName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRT_Name");
        });

        modelBuilder.Entity<StackColumnValue>(entity =>
        {
            entity.HasKey(e => e.ScvId).HasName("PK_StackColumnValue_SCV_ID");

            entity.ToTable("StackColumnValue", "de");

            entity.Property(e => e.ScvId).HasColumnName("SCV_ID");
            entity.Property(e => e.ScvFldid).HasColumnName("SCV_FLDID");
            entity.Property(e => e.ScvTblid).HasColumnName("SCV_TBLID");
            entity.Property(e => e.ScvValue)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SCV_Value");

            entity.HasOne(d => d.ScvFld).WithMany(p => p.StackColumnValues)
                .HasForeignKey(d => d.ScvFldid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StackColumnValue_SCV_FLDID__Field_FLD_ID");

            entity.HasOne(d => d.ScvTbl).WithMany(p => p.StackColumnValues)
                .HasForeignKey(d => d.ScvTblid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StackColumnValue_SCV_TBLID__Tables_TBL_ID");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.TblId).HasName("PK_Tables_TBL_ID");

            entity.Property(e => e.TblId).HasColumnName("TBL_ID");
            entity.Property(e => e.DatabaseName).HasMaxLength(100);
            entity.Property(e => e.ServerName).HasMaxLength(100);
            entity.Property(e => e.TblAllowCorrections).HasColumnName("TBL_AllowCorrections");
            entity.Property(e => e.TblAttributesAsMeasures).HasColumnName("TBL_AttributesAsMeasures");
            entity.Property(e => e.TblCheckSumKimball1FieldId).HasColumnName("TBL_CheckSumKimball1FieldID");
            entity.Property(e => e.TblCheckSumKimball2FieldId).HasColumnName("TBL_CheckSumKimball2FieldID");
            entity.Property(e => e.TblCleanOrgIdfieldlId).HasColumnName("TBL_CleanOrgIDFieldlID");
            entity.Property(e => e.TblCloseUnmappedHistoricalData)
                .HasDefaultValue(true)
                .HasColumnName("TBL_CloseUnmappedHistoricalData");
            entity.Property(e => e.TblCorrespondingResponseFileTable).HasColumnName("TBL_CorrespondingResponseFileTable");
            entity.Property(e => e.TblCreateBdt).HasColumnName("TBL_CreateBDT");
            entity.Property(e => e.TblCustomProperty1)
                .HasMaxLength(512)
                .HasColumnName("TBL_CustomProperty1");
            entity.Property(e => e.TblCustomProperty2)
                .HasMaxLength(512)
                .HasColumnName("TBL_CustomProperty2");
            entity.Property(e => e.TblDataEditorTableName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TBL_DataEditorTableName");
            entity.Property(e => e.TblDbsid).HasColumnName("TBL_DBSID");
            entity.Property(e => e.TblDescription)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TBL_Description");
            entity.Property(e => e.TblDescriptionFieldId).HasColumnName("TBL_DescriptionFieldID");
            entity.Property(e => e.TblDisplayOrder).HasColumnName("TBL_DisplayOrder");
            entity.Property(e => e.TblDisplaySeparator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TBL_DisplaySeparator");
            entity.Property(e => e.TblDitid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TBL_DITID");
            entity.Property(e => e.TblDstid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TBL_DSTID");
            entity.Property(e => e.TblDtdgidfieldId).HasColumnName("TBL_DTDGIDFieldID");
            entity.Property(e => e.TblFmdid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TBL_FMDID");
            entity.Property(e => e.TblGidfieldId).HasColumnName("TBL_GIDFieldID");
            entity.Property(e => e.TblIdfieldId).HasColumnName("TBL_IDFieldID");
            entity.Property(e => e.TblInsertSubTransformationIdfieldId).HasColumnName("TBL_InsertSubTransformationIDFieldID");
            entity.Property(e => e.TblInsertTransformationIdfieldId).HasColumnName("TBL_InsertTransformationIDFieldID");
            entity.Property(e => e.TblIsAutoTranslated).HasColumnName("TBL_IsAutoTranslated");
            entity.Property(e => e.TblIsMultiRow).HasColumnName("TBL_IsMultiRow");
            entity.Property(e => e.TblIsSourceTable).HasColumnName("TBL_IsSourceTable");
            entity.Property(e => e.TblIsUnEditable).HasColumnName("TBL_IsUnEditable");
            entity.Property(e => e.TblIsVisible)
                .HasDefaultValue(true)
                .HasColumnName("TBL_IsVisible");
            entity.Property(e => e.TblLogicalName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TBL_LogicalName");
            entity.Property(e => e.TblMigrationGuid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("TBL_MigrationGUID");
            entity.Property(e => e.TblNameFieldId).HasColumnName("TBL_NameFieldID");
            entity.Property(e => e.TblNeedsTranslationConfirmation).HasColumnName("TBL_NeedsTranslationConfirmation");
            entity.Property(e => e.TblNumberFieldId).HasColumnName("TBL_NumberFieldID");
            entity.Property(e => e.TblOlapId)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("TBL_OlapID");
            entity.Property(e => e.TblOrgIdfieldlId).HasColumnName("TBL_OrgIDFieldlID");
            entity.Property(e => e.TblParCleanOrgIdfieldId).HasColumnName("TBL_ParCleanOrgIDFieldID");
            entity.Property(e => e.TblParDirtyOrgIdfieldId).HasColumnName("TBL_ParDirtyOrgIDFieldID");
            entity.Property(e => e.TblPargidfieldId).HasColumnName("TBL_PARGIDFieldID");
            entity.Property(e => e.TblPrefix)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TBL_Prefix");
            entity.Property(e => e.TblRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TBL_RowVersion");
            entity.Property(e => e.TblRowVersionFieldId).HasColumnName("TBL_RowVersionFieldID");
            entity.Property(e => e.TblSqlstatementToBeUsedAsTimeTo).HasColumnName("TBL_SQLStatementToBeUsedAsTimeTo");
            entity.Property(e => e.TblSrcgidfieldId).HasColumnName("TBL_SRCGIDFieldID");
            entity.Property(e => e.TblTableName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TBL_TableName");
            entity.Property(e => e.TblTbtid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TBL_TBTID");
            entity.Property(e => e.TblTgrid).HasColumnName("TBL_TGRID");
            entity.Property(e => e.TblTimeFromFieldId).HasColumnName("TBL_TimeFromFieldID");
            entity.Property(e => e.TblTimeToFieldId).HasColumnName("TBL_TimeToFieldID");
            entity.Property(e => e.TblTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("TBL_TSInsert");
            entity.Property(e => e.TblTsinsertFieldId).HasColumnName("TBL_TSInsertFieldID");
            entity.Property(e => e.TblTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("TBL_TSUpdate");
            entity.Property(e => e.TblTsupdateFieldId).HasColumnName("TBL_TSUpdateFieldID");
            entity.Property(e => e.TblUpdateSubTransformationIdfieldId).HasColumnName("TBL_UpdateSubTransformationIDFieldID");
            entity.Property(e => e.TblUpdateTransformationIdfieldId).HasColumnName("TBL_UpdateTransformationIDFieldID");
            entity.Property(e => e.TblUseSqlstatementAsTimeFrom).HasColumnName("TBL_UseSQLStatementAsTimeFrom");
            entity.Property(e => e.TblUseSqlstatementAsTimeTo).HasColumnName("TBL_UseSQLStatementAsTimeTo");
            entity.Property(e => e.TblValueFieldId).HasColumnName("TBL_ValueFieldID");
            entity.Property(e => e.TblWsSchemaId)
                .HasDefaultValue(1)
                .HasColumnName("TBL_WS_SchemaID");

            entity.HasOne(d => d.TblDbs).WithMany(p => p.Tables)
                .HasForeignKey(d => d.TblDbsid)
                .HasConstraintName("FK_Tables_TBL_DBSID__DatabaseSchema_DBS_ID");

            entity.HasOne(d => d.TblTgr).WithMany(p => p.Tables)
                .HasForeignKey(d => d.TblTgrid)
                .HasConstraintName("FK_Tables_TBL_TGRID__TableGroup_TGR_ID");

            entity.HasOne(d => d.TblWsSchema).WithMany(p => p.Tables)
                .HasForeignKey(d => d.TblWsSchemaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tables_TBL_WS_SchemaID__WarehouseSchemas__WS_ID");
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity.HasKey(e => e.MtbId).HasName("PK_Tables_MTB_ID");

            entity.ToTable("Tables", "migrate");

            entity.Property(e => e.MtbId).HasColumnName("MTB_ID");
            entity.Property(e => e.MtbAction)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("MTB_Action");
            entity.Property(e => e.MtbIsMigrated).HasColumnName("MTB_IsMigrated");
            entity.Property(e => e.MtbModifiedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MTB_ModifiedBy");
            entity.Property(e => e.MtbTableName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MTB_TableName");
            entity.Property(e => e.MtbTableNameOld)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MTB_TableNameOld");
            entity.Property(e => e.MtbTblid).HasColumnName("MTB_TBLID");
            entity.Property(e => e.MtbTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("MTB_TSInsert");
            entity.Property(e => e.MtbTsmigrate)
                .HasColumnType("datetime")
                .HasColumnName("MTB_TSMigrate");
        });

        modelBuilder.Entity<TableGroup>(entity =>
        {
            entity.HasKey(e => e.TgrId).HasName("PK_TableGroup_TGR_ID");

            entity.ToTable("TableGroup", "de");

            entity.Property(e => e.TgrId).HasColumnName("TGR_ID");
            entity.Property(e => e.TgrName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TGR_Name");
            entity.Property(e => e.TgrTgrid).HasColumnName("TGR_TGRID");

            entity.HasOne(d => d.TgrTgr).WithMany(p => p.InverseTgrTgr)
                .HasForeignKey(d => d.TgrTgrid)
                .HasConstraintName("FK_TableGroup_TGR_TGRID__TableGroup_TGR_ID");
        });

        modelBuilder.Entity<TableLink>(entity =>
        {
            entity.HasKey(e => e.TlnId).HasName("PK_TableLinks_TLN_ID");

            entity.Property(e => e.TlnId).HasColumnName("TLN_ID");
            entity.Property(e => e.TlnAfterProc).HasColumnName("TLN_AfterProc");
            entity.Property(e => e.TlnAssignedRegex)
                .HasMaxLength(500)
                .HasColumnName("TLN_AssignedRegex");
            entity.Property(e => e.TlnAutoTranslationKind)
                .HasDefaultValue(1)
                .HasColumnName("TLN_AutoTranslationKind");
            entity.Property(e => e.TlnBackwardThreshold).HasColumnName("TLN_BackwardThreshold");
            entity.Property(e => e.TlnBeforeProc).HasColumnName("TLN_BeforeProc");
            entity.Property(e => e.TlnCodePage).HasColumnName("TLN_CodePage");
            entity.Property(e => e.TlnCustomFileName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TLN_CustomFileName");
            entity.Property(e => e.TlnCustomFilePath)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("TLN_CustomFilePath");
            entity.Property(e => e.TlnCustomFileSeparator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TLN_CustomFileSeparator");
            entity.Property(e => e.TlnCustomPatternLookup).HasColumnName("TLN_CustomPatternLookup");
            entity.Property(e => e.TlnCustomQuery).HasColumnName("TLN_CustomQuery");
            entity.Property(e => e.TlnCustomTableName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TLN_CustomTableName");
            entity.Property(e => e.TlnDescription)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("TLN_Description");
            entity.Property(e => e.TlnDropIndexBeforeImport)
                .HasDefaultValue(true)
                .HasColumnName("TLN_DropIndexBeforeImport");
            entity.Property(e => e.TlnEprmid).HasColumnName("TLN_EPRMID");
            entity.Property(e => e.TlnExtraQuery)
                .IsUnicode(false)
                .HasColumnName("TLN_ExtraQuery");
            entity.Property(e => e.TlnFcfid).HasColumnName("TLN_FCFID");
            entity.Property(e => e.TlnFillMode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("t")
                .HasColumnName("TLN_FillMode");
            entity.Property(e => e.TlnForwardThreshold).HasColumnName("TLN_ForwardThreshold");
            entity.Property(e => e.TlnGenerateDynamicSelect).HasColumnName("TLN_GenerateDynamicSelect");
            entity.Property(e => e.TlnHasColumnNamesInFirstRow)
                .HasDefaultValue(true)
                .HasColumnName("TLN_HasColumnNamesInFirstRow");
            entity.Property(e => e.TlnHasLocalFtpConfiguration).HasColumnName("TLN_HasLocalFtpConfiguration");
            entity.Property(e => e.TlnHasRegexMapping).HasColumnName("TLN_HasRegexMapping");
            entity.Property(e => e.TlnIgnoreOrgIdCase)
                .HasDefaultValue(true)
                .HasColumnName("TLN_IgnoreOrgIdCase");
            entity.Property(e => e.TlnInitQuerySection)
                .HasComment("Kod sql do deklarowania i inicjowania zmiennych wykorzystywanych w CustomQuery")
                .HasColumnName("TLN_InitQuerySection");
            entity.Property(e => e.TlnIsAutoTranslated).HasColumnName("TLN_IsAutoTranslated");
            entity.Property(e => e.TlnIsForStaticFiles).HasColumnName("TLN_IsForStaticFiles");
            entity.Property(e => e.TlnIsMissingOrgIdsReportingActive)
                .HasDefaultValue(true)
                .HasColumnName("TLN_IsMissingOrgIDsReportingActive");
            entity.Property(e => e.TlnLoadInRealTime).HasColumnName("TLN_LoadInRealTime");
            entity.Property(e => e.TlnMetaQuery).HasColumnName("TLN_MetaQuery");
            entity.Property(e => e.TlnName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TLN_Name");
            entity.Property(e => e.TlnNeedsTranslationConfirmation).HasColumnName("TLN_NeedsTranslationConfirmation");
            entity.Property(e => e.TlnOrgIdFieldSorting).HasColumnName("TLN_OrgIdFieldSorting");
            entity.Property(e => e.TlnPsrcid).HasColumnName("TLN_PSRCID");
            entity.Property(e => e.TlnRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TLN_RowVersion");
            entity.Property(e => e.TlnRunAfterProc).HasColumnName("TLN_RunAfterProc");
            entity.Property(e => e.TlnRunBeforeProc).HasColumnName("TLN_RunBeforeProc");
            entity.Property(e => e.TlnSheetName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TLN_SheetName");
            entity.Property(e => e.TlnTblid).HasColumnName("TLN_TBLID");
            entity.Property(e => e.TlnTbtid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TLN_TBTID");
            entity.Property(e => e.TlnTextQualifier)
                .HasMaxLength(50)
                .HasColumnName("TLN_TextQualifier");
            entity.Property(e => e.TlnThresholdEnabled)
                .HasDefaultValue(true)
                .HasColumnName("TLN_ThresholdEnabled");
            entity.Property(e => e.TlnTranslationDescriptionFieldId).HasColumnName("TLN_TranslationDescriptionFieldID");
            entity.Property(e => e.TlnTranslationField1FieldId).HasColumnName("TLN_TranslationField1FieldID");
            entity.Property(e => e.TlnTranslationField2FieldId).HasColumnName("TLN_TranslationField2FieldID");
            entity.Property(e => e.TlnTranslationField3FieldId).HasColumnName("TLN_TranslationField3FieldID");
            entity.Property(e => e.TlnTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("TLN_TSInsert");
            entity.Property(e => e.TlnTsuid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TLN_TSUID");
            entity.Property(e => e.TlnTsupdate)
                .HasColumnType("datetime")
                .HasColumnName("TLN_TSUpdate");
            entity.Property(e => e.TlnUseCorrectionRules).HasColumnName("TLN_UseCorrectionRules");
            entity.Property(e => e.TlnUseCustomName).HasColumnName("TLN_UseCustomName");
            entity.Property(e => e.TlnUseCustomQueryAndPath).HasColumnName("TLN_UseCustomQueryAndPath");
            entity.Property(e => e.TlnUseCustomQueryAsView).HasColumnName("TLN_UseCustomQueryAsView");
            entity.Property(e => e.TlnXmlSchemaPath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TLN_XmlSchemaPath");

            entity.HasOne(d => d.TlnFcf).WithMany(p => p.TableLinks)
                .HasForeignKey(d => d.TlnFcfid)
                .HasConstraintName("FK_TableLinks_TLN_FCFID__FtpConfigurations_FCF_ID");

            entity.HasOne(d => d.TlnPsrc).WithMany(p => p.TableLinks)
                .HasForeignKey(d => d.TlnPsrcid)
                .HasConstraintName("FK_TableLinks_TLN_PSRCID__PhysicalSources_PSRC_ID");

            entity.HasOne(d => d.TlnTbl).WithMany(p => p.TableLinks)
                .HasForeignKey(d => d.TlnTblid)
                .HasConstraintName("FK_TableLinks_TLN_TBLID__Tables_TBL_ID");

            entity.HasOne(d => d.TlnTbt).WithMany(p => p.TableLinks)
                .HasForeignKey(d => d.TlnTbtid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TableLinks_TLN_TBTID__TableTypes_TBT_ID");

            entity.HasOne(d => d.TlnTranslationDescriptionField).WithMany(p => p.TableLinkTlnTranslationDescriptionFields)
                .HasForeignKey(d => d.TlnTranslationDescriptionFieldId)
                .HasConstraintName("FK_TableLinks_TLN_TranslationDescriptionFieldID__Fields_FLD_ID");

            entity.HasOne(d => d.TlnTranslationField1Field).WithMany(p => p.TableLinkTlnTranslationField1Fields)
                .HasForeignKey(d => d.TlnTranslationField1FieldId)
                .HasConstraintName("FK_TableLinks_TLN_TranslationField1FieldID__Fields_FLD_ID");

            entity.HasOne(d => d.TlnTranslationField2Field).WithMany(p => p.TableLinkTlnTranslationField2Fields)
                .HasForeignKey(d => d.TlnTranslationField2FieldId)
                .HasConstraintName("FK_TableLinks_TLN_TranslationField2FieldID__Fields_FLD_ID");

            entity.HasOne(d => d.TlnTranslationField3Field).WithMany(p => p.TableLinkTlnTranslationField3Fields)
                .HasForeignKey(d => d.TlnTranslationField3FieldId)
                .HasConstraintName("FK_TableLinks_TLN_TranslationField3FieldID__Fields_FLD_ID");

            entity.HasOne(d => d.TlnTsu).WithMany(p => p.TableLinks)
                .HasForeignKey(d => d.TlnTsuid)
                .HasConstraintName("FK_TableLinks_TLN_TSUID__ThresholdUnits_TSU_ID");
        });

        modelBuilder.Entity<TableLink1>(entity =>
        {
            entity.HasKey(e => e.MtlId).HasName("PK_TableLinks_MTL_ID");

            entity.ToTable("TableLinks", "migrate");

            entity.Property(e => e.MtlId).HasColumnName("MTL_ID");
            entity.Property(e => e.MtlAction)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("MTL_Action");
            entity.Property(e => e.MtlIsMigrated).HasColumnName("MTL_IsMigrated");
            entity.Property(e => e.MtlModifiedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MTL_ModifiedBy");
            entity.Property(e => e.MtlName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MTL_Name");
            entity.Property(e => e.MtlNameOld)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MTL_NameOld");
            entity.Property(e => e.MtlPsid).HasColumnName("MTL_PSID");
            entity.Property(e => e.MtlTblid).HasColumnName("MTL_TBLID");
            entity.Property(e => e.MtlTlid).HasColumnName("MTL_TLID");
            entity.Property(e => e.MtlTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("MTL_TSInsert");
            entity.Property(e => e.MtlTsmigrate)
                .HasColumnType("datetime")
                .HasColumnName("MTL_TSMigrate");
        });

        modelBuilder.Entity<TableType>(entity =>
        {
            entity.HasKey(e => e.TbtId).HasName("PK_TableTypes_TBT_ID");

            entity.Property(e => e.TbtId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TBT_ID");
            entity.Property(e => e.TbtName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBT_Name");
        });

        modelBuilder.Entity<Target>(entity =>
        {
            entity.HasKey(e => e.TgId).HasName("PK_Target_TG_Id");

            entity.ToTable("Target", "dca");

            entity.Property(e => e.TgId).HasColumnName("TG_Id");
            entity.Property(e => e.TgBilancedZero).HasColumnName("TG_BilancedZero");
            entity.Property(e => e.TgCaption)
                .HasMaxLength(100)
                .HasColumnName("TG_Caption");
            entity.Property(e => e.TgCubeName)
                .HasMaxLength(100)
                .HasColumnName("TG_CubeName");
            entity.Property(e => e.TgDate)
                .HasColumnType("datetime")
                .HasColumnName("TG_Date");
            entity.Property(e => e.TgInvertedValues).HasColumnName("TG_InvertedValues");
            entity.Property(e => e.TgIsNewMeasure)
                .HasDefaultValue(true)
                .HasColumnName("TG_IsNewMeasure");
            entity.Property(e => e.TgMeasureGroup)
                .HasMaxLength(100)
                .HasColumnName("TG_MeasureGroup");
            entity.Property(e => e.TgMeasureName)
                .HasMaxLength(100)
                .HasColumnName("TG_MeasureName");
            entity.Property(e => e.TgPrcId).HasColumnName("TG_PRC_id");
            entity.Property(e => e.TgXmlDefinition)
                .HasDefaultValue("")
                .HasColumnName("TG_XmlDefinition");

            entity.HasOne(d => d.TgPrc).WithMany(p => p.Targets)
                .HasForeignKey(d => d.TgPrcId)
                .HasConstraintName("FK_Target_TG_PRC_Id__Processes_PRC_Id");
        });

        modelBuilder.Entity<TargetFktTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TargetFktTables", "dca");

            entity.Property(e => e.TfFktTableName)
                .HasMaxLength(50)
                .HasColumnName("TF_FktTableName");
            entity.Property(e => e.TfTgId).HasColumnName("TF_TG_Id");

            entity.HasOne(d => d.TfTg).WithMany()
                .HasForeignKey(d => d.TfTgId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TargetFktTables_TF_TG_Id__Target_TG_Id");
        });

        modelBuilder.Entity<ThresholdUnit>(entity =>
        {
            entity.HasKey(e => e.TsuId).HasName("PK_ThresholdUnits_TSU_ID");

            entity.Property(e => e.TsuId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TSU_ID");
            entity.Property(e => e.TsuName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TSU_Name");
        });

        modelBuilder.Entity<ToolTipField>(entity =>
        {
            entity.HasKey(e => e.TtfId).HasName("PK_ToolTipField_TTF_ID");

            entity.ToTable("ToolTipField", "de");

            entity.Property(e => e.TtfId).HasColumnName("TTF_ID");
            entity.Property(e => e.TtfDescription).HasColumnName("TTF_Description");
            entity.Property(e => e.TtfFldid).HasColumnName("TTF_FLDID");
            entity.Property(e => e.TtfLanid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TTF_LANID");

            entity.HasOne(d => d.TtfFld).WithMany(p => p.ToolTipFields)
                .HasForeignKey(d => d.TtfFldid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToolTipField_TTF_FLDID__Fields_FLD_ID");

            entity.HasOne(d => d.TtfLan).WithMany(p => p.ToolTipFields)
                .HasForeignKey(d => d.TtfLanid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToolTipField_TTF_LANID__Language_LAN_ID");
        });

        modelBuilder.Entity<ToolTipTable>(entity =>
        {
            entity.HasKey(e => e.TttId).HasName("PK_ToolTipTable_TTT_ID");

            entity.ToTable("ToolTipTable", "de");

            entity.Property(e => e.TttId).HasColumnName("TTT_ID");
            entity.Property(e => e.TttDescription).HasColumnName("TTT_Description");
            entity.Property(e => e.TttLanid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TTT_LANID");
            entity.Property(e => e.TttTblid).HasColumnName("TTT_TBLID");

            entity.HasOne(d => d.TttLan).WithMany(p => p.ToolTipTables)
                .HasForeignKey(d => d.TttLanid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToolTipTable_TTT_LANID__Language_LAN_ID");

            entity.HasOne(d => d.TttTbl).WithMany(p => p.ToolTipTables)
                .HasForeignKey(d => d.TttTblid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToolTipTable_TTT_TBLID__Tables_TBL_ID");
        });

        modelBuilder.Entity<Version>(entity =>
        {
            entity.HasKey(e => e.MvrId).HasName("PK_Version_MVR_ID");

            entity.ToTable("Version", "migrate");

            entity.Property(e => e.MvrId).HasColumnName("MVR_ID");
            entity.Property(e => e.MvrName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MVR_Name");
            entity.Property(e => e.MvrTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("MVR_TSInsert");
        });

        modelBuilder.Entity<WarehouseSchema>(entity =>
        {
            entity.HasKey(e => e.WsId).HasName("PK_WarehouseSchemas_WS_ID");

            entity.Property(e => e.WsId).HasColumnName("WS_ID");
            entity.Property(e => e.WsName)
                .HasMaxLength(50)
                .HasColumnName("WS_Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
