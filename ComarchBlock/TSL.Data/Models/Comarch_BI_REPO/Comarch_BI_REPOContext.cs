using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Comarch_BI_REPOContext : DbContext
{
    public Comarch_BI_REPOContext(DbContextOptions<Comarch_BI_REPOContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountActive> AccountActives { get; set; }

    public virtual DbSet<AccountActiveUser> AccountActiveUsers { get; set; }

    public virtual DbSet<AnalystInterfaceReportLayout> AnalystInterfaceReportLayouts { get; set; }

    public virtual DbSet<ApplicationRight> ApplicationRights { get; set; }

    public virtual DbSet<ApplicationRightsTranslation> ApplicationRightsTranslations { get; set; }

    public virtual DbSet<ApplicationRole> ApplicationRoles { get; set; }

    public virtual DbSet<ApplicationUsersRole> ApplicationUsersRoles { get; set; }

    public virtual DbSet<Budget> Budgets { get; set; }

    public virtual DbSet<BudgetColumn> BudgetColumns { get; set; }

    public virtual DbSet<BudgetColumnMember> BudgetColumnMembers { get; set; }

    public virtual DbSet<BudgetColumnValue> BudgetColumnValues { get; set; }

    public virtual DbSet<BudgetEntry> BudgetEntries { get; set; }

    public virtual DbSet<BudgetEntryComment> BudgetEntryComments { get; set; }

    public virtual DbSet<BudgetMeasure> BudgetMeasures { get; set; }

    public virtual DbSet<BudgetMeasureTranslation> BudgetMeasureTranslations { get; set; }

    public virtual DbSet<BudgetMember> BudgetMembers { get; set; }

    public virtual DbSet<BudgetPendingAction> BudgetPendingActions { get; set; }

    public virtual DbSet<BudgetPendingActionsType> BudgetPendingActionsTypes { get; set; }

    public virtual DbSet<BudgetVersion> BudgetVersions { get; set; }

    public virtual DbSet<BudgetVersionChange> BudgetVersionChanges { get; set; }

    public virtual DbSet<BudgetVersionCubesPermission> BudgetVersionCubesPermissions { get; set; }

    public virtual DbSet<BudgetVersionScheme> BudgetVersionSchemes { get; set; }

    public virtual DbSet<BudgetingStructure> BudgetingStructures { get; set; }

    public virtual DbSet<CompaniesCode> CompaniesCodes { get; set; }

    public virtual DbSet<CompaniesPackage> CompaniesPackages { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Connection> Connections { get; set; }

    public virtual DbSet<Context> Contexts { get; set; }

    public virtual DbSet<ContextTranslation> ContextTranslations { get; set; }

    public virtual DbSet<ContextsAction> ContextsActions { get; set; }

    public virtual DbSet<ContextsMapping> ContextsMappings { get; set; }

    public virtual DbSet<Cube> Cubes { get; set; }

    public virtual DbSet<CubeTranslation> CubeTranslations { get; set; }

    public virtual DbSet<CubesParametersHierarchy> CubesParametersHierarchies { get; set; }

    public virtual DbSet<CubesPermission> CubesPermissions { get; set; }

    public virtual DbSet<DataModel> DataModels { get; set; }

    public virtual DbSet<DataModelsDefinition> DataModelsDefinitions { get; set; }

    public virtual DbSet<DataModelsQueriesParameter> DataModelsQueriesParameters { get; set; }

    public virtual DbSet<DataModelsQuery> DataModelsQueries { get; set; }

    public virtual DbSet<DataModelsSource> DataModelsSources { get; set; }

    public virtual DbSet<DbVersion> DbVersions { get; set; }

    public virtual DbSet<Dimension> Dimensions { get; set; }

    public virtual DbSet<DimensionTranslation> DimensionTranslations { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<Folder> Folders { get; set; }

    public virtual DbSet<FormulaParameter> FormulaParameters { get; set; }

    public virtual DbSet<FtpConnection> FtpConnections { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Group1> Groups1 { get; set; }

    public virtual DbSet<HierarchiesTranslation> HierarchiesTranslations { get; set; }

    public virtual DbSet<Hierarchy> Hierarchies { get; set; }

    public virtual DbSet<Hierarchy1> Hierarchies1 { get; set; }

    public virtual DbSet<HierarchyTranslation> HierarchyTranslations { get; set; }

    public virtual DbSet<Level> Levels { get; set; }

    public virtual DbSet<LevelTranslation> LevelTranslations { get; set; }

    public virtual DbSet<Link> Links { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<MapTranslation> MapTranslations { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MobileAccount> MobileAccounts { get; set; }

    public virtual DbSet<MobileGcmid> MobileGcmids { get; set; }

    public virtual DbSet<MobileReportsSnapshot> MobileReportsSnapshots { get; set; }

    public virtual DbSet<MobileReportsUsersSnapshot> MobileReportsUsersSnapshots { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<OlapServer> OlapServers { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<Parameter> Parameters { get; set; }

    public virtual DbSet<ParametersTranslation> ParametersTranslations { get; set; }

    public virtual DbSet<PendingPayment> PendingPayments { get; set; }

    public virtual DbSet<PendingPaymentElement> PendingPaymentElements { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<PermissionSheet> PermissionSheets { get; set; }

    public virtual DbSet<PermissionsOlapMember> PermissionsOlapMembers { get; set; }

    public virtual DbSet<PromotionCode> PromotionCodes { get; set; }

    public virtual DbSet<PromotionCodesWorkMode> PromotionCodesWorkModes { get; set; }

    public virtual DbSet<RegistrationUserModel> RegistrationUserModels { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportParameter> ReportParameters { get; set; }

    public virtual DbSet<ReportTranslation> ReportTranslations { get; set; }

    public virtual DbSet<ReportsConnection> ReportsConnections { get; set; }

    public virtual DbSet<ReportsDatum> ReportsData { get; set; }

    public virtual DbSet<ReportsImage> ReportsImages { get; set; }

    public virtual DbSet<ReportsStore> ReportsStores { get; set; }

    public virtual DbSet<RestrictRole> RestrictRoles { get; set; }

    public virtual DbSet<RightsFoldersGroup> RightsFoldersGroups { get; set; }

    public virtual DbSet<RightsFoldersUser> RightsFoldersUsers { get; set; }

    public virtual DbSet<RightsReportsGroup> RightsReportsGroups { get; set; }

    public virtual DbSet<RightsReportsUser> RightsReportsUsers { get; set; }

    public virtual DbSet<SegmentationFtpConnection> SegmentationFtpConnections { get; set; }

    public virtual DbSet<SegmentationNode> SegmentationNodes { get; set; }

    public virtual DbSet<SegmentationObject> SegmentationObjects { get; set; }

    public virtual DbSet<SegmentationProcess> SegmentationProcesses { get; set; }

    public virtual DbSet<SegmentationProcessesPlan> SegmentationProcessesPlans { get; set; }

    public virtual DbSet<SegmentationProcessesResult> SegmentationProcessesResults { get; set; }

    public virtual DbSet<SegmentationSchedule> SegmentationSchedules { get; set; }

    public virtual DbSet<SemiramisAction> SemiramisActions { get; set; }

    public virtual DbSet<SemiramisActionsTranslation> SemiramisActionsTranslations { get; set; }

    public virtual DbSet<SemiramisLinkHierarchiesMap> SemiramisLinkHierarchiesMaps { get; set; }

    public virtual DbSet<SemiramisLinkHierarchy> SemiramisLinkHierarchies { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServicesAddress> ServicesAddresses { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<SocialProfile> SocialProfiles { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<SubscriptionsAlert> SubscriptionsAlerts { get; set; }

    public virtual DbSet<SubscriptionsAttachment> SubscriptionsAttachments { get; set; }

    public virtual DbSet<SubscriptionsCredential> SubscriptionsCredentials { get; set; }

    public virtual DbSet<SubscriptionsDescription> SubscriptionsDescriptions { get; set; }

    public virtual DbSet<SubscriptionsExternalUser> SubscriptionsExternalUsers { get; set; }

    public virtual DbSet<SubscriptionsFreeForm> SubscriptionsFreeForms { get; set; }

    public virtual DbSet<SubscriptionsFtpConnection> SubscriptionsFtpConnections { get; set; }

    public virtual DbSet<SubscriptionsParameter> SubscriptionsParameters { get; set; }

    public virtual DbSet<SubscriptionsPhoneUser> SubscriptionsPhoneUsers { get; set; }

    public virtual DbSet<SubscriptionsReport> SubscriptionsReports { get; set; }

    public virtual DbSet<SubscriptionsReportsParameter> SubscriptionsReportsParameters { get; set; }

    public virtual DbSet<SubscriptionsScenario> SubscriptionsScenarios { get; set; }

    public virtual DbSet<SubscriptionsSchedule> SubscriptionsSchedules { get; set; }

    public virtual DbSet<SubscriptionsUser> SubscriptionsUsers { get; set; }

    public virtual DbSet<Synchronization> Synchronizations { get; set; }

    public virtual DbSet<TimeMember> TimeMembers { get; set; }

    public virtual DbSet<TransformationDeleteList> TransformationDeleteLists { get; set; }

    public virtual DbSet<TransformationList> TransformationLists { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<User1> Users1 { get; set; }

    public virtual DbSet<UserDatabase> UserDatabases { get; set; }

    public virtual DbSet<UserFavouritesDimensionMeasure> UserFavouritesDimensionMeasures { get; set; }

    public virtual DbSet<UserFavouritesDimensionMeasureItem> UserFavouritesDimensionMeasureItems { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    public virtual DbSet<UserImage> UserImages { get; set; }

    public virtual DbSet<UserInvitationToCompany> UserInvitationToCompanies { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<UserWorkmodeHomedashboard> UserWorkmodeHomedashboards { get; set; }

    public virtual DbSet<UsersPermissionsOlapMember> UsersPermissionsOlapMembers { get; set; }

    public virtual DbSet<UsersRecentlyUsed> UsersRecentlyUseds { get; set; }

    public virtual DbSet<WorkMode> WorkModes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountActive>(entity =>
        {
            entity.HasKey(e => e.AccId).HasName("PK_AccountActive_ACC_ID");

            entity.ToTable("AccountActive", "RB");

            entity.Property(e => e.AccId)
                .HasDefaultValue(1)
                .HasColumnName("ACC_ID");
            entity.Property(e => e.AccCompanyId).HasColumnName("ACC_CompanyId");
            entity.Property(e => e.AccDateTo)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ACC_DateTo");
            entity.Property(e => e.AccDwisFull)
                .HasDefaultValue(false)
                .HasColumnName("ACC_DWIsFull");
            entity.Property(e => e.AccDwsize)
                .HasDefaultValue(0.0)
                .HasColumnName("ACC_DWSize");
            entity.Property(e => e.AccIsBlocked).HasColumnName("ACC_IsBlocked");
            entity.Property(e => e.AccIsDemo)
                .HasDefaultValue(false)
                .HasColumnName("ACC_IsDemo");
            entity.Property(e => e.AccIsFirstLoginActionDone).HasColumnName("ACC_IsFirstLoginActionDone");
            entity.Property(e => e.AccIsStandardReportsAdded).HasColumnName("ACC_IsStandardReportsAdded");
            entity.Property(e => e.AccModelDefinitionId).HasColumnName("ACC_ModelDefinitionId");
            entity.Property(e => e.AccWorkModeId).HasColumnName("ACC_WorkModeId");

            entity.HasOne(d => d.AccCompany).WithMany(p => p.AccountActives)
                .HasForeignKey(d => d.AccCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountActive_ACC_CompanyId__Companies_COM_ID");

            entity.HasOne(d => d.AccModelDefinition).WithMany(p => p.AccountActives)
                .HasForeignKey(d => d.AccModelDefinitionId)
                .HasConstraintName("FK_AccountActive_ACC_ModelDefinitionId__DataModelsDefinitions_DMD_Id");

            entity.HasOne(d => d.AccWorkMode).WithMany(p => p.AccountActives)
                .HasForeignKey(d => d.AccWorkModeId)
                .HasConstraintName("FK_AccountActive_ACC_WorkModeId__WorkMode_WOR_Id");
        });

        modelBuilder.Entity<AccountActiveUser>(entity =>
        {
            entity.HasKey(e => e.AauId).HasName("PK_AccountActiveUsers_AAU_Id");

            entity.ToTable("AccountActiveUsers", "RB");

            entity.Property(e => e.AauId).HasColumnName("AAU_Id");
            entity.Property(e => e.AauAccountActiveId).HasColumnName("AAU_AccountActiveId");
            entity.Property(e => e.AauUserId).HasColumnName("AAU_UserId");

            entity.HasOne(d => d.AauAccountActive).WithMany(p => p.AccountActiveUsers)
                .HasForeignKey(d => d.AauAccountActiveId)
                .HasConstraintName("FK_AccountActiveUsers_AAU_AccountActiveId__AccountActive_ACC_ID");

            entity.HasOne(d => d.AauUser).WithMany(p => p.AccountActiveUsers)
                .HasForeignKey(d => d.AauUserId)
                .HasConstraintName("FK_AccountActiveUsers_AAU_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<AnalystInterfaceReportLayout>(entity =>
        {
            entity.HasKey(e => e.AilId).HasName("PK_AnalystInterfaceReportLayouts_AIL_Id");

            entity.ToTable("AnalystInterfaceReportLayouts", "RB");

            entity.Property(e => e.AilId).HasColumnName("AIL_Id");
            entity.Property(e => e.AilInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AIL_Inserted");
            entity.Property(e => e.AilReportId).HasColumnName("AIL_ReportId");
            entity.Property(e => e.AilReportLocation).HasColumnName("AIL_ReportLocation");
            entity.Property(e => e.AilSelectedReportDataType).HasColumnName("AIL_SelectedReportDataType");
            entity.Property(e => e.AilUpdated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AIL_Updated");
            entity.Property(e => e.AilUserId).HasColumnName("AIL_UserId");

            entity.HasOne(d => d.AilReport).WithMany(p => p.AnalystInterfaceReportLayouts)
                .HasForeignKey(d => d.AilReportId)
                .HasConstraintName("FK_AnalystInterfaceReportLayouts_AIL_ReportId__Reports_REP_Id");

            entity.HasOne(d => d.AilUser).WithMany(p => p.AnalystInterfaceReportLayouts)
                .HasForeignKey(d => d.AilUserId)
                .HasConstraintName("FK_AnalystInterfaceReportLayouts_AIL_UserId__Users__USR_Id");
        });

        modelBuilder.Entity<ApplicationRight>(entity =>
        {
            entity.HasKey(e => e.AprId).HasName("PK_ApplicationRights_APR_Id");

            entity.ToTable("ApplicationRights", "RB");

            entity.Property(e => e.AprId)
                .ValueGeneratedNever()
                .HasColumnName("APR_Id");
            entity.Property(e => e.AprHide).HasColumnName("APR_Hide");
            entity.Property(e => e.AprName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APR_Name");
        });

        modelBuilder.Entity<ApplicationRightsTranslation>(entity =>
        {
            entity.HasKey(e => e.ArtId).HasName("PK_ApplicationRightsTranslations_ART_Id");

            entity.ToTable("ApplicationRightsTranslations", "RB");

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

            entity.ToTable("ApplicationRoles", "RB");

            entity.Property(e => e.ArlId).HasColumnName("ARL_Id");
            entity.Property(e => e.ArlCompanyId)
                .HasDefaultValue(1)
                .HasColumnName("ARL_CompanyId");
            entity.Property(e => e.ArlName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARL_Name");
            entity.Property(e => e.ArlRoleType).HasColumnName("ARL_RoleType");

            entity.HasOne(d => d.ArlCompany).WithMany(p => p.ApplicationRoles)
                .HasForeignKey(d => d.ArlCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationRoles_ARL_CompanyId__Companies_COM_ID");

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
                        j.ToTable("ApplicationRolesRights", "RB");
                        j.IndexerProperty<int>("ArrRoleId").HasColumnName("ARR_RoleId");
                        j.IndexerProperty<int>("ArrRightId").HasColumnName("ARR_RightId");
                    });
        });

        modelBuilder.Entity<ApplicationUsersRole>(entity =>
        {
            entity.HasKey(e => new { e.AurUserId, e.AurRoleId }).HasName("PK_ApplicationUsersRoles_AUR_UserId_AUR_RoleId");

            entity.ToTable("ApplicationUsersRoles", "RB");

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
                .HasConstraintName("FK_ApplicationUsersRoles_AUR_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<Budget>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Budgets_Id");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Cube).WithMany(p => p.Budgets)
                .HasForeignKey(d => d.CubeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Budgets_CubeId__Cubes_Id");
        });

        modelBuilder.Entity<BudgetColumn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetColumns_Id");

            entity.Property(e => e.BudgetMeasureName).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Precision).HasDefaultValue(2);
            entity.Property(e => e.RowVer).HasDefaultValue(1);
            entity.Property(e => e.Type).HasMaxLength(20);
            entity.Property(e => e.UserId).HasComment("One2Many=false;Many2OneCascade=none;");

            entity.HasOne(d => d.BudgetVersion).WithMany(p => p.BudgetColumns)
                .HasForeignKey(d => d.BudgetVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetColumns_BudgetVersionId__BudgetVersions_Id");

            entity.HasOne(d => d.User).WithMany(p => p.BudgetColumns)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetColumns_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<BudgetColumnMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetColumnMembers_Id");

            entity.Property(e => e.DimensionName).HasMaxLength(100);
            entity.Property(e => e.HierarchyName).HasMaxLength(100);
            entity.Property(e => e.LevelName).HasMaxLength(100);
            entity.Property(e => e.MemberName).HasMaxLength(500);
            entity.Property(e => e.RowVer).HasDefaultValue(1);

            entity.HasOne(d => d.Column).WithMany(p => p.BudgetColumnMembers)
                .HasForeignKey(d => d.ColumnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetColumnMembers_ColumnId__BudgetColumns_Id");
        });

        modelBuilder.Entity<BudgetColumnValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetColumnValues_Id");

            entity.Property(e => e.BudgetMemberId).HasComment("One2Many=false;");
            entity.Property(e => e.RowVer).HasDefaultValue(1);
            entity.Property(e => e.Value).HasColumnType("decimal(20, 5)");

            entity.HasOne(d => d.BudgetMember).WithMany(p => p.BudgetColumnValues)
                .HasForeignKey(d => d.BudgetMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetColumnValues_BudgetMemberId__BudgetMembers_Id");

            entity.HasOne(d => d.Column).WithMany(p => p.BudgetColumnValues)
                .HasForeignKey(d => d.ColumnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetColumnValues_ColumnId__BudgetColumns_Id");
        });

        modelBuilder.Entity<BudgetEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetEntries_Id");

            entity.HasIndex(e => e.BudgetMeasureId, "IX_BudgetEntries_BudgetMeasureId");

            entity.HasIndex(e => e.BudgetMemberId, "IX_BudgetEntries_BudgetMemberId");

            entity.HasIndex(e => e.TimeMemberId, "IX_BudgetEntries_TimeMemberId");

            entity.HasIndex(e => new { e.BudgetVersionId, e.BudgetMeasureId, e.BudgetMemberId }, "fastMemberLoadIndex");

            entity.Property(e => e.BudgetMeasureId).HasComment("");
            entity.Property(e => e.BudgetMemberId).HasComment("");
            entity.Property(e => e.Formula).HasMaxLength(1000);
            entity.Property(e => e.State)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("E")
                .IsFixedLength();
            entity.Property(e => e.TimeMemberId).HasComment("CollectionName=TimeMemberBudgetEntries;");
            entity.Property(e => e.Value).HasColumnType("decimal(20, 9)");

            entity.HasOne(d => d.BudgetMeasure).WithMany(p => p.BudgetEntries)
                .HasForeignKey(d => d.BudgetMeasureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetEntries_BudgetMeasureId__BudgetMeasures_Id");

            entity.HasOne(d => d.BudgetMember).WithMany(p => p.BudgetEntries)
                .HasForeignKey(d => d.BudgetMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetEntries_BudgetMemberId__BudgetMembers_Id");

            entity.HasOne(d => d.BudgetVersion).WithMany(p => p.BudgetEntries)
                .HasForeignKey(d => d.BudgetVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetEntries_BudgetVersionId__BudgetVersions_Id");

            entity.HasOne(d => d.TimeMember).WithMany(p => p.BudgetEntries)
                .HasForeignKey(d => d.TimeMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetEntries_TimeMemberId__TimeMembers_Id");
        });

        modelBuilder.Entity<BudgetEntryComment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK_BudgetEntryComments_CommentId");

            entity.HasIndex(e => e.BudgetEntryId, "BudgetEntryComments_BudgetEntryId_inx");

            entity.HasIndex(e => e.CreatorId, "BudgetEntryComments_CreatorId_inx");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BudgetMeasure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetMeasures_Id");

            entity.Property(e => e.BudgetId).HasComment("One2ManyCascade=all-delete-orphan;");
            entity.Property(e => e.FormatString).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Budget).WithMany(p => p.BudgetMeasures)
                .HasForeignKey(d => d.BudgetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetMeasures_BudgetId__Budgets_Id");

            entity.HasOne(d => d.Cube).WithMany(p => p.BudgetMeasures)
                .HasForeignKey(d => d.CubeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetMeasures_CubeId__Cubes_Id");
        });

        modelBuilder.Entity<BudgetMeasureTranslation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetMeasureTranslations_Id");

            entity.Property(e => e.BudgetMeasureId).HasComment("One2ManyCascade=all-delete-orphan;");
            entity.Property(e => e.Caption).HasMaxLength(100);

            entity.HasOne(d => d.BudgetMeasure).WithMany(p => p.BudgetMeasureTranslations)
                .HasForeignKey(d => d.BudgetMeasureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetMeasureTranslations_BudgetMeasureId__BudgetMeasures_Id");
        });

        modelBuilder.Entity<BudgetMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetMembers_Id");

            entity.HasIndex(e => e.ParentMemberId, "IX_BudgetMembers_ParentMemberId");

            entity.Property(e => e.BudgetId).HasComment("One2ManyCascade=none;");
            entity.Property(e => e.LastDataWarehouseLoad).HasColumnType("datetime");
            entity.Property(e => e.Leaf).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.ParentMemberId).HasComment("One2ManyCascade=none;");

            entity.HasOne(d => d.Budget).WithMany(p => p.BudgetMembers)
                .HasForeignKey(d => d.BudgetId)
                .HasConstraintName("FK_BudgetMembers_BudgetId__Budgets_Id");

            entity.HasOne(d => d.Member).WithMany(p => p.BudgetMembers)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_BudgetMembers_MemberId__Members_Id");

            entity.HasOne(d => d.ParentMember).WithMany(p => p.InverseParentMember)
                .HasForeignKey(d => d.ParentMemberId)
                .HasConstraintName("FK_BudgetMembers_ParentMemberId__BudgetMembers_Id");
        });

        modelBuilder.Entity<BudgetPendingAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetPendingActions_Id");

            entity.Property(e => e.BudgetMemberName).HasMaxLength(100);
            entity.Property(e => e.LastActionDate).HasColumnType("datetime");

            entity.HasOne(d => d.ActionType).WithMany(p => p.BudgetPendingActions)
                .HasForeignKey(d => d.ActionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetPendingActions_ActionTypeId__BudgetPendingActionsTypes_Id");
        });

        modelBuilder.Entity<BudgetPendingActionsType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetPendingActionsTypes_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ActionTypeDescription).HasMaxLength(256);
            entity.Property(e => e.ActionTypeName).HasMaxLength(64);
        });

        modelBuilder.Entity<BudgetVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetVersions_Id");

            entity.Property(e => e.BudgetId).HasComment("One2ManyCascade=all-delete-orphan;One2ManyInverse=true;Many2OneCascade=none;");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreationUserId).HasComment("One2Many=false;Many2OneCascade=none;");
            entity.Property(e => e.ExcelBinaryData).HasColumnType("image");
            entity.Property(e => e.ExcelFileName).HasMaxLength(255);
            entity.Property(e => e.LoadDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.State)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("E")
                .IsFixedLength();

            entity.HasOne(d => d.Budget).WithMany(p => p.BudgetVersions)
                .HasForeignKey(d => d.BudgetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetVersions_BudgetId__Budgets_Id");

            entity.HasOne(d => d.CreationUser).WithMany(p => p.BudgetVersions)
                .HasForeignKey(d => d.CreationUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetVersions_CreationUserId__Users_USR_Id");
        });

        modelBuilder.Entity<BudgetVersionChange>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetVersionChanges_Id");

            entity.HasIndex(e => e.BudgetVersionId, "UQ_BudgetVersionChanges_BudgetVersionId").IsUnique();

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LastLoadDwScenarioName).HasMaxLength(100);
            entity.Property(e => e.State)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("E")
                .IsFixedLength();
            entity.Property(e => e.UserId).HasComment("One2Many=false;");

            entity.HasOne(d => d.BudgetVersion).WithOne(p => p.BudgetVersionChange)
                .HasForeignKey<BudgetVersionChange>(d => d.BudgetVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetVersionChanges_BudgetVersionId__BudgetVersions_Id");

            entity.HasOne(d => d.User).WithMany(p => p.BudgetVersionChanges)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetVersionChanges_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<BudgetVersionCubesPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetVersionsCubesPermissions_Id");

            entity.HasOne(d => d.BudgetVersion).WithMany(p => p.BudgetVersionCubesPermissions)
                .HasForeignKey(d => d.BudgetVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.BudgetVersionsCubesPermissions_BudgetVersionId__BudgetVersions_Id");

            entity.HasOne(d => d.ExcludedCube).WithMany(p => p.BudgetVersionCubesPermissions)
                .HasForeignKey(d => d.ExcludedCubeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.BudgetVersionsCubesPermissions_ExcludedCubeId__Cubes_Id");

            entity.HasOne(d => d.User).WithMany(p => p.BudgetVersionCubesPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetVersionCubesPermissions_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<BudgetVersionScheme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetVersionScheme_Id");

            entity.ToTable("BudgetVersionScheme");

            entity.HasIndex(e => e.Name, "BudgetVersionSchemeName_indx");

            entity.HasIndex(e => e.BudgetVersionId, "BudgetVersionScheme_BudgetVersionId_indx");

            entity.Property(e => e.CreatorId).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Name).HasMaxLength(120);
        });

        modelBuilder.Entity<BudgetingStructure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgettingStructures_Id");

            entity.Property(e => e.BudgetId).HasComment("One2ManyCascade=all-delete-orphan;");

            entity.HasOne(d => d.Budget).WithMany(p => p.BudgetingStructures)
                .HasForeignKey(d => d.BudgetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetingStructures_BudgetId__Budgets_Id");

            entity.HasOne(d => d.Level).WithMany(p => p.BudgetingStructures)
                .HasForeignKey(d => d.LevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetingStructures_LevelId__Levels_Id");
        });

        modelBuilder.Entity<CompaniesCode>(entity =>
        {
            entity.HasKey(e => new { e.CcoCompanyId, e.CcoCodeId }).HasName("PK_CompaniesCodes_CCO_CompanyId_CCO_CodeId");

            entity.ToTable("CompaniesCodes", "RB");

            entity.Property(e => e.CcoCompanyId).HasColumnName("CCO_CompanyId");
            entity.Property(e => e.CcoCodeId).HasColumnName("CCO_CodeId");
            entity.Property(e => e.CcoUseDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CCO_UseDate");

            entity.HasOne(d => d.CcoCode).WithMany(p => p.CompaniesCodes)
                .HasForeignKey(d => d.CcoCodeId)
                .HasConstraintName("FK_CompaniesCodes_CCO_CodeId__PromotionCodes_PCO_Id");

            entity.HasOne(d => d.CcoCompany).WithMany(p => p.CompaniesCodes)
                .HasForeignKey(d => d.CcoCompanyId)
                .HasConstraintName("FK_CompaniesCodes_CCO_CompanyId__Companies_COM_ID");
        });

        modelBuilder.Entity<CompaniesPackage>(entity =>
        {
            entity.HasKey(e => new { e.CopCompanyId, e.CopPackageId }).HasName("PK_CompaniesPackages_COP_CompanyId_COP_PackageId");

            entity.ToTable("CompaniesPackages", "RB");

            entity.Property(e => e.CopCompanyId)
                .ValueGeneratedOnAdd()
                .HasColumnName("COP_CompanyId");
            entity.Property(e => e.CopPackageId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("COP_PackageId");
            entity.Property(e => e.CopMonthTime).HasColumnName("COP_MonthTime");
            entity.Property(e => e.CopNumberExtend).HasColumnName("COP_NumberExtend");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.ComId).HasName("PK_Companies_COM_ID");

            entity.ToTable("Companies", "RB");

            entity.Property(e => e.ComId)
                .ValueGeneratedNever()
                .HasColumnName("COM_ID");
            entity.Property(e => e.ComApartment)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COM_Apartment");
            entity.Property(e => e.ComAppVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COM_App_Version");
            entity.Property(e => e.ComBankAccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COM_BankAccount");
            entity.Property(e => e.ComCity)
                .HasMaxLength(256)
                .HasColumnName("COM_City");
            entity.Property(e => e.ComCompanyOwnerId).HasColumnName("COM_CompanyOwnerID");
            entity.Property(e => e.ComCountry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COM_Country");
            entity.Property(e => e.ComDawClientId).HasColumnName("COM_DawClientId");
            entity.Property(e => e.ComDawContractorId).HasColumnName("COM_DawContractorId");
            entity.Property(e => e.ComDawPin)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("COM_DawPin");
            entity.Property(e => e.ComDawSerialNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COM_DawSerialNumber");
            entity.Property(e => e.ComDwisFull).HasColumnName("COM_DWIsFull");
            entity.Property(e => e.ComDwsize).HasColumnName("COM_DWSize");
            entity.Property(e => e.ComFoundedYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("COM_FoundedYear");
            entity.Property(e => e.ComIsDawVerified)
                .HasDefaultValue(false)
                .HasColumnName("COM_IsDawVerified");
            entity.Property(e => e.ComIsPartner).HasColumnName("COM_IsPartner");
            entity.Property(e => e.ComIsSsoXladded).HasColumnName("COM_IsSsoXLAdded");
            entity.Property(e => e.ComLoadData)
                .HasDefaultValue(true)
                .HasColumnName("COM_Load_Data");
            entity.Property(e => e.ComModelType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("Model.xml")
                .HasColumnName("COM_ModelType");
            entity.Property(e => e.ComName)
                .HasMaxLength(256)
                .HasColumnName("COM_Name");
            entity.Property(e => e.ComNip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COM_Nip");
            entity.Property(e => e.ComNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COM_Number");
            entity.Property(e => e.ComOwnerName)
                .HasMaxLength(150)
                .HasColumnName("COM_OwnerName");
            entity.Property(e => e.ComPartner)
                .HasMaxLength(1024)
                .HasColumnName("COM_Partner");
            entity.Property(e => e.ComPartnerId)
                .HasDefaultValue(0)
                .HasColumnName("COM_PartnerId");
            entity.Property(e => e.ComPostCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COM_PostCode");
            entity.Property(e => e.ComRegon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COM_Regon");
            entity.Property(e => e.ComStreet)
                .HasMaxLength(256)
                .HasColumnName("COM_Street");
            entity.Property(e => e.ComSubdivision).HasColumnName("COM_Subdivision");
            entity.Property(e => e.ComSubdivisionName)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COM_SubdivisionName");
            entity.Property(e => e.ComTel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COM_Tel");
            entity.Property(e => e.ComUpdateApp)
                .HasDefaultValue(false)
                .HasColumnName("COM_Update_App");

            entity.HasOne(d => d.ComCompanyOwner).WithMany(p => p.Companies)
                .HasForeignKey(d => d.ComCompanyOwnerId)
                .HasConstraintName("FK_Companies_COM_CompanyOwnerID__Users_USR_Id");
        });

        modelBuilder.Entity<Connection>(entity =>
        {
            entity.HasKey(e => e.ConId).HasName("PK_Connections_CON_Id");

            entity.ToTable("Connections", "RB");

            entity.Property(e => e.ConId).HasColumnName("CON_Id");
            entity.Property(e => e.ConBitype).HasColumnName("CON_BIType");
            entity.Property(e => e.ConCompanyId)
                .HasDefaultValue(1)
                .HasColumnName("CON_CompanyId");
            entity.Property(e => e.ConCube)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CON_Cube");
            entity.Property(e => e.ConDatabase)
                .HasMaxLength(128)
                .HasColumnName("CON_Database");
            entity.Property(e => e.ConDbType).HasColumnName("CON_DbType");
            entity.Property(e => e.ConIsDefault).HasColumnName("CON_IsDefault");
            entity.Property(e => e.ConIsDefinedInWeb).HasColumnName("CON_IsDefinedInWeb");
            entity.Property(e => e.ConIsDeleted).HasColumnName("CON_IsDeleted");
            entity.Property(e => e.ConIsInMemoryConnection).HasColumnName("CON_IsInMemoryConnection");
            entity.Property(e => e.ConName)
                .HasMaxLength(128)
                .HasColumnName("CON_Name");
            entity.Property(e => e.ConOpenTimeout)
                .HasDefaultValue(-1)
                .HasColumnName("CON_OpenTimeout");
            entity.Property(e => e.ConPassword)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("CON_Password");
            entity.Property(e => e.ConPort)
                .HasDefaultValue(-1)
                .HasColumnName("CON_Port");
            entity.Property(e => e.ConQueryTimeout)
                .HasDefaultValue(-1)
                .HasColumnName("CON_QueryTimeout");
            entity.Property(e => e.ConServer)
                .HasMaxLength(128)
                .HasColumnName("CON_Server");
            entity.Property(e => e.ConUserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CON_UserId");

            entity.HasOne(d => d.ConCompany).WithMany(p => p.Connections)
                .HasForeignKey(d => d.ConCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Connections_CON_CompanyId__Companies_COM_ID");
        });

        modelBuilder.Entity<Context>(entity =>
        {
            entity.HasKey(e => e.CtxId).HasName("PK_Contexts_CTX_Id");

            entity.ToTable("Contexts", "RB");

            entity.Property(e => e.CtxId).HasColumnName("CTX_Id");
            entity.Property(e => e.CtxName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CTX_Name");

            entity.HasMany(d => d.CptParameters).WithMany(p => p.CtpContexts)
                .UsingEntity<Dictionary<string, object>>(
                    "ContextsParameter",
                    r => r.HasOne<Parameter>().WithMany()
                        .HasForeignKey("CptParameterId")
                        .HasConstraintName("FK_ContextsParameters_CPT_ParameterId__Parameters_PAR_Id"),
                    l => l.HasOne<Context>().WithMany()
                        .HasForeignKey("CtpContextId")
                        .HasConstraintName("FK_ContextsParameters_CTP_ContextId__Contexts_CTX_Id"),
                    j =>
                    {
                        j.HasKey("CtpContextId", "CptParameterId").HasName("PK_ContextsParameters_CTP_ContextId_CPT_ParameterId");
                        j.ToTable("ContextsParameters", "RB");
                        j.IndexerProperty<int>("CtpContextId").HasColumnName("CTP_ContextId");
                        j.IndexerProperty<int>("CptParameterId").HasColumnName("CPT_ParameterId");
                    });
        });

        modelBuilder.Entity<ContextTranslation>(entity =>
        {
            entity.HasKey(e => e.CtlId).HasName("PK_ContextTranslations_CTL_Id");

            entity.ToTable("ContextTranslations", "RB");

            entity.Property(e => e.CtlId).HasColumnName("CTL_Id");
            entity.Property(e => e.CtlContextId).HasColumnName("CTL_ContextId");
            entity.Property(e => e.CtlLocaleId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CTL_LocaleId");
            entity.Property(e => e.CtlTranslation)
                .HasMaxLength(50)
                .HasColumnName("CTL_Translation");

            entity.HasOne(d => d.CtlContext).WithMany(p => p.ContextTranslations)
                .HasForeignKey(d => d.CtlContextId)
                .HasConstraintName("FK_ContextTranslations_CTL_ContextId__Contexts_CTX_Id");
        });

        modelBuilder.Entity<ContextsAction>(entity =>
        {
            entity.HasKey(e => e.CtaId).HasName("PK_ContextsActions_CTA_ID");

            entity.ToTable("ContextsActions", "RB");

            entity.Property(e => e.CtaId).HasColumnName("CTA_ID");
            entity.Property(e => e.CtaCube)
                .HasMaxLength(50)
                .HasColumnName("CTA_Cube");
            entity.Property(e => e.CtaName)
                .HasMaxLength(50)
                .HasColumnName("CTA_Name");
            entity.Property(e => e.CtaType).HasColumnName("CTA_Type");
        });

        modelBuilder.Entity<ContextsMapping>(entity =>
        {
            entity.HasKey(e => e.CtmId).HasName("PK_ContextsMappings_CTM_Id");

            entity.ToTable("ContextsMappings", "RB");

            entity.Property(e => e.CtmId).HasColumnName("CTM_Id");
            entity.Property(e => e.CtmContextId).HasColumnName("CTM_ContextId");
            entity.Property(e => e.CtmContextMapping)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CTM_ContextMapping");
            entity.Property(e => e.CtmMappingName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CTM_MappingName");
        });

        modelBuilder.Entity<Cube>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cubes_Id");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OlapServerId).HasComment("One2ManyCascade=all-delete-orphan;");

            entity.HasOne(d => d.OlapServer).WithMany(p => p.Cubes)
                .HasForeignKey(d => d.OlapServerId)
                .HasConstraintName("FK_Cubes_OlapServerId__OlapServers_Id");
        });

        modelBuilder.Entity<CubeTranslation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CubeTranslations_Id");

            entity.Property(e => e.Caption).HasMaxLength(100);
            entity.Property(e => e.CubeId).HasComment("One2ManyCascade=all-delete-orphan;");

            entity.HasOne(d => d.Cube).WithMany(p => p.CubeTranslations)
                .HasForeignKey(d => d.CubeId)
                .HasConstraintName("FK_CubeTranslations_CubeId__Cubes_Id");
        });

        modelBuilder.Entity<CubesParametersHierarchy>(entity =>
        {
            entity.HasKey(e => new { e.CphCubeName, e.CphParameterId, e.CphHierarchyId }).HasName("PK_CubesParametersHierarchies_CPH_CubeName_CPH_ParameterId_CPH_HierarchyId");

            entity.ToTable("CubesParametersHierarchies", "RB");

            entity.Property(e => e.CphCubeName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CPH_CubeName");
            entity.Property(e => e.CphParameterId).HasColumnName("CPH_ParameterId");
            entity.Property(e => e.CphHierarchyId).HasColumnName("CPH_HierarchyId");

            entity.HasOne(d => d.CphHierarchy).WithMany(p => p.CubesParametersHierarchies)
                .HasForeignKey(d => d.CphHierarchyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CubesParametersHierarchies_CPH_HierarchyId__Hierarchies_HRC_Id");

            entity.HasOne(d => d.CphParameter).WithMany(p => p.CubesParametersHierarchies)
                .HasForeignKey(d => d.CphParameterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CubesParametersHierarchies_CPH_ParameterId__Parameters_PAR_Id");
        });

        modelBuilder.Entity<CubesPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CubesPermissions_Id");

            entity.ToTable("CubesPermissions", "RM");

            entity.Property(e => e.CubeName).HasMaxLength(250);
            entity.Property(e => e.DatabaseName).HasMaxLength(250);
            entity.Property(e => e.ServerName).HasMaxLength(250);

            entity.HasOne(d => d.User).WithMany(p => p.CubesPermissions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_CubesPermissions_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<DataModel>(entity =>
        {
            entity.HasKey(e => e.DmoId).HasName("PK_DataModels_DMO_Id");

            entity.ToTable("DataModels", "RB");

            entity.Property(e => e.DmoId).HasColumnName("DMO_Id");
            entity.Property(e => e.DmoDefinitionId).HasColumnName("DMO_DefinitionId");
            entity.Property(e => e.DmoDeployMode).HasColumnName("DMO_DeployMode");
            entity.Property(e => e.DmoDirectQueryMode).HasColumnName("DMO_DirectQueryMode");
            entity.Property(e => e.DmoIsCustomModel)
                .HasDefaultValue(true)
                .HasColumnName("DMO_IsCustomModel");
            entity.Property(e => e.DmoIsMultiCompany).HasColumnName("DMO_IsMultiCompany");
            entity.Property(e => e.DmoModelGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DMO_ModelGuid");
            entity.Property(e => e.DmoModelId).HasColumnName("DMO_ModelId");
            entity.Property(e => e.DmoPermissions).HasColumnName("DMO_Permissions");
            entity.Property(e => e.DmoRefreshTime)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("DMO_RefreshTime");
            entity.Property(e => e.DmoServer).HasColumnName("DMO_Server");
            entity.Property(e => e.DmoServiceId).HasColumnName("DMO_ServiceId");
            entity.Property(e => e.DmoUniqueIdentifier)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DMO_UniqueIdentifier");
            entity.Property(e => e.DmoUseDefaultConnection).HasColumnName("DMO_UseDefaultConnection");

            entity.HasOne(d => d.DmoDefinition).WithMany(p => p.DataModels)
                .HasForeignKey(d => d.DmoDefinitionId)
                .HasConstraintName("FK_DataModels_DMO_DefinitionId__DataModelsDefinitions_DMD_Id");

            entity.HasOne(d => d.DmoServerNavigation).WithMany(p => p.DataModels)
                .HasForeignKey(d => d.DmoServer)
                .HasConstraintName("FK_DataModels_DMO_Server__Connections_CON_Id");

            entity.HasMany(d => d.CdmCompanies).WithMany(p => p.CdmDataModels)
                .UsingEntity<Dictionary<string, object>>(
                    "CompaniesDataModel",
                    r => r.HasOne<Company>().WithMany()
                        .HasForeignKey("CdmCompanyId")
                        .HasConstraintName("FK_CompaniesDataModels_CDM_CompanyId__Companies_COM_ID"),
                    l => l.HasOne<DataModel>().WithMany()
                        .HasForeignKey("CdmDataModelId")
                        .HasConstraintName("FK_CompaniesDataModels_CDM_DataModelId__DataModels_DMO_Id"),
                    j =>
                    {
                        j.HasKey("CdmDataModelId", "CdmCompanyId").HasName("PK_CompaniesDataModels_CDM_DataModelId_CDM_CompanyId");
                        j.ToTable("CompaniesDataModels", "RB");
                        j.IndexerProperty<int>("CdmDataModelId").HasColumnName("CDM_DataModelId");
                        j.IndexerProperty<int>("CdmCompanyId").HasColumnName("CDM_CompanyId");
                    });

            entity.HasMany(d => d.DmfFs).WithMany(p => p.DmfDms)
                .UsingEntity<Dictionary<string, object>>(
                    "DataModelsFile",
                    r => r.HasOne<File>().WithMany()
                        .HasForeignKey("DmfFid")
                        .HasConstraintName("FK_DataModelsFiles_DMF_FID__Files_File_Id"),
                    l => l.HasOne<DataModel>().WithMany()
                        .HasForeignKey("DmfDmid")
                        .HasConstraintName("FK_DataModelsFiles_DMF_DMID__DataModels_DMO_Id"),
                    j =>
                    {
                        j.HasKey("DmfDmid", "DmfFid").HasName("PK_DataModelsFiles_DMF_DMID_DMF_FID");
                        j.ToTable("DataModelsFiles", "RB");
                        j.IndexerProperty<int>("DmfDmid").HasColumnName("DMF_DMID");
                        j.IndexerProperty<int>("DmfFid").HasColumnName("DMF_FID");
                    });

            entity.HasMany(d => d.DmrReps).WithMany(p => p.DmrDms)
                .UsingEntity<Dictionary<string, object>>(
                    "DataModelsReport",
                    r => r.HasOne<Report>().WithMany()
                        .HasForeignKey("DmrRepid")
                        .HasConstraintName("FK_DataModelsReports_DMR_REPID__Reports_REP_Id"),
                    l => l.HasOne<DataModel>().WithMany()
                        .HasForeignKey("DmrDmid")
                        .HasConstraintName("FK_DataModelsReports_DMR_DMID__DataModels_DMO_Id"),
                    j =>
                    {
                        j.HasKey("DmrDmid", "DmrRepid").HasName("PK_DataModelsReports_DMR_DMID_DMR_REPID");
                        j.ToTable("DataModelsReports", "RB");
                        j.IndexerProperty<int>("DmrDmid").HasColumnName("DMR_DMID");
                        j.IndexerProperty<int>("DmrRepid").HasColumnName("DMR_REPID");
                    });
        });

        modelBuilder.Entity<DataModelsDefinition>(entity =>
        {
            entity.HasKey(e => e.DmdId).HasName("PK_DataModelsDefinitions_DMD_Id");

            entity.ToTable("DataModelsDefinitions", "RB");

            entity.Property(e => e.DmdId).HasColumnName("DMD_Id");
            entity.Property(e => e.DmdDefinition).HasColumnName("DMD_Definition");
            entity.Property(e => e.DmdName).HasColumnName("DMD_Name");
        });

        modelBuilder.Entity<DataModelsQueriesParameter>(entity =>
        {
            entity.HasKey(e => e.DmqpId).HasName("PK_DataModelsQueriesParameters_DMQP_Id");

            entity.ToTable("DataModelsQueriesParameters", "RB");

            entity.Property(e => e.DmqpId).HasColumnName("DMQP_Id");
            entity.Property(e => e.DmqpDefinition)
                .HasColumnType("ntext")
                .HasColumnName("DMQP_Definition");
            entity.Property(e => e.DmqpName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("DMQP_Name");
            entity.Property(e => e.DmqpQueryId).HasColumnName("DMQP_QueryId");
            entity.Property(e => e.DmqpType).HasColumnName("DMQP_Type");

            entity.HasOne(d => d.DmqpQuery).WithMany(p => p.DataModelsQueriesParameters)
                .HasForeignKey(d => d.DmqpQueryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataModelsQueriesParameters_DMQP_QueryId__DataModelsQueries_DMQ_Id");
        });

        modelBuilder.Entity<DataModelsQuery>(entity =>
        {
            entity.HasKey(e => e.DmqId).HasName("PK_DataModelsQueries_DMQ_Id");

            entity.ToTable("DataModelsQueries", "RB");

            entity.Property(e => e.DmqId).HasColumnName("DMQ_Id");
            entity.Property(e => e.DmqModelId).HasColumnName("DMQ_ModelId");
            entity.Property(e => e.DmqQuery)
                .HasColumnType("text")
                .HasColumnName("DMQ_Query");
            entity.Property(e => e.DmqType).HasColumnName("DMQ_Type");

            entity.HasOne(d => d.DmqModel).WithMany(p => p.DataModelsQueries)
                .HasForeignKey(d => d.DmqModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataModelsQueries_DMQ_ModelId__DataModels_DMO_Id");
        });

        modelBuilder.Entity<DataModelsSource>(entity =>
        {
            entity.HasKey(e => new { e.DsoModelId, e.DsoConnectionId }).HasName("PK_DataModelsSources_DSO_ModelId_DSO_ConnectionId");

            entity.ToTable("DataModelsSources", "RB");

            entity.Property(e => e.DsoModelId).HasColumnName("DSO_ModelId");
            entity.Property(e => e.DsoConnectionId).HasColumnName("DSO_ConnectionId");
        });

        modelBuilder.Entity<DbVersion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DbVersion", "repo");

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

        modelBuilder.Entity<Dimension>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Dimensions_Id");

            entity.Property(e => e.CubeId).HasComment("One2ManyCascade=all-delete-orphan;");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Cube).WithMany(p => p.Dimensions)
                .HasForeignKey(d => d.CubeId)
                .HasConstraintName("FK_Dimensions_CubeId__Cubes_Id");
        });

        modelBuilder.Entity<DimensionTranslation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DimensionTranslations_Id");

            entity.Property(e => e.Caption).HasMaxLength(100);
            entity.Property(e => e.DimensionId).HasComment("One2ManyCascade=all-delete-orphan;");

            entity.HasOne(d => d.Dimension).WithMany(p => p.DimensionTranslations)
                .HasForeignKey(d => d.DimensionId)
                .HasConstraintName("FK_DimensionTranslations_DimensionId__Dimensions_Id");
        });

        modelBuilder.Entity<File>(entity =>
        {
            entity.HasKey(e => e.FileId).HasName("PK_Files_File_Id");

            entity.ToTable("Files", "RB");

            entity.Property(e => e.FileId).HasColumnName("File_Id");
            entity.Property(e => e.FileExtension).HasColumnName("File_Extension");
            entity.Property(e => e.FileGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("File_Guid");
            entity.Property(e => e.FilePath)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("File_Path");
        });

        modelBuilder.Entity<Folder>(entity =>
        {
            entity.HasKey(e => e.FolId).HasName("PK_Folders_FOL_Id");

            entity.ToTable("Folders", "RB");

            entity.Property(e => e.FolId).HasColumnName("FOL_Id");
            entity.Property(e => e.FolCompanyId)
                .HasDefaultValue(1)
                .HasColumnName("FOL_CompanyId");
            entity.Property(e => e.FolCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("FOL_CreatedOn");
            entity.Property(e => e.FolModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("FOL_ModifiedOn");
            entity.Property(e => e.FolName)
                .HasMaxLength(128)
                .HasColumnName("FOL_Name");
            entity.Property(e => e.FolOwnerId).HasColumnName("FOL_OwnerId");
            entity.Property(e => e.FolParentId).HasColumnName("FOL_ParentId");
            entity.Property(e => e.FolType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("c")
                .HasColumnName("FOL_Type");

            entity.HasOne(d => d.FolCompany).WithMany(p => p.Folders)
                .HasForeignKey(d => d.FolCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Folders_FOL_CompanyId__Companies_COM_ID");

            entity.HasOne(d => d.FolParent).WithMany(p => p.InverseFolParent)
                .HasForeignKey(d => d.FolParentId)
                .HasConstraintName("FK_Folders_FOL_ParentId__Folders_FOL_Id");
        });

        modelBuilder.Entity<FormulaParameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FormulaParameters_Id");

            entity.HasIndex(e => e.Name, "UQ_FormulaParameters_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Precision).HasColumnType("decimal(2, 0)");
            entity.Property(e => e.RangeFrom).HasColumnType("decimal(20, 9)");
            entity.Property(e => e.RangeTo).HasColumnType("decimal(20, 9)");
            entity.Property(e => e.Step).HasColumnType("decimal(20, 9)");
            entity.Property(e => e.UserId).HasComment("One2Many=false;");
            entity.Property(e => e.Value).HasColumnType("decimal(20, 9)");

            entity.HasOne(d => d.User).WithMany(p => p.FormulaParameters)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormulaParameters_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<FtpConnection>(entity =>
        {
            entity.HasKey(e => e.FcId).HasName("PK_FtpConnections_FC_Id");

            entity.ToTable("FtpConnections", "RB");

            entity.Property(e => e.FcId).HasColumnName("FC_Id");
            entity.Property(e => e.FcAddress).HasColumnName("FC_Address");
            entity.Property(e => e.FcConnectionName)
                .HasMaxLength(256)
                .HasColumnName("FC_ConnectionName");
            entity.Property(e => e.FcIsDefaultFtpConnection).HasColumnName("FC_IsDefaultFtpConnection");
            entity.Property(e => e.FcIsPredefinedConnection).HasColumnName("FC_IsPredefinedConnection");
            entity.Property(e => e.FcLogin)
                .HasMaxLength(256)
                .HasColumnName("FC_Login");
            entity.Property(e => e.FcPassword)
                .HasMaxLength(256)
                .HasColumnName("FC_Password");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Groups_Id");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Group1>(entity =>
        {
            entity.HasKey(e => e.GrpId).HasName("PK_Groups_GRP_Id");

            entity.ToTable("Groups", "RB");

            entity.Property(e => e.GrpId).HasColumnName("GRP_Id");
            entity.Property(e => e.GrpCompanyId)
                .HasDefaultValue(1)
                .HasColumnName("GRP_CompanyId");
            entity.Property(e => e.GrpGroupType).HasColumnName("GRP_GroupType");
            entity.Property(e => e.GrpName)
                .HasMaxLength(128)
                .HasColumnName("GRP_Name");
            entity.Property(e => e.GrpOwnerId).HasColumnName("GRP_OwnerId");

            entity.HasOne(d => d.GrpCompany).WithMany(p => p.Group1s)
                .HasForeignKey(d => d.GrpCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Groups_GRP_CompanyId__Companies_COM_ID");

            entity.HasMany(d => d.AgrRoles).WithMany(p => p.AgrGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "ApplicationGroupsRole",
                    r => r.HasOne<ApplicationRole>().WithMany()
                        .HasForeignKey("AgrRoleId")
                        .HasConstraintName("FK_ApplicationGroupsRoles_AGR_RoleId__ApplicationRoles_ARL_Id"),
                    l => l.HasOne<Group1>().WithMany()
                        .HasForeignKey("AgrGroupId")
                        .HasConstraintName("FK_ApplicationGroupsRoles_AGR_GroupId__Groups_GRP_Id"),
                    j =>
                    {
                        j.HasKey("AgrGroupId", "AgrRoleId").HasName("PK_ApplicationGroupsRoles_AGR_GroupId_AGR_RoleId");
                        j.ToTable("ApplicationGroupsRoles", "RB");
                        j.IndexerProperty<int>("AgrGroupId").HasColumnName("AGR_GroupId");
                        j.IndexerProperty<int>("AgrRoleId").HasColumnName("AGR_RoleId");
                    });

            entity.HasMany(d => d.GruUsers).WithMany(p => p.GruGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "GroupsUser",
                    r => r.HasOne<User1>().WithMany()
                        .HasForeignKey("GruUserId")
                        .HasConstraintName("FK_GroupsUsers_GRU_UserId__Users_USR_Id"),
                    l => l.HasOne<Group1>().WithMany()
                        .HasForeignKey("GruGroupId")
                        .HasConstraintName("FK_GroupsUsers_GRU_GroupId__Groups_GRP_Id"),
                    j =>
                    {
                        j.HasKey("GruGroupId", "GruUserId").HasName("PK_GroupsUsers_GRU_GroupId_GRU_UserId");
                        j.ToTable("GroupsUsers", "RB");
                        j.IndexerProperty<int>("GruGroupId").HasColumnName("GRU_GroupId");
                        j.IndexerProperty<int>("GruUserId").HasColumnName("GRU_UserId");
                    });

            entity.HasMany(d => d.RgrRoles).WithMany(p => p.RgrGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "RestrictGroupsRole",
                    r => r.HasOne<RestrictRole>().WithMany()
                        .HasForeignKey("RgrRoleId")
                        .HasConstraintName("FK_RestrictGroupsRoles_RGR_RoleId__RestrictRoles_RRL_Id"),
                    l => l.HasOne<Group1>().WithMany()
                        .HasForeignKey("RgrGroupId")
                        .HasConstraintName("FK_RestrictGroupsRoles_RGR_GroupId__Groups_GRP_Id"),
                    j =>
                    {
                        j.HasKey("RgrGroupId", "RgrRoleId").HasName("PK_RestrictGroupsRoles_RGR_GroupId_RGR_RoleId");
                        j.ToTable("RestrictGroupsRoles", "RB");
                        j.IndexerProperty<int>("RgrGroupId").HasColumnName("RGR_GroupId");
                        j.IndexerProperty<int>("RgrRoleId").HasColumnName("RGR_RoleId");
                    });
        });

        modelBuilder.Entity<HierarchiesTranslation>(entity =>
        {
            entity.HasKey(e => e.HtlId).HasName("PK_HierarchiesTranslations_HTL_Id");

            entity.ToTable("HierarchiesTranslations", "RB");

            entity.Property(e => e.HtlId).HasColumnName("HTL_Id");
            entity.Property(e => e.HtlHierarchyId).HasColumnName("HTL_HierarchyId");
            entity.Property(e => e.HtlLocaleId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("HTL_LocaleId");
            entity.Property(e => e.HtlTranslation)
                .HasMaxLength(100)
                .HasColumnName("HTL_Translation");

            entity.HasOne(d => d.HtlHierarchy).WithMany(p => p.HierarchiesTranslations)
                .HasForeignKey(d => d.HtlHierarchyId)
                .HasConstraintName("FK_HierarchiesTranslations_HTL_HierarchyId__Hierarchies_HRC_Id");
        });

        modelBuilder.Entity<Hierarchy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Hierarchies_Id");

            entity.Property(e => e.DimensionId).HasComment("One2ManyCascade=all-delete-orphan;");
            entity.Property(e => e.HierarchyOrigin).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Dimension).WithMany(p => p.Hierarchies)
                .HasForeignKey(d => d.DimensionId)
                .HasConstraintName("FK_Hierarchies_DimensionId__Dimensions_Id");
        });

        modelBuilder.Entity<Hierarchy1>(entity =>
        {
            entity.HasKey(e => e.HrcId).HasName("PK_Hierarchies_HRC_Id");

            entity.ToTable("Hierarchies", "RB");

            entity.Property(e => e.HrcId).HasColumnName("HRC_Id");
            entity.Property(e => e.HrcBusinessType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("HRC_BusinessType");
            entity.Property(e => e.HrcName)
                .HasMaxLength(255)
                .HasColumnName("HRC_Name");
        });

        modelBuilder.Entity<HierarchyTranslation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HierarchyTranslations_Id");

            entity.Property(e => e.Caption).HasMaxLength(100);
            entity.Property(e => e.HierarchyId).HasComment("One2ManyCascade=all-delete-orphan;");

            entity.HasOne(d => d.Hierarchy).WithMany(p => p.HierarchyTranslations)
                .HasForeignKey(d => d.HierarchyId)
                .HasConstraintName("FK_HierarchyTranslations_HierarchyId__Hierarchies_Id");
        });

        modelBuilder.Entity<Level>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Levels_Id");

            entity.Property(e => e.Id).HasComment("");
            entity.Property(e => e.HierarchyId).HasComment("One2ManyCascade=all-delete-orphan;");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(30);

            entity.HasOne(d => d.Hierarchy).WithMany(p => p.Levels)
                .HasForeignKey(d => d.HierarchyId)
                .HasConstraintName("FK_Levels_HierarchyId__Hierarchies_Id");
        });

        modelBuilder.Entity<LevelTranslation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LevelTranslations_Id");

            entity.Property(e => e.Caption).HasMaxLength(100);
            entity.Property(e => e.LevelId).HasComment("One2ManyCascade=all-delete-orphan;");

            entity.HasOne(d => d.Level).WithMany(p => p.LevelTranslations)
                .HasForeignKey(d => d.LevelId)
                .HasConstraintName("FK_LevelTranslations_LevelId__Levels_Id");
        });

        modelBuilder.Entity<Link>(entity =>
        {
            entity.HasKey(e => new { e.LinReportId, e.LinFolderId }).HasName("PK_Links_LIN_ReportId_LIN_FolderId");

            entity.ToTable("Links", "RB");

            entity.Property(e => e.LinReportId).HasColumnName("LIN_ReportId");
            entity.Property(e => e.LinFolderId).HasColumnName("LIN_FolderId");
            entity.Property(e => e.LinCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("LIN_CreatedOn");
            entity.Property(e => e.LinIsMainLink).HasColumnName("LIN_IsMainLink");
            entity.Property(e => e.LinModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("LIN_ModifiedOn");
            entity.Property(e => e.LinName)
                .HasMaxLength(128)
                .HasColumnName("LIN_Name");

            entity.HasOne(d => d.LinFolder).WithMany(p => p.Links)
                .HasForeignKey(d => d.LinFolderId)
                .HasConstraintName("FK_Links_LIN_FolderId__Folders_FOL_Id");

            entity.HasOne(d => d.LinReport).WithMany(p => p.Links)
                .HasForeignKey(d => d.LinReportId)
                .HasConstraintName("FK_Links_LIN_ReportId__Reports_REP_Id");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK_Log_LOG_Id");

            entity.ToTable("Log", "RB");

            entity.Property(e => e.LogId).HasColumnName("LOG_Id");
            entity.Property(e => e.LogEventData)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("LOG_EventData");
            entity.Property(e => e.LogEventDateTime)
                .HasColumnType("datetime")
                .HasColumnName("LOG_EventDateTime");
            entity.Property(e => e.LogEventType).HasColumnName("LOG_EventType");
            entity.Property(e => e.LogObjectId).HasColumnName("LOG_ObjectId");
            entity.Property(e => e.LogUserId).HasColumnName("LOG_UserId");
        });

        modelBuilder.Entity<MapTranslation>(entity =>
        {
            entity.HasKey(e => e.MtCode).HasName("PK_MapTranslations_MT_Code");

            entity.ToTable("MapTranslations", "RB");

            entity.Property(e => e.MtCode)
                .HasMaxLength(2)
                .HasColumnName("MT_Code");
            entity.Property(e => e.MtDe)
                .HasMaxLength(100)
                .HasColumnName("MT_DE");
            entity.Property(e => e.MtEn)
                .HasMaxLength(100)
                .HasColumnName("MT_EN");
            entity.Property(e => e.MtEs)
                .HasMaxLength(100)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("MT_ES");
            entity.Property(e => e.MtFr)
                .HasMaxLength(100)
                .HasColumnName("MT_FR");
            entity.Property(e => e.MtPl)
                .HasMaxLength(100)
                .HasColumnName("MT_PL");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Members_Id");

            entity.HasIndex(e => e.LevelId, "IX_Members_LevelId");

            entity.Property(e => e.Caption)
                .HasMaxLength(500)
                .HasDefaultValue(" ");
            entity.Property(e => e.LevelId).HasComment("One2ManyCascade=all-delete-orphan;");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.OrgId)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Level).WithMany(p => p.Members)
                .HasForeignKey(d => d.LevelId)
                .HasConstraintName("FK_Members_LevelId__Levels_Id");
        });

        modelBuilder.Entity<MobileAccount>(entity =>
        {
            entity.HasKey(e => e.MacId).HasName("PK_MobileAccounts_MAC_Id");

            entity.ToTable("MobileAccounts", "RB");

            entity.Property(e => e.MacId).HasColumnName("MAC_Id");
            entity.Property(e => e.MacAccount)
                .HasMaxLength(255)
                .HasColumnName("MAC_Account");
            entity.Property(e => e.MacUserId).HasColumnName("MAC_UserId");

            entity.HasOne(d => d.MacUser).WithMany(p => p.MobileAccounts)
                .HasForeignKey(d => d.MacUserId)
                .HasConstraintName("FK_MobileAccounts_MAC_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<MobileGcmid>(entity =>
        {
            entity.HasKey(e => new { e.MgiAccountId, e.MgiGcmid }).HasName("PK_MobileGCMIds_MGI_AccountId_MGI_GCMId");

            entity.ToTable("MobileGCMIds", "RB");

            entity.Property(e => e.MgiAccountId).HasColumnName("MGI_AccountId");
            entity.Property(e => e.MgiGcmid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MGI_GCMId");

            entity.HasOne(d => d.MgiAccount).WithMany(p => p.MobileGcmids)
                .HasForeignKey(d => d.MgiAccountId)
                .HasConstraintName("FK_MobileGCMIds_MGI_AccountId__MobileAccounts_MAC_Id");
        });

        modelBuilder.Entity<MobileReportsSnapshot>(entity =>
        {
            entity.HasKey(e => e.MrsId).HasName("PK_MobileReportsSnapshots_MRS_Id");

            entity.ToTable("MobileReportsSnapshots", "RB");

            entity.Property(e => e.MrsId).HasColumnName("MRS_Id");
            entity.Property(e => e.MrsColumns)
                .IsUnicode(false)
                .HasColumnName("MRS_Columns");
            entity.Property(e => e.MrsCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("MRS_CreatedOn");
            entity.Property(e => e.MrsLayout)
                .IsUnicode(false)
                .HasColumnName("MRS_Layout");
            entity.Property(e => e.MrsSnapshot).HasColumnName("MRS_Snapshot");
            entity.Property(e => e.MrsSnapshotSize).HasColumnName("MRS_SnapshotSize");
        });

        modelBuilder.Entity<MobileReportsUsersSnapshot>(entity =>
        {
            entity.HasKey(e => new { e.RusReportId, e.RusUserId, e.RusSnapshotId }).HasName("PK_MobileReportsUsersSnapshots_RUS_ReportId_RUS_UserId_RUS_SnapshotId");

            entity.ToTable("MobileReportsUsersSnapshots", "RB", tb => tb.HasTrigger("MobileReportsUsersDelete"));

            entity.Property(e => e.RusReportId).HasColumnName("RUS_ReportId");
            entity.Property(e => e.RusUserId).HasColumnName("RUS_UserId");
            entity.Property(e => e.RusSnapshotId).HasColumnName("RUS_SnapshotId");

            entity.HasOne(d => d.RusReport).WithMany(p => p.MobileReportsUsersSnapshots)
                .HasForeignKey(d => d.RusReportId)
                .HasConstraintName("FK_MobileReportsUsersSnapshots_RUS_ReportId__Reports_REP_Id");

            entity.HasOne(d => d.RusSnapshot).WithMany(p => p.MobileReportsUsersSnapshots)
                .HasForeignKey(d => d.RusSnapshotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MobileReportsUsersSnapshots_RUS_SnapshotId__MobileReportsSnapshots_MRS_Id");

            entity.HasOne(d => d.RusUser).WithMany(p => p.MobileReportsUsersSnapshots)
                .HasForeignKey(d => d.RusUserId)
                .HasConstraintName("FK_MobileReportsUsersSnapshots_RUS_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.ModId).HasName("PK_Modules_MOD_ID");

            entity.ToTable("Modules", "RB");

            entity.Property(e => e.ModId)
                .ValueGeneratedNever()
                .HasColumnName("MOD_ID");
            entity.Property(e => e.ModInternalName)
                .HasColumnType("text")
                .HasColumnName("MOD_InternalName");
            entity.Property(e => e.ModName)
                .HasColumnType("text")
                .HasColumnName("MOD_Name");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotId).HasName("PK_Notifications_NOT_Id");

            entity.ToTable("Notifications", "RB");

            entity.Property(e => e.NotId).HasColumnName("NOT_Id");
            entity.Property(e => e.NotCookieInterval).HasColumnName("NOT_CookieInterval");
            entity.Property(e => e.NotDateFrom)
                .HasColumnType("datetime")
                .HasColumnName("NOT_DateFrom");
            entity.Property(e => e.NotDateTo)
                .HasColumnType("datetime")
                .HasColumnName("NOT_DateTo");
            entity.Property(e => e.NotDescriptionDe)
                .HasColumnType("text")
                .HasColumnName("NOT_DescriptionDE");
            entity.Property(e => e.NotDescriptionEn)
                .HasColumnType("text")
                .HasColumnName("NOT_DescriptionEN");
            entity.Property(e => e.NotDescriptionFr)
                .HasColumnType("text")
                .HasColumnName("NOT_DescriptionFR");
            entity.Property(e => e.NotDescriptionPl)
                .HasColumnType("text")
                .HasColumnName("NOT_DescriptionPL");
            entity.Property(e => e.NotHidePath)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("NOT_HidePath");
            entity.Property(e => e.NotShowPath)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("NOT_ShowPath");
            entity.Property(e => e.NotType).HasColumnName("NOT_Type");
            entity.Property(e => e.NotWorkMode).HasColumnName("NOT_WorkMode");
        });

        modelBuilder.Entity<OlapServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OlapServers_Id");

            entity.Property(e => e.DatabaseName).HasMaxLength(250);
            entity.Property(e => e.ServerName).HasMaxLength(250);
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.PkgId).HasName("PK_Packages_PKG_Id");

            entity.ToTable("Packages", "RB");

            entity.Property(e => e.PkgId).HasColumnName("PKG_Id");
            entity.Property(e => e.PkgAnnualPrice)
                .HasDefaultValue(0.0)
                .HasColumnName("PKG_AnnualPrice");
            entity.Property(e => e.PkgAnnualPriceEur).HasColumnName("PKG_AnnualPriceEur");
            entity.Property(e => e.PkgDbspace).HasColumnName("PKG_DBSpace");
            entity.Property(e => e.PkgIsExtend).HasColumnName("PKG_IsExtend");
            entity.Property(e => e.PkgMaxDashboard).HasColumnName("PKG_MaxDashboard");
            entity.Property(e => e.PkgMaxReport).HasColumnName("PKG_MaxReport");
            entity.Property(e => e.PkgName)
                .HasMaxLength(128)
                .HasColumnName("PKG_Name");
            entity.Property(e => e.PkgPrice).HasColumnName("PKG_Price");
            entity.Property(e => e.PkgPriceEur).HasColumnName("PKG_PriceEur");
            entity.Property(e => e.PkgUserCount).HasColumnName("PKG_UserCount");
            entity.Property(e => e.PkgWorkModeId).HasColumnName("PKG_WorkModeId");
            entity.Property(e => e.PkgXlId).HasColumnName("PKG_XlId");
        });

        modelBuilder.Entity<Parameter>(entity =>
        {
            entity.HasKey(e => e.ParId).HasName("PK_Parameters_PAR_Id");

            entity.ToTable("Parameters", "RB");

            entity.Property(e => e.ParId).HasColumnName("PAR_Id");
            entity.Property(e => e.ParName)
                .HasMaxLength(256)
                .HasColumnName("PAR_Name");
        });

        modelBuilder.Entity<ParametersTranslation>(entity =>
        {
            entity.HasKey(e => e.PtlId).HasName("PK_ParametersTranslations_PTL_Id");

            entity.ToTable("ParametersTranslations", "RB");

            entity.Property(e => e.PtlId).HasColumnName("PTL_Id");
            entity.Property(e => e.PtlLocaleId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("PTL_LocaleId");
            entity.Property(e => e.PtlParameterId).HasColumnName("PTL_ParameterId");
            entity.Property(e => e.PtlTranslation)
                .HasMaxLength(50)
                .HasColumnName("PTL_Translation");

            entity.HasOne(d => d.PtlParameter).WithMany(p => p.ParametersTranslations)
                .HasForeignKey(d => d.PtlParameterId)
                .HasConstraintName("FK_ParametersTranslations_PTL_ParameterId__Parameters_PAR_Id");
        });

        modelBuilder.Entity<PendingPayment>(entity =>
        {
            entity.HasKey(e => e.PpaId).HasName("PK_PendingPayment_PPA_Id");

            entity.ToTable("PendingPayment", "RB");

            entity.Property(e => e.PpaId).HasColumnName("PPA_Id");
            entity.Property(e => e.PpaComapnyId).HasColumnName("PPA_ComapnyId");
            entity.Property(e => e.PpaCurrency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("PLN")
                .HasColumnName("PPA_Currency");
            entity.Property(e => e.PpaDotPayOperationNumber)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("PPA_DotPayOperationNumber");
            entity.Property(e => e.PpaGuid)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("PPA_Guid");
            entity.Property(e => e.PpaMonthTime).HasColumnName("PPA_MonthTime");
            entity.Property(e => e.PpaNumberExtend).HasColumnName("PPA_NumberExtend");
            entity.Property(e => e.PpaPackageId).HasColumnName("PPA_PackageId");
            entity.Property(e => e.PpaPurchaseAmount)
                .HasDefaultValue(0.0)
                .HasColumnName("PPA_PurchaseAmount");
            entity.Property(e => e.PpaPurchaseDate)
                .HasColumnType("datetime")
                .HasColumnName("PPA_PurchaseDate");
            entity.Property(e => e.PpaStatus).HasColumnName("PPA_Status");
        });

        modelBuilder.Entity<PendingPaymentElement>(entity =>
        {
            entity.HasKey(e => e.PppId).HasName("PK_PendingPaymentElements_PPP_Id");

            entity.ToTable("PendingPaymentElements", "RB");

            entity.Property(e => e.PppId).HasColumnName("PPP_Id");
            entity.Property(e => e.PppDiscount).HasColumnName("PPP_Discount");
            entity.Property(e => e.PppPendingPaymentId).HasColumnName("PPP_PendingPaymentId");
            entity.Property(e => e.PppPrice).HasColumnName("PPP_Price");
            entity.Property(e => e.PppQuantity).HasColumnName("PPP_Quantity");

            entity.HasOne(d => d.PppPendingPayment).WithMany(p => p.PendingPaymentElements)
                .HasForeignKey(d => d.PppPendingPaymentId)
                .HasConstraintName("FK_PendingPaymentElements_PPP_PendingPaymentId__PendingPayment__PPA_Id");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Permissions_Id");

            entity.Property(e => e.Id).HasComment("One2ManyCascade=all-delete-orphan;");
            entity.Property(e => e.BudgetMeasureId).HasComment("One2ManyInverse=true;Many2OneCascade=none;");
            entity.Property(e => e.BudgetMemberId).HasComment("One2ManyInverse=true;Many2OneCascade=none;");
            entity.Property(e => e.BudgetVersionId).HasComment("One2ManyCascade=all-delete-orphan; One2ManyInverse=true; Many2OneCascade=none;");
            entity.Property(e => e.UserGroupId).HasComment("Many2OneCascade=none;");
            entity.Property(e => e.UserId).HasComment("One2ManyInverse=true;Many2OneCascade = save-update;");

            entity.HasOne(d => d.BudgetMeasure).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.BudgetMeasureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Permissions_BudgetMeasureId__BudgetMeasures_Id");

            entity.HasOne(d => d.BudgetMember).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.BudgetMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Permissions_BudgetMemberId__BudgetMembers_Id");

            entity.HasOne(d => d.BudgetVersion).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.BudgetVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Permissions_BudgetVersionId__BudgetVersions_Id");

            entity.HasOne(d => d.UserGroup).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.UserGroupId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Permissions_UserGroupId__Groups_GRP_Id");

            entity.HasOne(d => d.User).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Permissions_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<PermissionSheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PermissionSheet_Id");

            entity.ToTable("PermissionSheet", "RM");

            entity.Property(e => e.CubeName).HasMaxLength(250);
            entity.Property(e => e.DatabaseName).HasMaxLength(250);
            entity.Property(e => e.DimensionName).HasMaxLength(250);
            entity.Property(e => e.HierarchyName).HasMaxLength(250);
            entity.Property(e => e.HierarchyOrgin).HasMaxLength(250);
            entity.Property(e => e.LastPropagationDate).HasColumnType("datetime");
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.ServerName).HasMaxLength(250);
        });

        modelBuilder.Entity<PermissionsOlapMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PermissionsOlapMember_Id");

            entity.ToTable("PermissionsOlapMember", "RM");

            entity.Property(e => e.DateFrom).HasColumnType("datetime");
            entity.Property(e => e.DateTo).HasColumnType("datetime");
            entity.Property(e => e.LevelName).HasMaxLength(500);
            entity.Property(e => e.MemberCaption).HasMaxLength(250);
            entity.Property(e => e.MemberUniqueName).HasMaxLength(500);
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.PermissionSheet).WithMany(p => p.PermissionsOlapMembers)
                .HasForeignKey(d => d.PermissionSheetId)
                .HasConstraintName("FK_PermissionsOlapMember_PermissionSheetId__PermissionSheet_Id");
        });

        modelBuilder.Entity<PromotionCode>(entity =>
        {
            entity.HasKey(e => e.PcoId).HasName("PK_PromotionCodes_PCO_Id");

            entity.ToTable("PromotionCodes", "RB");

            entity.Property(e => e.PcoId).HasColumnName("PCO_Id");
            entity.Property(e => e.PcoAllUsages).HasColumnName("PCO_AllUsages");
            entity.Property(e => e.PcoAvailableUsages).HasColumnName("PCO_AvailableUsages");
            entity.Property(e => e.PcoCode)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("PCO_Code");
            entity.Property(e => e.PcoCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PCO_CreateDate");
            entity.Property(e => e.PcoDiscount).HasColumnName("PCO_Discount");
            entity.Property(e => e.PcoExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("PCO_ExpirationDate");
            entity.Property(e => e.PcoFirstUsage).HasColumnName("PCO_FirstUsage");
            entity.Property(e => e.PcoMonths).HasColumnName("PCO_Months");
            entity.Property(e => e.PcoPartnerId)
                .HasDefaultValue(0)
                .HasColumnName("PCO_PartnerId");
            entity.Property(e => e.PcoSingleUse).HasColumnName("PCO_SingleUse");
            entity.Property(e => e.PcoUsers).HasColumnName("PCO_Users");
            entity.Property(e => e.PcoWorkMode).HasColumnName("PCO_WorkMode");
        });

        modelBuilder.Entity<PromotionCodesWorkMode>(entity =>
        {
            entity.HasKey(e => e.PcwmId).HasName("PK_PromotionCodesWorkModes_PCWM_Id");

            entity.ToTable("PromotionCodesWorkModes", "RB");

            entity.Property(e => e.PcwmId).HasColumnName("PCWM_Id");
            entity.Property(e => e.PcwmCodeId).HasColumnName("PCWM_CodeId");
            entity.Property(e => e.PcwmWorkModeId).HasColumnName("PCWM_WorkModeId");

            entity.HasOne(d => d.PcwmCode).WithMany(p => p.PromotionCodesWorkModes)
                .HasForeignKey(d => d.PcwmCodeId)
                .HasConstraintName("FK_PromotionCodesWorkModes_PCWM_CodeId__PromotionCodes_PCO_Id");

            entity.HasOne(d => d.PcwmWorkMode).WithMany(p => p.PromotionCodesWorkModes)
                .HasForeignKey(d => d.PcwmWorkModeId)
                .HasConstraintName("FK_PromotionCodesWorkModes_PCWM_WorkModeId__WorkMode_WOR_Id");
        });

        modelBuilder.Entity<RegistrationUserModel>(entity =>
        {
            entity.HasKey(e => e.RumId).HasName("PK_RegistrationUserModel_RUM_Id");

            entity.ToTable("RegistrationUserModel", "RB");

            entity.Property(e => e.RumId).HasColumnName("RUM_Id");
            entity.Property(e => e.RumDataModelsDefinitionId).HasColumnName("RUM_DataModelsDefinitionId");
            entity.Property(e => e.RumLogin)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("RUM_Login");

            entity.HasOne(d => d.RumDataModelsDefinition).WithMany(p => p.RegistrationUserModels)
                .HasForeignKey(d => d.RumDataModelsDefinitionId)
                .HasConstraintName("FK_RegistrationUserModel_RUM_DataModelsDefinitionId__DataModelsDefinitions_DMD_Id");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.RepId).HasName("PK_Reports_REP_Id");

            entity.ToTable("Reports", "RB", tb =>
                {
                    tb.HasTrigger("CleanPredefinedReferenceOnDelete");
                    tb.HasTrigger("CleanPredefinedReferenceOnUpdate");
                });

            entity.Property(e => e.RepId).HasColumnName("REP_Id");
            entity.Property(e => e.RepCatalogName)
                .HasMaxLength(128)
                .HasColumnName("REP_CatalogName");
            entity.Property(e => e.RepCompanyId)
                .HasDefaultValue(1)
                .HasColumnName("REP_CompanyId");
            entity.Property(e => e.RepCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("REP_CreatedOn");
            entity.Property(e => e.RepCubeName)
                .HasMaxLength(128)
                .HasColumnName("REP_CubeName");
            entity.Property(e => e.RepData)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("REP_Data");
            entity.Property(e => e.RepDescription).HasColumnName("REP_Description");
            entity.Property(e => e.RepIsOpenInTime).HasColumnName("REP_IsOpenInTime");
            entity.Property(e => e.RepIsPredefinedReport).HasColumnName("REP_IsPredefinedReport");
            entity.Property(e => e.RepIsStdReport).HasColumnName("REP_IsStdReport");
            entity.Property(e => e.RepLanguage)
                .HasMaxLength(50)
                .HasColumnName("REP_Language");
            entity.Property(e => e.RepMetadata)
                .HasMaxLength(4096)
                .IsUnicode(false)
                .HasColumnName("REP_Metadata");
            entity.Property(e => e.RepModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("REP_ModifiedOn");
            entity.Property(e => e.RepOrgId)
                .HasMaxLength(68)
                .IsUnicode(false)
                .HasColumnName("REP_OrgID");
            entity.Property(e => e.RepOwnerId).HasColumnName("REP_OwnerId");
            entity.Property(e => e.RepPredefinedReport).HasColumnName("REP_PredefinedReport");
            entity.Property(e => e.RepServerName)
                .HasMaxLength(128)
                .HasColumnName("REP_ServerName");
            entity.Property(e => e.RepSnapshot).HasColumnName("REP_Snapshot");
            entity.Property(e => e.RepSourceDbType).HasColumnName("REP_SourceDbType");
            entity.Property(e => e.RepStdReportHash).HasColumnName("REP_StdReportHash");
            entity.Property(e => e.RepStdReportId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("REP_StdReportId");
            entity.Property(e => e.RepStdReportVersion).HasColumnName("REP_StdReportVersion");
            entity.Property(e => e.RepTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("REP_Timestamp");
            entity.Property(e => e.RepType).HasColumnName("REP_Type");
            entity.Property(e => e.RepUseDefaultConnection).HasColumnName("REP_UseDefaultConnection");
            entity.Property(e => e.RepUseInMemory).HasColumnName("REP_UseInMemory");
            entity.Property(e => e.RepViewType).HasColumnName("REP_ViewType");
            entity.Property(e => e.RepWebServicePort)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("REP_WebServicePort");

            entity.HasOne(d => d.RepCompany).WithMany(p => p.Reports)
                .HasForeignKey(d => d.RepCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reports_REP_CompanyId__Companies_COM_ID");

            entity.HasMany(d => d.CtrContexts).WithMany(p => p.CtrReports)
                .UsingEntity<Dictionary<string, object>>(
                    "ReportsContext",
                    r => r.HasOne<Context>().WithMany()
                        .HasForeignKey("CtrContextId")
                        .HasConstraintName("FK_ReportsContexts_CTR_ContextId__Contexts_CTX_Id"),
                    l => l.HasOne<Report>().WithMany()
                        .HasForeignKey("CtrReportId")
                        .HasConstraintName("FK_ReportsContexts_CTR_ReportId__Reports_REP_Id"),
                    j =>
                    {
                        j.HasKey("CtrReportId", "CtrContextId").HasName("PK_ReportsContexts_CTR_ReportId_CTR_ContextId");
                        j.ToTable("ReportsContexts", "RB");
                        j.IndexerProperty<int>("CtrReportId").HasColumnName("CTR_ReportId");
                        j.IndexerProperty<int>("CtrContextId").HasColumnName("CTR_ContextId");
                    });

            entity.HasMany(d => d.DbrDashboards).WithMany(p => p.DbrReports)
                .UsingEntity<Dictionary<string, object>>(
                    "DashboardsReport",
                    r => r.HasOne<Report>().WithMany()
                        .HasForeignKey("DbrDashboardId")
                        .HasConstraintName("FK_DashboardsReports_DBR_DashboardId__Reports_REP_Id"),
                    l => l.HasOne<Report>().WithMany()
                        .HasForeignKey("DbrReportId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DashboardsReports_DBR_ReportId__Reports_REP_Id"),
                    j =>
                    {
                        j.HasKey("DbrDashboardId", "DbrReportId").HasName("PK_DashboardsReports_DBR_DashboardId_DBR_ReportId");
                        j.ToTable("DashboardsReports", "RB");
                        j.IndexerProperty<int>("DbrDashboardId").HasColumnName("DBR_DashboardId");
                        j.IndexerProperty<int>("DbrReportId").HasColumnName("DBR_ReportId");
                    });

            entity.HasMany(d => d.DbrReports).WithMany(p => p.DbrDashboards)
                .UsingEntity<Dictionary<string, object>>(
                    "DashboardsReport",
                    r => r.HasOne<Report>().WithMany()
                        .HasForeignKey("DbrReportId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DashboardsReports_DBR_ReportId__Reports_REP_Id"),
                    l => l.HasOne<Report>().WithMany()
                        .HasForeignKey("DbrDashboardId")
                        .HasConstraintName("FK_DashboardsReports_DBR_DashboardId__Reports_REP_Id"),
                    j =>
                    {
                        j.HasKey("DbrDashboardId", "DbrReportId").HasName("PK_DashboardsReports_DBR_DashboardId_DBR_ReportId");
                        j.ToTable("DashboardsReports", "RB");
                        j.IndexerProperty<int>("DbrDashboardId").HasColumnName("DBR_DashboardId");
                        j.IndexerProperty<int>("DbrReportId").HasColumnName("DBR_ReportId");
                    });
        });

        modelBuilder.Entity<ReportParameter>(entity =>
        {
            entity.HasKey(e => e.RpaId).HasName("PK_ReportParameters_RPA_Id");

            entity.ToTable("ReportParameters", "RB");

            entity.Property(e => e.RpaId).HasColumnName("RPA_Id");
            entity.Property(e => e.PraReportId).HasColumnName("PRA_ReportId");
            entity.Property(e => e.RpaContextId).HasColumnName("RPA_ContextId");
            entity.Property(e => e.RpaContextParameterId).HasColumnName("RPA_ContextParameterId");
            entity.Property(e => e.RpaCubeName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("RPA_CubeName");
            entity.Property(e => e.RpaDataModelId).HasColumnName("RPA_DataModelId");
            entity.Property(e => e.RpaHierarchyId).HasColumnName("RPA_HierarchyId");
            entity.Property(e => e.RpaIsActiveContexts).HasColumnName("RPA_IsActiveContexts");
            entity.Property(e => e.RpaParameterType).HasColumnName("RPA_ParameterType");

            entity.HasOne(d => d.PraReport).WithMany(p => p.ReportParameters)
                .HasForeignKey(d => d.PraReportId)
                .HasConstraintName("FK_ReportParameters_RPA_ReportId__Reports_REP_Id");

            entity.HasOne(d => d.RpaContext).WithMany(p => p.ReportParameters)
                .HasForeignKey(d => d.RpaContextId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ReportParameters_RPA_ContextId__Contexts_CTX_Id");

            entity.HasOne(d => d.RpaContextParameter).WithMany(p => p.ReportParameters)
                .HasForeignKey(d => d.RpaContextParameterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ReportParameters_RPA_ContextParameterId__Parameters_PAR_Id");

            entity.HasOne(d => d.RpaDataModel).WithMany(p => p.ReportParameters)
                .HasForeignKey(d => d.RpaDataModelId)
                .HasConstraintName("FK_ReportParameters_RPA_DataModelId__DataModels_DMO_Id");

            entity.HasOne(d => d.RpaHierarchy).WithMany(p => p.ReportParameters)
                .HasForeignKey(d => d.RpaHierarchyId)
                .HasConstraintName("FK_ReportParameters_RPA_HierarchyId__Hierarchies_HRC_Id");
        });

        modelBuilder.Entity<ReportTranslation>(entity =>
        {
            entity.HasKey(e => e.RptId).HasName("PK_ReportTranslations_RPT_Id");

            entity.ToTable("ReportTranslations", "RB");

            entity.Property(e => e.RptId).HasColumnName("RPT_Id");
            entity.Property(e => e.RptLocaleId)
                .HasMaxLength(5)
                .HasColumnName("RPT_LocaleId");
            entity.Property(e => e.RptOriginalText)
                .HasMaxLength(255)
                .HasColumnName("RPT_OriginalText");
            entity.Property(e => e.RptReportName)
                .HasMaxLength(100)
                .HasColumnName("RPT_ReportName");
            entity.Property(e => e.RptTranslatedText).HasColumnName("RPT_TranslatedText");
            entity.Property(e => e.RptTranslationSubject)
                .HasMaxLength(50)
                .HasColumnName("RPT_TranslationSubject");
        });

        modelBuilder.Entity<ReportsConnection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportsConnections", "RB");

            entity.Property(e => e.RcnConnectionId).HasColumnName("RCN_ConnectionId");
            entity.Property(e => e.RcnReportId).HasColumnName("RCN_ReportId");

            entity.HasOne(d => d.RcnConnection).WithMany()
                .HasForeignKey(d => d.RcnConnectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportsConnections_RCN_ConnectionId__Connections_CON_Id");

            entity.HasOne(d => d.RcnReport).WithMany()
                .HasForeignKey(d => d.RcnReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportsConnections_RCN_ReportId__Reports_REP_Id");
        });

        modelBuilder.Entity<ReportsDatum>(entity =>
        {
            entity.HasKey(e => new { e.RdaReportId, e.RdaDefinitionType }).HasName("PK_ReportsData_RDA_ReportId__RDA_DefinitionType");

            entity.ToTable("ReportsData", "RB");

            entity.Property(e => e.RdaReportId).HasColumnName("RDA_ReportId");
            entity.Property(e => e.RdaDefinitionType).HasColumnName("RDA_DefinitionType");
            entity.Property(e => e.RdaBinaryDefinition)
                .HasColumnType("image")
                .HasColumnName("RDA_BinaryDefinition");
            entity.Property(e => e.RdaTextDefinition)
                .HasColumnType("ntext")
                .HasColumnName("RDA_TextDefinition");

            entity.HasOne(d => d.RdaReport).WithMany(p => p.ReportsData)
                .HasForeignKey(d => d.RdaReportId)
                .HasConstraintName("FK_ReportsData_RDA_ReportId__Reports_REP_Id");
        });

        modelBuilder.Entity<ReportsImage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportsImages", "RB");

            entity.Property(e => e.ImgCheckSum).HasColumnName("IMG_CheckSum");
            entity.Property(e => e.ImgReportId).HasColumnName("IMG_ReportId");
            entity.Property(e => e.ImgReportImage).HasColumnName("IMG_ReportImage");
        });

        modelBuilder.Entity<ReportsStore>(entity =>
        {
            entity.HasKey(e => e.RstId).HasName("PK_ReportsStore_RST_Id");

            entity.ToTable("ReportsStore", "RB");

            entity.HasIndex(e => e.RstId, "UQ_ReportsStore_RST_Id").IsUnique();

            entity.Property(e => e.RstId).HasColumnName("RST_Id");
            entity.Property(e => e.RstFolderId).HasColumnName("RST_FolderId");
            entity.Property(e => e.RstIsForMobile).HasColumnName("RST_IsForMobile");
            entity.Property(e => e.RstRenderedOn)
                .HasColumnType("datetime")
                .HasColumnName("RST_RenderedOn");
            entity.Property(e => e.RstRenderedReport)
                .HasColumnType("image")
                .HasColumnName("RST_RenderedReport");
            entity.Property(e => e.RstRenderingFormat).HasColumnName("RST_RenderingFormat");
            entity.Property(e => e.RstReportId).HasColumnName("RST_ReportId");
            entity.Property(e => e.RstSubscriptionId).HasColumnName("RST_SubscriptionId");
            entity.Property(e => e.RstUserId).HasColumnName("RST_UserId");

            entity.HasOne(d => d.RstReport).WithMany(p => p.ReportsStores)
                .HasForeignKey(d => d.RstReportId)
                .HasConstraintName("FK_ReportsStore_RST_ReportId__Reports_REP_Id");

            entity.HasOne(d => d.RstSubscription).WithMany(p => p.ReportsStores)
                .HasForeignKey(d => d.RstSubscriptionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ReportsStore_RST_SubscriptionId__Subscriptions_SUB_Id");

            entity.HasOne(d => d.RstUser).WithMany(p => p.ReportsStores)
                .HasForeignKey(d => d.RstUserId)
                .HasConstraintName("FK_ReportsStore_RST_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<RestrictRole>(entity =>
        {
            entity.HasKey(e => e.RrlId).HasName("PK_RestrictRoles_RRL_Id");

            entity.ToTable("RestrictRoles", "RB");

            entity.Property(e => e.RrlId).HasColumnName("RRL_Id");
            entity.Property(e => e.RrlAccountActiveId).HasColumnName("RRL_AccountActiveId");
            entity.Property(e => e.RrlCompanyId).HasColumnName("RRL_CompanyId");
            entity.Property(e => e.RrlName)
                .HasMaxLength(100)
                .HasColumnName("RRL_Name");
            entity.Property(e => e.RrlXmlstring).HasColumnName("RRL_XMLString");
        });

        modelBuilder.Entity<RightsFoldersGroup>(entity =>
        {
            entity.HasKey(e => new { e.RfgFolderId, e.RfgGroupId }).HasName("PK_RightsFoldersGroups_RFG_FolderId_RFG_GroupId");

            entity.ToTable("RightsFoldersGroups", "RB");

            entity.Property(e => e.RfgFolderId).HasColumnName("RFG_FolderId");
            entity.Property(e => e.RfgGroupId).HasColumnName("RFG_GroupId");
            entity.Property(e => e.RfgAccessRight).HasColumnName("RFG_AccessRight");

            entity.HasOne(d => d.RfgFolder).WithMany(p => p.RightsFoldersGroups)
                .HasForeignKey(d => d.RfgFolderId)
                .HasConstraintName("FK_RightsFoldersGroups_RFG_DolderId__Folders_FOL_Id");

            entity.HasOne(d => d.RfgGroup).WithMany(p => p.RightsFoldersGroups)
                .HasForeignKey(d => d.RfgGroupId)
                .HasConstraintName("FK_RightsFoldersGroups_RFG_GroupId__Groups_GRP_Id");
        });

        modelBuilder.Entity<RightsFoldersUser>(entity =>
        {
            entity.HasKey(e => new { e.RfuFolderId, e.RfuUserId }).HasName("PK_RightsFoldersUsers_RFU_FolderId_RFU_UserId");

            entity.ToTable("RightsFoldersUsers", "RB");

            entity.Property(e => e.RfuFolderId).HasColumnName("RFU_FolderId");
            entity.Property(e => e.RfuUserId).HasColumnName("RFU_UserId");
            entity.Property(e => e.RfuAccessRight).HasColumnName("RFU_AccessRight");

            entity.HasOne(d => d.RfuFolder).WithMany(p => p.RightsFoldersUsers)
                .HasForeignKey(d => d.RfuFolderId)
                .HasConstraintName("FK_RightsFoldersUsers_RFU_FolderId__Folders_FOL_Id");

            entity.HasOne(d => d.RfuUser).WithMany(p => p.RightsFoldersUsers)
                .HasForeignKey(d => d.RfuUserId)
                .HasConstraintName("FK_RightsFoldersUsers_RFU_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<RightsReportsGroup>(entity =>
        {
            entity.HasKey(e => new { e.RrgReportId, e.RrgGroupId }).HasName("PK_RightsReportsGroups_RRG_ReportId_RRG_GroupId");

            entity.ToTable("RightsReportsGroups", "RB");

            entity.Property(e => e.RrgReportId).HasColumnName("RRG_ReportId");
            entity.Property(e => e.RrgGroupId).HasColumnName("RRG_GroupId");
            entity.Property(e => e.RrgAccessRight).HasColumnName("RRG_AccessRight");

            entity.HasOne(d => d.RrgGroup).WithMany(p => p.RightsReportsGroups)
                .HasForeignKey(d => d.RrgGroupId)
                .HasConstraintName("FK_RightsReportsGroups_RRG_GroupId__Groups_GRP_Id");

            entity.HasOne(d => d.RrgReport).WithMany(p => p.RightsReportsGroups)
                .HasForeignKey(d => d.RrgReportId)
                .HasConstraintName("FK_RightsReportsGroups_RRG_ReportId__Reports_REP_Id");
        });

        modelBuilder.Entity<RightsReportsUser>(entity =>
        {
            entity.HasKey(e => new { e.RruReportId, e.RruUserId }).HasName("PK_RightsReportsUsers_RRU_ReportId_RRU_UserId");

            entity.ToTable("RightsReportsUsers", "RB");

            entity.Property(e => e.RruReportId).HasColumnName("RRU_ReportId");
            entity.Property(e => e.RruUserId).HasColumnName("RRU_UserId");
            entity.Property(e => e.RruAccessRight).HasColumnName("RRU_AccessRight");

            entity.HasOne(d => d.RruReport).WithMany(p => p.RightsReportsUsers)
                .HasForeignKey(d => d.RruReportId)
                .HasConstraintName("FK_RightsReportsUsers_RRU_ReportId__Reports_REP_Id");

            entity.HasOne(d => d.RruUser).WithMany(p => p.RightsReportsUsers)
                .HasForeignKey(d => d.RruUserId)
                .HasConstraintName("FK_RightsReportsUsers_RRU_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<SegmentationFtpConnection>(entity =>
        {
            entity.HasKey(e => e.SfcId).HasName("PK_SegmentationFtpConnections_SFC_Id");

            entity.ToTable("SegmentationFtpConnections", "RB");

            entity.Property(e => e.SfcId).HasColumnName("SFC_Id");
            entity.Property(e => e.SfcBlockId)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("SFC_BlockId");
            entity.Property(e => e.SfcFtpConnectionId).HasColumnName("SFC_FtpConnectionId");
            entity.Property(e => e.SfcSegmentationId).HasColumnName("SFC_SegmentationId");

            entity.HasOne(d => d.SfcFtpConnection).WithMany(p => p.SegmentationFtpConnections)
                .HasForeignKey(d => d.SfcFtpConnectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SegmentationFtpConnections_SFC_FtpConnectionId__FtpConnections_FC_Id");

            entity.HasOne(d => d.SfcSegmentation).WithMany(p => p.SegmentationFtpConnections)
                .HasForeignKey(d => d.SfcSegmentationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SegmentationFtpConnections_SFC_SegmentationId__SegmentationNodes_SN_ID");
        });

        modelBuilder.Entity<SegmentationNode>(entity =>
        {
            entity.HasKey(e => e.SnId).HasName("PK_SegmentationNodes_SN_ID");

            entity.ToTable("SegmentationNodes", "RB");

            entity.Property(e => e.SnId).HasColumnName("SN_ID");
            entity.Property(e => e.SnCompanyId).HasColumnName("SN_CompanyID");
            entity.Property(e => e.SnCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("SN_CreatedOn");
            entity.Property(e => e.SnModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("SN_ModifiedOn");
            entity.Property(e => e.SnName)
                .HasMaxLength(128)
                .HasColumnName("SN_Name");
            entity.Property(e => e.SnParentId).HasColumnName("SN_ParentID");
            entity.Property(e => e.SnType).HasColumnName("SN_Type");

            entity.HasOne(d => d.SnParent).WithMany(p => p.InverseSnParent)
                .HasForeignKey(d => d.SnParentId)
                .HasConstraintName("FK_SegmentationNodes_SN_ParentID__SegmentationNodes_SN_ID");
        });

        modelBuilder.Entity<SegmentationObject>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SegmentationObjects", "RB");

            entity.Property(e => e.SoDefinition).HasColumnName("SO_Definition");
            entity.Property(e => e.SoDescription)
                .IsUnicode(false)
                .HasColumnName("SO_Description");
            entity.Property(e => e.SoIsUndone).HasColumnName("SO_IsUndone");
            entity.Property(e => e.SoLastActionOn)
                .HasColumnType("datetime")
                .HasColumnName("SO_LastActionOn");
            entity.Property(e => e.SoNodeId).HasColumnName("SO_NodeID");
            entity.Property(e => e.SoRelatedIds)
                .HasColumnType("text")
                .HasColumnName("SO_RelatedIds");
            entity.Property(e => e.SoStatusCode).HasColumnName("SO_StatusCode");
            entity.Property(e => e.SoType).HasColumnName("SO_Type");

            entity.HasOne(d => d.SoNode).WithMany()
                .HasForeignKey(d => d.SoNodeId)
                .HasConstraintName("FK_SegmentationObjects_SO_NodeID__SegmentationNodes_SN_ID");
        });

        modelBuilder.Entity<SegmentationProcess>(entity =>
        {
            entity.HasKey(e => e.SpId).HasName("PK_SegmentationProcesses_SP_ID");

            entity.ToTable("SegmentationProcesses", "RB");

            entity.Property(e => e.SpId).HasColumnName("SP_ID");
            entity.Property(e => e.SpDescription)
                .HasColumnType("text")
                .HasColumnName("SP_Description");
            entity.Property(e => e.SpEndDate)
                .HasColumnType("datetime")
                .HasColumnName("SP_EndDate");
            entity.Property(e => e.SpSegmentationObjectId).HasColumnName("SP_SegmentationObjectID");
            entity.Property(e => e.SpStartDate)
                .HasColumnType("datetime")
                .HasColumnName("SP_StartDate");
            entity.Property(e => e.SpState).HasColumnName("SP_State");
        });

        modelBuilder.Entity<SegmentationProcessesPlan>(entity =>
        {
            entity.HasKey(e => e.SppId).HasName("PK_SegmentationProcessesPlan_SPP_ID");

            entity.ToTable("SegmentationProcessesPlan", "RB");

            entity.Property(e => e.SppId).HasColumnName("SPP_ID");
            entity.Property(e => e.SppActive).HasColumnName("SPP_Active");
            entity.Property(e => e.SppCompanyId).HasColumnName("SPP_CompanyId");
            entity.Property(e => e.SppEndDate)
                .HasColumnType("datetime")
                .HasColumnName("SPP_EndDate");
            entity.Property(e => e.SppLastSendCode).HasColumnName("SPP_LastSendCode");
            entity.Property(e => e.SppLastSent)
                .HasColumnType("datetime")
                .HasColumnName("SPP_LastSent");
            entity.Property(e => e.SppName).HasColumnName("SPP_Name");
            entity.Property(e => e.SppProcessId).HasColumnName("SPP_ProcessID");
            entity.Property(e => e.SppSendTimePeriod).HasColumnName("SPP_SendTimePeriod");
            entity.Property(e => e.SppStartDate)
                .HasColumnType("datetime")
                .HasColumnName("SPP_StartDate");
        });

        modelBuilder.Entity<SegmentationProcessesResult>(entity =>
        {
            entity.HasKey(e => e.SprId).HasName("PK_SegmentationProcessesResults_SPR_ID");

            entity.ToTable("SegmentationProcessesResults", "RB");

            entity.Property(e => e.SprId).HasColumnName("SPR_ID");
            entity.Property(e => e.SprProcessId).HasColumnName("SPR_ProcessID");
            entity.Property(e => e.SprResult)
                .HasColumnType("text")
                .HasColumnName("SPR_Result");
            entity.Property(e => e.SprType).HasColumnName("SPR_Type");
        });

        modelBuilder.Entity<SegmentationSchedule>(entity =>
        {
            entity.HasKey(e => e.SesId).HasName("PK_SegmentationSchedule_SES_Id");

            entity.ToTable("SegmentationSchedule", "RB");

            entity.Property(e => e.SesId).HasColumnName("SES_Id");
            entity.Property(e => e.SesDayId).HasColumnName("SES_DayId");
            entity.Property(e => e.SesDayOfMonth).HasColumnName("SES_DayOfMonth");
            entity.Property(e => e.SesMonthId).HasColumnName("SES_MonthId");
            entity.Property(e => e.SesProcessesPlanId).HasColumnName("SES_ProcessesPlanId");
            entity.Property(e => e.SesSendTime)
                .HasMaxLength(50)
                .HasColumnName("SES_SendTime");
            entity.Property(e => e.SesSendYear).HasColumnName("SES_SendYear");
            entity.Property(e => e.SesShortPeriodStartTime)
                .HasMaxLength(50)
                .HasColumnName("SES_ShortPeriodStartTime");

            entity.HasOne(d => d.SesProcessesPlan).WithMany(p => p.SegmentationSchedules)
                .HasForeignKey(d => d.SesProcessesPlanId)
                .HasConstraintName("FK_SegmentationSchedule_SES_ProcessesPlanId__SegmentationProcessesPlan_SPP_ID");
        });

        modelBuilder.Entity<SemiramisAction>(entity =>
        {
            entity.HasKey(e => e.SeaId).HasName("PK_SemiramisActions_SEA_Id");

            entity.ToTable("SemiramisActions", "RB");

            entity.Property(e => e.SeaId)
                .ValueGeneratedNever()
                .HasColumnName("SEA_Id");
            entity.Property(e => e.SeaLinkParameterName)
                .HasMaxLength(50)
                .HasColumnName("SEA_LinkParameterName");
            entity.Property(e => e.SeaName)
                .HasMaxLength(50)
                .HasColumnName("SEA_Name");
        });

        modelBuilder.Entity<SemiramisActionsTranslation>(entity =>
        {
            entity.HasKey(e => e.SatId).HasName("PK_SemiramisActionsTranslations_SAT_Id");

            entity.ToTable("SemiramisActionsTranslations", "RB");

            entity.Property(e => e.SatId)
                .ValueGeneratedNever()
                .HasColumnName("SAT_Id");
            entity.Property(e => e.SatActionId).HasColumnName("SAT_ActionId");
            entity.Property(e => e.SatLocaleId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("SAT_LocaleId");
            entity.Property(e => e.SatTranslation)
                .HasMaxLength(50)
                .HasColumnName("SAT_Translation");

            entity.HasOne(d => d.SatAction).WithMany(p => p.SemiramisActionsTranslations)
                .HasForeignKey(d => d.SatActionId)
                .HasConstraintName("FK_SemiramisActionsTranslations_SAT_ActionId__SemiramisActions_SEA_Id");
        });

        modelBuilder.Entity<SemiramisLinkHierarchiesMap>(entity =>
        {
            entity.HasKey(e => new { e.SlmSemiramisLinkHierarchiesId, e.SlmHierarchyOrgId }).HasName("PK_SemiramisLinkHierarchiesMap_SLM_SemiramisLinkHierarchiesId_SLM_HierarchyOrgId");

            entity.ToTable("SemiramisLinkHierarchiesMap", "RB");

            entity.Property(e => e.SlmSemiramisLinkHierarchiesId).HasColumnName("SLM_SemiramisLinkHierarchiesId");
            entity.Property(e => e.SlmHierarchyOrgId)
                .HasMaxLength(255)
                .HasColumnName("SLM_HierarchyOrgId");

            entity.HasOne(d => d.SlmSemiramisLinkHierarchies).WithMany(p => p.SemiramisLinkHierarchiesMaps)
                .HasForeignKey(d => d.SlmSemiramisLinkHierarchiesId)
                .HasConstraintName("FK_SemiramisLinkHierarchiesMap_SLM_SemiramisLinkHierarchiesId__SemiramisLinkHierarchies_SEM_Id");
        });

        modelBuilder.Entity<SemiramisLinkHierarchy>(entity =>
        {
            entity.HasKey(e => e.SemId).HasName("PK_SemiramisLinkHierarchies_SEM_Id");

            entity.ToTable("SemiramisLinkHierarchies", "RB");

            entity.Property(e => e.SemId).HasColumnName("SEM_Id");
            entity.Property(e => e.SemActionId).HasColumnName("SEM_ActionId");
            entity.Property(e => e.SemAppName)
                .HasMaxLength(255)
                .HasColumnName("SEM_AppName");
            entity.Property(e => e.SemBeLinkType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SEM_BeLinkType");
            entity.Property(e => e.SemCubeName)
                .HasMaxLength(255)
                .HasColumnName("SEM_CubeName");
            entity.Property(e => e.SemHierarchyName)
                .HasMaxLength(255)
                .HasColumnName("SEM_HierarchyName");
            entity.Property(e => e.SemIsSupport).HasColumnName("SEM_IsSupport");

            entity.HasOne(d => d.SemAction).WithMany(p => p.SemiramisLinkHierarchies)
                .HasForeignKey(d => d.SemActionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SemiramisLinkHierarchies_SEM_ActionId__SemiramisActions_SEA_Id");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.SvcId).HasName("PK_Services_SVC_Id");

            entity.ToTable("Services", "RB");

            entity.Property(e => e.SvcId)
                .ValueGeneratedNever()
                .HasColumnName("SVC_Id");
            entity.Property(e => e.SvcCommandTimeout).HasColumnName("SVC_CommandTimeout");
            entity.Property(e => e.SvcConnectionRetryCount)
                .HasDefaultValue(1)
                .HasColumnName("SVC_ConnectionRetryCount");
            entity.Property(e => e.SvcConnectionRetryInterval).HasColumnName("SVC_ConnectionRetryInterval");
            entity.Property(e => e.SvcTimeout).HasColumnName("SVC_Timeout");
        });

        modelBuilder.Entity<ServicesAddress>(entity =>
        {
            entity.HasKey(e => e.SvcaId).HasName("PK_ServicesAddresses_SVCA_Id");

            entity.ToTable("ServicesAddresses", "RB");

            entity.Property(e => e.SvcaId).HasColumnName("SVCA_Id");
            entity.Property(e => e.SvcaHost)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SVCA_Host");
            entity.Property(e => e.SvcaPort).HasColumnName("SVCA_Port");
            entity.Property(e => e.SvcaServiceId).HasColumnName("SVCA_ServiceId");

            entity.HasOne(d => d.SvcaService).WithMany(p => p.ServicesAddresses)
                .HasForeignKey(d => d.SvcaServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServicesAddresses_SVCA_ServiceId__Services_SVC_Id");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.SetId).HasName("PK_Settings_SET_Id");

            entity.ToTable("Settings", "RB");

            entity.HasIndex(e => e.SetName, "UQ_Settings_SET_Name").IsUnique();

            entity.Property(e => e.SetId).HasColumnName("SET_Id");
            entity.Property(e => e.SetCompanyId)
                .HasDefaultValue(1)
                .HasColumnName("SET_CompanyId");
            entity.Property(e => e.SetName)
                .HasMaxLength(100)
                .HasColumnName("SET_Name");
            entity.Property(e => e.SetValue).HasColumnName("SET_Value");

            entity.HasOne(d => d.SetCompany).WithMany(p => p.Settings)
                .HasForeignKey(d => d.SetCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Settings_SET_CompanyId__Companies_COM_ID");
        });

        modelBuilder.Entity<SocialProfile>(entity =>
        {
            entity.HasKey(e => e.SopId).HasName("PK_SocialProfiles_SOP_ID");

            entity.ToTable("SocialProfiles", "RB");

            entity.Property(e => e.SopId)
                .ValueGeneratedNever()
                .HasColumnName("SOP_ID");
            entity.Property(e => e.SopCompanyId)
                .HasDefaultValue(1)
                .HasColumnName("SOP_CompanyId");
            entity.Property(e => e.SopFriendlyName)
                .HasMaxLength(256)
                .HasColumnName("SOP_FriendlyName");
            entity.Property(e => e.SopImageUrl)
                .HasColumnType("text")
                .HasColumnName("SOP_ImageUrl");
            entity.Property(e => e.SopOrgId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SOP_OrgId");
            entity.Property(e => e.SopProfileLink)
                .HasMaxLength(256)
                .HasColumnName("SOP_ProfileLink");

            entity.HasOne(d => d.SopCompany).WithMany(p => p.SocialProfiles)
                .HasForeignKey(d => d.SopCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SocialProfiles_SOP_CompanyId__Companies_COM_ID");
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.HasKey(e => e.SubId).HasName("PK_Subscriptions_SUB_Id");

            entity.ToTable("Subscriptions", "RB");

            entity.Property(e => e.SubId).HasColumnName("SUB_Id");
            entity.Property(e => e.SubActive).HasColumnName("SUB_Active");
            entity.Property(e => e.SubAppendFilters).HasColumnName("SUB_AppendFilters");
            entity.Property(e => e.SubCompanyId).HasColumnName("SUB_CompanyId");
            entity.Property(e => e.SubConditionComperType)
                .HasDefaultValue(0)
                .HasColumnName("SUB_ConditionComperType");
            entity.Property(e => e.SubConditionDefinition)
                .HasDefaultValue("")
                .HasColumnName("SUB_ConditionDefinition");
            entity.Property(e => e.SubConditionType)
                .HasDefaultValue(0)
                .HasColumnName("SUB_ConditionType");
            entity.Property(e => e.SubConditionValue)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(25, 10)")
                .HasColumnName("SUB_ConditionValue");
            entity.Property(e => e.SubConditionValueType)
                .HasDefaultValue(0)
                .HasColumnName("SUB_ConditionValueType");
            entity.Property(e => e.SubDataModelParametersValues)
                .HasColumnType("ntext")
                .HasColumnName("SUB_DataModelParametersValues");
            entity.Property(e => e.SubEmailSubject).HasColumnName("SUB_EmailSubject");
            entity.Property(e => e.SubEndDate)
                .HasColumnType("datetime")
                .HasColumnName("SUB_EndDate");
            entity.Property(e => e.SubExpandReport).HasColumnName("SUB_ExpandReport");
            entity.Property(e => e.SubIsConditionDefine)
                .HasDefaultValue(false)
                .HasColumnName("SUB_IsConditionDefine");
            entity.Property(e => e.SubIsPathSet).HasColumnName("SUB_IsPathSet");
            entity.Property(e => e.SubLastSendCode).HasColumnName("SUB_LastSendCode");
            entity.Property(e => e.SubLastSent)
                .HasColumnType("datetime")
                .HasColumnName("SUB_LastSent");
            entity.Property(e => e.SubMergeItems).HasColumnName("SUB_MergeItems");
            entity.Property(e => e.SubPath)
                .HasDefaultValue("")
                .HasColumnName("SUB_Path");
            entity.Property(e => e.SubRenderPerRecipient).HasColumnName("SUB_RenderPerRecipient");
            entity.Property(e => e.SubRenderPerUserDatabases).HasColumnName("SUB_RenderPerUserDatabases");
            entity.Property(e => e.SubReportFormat).HasColumnName("SUB_ReportFormat");
            entity.Property(e => e.SubSender)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("SUB_Sender");
            entity.Property(e => e.SubStartDate)
                .HasColumnType("datetime")
                .HasColumnName("SUB_StartDate");
            entity.Property(e => e.SubSubscriptionName).HasColumnName("SUB_SubscriptionName");
            entity.Property(e => e.SubType).HasColumnName("SUB_Type");
            entity.Property(e => e.SubUserId).HasColumnName("SUB_UserId");
            entity.Property(e => e.SubWhenFlag).HasColumnName("SUB_WhenFlag");
        });

        modelBuilder.Entity<SubscriptionsAlert>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SubscriptionsAlerts", "RB");

            entity.Property(e => e.SalComment).HasColumnName("SAL_Comment");
            entity.Property(e => e.SalConditionType).HasColumnName("SAL_ConditionType");
            entity.Property(e => e.SalConnectionString).HasColumnName("SAL_ConnectionString");
            entity.Property(e => e.SalCubeName).HasColumnName("SAL_CubeName");
            entity.Property(e => e.SalIsCustomMdxquery).HasColumnName("SAL_IsCustomMDXQuery");
            entity.Property(e => e.SalMdxquery).HasColumnName("SAL_MDXQuery");
            entity.Property(e => e.SalMdxwhereClause).HasColumnName("SAL_MDXWhereClause");
            entity.Property(e => e.SalSubscriptionId).HasColumnName("SAL_SubscriptionId");
            entity.Property(e => e.SalThreshold)
                .HasColumnType("decimal(25, 10)")
                .HasColumnName("SAL_Threshold");
            entity.Property(e => e.SalUseDefaultConnection).HasColumnName("SAL_UseDefaultConnection");

            entity.HasOne(d => d.SalSubscription).WithMany()
                .HasForeignKey(d => d.SalSubscriptionId)
                .HasConstraintName("FK_SubscriptionsAlerts_SAL_SubscriptionId__Subscriptions_SUB_Id");
        });

        modelBuilder.Entity<SubscriptionsAttachment>(entity =>
        {
            entity.HasKey(e => new { e.SatSubscriptionId, e.SatAttachmentType }).HasName("PK_SubscriptionsAttachments_SAT_SubscriptionId_SAT_AttachmentType");

            entity.ToTable("SubscriptionsAttachments", "RB");

            entity.Property(e => e.SatSubscriptionId).HasColumnName("SAT_SubscriptionId");
            entity.Property(e => e.SatAttachmentType).HasColumnName("SAT_AttachmentType");
        });

        modelBuilder.Entity<SubscriptionsCredential>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SubscriptionsCredentials", "RB");

            entity.Property(e => e.ScrCipher).HasColumnName("SCR_Cipher");
            entity.Property(e => e.ScrUserId).HasColumnName("SCR_UserId");
            entity.Property(e => e.ScrVector)
                .HasColumnType("image")
                .HasColumnName("SCR_Vector");

            entity.HasOne(d => d.ScrUser).WithMany()
                .HasForeignKey(d => d.ScrUserId)
                .HasConstraintName("FK_SubscriptionsCredentials_SCR_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<SubscriptionsDescription>(entity =>
        {
            entity.HasKey(e => e.SdeSubscriptionId).HasName("PK_SubscriptionsDescriptions_SDE_SubscriptionID");

            entity.ToTable("SubscriptionsDescriptions", "RB");

            entity.Property(e => e.SdeSubscriptionId)
                .ValueGeneratedNever()
                .HasColumnName("SDE_SubscriptionID");
            entity.Property(e => e.SdeDescription).HasColumnName("SDE_Description");
            entity.Property(e => e.SdeIsSendConditionInfo).HasColumnName("SDE_IsSendConditionInfo");
            entity.Property(e => e.SdeIsSendParameters).HasColumnName("SDE_IsSendParameters");
            entity.Property(e => e.SdeIsSendReportDescription).HasColumnName("SDE_IsSendReportDescription");
            entity.Property(e => e.SdeTextPosition).HasColumnName("SDE_TextPosition");

            entity.HasOne(d => d.SdeSubscription).WithOne(p => p.SubscriptionsDescription)
                .HasForeignKey<SubscriptionsDescription>(d => d.SdeSubscriptionId)
                .HasConstraintName("FK_SubscriptionsDescriptions_SDE_SubscriptionID__Subscriptions_SUB_Id");
        });

        modelBuilder.Entity<SubscriptionsExternalUser>(entity =>
        {
            entity.HasKey(e => e.SeuId).HasName("PK_SubscriptionsExternalUsers_SEU_Id");

            entity.ToTable("SubscriptionsExternalUsers", "RB");

            entity.Property(e => e.SeuId).HasColumnName("SEU_Id");
            entity.Property(e => e.SeuCompanyId).HasColumnName("SEU_CompanyId");
            entity.Property(e => e.SeuEmail)
                .HasMaxLength(256)
                .HasColumnName("SEU_Email");
            entity.Property(e => e.SeuName)
                .HasMaxLength(256)
                .HasColumnName("SEU_Name");
        });

        modelBuilder.Entity<SubscriptionsFreeForm>(entity =>
        {
            entity.HasKey(e => e.SffId).HasName("PK_SubscriptionsFreeForm_SFF_ID");

            entity.ToTable("SubscriptionsFreeForm", "RB");

            entity.Property(e => e.SffId).HasColumnName("SFF_ID");
            entity.Property(e => e.SffConnection)
                .HasMaxLength(255)
                .HasColumnName("SFF_Connection");
            entity.Property(e => e.SffScenarioParam)
                .HasMaxLength(4000)
                .HasColumnName("SFF_ScenarioParam");
            entity.Property(e => e.SffSubscriptionId).HasColumnName("SFF_SubscriptionId");

            entity.HasOne(d => d.SffSubscription).WithMany(p => p.SubscriptionsFreeForms)
                .HasForeignKey(d => d.SffSubscriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubscriptionsFreeForm_SFF_SubscriptionId__Subscriptions_SUB_Id");
        });

        modelBuilder.Entity<SubscriptionsFtpConnection>(entity =>
        {
            entity.HasKey(e => e.SfcId).HasName("PK_SubscriptionsFtpConnections_SFC_Id");

            entity.ToTable("SubscriptionsFtpConnections", "RB");

            entity.Property(e => e.SfcId).HasColumnName("SFC_Id");
            entity.Property(e => e.SfcFtpConnectionId).HasColumnName("SFC_FtpConnectionId");
            entity.Property(e => e.SfcSubscriptionId).HasColumnName("SFC_SubscriptionId");

            entity.HasOne(d => d.SfcFtpConnection).WithMany(p => p.SubscriptionsFtpConnections)
                .HasForeignKey(d => d.SfcFtpConnectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubscriptionsFtpConnections_SFC_FtpConnectionId__FtpConnections_FC_Id");

            entity.HasOne(d => d.SfcSubscription).WithMany(p => p.SubscriptionsFtpConnections)
                .HasForeignKey(d => d.SfcSubscriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubscriptionsFtpConnections_SFC_SubscriptionId__Subscriptions_SUB_Id");
        });

        modelBuilder.Entity<SubscriptionsParameter>(entity =>
        {
            entity.HasKey(e => e.SprId).HasName("PK_SubscriptionsParameters_SPR_ID");

            entity.ToTable("SubscriptionsParameters", "RB");

            entity.Property(e => e.SprId).HasColumnName("SPR_ID");
            entity.Property(e => e.SprName)
                .HasMaxLength(255)
                .HasColumnName("SPR_Name");
            entity.Property(e => e.SprQuery)
                .HasMaxLength(4000)
                .HasColumnName("SPR_Query");
            entity.Property(e => e.SprSubscriptionId).HasColumnName("SPR_SubscriptionId");
            entity.Property(e => e.SprType).HasColumnName("SPR_Type");

            entity.HasOne(d => d.SprSubscription).WithMany(p => p.SubscriptionsParameters)
                .HasForeignKey(d => d.SprSubscriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubscriptionsParameters_SPR_SubscriptionId__Subscriptions_SUB_Id");
        });

        modelBuilder.Entity<SubscriptionsPhoneUser>(entity =>
        {
            entity.HasKey(e => e.SpuId).HasName("PK_SubscriptionsPhoneUsers_SPU_Id");

            entity.ToTable("SubscriptionsPhoneUsers", "RB");

            entity.Property(e => e.SpuId).HasColumnName("SPU_Id");
            entity.Property(e => e.SpuName)
                .HasMaxLength(64)
                .HasColumnName("SPU_Name");
            entity.Property(e => e.SpuPhone)
                .HasMaxLength(16)
                .HasColumnName("SPU_Phone");
        });

        modelBuilder.Entity<SubscriptionsReport>(entity =>
        {
            entity.HasKey(e => e.SreId).HasName("PK_SubscriptionsReports_SRE_Id");

            entity.ToTable("SubscriptionsReports", "RB");

            entity.Property(e => e.SreId).HasColumnName("SRE_Id");
            entity.Property(e => e.SreFolderId).HasColumnName("SRE_FolderId");
            entity.Property(e => e.SreReportId).HasColumnName("SRE_ReportId");
            entity.Property(e => e.SreSubscriptionId).HasColumnName("SRE_SubscriptionId");

            entity.HasOne(d => d.SreReport).WithMany(p => p.SubscriptionsReports)
                .HasForeignKey(d => d.SreReportId)
                .HasConstraintName("FK_SubscriptionsReports_SRE_ReportId__Reports_REP_Id");

            entity.HasOne(d => d.SreSubscription).WithMany(p => p.SubscriptionsReports)
                .HasForeignKey(d => d.SreSubscriptionId)
                .HasConstraintName("FK_SubscriptionsReports_SRE_SubscriptionId__Subscriptions_SUB_Id");
        });

        modelBuilder.Entity<SubscriptionsReportsParameter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SubscriptionsReportsParameters", "RB");

            entity.Property(e => e.SrpParameterExpression).HasColumnName("SRP_ParameterExpression");
            entity.Property(e => e.SrpParameterLabel)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("SRP_ParameterLabel");
            entity.Property(e => e.SrpParameterName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("SRP_ParameterName");
            entity.Property(e => e.SrpParameterType).HasColumnName("SRP_ParameterType");
            entity.Property(e => e.SrpParameterUniqueId)
                .IsUnicode(false)
                .HasColumnName("SRP_ParameterUniqueID");
            entity.Property(e => e.SrpParameterValue)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("SRP_ParameterValue");
            entity.Property(e => e.SrpSubscriptionsReportsId).HasColumnName("SRP_SubscriptionsReportsId");

            entity.HasOne(d => d.SrpSubscriptionsReports).WithMany()
                .HasForeignKey(d => d.SrpSubscriptionsReportsId)
                .HasConstraintName("FK_SubscriptionsReportsParameters_SRP_SubscriptionsReportsId__SubscriptionsReports_SRE_Id");
        });

        modelBuilder.Entity<SubscriptionsScenario>(entity =>
        {
            entity.HasKey(e => e.SscId).HasName("PK_SubscriptionsScenarios_SSC_ID");

            entity.ToTable("SubscriptionsScenarios", "RB");

            entity.Property(e => e.SscId).HasColumnName("SSC_ID");
            entity.Property(e => e.SscName)
                .HasMaxLength(255)
                .HasColumnName("SSC_Name");
            entity.Property(e => e.SscQuery)
                .HasMaxLength(4000)
                .HasColumnName("SSC_Query");
            entity.Property(e => e.SscSubscriptionId).HasColumnName("SSC_SubscriptionId");

            entity.HasOne(d => d.SscSubscription).WithMany(p => p.SubscriptionsScenarios)
                .HasForeignKey(d => d.SscSubscriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubscriptionsScenarios_SSC_SubscriptionId__Subscriptions_SUB_Id");
        });

        modelBuilder.Entity<SubscriptionsSchedule>(entity =>
        {
            entity.HasKey(e => e.SscId).HasName("PK_SubscriptionsSchedule_SSC_Id");

            entity.ToTable("SubscriptionsSchedule", "RB");

            entity.Property(e => e.SscId).HasColumnName("SSC_Id");
            entity.Property(e => e.SscDayId).HasColumnName("SSC_DayId");
            entity.Property(e => e.SscDayOfMonth).HasColumnName("SSC_DayOfMonth");
            entity.Property(e => e.SscMonthId).HasColumnName("SSC_MonthId");
            entity.Property(e => e.SscSendTime)
                .HasMaxLength(50)
                .HasColumnName("SSC_SendTime");
            entity.Property(e => e.SscSendYear).HasColumnName("SSC_SendYear");
            entity.Property(e => e.SscShortPeriodStartTime)
                .HasMaxLength(50)
                .HasColumnName("SSC_ShortPeriodStartTime");
            entity.Property(e => e.SscSubscriptionId).HasColumnName("SSC_SubscriptionId");

            entity.HasOne(d => d.SscSubscription).WithMany(p => p.SubscriptionsSchedules)
                .HasForeignKey(d => d.SscSubscriptionId)
                .HasConstraintName("FK_SubscriptionsSchedule_SSC_SubscriptionId__Subscriptions_SUB_Id");
        });

        modelBuilder.Entity<SubscriptionsUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SubscriptionsUsers", "RB");

            entity.HasIndex(e => new { e.SusSubscriptionId, e.SusExternalUserId, e.SusGroupId, e.SusUserId, e.SusPhoneUserId }, "UQ_SubscriptionsUsers_SUS_SubscriptionId_SUS_ExternalUserId_SUS_GroupId_SUS_UserId_SUS_PhoneUserId")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SusExternalUserId).HasColumnName("SUS_ExternalUserId");
            entity.Property(e => e.SusGroupId).HasColumnName("SUS_GroupId");
            entity.Property(e => e.SusId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SUS_Id");
            entity.Property(e => e.SusPhoneUserId).HasColumnName("SUS_PhoneUserId");
            entity.Property(e => e.SusSubscriptionId).HasColumnName("SUS_SubscriptionId");
            entity.Property(e => e.SusUserId).HasColumnName("SUS_UserId");

            entity.HasOne(d => d.SusExternalUser).WithMany()
                .HasForeignKey(d => d.SusExternalUserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SubscriptionsUsers_SUS_ExternalUserId__SubscriptionExternalUsers_SEU_Id");

            entity.HasOne(d => d.SusGroup).WithMany()
                .HasForeignKey(d => d.SusGroupId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SubscriptionsUsers_SUS_GroupId__Groups_GRP_Id");

            entity.HasOne(d => d.SusPhoneUser).WithMany()
                .HasForeignKey(d => d.SusPhoneUserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SubscriptionsUsers_SUS_PhoneUserId__SubscriptionsPhoneUsers_SPU_Id");

            entity.HasOne(d => d.SusSubscription).WithMany()
                .HasForeignKey(d => d.SusSubscriptionId)
                .HasConstraintName("FK_SubscriptionsUsers_SUS_SubscriptionId__Subscriptions_SUB_Id");

            entity.HasOne(d => d.SusUser).WithMany()
                .HasForeignKey(d => d.SusUserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SubscriptionsUsers_SUS_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<Synchronization>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Synchronization", "RB");

            entity.Property(e => e.SnhLastSynchroDateTime)
                .HasColumnType("datetime")
                .HasColumnName("SNH_LastSynchroDateTime");
            entity.Property(e => e.SnhLastSynchroTs)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SNH_LastSynchroTs");
            entity.Property(e => e.SnhType).HasColumnName("SNH_Type");
        });

        modelBuilder.Entity<TimeMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TimeMembers_Id");

            entity.Property(e => e.BudgetVersionId).HasComment("One2ManyCascade=all-delete-orphan;Many2OneCascade=none;");
            entity.Property(e => e.LastDataWarehouseLoad).HasColumnType("datetime");
            entity.Property(e => e.MemberId).HasComment("Many2OneCascade=none;");

            entity.HasOne(d => d.BudgetVersion).WithMany(p => p.TimeMembers)
                .HasForeignKey(d => d.BudgetVersionId)
                .HasConstraintName("FK_TimeMembers_BudgetVersionId__BudgetVersions_Id");

            entity.HasOne(d => d.Member).WithMany(p => p.TimeMembers)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeMembers_MemberId__Members_Id");
        });

        modelBuilder.Entity<TransformationDeleteList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TransformationDeleteList", "RB");

            entity.Property(e => e.TdlCompanyId).HasColumnName("TDL_companyId");
            entity.Property(e => e.TdlConnectionid).HasColumnName("TDL_connectionid");
            entity.Property(e => e.TdlDeleteDate)
                .HasColumnType("datetime")
                .HasColumnName("TDL_deleteDate");
            entity.Property(e => e.TdlId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TDL_id");
            entity.Property(e => e.TdlIsdeleted)
                .HasDefaultValue(false)
                .HasColumnName("TDL_isdeleted");
            entity.Property(e => e.TdlTransformationid).HasColumnName("TDL_transformationid");

            entity.HasOne(d => d.TdlConnection).WithMany()
                .HasForeignKey(d => d.TdlConnectionid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransformationDeleteList_TDL_connectionid__Connections_CON_Id");
        });

        modelBuilder.Entity<TransformationList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TransformationList", "RB");

            entity.Property(e => e.TrlCompanyId).HasColumnName("TRL_companyId");
            entity.Property(e => e.TrlDeleteDate)
                .HasColumnType("datetime")
                .HasColumnName("TRL_deleteDate");
            entity.Property(e => e.TrlId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TRL_id");
            entity.Property(e => e.TrlIsDeleted)
                .HasDefaultValue(false)
                .HasColumnName("TRL_isDeleted");
            entity.Property(e => e.TrlLoadDate)
                .HasColumnType("datetime")
                .HasColumnName("TRL_loadDate");
            entity.Property(e => e.TrlUsertransformationId).HasColumnName("TRL_usertransformationId");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Users_Id");

            entity.HasIndex(e => new { e.AccountName, e.Domain }, "UQ_Users_AccountName_Domain").IsUnique();

            entity.Property(e => e.AccountName).HasMaxLength(150);
            entity.Property(e => e.DisplayName).HasMaxLength(100);
            entity.Property(e => e.Domain).HasMaxLength(150);
        });

        modelBuilder.Entity<User1>(entity =>
        {
            entity.HasKey(e => e.UsrId).HasName("PK_Users_USR_Id");

            entity.ToTable("Users", "RB");

            entity.Property(e => e.UsrId).HasColumnName("USR_Id");
            entity.Property(e => e.RowVer).HasDefaultValue(1);
            entity.Property(e => e.UsrEmail)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("USR_Email");
            entity.Property(e => e.UsrHash)
                .HasMaxLength(128)
                .HasColumnName("USR_Hash");
            entity.Property(e => e.UsrIsActive)
                .HasDefaultValue(true)
                .HasColumnName("USR_IsActive");
            entity.Property(e => e.UsrIsDeleted).HasColumnName("USR_IsDeleted");
            entity.Property(e => e.UsrIsIntegrated).HasColumnName("USR_IsIntegrated");
            entity.Property(e => e.UsrLastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("USR_LastUpdate");
            entity.Property(e => e.UsrLogin)
                .HasMaxLength(256)
                .HasDefaultValue(" ")
                .HasColumnName("USR_Login");
            entity.Property(e => e.UsrName)
                .HasMaxLength(64)
                .HasColumnName("USR_Name");
            entity.Property(e => e.UsrNtAccount)
                .HasMaxLength(128)
                .HasColumnName("USR_NtAccount");
            entity.Property(e => e.UsrPassword)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("USR_Password");
            entity.Property(e => e.UsrPhone)
                .HasMaxLength(30)
                .HasColumnName("USR_Phone");
            entity.Property(e => e.UsrSid)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USR_SID");
            entity.Property(e => e.UsrSourceSystemId).HasColumnName("USR_SourceSystem_Id");
            entity.Property(e => e.UsrSurname)
                .HasMaxLength(64)
                .HasColumnName("USR_Surname");
            entity.Property(e => e.UsrWinAccount)
                .HasMaxLength(128)
                .HasColumnName("USR_WinAccount");

            entity.HasMany(d => d.RurRoles).WithMany(p => p.RurUsers)
                .UsingEntity<Dictionary<string, object>>(
                    "RestrictUserRole",
                    r => r.HasOne<RestrictRole>().WithMany()
                        .HasForeignKey("RurRoleId")
                        .HasConstraintName("FK_RestrictUserRoles_RUR_RoleId__RestrictRoles_RRL_Id"),
                    l => l.HasOne<User1>().WithMany()
                        .HasForeignKey("RurUserId")
                        .HasConstraintName("FK_RestrictUserRoles_RUR_UserId__Users_USR_Id"),
                    j =>
                    {
                        j.HasKey("RurUserId", "RurRoleId").HasName("PK_RestrictUserRoles_RUR_UserId_RUR_RoleId");
                        j.ToTable("RestrictUserRoles", "RB");
                        j.IndexerProperty<int>("RurUserId").HasColumnName("RUR_UserId");
                        j.IndexerProperty<int>("RurRoleId").HasColumnName("RUR_RoleId");
                    });
        });

        modelBuilder.Entity<UserDatabase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserDatabases", "RB");

            entity.HasIndex(e => new { e.UdbConnectionId, e.UdbUserId, e.UdbExternalUserId }, "UNQ_UserDatabases_UDB_ConnectionId_UDB_UserId_UDB_ExternalUserId")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.UdbConnectionId).HasColumnName("UDB_ConnectionId");
            entity.Property(e => e.UdbExternalUserId).HasColumnName("UDB_ExternalUserId");
            entity.Property(e => e.UdbIsDefaultMdxSqlRaportDatabase).HasColumnName("UDB_IsDefaultMdxSqlRaportDatabase");
            entity.Property(e => e.UdbUserId).HasColumnName("UDB_UserId");

            entity.HasOne(d => d.UdbConnection).WithMany()
                .HasForeignKey(d => d.UdbConnectionId)
                .HasConstraintName("FK_UserDatabases_UDB_ConnectionId__Connections_CON_Id");

            entity.HasOne(d => d.UdbUser).WithMany()
                .HasForeignKey(d => d.UdbUserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UserDatabases_UDB_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<UserFavouritesDimensionMeasure>(entity =>
        {
            entity.HasKey(e => e.UfdmId).HasName("PK_UserFavouritesDimensionMeasure_UFDM_Id");

            entity.ToTable("UserFavouritesDimensionMeasure", "RB");

            entity.Property(e => e.UfdmId).HasColumnName("UFDM_Id");
            entity.Property(e => e.UfdmIsInMemory).HasColumnName("UFDM_IsInMemory");
            entity.Property(e => e.UfdmSourceIdentifier)
                .IsUnicode(false)
                .HasColumnName("UFDM_SourceIdentifier");
            entity.Property(e => e.UfdmUserId).HasColumnName("UFDM_UserId");

            entity.HasOne(d => d.UfdmUser).WithMany(p => p.UserFavouritesDimensionMeasures)
                .HasForeignKey(d => d.UfdmUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserFavouritesDimensionMeasure_UFDM_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<UserFavouritesDimensionMeasureItem>(entity =>
        {
            entity.HasKey(e => e.UfiId).HasName("PK_UserFavouritesDimensionMeasureItems_UFI_Id");

            entity.ToTable("UserFavouritesDimensionMeasureItems", "RB");

            entity.Property(e => e.UfiId).HasColumnName("UFI_Id");
            entity.Property(e => e.UfiItemUniqueName)
                .IsUnicode(false)
                .HasColumnName("UFI_ItemUniqueName");
            entity.Property(e => e.UfiNodeType)
                .IsUnicode(false)
                .HasColumnName("UFI_NodeType");
            entity.Property(e => e.UfiParentId).HasColumnName("UFI_ParentId");

            entity.HasOne(d => d.UfiParent).WithMany(p => p.UserFavouritesDimensionMeasureItems)
                .HasForeignKey(d => d.UfiParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserFavouritesDimensionMeasureItems_UFI_ParentId__UserFavouritesDimensionMeasure__UFDM_Id");
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserGroups_Id");

            entity.HasOne(d => d.Group).WithMany(p => p.UserGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserGroups_GroupId__Groups_Id");

            entity.HasOne(d => d.User).WithMany(p => p.UserGroups)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserGroups_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<UserImage>(entity =>
        {
            entity.HasKey(e => e.UimId).HasName("PK_UserImages_UIM_Id");

            entity.ToTable("UserImages", "RB");

            entity.Property(e => e.UimId)
                .ValueGeneratedNever()
                .HasColumnName("UIM_Id");
            entity.Property(e => e.UimImage)
                .IsUnicode(false)
                .HasColumnName("UIM_Image");
            entity.Property(e => e.UimImageMin)
                .IsUnicode(false)
                .HasColumnName("UIM_ImageMin");

            entity.HasOne(d => d.Uim).WithOne(p => p.UserImage)
                .HasForeignKey<UserImage>(d => d.UimId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserImages_UIM_Id__Users_USR_Id");
        });

        modelBuilder.Entity<UserInvitationToCompany>(entity =>
        {
            entity.HasKey(e => e.UitcId).HasName("PK_UserInvitationToCompany_UITC_Id");

            entity.ToTable("UserInvitationToCompany", "RB");

            entity.Property(e => e.UitcId).HasColumnName("UITC_Id");
            entity.Property(e => e.UitcAccountActiveId).HasColumnName("UITC_AccountActiveId");
            entity.Property(e => e.UitcEmail)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("UITC_Email");
            entity.Property(e => e.UitcHash)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("UITC_Hash");
            entity.Property(e => e.UitcWorkModeId).HasColumnName("UITC_WorkModeId");

            entity.HasOne(d => d.UitcAccountActive).WithMany(p => p.UserInvitationToCompanies)
                .HasForeignKey(d => d.UitcAccountActiveId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserInvitationToCompany_UITC_AccountActiveId__AccountActive_ACC_ID");

            entity.HasOne(d => d.UitcWorkMode).WithMany(p => p.UserInvitationToCompanies)
                .HasForeignKey(d => d.UitcWorkModeId)
                .HasConstraintName("FK_UserInvitationToCompany_UITC_WorkModeId__WorkMode_WOR_Id");
        });

        modelBuilder.Entity<UserSetting>(entity =>
        {
            entity.HasKey(e => new { e.UstUsrId, e.UstSetId }).HasName("PK_UserSettings_UST_USR_Id_UST_SET_Id");

            entity.ToTable("UserSettings", "RB");

            entity.Property(e => e.UstUsrId).HasColumnName("UST_USR_Id");
            entity.Property(e => e.UstSetId).HasColumnName("UST_SET_Id");
            entity.Property(e => e.UstCompanyId)
                .HasDefaultValue(1)
                .HasColumnName("UST_CompanyId");
            entity.Property(e => e.UstValue).HasColumnName("UST_Value");

            entity.HasOne(d => d.UstCompany).WithMany(p => p.UserSettings)
                .HasForeignKey(d => d.UstCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserSettings_UST_CompanyId__Companies_COM_ID");

            entity.HasOne(d => d.UstSet).WithMany(p => p.UserSettings)
                .HasForeignKey(d => d.UstSetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserSettings_UST_SET_Id__Settings_SET_Id");

            entity.HasOne(d => d.UstUsr).WithMany(p => p.UserSettings)
                .HasForeignKey(d => d.UstUsrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserSettings_UST_USR_Id__Users_USR_Id");
        });

        modelBuilder.Entity<UserWorkmodeHomedashboard>(entity =>
        {
            entity.HasKey(e => e.UwhId).HasName("PK_UserWorkmodeHomedashboard_UWH_Id");

            entity.ToTable("UserWorkmodeHomedashboard", "RB");

            entity.Property(e => e.UwhId).HasColumnName("UWH_Id");
            entity.Property(e => e.UwhCompanyId).HasColumnName("UWH_CompanyId");
            entity.Property(e => e.UwhHomeReportId).HasColumnName("UWH_HomeReportId");
            entity.Property(e => e.UwhUserId).HasColumnName("UWH_UserId");
            entity.Property(e => e.UwhWorkModeId).HasColumnName("UWH_WorkModeId");

            entity.HasOne(d => d.UwhCompany).WithMany(p => p.UserWorkmodeHomedashboards)
                .HasForeignKey(d => d.UwhCompanyId)
                .HasConstraintName("FK_UserWorkmodeHomedashboard_UWH_CompanyId__Companies_COM_ID");

            entity.HasOne(d => d.UwhHomeReport).WithMany(p => p.UserWorkmodeHomedashboards)
                .HasForeignKey(d => d.UwhHomeReportId)
                .HasConstraintName("FK_UserWorkmodeHomedashboard_UWH_HomeReportId__Reports_REP_Id");

            entity.HasOne(d => d.UwhUser).WithMany(p => p.UserWorkmodeHomedashboards)
                .HasForeignKey(d => d.UwhUserId)
                .HasConstraintName("FK_UserWorkmodeHomedashboard_UWH_UserId__Users_USR_Id");

            entity.HasOne(d => d.UwhWorkMode).WithMany(p => p.UserWorkmodeHomedashboards)
                .HasForeignKey(d => d.UwhWorkModeId)
                .HasConstraintName("FK_UserWorkmodeHomedashboard_UWH_WorkModeId__WorkMode_WOR_Id");
        });

        modelBuilder.Entity<UsersPermissionsOlapMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UsersPermissionsOlapMember", "RM");

            entity.HasOne(d => d.OlapMember).WithMany()
                .HasForeignKey(d => d.OlapMemberId)
                .HasConstraintName("FK_UsersPermissionsOlapMember_OlapMemberId__PermissionsOlapMember_Id");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UsersPermissionsOlapMember_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<UsersRecentlyUsed>(entity =>
        {
            entity.HasKey(e => new { e.UreUserId, e.UreCompanyId, e.UreReportId }).HasName("PK_UsersRecentlyUsed_URE_UserId_URE_CompanyId_URE_ReportId");

            entity.ToTable("UsersRecentlyUsed", "RB");

            entity.Property(e => e.UreUserId).HasColumnName("URE_UserId");
            entity.Property(e => e.UreCompanyId).HasColumnName("URE_CompanyId");
            entity.Property(e => e.UreReportId).HasColumnName("URE_ReportId");
            entity.Property(e => e.UreDate)
                .HasColumnType("datetime")
                .HasColumnName("URE_Date");

            entity.HasOne(d => d.UreCompany).WithMany(p => p.UsersRecentlyUseds)
                .HasForeignKey(d => d.UreCompanyId)
                .HasConstraintName("FK_UsersRecentlyUsed_URE_CompanyId__Companies_COM_ID");

            entity.HasOne(d => d.UreReport).WithMany(p => p.UsersRecentlyUseds)
                .HasForeignKey(d => d.UreReportId)
                .HasConstraintName("FK_UsersRecentlyUsed_URE_ReportId__Reports_REP_Id");

            entity.HasOne(d => d.UreUser).WithMany(p => p.UsersRecentlyUseds)
                .HasForeignKey(d => d.UreUserId)
                .HasConstraintName("FK_UsersRecentlyUsed_URE_UserId__Users_USR_Id");
        });

        modelBuilder.Entity<WorkMode>(entity =>
        {
            entity.HasKey(e => e.WorId).HasName("PK_WorkMode_WOR_Id");

            entity.ToTable("WorkMode", "RB");

            entity.Property(e => e.WorId).HasColumnName("WOR_Id");
            entity.Property(e => e.WorCompanyId)
                .HasDefaultValue(1)
                .HasColumnName("WOR_CompanyId");
            entity.Property(e => e.WorCountDay).HasColumnName("WOR_CountDay");
            entity.Property(e => e.WorDataModelsDefinitionId).HasColumnName("WOR_DataModelsDefinitionId");
            entity.Property(e => e.WorDemoReportsPath)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("WOR_DemoReportsPath");
            entity.Property(e => e.WorHasOwnDw).HasColumnName("WOR_HasOwnDW");
            entity.Property(e => e.WorIsMultiCompany).HasColumnName("WOR_IsMultiCompany");
            entity.Property(e => e.WorIsPaymentWorkMode).HasColumnName("WOR_IsPaymentWorkMode");
            entity.Property(e => e.WorIsPerMonthPayment).HasColumnName("WOR_IsPerMonthPayment");
            entity.Property(e => e.WorIsPerUserPayment).HasColumnName("WOR_IsPerUserPayment");
            entity.Property(e => e.WorName)
                .HasMaxLength(128)
                .HasColumnName("WOR_Name");
            entity.Property(e => e.WorStandardReportsPath)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("WOR_StandardReportsPath");

            entity.HasOne(d => d.WorCompany).WithMany(p => p.WorkModes)
                .HasForeignKey(d => d.WorCompanyId)
                .HasConstraintName("FK_WorkMode_WOR_CompanyId__Companies_COM_ID");

            entity.HasOne(d => d.WorDataModelsDefinition).WithMany(p => p.WorkModes)
                .HasForeignKey(d => d.WorDataModelsDefinitionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WorkMode_WOR_DataModelsDefinitionId__DataModelsDefinitions_DMD_Id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
