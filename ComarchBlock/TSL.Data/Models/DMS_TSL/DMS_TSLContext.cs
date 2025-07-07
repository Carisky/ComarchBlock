using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TSL.Data.Models.DMS_TSL;

public partial class DMS_TSLContext : DbContext
{
    public DMS_TSLContext(DbContextOptions<DMS_TSLContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DfApiKey> DfApiKeys { get; set; }

    public virtual DbSet<DfApplication> DfApplications { get; set; }

    public virtual DbSet<DfChangePasswordTmp> DfChangePasswordTmps { get; set; }

    public virtual DbSet<DfConf> DfConfs { get; set; }

    public virtual DbSet<DfConfAnonymizableControl> DfConfAnonymizableControls { get; set; }

    public virtual DbSet<DfConfApaccess> DfConfApaccesses { get; set; }

    public virtual DbSet<DfConfApattribute> DfConfApattributes { get; set; }

    public virtual DbSet<DfConfApcontrol> DfConfApcontrols { get; set; }

    public virtual DbSet<DfConfApdictionary> DfConfApdictionaries { get; set; }

    public virtual DbSet<DfConfApfolderPath> DfConfApfolderPaths { get; set; }

    public virtual DbSet<DfConfAptemplate> DfConfAptemplates { get; set; }

    public virtual DbSet<DfConfCfCtrlAnalitycalDescription> DfConfCfCtrlAnalitycalDescriptions { get; set; }

    public virtual DbSet<DfConfCfattachmentArchiveDocumentTypeSetting> DfConfCfattachmentArchiveDocumentTypeSettings { get; set; }

    public virtual DbSet<DfConfCfattachmentArchiveDocumentTypeSettingsMapping> DfConfCfattachmentArchiveDocumentTypeSettingsMappings { get; set; }

    public virtual DbSet<DfConfCfcardDokFlow> DfConfCfcardDokFlows { get; set; }

    public virtual DbSet<DfConfCfcontrolSection> DfConfCfcontrolSections { get; set; }

    public virtual DbSet<DfConfCfctrlDictionary> DfConfCfctrlDictionaries { get; set; }

    public virtual DbSet<DfConfCfctrlType> DfConfCfctrlTypes { get; set; }

    public virtual DbSet<DfConfCfcustomList> DfConfCfcustomLists { get; set; }

    public virtual DbSet<DfConfCfmultiLineCtrlColumn> DfConfCfmultiLineCtrlColumns { get; set; }

    public virtual DbSet<DfConfCfmultiLineCtrlList> DfConfCfmultiLineCtrlLists { get; set; }

    public virtual DbSet<DfConfCfrelatedControl> DfConfCfrelatedControls { get; set; }

    public virtual DbSet<DfConfCfrelatedWorkflowType> DfConfCfrelatedWorkflowTypes { get; set; }

    public virtual DbSet<DfConfCftab> DfConfCftabs { get; set; }

    public virtual DbSet<DfConfCmdictionary> DfConfCmdictionaries { get; set; }

    public virtual DbSet<DfConfCmsetting> DfConfCmsettings { get; set; }

    public virtual DbSet<DfConfDaysOff> DfConfDaysOffs { get; set; }

    public virtual DbSet<DfConfDsaccess> DfConfDsaccesses { get; set; }

    public virtual DbSet<DfConfDsconnection> DfConfDsconnections { get; set; }

    public virtual DbSet<DfConfDsctrlCondition> DfConfDsctrlConditions { get; set; }

    public virtual DbSet<DfConfDsdictionary> DfConfDsdictionaries { get; set; }

    public virtual DbSet<DfConfDshead> DfConfDsheads { get; set; }

    public virtual DbSet<DfConfDsscheme> DfConfDsschemes { get; set; }

    public virtual DbSet<DfConfDssetting> DfConfDssettings { get; set; }

    public virtual DbSet<DfConfDssettingsAccessCreator> DfConfDssettingsAccessCreators { get; set; }

    public virtual DbSet<DfConfDssettingsAdvancedSearchControl> DfConfDssettingsAdvancedSearchControls { get; set; }

    public virtual DbSet<DfConfDssettingsObserver> DfConfDssettingsObservers { get; set; }

    public virtual DbSet<DfConfDssettingsOutboxBookStage> DfConfDssettingsOutboxBookStages { get; set; }

    public virtual DbSet<DfConfEmployeeAttachment> DfConfEmployeeAttachments { get; set; }

    public virtual DbSet<DfConfMultilineColumnEditRestriction> DfConfMultilineColumnEditRestrictions { get; set; }

    public virtual DbSet<DfConfNotificationsForWorkflow> DfConfNotificationsForWorkflows { get; set; }

    public virtual DbSet<DfConfOsdictionary> DfConfOsdictionaries { get; set; }

    public virtual DbSet<DfConfOsemployeePosition> DfConfOsemployeePositions { get; set; }

    public virtual DbSet<DfConfOsemployeesQueue> DfConfOsemployeesQueues { get; set; }

    public virtual DbSet<DfConfOsflowAccess> DfConfOsflowAccesses { get; set; }

    public virtual DbSet<DfConfOstree> DfConfOstrees { get; set; }

    public virtual DbSet<DfConfOsworkflowSetting> DfConfOsworkflowSettings { get; set; }

    public virtual DbSet<DfConfPrint> DfConfPrints { get; set; }

    public virtual DbSet<DfConfRbaccess> DfConfRbaccesses { get; set; }

    public virtual DbSet<DfConfRbdictionary> DfConfRbdictionaries { get; set; }

    public virtual DbSet<DfConfReminder> DfConfReminders { get; set; }

    public virtual DbSet<DfConfStampDictionary> DfConfStampDictionaries { get; set; }

    public virtual DbSet<DfConfSystemLoggerSetting> DfConfSystemLoggerSettings { get; set; }

    public virtual DbSet<DfConfUrdokListColumnSetting> DfConfUrdokListColumnSettings { get; set; }

    public virtual DbSet<DfConfWorkflowDirectory> DfConfWorkflowDirectories { get; set; }

    public virtual DbSet<DfConfWorkflowPattern> DfConfWorkflowPatterns { get; set; }

    public virtual DbSet<DfConfXlLicence> DfConfXlLicences { get; set; }

    public virtual DbSet<DfDashboard> DfDashboards { get; set; }

    public virtual DbSet<DfDashboardsAccess> DfDashboardsAccesses { get; set; }

    public virtual DbSet<DfHeadDokumentFlow> DfHeadDokumentFlows { get; set; }

    public virtual DbSet<DfNotificationToken> DfNotificationTokens { get; set; }

    public virtual DbSet<DfOneTimeToken> DfOneTimeTokens { get; set; }

    public virtual DbSet<DfRefreshToken> DfRefreshTokens { get; set; }

    public virtual DbSet<DfReport> DfReports { get; set; }

    public virtual DbSet<DfReportsAccess> DfReportsAccesses { get; set; }

    public virtual DbSet<DfReportsWorkflowTypesAccess> DfReportsWorkflowTypesAccesses { get; set; }

    public virtual DbSet<DfSession> DfSessions { get; set; }

    public virtual DbSet<DfSessionHistory> DfSessionHistories { get; set; }

    public virtual DbSet<DfWork> DfWorks { get; set; }

    public virtual DbSet<DfWorkAddimension> DfWorkAddimensions { get; set; }

    public virtual DbSet<DfWorkAdheader> DfWorkAdheaders { get; set; }

    public virtual DbSet<DfWorkAdheaderHistory> DfWorkAdheaderHistories { get; set; }

    public virtual DbSet<DfWorkAditem> DfWorkAditems { get; set; }

    public virtual DbSet<DfWorkAdvalue> DfWorkAdvalues { get; set; }

    public virtual DbSet<DfWorkAnonymizableLog> DfWorkAnonymizableLogs { get; set; }

    public virtual DbSet<DfWorkApprocess> DfWorkApprocesses { get; set; }

    public virtual DbSet<DfWorkCf> DfWorkCfs { get; set; }

    public virtual DbSet<DfWorkCfbin> DfWorkCfbins { get; set; }

    public virtual DbSet<DfWorkCfhistory> DfWorkCfhistories { get; set; }

    public virtual DbSet<DfWorkCfmultiLine> DfWorkCfmultiLines { get; set; }

    public virtual DbSet<DfWorkCfmultiLineHistory> DfWorkCfmultiLineHistories { get; set; }

    public virtual DbSet<DfWorkCfworkflowDocument> DfWorkCfworkflowDocuments { get; set; }

    public virtual DbSet<DfWorkCounter> DfWorkCounters { get; set; }

    public virtual DbSet<DfWorkCustomContentDiagnosticLog> DfWorkCustomContentDiagnosticLogs { get; set; }

    public virtual DbSet<DfWorkCustomContentDiagnosticSession> DfWorkCustomContentDiagnosticSessions { get; set; }

    public virtual DbSet<DfWorkCustomContentType> DfWorkCustomContentTypes { get; set; }

    public virtual DbSet<DfWorkD> DfWorkDs { get; set; }

    public virtual DbSet<DfWorkDsaccess> DfWorkDsaccesses { get; set; }

    public virtual DbSet<DfWorkDsaccessLimited> DfWorkDsaccessLimiteds { get; set; }

    public virtual DbSet<DfWorkDscurrentStageAccess> DfWorkDscurrentStageAccesses { get; set; }

    public virtual DbSet<DfWorkDscurrentStageAccessLimited> DfWorkDscurrentStageAccessLimiteds { get; set; }

    public virtual DbSet<DfWorkDsparallelApproval> DfWorkDsparallelApprovals { get; set; }

    public virtual DbSet<DfWorkErpXlaccrualNoteItem> DfWorkErpXlaccrualNoteItems { get; set; }

    public virtual DbSet<DfWorkErpXlarticle> DfWorkErpXlarticles { get; set; }

    public virtual DbSet<DfWorkErpXlarticlesHistory> DfWorkErpXlarticlesHistories { get; set; }

    public virtual DbSet<DfWorkErpXldocument> DfWorkErpXldocuments { get; set; }

    public virtual DbSet<DfWorkErpXldocumentHistory> DfWorkErpXldocumentHistories { get; set; }

    public virtual DbSet<DfWorkLogEntry> DfWorkLogEntries { get; set; }

    public virtual DbSet<DfWorkOsclosedDoc> DfWorkOsclosedDocs { get; set; }

    public virtual DbSet<DfWorkOsnotification> DfWorkOsnotifications { get; set; }

    public virtual DbSet<DfWorkOsworkDoc> DfWorkOsworkDocs { get; set; }

    public virtual DbSet<DfWorkUserLoginHistory> DfWorkUserLoginHistories { get; set; }

    public virtual DbSet<DmAccess> DmAccesses { get; set; }

    public virtual DbSet<DmDocumentsBin> DmDocumentsBins { get; set; }

    public virtual DbSet<DmHeadTree> DmHeadTrees { get; set; }

    public virtual DbSet<EdError> EdErrors { get; set; }

    public virtual DbSet<EdMessage> EdMessages { get; set; }

    public virtual DbSet<EdMessageAttachment> EdMessageAttachments { get; set; }

    public virtual DbSet<EdWorkApprocess> EdWorkApprocesses { get; set; }

    public virtual DbSet<GetGuid> GetGuids { get; set; }

    public virtual DbSet<KsAdditionalDescription> KsAdditionalDescriptions { get; set; }

    public virtual DbSet<KsAsidocument> KsAsidocuments { get; set; }

    public virtual DbSet<KsBankAccount> KsBankAccounts { get; set; }

    public virtual DbSet<KsDeductionSettlement> KsDeductionSettlements { get; set; }

    public virtual DbSet<KsDocument> KsDocuments { get; set; }

    public virtual DbSet<KsDocumentAgreement> KsDocumentAgreements { get; set; }

    public virtual DbSet<KsDocumentContractor> KsDocumentContractors { get; set; }

    public virtual DbSet<KsDocumentFooter> KsDocumentFooters { get; set; }

    public virtual DbSet<KsDocumentHeader> KsDocumentHeaders { get; set; }

    public virtual DbSet<KsDocumentItem> KsDocumentItems { get; set; }

    public virtual DbSet<KsDocumentLotNumber> KsDocumentLotNumbers { get; set; }

    public virtual DbSet<KsDocumentOrder> KsDocumentOrders { get; set; }

    public virtual DbSet<KsDocumentOrderItem> KsDocumentOrderItems { get; set; }

    public virtual DbSet<KsError> KsErrors { get; set; }

    public virtual DbSet<KsFactorBankAccount> KsFactorBankAccounts { get; set; }

    public virtual DbSet<KsLoadSettlement> KsLoadSettlements { get; set; }

    public virtual DbSet<KsPartialPayment> KsPartialPayments { get; set; }

    public virtual DbSet<KsPaymentDate> KsPaymentDates { get; set; }

    public virtual DbSet<KsShipmentAddress> KsShipmentAddresses { get; set; }

    public virtual DbSet<KsSordocument> KsSordocuments { get; set; }

    public virtual DbSet<KsTransport> KsTransports { get; set; }

    public virtual DbSet<KsTransportMean> KsTransportMeans { get; set; }

    public virtual DbSet<KsWorkApprocess> KsWorkApprocesses { get; set; }

    public virtual DbSet<LeOrderStage> LeOrderStages { get; set; }

    public virtual DbSet<LgHead> LgHeads { get; set; }

    public virtual DbSet<LgLanguage> LgLanguages { get; set; }

    public virtual DbSet<LgWorkUser> LgWorkUsers { get; set; }

    public virtual DbSet<MdSession> MdSessions { get; set; }

    public virtual DbSet<MlError> MlErrors { get; set; }

    public virtual DbSet<MlMail> MlMails { get; set; }

    public virtual DbSet<MlMailAttachment> MlMailAttachments { get; set; }

    public virtual DbSet<MlWorkApprocess> MlWorkApprocesses { get; set; }

    public virtual DbSet<OcDocument> OcDocuments { get; set; }

    public virtual DbSet<OcDocumentBarcode> OcDocumentBarcodes { get; set; }

    public virtual DbSet<OcDocumentItem> OcDocumentItems { get; set; }

    public virtual DbSet<OcDocumentJpkcode> OcDocumentJpkcodes { get; set; }

    public virtual DbSet<OcDocumentVatRegistry> OcDocumentVatRegistries { get; set; }

    public virtual DbSet<OcError> OcErrors { get; set; }

    public virtual DbSet<OcFilelock> OcFilelocks { get; set; }

    public virtual DbSet<OcWorkApprocess> OcWorkApprocesses { get; set; }

    public virtual DbSet<PmProcessMail> PmProcessMails { get; set; }

    public virtual DbSet<PmaProcessMailsAttachment> PmaProcessMailsAttachments { get; set; }

    public virtual DbSet<RoControlsValue> RoControlsValues { get; set; }

    public virtual DbSet<RoControlsValueExpand> RoControlsValueExpands { get; set; }

    public virtual DbSet<RoCustomContentDiagnosticLogDetail> RoCustomContentDiagnosticLogDetails { get; set; }

    public virtual DbSet<RoDocAccess> RoDocAccesses { get; set; }

    public virtual DbSet<RoDocument> RoDocuments { get; set; }

    public virtual DbSet<RoEmployee> RoEmployees { get; set; }

    public virtual DbSet<RoEmployeePermission> RoEmployeePermissions { get; set; }

    public virtual DbSet<RoExpiredDoc> RoExpiredDocs { get; set; }

    public virtual DbSet<RoObjectsType> RoObjectsTypes { get; set; }

    public virtual DbSet<RoStageActive> RoStageActives { get; set; }

    public virtual DbSet<RoStageAll> RoStageAlls { get; set; }

    public virtual DbSet<RsGroup> RsGroups { get; set; }

    public virtual DbSet<RsReservation> RsReservations { get; set; }

    public virtual DbSet<RsResource> RsResources { get; set; }

    public virtual DbSet<RsResourceCompany> RsResourceCompanies { get; set; }

    public virtual DbSet<SbCustomQuery> SbCustomQueries { get; set; }

    public virtual DbSet<SbSession> SbSessions { get; set; }

    public virtual DbSet<SbSqlquery> SbSqlqueries { get; set; }

    public virtual DbSet<SlDocument> SlDocuments { get; set; }

    public virtual DbSet<SlDocumentBankAccount> SlDocumentBankAccounts { get; set; }

    public virtual DbSet<SlDocumentItem> SlDocumentItems { get; set; }

    public virtual DbSet<SlDocumentVatRegistry> SlDocumentVatRegistries { get; set; }

    public virtual DbSet<SlError> SlErrors { get; set; }

    public virtual DbSet<SlItem> SlItems { get; set; }

    public virtual DbSet<SlWorkApprocess> SlWorkApprocesses { get; set; }

    public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DfApiKey>(entity =>
        {
            entity.HasKey(e => e.ApkId);

            entity.ToTable("DF_ApiKeys", "do", tb => tb.HasTrigger("UpdateRefreshTokensOnApiKeyChanges"));

            entity.Property(e => e.ApkId).HasColumnName("APK_ID");
            entity.Property(e => e.ApkAppid).HasColumnName("APK_APPId");
            entity.Property(e => e.ApkCmdid).HasColumnName("APK_CMDId");
            entity.Property(e => e.ApkDcdid).HasColumnName("APK_DCDId");
            entity.Property(e => e.ApkGuid).HasColumnName("APK_Guid");
            entity.Property(e => e.ApkRevoked)
                .HasDefaultValue(false)
                .HasColumnName("APK_Revoked");

            entity.HasOne(d => d.ApkApp).WithMany(p => p.DfApiKeys)
                .HasForeignKey(d => d.ApkAppid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ApiKeys_DF_Applications");

            entity.HasOne(d => d.ApkCmd).WithMany(p => p.DfApiKeys)
                .HasForeignKey(d => d.ApkCmdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ApiKeys_DF_ConfCMDictionary");

            entity.HasOne(d => d.ApkDcd).WithMany(p => p.DfApiKeys)
                .HasForeignKey(d => d.ApkDcdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ApiKeys_DF_ConfOSDictionary");
        });

        modelBuilder.Entity<DfApplication>(entity =>
        {
            entity.HasKey(e => e.AppId);

            entity.ToTable("DF_Applications", "do");

            entity.Property(e => e.AppId).HasColumnName("APP_Id");
            entity.Property(e => e.AppArchival).HasColumnName("APP_Archival");
            entity.Property(e => e.AppGuid).HasColumnName("APP_Guid");
            entity.Property(e => e.AppName)
                .HasMaxLength(255)
                .HasColumnName("APP_Name");
        });

        modelBuilder.Entity<DfChangePasswordTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ChangePasswordTmp", "do");

            entity.HasIndex(e => e.CptDcdid, "I_DF_ChangePasswordTmp").IsClustered();

            entity.Property(e => e.CptAction).HasColumnName("CPT_Action");
            entity.Property(e => e.CptDcdid).HasColumnName("CPT_DCDID");
            entity.Property(e => e.CptGuid).HasColumnName("CPT_Guid");
            entity.Property(e => e.CptIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("CPT_IssueDate");
        });

        modelBuilder.Entity<DfConf>(entity =>
        {
            entity.HasKey(e => e.CId);

            entity.ToTable("DF_Conf", "do");

            entity.Property(e => e.CId).HasColumnName("C_ID");
            entity.Property(e => e.CKey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("C_KEY");
            entity.Property(e => e.CLongvalue)
                .HasColumnType("text")
                .HasColumnName("C_LONGVALUE");
            entity.Property(e => e.CValue)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("C_VALUE");
        });

        modelBuilder.Entity<DfConfAnonymizableControl>(entity =>
        {
            entity.HasKey(e => e.CasId);

            entity.ToTable("DF_ConfAnonymizableControls", "do");

            entity.Property(e => e.CasId).HasColumnName("CAS_ID");
            entity.Property(e => e.CasArchival).HasColumnName("CAS_Archival");
            entity.Property(e => e.CasColumnName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CAS_ColumnName");
            entity.Property(e => e.CasControlName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CAS_ControlName");
            entity.Property(e => e.CasDctid).HasColumnName("CAS_DCTId");
            entity.Property(e => e.CasDfhid).HasColumnName("CAS_DFHId");
        });

        modelBuilder.Entity<DfConfApaccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfAPAccess", "do");

            entity.Property(e => e.ApaApdid).HasColumnName("APA_APDId");
            entity.Property(e => e.ApaArchival).HasColumnName("APA_Archival");
            entity.Property(e => e.ApaCanEditDocument).HasColumnName("APA_CanEditDocument");
            entity.Property(e => e.ApaDcdid).HasColumnName("APA_DCDId");

            entity.HasOne(d => d.ApaApd).WithMany()
                .HasForeignKey(d => d.ApaApdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfAPAccess_DF_ConfAPDictionary");

            entity.HasOne(d => d.ApaDcd).WithMany()
                .HasForeignKey(d => d.ApaDcdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfAPAccess_DF_ConfOSDictionary");
        });

        modelBuilder.Entity<DfConfApattribute>(entity =>
        {
            entity.HasKey(e => e.ApatId);

            entity.ToTable("DF_ConfAPAttribute", "do");

            entity.Property(e => e.ApatId).HasColumnName("APAT_ID");
            entity.Property(e => e.ApatApdid).HasColumnName("APAT_APDId");
            entity.Property(e => e.ApatArchival).HasColumnName("APAT_Archival");
            entity.Property(e => e.ApatExternalId)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("APAT_ExternalId");
            entity.Property(e => e.ApatName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APAT_Name");
            entity.Property(e => e.ApatRequired).HasColumnName("APAT_Required");
            entity.Property(e => e.ApatSqlQuery)
                .HasColumnType("text")
                .HasColumnName("APAT_SqlQuery");
            entity.Property(e => e.ApatType).HasColumnName("APAT_Type");
        });

        modelBuilder.Entity<DfConfApcontrol>(entity =>
        {
            entity.HasKey(e => e.ApcId);

            entity.ToTable("DF_ConfAPControl", "do");

            entity.Property(e => e.ApcId).HasColumnName("APC_ID");
            entity.Property(e => e.ApcApdid).HasColumnName("APC_APDId");
            entity.Property(e => e.ApcArchival).HasColumnName("APC_Archival");
            entity.Property(e => e.ApcDctid).HasColumnName("APC_DCTId");
            entity.Property(e => e.ApcDfhid).HasColumnName("APC_DFHId");
            entity.Property(e => e.ApcDkodisplayName)
                .HasMaxLength(511)
                .IsUnicode(false)
                .HasColumnName("APC_DKODisplayName");
            entity.Property(e => e.ApcDkoguid).HasColumnName("APC_DKOGuid");
            entity.Property(e => e.ApcDkoname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APC_DKOName");
            entity.Property(e => e.ApcMode).HasColumnName("APC_Mode");
            entity.Property(e => e.ApcSqlQuery)
                .HasColumnType("text")
                .HasColumnName("APC_SqlQuery");

            entity.HasOne(d => d.ApcApd).WithMany(p => p.DfConfApcontrols)
                .HasForeignKey(d => d.ApcApdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfAPControl_DF_ConfAPDictionary");
        });

        modelBuilder.Entity<DfConfApdictionary>(entity =>
        {
            entity.HasKey(e => e.ApdId);

            entity.ToTable("DF_ConfAPDictionary", "do");

            entity.Property(e => e.ApdId).HasColumnName("APD_ID");
            entity.Property(e => e.ApdArchival).HasColumnName("APD_Archival");
            entity.Property(e => e.ApdAttachmentControlName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APD_AttachmentControlName");
            entity.Property(e => e.ApdCompanyId).HasColumnName("APD_CompanyId");
            entity.Property(e => e.ApdConnectionString)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("APD_ConnectionString");
            entity.Property(e => e.ApdConnectionType).HasColumnName("APD_ConnectionType");
            entity.Property(e => e.ApdCopyOnlyGraphicAttachmentsToDisk).HasColumnName("APD_CopyOnlyGraphicAttachmentsToDisk");
            entity.Property(e => e.ApdDfhid).HasColumnName("APD_DFHId");
            entity.Property(e => e.ApdDisableOcrFilesArchiving).HasColumnName("APD_DisableOcrFilesArchiving");
            entity.Property(e => e.ApdEdorAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APD_EDorAddress");
            entity.Property(e => e.ApdEdorPrivateKey)
                .HasColumnType("text")
                .HasColumnName("APD_EDorPrivateKey");
            entity.Property(e => e.ApdEdorPrivateKeyFileName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APD_EDorPrivateKeyFileName");
            entity.Property(e => e.ApdEdorSystemName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APD_EDorSystemName");
            entity.Property(e => e.ApdEdorToken)
                .HasColumnType("text")
                .HasColumnName("APD_EDorToken");
            entity.Property(e => e.ApdEdorTokenExpires).HasColumnName("APD_EDorTokenExpires");
            entity.Property(e => e.ApdInsertCommand)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("APD_InsertCommand");
            entity.Property(e => e.ApdMailboxAccessToken)
                .HasColumnType("text")
                .HasColumnName("APD_MailboxAccessToken");
            entity.Property(e => e.ApdMailboxAuthenticationMethod).HasColumnName("APD_MailboxAuthenticationMethod");
            entity.Property(e => e.ApdMailboxHost)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APD_MailboxHost");
            entity.Property(e => e.ApdMailboxOauthProviderName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APD_MailboxOAuthProviderName");
            entity.Property(e => e.ApdMailboxPassword)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APD_MailboxPassword");
            entity.Property(e => e.ApdMailboxPort).HasColumnName("APD_MailboxPort");
            entity.Property(e => e.ApdMailboxRefreshToken)
                .HasColumnType("text")
                .HasColumnName("APD_MailboxRefreshToken");
            entity.Property(e => e.ApdMailboxSecureConnectionType).HasColumnName("APD_MailboxSecureConnectionType");
            entity.Property(e => e.ApdMailboxUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APD_MailboxUser");
            entity.Property(e => e.ApdName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APD_Name");
            entity.Property(e => e.ApdOcrDefaultPaymentType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("APD_OcrDefaultPaymentType");
            entity.Property(e => e.ApdOcrDocumentBarcode).HasColumnName("APD_OcrDocumentBarcode");
            entity.Property(e => e.ApdOcrDocumentCountry).HasColumnName("APD_OcrDocumentCountry");
            entity.Property(e => e.ApdOcrDocumentName).HasColumnName("APD_OcrDocumentName");
            entity.Property(e => e.ApdOcrDocumentType).HasColumnName("APD_OcrDocumentType");
            entity.Property(e => e.ApdOcrLinkPagesByContent).HasColumnName("APD_OcrLinkPagesByContent");
            entity.Property(e => e.ApdOcrPagesToRecognize)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APD_OcrPagesToRecognize");
            entity.Property(e => e.ApdRemoveFromListAndEdor).HasColumnName("APD_RemoveFromListAndEDor");
            entity.Property(e => e.ApdRemoveFromListAndMailbox).HasColumnName("APD_RemoveFromListAndMailbox");
            entity.Property(e => e.ApdRemoveFromMailboxAfterGenerating).HasColumnName("APD_RemoveFromMailboxAfterGenerating");
            entity.Property(e => e.ApdRepositoryDocumentTypeId)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("APD_RepositoryDocumentTypeId");
            entity.Property(e => e.ApdRepositoryLocationId)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("APD_RepositoryLocationId");
            entity.Property(e => e.ApdSaldeoApiConfigurationPointId).HasColumnName("APD_SaldeoApiConfigurationPointId");
            entity.Property(e => e.ApdSaldeoId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APD_SaldeoId");
            entity.Property(e => e.ApdSaldeoMode).HasColumnName("APD_SaldeoMode");
            entity.Property(e => e.ApdSaldeoToken)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APD_SaldeoToken");
            entity.Property(e => e.ApdSaldeoUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APD_SaldeoUrl");
            entity.Property(e => e.ApdSaldeoUser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APD_SaldeoUser");
            entity.Property(e => e.ApdScanFolderPath)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("APD_ScanFolderPath");
            entity.Property(e => e.ApdShowMailDate).HasColumnName("APD_ShowMailDate");
            entity.Property(e => e.ApdShowMailSender).HasColumnName("APD_ShowMailSender");
            entity.Property(e => e.ApdShowMailSubject).HasColumnName("APD_ShowMailSubject");
            entity.Property(e => e.ApdSqliterator)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("APD_SQLIterator");
            entity.Property(e => e.ApdTag1Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APD_Tag1_Name");
            entity.Property(e => e.ApdTag2Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APD_Tag2_Name");
            entity.Property(e => e.ApdTag3Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APD_Tag3_Name");
            entity.Property(e => e.ApdTextSearchInRepositoryModule)
                .HasDefaultValue(true)
                .HasColumnName("APD_TextSearchInRepositoryModule");
            entity.Property(e => e.ApdTrackingDatabaseType).HasColumnName("APD_TrackingDatabaseType");
            entity.Property(e => e.ApdUseSaldeoApiConfigurationPoint).HasColumnName("APD_UseSaldeoApiConfigurationPoint");
        });

        modelBuilder.Entity<DfConfApfolderPath>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfAPFolderPaths", "do");

            entity.Property(e => e.ApfApdid).HasColumnName("APF_APDID");
            entity.Property(e => e.ApfDcdid).HasColumnName("APF_DCDID");
            entity.Property(e => e.ApfFolderPath)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("APF_FolderPath");
            entity.Property(e => e.ApfWindowsLogin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APF_WindowsLogin");

            entity.HasOne(d => d.ApfApd).WithMany()
                .HasForeignKey(d => d.ApfApdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DF_ConfAP__APF_A__79FD19BE");

            entity.HasOne(d => d.ApfDcd).WithMany()
                .HasForeignKey(d => d.ApfDcdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DF_ConfAP__APF_D__7AF13DF7");
        });

        modelBuilder.Entity<DfConfAptemplate>(entity =>
        {
            entity.HasKey(e => e.AptId);

            entity.ToTable("DF_ConfAPTemplates", "do");

            entity.Property(e => e.AptId).HasColumnName("APT_ID");
            entity.Property(e => e.AptArchival).HasColumnName("APT_Archival");
            entity.Property(e => e.AptContent)
                .IsUnicode(false)
                .HasColumnName("APT_Content");
            entity.Property(e => e.AptIsLite).HasColumnName("APT_IsLite");
            entity.Property(e => e.AptIsPredefined).HasColumnName("APT_IsPredefined");
            entity.Property(e => e.AptName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APT_Name");
            entity.Property(e => e.AptVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APT_Version");
        });

        modelBuilder.Entity<DfConfCfCtrlAnalitycalDescription>(entity =>
        {
            entity.HasKey(e => e.DadId);

            entity.ToTable("DF_ConfCfCtrlAnalitycalDescription", "do");

            entity.Property(e => e.DadId).HasColumnName("Dad_Id");
            entity.Property(e => e.DadControlTypeId).HasColumnName("DAD_ControlTypeId");
            entity.Property(e => e.DadDkoId).HasColumnName("Dad_DkoId");
            entity.Property(e => e.DadGroup).HasColumnName("DAD_Group");
            entity.Property(e => e.DadPropertyName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Dad_PropertyName");
            entity.Property(e => e.DadReferencedColumnId).HasColumnName("DAD_ReferencedColumnId");
            entity.Property(e => e.DadReferencedControlId).HasColumnName("Dad_ReferencedControlId");
            entity.Property(e => e.DadRequired).HasColumnName("DAD_Required");
        });

        modelBuilder.Entity<DfConfCfattachmentArchiveDocumentTypeSetting>(entity =>
        {
            entity.HasKey(e => e.DaaId).HasName("PK_DF_DF_ConfCFAttachmentArchiveDocumentTypeSettings");

            entity.ToTable("DF_ConfCFAttachmentArchiveDocumentTypeSettings", "do");

            entity.Property(e => e.DaaId).HasColumnName("DAA_Id");
            entity.Property(e => e.DaaArchival).HasColumnName("DAA_Archival");
            entity.Property(e => e.DaaDdsmappingStageId).HasColumnName("DAA_DDSMappingStageId");
            entity.Property(e => e.DaaDkoid).HasColumnName("DAA_DKOId");
            entity.Property(e => e.DaaDocumentTypeId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DAA_DocumentTypeId");
            entity.Property(e => e.DaaDocumentTypeName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DAA_DocumentTypeName");
            entity.Property(e => e.DaaIsDefault).HasColumnName("DAA_IsDefault");
        });

        modelBuilder.Entity<DfConfCfattachmentArchiveDocumentTypeSettingsMapping>(entity =>
        {
            entity.HasKey(e => e.DamId);

            entity.ToTable("DF_ConfCFAttachmentArchiveDocumentTypeSettingsMappings", "do");

            entity.Property(e => e.DamId).HasColumnName("DAM_ID");
            entity.Property(e => e.DamArchival).HasColumnName("DAM_Archival");
            entity.Property(e => e.DamAttributeId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DAM_AttributeId");
            entity.Property(e => e.DamAttributeIsRequired).HasColumnName("DAM_AttributeIsRequired");
            entity.Property(e => e.DamAttributeName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DAM_AttributeName");
            entity.Property(e => e.DamAttributeType).HasColumnName("DAM_AttributeType");
            entity.Property(e => e.DamDaaid).HasColumnName("DAM_DAAId");
            entity.Property(e => e.DamDkoid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DAM_DKOID");
        });

        modelBuilder.Entity<DfConfCfcardDokFlow>(entity =>
        {
            entity.HasKey(e => e.DkoId);

            entity.ToTable("DF_ConfCFCardDokFlow", "do");

            entity.HasIndex(e => e.DkoDshid, "I_DF_ConfCFCardDokFlow_DSHID");

            entity.HasIndex(e => e.DkoName, "I_DF_ConfCFCardDokFlow_Name");

            entity.Property(e => e.DkoId)
                .HasComment("Primary key")
                .HasColumnName("DKO_ID");
            entity.Property(e => e.DkoAccDynamic).HasColumnName("DKO_AccDynamic");
            entity.Property(e => e.DkoArchival).HasColumnName("DKO_Archival");
            entity.Property(e => e.DkoAskBeforeExecute).HasColumnName("DKO_AskBeforeExecute");
            entity.Property(e => e.DkoAttachmentLocation)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("DKO_AttachmentLocation");
            entity.Property(e => e.DkoAttachmentRepositoryAsSource).HasColumnName("DKO_AttachmentRepositoryAsSource");
            entity.Property(e => e.DkoAttachmentVersioning).HasColumnName("DKO_AttachmentVersioning");
            entity.Property(e => e.DkoAvistaWorkMode).HasColumnName("DKO_AVistaWorkMode");
            entity.Property(e => e.DkoBlockDeletingAttachments).HasColumnName("DKO_BlockDeletingAttachments");
            entity.Property(e => e.DkoCanGenerateWithoutAd).HasColumnName("DKO_CanGenerateWithoutAD");
            entity.Property(e => e.DkoCanNotify).HasColumnName("DKO_CanNotify");
            entity.Property(e => e.DkoCeeconfigurationId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DKO_CEEConfigurationId");
            entity.Property(e => e.DkoCeeconfigurationName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DKO_CEEConfigurationName");
            entity.Property(e => e.DkoCeedocumentType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DKO_CEEDocumentType");
            entity.Property(e => e.DkoCfsid).HasColumnName("DKO_CFSId");
            entity.Property(e => e.DkoColor).HasColumnName("DKO_Color");
            entity.Property(e => e.DkoColumnName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("Nazwa kolumny tabeli nagłówkowej podpięte dokumentu, z której będą pobierane wartości inicjujące kontrolkę")
                .HasColumnName("DKO_ColumnName");
            entity.Property(e => e.DkoCompanyId).HasColumnName("DKO_CompanyId");
            entity.Property(e => e.DkoConfirmMessage)
                .HasMaxLength(4000)
                .HasColumnName("DKO_ConfirmMessage");
            entity.Property(e => e.DkoControlPositionedInNewLine).HasColumnName("DKO_ControlPositionedInNewLine");
            entity.Property(e => e.DkoCsScriptGeneratedChange)
                .IsUnicode(false)
                .HasColumnName("DKO_CsScriptGeneratedChange");
            entity.Property(e => e.DkoCsScriptGeneratedInit)
                .IsUnicode(false)
                .HasColumnName("DKO_CsScriptGeneratedInit");
            entity.Property(e => e.DkoCsScriptHostingInit).HasColumnName("DKO_CsScriptHostingInit");
            entity.Property(e => e.DkoCsScriptNameChange)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DKO_CsScriptNameChange");
            entity.Property(e => e.DkoCsScriptNameInit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DKO_CsScriptNameInit");
            entity.Property(e => e.DkoCsScriptReferencesChange)
                .IsUnicode(false)
                .HasColumnName("DKO_CsScriptReferencesChange");
            entity.Property(e => e.DkoCsScriptReferencesInit)
                .IsUnicode(false)
                .HasColumnName("DKO_CsScriptReferencesInit");
            entity.Property(e => e.DkoCsScriptUserChange)
                .IsUnicode(false)
                .HasColumnName("DKO_CsScriptUserChange");
            entity.Property(e => e.DkoCsScriptUserInit)
                .IsUnicode(false)
                .HasColumnName("DKO_CsScriptUserInit");
            entity.Property(e => e.DkoDateAndTime)
                .HasComment("Czy kontrolka data ma prezentować datę i czas")
                .HasColumnName("DKO_DateAndTime");
            entity.Property(e => e.DkoDctid)
                .HasComment("Relacja do tabeli typów kontrolek")
                .HasColumnName("DKO_DCTId");
            entity.Property(e => e.DkoDdeid)
                .HasComment("relacja do tabeli konfiguracyjnej dokumentu elektroniczne")
                .HasColumnName("DKO_DDEId");
            entity.Property(e => e.DkoDecimalPrecision)
                .HasComment("Ilość miejsc po przecinku dla kontrolki typu Decimal")
                .HasColumnName("DKO_DecimalPrecision");
            entity.Property(e => e.DkoDisplayName)
                .HasMaxLength(511)
                .IsUnicode(false)
                .HasColumnName("DKO_DisplayName");
            entity.Property(e => e.DkoDkoid)
                .HasComment("Id kontrolki „Dokument elektroniczny”")
                .HasColumnName("DKO_DKOId");
            entity.Property(e => e.DkoDocumentsManagerAsSource).HasColumnName("DKO_DocumentsManagerAsSource");
            entity.Property(e => e.DkoDontCloseDocumentDialogAfterSave).HasColumnName("DKO_DontCloseDocumentDialogAfterSave");
            entity.Property(e => e.DkoDshid)
                .HasComment("Relacja do tabeli nagłówkowej")
                .HasColumnName("DKO_DSHId");
            entity.Property(e => e.DkoErpControlCompanyId).HasColumnName("DKO_ErpControlCompanyId");
            entity.Property(e => e.DkoErpStoredProcedure)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("DKO_ErpStoredProcedure");
            entity.Property(e => e.DkoErpdepartmentId).HasColumnName("DKO_ERPDepartmentId");
            entity.Property(e => e.DkoExecutableFile)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("DKO_ExecutableFile");
            entity.Property(e => e.DkoExecutableIisfile)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("DKO_ExecutableIISFile");
            entity.Property(e => e.DkoExpectedSqlQueryResultColumnsCount).HasColumnName("DKO_ExpectedSqlQueryResultColumnsCount");
            entity.Property(e => e.DkoExpectedValueExpressionResultColumnsCount).HasColumnName("DKO_ExpectedValueExpressionResultColumnsCount");
            entity.Property(e => e.DkoExpressionCompanyId).HasColumnName("DKO_ExpressionCompanyId");
            entity.Property(e => e.DkoExpressionEngineType).HasColumnName("DKO_ExpressionEngineType");
            entity.Property(e => e.DkoFillEntireRow).HasColumnName("DKO_FillEntireRow");
            entity.Property(e => e.DkoGridView).HasColumnName("DKO_GridView");
            entity.Property(e => e.DkoGuid).HasColumnName("DKO_Guid");
            entity.Property(e => e.DkoHideRowAdding).HasColumnName("DKO_HideRowAdding");
            entity.Property(e => e.DkoHideRowRemoving).HasColumnName("DKO_HideRowRemoving");
            entity.Property(e => e.DkoIdentifierType).HasColumnName("DKO_IdentifierType");
            entity.Property(e => e.DkoInitSqlCompanyId).HasColumnName("DKO_InitSqlCompanyId");
            entity.Property(e => e.DkoInitType).HasColumnName("DKO_InitType");
            entity.Property(e => e.DkoIsAttachmentMappingToErpXl).HasColumnName("DKO_IsAttachmentMappingToErpXl");
            entity.Property(e => e.DkoIsInitiatedEveryTime).HasColumnName("DKO_IsInitiatedEveryTime");
            entity.Property(e => e.DkoIsRequired).HasColumnName("DKO_IsRequired");
            entity.Property(e => e.DkoIsSearchForAnyStringModeEnabled).HasColumnName("DKO_IsSearchForAnyStringModeEnabled");
            entity.Property(e => e.DkoIsUsedForMobileSignatures).HasColumnName("DKO_IsUsedForMobileSignatures");
            entity.Property(e => e.DkoLastUsedCalculationMode).HasColumnName("DKO_LastUsedCalculationMode");
            entity.Property(e => e.DkoListWorkMode).HasColumnName("DKO_ListWorkMode");
            entity.Property(e => e.DkoMaxLength).HasColumnName("DKO_MaxLength");
            entity.Property(e => e.DkoMultiLine).HasColumnName("DKO_MultiLine");
            entity.Property(e => e.DkoName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DKO_Name");
            entity.Property(e => e.DkoPos)
                .HasComment("Pozycja kontrolki na panelu „Karta obiegu”")
                .HasColumnName("DKO_Pos");
            entity.Property(e => e.DkoReadOnly)
                .HasComment("Czy kontrolka ma być tylko do odczytu na etapach innych niż pierwszy")
                .HasColumnName("DKO_ReadOnly");
            entity.Property(e => e.DkoRegisterBarcodes).HasColumnName("DKO_RegisterBarcodes");
            entity.Property(e => e.DkoRegisterGpscoordinates).HasColumnName("DKO_RegisterGPSCoordinates");
            entity.Property(e => e.DkoRowsCount).HasColumnName("DKO_RowsCount");
            entity.Property(e => e.DkoSaveBeforeExecute).HasColumnName("DKO_SaveBeforeExecute");
            entity.Property(e => e.DkoScrollBars).HasColumnName("DKO_ScrollBars");
            entity.Property(e => e.DkoShowOnlyActiveDocuments).HasColumnName("DKO_ShowOnlyActiveDocuments");
            entity.Property(e => e.DkoSignPdf).HasColumnName("DKO_SignPDF");
            entity.Property(e => e.DkoSize)
                .HasDefaultValue((short)1)
                .HasColumnName("DKO_Size");
            entity.Property(e => e.DkoSqlQuery)
                .HasColumnType("text")
                .HasColumnName("DKO_SqlQuery");
            entity.Property(e => e.DkoStaysInRelatedHistory).HasColumnName("DKO_StaysInRelatedHistory");
            entity.Property(e => e.DkoStoredProcedure)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("DKO_StoredProcedure");
            entity.Property(e => e.DkoTitle)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("DKO_Title");
            entity.Property(e => e.DkoType).HasColumnName("DKO_Type");
            entity.Property(e => e.DkoUseDefaultRepositoryLogin).HasColumnName("DKO_UseDefaultRepositoryLogin");
            entity.Property(e => e.DkoUseDefaultRepositoryLoginToRead).HasColumnName("DKO_UseDefaultRepositoryLoginToRead");
            entity.Property(e => e.DkoValueExpression)
                .HasColumnType("text")
                .HasColumnName("DKO_ValueExpression");
            entity.Property(e => e.DkoWorkMode).HasColumnName("DKO_WorkMode");

            entity.HasOne(d => d.DkoCfs).WithMany(p => p.DfConfCfcardDokFlows)
                .HasForeignKey(d => d.DkoCfsid)
                .HasConstraintName("FK_DF_ConfCFCardDokFlow_DF_ConfCFControlSections");

            entity.HasOne(d => d.DkoDct).WithMany(p => p.DfConfCfcardDokFlows)
                .HasForeignKey(d => d.DkoDctid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfCFCardDokFlow_DF_ConfCFCtrlType");

            entity.HasOne(d => d.DkoDko).WithMany(p => p.InverseDkoDko)
                .HasForeignKey(d => d.DkoDkoid)
                .HasConstraintName("FK_DF_ConfCFCardDokFlow_DF_ConfCFCardDokFlow");

            entity.HasOne(d => d.DkoDsh).WithMany(p => p.DfConfCfcardDokFlows)
                .HasForeignKey(d => d.DkoDshid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfCFCardDokFlow_DF_ConfDSHead");
        });

        modelBuilder.Entity<DfConfCfcontrolSection>(entity =>
        {
            entity.HasKey(e => e.CfsId);

            entity.ToTable("DF_ConfCFControlSections", "do");

            entity.Property(e => e.CfsId).HasColumnName("CFS_Id");
            entity.Property(e => e.CfsArchival).HasColumnName("CFS_Archival");
            entity.Property(e => e.CfsCfcid).HasColumnName("CFS_CFCId");
            entity.Property(e => e.CfsColumnCount).HasColumnName("CFS_ColumnCount");
            entity.Property(e => e.CfsControlsMaxWidth).HasColumnName("CFS_ControlsMaxWidth");
            entity.Property(e => e.CfsDshid).HasColumnName("CFS_DSHId");
            entity.Property(e => e.CfsIsStaticColumnCountMode).HasColumnName("CFS_IsStaticColumnCountMode");
            entity.Property(e => e.CfsName)
                .HasMaxLength(255)
                .HasColumnName("CFS_Name");
            entity.Property(e => e.CfsPosition).HasColumnName("CFS_Position");
        });

        modelBuilder.Entity<DfConfCfctrlDictionary>(entity =>
        {
            entity.HasKey(e => e.DdcId);

            entity.ToTable("DF_ConfCFCtrlDictionary", "do");

            entity.Property(e => e.DdcId).HasColumnName("DDC_Id");
            entity.Property(e => e.DdcArchival).HasColumnName("DDC_Archival");
            entity.Property(e => e.DdcDkoid).HasColumnName("DDC_DKOId");
            entity.Property(e => e.DdcDmlid).HasColumnName("DDC_DMLId");
            entity.Property(e => e.DdcIsDefault).HasColumnName("DDC_IsDefault");
            entity.Property(e => e.DdcName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DDC_Name");

            entity.HasOne(d => d.DdcDko).WithMany(p => p.DfConfCfctrlDictionaries)
                .HasForeignKey(d => d.DdcDkoid)
                .HasConstraintName("FK_DF_ConfCFCtrlDictionary_DF_ConfCFCardDokFlow");
        });

        modelBuilder.Entity<DfConfCfctrlType>(entity =>
        {
            entity.HasKey(e => e.DctId);

            entity.ToTable("DF_ConfCFCtrlType", "do");

            entity.Property(e => e.DctId)
                .ValueGeneratedNever()
                .HasComment("Primary key")
                .HasColumnName("DCT_ID");
            entity.Property(e => e.DctName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DCT_Name");
        });

        modelBuilder.Entity<DfConfCfcustomList>(entity =>
        {
            entity.HasKey(e => e.DclId);

            entity.ToTable("DF_ConfCFCustomLists", "do");

            entity.Property(e => e.DclId).HasColumnName("DCL_Id");
            entity.Property(e => e.DclName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCL_Name");
            entity.Property(e => e.DclSqlQuery)
                .IsUnicode(false)
                .HasColumnName("DCL_SqlQuery");
            entity.Property(e => e.DclType).HasColumnName("DCL_Type");
        });

        modelBuilder.Entity<DfConfCfmultiLineCtrlColumn>(entity =>
        {
            entity.HasKey(e => e.DmcId);

            entity.ToTable("DF_ConfCFMultiLineCtrlColumns", "do");

            entity.Property(e => e.DmcId).HasColumnName("DMC_Id");
            entity.Property(e => e.DmcArchival).HasColumnName("DMC_Archival");
            entity.Property(e => e.DmcCeedocumentConfigurationId)
                .HasMaxLength(511)
                .IsUnicode(false)
                .HasColumnName("DMC_CEEDocumentConfigurationId");
            entity.Property(e => e.DmcCeedocumentConfigurationName)
                .HasMaxLength(511)
                .IsUnicode(false)
                .HasColumnName("DMC_CEEDocumentConfigurationName");
            entity.Property(e => e.DmcCeedocumentType)
                .HasMaxLength(511)
                .IsUnicode(false)
                .HasColumnName("DMC_CEEDocumentType");
            entity.Property(e => e.DmcCompanyId).HasColumnName("DMC_CompanyId");
            entity.Property(e => e.DmcDateAndTime).HasColumnName("DMC_DateAndTime");
            entity.Property(e => e.DmcDctid).HasColumnName("DMC_DCTId");
            entity.Property(e => e.DmcDecimalPrecision).HasColumnName("DMC_DecimalPrecision");
            entity.Property(e => e.DmcDisplayName)
                .HasMaxLength(511)
                .IsUnicode(false)
                .HasColumnName("DMC_DisplayName");
            entity.Property(e => e.DmcDkoid).HasColumnName("DMC_DKOId");
            entity.Property(e => e.DmcDmlid).HasColumnName("DMC_DMLId");
            entity.Property(e => e.DmcDontCloseDocumentDialogAfterSave).HasColumnName("DMC_DontCloseDocumentDialogAfterSave");
            entity.Property(e => e.DmcErpdocumentType).HasColumnName("DMC_ERPDocumentType");
            entity.Property(e => e.DmcIdentifierType).HasColumnName("DMC_IdentifierType");
            entity.Property(e => e.DmcIsReadOnly).HasColumnName("DMC_IsReadOnly");
            entity.Property(e => e.DmcMapFromControls).HasColumnName("DMC_MapFromControls");
            entity.Property(e => e.DmcMapToErpcontrol).HasColumnName("DMC_MapToERPControl");
            entity.Property(e => e.DmcName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("DMC_Name");
            entity.Property(e => e.DmcPosition).HasColumnName("DMC_Position");
            entity.Property(e => e.DmcShowOnlyActiveDocuments).HasColumnName("DMC_ShowOnlyActiveDocuments");
        });

        modelBuilder.Entity<DfConfCfmultiLineCtrlList>(entity =>
        {
            entity.HasKey(e => e.DmlId);

            entity.ToTable("DF_ConfCFMultiLineCtrlLists", "do");

            entity.Property(e => e.DmlId).HasColumnName("DML_Id");
            entity.Property(e => e.DmlArchival).HasColumnName("DML_Archival");
            entity.Property(e => e.DmlCompanyId).HasColumnName("DML_CompanyId");
            entity.Property(e => e.DmlCsScriptGenerated)
                .IsUnicode(false)
                .HasColumnName("DML_CsScriptGenerated");
            entity.Property(e => e.DmlCsScriptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DML_CsScriptName");
            entity.Property(e => e.DmlCsScriptReferences)
                .IsUnicode(false)
                .HasColumnName("DML_CsScriptReferences");
            entity.Property(e => e.DmlCsScriptUser)
                .IsUnicode(false)
                .HasColumnName("DML_CsScriptUser");
            entity.Property(e => e.DmlDclid).HasColumnName("DML_DCLId");
            entity.Property(e => e.DmlDkoid).HasColumnName("DML_DKOId");
            entity.Property(e => e.DmlExpectedSqlQueryResultColumnsCount).HasColumnName("DML_ExpectedSqlQueryResultColumnsCount");
            entity.Property(e => e.DmlIdentifierType).HasColumnName("DML_IdentifierType");
            entity.Property(e => e.DmlInitType).HasColumnName("DML_InitType");
            entity.Property(e => e.DmlIsSearchForAnyStringModeEnabled).HasColumnName("DML_IsSearchForAnyStringModeEnabled");
            entity.Property(e => e.DmlName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DML_Name");
            entity.Property(e => e.DmlPosition).HasColumnName("DMl_Position");
            entity.Property(e => e.DmlSqlQuery)
                .IsUnicode(false)
                .HasColumnName("DML_SqlQuery");
            entity.Property(e => e.DmlWorkMode).HasColumnName("DML_WorkMode");
        });

        modelBuilder.Entity<DfConfCfrelatedControl>(entity =>
        {
            entity.HasKey(e => e.DrcId);

            entity.ToTable("DF_ConfCFRelatedControls", "do");

            entity.Property(e => e.DrcId).HasColumnName("DRC_Id");
            entity.Property(e => e.DrcArchival).HasColumnName("DRC_Archival");
            entity.Property(e => e.DrcDkoid).HasColumnName("DRC_DKOId");
            entity.Property(e => e.DrcRelatedControlId).HasColumnName("DRC_RelatedControlId");

            entity.HasOne(d => d.DrcDko).WithMany(p => p.DfConfCfrelatedControlDrcDkos)
                .HasForeignKey(d => d.DrcDkoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfCFRelatedControls_DF_ConfCFCardDokFlow_id");

            entity.HasOne(d => d.DrcRelatedControl).WithMany(p => p.DfConfCfrelatedControlDrcRelatedControls)
                .HasForeignKey(d => d.DrcRelatedControlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfCFRelatedControls_DF_ConfCFCardDokFlow_related_id");
        });

        modelBuilder.Entity<DfConfCfrelatedWorkflowType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfCFRelatedWorkflowTypes", "do");

            entity.Property(e => e.CrtArchival).HasColumnName("CRT_Archival");
            entity.Property(e => e.CrtDfhid).HasColumnName("CRT_DFHID");
            entity.Property(e => e.CrtDkoid).HasColumnName("CRT_DKOID");
            entity.Property(e => e.CrtDmcid).HasColumnName("CRT_DMCID");
        });

        modelBuilder.Entity<DfConfCftab>(entity =>
        {
            entity.HasKey(e => e.CfcId);

            entity.ToTable("DF_ConfCFTabs", "do");

            entity.Property(e => e.CfcId).HasColumnName("CFC_Id");
            entity.Property(e => e.CfcArchival).HasColumnName("CFC_Archival");
            entity.Property(e => e.CfcDshid).HasColumnName("CFC_DSHId");
            entity.Property(e => e.CfcName)
                .HasMaxLength(255)
                .HasColumnName("CFC_Name");
            entity.Property(e => e.CfcPosition).HasColumnName("CFC_Position");
        });

        modelBuilder.Entity<DfConfCmdictionary>(entity =>
        {
            entity.HasKey(e => e.CmdId).HasName("PK__DF_ConfC__1D2E459FA8629CD9");

            entity.ToTable("DF_ConfCMDictionary", "do", tb => tb.HasTrigger("UpdateApiKeysOnCompanyChanges"));

            entity.Property(e => e.CmdId).HasColumnName("CMD_ID");
            entity.Property(e => e.CmdArchival)
                .HasDefaultValue(false)
                .HasColumnName("CMD_Archival");
            entity.Property(e => e.CmdCertificateName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_CertificateName");
            entity.Property(e => e.CmdCompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CMD_CompanyName");
            entity.Property(e => e.CmdConnectionStringErp)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_ConnectionStringERP");
            entity.Property(e => e.CmdConnectionStringErpconf)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_ConnectionStringERPConf");
            entity.Property(e => e.CmdConnectionStringErpconfEncrypted)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CMD_ConnectionStringERPConfEncrypted");
            entity.Property(e => e.CmdConnectionStringErpencrypted)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CMD_ConnectionStringERPEncrypted");
            entity.Property(e => e.CmdConnectionTypeErp).HasColumnName("CMD_ConnectionTypeERP");
            entity.Property(e => e.CmdDatabase)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_Database");
            entity.Property(e => e.CmdDisplayName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CMD_DisplayName");
            entity.Property(e => e.CmdDomainGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_DomainGroup");
            entity.Property(e => e.CmdDomainName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_DomainName");
            entity.Property(e => e.CmdEdorAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMD_EDorAddress");
            entity.Property(e => e.CmdEdorPrivateKey)
                .HasColumnType("text")
                .HasColumnName("CMD_EDorPrivateKey");
            entity.Property(e => e.CmdEdorPrivateKeyFileName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_EDorPrivateKeyFileName");
            entity.Property(e => e.CmdEdorSystemName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_EDorSystemName");
            entity.Property(e => e.CmdEdorToken)
                .HasColumnType("text")
                .HasColumnName("CMD_EDorToken");
            entity.Property(e => e.CmdEdorTokenExpires).HasColumnName("CMD_EDorTokenExpires");
            entity.Property(e => e.CmdErpSystem).HasColumnName("CMD_ErpSystem");
            entity.Property(e => e.CmdErpdepartmentId).HasColumnName("CMD_ERPDepartmentId");
            entity.Property(e => e.CmdKseFtoken)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_KSeFToken");
            entity.Property(e => e.CmdLicenceKeyServerXl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_LicenceKeyServerXL");
            entity.Property(e => e.CmdLogin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_Login");
            entity.Property(e => e.CmdMigratorGetEmployeesQuery)
                .IsUnicode(false)
                .HasColumnName("CMD_MigratorGetEmployeesQuery");
            entity.Property(e => e.CmdMigratorGetGetDepartmentsQuery)
                .IsUnicode(false)
                .HasColumnName("CMD_MigratorGetGetDepartmentsQuery");
            entity.Property(e => e.CmdMigratorGetOrganizationStructureQuery)
                .IsUnicode(false)
                .HasColumnName("CMD_MigratorGetOrganizationStructureQuery");
            entity.Property(e => e.CmdMigratorGetPositionsQuery)
                .IsUnicode(false)
                .HasColumnName("CMD_MigratorGetPositionsQuery");
            entity.Property(e => e.CmdNatCompanyId).HasColumnName("CMD_NatCompanyId");
            entity.Property(e => e.CmdNip)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("CMD_Nip");
            entity.Property(e => e.CmdOrganizationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMD_OrganizationId");
            entity.Property(e => e.CmdOrganizationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMD_OrganizationName");
            entity.Property(e => e.CmdPassword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_Password");
            entity.Property(e => e.CmdPasswordEncrypted)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CMD_PasswordEncrypted");
            entity.Property(e => e.CmdRestService)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_RestService");
            entity.Property(e => e.CmdShortcut)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CMD_Shortcut");
            entity.Property(e => e.CmdUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMD_Url");
            entity.Property(e => e.CmdUseDomain).HasColumnName("CMD_UseDomain");
        });

        modelBuilder.Entity<DfConfCmsetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfCMSettings", "do");

            entity.HasIndex(e => e.CmsName, "uc_CMS_Name").IsUnique();

            entity.Property(e => e.CmsErpdbmap)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("CMS_ERPDBMap");
            entity.Property(e => e.CmsName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CMS_Name");
            entity.Property(e => e.CmsUrl)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("CMS_URL");
        });

        modelBuilder.Entity<DfConfDaysOff>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfDaysOff", "do");

            entity.Property(e => e.DofDate).HasColumnName("DOF_Date");
        });

        modelBuilder.Entity<DfConfDsaccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfDSAccess", "do");

            entity.HasIndex(e => e.DsaDcdid, "I_DF_ConfDSAccess_DCDId");

            entity.HasIndex(e => e.DsaDdsid, "I_DF_ConfDSAccess_DDSId").IsClustered();

            entity.Property(e => e.DsaArchival).HasColumnName("DSA_Archival");
            entity.Property(e => e.DsaDcdid).HasColumnName("DSA_DCDId");
            entity.Property(e => e.DsaDdsid).HasColumnName("DSA_DDSId");
            entity.Property(e => e.DsaTypeAccess)
                .HasComment("1-pracownik, 2-dział, 3-stanowisko")
                .HasColumnName("DSA_TypeAccess");

            entity.HasOne(d => d.DsaDcd).WithMany()
                .HasForeignKey(d => d.DsaDcdid)
                .HasConstraintName("FK_DF_ConfDSAccess_DF_ConfOSDictionary");

            entity.HasOne(d => d.DsaDds).WithMany()
                .HasForeignKey(d => d.DsaDdsid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfDSAccess_DF_ConfDSDictionary");
        });

        modelBuilder.Entity<DfConfDsconnection>(entity =>
        {
            entity.HasKey(e => e.DscId);

            entity.ToTable("DF_ConfDSConnection", "do");

            entity.Property(e => e.DscId).HasColumnName("DSC_ID");
            entity.Property(e => e.DscArchival).HasColumnName("DSC_Archival");
            entity.Property(e => e.DscDssfromId).HasColumnName("DSC_DSSFromId");
            entity.Property(e => e.DscDsstoId).HasColumnName("DSC_DSSToId");
            entity.Property(e => e.DscGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DSC_Guid");

            entity.HasOne(d => d.DscDssfrom).WithMany(p => p.DfConfDsconnectionDscDssfroms)
                .HasForeignKey(d => d.DscDssfromId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfDSConnection_DF_ConfDSScheme");

            entity.HasOne(d => d.DscDssto).WithMany(p => p.DfConfDsconnectionDscDsstos)
                .HasForeignKey(d => d.DscDsstoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfDSConnection_DF_ConfDSScheme1");
        });

        modelBuilder.Entity<DfConfDsctrlCondition>(entity =>
        {
            entity.HasKey(e => e.DsmId);

            entity.ToTable("DF_ConfDSCtrlCondition", "do");

            entity.HasIndex(e => new { e.DsmDdsid, e.DsmDkoid, e.DsmDkovariant }, "I_DF_ConfDSCtrlCondition_1");

            entity.Property(e => e.DsmId).HasColumnName("DSM_ID");
            entity.Property(e => e.DsmArchival).HasColumnName("DSM_Archival");
            entity.Property(e => e.DsmDdsid).HasColumnName("DSM_DDSId");
            entity.Property(e => e.DsmDkoid).HasColumnName("DSM_DKOId");
            entity.Property(e => e.DsmDkovariant)
                .HasDefaultValue(1)
                .HasColumnName("DSM_DKOVariant");
            entity.Property(e => e.DsmInit).HasColumnName("DSM_Init");
            entity.Property(e => e.DsmInitOrder).HasColumnName("DSM_InitOrder");
            entity.Property(e => e.DsmManualObserverExecution).HasColumnName("DSM_ManualObserverExecution");
            entity.Property(e => e.DsmReadonly).HasColumnName("DSM_Readonly");
            entity.Property(e => e.DsmRequired).HasColumnName("DSM_Required");
            entity.Property(e => e.DsmVisible).HasColumnName("DSM_Visible");

            entity.HasOne(d => d.DsmDds).WithMany(p => p.DfConfDsctrlConditions)
                .HasForeignKey(d => d.DsmDdsid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfDSCtrlCondition_DF_ConfDSDictionary");

            entity.HasOne(d => d.DsmDko).WithMany(p => p.DfConfDsctrlConditions)
                .HasForeignKey(d => d.DsmDkoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfDSCtrlCondition_DF_ConfCFCardDokFlow");
        });

        modelBuilder.Entity<DfConfDsdictionary>(entity =>
        {
            entity.HasKey(e => e.DdsId);

            entity.ToTable("DF_ConfDSDictionary", "do");

            entity.Property(e => e.DdsId).HasColumnName("DDS_ID");
            entity.Property(e => e.DdsAdditionalPermissions).HasColumnName("DDS_AdditionalPermissions");
            entity.Property(e => e.DdsAllowChangeTaskRealisationTimeLimitOnCurrentStage).HasColumnName("DDS_AllowChangeTaskRealisationTimeLimitOnCurrentStage");
            entity.Property(e => e.DdsAllowChangeTaskRealisationTimeLimitOnPreviousStage).HasColumnName("DDS_AllowChangeTaskRealisationTimeLimitOnPreviousStage");
            entity.Property(e => e.DdsAllowExcludingPermissionsOnPreviousStage).HasColumnName("DDS_AllowExcludingPermissionsOnPreviousStage");
            entity.Property(e => e.DdsArchival).HasColumnName("DDS_Archival");
            entity.Property(e => e.DdsAutoChangeDocOwner).HasColumnName("DDS_AutoChangeDocOwner");
            entity.Property(e => e.DdsComment1)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("DDS_Comment1");
            entity.Property(e => e.DdsComment2)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("DDS_Comment2");
            entity.Property(e => e.DdsConditions)
                .HasColumnType("text")
                .HasColumnName("DDS_Conditions");
            entity.Property(e => e.DdsDdsdocumentApprovalStageId).HasColumnName("DDS_DDSDocumentApprovalStageId");
            entity.Property(e => e.DdsDdspropagateToStageId).HasColumnName("DDS_DDSPropagateToStageId");
            entity.Property(e => e.DdsDefaultStageId).HasColumnName("DDS_DefaultStageId");
            entity.Property(e => e.DdsDefaultStageName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DDS_DefaultStageName");
            entity.Property(e => e.DdsDesignation).HasColumnName("DDS_Designation");
            entity.Property(e => e.DdsDisableReturnDocumentToPreviousStage).HasColumnName("DDS_DisableReturnDocumentToPreviousStage");
            entity.Property(e => e.DdsDkoattachmentControlToOpenAfterDocumentLoadId).HasColumnName("DDS_DKOAttachmentControlToOpenAfterDocumentLoadId");
            entity.Property(e => e.DdsDocumentReminderSendMailDate).HasColumnName("DDS_DocumentReminderSendMailDate");
            entity.Property(e => e.DdsDshid).HasColumnName("DDS_DSHId");
            entity.Property(e => e.DdsExpiredDocumentReminderSendMailDate)
                .HasColumnType("datetime")
                .HasColumnName("DDS_ExpiredDocumentReminderSendMailDate");
            entity.Property(e => e.DdsGuid).HasColumnName("DDS_Guid");
            entity.Property(e => e.DdsName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DDS_Name");
            entity.Property(e => e.DdsPermissionsForOperatorNotWorkingWithDocument).HasColumnName("DDS_PermissionsForOperatorNotWorkingWithDocument");
            entity.Property(e => e.DdsPosition).HasColumnName("DDS_Position");
            entity.Property(e => e.DdsPropagateAfterTime).HasColumnName("DDS_PropagateAfterTime");
            entity.Property(e => e.DdsPropagateAfterTimeMinutes).HasColumnName("DDS_PropagateAfterTimeMinutes");
            entity.Property(e => e.DdsPropagationAfterAllOperatorsApproval).HasColumnName("DDS_PropagationAfterAllOperatorsApproval");
            entity.Property(e => e.DdsPropagationEnabled).HasColumnName("DDS_PropagationEnabled");
            entity.Property(e => e.DdsSendEmailAboutOutstandings).HasColumnName("DDS_SendEmailAboutOutstandings");
            entity.Property(e => e.DdsSendEmailAboutOutstandingsAtTime).HasColumnName("DDS_SendEmailAboutOutstandingsAtTime");
            entity.Property(e => e.DdsSendEmailAboutOutstandingsDayInterval).HasColumnName("DDS_SendEmailAboutOutstandingsDayInterval");
            entity.Property(e => e.DdsSendEmailAboutOutstandingsDaysOfTheWeek)
                .HasDefaultValue(0)
                .HasColumnName("DDS_SendEmailAboutOutstandingsDaysOfTheWeek");
            entity.Property(e => e.DdsSendEmailAboutOutstandingsMode).HasColumnName("DDS_SendEmailAboutOutstandingsMode");
            entity.Property(e => e.DdsSendEmailAboutOutstandingsSkipWorkOff).HasColumnName("DDS_SendEmailAboutOutstandingsSkipWorkOff");
            entity.Property(e => e.DdsSendEmailAtTime).HasColumnName("DDS_SendEmailAtTime");
            entity.Property(e => e.DdsSendEmailDayInterval).HasColumnName("DDS_SendEmailDayInterval");
            entity.Property(e => e.DdsSendEmailDaysOfTheWeek)
                .HasDefaultValue(0)
                .HasColumnName("DDS_SendEmailDaysOfTheWeek");
            entity.Property(e => e.DdsSendEmailMode).HasColumnName("DDS_SendEMailMode");
            entity.Property(e => e.DdsSendEmailSkipWorkOff).HasColumnName("DDS_SendEmailSkipWorkOff");
            entity.Property(e => e.DdsSendEmailToObserverAtTime).HasColumnName("DDS_SendEmailToObserverAtTime");
            entity.Property(e => e.DdsSendEmailToObserverDayInterval).HasColumnName("DDS_SendEmailToObserverDayInterval");
            entity.Property(e => e.DdsSendEmailToObserverDaysOfTheWeek)
                .HasDefaultValue(0)
                .HasColumnName("DDS_SendEmailToObserverDaysOfTheWeek");
            entity.Property(e => e.DdsSendEmailToObserverMode).HasColumnName("DDS_SendEMailToObserverMode");
            entity.Property(e => e.DdsSendEmailToObserverSkipWorkOff).HasColumnName("DDS_SendEmailToObserverSkipWorkOff");
            entity.Property(e => e.DdsSendMailToObserversDate).HasColumnName("DDS_SendMailToObserversDate");
            entity.Property(e => e.DdsSendMailToPermittedDate).HasColumnName("DDS_SendMailToPermittedDate");
            entity.Property(e => e.DdsSendReminderEmail).HasColumnName("DDS_SendReminderEmail");
            entity.Property(e => e.DdsSendReminderEmailAtTime).HasColumnName("DDS_SendReminderEmailAtTime");
            entity.Property(e => e.DdsSendReminderEmailDayInterval).HasColumnName("DDS_SendReminderEmailDayInterval");
            entity.Property(e => e.DdsSendReminderEmailDaysOfTheWeek)
                .HasDefaultValue(0)
                .HasColumnName("DDS_SendReminderEmailDaysOfTheWeek");
            entity.Property(e => e.DdsSendReminderEmailMode).HasColumnName("DDS_SendReminderEmailMode");
            entity.Property(e => e.DdsSendReminderEmailSkipWorkOff).HasColumnName("DDS_SendReminderEmailSkipWorkOff");
            entity.Property(e => e.DdsSetInErpxltimetable).HasColumnName("DDS_SetInERPXLTimetable");
            entity.Property(e => e.DdsSkipWorkOff).HasColumnName("DDS_SkipWorkOff");
            entity.Property(e => e.DdsStageColor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DDS_StageColor");
            entity.Property(e => e.DdsTaskRealisationTimeLimit).HasColumnName("DDS_TaskRealisationTimeLimit");
            entity.Property(e => e.DdsTaskRealisationTimeLimitMinutes).HasColumnName("DDS_TaskRealisationTimeLimitMinutes");
            entity.Property(e => e.DdsTaskRealisationTimeLimitSkipWorkOff).HasColumnName("DDS_TaskRealisationTimeLimitSkipWorkOff");
            entity.Property(e => e.DdsTurnOnObserverWhileDocumentLoading)
                .HasDefaultValue(true)
                .HasColumnName("DDS_TurnOnObserverWhileDocumentLoading");

            entity.HasOne(d => d.DdsDsh).WithMany(p => p.DfConfDsdictionaries)
                .HasForeignKey(d => d.DdsDshid)
                .HasConstraintName("FK_DF_ConfDSDictionary_DF_ConfDSHead");
        });

        modelBuilder.Entity<DfConfDshead>(entity =>
        {
            entity.HasKey(e => e.DshId);

            entity.ToTable("DF_ConfDSHead", "do");

            entity.Property(e => e.DshId).HasColumnName("DSH_ID");
            entity.Property(e => e.DshArchves).HasColumnName("DSH_Archves");
            entity.Property(e => e.DshCreateData)
                .HasColumnType("datetime")
                .HasColumnName("DSH_CreateData");
            entity.Property(e => e.DshDfhid).HasColumnName("DSH_DFHId");
            entity.Property(e => e.DshXml).HasColumnName("DSH_XML");

            entity.HasOne(d => d.DshDfh).WithMany(p => p.DfConfDsheads)
                .HasForeignKey(d => d.DshDfhid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfDSHead_DF_HeadDokumentFlow");
        });

        modelBuilder.Entity<DfConfDsscheme>(entity =>
        {
            entity.HasKey(e => e.DssId);

            entity.ToTable("DF_ConfDSScheme", "do");

            entity.Property(e => e.DssId).HasColumnName("DSS_ID");
            entity.Property(e => e.DssArchival).HasColumnName("DSS_Archival");
            entity.Property(e => e.DssDdsid).HasColumnName("DSS_DDSId");
            entity.Property(e => e.DssDdsnextId).HasColumnName("DSS_DDSNextId");
            entity.Property(e => e.DssDshid).HasColumnName("DSS_DSHId");
            entity.Property(e => e.DssGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DSS_Guid");
            entity.Property(e => e.DssMaxNumberOfPassesMixMode).HasColumnName("DSS_MaxNumberOfPassesMixMode");
            entity.Property(e => e.DssMixedMode).HasColumnName("DSS_MixedMode");
            entity.Property(e => e.DssSendMail).HasColumnName("DSS_SendMail");
            entity.Property(e => e.DssWaitingTime).HasColumnName("DSS_WaitingTime");

            entity.HasOne(d => d.DssDds).WithMany(p => p.DfConfDsschemes)
                .HasForeignKey(d => d.DssDdsid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfDSScheme_DF_ConfDSDictionary");

            entity.HasOne(d => d.DssDsh).WithMany(p => p.DfConfDsschemes)
                .HasForeignKey(d => d.DssDshid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfDSScheme_DF_ConfDSHead");
        });

        modelBuilder.Entity<DfConfDssetting>(entity =>
        {
            entity.HasKey(e => e.DstDshid);

            entity.ToTable("DF_ConfDSSettings", "do");

            entity.Property(e => e.DstDshid)
                .ValueGeneratedNever()
                .HasColumnName("DST_DSHID");
            entity.Property(e => e.DstCanPrintOutboxBook).HasColumnName("DST_CanPrintOutboxBook");
            entity.Property(e => e.DstCompanyId).HasColumnName("DST_CompanyId");
            entity.Property(e => e.DstIsAutoSaveOnDocumentCreationEnabled).HasColumnName("DST_IsAutoSaveOnDocumentCreationEnabled");
            entity.Property(e => e.DstMappedControlForComments).HasColumnName("DST_MappedControlForComments");
            entity.Property(e => e.DstMappedControlForContractor).HasColumnName("DST_MappedControlForContractor");
            entity.Property(e => e.DstMappedControlForDeclaredValue).HasColumnName("DST_MappedControlForDeclaredValue");
            entity.Property(e => e.DstMappedControlForParameter1).HasColumnName("DST_MappedControlForParameter1");
            entity.Property(e => e.DstMappedControlForParameter2).HasColumnName("DST_MappedControlForParameter2");
            entity.Property(e => e.DstMappedControlForRecipientAddress).HasColumnName("DST_MappedControlForRecipientAddress");
            entity.Property(e => e.DstMappedControlForShipmentFee).HasColumnName("DST_MappedControlForShipmentFee");
            entity.Property(e => e.DstMappedControlForShipmentNumber).HasColumnName("DST_MappedControlForShipmentNumber");
            entity.Property(e => e.DstMappedControlForShipmentValue).HasColumnName("DST_MappedControlForShipmentValue");
            entity.Property(e => e.DstMappedControlForWeight).HasColumnName("DST_MappedControlForWeight");
            entity.Property(e => e.DstOwnData)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DST_OwnData");
            entity.Property(e => e.DstParameter1)
                .HasDefaultValue(-1)
                .HasColumnName("DST_Parameter1");
            entity.Property(e => e.DstParameter2)
                .HasDefaultValue(-2)
                .HasColumnName("DST_Parameter2");
            entity.Property(e => e.DstParameter3)
                .HasDefaultValue(-3)
                .HasColumnName("DST_Parameter3");
            entity.Property(e => e.DstParameter4)
                .HasDefaultValue(-4)
                .HasColumnName("DST_Parameter4");
            entity.Property(e => e.DstParameter5)
                .HasDefaultValue(-5)
                .HasColumnName("DST_Parameter5");
            entity.Property(e => e.DstShowLabelForParameter1).HasColumnName("DST_ShowLabelForParameter1");
            entity.Property(e => e.DstShowLabelForParameter2).HasColumnName("DST_ShowLabelForParameter2");
            entity.Property(e => e.DstShowLabelForParameter3).HasColumnName("DST_ShowLabelForParameter3");
            entity.Property(e => e.DstShowLabelForParameter4)
                .HasDefaultValue(true)
                .HasColumnName("DST_ShowLabelForParameter4");
            entity.Property(e => e.DstShowLabelForParameter5)
                .HasDefaultValue(true)
                .HasColumnName("DST_ShowLabelForParameter5");
            entity.Property(e => e.DstUseCurrentCompany).HasColumnName("DST_UseCurrentCompany");
            entity.Property(e => e.DstWorkWithMobile).HasColumnName("DST_WorkWithMobile");
            entity.Property(e => e.DstWorkflowCardVisibilityFromPropagationMoment)
                .HasDefaultValue(false)
                .HasColumnName("DST_WorkflowCardVisibilityFromPropagationMoment");

            entity.HasOne(d => d.DstDsh).WithOne(p => p.DfConfDssetting)
                .HasForeignKey<DfConfDssetting>(d => d.DstDshid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfDSSettings_DF_ConfDSHead");
        });

        modelBuilder.Entity<DfConfDssettingsAccessCreator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfDSSettingsAccessCreator", "do");

            entity.HasIndex(e => e.DacDfhid, "I_DF_ConfDSSettingsAccessCreator").IsClustered();

            entity.Property(e => e.DacArchival).HasColumnName("DAC_Archival");
            entity.Property(e => e.DacDcdid).HasColumnName("DAC_DCDID");
            entity.Property(e => e.DacDfhid).HasColumnName("DAC_DFHID");

            entity.HasOne(d => d.DacDfh).WithMany()
                .HasForeignKey(d => d.DacDfhid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfDSSettingsAccessCreator_DF_HeadDokumentFlow");
        });

        modelBuilder.Entity<DfConfDssettingsAdvancedSearchControl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfDSSettingsAdvancedSearchControls", "do");

            entity.HasIndex(e => e.DsfDshid, "I_DF_ConfDSSettingsAdvancedSearchControls").IsClustered();

            entity.HasIndex(e => e.DsfDkoid, "I_DF_ConfDSSettingsAdvancedSearchControls_DKO");

            entity.Property(e => e.DsfArchival).HasColumnName("DSF_Archival");
            entity.Property(e => e.DsfDkoid).HasColumnName("DSF_DKOID");
            entity.Property(e => e.DsfDshid).HasColumnName("DSF_DSHID");
        });

        modelBuilder.Entity<DfConfDssettingsObserver>(entity =>
        {
            entity.HasKey(e => new { e.DsoDfhid, e.DsoDcdid });

            entity.ToTable("DF_ConfDSSettingsObservers", "do");

            entity.HasIndex(e => e.DsoDfhid, "I_DF_ConfDSSettingsObservers");

            entity.HasIndex(e => e.DsoDcdid, "I_DF_ConfDSSettingsObservers_DCD");

            entity.Property(e => e.DsoDfhid).HasColumnName("DSO_DFHID");
            entity.Property(e => e.DsoDcdid).HasColumnName("DSO_DCDId");
            entity.Property(e => e.DsoArchival).HasColumnName("DSO_Archival");
            entity.Property(e => e.DsoCanEditDocument).HasColumnName("DSO_CanEditDocument");

            entity.HasOne(d => d.DsoDfh).WithMany(p => p.DfConfDssettingsObservers)
                .HasForeignKey(d => d.DsoDfhid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfDSSettingsObservers_DF_HeadDokumentFlow");
        });

        modelBuilder.Entity<DfConfDssettingsOutboxBookStage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfDSSettingsOutboxBookStages", "do");

            entity.HasIndex(e => e.DbsDshid, "I_DF_ConfDSSettingsOutboxBookStages").IsClustered();

            entity.HasIndex(e => e.DbsDdsid, "I_DF_ConfDSSettingsOutboxBookStages_DDS");

            entity.Property(e => e.DbsArchival).HasColumnName("DBS_Archival");
            entity.Property(e => e.DbsDdsid).HasColumnName("DBS_DDSID");
            entity.Property(e => e.DbsDshid).HasColumnName("DBS_DSHID");
        });

        modelBuilder.Entity<DfConfEmployeeAttachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfEmployeeAttachment", "do");

            entity.Property(e => e.DeaArchival).HasColumnName("DEA_Archival");
            entity.Property(e => e.DeaBin).HasColumnName("DEA_BIN");
            entity.Property(e => e.DeaCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DEA_CreateDate");
            entity.Property(e => e.DeaDcdid).HasColumnName("DEA_DCDID");
            entity.Property(e => e.DeaExtension)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("DEA_Extension");
            entity.Property(e => e.DeaFilePath)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("DEA_FilePath");
            entity.Property(e => e.DeaId).HasColumnName("DEA_ID");
            entity.Property(e => e.DeaMode).HasColumnName("DEA_Mode");
            entity.Property(e => e.DeaModyficationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DEA_ModyficationDate");
            entity.Property(e => e.DeaModyficationDcdid).HasColumnName("DEA_ModyficationDCDID");
            entity.Property(e => e.DeaName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DEA_Name");
            entity.Property(e => e.DeaPos).HasColumnName("DEA_POS");
            entity.Property(e => e.DeaSize).HasColumnName("DEA_Size");
        });

        modelBuilder.Entity<DfConfMultilineColumnEditRestriction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfMultilineColumnEditRestrictions", "do");

            entity.Property(e => e.MerBlockEdit).HasColumnName("MER_BlockEdit");
            entity.Property(e => e.MerDdsid).HasColumnName("MER_DDSID");
            entity.Property(e => e.MerDkoid).HasColumnName("MER_DKOID");
            entity.Property(e => e.MerDmcid).HasColumnName("MER_DMCID");
            entity.Property(e => e.MerIsArchival).HasColumnName("MER_IsArchival");
        });

        modelBuilder.Entity<DfConfNotificationsForWorkflow>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfNotificationsForWorkflow", "do");

            entity.Property(e => e.DfcArchival).HasColumnName("DFC_Archival");
            entity.Property(e => e.DfcDcdid).HasColumnName("DFC_DCDId");
            entity.Property(e => e.DfcDfhid).HasColumnName("DFC_DFHId");
            entity.Property(e => e.DfcNotificationsEnabled).HasColumnName("DFC_NotificationsEnabled");
        });

        modelBuilder.Entity<DfConfOsdictionary>(entity =>
        {
            entity.HasKey(e => e.DcdId);

            entity.ToTable("DF_ConfOSDictionary", "do");

            entity.Property(e => e.DcdId).HasColumnName("DCD_ID");
            entity.Property(e => e.Dcd2fasecretKey)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("DCD_2FASecretKey");
            entity.Property(e => e.DcdAdditionalName1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_AdditionalName1");
            entity.Property(e => e.DcdAdditionalName2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_AdditionalName2");
            entity.Property(e => e.DcdAdditionalName3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_AdditionalName3");
            entity.Property(e => e.DcdAdditionalName4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_AdditionalName4");
            entity.Property(e => e.DcdAdditionalName5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_AdditionalName5");
            entity.Property(e => e.DcdAnonymizedDescription)
                .IsUnicode(false)
                .HasColumnName("DCD_AnonymizedDescription");
            entity.Property(e => e.DcdAnonymizedStartDate)
                .HasColumnType("datetime")
                .HasColumnName("DCD_AnonymizedStartDate");
            entity.Property(e => e.DcdApiKey)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("DCD_ApiKey");
            entity.Property(e => e.DcdAppid).HasColumnName("DCD_APPId");
            entity.Property(e => e.DcdArchival).HasColumnName("DCD_Archival");
            entity.Property(e => e.DcdAutoCreateDocuments).HasColumnName("DCD_AutoCreateDocuments");
            entity.Property(e => e.DcdBackToListAfterPropagate)
                .HasDefaultValue((byte)1)
                .HasColumnName("DCD_BackToListAfterPropagate");
            entity.Property(e => e.DcdCanConfirmContentTerms).HasColumnName("DCD_CanConfirmContentTerms");
            entity.Property(e => e.DcdCanConfirmIntegrityAndAccountsTerms).HasColumnName("DCD_CanConfirmIntegrityAndAccountsTerms");
            entity.Property(e => e.DcdCanCreateDashboards).HasColumnName("DCD_CanCreateDashboards");
            entity.Property(e => e.DcdCanCreateRpaprograms).HasColumnName("DCD_CanCreateRPAPrograms");
            entity.Property(e => e.DcdCanExportListToSpreadsheet).HasColumnName("DCD_CanExportListToSpreadsheet");
            entity.Property(e => e.DcdCanPrintOutboxBook).HasColumnName("DCD_CanPrintOutboxBook");
            entity.Property(e => e.DcdCanPrintPreview).HasColumnName("DCD_CanPrintPreview");
            entity.Property(e => e.DcdCompanyId).HasColumnName("DCD_CompanyId");
            entity.Property(e => e.DcdCreateDocumentFromScan).HasColumnName("DCD_CreateDocumentFromScan");
            entity.Property(e => e.DcdDcpid).HasColumnName("DCD_DCPId");
            entity.Property(e => e.DcdDefaultFullScreen).HasColumnName("DCD_DefaultFullScreen");
            entity.Property(e => e.DcdDeleteDocument).HasColumnName("DCD_DeleteDocument");
            entity.Property(e => e.DcdErplogin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_ERPLogin");
            entity.Property(e => e.DcdForAllDocumentWorkflowsSetSections).HasColumnName("DCD_ForAllDocumentWorkflowsSetSections");
            entity.Property(e => e.DcdGeneralLogConfigSource).HasColumnName("DCD_GeneralLogConfigSource");
            entity.Property(e => e.DcdIsAnonymized).HasColumnName("DCD_IsAnonymized");
            entity.Property(e => e.DcdIsGeneralLoggingEnabled).HasColumnName("DCD_IsGeneralLoggingEnabled");
            entity.Property(e => e.DcdIsRobotizationLoggingEnabled).HasColumnName("DCD_IsRobotizationLoggingEnabled");
            entity.Property(e => e.DcdLastModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("DCD_LastModificationDate");
            entity.Property(e => e.DcdLogin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DCD_Login");
            entity.Property(e => e.DcdLoginMethod).HasColumnName("DCD_LoginMethod");
            entity.Property(e => e.DcdMail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_Mail");
            entity.Property(e => e.DcdMessageOnWorkflowDetailsClosing).HasColumnName("DCD_MessageOnWorkflowDetailsClosing");
            entity.Property(e => e.DcdMlstageSuggestions).HasColumnName("DCD_MLStageSuggestions");
            entity.Property(e => e.DcdMlstageSuggestionsLastCalculation)
                .HasColumnType("datetime")
                .HasColumnName("DCD_MLStageSuggestionsLastCalculation");
            entity.Property(e => e.DcdModificationOfDocumentNumber).HasColumnName("DCD_ModificationOfDocumentNumber");
            entity.Property(e => e.DcdModulesPermission).HasColumnName("DCD_ModulesPermission");
            entity.Property(e => e.DcdName1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_Name1");
            entity.Property(e => e.DcdName2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_Name2");
            entity.Property(e => e.DcdName3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_Name3");
            entity.Property(e => e.DcdNatSystemId).HasColumnName("DCD_NatSystemId");
            entity.Property(e => e.DcdNatSystemId2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCD_NatSystemId2");
            entity.Property(e => e.DcdNatTypeId).HasColumnName("DCD_NatTypeId");
            entity.Property(e => e.DcdOptimaPraimportRowId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("DCD_OptimaPRAImportRowId");
            entity.Property(e => e.DcdPassword)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DCD_Password");
            entity.Property(e => e.DcdPositionRelatedWithDepartment).HasColumnName("DCD_PositionRelatedWithDepartment");
            entity.Property(e => e.DcdReplacementDateRestrictionsDisabled).HasColumnName("DCD_ReplacementDateRestrictionsDisabled");
            entity.Property(e => e.DcdReplacementEmployeeId).HasColumnName("DCD_ReplacementEmployeeId");
            entity.Property(e => e.DcdReplacementEndDate).HasColumnName("DCD_ReplacementEndDate");
            entity.Property(e => e.DcdReplacementStartDate).HasColumnName("DCD_ReplacementStartDate");
            entity.Property(e => e.DcdRobotizationLogConfigSource).HasColumnName("DCD_RobotizationLogConfigSource");
            entity.Property(e => e.DcdRole).HasColumnName("DCD_Role");
            entity.Property(e => e.DcdRunErpinTheBackground).HasColumnName("DCD_RunERPInTheBackground");
            entity.Property(e => e.DcdSaldeoId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_SaldeoId");
            entity.Property(e => e.DcdSaldeoLogin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DCD_SaldeoLogin");
            entity.Property(e => e.DcdSelectedStartupPanelOption).HasColumnName("DCD_SelectedStartupPanelOption");
            entity.Property(e => e.DcdSid).HasColumnName("DCD_Sid");
            entity.Property(e => e.DcdStandardPrintout)
                .HasDefaultValue(true)
                .HasColumnName("DCD_StandardPrintout");
            entity.Property(e => e.DcdType).HasColumnName("DCD_Type");
            entity.Property(e => e.DcdUseOwnXllogin).HasColumnName("DCD_UseOwnXLLogin");
            entity.Property(e => e.DcdUserLoginToken).HasColumnName("DCD_UserLoginToken");

            entity.HasOne(d => d.DcdReplacementEmployee).WithMany(p => p.InverseDcdReplacementEmployee)
                .HasForeignKey(d => d.DcdReplacementEmployeeId)
                .HasConstraintName("FK_DF_ConfOSDictionary_DF_ConfOSDictionary");
        });

        modelBuilder.Entity<DfConfOsemployeePosition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfOSEmployeePosition", "do");

            entity.HasIndex(e => e.DepDcdpositionId, "I_DF_ConfOSEmployeePosition").IsClustered();

            entity.Property(e => e.DepArchival).HasColumnName("DEP_Archival");
            entity.Property(e => e.DepDcdemployeeId).HasColumnName("DEP_DCDEmployeeId");
            entity.Property(e => e.DepDcdpositionId).HasColumnName("DEP_DCDPositionId");

            entity.HasOne(d => d.DepDcdemployee).WithMany()
                .HasForeignKey(d => d.DepDcdemployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfOSEmployeePosition_DF_ConfOSDictionary_employee");

            entity.HasOne(d => d.DepDcdposition).WithMany()
                .HasForeignKey(d => d.DepDcdpositionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfOSEmployeePosition_DF_ConfOSDictionary_position");
        });

        modelBuilder.Entity<DfConfOsemployeesQueue>(entity =>
        {
            entity.HasKey(e => e.DcqId);

            entity.ToTable("DF_ConfOSEmployeesQueue", "do");

            entity.Property(e => e.DcqId).HasColumnName("DCQ_Id");
            entity.Property(e => e.DcqExpirationDate).HasColumnName("DCQ_ExpirationDate");
            entity.Property(e => e.DcqGuid).HasColumnName("DCQ_Guid");
            entity.Property(e => e.DcqIp)
                .HasMaxLength(40)
                .HasColumnName("DCQ_Ip");
            entity.Property(e => e.DcqLogin)
                .HasMaxLength(100)
                .HasColumnName("DCQ_Login");
            entity.Property(e => e.DcqMail)
                .HasMaxLength(255)
                .HasColumnName("DCQ_Mail");
            entity.Property(e => e.DcqName)
                .HasMaxLength(255)
                .HasColumnName("DCQ_Name");
            entity.Property(e => e.DcqNip)
                .HasMaxLength(100)
                .HasColumnName("DCQ_Nip");
            entity.Property(e => e.DcqPassword)
                .HasMaxLength(100)
                .HasColumnName("DCQ_Password");
            entity.Property(e => e.DcqRegistrationDate).HasColumnName("DCQ_RegistrationDate");
            entity.Property(e => e.DcqTermsAccepted).HasColumnName("DCQ_TermsAccepted");
            entity.Property(e => e.DcqWorkConditionsAccepted).HasColumnName("DCQ_WorkConditionsAccepted");
        });

        modelBuilder.Entity<DfConfOsflowAccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfOSFlowAccess", "do");

            entity.HasIndex(e => e.TfaDcdid, "I_DF_ConfOSFlowAccess").IsClustered();

            entity.Property(e => e.TfaDcdid).HasColumnName("TFA_DCDId");
            entity.Property(e => e.TfaDfhid).HasColumnName("TFA_DFHId");
            entity.Property(e => e.TfaExists)
                .HasDefaultValue(true)
                .HasColumnName("TFA_Exists");

            entity.HasOne(d => d.TfaDcd).WithMany()
                .HasForeignKey(d => d.TfaDcdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfOSFlowAccess_DF_ConfOSDictionary_employee");

            entity.HasOne(d => d.TfaDfh).WithMany()
                .HasForeignKey(d => d.TfaDfhid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfOSFlowAccess_DF_ConfOSDictionary_workflow");
        });

        modelBuilder.Entity<DfConfOstree>(entity =>
        {
            entity.HasKey(e => e.DcoId);

            entity.ToTable("DF_ConfOSTree", "do");

            entity.HasIndex(e => e.DcoDcdid, "I_DF_ConfOSTree_DCD");

            entity.HasIndex(e => e.DcoDcoid, "I_DF_ConfOSTree_DCO");

            entity.Property(e => e.DcoId).HasColumnName("DCO_ID");
            entity.Property(e => e.DcoArchival).HasColumnName("DCO_Archival");
            entity.Property(e => e.DcoDcdid).HasColumnName("DCO_DCDId");
            entity.Property(e => e.DcoDcoid).HasColumnName("DCO_DCOId");

            entity.HasOne(d => d.DcoDcd).WithMany(p => p.DfConfOstrees)
                .HasForeignKey(d => d.DcoDcdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfOSTree_DF_ConfOSDictionary");

            entity.HasOne(d => d.DcoDco).WithMany(p => p.InverseDcoDco)
                .HasForeignKey(d => d.DcoDcoid)
                .HasConstraintName("FK_DF_ConfOSTree_DF_ConfOSTree");
        });

        modelBuilder.Entity<DfConfOsworkflowSetting>(entity =>
        {
            entity.HasKey(e => e.CowId);

            entity.ToTable("DF_ConfOSWorkflowSettings", "do");

            entity.Property(e => e.CowId).HasColumnName("COW_ID");
            entity.Property(e => e.CowDcdid).HasColumnName("COW_DCDId");
            entity.Property(e => e.CowDfhid).HasColumnName("COW_DFHId");
            entity.Property(e => e.CowMlstageSuggestions).HasColumnName("COW_MLStageSuggestions");
        });

        modelBuilder.Entity<DfConfPrint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfPrint", "do");

            entity.HasIndex(e => e.DcpDocumentType, "uc_DCP_DocumentType").IsUnique();

            entity.Property(e => e.DcpDocumentType).HasColumnName("DCP_DocumentType");
            entity.Property(e => e.DcpPrint).HasColumnName("DCP_Print");
            entity.Property(e => e.DcpPrintFormat).HasColumnName("DCP_PrintFormat");
            entity.Property(e => e.DcpPrintSource).HasColumnName("DCP_PrintSource");
        });

        modelBuilder.Entity<DfConfRbaccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfRBAccess", "do");

            entity.Property(e => e.RbaDcdid).HasColumnName("RBA_DCDId");
            entity.Property(e => e.RbaRbdid).HasColumnName("RBA_RBDId");

            entity.HasOne(d => d.RbaRbd).WithMany()
                .HasForeignKey(d => d.RbaRbdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ConfRBAccess_DF_ConfRBDictionary");
        });

        modelBuilder.Entity<DfConfRbdictionary>(entity =>
        {
            entity.HasKey(e => e.RbdId);

            entity.ToTable("DF_ConfRBDictionary", "do");

            entity.Property(e => e.RbdId).HasColumnName("RBD_Id");
            entity.Property(e => e.RbdAssemblyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RBD_AssemblyName");
            entity.Property(e => e.RbdProgramDate)
                .HasColumnType("datetime")
                .HasColumnName("RBD_ProgramDate");
            entity.Property(e => e.RbdProgramGenerated)
                .IsUnicode(false)
                .HasColumnName("RBD_ProgramGenerated");
            entity.Property(e => e.RbdProgramName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RBD_ProgramName");
            entity.Property(e => e.RbdProgramReferences)
                .IsUnicode(false)
                .HasColumnName("RBD_ProgramReferences");
            entity.Property(e => e.RbdProgramUser)
                .IsUnicode(false)
                .HasColumnName("RBD_ProgramUser");
        });

        modelBuilder.Entity<DfConfReminder>(entity =>
        {
            entity.HasKey(e => e.CrId);

            entity.ToTable("DF_ConfReminder", "do");

            entity.Property(e => e.CrId).HasColumnName("CR_Id");
            entity.Property(e => e.CrGenerationTime)
                .HasColumnType("datetime")
                .HasColumnName("CR_GenerationTime");
            entity.Property(e => e.CrGuid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CR_Guid");
            entity.Property(e => e.CrUsed).HasColumnName("CR_Used");
            entity.Property(e => e.CrUserId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CR_UserId");
        });

        modelBuilder.Entity<DfConfStampDictionary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfStampDictionary", "do");

            entity.HasIndex(e => e.DcsCompanyId, "uc_DCS_CompanyID").IsUnique();

            entity.Property(e => e.DcsCompanyId).HasColumnName("DCS_CompanyID");
            entity.Property(e => e.DcsLenAmount)
                .HasDefaultValue(70)
                .HasColumnName("DCS_LenAmount");
            entity.Property(e => e.DcsLenBroadcastNumber)
                .HasDefaultValue(140)
                .HasColumnName("DCS_LenBroadcastNumber");
            entity.Property(e => e.DcsLenCharge)
                .HasDefaultValue(70)
                .HasColumnName("DCS_LenCharge");
            entity.Property(e => e.DcsLenComments)
                .HasDefaultValue(140)
                .HasColumnName("DCS_LenComments");
            entity.Property(e => e.DcsLenCustomerAdress)
                .HasDefaultValue(150)
                .HasColumnName("DCS_LenCustomerAdress");
            entity.Property(e => e.DcsLenCustomerName)
                .HasDefaultValue(150)
                .HasColumnName("DCS_LenCustomerName");
            entity.Property(e => e.DcsLenDeclaredValue)
                .HasDefaultValue(80)
                .HasColumnName("DCS_LenDeclaredValue");
            entity.Property(e => e.DcsLenDocumentNummber)
                .HasDefaultValue(150)
                .HasColumnName("DCS_LenDocumentNummber");
            entity.Property(e => e.DcsLenLp)
                .HasDefaultValue(32)
                .HasColumnName("DCS_LenLP");
            entity.Property(e => e.DcsLenWeight)
                .HasDefaultValue(70)
                .HasColumnName("DCS_LenWeight");
            entity.Property(e => e.DcsLine1)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("DCS_Line1");
            entity.Property(e => e.DcsLine2)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("DCS_Line2");
            entity.Property(e => e.DcsLine3)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("DCS_Line3");
        });

        modelBuilder.Entity<DfConfSystemLoggerSetting>(entity =>
        {
            entity.HasKey(e => e.SlsId);

            entity.ToTable("DF_ConfSystemLoggerSettings", "do");

            entity.Property(e => e.SlsId).HasColumnName("SLS_ID");
            entity.Property(e => e.SlsCsScriptLogsConfigSource).HasColumnName("SLS_CsScriptLogsConfigSource");
            entity.Property(e => e.SlsErpXllogsConfigSource).HasColumnName("SLS_ErpXLLogsConfigSource");
            entity.Property(e => e.SlsExeLogsConfigSource).HasColumnName("SLS_ExeLogsConfigSource");
            entity.Property(e => e.SlsGeneralLogsConfigSource).HasColumnName("SLS_GeneralLogsConfigSource");
            entity.Property(e => e.SlsIsCsScriptLogsEnabled).HasColumnName("SLS_IsCsScriptLogsEnabled");
            entity.Property(e => e.SlsIsErpXllogsEnabled).HasColumnName("SLS_IsErpXLLogsEnabled");
            entity.Property(e => e.SlsIsExeLogsEnabled).HasColumnName("SLS_IsExeLogsEnabled");
            entity.Property(e => e.SlsIsGeneralLogsEnabled).HasColumnName("SLS_IsGeneralLogsEnabled");
        });

        modelBuilder.Entity<DfConfUrdokListColumnSetting>(entity =>
        {
            entity.HasKey(e => e.DlcId).HasName("PK__DF_ConfU__BF665B271DE9CEC4");

            entity.ToTable("DF_ConfURDokListColumnSettings", "do");

            entity.Property(e => e.DlcId).HasColumnName("DLC_ID");
            entity.Property(e => e.DlcArchival).HasColumnName("DLC_Archival");
            entity.Property(e => e.DlcColumnName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DLC_ColumnName");
            entity.Property(e => e.DlcDcdid).HasColumnName("DLC_DCDId");
            entity.Property(e => e.DlcDfhid).HasColumnName("DLC_DFHId");
            entity.Property(e => e.DlcPos).HasColumnName("DLC_Pos");
            entity.Property(e => e.DlcWidth).HasColumnName("DLC_Width");
        });

        modelBuilder.Entity<DfConfWorkflowDirectory>(entity =>
        {
            entity.HasKey(e => e.DdwId);

            entity.ToTable("DF_ConfWorkflowDirectory", "do");

            entity.Property(e => e.DdwId).HasColumnName("DDW_Id");
            entity.Property(e => e.DdwArchival)
                .HasDefaultValue(false)
                .HasColumnName("DDW_Archival");
            entity.Property(e => e.DdwCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("DDW_CreateDate");
            entity.Property(e => e.DdwDdwid).HasColumnName("DDW_DDWId");
            entity.Property(e => e.DdwName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DDW_Name");
            entity.Property(e => e.DdwPosition).HasColumnName("DDW_Position");
        });

        modelBuilder.Entity<DfConfWorkflowPattern>(entity =>
        {
            entity.HasKey(e => e.CwpId).HasName("PK__DF_ConfW__C7BD1A13D87D197F");

            entity.ToTable("DF_ConfWorkflowPatterns", "do");

            entity.Property(e => e.CwpId).HasColumnName("CWP_Id");
            entity.Property(e => e.CwpArchival).HasColumnName("CWP_Archival");
            entity.Property(e => e.CwpCsScript).HasColumnName("CWP_CsScript");
            entity.Property(e => e.CwpDescription)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("CWP_Description");
            entity.Property(e => e.CwpErpSystem).HasColumnName("CWP_ErpSystem");
            entity.Property(e => e.CwpFile)
                .IsUnicode(false)
                .HasColumnName("CWP_File");
            entity.Property(e => e.CwpIsLite).HasColumnName("CWP_IsLite");
            entity.Property(e => e.CwpIsPredefined).HasColumnName("CWP_IsPredefined");
            entity.Property(e => e.CwpName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CWP_Name");
            entity.Property(e => e.CwpVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CWP_Version");
        });

        modelBuilder.Entity<DfConfXlLicence>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ConfXlLicences", "do");

            entity.Property(e => e.XllDocumentType).HasColumnName("XLL_DocumentType");
            entity.Property(e => e.XllLicence).HasColumnName("XLL_Licence");
        });

        modelBuilder.Entity<DfDashboard>(entity =>
        {
            entity.HasKey(e => e.DsbId);

            entity.ToTable("DF_Dashboards", "do");

            entity.Property(e => e.DsbId).HasColumnName("DSB_ID");
            entity.Property(e => e.DsbArchival).HasColumnName("DSB_Archival");
            entity.Property(e => e.DsbName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DSB_Name");
            entity.Property(e => e.DsbType).HasColumnName("DSB_Type");
            entity.Property(e => e.DsbXml).HasColumnName("DSB_XML");
        });

        modelBuilder.Entity<DfDashboardsAccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_DashboardsAccess", "do");

            entity.HasIndex(e => e.DbaBsbid, "I_DF_DashboardsAccess").IsClustered();

            entity.Property(e => e.DbaArchival).HasColumnName("DBA_Archival");
            entity.Property(e => e.DbaBsbid).HasColumnName("DBA_BSBID");
            entity.Property(e => e.DbaDcdid).HasColumnName("DBA_DCDID");

            entity.HasOne(d => d.DbaBsb).WithMany()
                .HasForeignKey(d => d.DbaBsbid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_DashboardsAccess_DF_Dashboards");
        });

        modelBuilder.Entity<DfHeadDokumentFlow>(entity =>
        {
            entity.HasKey(e => e.DfhId);

            entity.ToTable("DF_HeadDokumentFlow", "do");

            entity.HasIndex(e => e.DfhPrefix, "I_DF_HeadDocumentFlowPrefix");

            entity.Property(e => e.DfhId).HasColumnName("DFH_Id");
            entity.Property(e => e.DfhArchives).HasColumnName("DFH_Archives");
            entity.Property(e => e.DfhChangesHistory).HasColumnName("DFH_ChangesHistory");
            entity.Property(e => e.DfhCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("DFH_CreateDate");
            entity.Property(e => e.DfhCreatedInDmsversion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DFH_CreatedInDMSVersion");
            entity.Property(e => e.DfhDdwid).HasColumnName("DFH_DDWId");
            entity.Property(e => e.DfhIconId)
                .HasDefaultValue(1)
                .HasColumnName("DFH_IconId");
            entity.Property(e => e.DfhIsLocked).HasColumnName("DFH_IsLocked");
            entity.Property(e => e.DfhLockedByCompanyId).HasColumnName("DFH_LockedByCompanyId");
            entity.Property(e => e.DfhLockedByUserId).HasColumnName("DFH_LockedByUserId");
            entity.Property(e => e.DfhLockedTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("DFH_LockedTimestamp");
            entity.Property(e => e.DfhName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DFH_Name");
            entity.Property(e => e.DfhPosition).HasColumnName("DFH_Position");
            entity.Property(e => e.DfhPrefix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DFH_Prefix");
            entity.Property(e => e.DfhSddtyp).HasColumnName("DFH_SDDTyp");
            entity.Property(e => e.DfhSymbol)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DFH_Symbol");
            entity.Property(e => e.DfhType).HasColumnName("DFH_Type");
        });

        modelBuilder.Entity<DfNotificationToken>(entity =>
        {
            entity.HasKey(e => e.DntId);

            entity.ToTable("DF_NotificationTokens", "do");

            entity.Property(e => e.DntId).HasColumnName("DNT_ID");
            entity.Property(e => e.DntDcdid).HasColumnName("DNT_DCDId");
            entity.Property(e => e.DntPlatform).HasColumnName("DNT_Platform");
            entity.Property(e => e.DntToken)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DNT_Token");
        });

        modelBuilder.Entity<DfOneTimeToken>(entity =>
        {
            entity.HasKey(e => e.OttId);

            entity.ToTable("DF_OneTimeTokens", "do");

            entity.Property(e => e.OttId).HasColumnName("OTT_ID");
            entity.Property(e => e.OttAppid).HasColumnName("OTT_APPId");
            entity.Property(e => e.OttCreated)
                .HasColumnType("datetime")
                .HasColumnName("OTT_Created");
            entity.Property(e => e.OttCreatedByIp)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("OTT_CreatedByIp");
            entity.Property(e => e.OttDcdid).HasColumnName("OTT_DCDId");
            entity.Property(e => e.OttExpires)
                .HasColumnType("datetime")
                .HasColumnName("OTT_Expires");
            entity.Property(e => e.OttPath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OTT_Path");
            entity.Property(e => e.OttToken)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OTT_Token");
            entity.Property(e => e.OttUsed)
                .HasColumnType("datetime")
                .HasColumnName("OTT_Used");
            entity.Property(e => e.OttUsedByIp)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("OTT_UsedByIp");

            entity.HasOne(d => d.OttApp).WithMany(p => p.DfOneTimeTokens)
                .HasForeignKey(d => d.OttAppid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_OneTimeTokens_DF_Applications");

            entity.HasOne(d => d.OttDcd).WithMany(p => p.DfOneTimeTokens)
                .HasForeignKey(d => d.OttDcdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_OneTimeTokens_DF_ConfOSDictionary");
        });

        modelBuilder.Entity<DfRefreshToken>(entity =>
        {
            entity.HasKey(e => e.RftId);

            entity.ToTable("DF_RefreshTokens", "do");

            entity.Property(e => e.RftId).HasColumnName("RFT_ID");
            entity.Property(e => e.RftAppid).HasColumnName("RFT_APPId");
            entity.Property(e => e.RftCreated)
                .HasColumnType("datetime")
                .HasColumnName("RFT_Created");
            entity.Property(e => e.RftCreatedByIp)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("RFT_CreatedByIp");
            entity.Property(e => e.RftDcdid).HasColumnName("RFT_DCDId");
            entity.Property(e => e.RftExpires)
                .HasColumnType("datetime")
                .HasColumnName("RFT_Expires");
            entity.Property(e => e.RftReplacedByToken)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RFT_ReplacedByToken");
            entity.Property(e => e.RftRevoked)
                .HasColumnType("datetime")
                .HasColumnName("RFT_Revoked");
            entity.Property(e => e.RftRevokedByIp)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("RFT_RevokedByIp");
            entity.Property(e => e.RftToken)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RFT_Token");

            entity.HasOne(d => d.RftApp).WithMany(p => p.DfRefreshTokens)
                .HasForeignKey(d => d.RftAppid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_RefreshTokens_DF_Applications");

            entity.HasOne(d => d.RftDcd).WithMany(p => p.DfRefreshTokens)
                .HasForeignKey(d => d.RftDcdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_RefreshTokens_DF_ConfOSDictionary");
        });

        modelBuilder.Entity<DfReport>(entity =>
        {
            entity.HasKey(e => e.RptId);

            entity.ToTable("DF_Reports", "do");

            entity.Property(e => e.RptId).HasColumnName("RPT_ID");
            entity.Property(e => e.RptArchival).HasColumnName("RPT_Archival");
            entity.Property(e => e.RptData).HasColumnName("RPT_Data");
            entity.Property(e => e.RptDescription)
                .HasMaxLength(255)
                .HasColumnName("RPT_Description");
            entity.Property(e => e.RptGuid).HasColumnName("RPT_GUID");
            entity.Property(e => e.RptName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RPT_Name");
            entity.Property(e => e.RptShowInReportList)
                .HasDefaultValue(true)
                .HasColumnName("RPT_ShowInReportList");
            entity.Property(e => e.RptSource).HasColumnName("RPT_Source");
            entity.Property(e => e.RptType).HasColumnName("RPT_Type");
        });

        modelBuilder.Entity<DfReportsAccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ReportsAccess", "do");

            entity.Property(e => e.RpaArchival).HasColumnName("RPA_Archival");
            entity.Property(e => e.RpaDcdid).HasColumnName("RPA_DCDID");
            entity.Property(e => e.RpaRptid).HasColumnName("RPA_RPTID");

            entity.HasOne(d => d.RpaRpt).WithMany()
                .HasForeignKey(d => d.RpaRptid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ReportsAccess_DF_Reports");
        });

        modelBuilder.Entity<DfReportsWorkflowTypesAccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_ReportsWorkflowTypesAccess", "do");

            entity.Property(e => e.RwaArchival).HasColumnName("RWA_Archival");
            entity.Property(e => e.RwaDfhid).HasColumnName("RWA_DFHID");
            entity.Property(e => e.RwaRptid).HasColumnName("RWA_RPTID");
            entity.Property(e => e.RwaType).HasColumnName("RWA_Type");

            entity.HasOne(d => d.RwaDfh).WithMany()
                .HasForeignKey(d => d.RwaDfhid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ReportsWorkflowTypesAccess_DF_HeadDokumentFlow");

            entity.HasOne(d => d.RwaRpt).WithMany()
                .HasForeignKey(d => d.RwaRptid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_ReportsWorkflowTypesAccess_DF_Reports");
        });

        modelBuilder.Entity<DfSession>(entity =>
        {
            entity.HasKey(e => e.SId);

            entity.ToTable("DF_Sessions", "do", tb => tb.HasTrigger("CreateSessionHistory"));

            entity.Property(e => e.SId).HasColumnName("S_ID");
            entity.Property(e => e.SApptype).HasColumnName("S_APPTYPE");
            entity.Property(e => e.SGuid).HasColumnName("S_GUID");
            entity.Property(e => e.SIpAddress)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("S_IpAddress");
            entity.Property(e => e.SLastaccess)
                .HasColumnType("datetime")
                .HasColumnName("S_LASTACCESS");
            entity.Property(e => e.SOperator)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_OPERATOR");
            entity.Property(e => e.SOperatorid).HasColumnName("S_OPERATORID");
        });

        modelBuilder.Entity<DfSessionHistory>(entity =>
        {
            entity.HasKey(e => e.ShId);

            entity.ToTable("DF_SessionHistory", "do");

            entity.Property(e => e.ShId).HasColumnName("SH_ID");
            entity.Property(e => e.ShAppType).HasColumnName("SH_AppType");
            entity.Property(e => e.ShGuid).HasColumnName("SH_GUID");
            entity.Property(e => e.ShLoginDate)
                .HasColumnType("datetime")
                .HasColumnName("SH_LoginDate");
            entity.Property(e => e.ShLogoutDate)
                .HasColumnType("datetime")
                .HasColumnName("SH_LogoutDate");
            entity.Property(e => e.ShLpAddress)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("SH_LpAddress");
            entity.Property(e => e.ShOperator)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SH_Operator");
            entity.Property(e => e.ShOperatorId).HasColumnName("SH_OperatorID");
            entity.Property(e => e.ShWorkingTimeMinutes).HasColumnName("SH_WorkingTimeMinutes");
        });

        modelBuilder.Entity<DfWork>(entity =>
        {
            entity.HasKey(e => e.DwdId);

            entity.ToTable("DF_Work", "do");

            entity.HasIndex(e => e.DwdDcdlockUserId, "I_DF_WorkLockDocument_DCDId");

            entity.HasIndex(e => new { e.DwdYear, e.DwdMonth, e.DwdNumber }, "I_DF_WorkYearMonthNumber");

            entity.HasIndex(e => e.DwdArchival, "I_DF_Work_Archival");

            entity.HasIndex(e => e.DwdDshid, "I_DF_Work_DSH");

            entity.HasIndex(e => new { e.DwdDshid, e.DwdArchival }, "I_DF_Work_DSHArch");

            entity.Property(e => e.DwdId).HasColumnName("DWD_ID");
            entity.Property(e => e.DwdArchival).HasColumnName("DWD_Archival");
            entity.Property(e => e.DwdCompanyId).HasColumnName("DWD_CompanyId");
            entity.Property(e => e.DwdCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("DWD_CreateDate");
            entity.Property(e => e.DwdDcdcreatorId).HasColumnName("DWD_DCDCreatorId");
            entity.Property(e => e.DwdDcdlockUserId).HasColumnName("DWD_DCDLockUserId");
            entity.Property(e => e.DwdDcdownerId).HasColumnName("DWD_DCDOwnerId");
            entity.Property(e => e.DwdDshid).HasColumnName("DWD_DSHId");
            entity.Property(e => e.DwdDwscurrentStageId).HasColumnName("DWD_DWSCurrentStageId");
            entity.Property(e => e.DwdErpdepartmentId).HasColumnName("DWD_ERPDepartmentId");
            entity.Property(e => e.DwdFullNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DWD_FullNumber");
            entity.Property(e => e.DwdIsAutoSaved).HasColumnName("DWD_IsAutoSaved");
            entity.Property(e => e.DwdLockDate)
                .HasColumnType("datetime")
                .HasColumnName("DWD_LockDate");
            entity.Property(e => e.DwdMonth).HasColumnName("DWD_Month");
            entity.Property(e => e.DwdNatSddid).HasColumnName("DWD_NatSDDId");
            entity.Property(e => e.DwdNumber)
                .HasDefaultValue(0)
                .HasColumnName("DWD_Number");
            entity.Property(e => e.DwdParentDocumentDwdid).HasColumnName("DWD_ParentDocumentDWDId");
            entity.Property(e => e.DwdSelectedNextStageId).HasColumnName("DWD_SelectedNextStageId");
            entity.Property(e => e.DwdYear).HasColumnName("DWD_Year");

            entity.HasOne(d => d.DwdDcdowner).WithMany(p => p.DfWorks)
                .HasForeignKey(d => d.DwdDcdownerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_Work_DF_ConfOSDictionary");

            entity.HasOne(d => d.DwdDsh).WithMany(p => p.DfWorks)
                .HasForeignKey(d => d.DwdDshid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_Work_DF_ConfDSHead");

            entity.HasOne(d => d.DwdDwscurrentStage).WithMany(p => p.DfWorks)
                .HasForeignKey(d => d.DwdDwscurrentStageId)
                .HasConstraintName("FK_DF_Work_DF_WorkDS");
        });

        modelBuilder.Entity<DfWorkAddimension>(entity =>
        {
            entity.HasKey(e => e.AddId);

            entity.ToTable("DF_WorkADDimension", "do");

            entity.Property(e => e.AddId).HasColumnName("ADD_Id");
            entity.Property(e => e.AddAdhid).HasColumnName("ADD_ADHId");
            entity.Property(e => e.AddName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ADD_Name");
            entity.Property(e => e.AddNatSystemId).HasColumnName("ADD_NatSystemID");

            entity.HasOne(d => d.AddAdh).WithMany(p => p.DfWorkAddimensions)
                .HasForeignKey(d => d.AddAdhid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkADDimension_DF_WorkADHeader");
        });

        modelBuilder.Entity<DfWorkAdheader>(entity =>
        {
            entity.HasKey(e => e.AdhId);

            entity.ToTable("DF_WorkADHeader", "do", tb => tb.HasTrigger("DF_WorkADHeaderCopyHistory"));

            entity.Property(e => e.AdhId).HasColumnName("ADH_Id");
            entity.Property(e => e.AdhAcceptedDate)
                .HasColumnType("datetime")
                .HasColumnName("ADH_AcceptedDate");
            entity.Property(e => e.AdhAnalyticalDateId).HasColumnName("ADH_AnalyticalDateId");
            entity.Property(e => e.AdhAnalyticalDateName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADH_AnalyticalDateName");
            entity.Property(e => e.AdhArchival).HasColumnName("ADH_Archival");
            entity.Property(e => e.AdhDcdacceptedBy).HasColumnName("ADH_DCDAcceptedBy");
            entity.Property(e => e.AdhDcdid).HasColumnName("ADH_DCDID");
            entity.Property(e => e.AdhDdsid).HasColumnName("ADH_DDSID");
            entity.Property(e => e.AdhFinancialCategoryId).HasColumnName("ADH_FinancialCategoryId");
            entity.Property(e => e.AdhFinancialCategoryName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADH_FinancialCategoryName");
            entity.Property(e => e.AdhModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("ADH_ModificationDate");
            entity.Property(e => e.AdhName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADH_Name");
            entity.Property(e => e.AdhXldid).HasColumnName("ADH_XLDId");
        });

        modelBuilder.Entity<DfWorkAdheaderHistory>(entity =>
        {
            entity.HasKey(e => e.AdjId).HasFillFactor(80);

            entity.ToTable("DF_WorkADHeaderHistory", "do");

            entity.Property(e => e.AdjId).HasColumnName("ADJ_Id");
            entity.Property(e => e.AdjAcceptedDate)
                .HasColumnType("datetime")
                .HasColumnName("ADJ_AcceptedDate");
            entity.Property(e => e.AdjAdhid).HasColumnName("ADJ_ADHId");
            entity.Property(e => e.AdjAnalyticalDateId).HasColumnName("ADJ_AnalyticalDateId");
            entity.Property(e => e.AdjAnalyticalDateName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADJ_AnalyticalDateName");
            entity.Property(e => e.AdjArchival).HasColumnName("ADJ_Archival");
            entity.Property(e => e.AdjDcdacceptedBy).HasColumnName("ADJ_DCDAcceptedBy");
            entity.Property(e => e.AdjDcdid).HasColumnName("ADJ_DCDID");
            entity.Property(e => e.AdjDdsid).HasColumnName("ADJ_DDSID");
            entity.Property(e => e.AdjFinancialCategoryId).HasColumnName("ADJ_FinancialCategoryId");
            entity.Property(e => e.AdjFinancialCategoryName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADJ_FinancialCategoryName");
            entity.Property(e => e.AdjModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("ADJ_ModificationDate");
            entity.Property(e => e.AdjName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADJ_Name");
            entity.Property(e => e.AdjXldid).HasColumnName("ADJ_XLDId");
        });

        modelBuilder.Entity<DfWorkAditem>(entity =>
        {
            entity.HasKey(e => e.AdiId);

            entity.ToTable("DF_WorkADItem", "do");

            entity.Property(e => e.AdiId).HasColumnName("ADI_Id");
            entity.Property(e => e.AdiAdhid).HasColumnName("ADI_ADHId");
            entity.Property(e => e.AdiAmount)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("ADI_Amount");
            entity.Property(e => e.AdiArchival).HasColumnName("ADI_Archival");
            entity.Property(e => e.AdiDcdid).HasColumnName("adi_DCDID");
            entity.Property(e => e.AdiDdsid).HasColumnName("adi_DDSID");
            entity.Property(e => e.AdiModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("adi_ModificationDate");
            entity.Property(e => e.AdiPercent)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("ADI_Percent");
            entity.Property(e => e.AdiPositionId).HasColumnName("ADI_PositionId");
            entity.Property(e => e.AdiPositionIsVat).HasColumnName("ADI_PositionIsVat");
            entity.Property(e => e.AdiPositionName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADI_PositionName");
        });

        modelBuilder.Entity<DfWorkAdvalue>(entity =>
        {
            entity.HasKey(e => e.AdvId);

            entity.ToTable("DF_WorkADValue", "do");

            entity.HasIndex(e => new { e.AdvAdiid, e.AdvNatSystemId }, "I_DF_WorkADValue_ADII_And_NatSystemId");

            entity.Property(e => e.AdvId).HasColumnName("ADV_Id");
            entity.Property(e => e.AdvAddid).HasColumnName("ADV_ADDId");
            entity.Property(e => e.AdvAdiid).HasColumnName("ADV_ADIId");
            entity.Property(e => e.AdvArchival).HasColumnName("ADV_Archival");
            entity.Property(e => e.AdvDcdid).HasColumnName("ADV_DCDID");
            entity.Property(e => e.AdvDdsid).HasColumnName("ADV_DDSID");
            entity.Property(e => e.AdvElementName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADV_ElementName");
            entity.Property(e => e.AdvModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("ADV_ModificationDate");
            entity.Property(e => e.AdvName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADV_Name");
            entity.Property(e => e.AdvNatSystemId).HasColumnName("ADV_NatSystemId");
            entity.Property(e => e.AdvType).HasColumnName("ADV_Type");

            entity.HasOne(d => d.AdvAdd).WithMany(p => p.DfWorkAdvalues)
                .HasForeignKey(d => d.AdvAddid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkADValue_DF_WorkADDimension");

            entity.HasOne(d => d.AdvAdi).WithMany(p => p.DfWorkAdvalues)
                .HasForeignKey(d => d.AdvAdiid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkADValue_DF_WorkADItem");
        });

        modelBuilder.Entity<DfWorkAnonymizableLog>(entity =>
        {
            entity.HasKey(e => e.AlgId);

            entity.ToTable("DF_WorkAnonymizableLog", "do");

            entity.Property(e => e.AlgId).HasColumnName("ALG_Id");
            entity.Property(e => e.AlgCdcid).HasColumnName("ALG_CDCid");
            entity.Property(e => e.AlgDate)
                .HasColumnType("datetime")
                .HasColumnName("ALG_Date");
            entity.Property(e => e.AlgDwcid).HasColumnName("ALG_DWCId");
            entity.Property(e => e.AlgDwlid).HasColumnName("ALG_DWLId");
            entity.Property(e => e.AlgXldid).HasColumnName("ALG_XLDId");
        });

        modelBuilder.Entity<DfWorkApprocess>(entity =>
        {
            entity.HasKey(e => e.ApwId);

            entity.ToTable("DF_WorkAPProcess", "do");

            entity.Property(e => e.ApwId).HasColumnName("APW_Id");
            entity.Property(e => e.ApwApdid).HasColumnName("APW_APDId");
            entity.Property(e => e.ApwDocumentId1).HasColumnName("APW_DocumentID1");
            entity.Property(e => e.ApwDocumentId2).HasColumnName("APW_DocumentID2");
        });

        modelBuilder.Entity<DfWorkCf>(entity =>
        {
            entity.HasKey(e => e.DwcId);

            entity.ToTable("DF_WorkCF", "do", tb => tb.HasTrigger("DF_WorkCFCopyHistory"));

            entity.HasIndex(e => e.DwcDkoid, "I_DF_WorkCF_DKOId");

            entity.HasIndex(e => e.DwcDwdid, "I_DF_WorkCF_DWDId");

            entity.HasIndex(e => e.DwcValueDate, "I_DF_WorkCF_Date");

            entity.HasIndex(e => e.DwcValueInt, "I_DF_WorkCF_Int");

            entity.HasIndex(e => e.DwcValueReal, "I_DF_WorkCF_Real");

            entity.HasIndex(e => e.DwcValueString, "I_DF_WorkCF_String");

            entity.HasIndex(e => new { e.DwcDwdid, e.DwcDkoid }, "I_DF_Work_CF_DWD_DKO").IsUnique();

            entity.Property(e => e.DwcId).HasColumnName("DWC_ID");
            entity.Property(e => e.DwcDcdid).HasColumnName("DWC_DCDID");
            entity.Property(e => e.DwcDdsid).HasColumnName("DWC_DDSID");
            entity.Property(e => e.DwcDkoid).HasColumnName("DWC_DKOId");
            entity.Property(e => e.DwcDwdid).HasColumnName("DWC_DWDId");
            entity.Property(e => e.DwcGidid).HasColumnName("DWC_GIDId");
            entity.Property(e => e.DwcGidtype).HasColumnName("DWC_GIDType");
            entity.Property(e => e.DwcLastUsedCalculationMode).HasColumnName("DWC_LastUsedCalculationMode");
            entity.Property(e => e.DwcModificationData)
                .HasColumnType("datetime")
                .HasColumnName("DWC_ModificationData");
            entity.Property(e => e.DwcNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DWC_Number");
            entity.Property(e => e.DwcValueDate)
                .HasColumnType("datetime")
                .HasColumnName("DWC_ValueDate");
            entity.Property(e => e.DwcValueDecimal)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWC_ValueDecimal");
            entity.Property(e => e.DwcValueInt).HasColumnName("DWC_ValueInt");
            entity.Property(e => e.DwcValueListPos).HasColumnName("DWC_ValueListPos");
            entity.Property(e => e.DwcValueReal).HasColumnName("DWC_ValueReal");
            entity.Property(e => e.DwcValueString)
                .IsUnicode(false)
                .HasColumnName("DWC_ValueString");
            entity.Property(e => e.DwcValueStringId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWC_ValueStringId");

            entity.HasOne(d => d.DwcDwd).WithMany(p => p.DfWorkCfs)
                .HasForeignKey(d => d.DwcDwdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkCF_DF_Work");
        });

        modelBuilder.Entity<DfWorkCfbin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_WorkCFBin", "do");

            entity.HasIndex(e => new { e.DwbDwcid, e.DwbDrtid, e.DwbArchival }, "I_DF_WorkCFBin_DWB_DWCID_DWB_DRTID_DWB_Archival");

            entity.HasIndex(e => e.DwbName, "I_DF_WorkCFBin_DWB_Name");

            entity.HasIndex(e => e.DwbIdint, "PK_DF_WorkCFBin")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.DwbAngleOfRotation)
                .HasDefaultValue(0)
                .HasColumnName("DWB_AngleOfRotation");
            entity.Property(e => e.DwbArchival)
                .HasDefaultValue(0)
                .HasColumnName("DWB_Archival");
            entity.Property(e => e.DwbArchiveDocumentId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWB_ArchiveDocumentId");
            entity.Property(e => e.DwbArchiveDocumentLinkId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWB_ArchiveDocumentLinkId");
            entity.Property(e => e.DwbArchiveDocumentLocationId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWB_ArchiveDocumentLocationId");
            entity.Property(e => e.DwbArchiveDocumentTypeId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWB_ArchiveDocumentTypeId");
            entity.Property(e => e.DwbBin).HasColumnName("DWB_BIN");
            entity.Property(e => e.DwbCompanyId).HasColumnName("DWB_CompanyId");
            entity.Property(e => e.DwbCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DWB_CreateDate");
            entity.Property(e => e.DwbDcdid).HasColumnName("DWB_DCDID");
            entity.Property(e => e.DwbDdsid).HasColumnName("DWB_DDSID");
            entity.Property(e => e.DwbDrtid).HasColumnName("DWB_DRTID");
            entity.Property(e => e.DwbDwcid).HasColumnName("DWB_DWCID");
            entity.Property(e => e.DwbErpid).HasColumnName("DWB_ERPId");
            entity.Property(e => e.DwbFilePath)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("DWB_FilePath");
            entity.Property(e => e.DwbIbardId).HasColumnName("DWB_IbardId");
            entity.Property(e => e.DwbId).HasColumnName("DWB_ID");
            entity.Property(e => e.DwbIdint)
                .ValueGeneratedOnAdd()
                .HasColumnName("DWB_IDInt");
            entity.Property(e => e.DwbMode).HasColumnName("DWB_Mode");
            entity.Property(e => e.DwbModificationData)
                .HasColumnType("datetime")
                .HasColumnName("DWB_ModificationData");
            entity.Property(e => e.DwbName)
                .HasMaxLength(255)
                .HasColumnName("DWB_Name");
            entity.Property(e => e.DwbPos).HasColumnName("DWB_POS");
            entity.Property(e => e.DwbSigned)
                .HasDefaultValue(false)
                .HasColumnName("DWB_Signed");
            entity.Property(e => e.DwbSize).HasColumnName("DWB_Size");

            entity.HasOne(d => d.DwbDwc).WithMany()
                .HasForeignKey(d => d.DwbDwcid)
                .HasConstraintName("FK_DF_WorkCFBin_DF_WorkCF");
        });

        modelBuilder.Entity<DfWorkCfhistory>(entity =>
        {
            entity.HasKey(e => e.DwjId).HasFillFactor(80);

            entity.ToTable("DF_WorkCFHistory", "do");

            entity.Property(e => e.DwjId).HasColumnName("DWJ_ID");
            entity.Property(e => e.DwjDcdid).HasColumnName("DWJ_DCDID");
            entity.Property(e => e.DwjDdsid).HasColumnName("DWJ_DDSID");
            entity.Property(e => e.DwjDkoid).HasColumnName("DWJ_DKOId");
            entity.Property(e => e.DwjDwcid).HasColumnName("DWJ_DWCId");
            entity.Property(e => e.DwjDwdid).HasColumnName("DWJ_DWDId");
            entity.Property(e => e.DwjGidid).HasColumnName("DWJ_GIDId");
            entity.Property(e => e.DwjGidtype).HasColumnName("DWJ_GIDType");
            entity.Property(e => e.DwjModificationData)
                .HasColumnType("datetime")
                .HasColumnName("DWJ_ModificationData");
            entity.Property(e => e.DwjNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DWJ_Number");
            entity.Property(e => e.DwjValueDate)
                .HasColumnType("datetime")
                .HasColumnName("DWJ_ValueDate");
            entity.Property(e => e.DwjValueDecimal)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWJ_ValueDecimal");
            entity.Property(e => e.DwjValueInt).HasColumnName("DWJ_ValueInt");
            entity.Property(e => e.DwjValueListPos).HasColumnName("DWJ_ValueListPos");
            entity.Property(e => e.DwjValueReal).HasColumnName("DWJ_ValueReal");
            entity.Property(e => e.DwjValueString)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWJ_ValueString");
        });

        modelBuilder.Entity<DfWorkCfmultiLine>(entity =>
        {
            entity.HasKey(e => e.DwlId);

            entity.ToTable("DF_WorkCFMultiLine", "do", tb => tb.HasTrigger("DF_WorkCFMultiLineCopyHistory"));

            entity.HasIndex(e => e.DwlDwdid, "I_DF_WorkCFMultiLineDWD").HasFillFactor(80);

            entity.HasIndex(e => e.DwlValueString1, "I_DF_WorkCFMultiLine_String1");

            entity.HasIndex(e => e.DwlValueString10, "I_DF_WorkCFMultiLine_String10");

            entity.HasIndex(e => e.DwlValueString11, "I_DF_WorkCFMultiLine_String11");

            entity.HasIndex(e => e.DwlValueString12, "I_DF_WorkCFMultiLine_String12");

            entity.HasIndex(e => e.DwlValueString13, "I_DF_WorkCFMultiLine_String13");

            entity.HasIndex(e => e.DwlValueString14, "I_DF_WorkCFMultiLine_String14");

            entity.HasIndex(e => e.DwlValueString15, "I_DF_WorkCFMultiLine_String15");

            entity.HasIndex(e => e.DwlValueString16, "I_DF_WorkCFMultiLine_String16");

            entity.HasIndex(e => e.DwlValueString17, "I_DF_WorkCFMultiLine_String17");

            entity.HasIndex(e => e.DwlValueString18, "I_DF_WorkCFMultiLine_String18");

            entity.HasIndex(e => e.DwlValueString19, "I_DF_WorkCFMultiLine_String19");

            entity.HasIndex(e => e.DwlValueString2, "I_DF_WorkCFMultiLine_String2");

            entity.HasIndex(e => e.DwlValueString20, "I_DF_WorkCFMultiLine_String20");

            entity.HasIndex(e => e.DwlValueString3, "I_DF_WorkCFMultiLine_String3");

            entity.HasIndex(e => e.DwlValueString4, "I_DF_WorkCFMultiLine_String4");

            entity.HasIndex(e => e.DwlValueString5, "I_DF_WorkCFMultiLine_String5");

            entity.HasIndex(e => e.DwlValueString6, "I_DF_WorkCFMultiLine_String6");

            entity.HasIndex(e => e.DwlValueString7, "I_DF_WorkCFMultiLine_String7");

            entity.HasIndex(e => e.DwlValueString8, "I_DF_WorkCFMultiLine_String8");

            entity.HasIndex(e => e.DwlValueString9, "I_DF_WorkCFMultiLine_String9");

            entity.Property(e => e.DwlId).HasColumnName("DWL_ID");
            entity.Property(e => e.DwlArchival).HasColumnName("DWL_Archival");
            entity.Property(e => e.DwlDcdid).HasColumnName("DWL_DCDID");
            entity.Property(e => e.DwlDdsid).HasColumnName("DWL_DDSID");
            entity.Property(e => e.DwlDkoid).HasColumnName("DWL_DKOId");
            entity.Property(e => e.DwlDwdid).HasColumnName("DWL_DWDId");
            entity.Property(e => e.DwlMappedPosition).HasColumnName("DWL_MappedPosition");
            entity.Property(e => e.DwlModificationData)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ModificationData");
            entity.Property(e => e.DwlPosition).HasColumnName("DWL_Position");
            entity.Property(e => e.DwlValueDate1)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate1");
            entity.Property(e => e.DwlValueDate10)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate10");
            entity.Property(e => e.DwlValueDate11)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate11");
            entity.Property(e => e.DwlValueDate12)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate12");
            entity.Property(e => e.DwlValueDate13)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate13");
            entity.Property(e => e.DwlValueDate14)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate14");
            entity.Property(e => e.DwlValueDate15)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate15");
            entity.Property(e => e.DwlValueDate16)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate16");
            entity.Property(e => e.DwlValueDate17)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate17");
            entity.Property(e => e.DwlValueDate18)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate18");
            entity.Property(e => e.DwlValueDate19)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate19");
            entity.Property(e => e.DwlValueDate2)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate2");
            entity.Property(e => e.DwlValueDate20)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate20");
            entity.Property(e => e.DwlValueDate3)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate3");
            entity.Property(e => e.DwlValueDate4)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate4");
            entity.Property(e => e.DwlValueDate5)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate5");
            entity.Property(e => e.DwlValueDate6)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate6");
            entity.Property(e => e.DwlValueDate7)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate7");
            entity.Property(e => e.DwlValueDate8)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate8");
            entity.Property(e => e.DwlValueDate9)
                .HasColumnType("datetime")
                .HasColumnName("DWL_ValueDate9");
            entity.Property(e => e.DwlValueDecimal1)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal1");
            entity.Property(e => e.DwlValueDecimal10)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal10");
            entity.Property(e => e.DwlValueDecimal11)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal11");
            entity.Property(e => e.DwlValueDecimal12)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal12");
            entity.Property(e => e.DwlValueDecimal13)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal13");
            entity.Property(e => e.DwlValueDecimal14)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal14");
            entity.Property(e => e.DwlValueDecimal15)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal15");
            entity.Property(e => e.DwlValueDecimal16)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal16");
            entity.Property(e => e.DwlValueDecimal17)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal17");
            entity.Property(e => e.DwlValueDecimal18)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal18");
            entity.Property(e => e.DwlValueDecimal19)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal19");
            entity.Property(e => e.DwlValueDecimal2)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal2");
            entity.Property(e => e.DwlValueDecimal20)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal20");
            entity.Property(e => e.DwlValueDecimal3)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal3");
            entity.Property(e => e.DwlValueDecimal4)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal4");
            entity.Property(e => e.DwlValueDecimal5)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal5");
            entity.Property(e => e.DwlValueDecimal6)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal6");
            entity.Property(e => e.DwlValueDecimal7)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal7");
            entity.Property(e => e.DwlValueDecimal8)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal8");
            entity.Property(e => e.DwlValueDecimal9)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWL_ValueDecimal9");
            entity.Property(e => e.DwlValueInt1).HasColumnName("DWL_ValueInt1");
            entity.Property(e => e.DwlValueInt10).HasColumnName("DWL_ValueInt10");
            entity.Property(e => e.DwlValueInt11).HasColumnName("DWL_ValueInt11");
            entity.Property(e => e.DwlValueInt12).HasColumnName("DWL_ValueInt12");
            entity.Property(e => e.DwlValueInt13).HasColumnName("DWL_ValueInt13");
            entity.Property(e => e.DwlValueInt14).HasColumnName("DWL_ValueInt14");
            entity.Property(e => e.DwlValueInt15).HasColumnName("DWL_ValueInt15");
            entity.Property(e => e.DwlValueInt16).HasColumnName("DWL_ValueInt16");
            entity.Property(e => e.DwlValueInt17).HasColumnName("DWL_ValueInt17");
            entity.Property(e => e.DwlValueInt18).HasColumnName("DWL_ValueInt18");
            entity.Property(e => e.DwlValueInt19).HasColumnName("DWL_ValueInt19");
            entity.Property(e => e.DwlValueInt2).HasColumnName("DWL_ValueInt2");
            entity.Property(e => e.DwlValueInt20).HasColumnName("DWL_ValueInt20");
            entity.Property(e => e.DwlValueInt3).HasColumnName("DWL_ValueInt3");
            entity.Property(e => e.DwlValueInt4).HasColumnName("DWL_ValueInt4");
            entity.Property(e => e.DwlValueInt5).HasColumnName("DWL_ValueInt5");
            entity.Property(e => e.DwlValueInt6).HasColumnName("DWL_ValueInt6");
            entity.Property(e => e.DwlValueInt7).HasColumnName("DWL_ValueInt7");
            entity.Property(e => e.DwlValueInt8).HasColumnName("DWL_ValueInt8");
            entity.Property(e => e.DwlValueInt9).HasColumnName("DWL_ValueInt9");
            entity.Property(e => e.DwlValueReal1).HasColumnName("DWL_ValueReal1");
            entity.Property(e => e.DwlValueReal10).HasColumnName("DWL_ValueReal10");
            entity.Property(e => e.DwlValueReal11).HasColumnName("DWL_ValueReal11");
            entity.Property(e => e.DwlValueReal12).HasColumnName("DWL_ValueReal12");
            entity.Property(e => e.DwlValueReal13).HasColumnName("DWL_ValueReal13");
            entity.Property(e => e.DwlValueReal14).HasColumnName("DWL_ValueReal14");
            entity.Property(e => e.DwlValueReal15).HasColumnName("DWL_ValueReal15");
            entity.Property(e => e.DwlValueReal16).HasColumnName("DWL_ValueReal16");
            entity.Property(e => e.DwlValueReal17).HasColumnName("DWL_ValueReal17");
            entity.Property(e => e.DwlValueReal18).HasColumnName("DWL_ValueReal18");
            entity.Property(e => e.DwlValueReal19).HasColumnName("DWL_ValueReal19");
            entity.Property(e => e.DwlValueReal2).HasColumnName("DWL_ValueReal2");
            entity.Property(e => e.DwlValueReal20).HasColumnName("DWL_ValueReal20");
            entity.Property(e => e.DwlValueReal3).HasColumnName("DWL_ValueReal3");
            entity.Property(e => e.DwlValueReal4).HasColumnName("DWL_ValueReal4");
            entity.Property(e => e.DwlValueReal5).HasColumnName("DWL_ValueReal5");
            entity.Property(e => e.DwlValueReal6).HasColumnName("DWL_ValueReal6");
            entity.Property(e => e.DwlValueReal7).HasColumnName("DWL_ValueReal7");
            entity.Property(e => e.DwlValueReal8).HasColumnName("DWL_ValueReal8");
            entity.Property(e => e.DwlValueReal9).HasColumnName("DWL_ValueReal9");
            entity.Property(e => e.DwlValueString1)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString1");
            entity.Property(e => e.DwlValueString10)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString10");
            entity.Property(e => e.DwlValueString11)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString11");
            entity.Property(e => e.DwlValueString12)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString12");
            entity.Property(e => e.DwlValueString13)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString13");
            entity.Property(e => e.DwlValueString14)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString14");
            entity.Property(e => e.DwlValueString15)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString15");
            entity.Property(e => e.DwlValueString16)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString16");
            entity.Property(e => e.DwlValueString17)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString17");
            entity.Property(e => e.DwlValueString18)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString18");
            entity.Property(e => e.DwlValueString19)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString19");
            entity.Property(e => e.DwlValueString2)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString2");
            entity.Property(e => e.DwlValueString20)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString20");
            entity.Property(e => e.DwlValueString3)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString3");
            entity.Property(e => e.DwlValueString4)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString4");
            entity.Property(e => e.DwlValueString5)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString5");
            entity.Property(e => e.DwlValueString6)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString6");
            entity.Property(e => e.DwlValueString7)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString7");
            entity.Property(e => e.DwlValueString8)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString8");
            entity.Property(e => e.DwlValueString9)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueString9");
            entity.Property(e => e.DwlValueStringId1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId1");
            entity.Property(e => e.DwlValueStringId10)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId10");
            entity.Property(e => e.DwlValueStringId11)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId11");
            entity.Property(e => e.DwlValueStringId12)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId12");
            entity.Property(e => e.DwlValueStringId13)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId13");
            entity.Property(e => e.DwlValueStringId14)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId14");
            entity.Property(e => e.DwlValueStringId15)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId15");
            entity.Property(e => e.DwlValueStringId16)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId16");
            entity.Property(e => e.DwlValueStringId17)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId17");
            entity.Property(e => e.DwlValueStringId18)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId18");
            entity.Property(e => e.DwlValueStringId19)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId19");
            entity.Property(e => e.DwlValueStringId2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId2");
            entity.Property(e => e.DwlValueStringId20)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId20");
            entity.Property(e => e.DwlValueStringId3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId3");
            entity.Property(e => e.DwlValueStringId4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId4");
            entity.Property(e => e.DwlValueStringId5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId5");
            entity.Property(e => e.DwlValueStringId6)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId6");
            entity.Property(e => e.DwlValueStringId7)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId7");
            entity.Property(e => e.DwlValueStringId8)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId8");
            entity.Property(e => e.DwlValueStringId9)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringId9");
            entity.Property(e => e.DwlValueStringType1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType1");
            entity.Property(e => e.DwlValueStringType10)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType10");
            entity.Property(e => e.DwlValueStringType11)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType11");
            entity.Property(e => e.DwlValueStringType12)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType12");
            entity.Property(e => e.DwlValueStringType13)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType13");
            entity.Property(e => e.DwlValueStringType14)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType14");
            entity.Property(e => e.DwlValueStringType15)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType15");
            entity.Property(e => e.DwlValueStringType16)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType16");
            entity.Property(e => e.DwlValueStringType17)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType17");
            entity.Property(e => e.DwlValueStringType18)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType18");
            entity.Property(e => e.DwlValueStringType19)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType19");
            entity.Property(e => e.DwlValueStringType2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType2");
            entity.Property(e => e.DwlValueStringType20)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType20");
            entity.Property(e => e.DwlValueStringType3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType3");
            entity.Property(e => e.DwlValueStringType4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType4");
            entity.Property(e => e.DwlValueStringType5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType5");
            entity.Property(e => e.DwlValueStringType6)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType6");
            entity.Property(e => e.DwlValueStringType7)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType7");
            entity.Property(e => e.DwlValueStringType8)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType8");
            entity.Property(e => e.DwlValueStringType9)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DWL_ValueStringType9");
            entity.Property(e => e.DwlValueType1).HasColumnName("DWL_ValueType1");
            entity.Property(e => e.DwlValueType10).HasColumnName("DWL_ValueType10");
            entity.Property(e => e.DwlValueType11).HasColumnName("DWL_ValueType11");
            entity.Property(e => e.DwlValueType12).HasColumnName("DWL_ValueType12");
            entity.Property(e => e.DwlValueType13).HasColumnName("DWL_ValueType13");
            entity.Property(e => e.DwlValueType14).HasColumnName("DWL_ValueType14");
            entity.Property(e => e.DwlValueType15).HasColumnName("DWL_ValueType15");
            entity.Property(e => e.DwlValueType16).HasColumnName("DWL_ValueType16");
            entity.Property(e => e.DwlValueType17).HasColumnName("DWL_ValueType17");
            entity.Property(e => e.DwlValueType18).HasColumnName("DWL_ValueType18");
            entity.Property(e => e.DwlValueType19).HasColumnName("DWL_ValueType19");
            entity.Property(e => e.DwlValueType2).HasColumnName("DWL_ValueType2");
            entity.Property(e => e.DwlValueType20).HasColumnName("DWL_ValueType20");
            entity.Property(e => e.DwlValueType3).HasColumnName("DWL_ValueType3");
            entity.Property(e => e.DwlValueType4).HasColumnName("DWL_ValueType4");
            entity.Property(e => e.DwlValueType5).HasColumnName("DWL_ValueType5");
            entity.Property(e => e.DwlValueType6).HasColumnName("DWL_ValueType6");
            entity.Property(e => e.DwlValueType7).HasColumnName("DWL_ValueType7");
            entity.Property(e => e.DwlValueType8).HasColumnName("DWL_ValueType8");
            entity.Property(e => e.DwlValueType9).HasColumnName("DWL_ValueType9");
        });

        modelBuilder.Entity<DfWorkCfmultiLineHistory>(entity =>
        {
            entity.HasKey(e => e.DwhId);

            entity.ToTable("DF_WorkCFMultiLineHistory", "do");

            entity.Property(e => e.DwhId).HasColumnName("DWH_ID");
            entity.Property(e => e.DwhArchival).HasColumnName("DWH_Archival");
            entity.Property(e => e.DwhDcdid).HasColumnName("DWH_DCDID");
            entity.Property(e => e.DwhDdsid).HasColumnName("DWH_DDSID");
            entity.Property(e => e.DwhDkoid).HasColumnName("DWH_DKOId");
            entity.Property(e => e.DwhDwdid).HasColumnName("DWH_DWDId");
            entity.Property(e => e.DwhDwlid).HasColumnName("DWH_DWLId");
            entity.Property(e => e.DwhMappedPosition).HasColumnName("DWH_MappedPosition");
            entity.Property(e => e.DwhModificationData)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ModificationData");
            entity.Property(e => e.DwhRow).HasColumnName("DWH_Row");
            entity.Property(e => e.DwhValueDate1)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate1");
            entity.Property(e => e.DwhValueDate10)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate10");
            entity.Property(e => e.DwhValueDate11)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate11");
            entity.Property(e => e.DwhValueDate12)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate12");
            entity.Property(e => e.DwhValueDate13)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate13");
            entity.Property(e => e.DwhValueDate14)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate14");
            entity.Property(e => e.DwhValueDate15)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate15");
            entity.Property(e => e.DwhValueDate16)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate16");
            entity.Property(e => e.DwhValueDate17)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate17");
            entity.Property(e => e.DwhValueDate18)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate18");
            entity.Property(e => e.DwhValueDate19)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate19");
            entity.Property(e => e.DwhValueDate2)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate2");
            entity.Property(e => e.DwhValueDate20)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate20");
            entity.Property(e => e.DwhValueDate3)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate3");
            entity.Property(e => e.DwhValueDate4)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate4");
            entity.Property(e => e.DwhValueDate5)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate5");
            entity.Property(e => e.DwhValueDate6)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate6");
            entity.Property(e => e.DwhValueDate7)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate7");
            entity.Property(e => e.DwhValueDate8)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate8");
            entity.Property(e => e.DwhValueDate9)
                .HasColumnType("datetime")
                .HasColumnName("DWH_ValueDate9");
            entity.Property(e => e.DwhValueDecimal1)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal1");
            entity.Property(e => e.DwhValueDecimal10)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal10");
            entity.Property(e => e.DwhValueDecimal11)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal11");
            entity.Property(e => e.DwhValueDecimal12)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal12");
            entity.Property(e => e.DwhValueDecimal13)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal13");
            entity.Property(e => e.DwhValueDecimal14)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal14");
            entity.Property(e => e.DwhValueDecimal15)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal15");
            entity.Property(e => e.DwhValueDecimal16)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal16");
            entity.Property(e => e.DwhValueDecimal17)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal17");
            entity.Property(e => e.DwhValueDecimal18)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal18");
            entity.Property(e => e.DwhValueDecimal19)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal19");
            entity.Property(e => e.DwhValueDecimal2)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal2");
            entity.Property(e => e.DwhValueDecimal20)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal20");
            entity.Property(e => e.DwhValueDecimal3)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal3");
            entity.Property(e => e.DwhValueDecimal4)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal4");
            entity.Property(e => e.DwhValueDecimal5)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal5");
            entity.Property(e => e.DwhValueDecimal6)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal6");
            entity.Property(e => e.DwhValueDecimal7)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal7");
            entity.Property(e => e.DwhValueDecimal8)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal8");
            entity.Property(e => e.DwhValueDecimal9)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWH_ValueDecimal9");
            entity.Property(e => e.DwhValueInt1).HasColumnName("DWH_ValueInt1");
            entity.Property(e => e.DwhValueInt10).HasColumnName("DWH_ValueInt10");
            entity.Property(e => e.DwhValueInt11).HasColumnName("DWH_ValueInt11");
            entity.Property(e => e.DwhValueInt12).HasColumnName("DWH_ValueInt12");
            entity.Property(e => e.DwhValueInt13).HasColumnName("DWH_ValueInt13");
            entity.Property(e => e.DwhValueInt14).HasColumnName("DWH_ValueInt14");
            entity.Property(e => e.DwhValueInt15).HasColumnName("DWH_ValueInt15");
            entity.Property(e => e.DwhValueInt16).HasColumnName("DWH_ValueInt16");
            entity.Property(e => e.DwhValueInt17).HasColumnName("DWH_ValueInt17");
            entity.Property(e => e.DwhValueInt18).HasColumnName("DWH_ValueInt18");
            entity.Property(e => e.DwhValueInt19).HasColumnName("DWH_ValueInt19");
            entity.Property(e => e.DwhValueInt2).HasColumnName("DWH_ValueInt2");
            entity.Property(e => e.DwhValueInt20).HasColumnName("DWH_ValueInt20");
            entity.Property(e => e.DwhValueInt3).HasColumnName("DWH_ValueInt3");
            entity.Property(e => e.DwhValueInt4).HasColumnName("DWH_ValueInt4");
            entity.Property(e => e.DwhValueInt5).HasColumnName("DWH_ValueInt5");
            entity.Property(e => e.DwhValueInt6).HasColumnName("DWH_ValueInt6");
            entity.Property(e => e.DwhValueInt7).HasColumnName("DWH_ValueInt7");
            entity.Property(e => e.DwhValueInt8).HasColumnName("DWH_ValueInt8");
            entity.Property(e => e.DwhValueInt9).HasColumnName("DWH_ValueInt9");
            entity.Property(e => e.DwhValueReal1).HasColumnName("DWH_ValueReal1");
            entity.Property(e => e.DwhValueReal10).HasColumnName("DWH_ValueReal10");
            entity.Property(e => e.DwhValueReal11).HasColumnName("DWH_ValueReal11");
            entity.Property(e => e.DwhValueReal12).HasColumnName("DWH_ValueReal12");
            entity.Property(e => e.DwhValueReal13).HasColumnName("DWH_ValueReal13");
            entity.Property(e => e.DwhValueReal14).HasColumnName("DWH_ValueReal14");
            entity.Property(e => e.DwhValueReal15).HasColumnName("DWH_ValueReal15");
            entity.Property(e => e.DwhValueReal16).HasColumnName("DWH_ValueReal16");
            entity.Property(e => e.DwhValueReal17).HasColumnName("DWH_ValueReal17");
            entity.Property(e => e.DwhValueReal18).HasColumnName("DWH_ValueReal18");
            entity.Property(e => e.DwhValueReal19).HasColumnName("DWH_ValueReal19");
            entity.Property(e => e.DwhValueReal2).HasColumnName("DWH_ValueReal2");
            entity.Property(e => e.DwhValueReal20).HasColumnName("DWH_ValueReal20");
            entity.Property(e => e.DwhValueReal3).HasColumnName("DWH_ValueReal3");
            entity.Property(e => e.DwhValueReal4).HasColumnName("DWH_ValueReal4");
            entity.Property(e => e.DwhValueReal5).HasColumnName("DWH_ValueReal5");
            entity.Property(e => e.DwhValueReal6).HasColumnName("DWH_ValueReal6");
            entity.Property(e => e.DwhValueReal7).HasColumnName("DWH_ValueReal7");
            entity.Property(e => e.DwhValueReal8).HasColumnName("DWH_ValueReal8");
            entity.Property(e => e.DwhValueReal9).HasColumnName("DWH_ValueReal9");
            entity.Property(e => e.DwhValueString1)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString1");
            entity.Property(e => e.DwhValueString10)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString10");
            entity.Property(e => e.DwhValueString11)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString11");
            entity.Property(e => e.DwhValueString12)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString12");
            entity.Property(e => e.DwhValueString13)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString13");
            entity.Property(e => e.DwhValueString14)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString14");
            entity.Property(e => e.DwhValueString15)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString15");
            entity.Property(e => e.DwhValueString16)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString16");
            entity.Property(e => e.DwhValueString17)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString17");
            entity.Property(e => e.DwhValueString18)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString18");
            entity.Property(e => e.DwhValueString19)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString19");
            entity.Property(e => e.DwhValueString2)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString2");
            entity.Property(e => e.DwhValueString20)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString20");
            entity.Property(e => e.DwhValueString3)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString3");
            entity.Property(e => e.DwhValueString4)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString4");
            entity.Property(e => e.DwhValueString5)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString5");
            entity.Property(e => e.DwhValueString6)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString6");
            entity.Property(e => e.DwhValueString7)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString7");
            entity.Property(e => e.DwhValueString8)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString8");
            entity.Property(e => e.DwhValueString9)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWH_ValueString9");
            entity.Property(e => e.DwhValueType1).HasColumnName("DWH_ValueType1");
            entity.Property(e => e.DwhValueType10).HasColumnName("DWH_ValueType10");
            entity.Property(e => e.DwhValueType11).HasColumnName("DWH_ValueType11");
            entity.Property(e => e.DwhValueType12).HasColumnName("DWH_ValueType12");
            entity.Property(e => e.DwhValueType13).HasColumnName("DWH_ValueType13");
            entity.Property(e => e.DwhValueType14).HasColumnName("DWH_ValueType14");
            entity.Property(e => e.DwhValueType15).HasColumnName("DWH_ValueType15");
            entity.Property(e => e.DwhValueType16).HasColumnName("DWH_ValueType16");
            entity.Property(e => e.DwhValueType17).HasColumnName("DWH_ValueType17");
            entity.Property(e => e.DwhValueType18).HasColumnName("DWH_ValueType18");
            entity.Property(e => e.DwhValueType19).HasColumnName("DWH_ValueType19");
            entity.Property(e => e.DwhValueType2).HasColumnName("DWH_ValueType2");
            entity.Property(e => e.DwhValueType20).HasColumnName("DWH_ValueType20");
            entity.Property(e => e.DwhValueType3).HasColumnName("DWH_ValueType3");
            entity.Property(e => e.DwhValueType4).HasColumnName("DWH_ValueType4");
            entity.Property(e => e.DwhValueType5).HasColumnName("DWH_ValueType5");
            entity.Property(e => e.DwhValueType6).HasColumnName("DWH_ValueType6");
            entity.Property(e => e.DwhValueType7).HasColumnName("DWH_ValueType7");
            entity.Property(e => e.DwhValueType8).HasColumnName("DWH_ValueType8");
            entity.Property(e => e.DwhValueType9).HasColumnName("DWH_ValueType9");
        });

        modelBuilder.Entity<DfWorkCfworkflowDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_WorkCFWorkflowDocuments", "do");

            entity.HasIndex(e => e.DwwDwdid, "I_DF_WorkCFWorkflowDocuments_DWW_DWDId").IsClustered();

            entity.Property(e => e.DwwArchival).HasColumnName("DWW_Archival");
            entity.Property(e => e.DwwDcdid).HasColumnName("DWW_DCDID");
            entity.Property(e => e.DwwDdsid).HasColumnName("DWW_DDSID");
            entity.Property(e => e.DwwDwcid).HasColumnName("DWW_DWCId");
            entity.Property(e => e.DwwDwdid).HasColumnName("DWW_DWDId");
            entity.Property(e => e.DwwModificationData)
                .HasColumnType("datetime")
                .HasColumnName("DWW_ModificationData");

            entity.HasOne(d => d.DwwDwc).WithMany()
                .HasForeignKey(d => d.DwwDwcid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkCFWorkflowDocuments_DF_WorkCF");

            entity.HasOne(d => d.DwwDwd).WithMany()
                .HasForeignKey(d => d.DwwDwdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkCFWorkflowDocuments_DF_Work");
        });

        modelBuilder.Entity<DfWorkCounter>(entity =>
        {
            entity.HasKey(e => new { e.DwtYear, e.DwtMonth, e.DwtDfhid })
                .HasName("DWT_Primary")
                .HasFillFactor(80);

            entity.ToTable("DF_WorkCounter", "do");

            entity.Property(e => e.DwtYear).HasColumnName("DWT_Year");
            entity.Property(e => e.DwtMonth).HasColumnName("DWT_Month");
            entity.Property(e => e.DwtDfhid).HasColumnName("DWT_DFHID");
            entity.Property(e => e.DwtNumber).HasColumnName("DWT_Number");
        });

        modelBuilder.Entity<DfWorkCustomContentDiagnosticLog>(entity =>
        {
            entity.HasKey(e => e.CcdId);

            entity.ToTable("DF_WorkCustomContentDiagnosticLog", "do");

            entity.Property(e => e.CcdId).HasColumnName("CCD_ID");
            entity.Property(e => e.CcdCcsid).HasColumnName("CCD_CCSID");
            entity.Property(e => e.CcdCctid).HasColumnName("CCD_CCTID");
            entity.Property(e => e.CcdDcdid).HasColumnName("CCD_DCDID");
            entity.Property(e => e.CcdDdsid).HasColumnName("CCD_DDSID");
            entity.Property(e => e.CcdDkoid).HasColumnName("CCD_DKOID");
            entity.Property(e => e.CcdDmlid).HasColumnName("CCD_DMLID");
            entity.Property(e => e.CcdDshid).HasColumnName("CCD_DSHID");
            entity.Property(e => e.CcdDuration).HasColumnName("CCD_Duration");
            entity.Property(e => e.CcdDwdid).HasColumnName("CCD_DWDID");
            entity.Property(e => e.CcdEventGuid).HasColumnName("CCD_EventGuid");
            entity.Property(e => e.CcdStartTime).HasColumnName("CCD_StartTime");

            entity.HasOne(d => d.CcdCcs).WithMany(p => p.DfWorkCustomContentDiagnosticLogs)
                .HasForeignKey(d => d.CcdCcsid)
                .HasConstraintName("FK_DF_WorkCustomContentDiagnosticLog_DF_WorkCustomContentDiagnosticSessions");

            entity.HasOne(d => d.CcdCct).WithMany(p => p.DfWorkCustomContentDiagnosticLogs)
                .HasForeignKey(d => d.CcdCctid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkCustomContentDiagnosticLog_DF_WorkCustomContentType");
        });

        modelBuilder.Entity<DfWorkCustomContentDiagnosticSession>(entity =>
        {
            entity.HasKey(e => e.CcsId);

            entity.ToTable("DF_WorkCustomContentDiagnosticSessions", "do");

            entity.Property(e => e.CcsId).HasColumnName("CCS_ID");
            entity.Property(e => e.CcsEndTime).HasColumnName("CCS_EndTime");
            entity.Property(e => e.CcsIsActive).HasColumnName("CCS_IsActive");
            entity.Property(e => e.CcsName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CCS_Name");
            entity.Property(e => e.CcsStartTime).HasColumnName("CCS_StartTime");
        });

        modelBuilder.Entity<DfWorkCustomContentType>(entity =>
        {
            entity.HasKey(e => e.CctId);

            entity.ToTable("DF_WorkCustomContentType", "do");

            entity.Property(e => e.CctId)
                .ValueGeneratedNever()
                .HasColumnName("CCT_ID");
            entity.Property(e => e.CctName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CCT_Name");
        });

        modelBuilder.Entity<DfWorkD>(entity =>
        {
            entity.HasKey(e => e.DwsId);

            entity.ToTable("DF_WorkDS", "do");

            entity.HasIndex(e => e.DwsCreateDate, "I_DF_WorkDS_CreateDate");

            entity.HasIndex(e => e.DwsDcdpersonId, "I_DF_WorkDS_DCDId");

            entity.HasIndex(e => e.DwsDdsid, "I_DF_WorkDS_DDSId");

            entity.HasIndex(e => e.DwsDwdid, "I_DF_WorkDS_DWDId");

            entity.Property(e => e.DwsId).HasColumnName("DWS_ID");
            entity.Property(e => e.DwsActionType).HasColumnName("DWS_ActionType");
            entity.Property(e => e.DwsCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("DWS_CreateDate");
            entity.Property(e => e.DwsDcdownerId).HasColumnName("DWS_DCDOwnerId");
            entity.Property(e => e.DwsDcdpersonId).HasColumnName("DWS_DCDPersonId");
            entity.Property(e => e.DwsDcdreplacementPersonId).HasColumnName("DWS_DCDReplacementPersonId");
            entity.Property(e => e.DwsDcdunfrozenBy).HasColumnName("DWS_DCDUnfrozenBy");
            entity.Property(e => e.DwsDdsid).HasColumnName("DWS_DDSId");
            entity.Property(e => e.DwsDwdid).HasColumnName("DWS_DWDId");
            entity.Property(e => e.DwsIsCurrent).HasColumnName("DWS_IsCurrent");
            entity.Property(e => e.DwsIsMailSentToObservers).HasColumnName("DWS_IsMailSentToObservers");
            entity.Property(e => e.DwsIsMailSentToPermitted).HasColumnName("DWS_IsMailSentToPermitted");
            entity.Property(e => e.DwsIsReturnFromStage).HasColumnName("DWS_IsReturnFromStage");
            entity.Property(e => e.DwsLimitedPermissions).HasColumnName("DWS_LimitedPermissions");
            entity.Property(e => e.DwsMessage)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWS_Message");
            entity.Property(e => e.DwsNatSosId).HasColumnName("DWS_NatSosId");
            entity.Property(e => e.DwsTaskRealisationExpirationTime)
                .HasColumnType("datetime")
                .HasColumnName("DWS_TaskRealisationExpirationTime");
            entity.Property(e => e.DwsTaskRealisationSendReminderFromDate).HasColumnName("DWS_TaskRealisationSendReminderFromDate");
            entity.Property(e => e.DwsTaskRealisationTimeLimitMinutes).HasColumnName("DWS_TaskRealisationTimeLimitMinutes");
            entity.Property(e => e.DwsUnfreezeDate)
                .HasColumnType("datetime")
                .HasColumnName("DWS_UnfreezeDate");

            entity.HasOne(d => d.DwsDcdperson).WithMany(p => p.DfWorkDDwsDcdpeople)
                .HasForeignKey(d => d.DwsDcdpersonId)
                .HasConstraintName("FK_DF_WorkDS_DF_ConfOSDictionary");

            entity.HasOne(d => d.DwsDcdreplacementPerson).WithMany(p => p.DfWorkDDwsDcdreplacementPeople)
                .HasForeignKey(d => d.DwsDcdreplacementPersonId)
                .HasConstraintName("FK_DF_ConfOSDictionary_DF_WorkDS");

            entity.HasOne(d => d.DwsDds).WithMany(p => p.DfWorkDs)
                .HasForeignKey(d => d.DwsDdsid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkDS_DF_ConfDSDictionary");

            entity.HasOne(d => d.DwsDwd).WithMany(p => p.DfWorkDs)
                .HasForeignKey(d => d.DwsDwdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkDS_DF_Work");
        });

        modelBuilder.Entity<DfWorkDsaccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_WorkDSAccess", "do");

            entity.HasIndex(e => e.WsaDcdid, "I_DF_WorkDSAccess_DCDId").IsClustered();

            entity.HasIndex(e => e.WsaDwsid, "I_DF_WorkDSAccess_DWSId");

            entity.Property(e => e.WsaArchival).HasColumnName("WSA_Archival");
            entity.Property(e => e.WsaDcdid).HasColumnName("WSA_DCDId");
            entity.Property(e => e.WsaDcpid).HasColumnName("WSA_DCPId");
            entity.Property(e => e.WsaDwsid).HasColumnName("WSA_DWSId");
            entity.Property(e => e.WsaTypeAccess).HasColumnName("WSA_TypeAccess");

            entity.HasOne(d => d.WsaDcd).WithMany()
                .HasForeignKey(d => d.WsaDcdid)
                .HasConstraintName("FK_DF_WorkDSAccess_DF_ConfOSDictionary");

            entity.HasOne(d => d.WsaDws).WithMany()
                .HasForeignKey(d => d.WsaDwsid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkDSAccess_DF_WorkDS");
        });

        modelBuilder.Entity<DfWorkDsaccessLimited>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_WorkDSAccessLimited", "do");

            entity.HasIndex(e => e.EsaDcdid, "I_DF_WorkDSAccessLimited_ESA_DCDId").IsClustered();

            entity.Property(e => e.EsaDcdid).HasColumnName("ESA_DCDId");
            entity.Property(e => e.EsaDwsid).HasColumnName("ESA_DWSId");

            entity.HasOne(d => d.EsaDcd).WithMany()
                .HasForeignKey(d => d.EsaDcdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkDSAccessLimited_DF_ConfOSDictionary");

            entity.HasOne(d => d.EsaDws).WithMany()
                .HasForeignKey(d => d.EsaDwsid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkDSAccessLimited_DF_WorkDS");
        });

        modelBuilder.Entity<DfWorkDscurrentStageAccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_WorkDSCurrentStageAccess", "do");

            entity.Property(e => e.WscDcdid).HasColumnName("WSC_DCDId");
            entity.Property(e => e.WscDdsid).HasColumnName("WSC_DDSId");
            entity.Property(e => e.WscDwsid).HasColumnName("WSC_DWSId");
        });

        modelBuilder.Entity<DfWorkDscurrentStageAccessLimited>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DF_WorkDSCurrentStageAccessLimited", "do");

            entity.Property(e => e.SalDcdid).HasColumnName("SAL_DCDId");
            entity.Property(e => e.SalDdsid).HasColumnName("SAL_DDSId");
            entity.Property(e => e.SalDwsid).HasColumnName("SAL_DWSId");
        });

        modelBuilder.Entity<DfWorkDsparallelApproval>(entity =>
        {
            entity.HasKey(e => e.DwpId);

            entity.ToTable("DF_WorkDSParallelApproval", "do");

            entity.Property(e => e.DwpId).HasColumnName("DWP_ID");
            entity.Property(e => e.DwpApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("DWP_ApprovalDate");
            entity.Property(e => e.DwpApproved).HasColumnName("DWP_Approved");
            entity.Property(e => e.DwpArchival).HasColumnName("DWP_Archival");
            entity.Property(e => e.DwpDcdid).HasColumnName("DWP_DCDId");
            entity.Property(e => e.DwpDcdreplacementPersonId).HasColumnName("DWP_DCDReplacementPersonId");
            entity.Property(e => e.DwpDwsid).HasColumnName("DWP_DWSId");
            entity.Property(e => e.DwpMessage)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWP_Message");
        });

        modelBuilder.Entity<DfWorkErpXlaccrualNoteItem>(entity =>
        {
            entity.HasKey(e => e.XlnId).HasName("PK__DF_WorkE__B2B15AA92BB27409");

            entity.ToTable("DF_WorkErpXLAccrualNoteItem", "do");

            entity.Property(e => e.XlnId).HasColumnName("XLN_Id");
            entity.Property(e => e.XlnArchival).HasColumnName("XLN_Archival");
            entity.Property(e => e.XlnDcdid).HasColumnName("XLN_DCDID");
            entity.Property(e => e.XlnDdsid).HasColumnName("XLN_DDSID");
            entity.Property(e => e.XlnDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLN_Description");
            entity.Property(e => e.XlnExpenditure)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLN_Expenditure");
            entity.Property(e => e.XlnIncome)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLN_Income");
            entity.Property(e => e.XlnModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("XLN_ModificationDate");
            entity.Property(e => e.XlnPosition).HasColumnName("XLN_Position");
            entity.Property(e => e.XlnSymbolId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLN_SymbolId");
            entity.Property(e => e.XlnXldid).HasColumnName("XLN_XLDId");

            entity.HasOne(d => d.XlnXld).WithMany(p => p.DfWorkErpXlaccrualNoteItems)
                .HasForeignKey(d => d.XlnXldid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkErpXLAccrualNoteItem_DF_WorkErpXLDocument");
        });

        modelBuilder.Entity<DfWorkErpXlarticle>(entity =>
        {
            entity.HasKey(e => e.XlaId).HasName("PK__DF_WorkE__238740DFBC1AA5CF");

            entity.ToTable("DF_WorkErpXLArticles", "do", tb => tb.HasTrigger("WorkErpXLArticlesCopyHistory"));

            entity.Property(e => e.XlaId).HasColumnName("XLA_ID");
            entity.Property(e => e.XlaArchival).HasColumnName("XLA_Archival");
            entity.Property(e => e.XlaArticleCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLA_ArticleCode");
            entity.Property(e => e.XlaArticleId).HasColumnName("XLA_ArticleId");
            entity.Property(e => e.XlaArticleName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLA_ArticleName");
            entity.Property(e => e.XlaCorrectionDocumentAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLA_CorrectionDocumentAmount");
            entity.Property(e => e.XlaDcdid).HasColumnName("XLA_DCDID");
            entity.Property(e => e.XlaDdsid).HasColumnName("XLA_DDSID");
            entity.Property(e => e.XlaIsBaseUnit).HasColumnName("XLA_IsBaseUnit");
            entity.Property(e => e.XlaModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("XLA_ModificationDate");
            entity.Property(e => e.XlaPosition).HasColumnName("XLA_Position");
            entity.Property(e => e.XlaPrice)
                .HasColumnType("decimal(24, 10)")
                .HasColumnName("XLA_Price");
            entity.Property(e => e.XlaQuantity)
                .HasColumnType("decimal(24, 10)")
                .HasColumnName("XLA_Quantity");
            entity.Property(e => e.XlaTaxRateId).HasColumnName("XLA_TaxRateId");
            entity.Property(e => e.XlaUnitName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("XLA_UnitName");
            entity.Property(e => e.XlaVatDeduction).HasColumnName("XLA_VatDeduction");
            entity.Property(e => e.XlaVatValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLA_VatValue");
            entity.Property(e => e.XlaXldid).HasColumnName("XLA_XLDId");

            entity.HasOne(d => d.XlaXld).WithMany(p => p.DfWorkErpXlarticles)
                .HasForeignKey(d => d.XlaXldid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkErpXLDocumentArticles_DF_WorkErpXLDocument");
        });

        modelBuilder.Entity<DfWorkErpXlarticlesHistory>(entity =>
        {
            entity.HasKey(e => e.XlhId)
                .HasName("PK__DF_WorkE__C3EB7713D468515C")
                .HasFillFactor(80);

            entity.ToTable("DF_WorkErpXLArticlesHistory", "do");

            entity.Property(e => e.XlhId).HasColumnName("XLH_ID");
            entity.Property(e => e.XlhArchival).HasColumnName("XLH_Archival");
            entity.Property(e => e.XlhArticleCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLH_ArticleCode");
            entity.Property(e => e.XlhArticleId).HasColumnName("XLH_ArticleId");
            entity.Property(e => e.XlhArticleName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLH_ArticleName");
            entity.Property(e => e.XlhCorrectionDocumentAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLH_CorrectionDocumentAmount");
            entity.Property(e => e.XlhDcdid).HasColumnName("XLH_DCDID");
            entity.Property(e => e.XlhDdsid).HasColumnName("XLH_DDSID");
            entity.Property(e => e.XlhIsBaseUnit).HasColumnName("XLH_IsBaseUnit");
            entity.Property(e => e.XlhModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("XLH_ModificationDate");
            entity.Property(e => e.XlhPosition).HasColumnName("XLH_Position");
            entity.Property(e => e.XlhPrice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("XLH_Price");
            entity.Property(e => e.XlhQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("XLH_Quantity");
            entity.Property(e => e.XlhTaxRateId).HasColumnName("XLH_TaxRateId");
            entity.Property(e => e.XlhUnitName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("XLH_UnitName");
            entity.Property(e => e.XlhXlaid).HasColumnName("XLH_XLAID");
            entity.Property(e => e.XlhXldid).HasColumnName("XLH_XLDId");
        });

        modelBuilder.Entity<DfWorkErpXldocument>(entity =>
        {
            entity.HasKey(e => e.XldId).HasName("PK__DF_WorkE__6792E896C763E68C");

            entity.ToTable("DF_WorkErpXLDocument", "do", tb => tb.HasTrigger("DF_WorkErpXLDocumentCopyHistory"));

            entity.Property(e => e.XldId).HasColumnName("XLD_Id");
            entity.Property(e => e.XldAccountingNoteSeriesId).HasColumnName("XLD_AccountingNoteSeriesId");
            entity.Property(e => e.XldAccountingNoteSeriesName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLD_AccountingNoteSeriesName");
            entity.Property(e => e.XldAccrualNoteDocTypeId).HasColumnName("XLD_AccrualNoteDocTypeId");
            entity.Property(e => e.XldAccrualNoteDocTypeName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLD_AccrualNoteDocTypeName");
            entity.Property(e => e.XldAccrualNoteDocTypeType).HasColumnName("XLD_AccrualNoteDocTypeType");
            entity.Property(e => e.XldBankAccountId).HasColumnName("XLD_BankAccountId");
            entity.Property(e => e.XldBankAccountNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLD_BankAccountNumber");
            entity.Property(e => e.XldBlockVatTableChanges).HasColumnName("XLD_BlockVatTableChanges");
            entity.Property(e => e.XldCompanyId).HasColumnName("XLD_CompanyId");
            entity.Property(e => e.XldCurrency)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("XLD_Currency");
            entity.Property(e => e.XldCustomerAcronym)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLD_CustomerAcronym");
            entity.Property(e => e.XldCustomerId).HasColumnName("XLD_CustomerId");
            entity.Property(e => e.XldCustomerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLD_CustomerName");
            entity.Property(e => e.XldDcdid).HasColumnName("XLD_DCDID");
            entity.Property(e => e.XldDdsid).HasColumnName("XLD_DDSID");
            entity.Property(e => e.XldDocumentId).HasColumnName("XLD_DocumentId");
            entity.Property(e => e.XldDocumentTypeId).HasColumnName("XLD_DocumentTypeId");
            entity.Property(e => e.XldErpDocumentNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLD_ErpDocumentNumber");
            entity.Property(e => e.XldGrossAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLD_GrossAmount");
            entity.Property(e => e.XldMappingDisabled).HasColumnName("XLD_MappingDisabled");
            entity.Property(e => e.XldModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("XLD_ModificationDate");
            entity.Property(e => e.XldNetAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLD_NetAmount");
            entity.Property(e => e.XldPayerAddressId).HasColumnName("XLD_PayerAddressId");
            entity.Property(e => e.XldPayerAddressName)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("XLD_PayerAddressName");
            entity.Property(e => e.XldPayerId).HasColumnName("XLD_PayerId");
            entity.Property(e => e.XldPayerIsCentral).HasColumnName("XLD_PayerIsCentral");
            entity.Property(e => e.XldPayerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLD_PayerName");
            entity.Property(e => e.XldPayerType).HasColumnName("XLD_PayerType");
            entity.Property(e => e.XldPricePrecision2Digits).HasColumnName("XLD_PricePrecision2Digits");
            entity.Property(e => e.XldPriceType).HasColumnName("XLD_PriceType");
            entity.Property(e => e.XldPucharseTypeId).HasColumnName("XLD_PucharseTypeId");
            entity.Property(e => e.XldPucharseTypeName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLD_PucharseTypeName");
            entity.Property(e => e.XldSeriesId).HasColumnName("XLD_SeriesId");
            entity.Property(e => e.XldSeriesName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLD_SeriesName");
            entity.Property(e => e.XldSourceWarehouseId).HasColumnName("XLD_SourceWarehouseId");
            entity.Property(e => e.XldSourceWarehouseName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLD_SourceWarehouseName");
            entity.Property(e => e.XldSplitPayment).HasColumnName("XLD_SplitPayment");
            entity.Property(e => e.XldTaxRateId).HasColumnName("XLD_TaxRateId");
            entity.Property(e => e.XldTotalExpenditure)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLD_TotalExpenditure");
            entity.Property(e => e.XldTotalIncome)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLD_TotalIncome");
            entity.Property(e => e.XldVatDeduction).HasColumnName("XLD_VatDeduction");
            entity.Property(e => e.XldVatRegisterId).HasColumnName("XLD_VatRegisterId");
            entity.Property(e => e.XldVatRegisterName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLD_VatRegisterName");
            entity.Property(e => e.XldVatRegisterTypeOfPatternIsRequired).HasColumnName("XLD_VatRegisterTypeOfPatternIsRequired");
            entity.Property(e => e.XldWarehouseId).HasColumnName("XLD_WarehouseId");
            entity.Property(e => e.XldWarehouseName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLD_WarehouseName");
            entity.Property(e => e.XldXldid).HasColumnName("XLD_XLDID");
        });

        modelBuilder.Entity<DfWorkErpXldocumentHistory>(entity =>
        {
            entity.HasKey(e => e.XlhId)
                .HasName("PK__DF_WorkH")
                .HasFillFactor(80);

            entity.ToTable("DF_WorkErpXLDocumentHistory", "do");

            entity.Property(e => e.XlhId).HasColumnName("XLH_Id");
            entity.Property(e => e.XlhAccountingNoteSeriesId).HasColumnName("XLH_AccountingNoteSeriesId");
            entity.Property(e => e.XlhAccountingNoteSeriesName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLH_AccountingNoteSeriesName");
            entity.Property(e => e.XlhAccrualNoteDocTypeId).HasColumnName("XLH_AccrualNoteDocTypeId");
            entity.Property(e => e.XlhAccrualNoteDocTypeName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLH_AccrualNoteDocTypeName");
            entity.Property(e => e.XlhAccrualNoteDocTypeType).HasColumnName("XLH_AccrualNoteDocTypeType");
            entity.Property(e => e.XlhCompanyId).HasColumnName("XLH_CompanyId");
            entity.Property(e => e.XlhCurrency)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("XLH_Currency");
            entity.Property(e => e.XlhCustomerAcronym)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLH_CustomerAcronym");
            entity.Property(e => e.XlhCustomerId).HasColumnName("XLH_CustomerId");
            entity.Property(e => e.XlhCustomerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLH_CustomerName");
            entity.Property(e => e.XlhDcdid).HasColumnName("XLH_DCDID");
            entity.Property(e => e.XlhDdsid).HasColumnName("XLH_DDSID");
            entity.Property(e => e.XlhDocumentId).HasColumnName("XLH_DocumentId");
            entity.Property(e => e.XlhDocumentTypeId).HasColumnName("XLH_DocumentTypeId");
            entity.Property(e => e.XlhGrossAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLH_GrossAmount");
            entity.Property(e => e.XlhMappingDisabled).HasColumnName("XLH_MappingDisabled");
            entity.Property(e => e.XlhModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("XLH_ModificationDate");
            entity.Property(e => e.XlhNetAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLH_NetAmount");
            entity.Property(e => e.XlhPayerId).HasColumnName("XLH_PayerId");
            entity.Property(e => e.XlhPayerIsCentral).HasColumnName("XLH_PayerIsCentral");
            entity.Property(e => e.XlhPayerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLH_PayerName");
            entity.Property(e => e.XlhPayerType).HasColumnName("XLH_PayerType");
            entity.Property(e => e.XlhPricePrecision2Digits).HasColumnName("XLH_PricePrecision2Digits");
            entity.Property(e => e.XlhPriceType).HasColumnName("XLH_PriceType");
            entity.Property(e => e.XlhPucharseTypeId).HasColumnName("XLH_PucharseTypeId");
            entity.Property(e => e.XlhPucharseTypeName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLH_PucharseTypeName");
            entity.Property(e => e.XlhSeriesId).HasColumnName("XLH_SeriesId");
            entity.Property(e => e.XlhSeriesName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLH_SeriesName");
            entity.Property(e => e.XlhTaxRateId).HasColumnName("XLH_TaxRateId");
            entity.Property(e => e.XlhTotalExpenditure)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLH_TotalExpenditure");
            entity.Property(e => e.XlhTotalIncome)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XLH_TotalIncome");
            entity.Property(e => e.XlhVatDeduction).HasColumnName("XLH_VatDeduction");
            entity.Property(e => e.XlhVatRegisterId).HasColumnName("XLH_VatRegisterId");
            entity.Property(e => e.XlhVatRegisterName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("XLH_VatRegisterName");
            entity.Property(e => e.XlhVatRegisterTypeOfPatternIsRequired).HasColumnName("XLH_VatRegisterTypeOfPatternIsRequired");
            entity.Property(e => e.XlhXldid).HasColumnName("XLH_XLDId");
        });

        modelBuilder.Entity<DfWorkLogEntry>(entity =>
        {
            entity.HasKey(e => e.LeId).HasName("PK__DF_WorkL__55311402E4E8D614");

            entity.ToTable("DF_WorkLogEntries", "do");

            entity.Property(e => e.LeId).HasColumnName("LE_Id");
            entity.Property(e => e.LeDocumentId).HasColumnName("LE_DocumentId");
            entity.Property(e => e.LeLevel)
                .HasMaxLength(10)
                .HasColumnName("LE_Level");
            entity.Property(e => e.LeLogger)
                .HasMaxLength(128)
                .HasColumnName("LE_Logger");
            entity.Property(e => e.LeMessage).HasColumnName("LE_Message");
            entity.Property(e => e.LeTimeStamp).HasColumnName("LE_TimeStamp");
            entity.Property(e => e.LeType)
                .HasDefaultValue((byte)1)
                .HasColumnName("LE_Type");
        });

        modelBuilder.Entity<DfWorkOsclosedDoc>(entity =>
        {
            entity.HasKey(e => new { e.WocDcdid, e.WocDwdid, e.WocPermissionSource });

            entity.ToTable("DF_WorkOSClosedDoc", "do");

            entity.HasIndex(e => e.WocIsActive, "I_DF_WorkOSClosedDoc_IsActive");

            entity.Property(e => e.WocDcdid).HasColumnName("WOC_DCDID");
            entity.Property(e => e.WocDwdid).HasColumnName("WOC_DWDID");
            entity.Property(e => e.WocPermissionSource).HasColumnName("WOC_PermissionSource");
            entity.Property(e => e.WocIsActive).HasColumnName("WOC_IsActive");

            entity.HasOne(d => d.WocDcd).WithMany(p => p.DfWorkOsclosedDocs)
                .HasForeignKey(d => d.WocDcdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkOSClosedDoc_DF_ConfOSDictionary");

            entity.HasOne(d => d.WocDwd).WithMany(p => p.DfWorkOsclosedDocs)
                .HasForeignKey(d => d.WocDwdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkOSClosedDoc_DF_Work");
        });

        modelBuilder.Entity<DfWorkOsnotification>(entity =>
        {
            entity.HasKey(e => e.NtfId);

            entity.ToTable("DF_WorkOSNotifications", "do");

            entity.HasIndex(e => e.NtfDcdid, "I_DF_WorkOSNotifications_DCD");

            entity.HasIndex(e => e.NtfDwdid, "I_DF_WorkOSNotifications_DWD");

            entity.HasIndex(e => e.NtfDwsid, "I_DF_WorkOSNotifications_DWS");

            entity.Property(e => e.NtfId).HasColumnName("NTF_ID");
            entity.Property(e => e.NtfDateOpening)
                .HasColumnType("datetime")
                .HasColumnName("NTF_DateOpening");
            entity.Property(e => e.NtfDcdid).HasColumnName("NTF_DCDId");
            entity.Property(e => e.NtfDwdid).HasColumnName("NTF_DWDId");
            entity.Property(e => e.NtfDwsid).HasColumnName("NTF_DWSId");
        });

        modelBuilder.Entity<DfWorkOsworkDoc>(entity =>
        {
            entity.HasKey(e => new { e.WooDcdid, e.WooDwdid, e.WooPermissionSource });

            entity.ToTable("DF_WorkOSWorkDoc", "do");

            entity.HasIndex(e => e.WooIsActive, "I_DF_WorkOSWorkDoc_IsActive");

            entity.Property(e => e.WooDcdid).HasColumnName("WOO_DCDID");
            entity.Property(e => e.WooDwdid).HasColumnName("WOO_DWDID");
            entity.Property(e => e.WooPermissionSource).HasColumnName("WOO_PermissionSource");
            entity.Property(e => e.WooIsActive).HasColumnName("WOO_IsActive");

            entity.HasOne(d => d.WooDcd).WithMany(p => p.DfWorkOsworkDocs)
                .HasForeignKey(d => d.WooDcdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkOSWorkDoc_DF_ConfOSDictionary");

            entity.HasOne(d => d.WooDwd).WithMany(p => p.DfWorkOsworkDocs)
                .HasForeignKey(d => d.WooDwdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DF_WorkOSWorkDoc_DF_Work");
        });

        modelBuilder.Entity<DfWorkUserLoginHistory>(entity =>
        {
            entity.HasKey(e => new { e.UlhLoginDate, e.UlhDcdid }).HasName("PK__DF_WorkU__45A478E85FEA63F5");

            entity.ToTable("DF_WorkUserLoginHistory", "do");

            entity.Property(e => e.UlhLoginDate)
                .HasColumnType("datetime")
                .HasColumnName("ULH_LoginDate");
            entity.Property(e => e.UlhDcdid).HasColumnName("ULH_DCDID");
            entity.Property(e => e.UlhCmduserCompanyId).HasColumnName("ULH_CMDUserCompanyId");
            entity.Property(e => e.UlhUserLogin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ULH_UserLogin");
        });

        modelBuilder.Entity<DmAccess>(entity =>
        {
            entity.HasKey(e => e.DraId);

            entity.ToTable("DM_Access", "do");

            entity.Property(e => e.DraId).HasColumnName("DRA_Id");
            entity.Property(e => e.DraCatAdministrator).HasColumnName("DRA_CatAdministrator");
            entity.Property(e => e.DraCatArchive).HasColumnName("DRA_CatArchive");
            entity.Property(e => e.DraCatEdit).HasColumnName("DRA_CatEdit");
            entity.Property(e => e.DraDcdid).HasColumnName("DRA_DCDId");
            entity.Property(e => e.DraDokArchive).HasColumnName("DRA_DokArchive");
            entity.Property(e => e.DraDokEdit).HasColumnName("DRA_DokEdit");
            entity.Property(e => e.DraDokView).HasColumnName("DRA_DokView");
            entity.Property(e => e.DraDrtid).HasColumnName("DRA_DRTId");
            entity.Property(e => e.DraIsArchival).HasColumnName("DRA_IsArchival");

            entity.HasOne(d => d.DraDrt).WithMany(p => p.DmAccesses)
                .HasForeignKey(d => d.DraDrtid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_Access_DM_HeadTree");
        });

        modelBuilder.Entity<DmDocumentsBin>(entity =>
        {
            entity.HasKey(e => e.DrbId);

            entity.ToTable("DM_DocumentsBin", "do");

            entity.Property(e => e.DrbId)
                .ValueGeneratedNever()
                .HasColumnName("DRB_Id");
            entity.Property(e => e.DrbBin).HasColumnName("DRB_BIN");
            entity.Property(e => e.DrbCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("DRB_CreationDate");
            entity.Property(e => e.DrbDcdcreation).HasColumnName("DRB_DCDCreation");
            entity.Property(e => e.DrbDrtid).HasColumnName("DRB_DRTId");
            entity.Property(e => e.DrbExtension)
                .HasMaxLength(50)
                .HasColumnName("DRB_Extension");
            entity.Property(e => e.DrbIbardFileId).HasColumnName("DRB_IbardFileId");
            entity.Property(e => e.DrbName)
                .HasMaxLength(255)
                .HasColumnName("DRB_Name");
            entity.Property(e => e.DrbSize).HasColumnName("DRB_Size");
            entity.Property(e => e.DrbVersion).HasColumnName("DRB_Version");

            entity.HasOne(d => d.DrbDrt).WithMany(p => p.DmDocumentsBins)
                .HasForeignKey(d => d.DrbDrtid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_DocumentsBin_DM_HeadTree");
        });

        modelBuilder.Entity<DmHeadTree>(entity =>
        {
            entity.HasKey(e => e.DrtId);

            entity.ToTable("DM_HeadTree", "do");

            entity.Property(e => e.DrtId).HasColumnName("DRT_ID");
            entity.Property(e => e.DrtArchival).HasColumnName("DRT_Archival");
            entity.Property(e => e.DrtArchiveAfterTime).HasColumnName("DRT_ArchiveAfterTime");
            entity.Property(e => e.DrtArchived).HasColumnName("DRT_Archived");
            entity.Property(e => e.DrtCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("DRT_CreationDate");
            entity.Property(e => e.DrtDcdcreator).HasColumnName("DRT_DCDCreator");
            entity.Property(e => e.DrtDcdmodifiedById).HasColumnName("DRT_DCDModifiedById");
            entity.Property(e => e.DrtDrtid).HasColumnName("DRT_DRTId");
            entity.Property(e => e.DrtModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("DRT_ModificationDate");
            entity.Property(e => e.DrtName)
                .HasMaxLength(255)
                .HasColumnName("DRT_Name");
            entity.Property(e => e.DrtPosition).HasColumnName("DRT_Position");
            entity.Property(e => e.DrtType).HasColumnName("DRT_Type");
            entity.Property(e => e.DrtVersioning).HasColumnName("DRT_Versioning");
        });

        modelBuilder.Entity<EdError>(entity =>
        {
            entity.HasKey(e => e.EdrId);

            entity.ToTable("ED_Errors", "do");

            entity.Property(e => e.EdrId).HasColumnName("EDR_Id");
            entity.Property(e => e.EdrApdid).HasColumnName("EDR_APDId");
            entity.Property(e => e.EdrCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("EDR_CreateDate");
            entity.Property(e => e.EdrMessage).HasColumnName("EDR_Message");
            entity.Property(e => e.EdrOperatorId).HasColumnName("EDR_OperatorId");
        });

        modelBuilder.Entity<EdMessage>(entity =>
        {
            entity.HasKey(e => e.EdmId);

            entity.ToTable("ED_Messages", "do");

            entity.Property(e => e.EdmId).HasColumnName("EDM_Id");
            entity.Property(e => e.EdmDeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("EDM_DeliveryDate");
            entity.Property(e => e.EdmEvidencesFile).HasColumnName("EDM_EvidencesFile");
            entity.Property(e => e.EdmMessageId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EDM_MessageId");
            entity.Property(e => e.EdmSenderName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("EDM_SenderName");
            entity.Property(e => e.EdmSubject)
                .HasMaxLength(500)
                .HasColumnName("EDM_Subject");
            entity.Property(e => e.EdmTextBody)
                .HasColumnType("text")
                .HasColumnName("EDM_TextBody");
        });

        modelBuilder.Entity<EdMessageAttachment>(entity =>
        {
            entity.HasKey(e => e.EdaId);

            entity.ToTable("ED_MessageAttachments", "do");

            entity.Property(e => e.EdaId).HasColumnName("EDA_Id");
            entity.Property(e => e.EdaAngleOfRotation)
                .HasDefaultValue(0)
                .HasColumnName("EDA_AngleOfRotation");
            entity.Property(e => e.EdaArchival).HasColumnName("EDA_Archival");
            entity.Property(e => e.EdaAttachmentId).HasColumnName("EDA_AttachmentId");
            entity.Property(e => e.EdaContent)
                .HasColumnType("image")
                .HasColumnName("EDA_Content");
            entity.Property(e => e.EdaContentType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EDA_ContentType");
            entity.Property(e => e.EdaEdmid).HasColumnName("EDA_EDMId");
            entity.Property(e => e.EdaFileName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EDA_FileName");
            entity.Property(e => e.EdaPosition).HasColumnName("EDA_Position");
            entity.Property(e => e.EdaSize).HasColumnName("EDA_Size");

            entity.HasOne(d => d.EdaEdm).WithMany(p => p.EdMessageAttachments)
                .HasForeignKey(d => d.EdaEdmid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ED_MessageAttachments_ED_Messages");
        });

        modelBuilder.Entity<EdWorkApprocess>(entity =>
        {
            entity.HasKey(e => e.EdwId);

            entity.ToTable("ED_WorkAPProcess", "do");

            entity.Property(e => e.EdwId).HasColumnName("EDW_Id");
            entity.Property(e => e.EdwApdid).HasColumnName("EDW_APDId");
            entity.Property(e => e.EdwArchival).HasColumnName("EDW_Archival");
            entity.Property(e => e.EdwCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("EDW_CreateDate");
            entity.Property(e => e.EdwEdmid).HasColumnName("EDW_EDMId");
            entity.Property(e => e.EdwOperatorId).HasColumnName("EDW_OperatorId");
            entity.Property(e => e.EdwStatus).HasColumnName("EDW_Status");
        });

        modelBuilder.Entity<GetGuid>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetGuid", "do");

            entity.Property(e => e.Guid).HasColumnName("guid");
        });

        modelBuilder.Entity<KsAdditionalDescription>(entity =>
        {
            entity.HasKey(e => e.KsoId);

            entity.ToTable("KS_AdditionalDescriptions", "do");

            entity.Property(e => e.KsoId).HasColumnName("KSO_Id");
            entity.Property(e => e.KsoDocumentId).HasColumnName("KSO_DocumentId");
            entity.Property(e => e.KsoDodatkowyOpisKlucz)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSO_DodatkowyOpisKlucz");
            entity.Property(e => e.KsoDodatkowyOpisNrWiersza)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("KSO_DodatkowyOpisNrWiersza");
            entity.Property(e => e.KsoDodatkowyOpisWartosc)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSO_DodatkowyOpisWartosc");

            entity.HasOne(d => d.KsoDocument).WithMany(p => p.KsAdditionalDescriptions)
                .HasForeignKey(d => d.KsoDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_AdditionalDescriptions_KS_Documents");
        });

        modelBuilder.Entity<KsAsidocument>(entity =>
        {
            entity.HasKey(e => e.KsaId);

            entity.ToTable("KS_ASIDocuments", "do");

            entity.Property(e => e.KsaId).HasColumnName("KSA_Id");
            entity.Property(e => e.KsaDocumentId).HasColumnName("KSA_DocumentId");
            entity.Property(e => e.KsaFakturaZaliczkowaNumer)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSA_FakturaZaliczkowaNumer");
            entity.Property(e => e.KsaFakturaZaliczkowaNumerKseF)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("KSA_FakturaZaliczkowaNumerKSeF");

            entity.HasOne(d => d.KsaDocument).WithMany(p => p.KsAsidocuments)
                .HasForeignKey(d => d.KsaDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_ASIDocuments_KS_Documents");
        });

        modelBuilder.Entity<KsBankAccount>(entity =>
        {
            entity.HasKey(e => e.KsbId);

            entity.ToTable("KS_BankAccounts", "do");

            entity.Property(e => e.KsbId).HasColumnName("KSB_Id");
            entity.Property(e => e.KsbDocumentId).HasColumnName("KSB_DocumentId");
            entity.Property(e => e.KsbNazwaBanku)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSB_NazwaBanku");
            entity.Property(e => e.KsbNrRachunku)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KSB_NrRachunku");
            entity.Property(e => e.KsbNrRachunkuSwift)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("KSB_NrRachunkuSWIFT");
            entity.Property(e => e.KsbOpisRachunku)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSB_OpisRachunku");
            entity.Property(e => e.KsbRachunekWlasnyBanku).HasColumnName("KSB_RachunekWlasnyBanku");

            entity.HasOne(d => d.KsbDocument).WithMany(p => p.KsBankAccounts)
                .HasForeignKey(d => d.KsbDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_BankAccounts_KS_Documents");
        });

        modelBuilder.Entity<KsDeductionSettlement>(entity =>
        {
            entity.HasKey(e => e.KsuId);

            entity.ToTable("KS_DeductionSettlements", "do");

            entity.Property(e => e.KsuId).HasColumnName("KSU_Id");
            entity.Property(e => e.KsuDocumentId).HasColumnName("KSU_DocumentId");
            entity.Property(e => e.KsuRozliczenieOdliczeniaKwota)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSU_RozliczenieOdliczeniaKwota");
            entity.Property(e => e.KsuRozliczenieOdliczeniaPowod)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSU_RozliczenieOdliczeniaPowod");

            entity.HasOne(d => d.KsuDocument).WithMany(p => p.KsDeductionSettlements)
                .HasForeignKey(d => d.KsuDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_DeductionSettlements_KS_Documents");
        });

        modelBuilder.Entity<KsDocument>(entity =>
        {
            entity.HasKey(e => e.KsdId);

            entity.ToTable("KS_Documents", "do");

            entity.Property(e => e.KsdId).HasColumnName("KSD_Id");
            entity.Property(e => e.KsdDataDostawy)
                .HasColumnType("datetime")
                .HasColumnName("KSD_DataDostawy");
            entity.Property(e => e.KsdDataSprzedazyDo)
                .HasColumnType("datetime")
                .HasColumnName("KSD_DataSprzedazyDo");
            entity.Property(e => e.KsdDataSprzedazyOd)
                .HasColumnType("datetime")
                .HasColumnName("KSD_DataSprzedazyOd");
            entity.Property(e => e.KsdDataWystFaKorygowanej)
                .HasColumnType("datetime")
                .HasColumnName("KSD_DataWystFaKorygowanej");
            entity.Property(e => e.KsdDataWystawienia)
                .HasColumnType("datetime")
                .HasColumnName("KSD_DataWystawienia");
            entity.Property(e => e.KsdDataZaplatyCzesciowej)
                .HasColumnType("datetime")
                .HasColumnName("KSD_DataZaplatyCzesciowej");
            entity.Property(e => e.KsdFaKorygowanaKwotaZaplatyPrzedKorekta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_FaKorygowanaKwotaZaplatyPrzedKorekta");
            entity.Property(e => e.KsdFakturaDoParagonu).HasColumnName("KSD_FakturaDoParagonu");
            entity.Property(e => e.KsdFakturaPowiazanyNabywca).HasColumnName("KSD_FakturaPowiazanyNabywca");
            entity.Property(e => e.KsdFakturaProceduraUproszczona).HasColumnName("KSD_FakturaProceduraUproszczona");
            entity.Property(e => e.KsdFakturaVatmarza).HasColumnName("KSD_FakturaVATMarza");
            entity.Property(e => e.KsdFormaPlatnosci).HasColumnName("KSD_FormaPlatnosci");
            entity.Property(e => e.KsdHtml)
                .HasColumnType("text")
                .HasColumnName("KSD_Html");
            entity.Property(e => e.KsdKodWaluty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSD_KodWaluty");
            entity.Property(e => e.KsdKorDanychPodatnikAdres)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSD_KorDanychPodatnikAdres");
            entity.Property(e => e.KsdKorDanychPodatnikGln)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSD_KorDanychPodatnikGLN");
            entity.Property(e => e.KsdKorDanychPodatnikKodKraju)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSD_KorDanychPodatnikKodKraju");
            entity.Property(e => e.KsdKorDanychPodatnikNazwa)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSD_KorDanychPodatnikNazwa");
            entity.Property(e => e.KsdKorDanychPodatnikNip)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSD_KorDanychPodatnikNIP");
            entity.Property(e => e.KsdKorDanychPodatnikPrefiksNip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSD_KorDanychPodatnikPrefiksNIP");
            entity.Property(e => e.KsdKursWalutyZ)
                .HasColumnType("decimal(22, 6)")
                .HasColumnName("KSD_KursWalutyZ");
            entity.Property(e => e.KsdKursWalutyZk)
                .HasColumnType("decimal(22, 6)")
                .HasColumnName("KSD_KursWalutyZK");
            entity.Property(e => e.KsdKwotaZaplatyCzesciowej)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_KwotaZaplatyCzesciowej");
            entity.Property(e => e.KsdMarzaBiuraPodrozy).HasColumnName("KSD_MarzaBiuraPodrozy");
            entity.Property(e => e.KsdMarzaDzielaSztuki).HasColumnName("KSD_MarzaDzielaSztuki");
            entity.Property(e => e.KsdMarzaKolekcjonerskieAntyki).HasColumnName("KSD_MarzaKolekcjonerskieAntyki");
            entity.Property(e => e.KsdMarzaTowaryUzywane).HasColumnName("KSD_MarzaTowaryUzywane");
            entity.Property(e => e.KsdMetodaKasowa).HasColumnName("KSD_MetodaKasowa");
            entity.Property(e => e.KsdMiejsceWystawienia)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_MiejsceWystawienia");
            entity.Property(e => e.KsdNrFaKorygowanej)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_NrFaKorygowanej");
            entity.Property(e => e.KsdNrFaKorygowany)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_NrFaKorygowany");
            entity.Property(e => e.KsdNrKseFfaKorygowanej)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("KSD_NrKSeFFaKorygowanej");
            entity.Property(e => e.KsdNstwdt).HasColumnName("KSD_NSTWDT");
            entity.Property(e => e.KsdNumerFaktury)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_NumerFaktury");
            entity.Property(e => e.KsdOdwrotneObciazenie).HasColumnName("KSD_OdwrotneObciazenie");
            entity.Property(e => e.KsdOkresFaKorygowanej)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_OkresFaKorygowanej");
            entity.Property(e => e.KsdOpisPlatnosci)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_OpisPlatnosci");
            entity.Property(e => e.KsdPlDataZaplaty)
                .HasColumnType("datetime")
                .HasColumnName("KSD_PlDataZaplaty");
            entity.Property(e => e.KsdPlZaplacono).HasColumnName("KSD_PlZaplacono");
            entity.Property(e => e.KsdPlZaplataCzesciowa).HasColumnName("KSD_PlZaplataCzesciowa");
            entity.Property(e => e.KsdPlatnoscInna).HasColumnName("KSD_PlatnoscInna");
            entity.Property(e => e.KsdPodzielonaPlatnosc).HasColumnName("KSD_PodzielonaPlatnosc");
            entity.Property(e => e.KsdPrzyczynaKorekty)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_PrzyczynaKorekty");
            entity.Property(e => e.KsdRodzajFaktury)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_RodzajFaktury");
            entity.Property(e => e.KsdRozliczenieDoRozliczenia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_RozliczenieDoRozliczenia");
            entity.Property(e => e.KsdRozliczenieDoZaplaty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_RozliczenieDoZaplaty");
            entity.Property(e => e.KsdRozliczenieObciazeniaSuma)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_RozliczenieObciazeniaSuma");
            entity.Property(e => e.KsdRozliczenieOdliczeniaSuma)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_RozliczenieOdliczeniaSuma");
            entity.Property(e => e.KsdSamofakturowanie).HasColumnName("KSD_Samofakturowanie");
            entity.Property(e => e.KsdSourceContent)
                .HasColumnType("image")
                .HasColumnName("KSD_SourceContent");
            entity.Property(e => e.KsdSprzedazZwdyrektywa)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_SprzedazZWDyrektywa");
            entity.Property(e => e.KsdSprzedazZwolniona).HasColumnName("KSD_SprzedazZwolniona");
            entity.Property(e => e.KsdSprzedazZwpodstawa)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_SprzedazZWPodstawa");
            entity.Property(e => e.KsdSprzedazZwustawa)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_SprzedazZWUstawa");
            entity.Property(e => e.KsdSumaBrutto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaBrutto");
            entity.Property(e => e.KsdSumaNetto0Export)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNetto0_Export");
            entity.Property(e => e.KsdSumaNetto0NoWdtNoExport)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNetto0_NoWDT_NoExport");
            entity.Property(e => e.KsdSumaNetto0Wdt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNetto0_WDT");
            entity.Property(e => e.KsdSumaNettoInna)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNettoInna");
            entity.Property(e => e.KsdSumaNettoMarza)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNettoMarza");
            entity.Property(e => e.KsdSumaNettoOokraj)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNettoOOKraj");
            entity.Property(e => e.KsdSumaNettoRs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNettoRS");
            entity.Property(e => e.KsdSumaNettoStawkaObnizona)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNettoStawkaObnizona");
            entity.Property(e => e.KsdSumaNettoStawkaObnizonaDruga)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNettoStawkaObnizonaDruga");
            entity.Property(e => e.KsdSumaNettoStawkaObnizonaTrzecia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNettoStawkaObnizonaTrzecia");
            entity.Property(e => e.KsdSumaNettoStawkaPodstawowa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNettoStawkaPodstawowa");
            entity.Property(e => e.KsdSumaNettoStawkiExportowe)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNettoStawkiExportowe");
            entity.Property(e => e.KsdSumaNettoZw)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaNettoZW");
            entity.Property(e => e.KsdSumaVatoss)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaVATOSS");
            entity.Property(e => e.KsdSumaVatstawkaObnizona)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaVATStawkaObnizona");
            entity.Property(e => e.KsdSumaVatstawkaObnizonaDruga)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaVATStawkaObnizonaDruga");
            entity.Property(e => e.KsdSumaVatstawkaObnizonaDrugaPln)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaVATStawkaObnizonaDrugaPLN");
            entity.Property(e => e.KsdSumaVatstawkaObnizonaPln)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaVATStawkaObnizonaPLN");
            entity.Property(e => e.KsdSumaVatstawkaObnizonaTrzecia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaVATStawkaObnizonaTrzecia");
            entity.Property(e => e.KsdSumaVatstawkaObnizonaTrzeciaPln)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaVATStawkaObnizonaTrzeciaPLN");
            entity.Property(e => e.KsdSumaVatstawkaPodstawowa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaVATStawkaPodstawowa");
            entity.Property(e => e.KsdSumaVatstawkaPodstawowaPln)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_SumaVATStawkaPodstawowaPLN");
            entity.Property(e => e.KsdTag1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("KSD_Tag1");
            entity.Property(e => e.KsdTag2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("KSD_Tag2");
            entity.Property(e => e.KsdTag3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("KSD_Tag3");
            entity.Property(e => e.KsdTypKorekty).HasColumnName("KSD_TypKorekty");
            entity.Property(e => e.KsdWarunkiSkonta)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_WarunkiSkonta");
            entity.Property(e => e.KsdWarunkiTransakcjiKursUmowny)
                .HasColumnType("decimal(22, 6)")
                .HasColumnName("KSD_WarunkiTransakcjiKursUmowny");
            entity.Property(e => e.KsdWarunkiTransakcjiPodmiotPosredniczacy).HasColumnName("KSD_WarunkiTransakcjiPodmiotPosredniczacy");
            entity.Property(e => e.KsdWarunkiTransakcjiWalutaUmowna)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSD_WarunkiTransakcjiWalutaUmowna");
            entity.Property(e => e.KsdWarunkiTransakcjiWarunkiDostawy)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_WarunkiTransakcjiWarunkiDostawy");
            entity.Property(e => e.KsdWysokoscSkonta)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSD_WysokoscSkonta");
            entity.Property(e => e.KsdXml)
                .HasColumnType("text")
                .HasColumnName("KSD_Xml");
            entity.Property(e => e.KsdZamWartoscBrutto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSD_ZamWartoscBrutto");
            entity.Property(e => e.KsdZnacznikNstwdt).HasColumnName("KSD_ZnacznikNSTWDT");
            entity.Property(e => e.KsdZwrotAkcyzy).HasColumnName("KSD_ZwrotAkcyzy");
        });

        modelBuilder.Entity<KsDocumentAgreement>(entity =>
        {
            entity.HasKey(e => e.KsgId);

            entity.ToTable("KS_DocumentAgreements", "do");

            entity.Property(e => e.KsgId).HasColumnName("KSG_Id");
            entity.Property(e => e.KsgDocumentId).HasColumnName("KSG_DocumentId");
            entity.Property(e => e.KsgWarunkiTransakcjiDataUmowy)
                .HasColumnType("datetime")
                .HasColumnName("KSG_WarunkiTransakcjiDataUmowy");
            entity.Property(e => e.KsgWarunkiTransakcjiNrUmowy)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSG_WarunkiTransakcjiNrUmowy");

            entity.HasOne(d => d.KsgDocument).WithMany(p => p.KsDocumentAgreements)
                .HasForeignKey(d => d.KsgDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_DocumentAgreements_KS_Documents");
        });

        modelBuilder.Entity<KsDocumentContractor>(entity =>
        {
            entity.HasKey(e => e.KscId);

            entity.ToTable("KS_DocumentContractors", "do");

            entity.Property(e => e.KscId).HasColumnName("KSC_Id");
            entity.Property(e => e.KscDocumentId).HasColumnName("KSC_DocumentId");
            entity.Property(e => e.KscNabywcaAdres)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaAdres");
            entity.Property(e => e.KscNabywcaAdresKorespAdres)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaAdresKorespAdres");
            entity.Property(e => e.KscNabywcaAdresKorespGln)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaAdresKorespGLN");
            entity.Property(e => e.KscNabywcaAdresKorespKodKraju)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaAdresKorespKodKraju");
            entity.Property(e => e.KscNabywcaBrakId).HasColumnName("KSC_NabywcaBrakID");
            entity.Property(e => e.KscNabywcaEmail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaEmail");
            entity.Property(e => e.KscNabywcaEori)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaEORI");
            entity.Property(e => e.KscNabywcaGln)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaGLN");
            entity.Property(e => e.KscNabywcaIdNabywcy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaIdNabywcy");
            entity.Property(e => e.KscNabywcaKodKraju)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaKodKraju");
            entity.Property(e => e.KscNabywcaKodUe)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaKodUE");
            entity.Property(e => e.KscNabywcaNazwa)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaNazwa");
            entity.Property(e => e.KscNabywcaNip)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaNIP");
            entity.Property(e => e.KscNabywcaNrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaNrID");
            entity.Property(e => e.KscNabywcaNrKlienta)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaNrKlienta");
            entity.Property(e => e.KscNabywcaNrVatUe)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaNrVatUE");
            entity.Property(e => e.KscNabywcaTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KSC_NabywcaTel");
            entity.Property(e => e.KscPodatnikAdres)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSC_PodatnikAdres");
            entity.Property(e => e.KscPodatnikAdresKorespAdres)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSC_PodatnikAdresKorespAdres");
            entity.Property(e => e.KscPodatnikAdresKorespGln)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSC_PodatnikAdresKorespGLN");
            entity.Property(e => e.KscPodatnikAdresKorespKodKraju)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSC_PodatnikAdresKorespKodKraju");
            entity.Property(e => e.KscPodatnikEmail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("KSC_PodatnikEmail");
            entity.Property(e => e.KscPodatnikEori)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSC_PodatnikEORI");
            entity.Property(e => e.KscPodatnikGln)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSC_PodatnikGLN");
            entity.Property(e => e.KscPodatnikKodKraju)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSC_PodatnikKodKraju");
            entity.Property(e => e.KscPodatnikNazwa)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSC_PodatnikNazwa");
            entity.Property(e => e.KscPodatnikNip)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSC_PodatnikNIP");
            entity.Property(e => e.KscPodatnikPrefiksNip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSC_PodatnikPrefiksNIP");
            entity.Property(e => e.KscPodatnikStatus).HasColumnName("KSC_PodatnikStatus");
            entity.Property(e => e.KscPodatnikTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KSC_PodatnikTel");
            entity.Property(e => e.KscPodmiot3Adres)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3Adres");
            entity.Property(e => e.KscPodmiot3AdresKorespAdres)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3AdresKorespAdres");
            entity.Property(e => e.KscPodmiot3AdresKorespGln)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3AdresKorespGLN");
            entity.Property(e => e.KscPodmiot3AdresKorespKodKraju)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3AdresKorespKodKraju");
            entity.Property(e => e.KscPodmiot3BrakId).HasColumnName("KSC_Podmiot3BrakID");
            entity.Property(e => e.KscPodmiot3Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3Email");
            entity.Property(e => e.KscPodmiot3Eori)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3EORI");
            entity.Property(e => e.KscPodmiot3Gln)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3GLN");
            entity.Property(e => e.KscPodmiot3IdNabywcy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3IdNabywcy");
            entity.Property(e => e.KscPodmiot3Idwew)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3IDWew");
            entity.Property(e => e.KscPodmiot3KodKraju)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3KodKraju");
            entity.Property(e => e.KscPodmiot3KodUe)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3KodUE");
            entity.Property(e => e.KscPodmiot3Nazwa)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3Nazwa");
            entity.Property(e => e.KscPodmiot3Nip)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3NIP");
            entity.Property(e => e.KscPodmiot3NrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3NrID");
            entity.Property(e => e.KscPodmiot3NrVatUe)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3NrVatUE");
            entity.Property(e => e.KscPodmiot3Numerklienta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3Numerklienta");
            entity.Property(e => e.KscPodmiot3OpisRoli)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3OpisRoli");
            entity.Property(e => e.KscPodmiot3Rola).HasColumnName("KSC_Podmiot3Rola");
            entity.Property(e => e.KscPodmiot3RolaInna).HasColumnName("KSC_Podmiot3RolaInna");
            entity.Property(e => e.KscPodmiot3Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KSC_Podmiot3Tel");
            entity.Property(e => e.KscPodmiot3Udzial)
                .HasColumnType("decimal(9, 6)")
                .HasColumnName("KSC_Podmiot3Udzial");
            entity.Property(e => e.KscPodmiotUpowaznionyAdres)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSC_PodmiotUpowaznionyAdres");
            entity.Property(e => e.KscPodmiotUpowaznionyAdresKorespAdres)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSC_PodmiotUpowaznionyAdresKorespAdres");
            entity.Property(e => e.KscPodmiotUpowaznionyAdresKorespGln)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSC_PodmiotUpowaznionyAdresKorespGLN");
            entity.Property(e => e.KscPodmiotUpowaznionyAdresKorespKodKraju)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSC_PodmiotUpowaznionyAdresKorespKodKraju");
            entity.Property(e => e.KscPodmiotUpowaznionyDaneKontaktoweEmail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("KSC_PodmiotUpowaznionyDaneKontaktoweEmail");
            entity.Property(e => e.KscPodmiotUpowaznionyDaneKontaktoweTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KSC_PodmiotUpowaznionyDaneKontaktoweTel");
            entity.Property(e => e.KscPodmiotUpowaznionyEori)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSC_PodmiotUpowaznionyEORI");
            entity.Property(e => e.KscPodmiotUpowaznionyGln)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSC_PodmiotUpowaznionyGLN");
            entity.Property(e => e.KscPodmiotUpowaznionyKodKraju)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSC_PodmiotUpowaznionyKodKraju");
            entity.Property(e => e.KscPodmiotUpowaznionyNazwa)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSC_PodmiotUpowaznionyNazwa");
            entity.Property(e => e.KscPodmiotUpowaznionyNip)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSC_PodmiotUpowaznionyNIP");
            entity.Property(e => e.KscPodmiotUpowaznionyRola).HasColumnName("KSC_PodmiotUpowaznionyRola");

            entity.HasOne(d => d.KscDocument).WithMany(p => p.KsDocumentContractors)
                .HasForeignKey(d => d.KscDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_DocumentContractors_KS_Documents");
        });

        modelBuilder.Entity<KsDocumentFooter>(entity =>
        {
            entity.HasKey(e => e.KsfId);

            entity.ToTable("KS_DocumentFooters", "do");

            entity.Property(e => e.KsfId).HasColumnName("KSF_Id");
            entity.Property(e => e.KsfDocumentId).HasColumnName("KSF_DocumentId");
            entity.Property(e => e.KsfStopkaBdo)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSF_StopkaBDO");
            entity.Property(e => e.KsfStopkaFaktury)
                .HasMaxLength(3500)
                .IsUnicode(false)
                .HasColumnName("KSF_StopkaFaktury");
            entity.Property(e => e.KsfStopkaKrs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KSF_StopkaKRS");
            entity.Property(e => e.KsfStopkaRegon)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("KSF_StopkaREGON");
            entity.Property(e => e.KsfStopkaRejestrInny)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSF_StopkaRejestrInny");

            entity.HasOne(d => d.KsfDocument).WithMany(p => p.KsDocumentFooters)
                .HasForeignKey(d => d.KsfDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_DocumentFooters_KS_Documents");
        });

        modelBuilder.Entity<KsDocumentHeader>(entity =>
        {
            entity.HasKey(e => e.KshId);

            entity.ToTable("KS_DocumentHeaders", "do");

            entity.Property(e => e.KshId).HasColumnName("KSH_Id");
            entity.Property(e => e.KshDataWytworzeniaFa)
                .HasColumnType("datetime")
                .HasColumnName("KSH_DataWytworzeniaFa");
            entity.Property(e => e.KshDocumentId).HasColumnName("KSH_DocumentId");
            entity.Property(e => e.KshKodSystemowy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("KSH_KodSystemowy");
            entity.Property(e => e.KshNazwaSystemuErp)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSH_NazwaSystemuERP");
            entity.Property(e => e.KshNumerReferencyjnyKseF)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("KSH_NumerReferencyjnyKSeF");
            entity.Property(e => e.KshWariantFormularza).HasColumnName("KSH_WariantFormularza");
            entity.Property(e => e.KshWersjaSchemy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("KSH_WersjaSchemy");

            entity.HasOne(d => d.KshDocument).WithMany(p => p.KsDocumentHeaders)
                .HasForeignKey(d => d.KshDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_DocumentHeaders_KS_Documents");
        });

        modelBuilder.Entity<KsDocumentItem>(entity =>
        {
            entity.HasKey(e => e.KsiId);

            entity.ToTable("KS_DocumentItems", "do");

            entity.Property(e => e.KsiId).HasColumnName("KSI_Id");
            entity.Property(e => e.KsiDocumentId).HasColumnName("KSI_DocumentId");
            entity.Property(e => e.KsiElementCenaBrutto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSI_ElementCenaBrutto");
            entity.Property(e => e.KsiElementCenaNetto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSI_ElementCenaNetto");
            entity.Property(e => e.KsiElementDataDostawy)
                .HasColumnType("datetime")
                .HasColumnName("KSI_ElementDataDostawy");
            entity.Property(e => e.KsiElementEan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KSI_ElementEAN");
            entity.Property(e => e.KsiElementGrupaJpk)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSI_ElementGrupaJPK");
            entity.Property(e => e.KsiElementId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSI_ElementID");
            entity.Property(e => e.KsiElementIlosc)
                .HasColumnType("decimal(22, 6)")
                .HasColumnName("KSI_ElementIlosc");
            entity.Property(e => e.KsiElementJm)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSI_ElementJM");
            entity.Property(e => e.KsiElementKodCn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSI_ElementKodCN");
            entity.Property(e => e.KsiElementKursWaluty)
                .HasColumnType("decimal(22, 6)")
                .HasColumnName("KSI_ElementKursWaluty");
            entity.Property(e => e.KsiElementKwotaAkcyzy)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSI_ElementKwotaAkcyzy");
            entity.Property(e => e.KsiElementKwotaRabatu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSI_ElementKwotaRabatu");
            entity.Property(e => e.KsiElementLp)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("KSI_ElementLp");
            entity.Property(e => e.KsiElementNazwa)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSI_ElementNazwa");
            entity.Property(e => e.KsiElementOpis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSI_ElementOpis");
            entity.Property(e => e.KsiElementPkob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSI_ElementPKOB");
            entity.Property(e => e.KsiElementPkwiU)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSI_ElementPKWiU");
            entity.Property(e => e.KsiElementProcedura).HasColumnName("KSI_ElementProcedura");
            entity.Property(e => e.KsiElementProceduraJpk)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSI_ElementProceduraJPK");
            entity.Property(e => e.KsiElementStawkaVat)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSI_ElementStawkaVAT");
            entity.Property(e => e.KsiElementStawkaVatoss)
                .HasColumnType("decimal(9, 6)")
                .HasColumnName("KSI_ElementStawkaVATOSS");
            entity.Property(e => e.KsiElementWartoscBrutto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSI_ElementWartoscBrutto");
            entity.Property(e => e.KsiElementWartoscNetto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSI_ElementWartoscNetto");
            entity.Property(e => e.KsiElementZal15Oo).HasColumnName("KSI_ElementZal15OO");
            entity.Property(e => e.KsiElementwartoscVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSI_ElementwartoscVat");
            entity.Property(e => e.KsiIndeks)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSI_Indeks");

            entity.HasOne(d => d.KsiDocument).WithMany(p => p.KsDocumentItems)
                .HasForeignKey(d => d.KsiDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_DocumentItems_KS_Documents");
        });

        modelBuilder.Entity<KsDocumentLotNumber>(entity =>
        {
            entity.HasKey(e => e.KstId);

            entity.ToTable("KS_DocumentLotNumbers", "do");

            entity.Property(e => e.KstId).HasColumnName("KST_Id");
            entity.Property(e => e.KstDocumentId).HasColumnName("KST_DocumentId");
            entity.Property(e => e.KstWarunkiTransakcjiNrPartiiTowaru)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KST_WarunkiTransakcjiNrPartiiTowaru");

            entity.HasOne(d => d.KstDocument).WithMany(p => p.KsDocumentLotNumbers)
                .HasForeignKey(d => d.KstDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_DocumentLotNumbers_KS_Documents");
        });

        modelBuilder.Entity<KsDocumentOrder>(entity =>
        {
            entity.HasKey(e => e.KszId);

            entity.ToTable("KS_DocumentOrders", "do");

            entity.Property(e => e.KszId).HasColumnName("KSZ_Id");
            entity.Property(e => e.KszDocumentId).HasColumnName("KSZ_DocumentId");
            entity.Property(e => e.KszWarunkiTransakcjiDataZamowienia)
                .HasColumnType("datetime")
                .HasColumnName("KSZ_WarunkiTransakcjiDataZamowienia");
            entity.Property(e => e.KszWarunkiTransakcjiNrZamowienia)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSZ_WarunkiTransakcjiNrZamowienia");

            entity.HasOne(d => d.KszDocument).WithMany(p => p.KsDocumentOrders)
                .HasForeignKey(d => d.KszDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_DocumentOrders_KS_Documents");
        });

        modelBuilder.Entity<KsDocumentOrderItem>(entity =>
        {
            entity.HasKey(e => e.KsjId);

            entity.ToTable("KS_DocumentOrderItems", "do");

            entity.Property(e => e.KsjId).HasColumnName("KSJ_Id");
            entity.Property(e => e.KsjDocumentId).HasColumnName("KSJ_DocumentId");
            entity.Property(e => e.KsjIndeksZam)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSJ_IndeksZam");
            entity.Property(e => e.KsjZamElementCenaNetto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSJ_ZamElementCenaNetto");
            entity.Property(e => e.KsjZamElementEan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KSJ_ZamElementEAN");
            entity.Property(e => e.KsjZamElementGrupaJpk)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSJ_ZamElementGrupaJPK");
            entity.Property(e => e.KsjZamElementId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSJ_ZamElementID");
            entity.Property(e => e.KsjZamElementIlosc)
                .HasColumnType("decimal(22, 6)")
                .HasColumnName("KSJ_ZamElementIlosc");
            entity.Property(e => e.KsjZamElementJm)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSJ_ZamElementJM");
            entity.Property(e => e.KsjZamElementKodCn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSJ_ZamElementKodCN");
            entity.Property(e => e.KsjZamElementKwotaAkcyzyZ)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSJ_ZamElementKwotaAkcyzyZ");
            entity.Property(e => e.KsjZamElementKwotaVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSJ_ZamElementKwotaVAT");
            entity.Property(e => e.KsjZamElementLp)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("KSJ_ZamElementLp");
            entity.Property(e => e.KsjZamElementNazwa)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSJ_ZamElementNazwa");
            entity.Property(e => e.KsjZamElementPkob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSJ_ZamElementPKOB");
            entity.Property(e => e.KsjZamElementPkwiU)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSJ_ZamElementPKWiU");
            entity.Property(e => e.KsjZamElementProcedura).HasColumnName("KSJ_ZamElementProcedura");
            entity.Property(e => e.KsjZamElementProceduraJpk)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSJ_ZamElementProceduraJPK");
            entity.Property(e => e.KsjZamElementStawkaVat)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSJ_ZamElementStawkaVAT");
            entity.Property(e => e.KsjZamElementStawkaVatoss)
                .HasColumnType("decimal(9, 6)")
                .HasColumnName("KSJ_ZamElementStawkaVATOSS");
            entity.Property(e => e.KsjZamElementWartoscNetto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSJ_ZamElementWartoscNetto");

            entity.HasOne(d => d.KsjDocument).WithMany(p => p.KsDocumentOrderItems)
                .HasForeignKey(d => d.KsjDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_DocumentOrderItems_KS_Documents");
        });

        modelBuilder.Entity<KsError>(entity =>
        {
            entity.HasKey(e => e.KseId);

            entity.ToTable("KS_Errors", "do");

            entity.Property(e => e.KseId).HasColumnName("KSE_Id");
            entity.Property(e => e.KseApdid).HasColumnName("KSE_APDId");
            entity.Property(e => e.KseCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("KSE_CreateDate");
            entity.Property(e => e.KseMessage).HasColumnName("KSE_Message");
            entity.Property(e => e.KseOperatorId).HasColumnName("KSE_OperatorId");
        });

        modelBuilder.Entity<KsFactorBankAccount>(entity =>
        {
            entity.HasKey(e => e.KskId);

            entity.ToTable("KS_FactorBankAccounts", "do");

            entity.Property(e => e.KskId).HasColumnName("KSK_Id");
            entity.Property(e => e.KskDocumentId).HasColumnName("KSK_DocumentId");
            entity.Property(e => e.KskFaktorNazwaBanku)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSK_FaktorNazwaBanku");
            entity.Property(e => e.KskFaktorNrRachunku)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KSK_FaktorNrRachunku");
            entity.Property(e => e.KskFaktorNrRachunkuSwift)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("KSK_FaktorNrRachunkuSWIFT");
            entity.Property(e => e.KskFaktorOpisBanku)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSK_FaktorOpisBanku");
            entity.Property(e => e.KskFaktorRachunekWlasnyBanku).HasColumnName("KSK_FaktorRachunekWlasnyBanku");

            entity.HasOne(d => d.KskDocument).WithMany(p => p.KsFactorBankAccounts)
                .HasForeignKey(d => d.KskDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_FactorBankAccounts_KS_Documents");
        });

        modelBuilder.Entity<KsLoadSettlement>(entity =>
        {
            entity.HasKey(e => e.KslId);

            entity.ToTable("KS_LoadSettlements", "do");

            entity.Property(e => e.KslId).HasColumnName("KSL_Id");
            entity.Property(e => e.KslDocumentId).HasColumnName("KSL_DocumentId");
            entity.Property(e => e.KslRozliczenieObciazeniaKwota)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSL_RozliczenieObciazeniaKwota");
            entity.Property(e => e.KslRozliczenieObciazeniaPowod)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSL_RozliczenieObciazeniaPowod");

            entity.HasOne(d => d.KslDocument).WithMany(p => p.KsLoadSettlements)
                .HasForeignKey(d => d.KslDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_LoadSettlements_KS_Documents");
        });

        modelBuilder.Entity<KsPartialPayment>(entity =>
        {
            entity.HasKey(e => e.KsrId);

            entity.ToTable("KS_PartialPayments", "do");

            entity.Property(e => e.KsrId).HasColumnName("KSR_Id");
            entity.Property(e => e.KsrDataZaplatyCzesciowej)
                .HasColumnType("datetime")
                .HasColumnName("KSR_DataZaplatyCzesciowej");
            entity.Property(e => e.KsrDocumentId).HasColumnName("KSR_DocumentId");
            entity.Property(e => e.KsrKwotaZaplatyCzesciowej)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KSR_KwotaZaplatyCzesciowej");

            entity.HasOne(d => d.KsrDocument).WithMany(p => p.KsPartialPayments)
                .HasForeignKey(d => d.KsrDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_PartialPayments_KS_Documents");
        });

        modelBuilder.Entity<KsPaymentDate>(entity =>
        {
            entity.HasKey(e => e.KspId);

            entity.ToTable("KS_PaymentDates", "do");

            entity.Property(e => e.KspId).HasColumnName("KSP_Id");
            entity.Property(e => e.KspDocumentId).HasColumnName("KSP_DocumentId");
            entity.Property(e => e.KspTerminPlatnosci)
                .HasColumnType("datetime")
                .HasColumnName("KSP_TerminPlatnosci");
            entity.Property(e => e.KspTerminPlatnosciOpis)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSP_TerminPlatnosciOpis");

            entity.HasOne(d => d.KspDocument).WithMany(p => p.KsPaymentDates)
                .HasForeignKey(d => d.KspDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_PaymentDates_KS_Documents");
        });

        modelBuilder.Entity<KsShipmentAddress>(entity =>
        {
            entity.HasKey(e => e.KsyId);

            entity.ToTable("KS_ShipmentAddresses", "do");

            entity.Property(e => e.KsyId).HasColumnName("KSY_Id");
            entity.Property(e => e.KsyAdres)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSY_Adres");
            entity.Property(e => e.KsyGln)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSY_GLN");
            entity.Property(e => e.KsyKodKraju)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSY_KodKraju");
            entity.Property(e => e.KsyTransportId).HasColumnName("KSY_TransportId");
            entity.Property(e => e.KsyType).HasColumnName("KSY_Type");

            entity.HasOne(d => d.KsyTransport).WithMany(p => p.KsShipmentAddresses)
                .HasForeignKey(d => d.KsyTransportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_ShipmentAddresses_KS_Transports");
        });

        modelBuilder.Entity<KsSordocument>(entity =>
        {
            entity.HasKey(e => e.KssId);

            entity.ToTable("KS_SORDocuments", "do");

            entity.Property(e => e.KssId).HasColumnName("KSS_Id");
            entity.Property(e => e.KssDocumentId).HasColumnName("KSS_DocumentId");
            entity.Property(e => e.KssNumerWz)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSS_NumerWZ");

            entity.HasOne(d => d.KssDocument).WithMany(p => p.KsSordocuments)
                .HasForeignKey(d => d.KssDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_SORDocuments_KS_Documents");
        });

        modelBuilder.Entity<KsTransport>(entity =>
        {
            entity.HasKey(e => e.KsnId);

            entity.ToTable("KS_Transports", "do");

            entity.Property(e => e.KsnId).HasColumnName("KSN_Id");
            entity.Property(e => e.KsnDocumentId).HasColumnName("KSN_DocumentId");
            entity.Property(e => e.KsnWarunkiTransakcjiDataGodzRozpTransportu)
                .HasColumnType("datetime")
                .HasColumnName("KSN_WarunkiTransakcjiDataGodzRozpTransportu");
            entity.Property(e => e.KsnWarunkiTransakcjiDataGodzZakTransportu)
                .HasColumnType("datetime")
                .HasColumnName("KSN_WarunkiTransakcjiDataGodzZakTransportu");
            entity.Property(e => e.KsnWarunkiTransakcjiJednostkaOpakowania)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSN_WarunkiTransakcjiJednostkaOpakowania");
            entity.Property(e => e.KsnWarunkiTransakcjiLadunekInny).HasColumnName("KSN_WarunkiTransakcjiLadunekInny");
            entity.Property(e => e.KsnWarunkiTransakcjiNrZleceniaTransportu)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSN_WarunkiTransakcjiNrZleceniaTransportu");
            entity.Property(e => e.KsnWarunkiTransakcjiOpisInnegoLadunku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSN_WarunkiTransakcjiOpisInnegoLadunku");
            entity.Property(e => e.KsnWarunkiTransakcjiOpisInnegoTransportu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSN_WarunkiTransakcjiOpisInnegoTransportu");
            entity.Property(e => e.KsnWarunkiTransakcjiOpisLadunku).HasColumnName("KSN_WarunkiTransakcjiOpisLadunku");
            entity.Property(e => e.KsnWarunkiTransakcjiPrzewoznikAdres)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSN_WarunkiTransakcjiPrzewoznikAdres");
            entity.Property(e => e.KsnWarunkiTransakcjiPrzewoznikBrakId).HasColumnName("KSN_WarunkiTransakcjiPrzewoznikBrakID");
            entity.Property(e => e.KsnWarunkiTransakcjiPrzewoznikGln)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSN_WarunkiTransakcjiPrzewoznikGLN");
            entity.Property(e => e.KsnWarunkiTransakcjiPrzewoznikKodKraju)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSN_WarunkiTransakcjiPrzewoznikKodKraju");
            entity.Property(e => e.KsnWarunkiTransakcjiPrzewoznikKodUe)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KSN_WarunkiTransakcjiPrzewoznikKodUE");
            entity.Property(e => e.KsnWarunkiTransakcjiPrzewoznikNazwa)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KSN_WarunkiTransakcjiPrzewoznikNazwa");
            entity.Property(e => e.KsnWarunkiTransakcjiPrzewoznikNip)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSN_WarunkiTransakcjiPrzewoznikNIP");
            entity.Property(e => e.KsnWarunkiTransakcjiPrzewoznikNrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KSN_WarunkiTransakcjiPrzewoznikNrID");
            entity.Property(e => e.KsnWarunkiTransakcjiPrzewoznikNrUe)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("KSN_WarunkiTransakcjiPrzewoznikNrUE");
            entity.Property(e => e.KsnWarunkiTransakcjiRodzajTransportu).HasColumnName("KSN_WarunkiTransakcjiRodzajTransportu");
            entity.Property(e => e.KsnWarunkiTransakcjiTransportInny).HasColumnName("KSN_WarunkiTransakcjiTransportInny");

            entity.HasOne(d => d.KsnDocument).WithMany(p => p.KsTransports)
                .HasForeignKey(d => d.KsnDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_Transports_KS_Documents");
        });

        modelBuilder.Entity<KsTransportMean>(entity =>
        {
            entity.HasKey(e => e.KsmId);

            entity.ToTable("KS_TransportMeans", "do");

            entity.Property(e => e.KsmId).HasColumnName("KSM_Id");
            entity.Property(e => e.KsmDocumentId).HasColumnName("KSM_DocumentId");
            entity.Property(e => e.KsmNstdataDopuszczenia)
                .HasColumnType("datetime")
                .HasColumnName("KSM_NSTDataDopuszczenia");
            entity.Property(e => e.KsmNstkolor)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTKolor");
            entity.Property(e => e.KsmNstmarka)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTMarka");
            entity.Property(e => e.KsmNstmodel)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTModel");
            entity.Property(e => e.KsmNstnrFabryczny)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTNrFabryczny");
            entity.Property(e => e.KsmNstnrKadluba)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTNrKadluba");
            entity.Property(e => e.KsmNstnrNadwozia)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTNrNadwozia");
            entity.Property(e => e.KsmNstnrPodwozia)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTNrPodwozia");
            entity.Property(e => e.KsmNstnrRamy)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTNrRamy");
            entity.Property(e => e.KsmNstnrRej)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTNrRej");
            entity.Property(e => e.KsmNstnrWierszaFa).HasColumnName("KSM_NSTNrWierszaFa");
            entity.Property(e => e.KsmNstplywGodzRobocze)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTPlywGodzRobocze");
            entity.Property(e => e.KsmNstpowGodzRobocze)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTPowGodzRobocze");
            entity.Property(e => e.KsmNstprzebieg)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTPrzebieg");
            entity.Property(e => e.KsmNstrokProd)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTRokProd");
            entity.Property(e => e.KsmNsttyp)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTTyp");
            entity.Property(e => e.KsmNstvin)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KSM_NSTVIN");

            entity.HasOne(d => d.KsmDocument).WithMany(p => p.KsTransportMeans)
                .HasForeignKey(d => d.KsmDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KS_TransportMeans_KS_Documents");
        });

        modelBuilder.Entity<KsWorkApprocess>(entity =>
        {
            entity.HasKey(e => e.KswId);

            entity.ToTable("KS_WorkAPProcess", "do");

            entity.Property(e => e.KswId).HasColumnName("KSW_Id");
            entity.Property(e => e.KswApdid).HasColumnName("KSW_APDId");
            entity.Property(e => e.KswArchival).HasColumnName("KSW_Archival");
            entity.Property(e => e.KswCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("KSW_CreateDate");
            entity.Property(e => e.KswDocumentId).HasColumnName("KSW_DocumentId");
            entity.Property(e => e.KswOperatorId).HasColumnName("KSW_OperatorId");
            entity.Property(e => e.KswStatus).HasColumnName("KSW_Status");
        });

        modelBuilder.Entity<LeOrderStage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LE_OrderStages", "do");

            entity.Property(e => e.LsCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("LS_CreateDate");
            entity.Property(e => e.LsDcdid).HasColumnName("LS_DCDId");
            entity.Property(e => e.LsDshid).HasColumnName("LS_DSHId");
            entity.Property(e => e.LsId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LS_Id");
            entity.Property(e => e.LsNameSink)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("LS_NameSink");
            entity.Property(e => e.LsNameSource)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("LS_NameSource");
            entity.Property(e => e.LsPredictionValue).HasColumnName("LS_PredictionValue");
        });

        modelBuilder.Entity<LgHead>(entity =>
        {
            entity.HasKey(e => e.LhdId).HasName("LHD_Primary");

            entity.ToTable("LG_Head", "do");

            entity.Property(e => e.LhdId)
                .ValueGeneratedNever()
                .HasColumnName("LHD_ID");
            entity.Property(e => e.LhdCulture)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LHD_Culture");
            entity.Property(e => e.LhdName)
                .HasMaxLength(30)
                .HasColumnName("LHD_Name");
        });

        modelBuilder.Entity<LgLanguage>(entity =>
        {
            entity.HasKey(e => new { e.LgsLhdid, e.LgsKey }).HasName("LGS_Primary");

            entity.ToTable("LG_Languages", "do");

            entity.Property(e => e.LgsLhdid).HasColumnName("LGS_LHDId");
            entity.Property(e => e.LgsKey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LGS_Key");
            entity.Property(e => e.LgsPhrase)
                .HasMaxLength(2000)
                .HasColumnName("LGS_Phrase");
            entity.Property(e => e.LgsType).HasColumnName("LGS_Type");

            entity.HasOne(d => d.LgsLhd).WithMany(p => p.LgLanguages)
                .HasForeignKey(d => d.LgsLhdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LG_Languages_LG_Head");
        });

        modelBuilder.Entity<LgWorkUser>(entity =>
        {
            entity.HasKey(e => e.LguDcdid).HasName("LGU_Primary");

            entity.ToTable("LG_WorkUser", "do");

            entity.Property(e => e.LguDcdid)
                .ValueGeneratedNever()
                .HasColumnName("LGU_DCDId");
            entity.Property(e => e.LguLhdid).HasColumnName("LGU_LHDId");
        });

        modelBuilder.Entity<MdSession>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MD_Sessions", "do");

            entity.Property(e => e.MdsAuthenticationToken).HasColumnName("MDS_AuthenticationToken");
            entity.Property(e => e.MdsAuthenticationTokenExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("MDS_AuthenticationToken_ExpirationDate");
            entity.Property(e => e.MdsAuthorisationToken).HasColumnName("MDS_AuthorisationToken");
            entity.Property(e => e.MdsAuthorisationTokenExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("MDS_AuthorisationToken_ExpirationDate");
            entity.Property(e => e.MdsLastActivityTime)
                .HasColumnType("datetime")
                .HasColumnName("MDS_LastActivityTime");
            entity.Property(e => e.MdsLoggedInDcdid).HasColumnName("MDS_LoggedInDCDId");
            entity.Property(e => e.MdsSguid).HasColumnName("MDS_SGUID");
        });

        modelBuilder.Entity<MlError>(entity =>
        {
            entity.HasKey(e => e.MleId);

            entity.ToTable("ML_Errors", "do");

            entity.Property(e => e.MleId).HasColumnName("MLE_Id");
            entity.Property(e => e.MleApdid).HasColumnName("MLE_APDId");
            entity.Property(e => e.MleCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("MLE_CreateDate");
            entity.Property(e => e.MleMessage).HasColumnName("MLE_Message");
            entity.Property(e => e.MleOperatorId).HasColumnName("MLE_OperatorId");
        });

        modelBuilder.Entity<MlMail>(entity =>
        {
            entity.HasKey(e => e.MlmId);

            entity.ToTable("ML_Mails", "do");

            entity.Property(e => e.MlmId).HasColumnName("MLM_Id");
            entity.Property(e => e.MlmBodyText)
                .HasColumnType("text")
                .HasColumnName("MLM_BodyText");
            entity.Property(e => e.MlmCc)
                .IsUnicode(false)
                .HasColumnName("MLM_Cc");
            entity.Property(e => e.MlmDate)
                .HasColumnType("datetime")
                .HasColumnName("MLM_Date");
            entity.Property(e => e.MlmFrom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MLM_From");
            entity.Property(e => e.MlmMailBox)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MLM_MailBox");
            entity.Property(e => e.MlmMessageId).HasColumnName("MLM_MessageId");
            entity.Property(e => e.MlmSubject)
                .HasMaxLength(500)
                .HasColumnName("MLM_Subject");
            entity.Property(e => e.MlmTo)
                .IsUnicode(false)
                .HasColumnName("MLM_To");
        });

        modelBuilder.Entity<MlMailAttachment>(entity =>
        {
            entity.HasKey(e => e.MlaId);

            entity.ToTable("ML_Mail_Attachments", "do");

            entity.Property(e => e.MlaId).HasColumnName("MLA_Id");
            entity.Property(e => e.MlaAngleOfRotation)
                .HasDefaultValue(0)
                .HasColumnName("MLA_AngleOfRotation");
            entity.Property(e => e.MlaArchival).HasColumnName("MLA_Archival");
            entity.Property(e => e.MlaContent)
                .HasColumnType("image")
                .HasColumnName("MLA_Content");
            entity.Property(e => e.MlaFileName)
                .HasMaxLength(255)
                .HasColumnName("MLA_FileName");
            entity.Property(e => e.MlaMailId).HasColumnName("MLA_MailId");
            entity.Property(e => e.MlaPosition).HasColumnName("MLA_Position");

            entity.HasOne(d => d.MlaMail).WithMany(p => p.MlMailAttachments)
                .HasForeignKey(d => d.MlaMailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ML_Mail_Attachments_ML_Mails");
        });

        modelBuilder.Entity<MlWorkApprocess>(entity =>
        {
            entity.HasKey(e => e.MlwId);

            entity.ToTable("ML_WorkAPProcess", "do");

            entity.Property(e => e.MlwId).HasColumnName("MLW_Id");
            entity.Property(e => e.MlwApdid).HasColumnName("MLW_APDId");
            entity.Property(e => e.MlwArchival).HasColumnName("MLW_Archival");
            entity.Property(e => e.MlwCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("MLW_CreateDate");
            entity.Property(e => e.MlwMailId).HasColumnName("MLW_MailId");
            entity.Property(e => e.MlwOperatorId).HasColumnName("MLW_OperatorId");
            entity.Property(e => e.MlwProcessDate)
                .HasColumnType("datetime")
                .HasColumnName("MLW_ProcessDate");
            entity.Property(e => e.MlwStatus).HasColumnName("MLW_Status");
        });

        modelBuilder.Entity<OcDocument>(entity =>
        {
            entity.HasKey(e => e.OcdId);

            entity.ToTable("OC_Documents", "do");

            entity.Property(e => e.OcdId).HasColumnName("OCD_Id");
            entity.Property(e => e.OcdBankAccountNumber)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("OCD_BankAccountNumber");
            entity.Property(e => e.OcdBarcodeText)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OCD_BarcodeText");
            entity.Property(e => e.OcdBarcodeType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCD_BarcodeType");
            entity.Property(e => e.OcdBuyerContractorApartmentNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OCD_BuyerContractorApartmentNumber");
            entity.Property(e => e.OcdBuyerContractorCity)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCD_BuyerContractorCity");
            entity.Property(e => e.OcdBuyerContractorHouseNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OCD_BuyerContractorHouseNumber");
            entity.Property(e => e.OcdBuyerContractorIsActiveVatPayer).HasColumnName("OCD_BuyerContractorIsActiveVatPayer");
            entity.Property(e => e.OcdBuyerContractorName)
                .IsUnicode(false)
                .HasColumnName("OCD_BuyerContractorName");
            entity.Property(e => e.OcdBuyerContractorNip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OCD_BuyerContractorNip");
            entity.Property(e => e.OcdBuyerContractorPost)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCD_BuyerContractorPost");
            entity.Property(e => e.OcdBuyerContractorPostcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OCD_BuyerContractorPostcode");
            entity.Property(e => e.OcdBuyerContractorStreet)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCD_BuyerContractorStreet");
            entity.Property(e => e.OcdBuyerContractorVoivodeship)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCD_BuyerContractorVoivodeship");
            entity.Property(e => e.OcdContractorApartmentNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorApartmentNumber");
            entity.Property(e => e.OcdContractorCity)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorCity");
            entity.Property(e => e.OcdContractorCountry)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorCountry");
            entity.Property(e => e.OcdContractorHouseNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorHouseNumber");
            entity.Property(e => e.OcdContractorIsActiveVatPayer).HasColumnName("OCD_ContractorIsActiveVatPayer");
            entity.Property(e => e.OcdContractorName)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorName");
            entity.Property(e => e.OcdContractorName1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorName1");
            entity.Property(e => e.OcdContractorName2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorName2");
            entity.Property(e => e.OcdContractorName3)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorName3");
            entity.Property(e => e.OcdContractorNip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorNip");
            entity.Property(e => e.OcdContractorPost)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorPost");
            entity.Property(e => e.OcdContractorPostcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorPostcode");
            entity.Property(e => e.OcdContractorStreet)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorStreet");
            entity.Property(e => e.OcdContractorVoivodeship)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCD_ContractorVoivodeship");
            entity.Property(e => e.OcdCorrection)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("OCD_Correction");
            entity.Property(e => e.OcdCorrectionNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OCD_CorrectionNumber");
            entity.Property(e => e.OcdCurrency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("OCD_Currency");
            entity.Property(e => e.OcdCurrencyDate)
                .HasColumnType("datetime")
                .HasColumnName("OCD_CurrencyDate");
            entity.Property(e => e.OcdCurrencyRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCD_CurrencyRate");
            entity.Property(e => e.OcdCurrencyUnit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCD_CurrencyUnit");
            entity.Property(e => e.OcdDate)
                .HasColumnType("datetime")
                .HasColumnName("OCD_Date");
            entity.Property(e => e.OcdDeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("OCD_DeliveryDate");
            entity.Property(e => e.OcdDocumentId).HasColumnName("OCD_DocumentId");
            entity.Property(e => e.OcdDocumentName)
                .HasDefaultValue((byte)1)
                .HasColumnName("OCD_DocumentName");
            entity.Property(e => e.OcdDocumentRawText)
                .HasColumnType("text")
                .HasColumnName("OCD_DocumentRawText");
            entity.Property(e => e.OcdDocumentType)
                .HasDefaultValue((byte)1)
                .HasColumnName("OCD_DocumentType");
            entity.Property(e => e.OcdEsrCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OCD_EsrCode");
            entity.Property(e => e.OcdEsrReference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCD_EsrReference");
            entity.Property(e => e.OcdEsrSubscriberCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCD_EsrSubscriberCode");
            entity.Property(e => e.OcdFileName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OCD_FileName");
            entity.Property(e => e.OcdFirstPageNumber).HasColumnName("OCD_FirstPageNumber");
            entity.Property(e => e.OcdGrossAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCD_GrossAmount");
            entity.Property(e => e.OcdIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("OCD_IssueDate");
            entity.Property(e => e.OcdLanguage)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OCD_Language");
            entity.Property(e => e.OcdNetAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCD_NetAmount");
            entity.Property(e => e.OcdNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCD_Number");
            entity.Property(e => e.OcdOrderDate)
                .HasColumnType("datetime")
                .HasColumnName("OCD_OrderDate");
            entity.Property(e => e.OcdOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCD_OrderNumber");
            entity.Property(e => e.OcdPaymentAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCD_PaymentAmount");
            entity.Property(e => e.OcdPaymentCurrency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("OCD_PaymentCurrency");
            entity.Property(e => e.OcdPaymentCurrencyDate)
                .HasColumnType("datetime")
                .HasColumnName("OCD_PaymentCurrencyDate");
            entity.Property(e => e.OcdPaymentCurrencyRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCD_PaymentCurrencyRate");
            entity.Property(e => e.OcdPaymentCurrencyType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OCD_PaymentCurrencyType");
            entity.Property(e => e.OcdPaymentCurrencyUnit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCD_PaymentCurrencyUnit");
            entity.Property(e => e.OcdPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("OCD_PaymentDate");
            entity.Property(e => e.OcdPaymentType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OCD_PaymentType");
            entity.Property(e => e.OcdPurchaseDate)
                .HasColumnType("datetime")
                .HasColumnName("OCD_PurchaseDate");
            entity.Property(e => e.OcdPurchaseOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCD_PurchaseOrderNumber");
            entity.Property(e => e.OcdQradditionalInformation)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("OCD_QRAdditionalInformation");
            entity.Property(e => e.OcdQrbillInformation)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("OCD_QRBillInformation");
            entity.Property(e => e.OcdQrreference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCD_QRReference");
            entity.Property(e => e.OcdReceiptDate)
                .HasColumnType("datetime")
                .HasColumnName("OCD_ReceiptDate");
            entity.Property(e => e.OcdSellerContractorApartmentNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OCD_SellerContractorApartmentNumber");
            entity.Property(e => e.OcdSellerContractorCity)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCD_SellerContractorCity");
            entity.Property(e => e.OcdSellerContractorHouseNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OCD_SellerContractorHouseNumber");
            entity.Property(e => e.OcdSellerContractorIsActiveVatPayer).HasColumnName("OCD_SellerContractorIsActiveVatPayer");
            entity.Property(e => e.OcdSellerContractorName)
                .IsUnicode(false)
                .HasColumnName("OCD_SellerContractorName");
            entity.Property(e => e.OcdSellerContractorNip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OCD_SellerContractorNip");
            entity.Property(e => e.OcdSellerContractorPost)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCD_SellerContractorPost");
            entity.Property(e => e.OcdSellerContractorPostcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OCD_SellerContractorPostcode");
            entity.Property(e => e.OcdSellerContractorStreet)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCD_SellerContractorStreet");
            entity.Property(e => e.OcdSellerContractorTaxIdentificationNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OCD_SellerContractorTaxIdentificationNumber");
            entity.Property(e => e.OcdSellerContractorVoivodeship)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCD_SellerContractorVoivodeship");
            entity.Property(e => e.OcdSourceContent)
                .HasColumnType("image")
                .HasColumnName("OCD_SourceContent");
            entity.Property(e => e.OcdSystemCurrencyPaymentAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCD_SystemCurrencyPaymentAmount");
            entity.Property(e => e.OcdTag1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OCD_Tag1");
            entity.Property(e => e.OcdTag2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OCD_Tag2");
            entity.Property(e => e.OcdTag3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OCD_Tag3");
            entity.Property(e => e.OcdVatAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCD_VatAmount");
            entity.Property(e => e.OcdVehicleIdentificationNumber)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCD_VehicleIdentificationNumber");
        });

        modelBuilder.Entity<OcDocumentBarcode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OC_Document_Barcodes", "do");

            entity.Property(e => e.OcbBarcodeText)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OCB_BarcodeText");
            entity.Property(e => e.OcbBarcodeType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCB_BarcodeType");
            entity.Property(e => e.OcbDocumentId).HasColumnName("OCB_DocumentId");
            entity.Property(e => e.OcbId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OCB_Id");
            entity.Property(e => e.OcbLp).HasColumnName("OCB_LP");
        });

        modelBuilder.Entity<OcDocumentItem>(entity =>
        {
            entity.HasKey(e => e.OdiId);

            entity.ToTable("OC_Document_Items", "do");

            entity.Property(e => e.OdiId).HasColumnName("ODI_Id");
            entity.Property(e => e.OdiCount)
                .HasColumnType("numeric(22, 6)")
                .HasColumnName("ODI_Count");
            entity.Property(e => e.OdiDocumentId).HasColumnName("ODI_DocumentId");
            entity.Property(e => e.OdiEan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODI_EAN");
            entity.Property(e => e.OdiGrossUnitPrice)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ODI_GrossUnitPrice");
            entity.Property(e => e.OdiGrossValue)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ODI_GrossValue");
            entity.Property(e => e.OdiName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ODI_Name");
            entity.Property(e => e.OdiNetUnitPrice)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ODI_NetUnitPrice");
            entity.Property(e => e.OdiNetValue)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ODI_NetValue");
            entity.Property(e => e.OdiProductCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODI_ProductCode");
            entity.Property(e => e.OdiUnit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ODI_Unit");
            entity.Property(e => e.OdiVatAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ODI_VatAmount");
            entity.Property(e => e.OdiVatRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ODI_VatRate");
            entity.Property(e => e.OdiVatStatus).HasColumnName("ODI_VatStatus");

            entity.HasOne(d => d.OdiDocument).WithMany(p => p.OcDocumentItems)
                .HasForeignKey(d => d.OdiDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OC_Document_Items_OC_Documents");
        });

        modelBuilder.Entity<OcDocumentJpkcode>(entity =>
        {
            entity.HasKey(e => e.OdjId);

            entity.ToTable("OC_Document_JPKCodes", "do");

            entity.Property(e => e.OdjId).HasColumnName("ODJ_Id");
            entity.Property(e => e.OdjCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODJ_Code");
            entity.Property(e => e.OdjDocumentId).HasColumnName("ODJ_DocumentId");

            entity.HasOne(d => d.OdjDocument).WithMany(p => p.OcDocumentJpkcodes)
                .HasForeignKey(d => d.OdjDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OC_Document_JPKCodes_OC_Documents");
        });

        modelBuilder.Entity<OcDocumentVatRegistry>(entity =>
        {
            entity.HasKey(e => e.OcvId);

            entity.ToTable("OC_Document_Vat_Registries", "do");

            entity.Property(e => e.OcvId).HasColumnName("OCV_Id");
            entity.Property(e => e.OcvDocumentId).HasColumnName("OCV_DocumentId");
            entity.Property(e => e.OcvGross)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCV_Gross");
            entity.Property(e => e.OcvNet)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCV_Net");
            entity.Property(e => e.OcvPurchaseType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OCV_PurchaseType");
            entity.Property(e => e.OcvVat)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCV_Vat");
            entity.Property(e => e.OcvVatDeduction)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OCV_VatDeduction");
            entity.Property(e => e.OcvVatRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OCV_VatRate");
            entity.Property(e => e.OcvVatStatus)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("OCV_VatStatus");

            entity.HasOne(d => d.OcvDocument).WithMany(p => p.OcDocumentVatRegistries)
                .HasForeignKey(d => d.OcvDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OC_Document_Vat_Registries_OC_Documents");
        });

        modelBuilder.Entity<OcError>(entity =>
        {
            entity.HasKey(e => e.OceId);

            entity.ToTable("OC_Errors", "do");

            entity.Property(e => e.OceId).HasColumnName("OCE_Id");
            entity.Property(e => e.OceApdid).HasColumnName("OCE_APDId");
            entity.Property(e => e.OceCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OCE_CreateDate");
            entity.Property(e => e.OceMessage).HasColumnName("OCE_Message");
            entity.Property(e => e.OceOperatorId).HasColumnName("OCE_OperatorId");
            entity.Property(e => e.OceUri)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OCE_Uri");
        });

        modelBuilder.Entity<OcFilelock>(entity =>
        {
            entity.HasKey(e => e.OcfId);

            entity.ToTable("OC_Filelocks", "do");

            entity.HasIndex(e => e.OcfResourceId, "UQ__OC_Filel__DE70F8F275EABBB6").IsUnique();

            entity.Property(e => e.OcfId).HasColumnName("OCF_Id");
            entity.Property(e => e.OcfApdid).HasColumnName("OCF_APDId");
            entity.Property(e => e.OcfFilePath)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("OCF_FilePath");
            entity.Property(e => e.OcfFileProcessId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OCF_FileProcessId");
            entity.Property(e => e.OcfInstanceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OCF_InstanceId");
            entity.Property(e => e.OcfLockDate)
                .HasColumnType("datetime")
                .HasColumnName("OCF_LockDate");
            entity.Property(e => e.OcfLockExpiration)
                .HasColumnType("datetime")
                .HasColumnName("OCF_LockExpiration");
            entity.Property(e => e.OcfMachineName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OCF_MachineName");
            entity.Property(e => e.OcfOperatorId).HasColumnName("OCF_OperatorId");
            entity.Property(e => e.OcfProcessId).HasColumnName("OCF_ProcessId");
            entity.Property(e => e.OcfResourceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OCF_ResourceId");
            entity.Property(e => e.OcfWindowsLogin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OCF_WindowsLogin");
        });

        modelBuilder.Entity<OcWorkApprocess>(entity =>
        {
            entity.HasKey(e => e.OcwId);

            entity.ToTable("OC_WorkAPProcess", "do");

            entity.Property(e => e.OcwId).HasColumnName("OCW_Id");
            entity.Property(e => e.OcwApdid).HasColumnName("OCW_APDId");
            entity.Property(e => e.OcwArchival).HasColumnName("OCW_Archival");
            entity.Property(e => e.OcwCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OCW_CreateDate");
            entity.Property(e => e.OcwDocumentId).HasColumnName("OCW_DocumentId");
            entity.Property(e => e.OcwLocalFileName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("OCW_LocalFileName");
            entity.Property(e => e.OcwMessage).HasColumnName("OCW_Message");
            entity.Property(e => e.OcwOperatorId).HasColumnName("OCW_OperatorId");
            entity.Property(e => e.OcwStatus).HasColumnName("OCW_Status");
        });

        modelBuilder.Entity<PmProcessMail>(entity =>
        {
            entity.HasKey(e => e.PmId);

            entity.ToTable("PM_ProcessMails", "do");

            entity.Property(e => e.PmId).HasColumnName("PM_Id");
            entity.Property(e => e.PmBccRecipients)
                .HasMaxLength(1024)
                .HasColumnName("PM_BccRecipients");
            entity.Property(e => e.PmBody).HasColumnName("PM_Body");
            entity.Property(e => e.PmCcRecipients)
                .HasMaxLength(1024)
                .HasColumnName("PM_CcRecipients");
            entity.Property(e => e.PmSent)
                .HasDefaultValue((short)0)
                .HasColumnName("PM_Sent");
            entity.Property(e => e.PmSubject)
                .HasMaxLength(255)
                .HasColumnName("PM_Subject");
        });

        modelBuilder.Entity<PmaProcessMailsAttachment>(entity =>
        {
            entity.HasKey(e => e.PmaId);

            entity.ToTable("PMA_ProcessMailsAttachment", "do");

            entity.Property(e => e.PmaId).HasColumnName("PMA_Id");
            entity.Property(e => e.PmaData).HasColumnName("PMA_Data");
            entity.Property(e => e.PmaName)
                .HasMaxLength(255)
                .HasColumnName("PMA_Name");
            entity.Property(e => e.PmaPmid).HasColumnName("PMA_PMID");

            entity.HasOne(d => d.PmaPm).WithMany(p => p.PmaProcessMailsAttachments)
                .HasForeignKey(d => d.PmaPmid)
                .HasConstraintName("FK_PMA_ProcessMailsAttachment_PM_ProcessMails");
        });

        modelBuilder.Entity<RoControlsValue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RO_ControlsValue", "do");

            entity.Property(e => e.DctName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DCT_Name");
            entity.Property(e => e.DfhId).HasColumnName("DFH_Id");
            entity.Property(e => e.DkoId).HasColumnName("DKO_ID");
            entity.Property(e => e.DkoName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DKO_Name");
            entity.Property(e => e.DshId).HasColumnName("DSH_ID");
            entity.Property(e => e.DwcId).HasColumnName("DWC_ID");
            entity.Property(e => e.DwdId).HasColumnName("DWD_ID");
            entity.Property(e => e.Value)
                .HasMaxLength(900)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoControlsValueExpand>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RO_ControlsValueExpand", "do");

            entity.Property(e => e.DctName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DCT_Name");
            entity.Property(e => e.DfhId).HasColumnName("DFH_Id");
            entity.Property(e => e.DkoId).HasColumnName("DKO_ID");
            entity.Property(e => e.DkoName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DKO_Name");
            entity.Property(e => e.DshId).HasColumnName("DSH_ID");
            entity.Property(e => e.DwcId).HasColumnName("DWC_ID");
            entity.Property(e => e.DwcValueDate)
                .HasColumnType("datetime")
                .HasColumnName("DWC_ValueDate");
            entity.Property(e => e.DwcValueDecimal)
                .HasColumnType("decimal(24, 6)")
                .HasColumnName("DWC_ValueDecimal");
            entity.Property(e => e.DwcValueInt).HasColumnName("DWC_ValueInt");
            entity.Property(e => e.DwcValueListPos).HasColumnName("DWC_ValueListPos");
            entity.Property(e => e.DwcValueReal).HasColumnName("DWC_ValueReal");
            entity.Property(e => e.DwcValueString)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("DWC_ValueString");
            entity.Property(e => e.DwdId).HasColumnName("DWD_ID");
        });

        modelBuilder.Entity<RoCustomContentDiagnosticLogDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RO_CustomContentDiagnosticLogDetails", "do");

            entity.Property(e => e.ControlType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LogType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.WorkflowInstanceIdDshid).HasColumnName("WorkflowInstanceId (DSHID)");
        });

        modelBuilder.Entity<RoDocAccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RO_DocAccess", "do");

            entity.Property(e => e.DcdId).HasColumnName("DCD_ID");
            entity.Property(e => e.DdsName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DDS_Name");
            entity.Property(e => e.DfhId).HasColumnName("DFH_ID");
            entity.Property(e => e.DshId).HasColumnName("DSH_ID");
            entity.Property(e => e.DwdCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("DWD_CreateDate");
            entity.Property(e => e.DwdDcdownerId).HasColumnName("DWD_DCDOwnerId");
            entity.Property(e => e.DwdFullNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DWD_FullNumber");
            entity.Property(e => e.DwdId).HasColumnName("DWD_ID");
            entity.Property(e => e.DwdMonth).HasColumnName("DWD_Month");
            entity.Property(e => e.DwdYear).HasColumnName("DWD_Year");
            entity.Property(e => e.DwsId).HasColumnName("DWS_ID");
        });

        modelBuilder.Entity<RoDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RO_Documents", "do");

            entity.Property(e => e.DfhId).HasColumnName("DFH_Id");
            entity.Property(e => e.DshId).HasColumnName("DSH_ID");
            entity.Property(e => e.DwdCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("DWD_CreateDate");
            entity.Property(e => e.DwdDcdownerId).HasColumnName("DWD_DCDOwnerId");
            entity.Property(e => e.DwdFullNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DWD_FullNumber");
            entity.Property(e => e.DwdId).HasColumnName("DWD_ID");
            entity.Property(e => e.DwdMonth).HasColumnName("DWD_Month");
            entity.Property(e => e.DwdNumber).HasColumnName("DWD_Number");
            entity.Property(e => e.DwdYear).HasColumnName("DWD_Year");
        });

        modelBuilder.Entity<RoEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RO_Employee", "do");

            entity.Property(e => e.DcdId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DCD_Id");
            entity.Property(e => e.DcdName1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_Name1");
        });

        modelBuilder.Entity<RoEmployeePermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RO_EmployeePermissions", "do");

            entity.Property(e => e.Administrator)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.AutomatyczneTworzenieDokumentówOcr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Automatyczne tworzenie dokumentów (OCR)");
            entity.Property(e => e.DcdId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DCD_ID");
            entity.Property(e => e.EksportListyDokDoExcela)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Eksport listy dok. do Excela");
            entity.Property(e => e.GenerowanieDokXlWOparciuOLoginWłasny)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Generowanie dok. XL w oparciu o login własny");
            entity.Property(e => e.InicjowanieObieguNaPodstawieSkanuDok)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Inicjowanie obiegu na podstawie skanu dok.");
            entity.Property(e => e.KreatorRaportów)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Kreator raportów");
            entity.Property(e => e.MetodaLogowania)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("Metoda logowania");
            entity.Property(e => e.Operator)
                .HasMaxLength(358)
                .IsUnicode(false);
            entity.Property(e => e.PodglądWydrukuDokumentuWww)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Podgląd wydruku dokumentu (WWW)");
            entity.Property(e => e.PowrótNaListęPoPrzekazaniu)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Powrót na listę po przekazaniu");
            entity.Property(e => e.PracaZModułem)
                .HasMaxLength(37)
                .IsUnicode(false)
                .HasColumnName("Praca z modułem");
            entity.Property(e => e.UruchomComarchErpAltumWTle)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Uruchom Comarch ERP Altum w tle");
            entity.Property(e => e.UsuwanieDokumentów)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Usuwanie dokumentów");
            entity.Property(e => e.WydrukKsiążkiNadawczej)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Wydruk książki nadawczej");
            entity.Property(e => e.WydrukStandardowy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Wydruk standardowy");
            entity.Property(e => e.ZmianaDatyUtworzeniaDokumentu)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Zmiana daty utworzenia dokumentu");
        });

        modelBuilder.Entity<RoExpiredDoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RO_ExpiredDocs", "do");

            entity.Property(e => e.DcdName1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DCD_Name1");
            entity.Property(e => e.DwdFullNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DWD_FullNumber");
            entity.Property(e => e.DwdId).HasColumnName("DWD_ID");
            entity.Property(e => e.Expiration)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoObjectsType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RO_ObjectsTypes", "do");

            entity.Property(e => e.DfhArchives).HasColumnName("DFH_Archives");
            entity.Property(e => e.DfhCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("DFH_CreateDate");
            entity.Property(e => e.DfhId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DFH_Id");
            entity.Property(e => e.DfhName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DFH_Name");
            entity.Property(e => e.DfhPrefix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DFH_Prefix");
        });

        modelBuilder.Entity<RoStageActive>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RO_StageActive", "do");

            entity.Property(e => e.DdsId).HasColumnName("DDS_ID");
            entity.Property(e => e.DdsName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DDS_Name");
            entity.Property(e => e.DfhId).HasColumnName("DFH_Id");
            entity.Property(e => e.DshId).HasColumnName("DSH_ID");
            entity.Property(e => e.DwdId).HasColumnName("DWD_ID");
            entity.Property(e => e.DwsCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("DWS_CreateDate");
            entity.Property(e => e.DwsDcdpersonId).HasColumnName("DWS_DCDPersonId");
            entity.Property(e => e.DwsId).HasColumnName("DWS_ID");
            entity.Property(e => e.DwsIsCurrent).HasColumnName("DWS_IsCurrent");
        });

        modelBuilder.Entity<RoStageAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RO_StageAll", "do");

            entity.Property(e => e.DdsId).HasColumnName("DDS_ID");
            entity.Property(e => e.DdsName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DDS_Name");
            entity.Property(e => e.DfhId).HasColumnName("DFH_Id");
            entity.Property(e => e.DshId).HasColumnName("DSH_ID");
            entity.Property(e => e.DwdId).HasColumnName("DWD_ID");
            entity.Property(e => e.DwsCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("DWS_CreateDate");
            entity.Property(e => e.DwsDcdpersonId).HasColumnName("DWS_DCDPersonId");
            entity.Property(e => e.DwsId).HasColumnName("DWS_ID");
            entity.Property(e => e.DwsIsCurrent).HasColumnName("DWS_IsCurrent");
        });

        modelBuilder.Entity<RsGroup>(entity =>
        {
            entity.HasKey(e => e.RgrId);

            entity.ToTable("RS_Groups", "do");

            entity.Property(e => e.RgrId).HasColumnName("RGR_ID");
            entity.Property(e => e.RgrArchival)
                .HasDefaultValue(false)
                .HasColumnName("RGR_Archival");
            entity.Property(e => e.RgrName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RGR_Name");
        });

        modelBuilder.Entity<RsReservation>(entity =>
        {
            entity.HasKey(e => e.RrvId);

            entity.ToTable("RS_Reservations", "do");

            entity.Property(e => e.RrvId).HasColumnName("RRV_ID");
            entity.Property(e => e.RrvArchival)
                .HasDefaultValue(false)
                .HasColumnName("RRV_Archival");
            entity.Property(e => e.RrvCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("RRV_CreatedAt");
            entity.Property(e => e.RrvDcdid).HasColumnName("RRV_DCDID");
            entity.Property(e => e.RrvName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RRV_Name");
            entity.Property(e => e.RrvReservationEnd)
                .HasColumnType("datetime")
                .HasColumnName("RRV_ReservationEnd");
            entity.Property(e => e.RrvReservationStart)
                .HasColumnType("datetime")
                .HasColumnName("RRV_ReservationStart");
            entity.Property(e => e.RrvRrsid).HasColumnName("RRV_RRSID");
        });

        modelBuilder.Entity<RsResource>(entity =>
        {
            entity.HasKey(e => e.RrsId);

            entity.ToTable("RS_Resources", "do");

            entity.Property(e => e.RrsId).HasColumnName("RRS_ID");
            entity.Property(e => e.RrsArchival)
                .HasDefaultValue(false)
                .HasColumnName("RRS_Archival");
            entity.Property(e => e.RrsIsGlobal)
                .HasDefaultValue(false)
                .HasColumnName("RRS_IsGlobal");
            entity.Property(e => e.RrsName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RRS_Name");
            entity.Property(e => e.RrsRgrid)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("RRS_RGRID");
        });

        modelBuilder.Entity<RsResourceCompany>(entity =>
        {
            entity.HasKey(e => e.RrcId);

            entity.ToTable("RS_ResourceCompanies", "do");

            entity.Property(e => e.RrcId).HasColumnName("RRC_ID");
            entity.Property(e => e.RrcCompanyId).HasColumnName("RRC_CompanyId");
            entity.Property(e => e.RrcRrsid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RRC_RRSID");
        });

        modelBuilder.Entity<SbCustomQuery>(entity =>
        {
            entity.HasKey(e => e.ToqId);

            entity.ToTable("SB_CustomQueries", "do");

            entity.Property(e => e.ToqId).HasColumnName("TOQ_Id");
            entity.Property(e => e.ToqDatabaseType).HasColumnName("TOQ_DatabaseType");
            entity.Property(e => e.ToqIsRunQuery).HasColumnName("TOQ_IsRunQuery");
            entity.Property(e => e.ToqName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOQ_Name");
            entity.Property(e => e.ToqObjectType).HasColumnName("TOQ_ObjectType");
            entity.Property(e => e.ToqSqlquery)
                .IsUnicode(false)
                .HasColumnName("TOQ_SQLQuery");
        });

        modelBuilder.Entity<SbSession>(entity =>
        {
            entity.HasKey(e => e.SbsId);

            entity.ToTable("SB_Sessions", "do");

            entity.Property(e => e.SbsId).HasColumnName("SBS_Id");
            entity.Property(e => e.SbsDcdid).HasColumnName("SBS_DCDId");
            entity.Property(e => e.SbsGuid).HasColumnName("SBS_Guid");
            entity.Property(e => e.SbsLastActivityTime)
                .HasColumnType("datetime")
                .HasColumnName("SBS_LastActivityTime");
            entity.Property(e => e.SbsStatus).HasColumnName("SBS_Status");
        });

        modelBuilder.Entity<SbSqlquery>(entity =>
        {
            entity.HasKey(e => e.TosId);

            entity.ToTable("SB_SQLQueries", "do");

            entity.Property(e => e.TosId).HasColumnName("TOS_Id");
            entity.Property(e => e.TosArchival)
                .HasDefaultValue(false)
                .HasColumnName("TOS_Archival");
            entity.Property(e => e.TosCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("TOS_CreateDate");
            entity.Property(e => e.TosDcdid).HasColumnName("TOS_DCDId");
            entity.Property(e => e.TosName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TOS_Name");
            entity.Property(e => e.TosSqlquery)
                .IsUnicode(false)
                .HasColumnName("TOS_SQLQuery");
        });

        modelBuilder.Entity<SlDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SL_Docum__3213E83FD0838ECD");

            entity.ToTable("SL_Documents", "do");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.CompanyProgramId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("company_program_id");
            entity.Property(e => e.ContractorCity)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contractor_city");
            entity.Property(e => e.ContractorCountryIso3166a2)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("contractor_country_iso3166a2");
            entity.Property(e => e.ContractorFullName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contractor_full_name");
            entity.Property(e => e.ContractorId).HasColumnName("contractor_id");
            entity.Property(e => e.ContractorNip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contractor_nip");
            entity.Property(e => e.ContractorPostcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contractor_postcode");
            entity.Property(e => e.ContractorProgramId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contractor_program_id");
            entity.Property(e => e.ContractorShortName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contractor_short_name");
            entity.Property(e => e.ContractorStreet)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contractor_street");
            entity.Property(e => e.CorrInvDate).HasColumnName("corr_inv_date");
            entity.Property(e => e.CorrInvNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("corr_inv_num");
            entity.Property(e => e.CurrencyDate).HasColumnName("currency_date");
            entity.Property(e => e.CurrencyFactor)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("currency_factor");
            entity.Property(e => e.CurrencyIso4217)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("currency_iso4217");
            entity.Property(e => e.CurrencyRate)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("currency_rate");
            entity.Property(e => e.CurrencyTable)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("currency_table");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("filename");
            entity.Property(e => e.FolderMonth).HasColumnName("folder_month");
            entity.Property(e => e.FolderYear).HasColumnName("folder_year");
            entity.Property(e => e.IsCashBasis).HasColumnName("is_cash_basis");
            entity.Property(e => e.IsCorrective).HasColumnName("is_corrective");
            entity.Property(e => e.IssueDate).HasColumnName("issue_date");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("number");
            entity.Property(e => e.OcrId).HasColumnName("ocr_id");
            entity.Property(e => e.PaymentDate).HasColumnName("payment_date");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("payment_type");
            entity.Property(e => e.QueueUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("queue_user");
            entity.Property(e => e.ReceiveDate).HasColumnName("receive_date");
            entity.Property(e => e.Registry)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("registry");
            entity.Property(e => e.SaldeoSyncCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("saldeo_sync_create_date");
            entity.Property(e => e.SaleDate).HasColumnName("sale_date");
            entity.Property(e => e.SourceContent)
                .HasColumnType("image")
                .HasColumnName("source_content");
            entity.Property(e => e.Sum)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("sum");
        });

        modelBuilder.Entity<SlDocumentBankAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SL_Docum__3213E83F4E76F63D");

            entity.ToTable("SL_Document_Bank_Accounts", "do");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.Number)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("number");

            entity.HasOne(d => d.Document).WithMany(p => p.SlDocumentBankAccounts)
                .HasForeignKey(d => d.DocumentId)
                .HasConstraintName("FK__SL_Docume__docum__11D4A34F");
        });

        modelBuilder.Entity<SlDocumentItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SL_Docum__3213E83F24EA43DF");

            entity.ToTable("SL_Document_Items", "do");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.Gross)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("gross");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Netto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("netto");
            entity.Property(e => e.Unit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("unit");
            entity.Property(e => e.UnitValue)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("unit_value");
            entity.Property(e => e.Vat)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("vat");
            entity.Property(e => e.VatLabel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vat_label");
            entity.Property(e => e.VatRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("vat_rate");

            entity.HasOne(d => d.Document).WithMany(p => p.SlDocumentItems)
                .HasForeignKey(d => d.DocumentId)
                .HasConstraintName("FK__SL_Docume__docum__1A69E950");
        });

        modelBuilder.Entity<SlDocumentVatRegistry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SL_Docum__3213E83F0166304F");

            entity.ToTable("SL_Document_Vat_Registries", "do");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.Netto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("netto");
            entity.Property(e => e.Vat)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("vat");
            entity.Property(e => e.VatLabel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vat_label");
            entity.Property(e => e.VatRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("vat_rate");

            entity.HasOne(d => d.Document).WithMany(p => p.SlDocumentVatRegistries)
                .HasForeignKey(d => d.DocumentId)
                .HasConstraintName("FK__SL_Docume__docum__14B10FFA");
        });

        modelBuilder.Entity<SlError>(entity =>
        {
            entity.HasKey(e => e.SleId);

            entity.ToTable("SL_Errors", "do");

            entity.Property(e => e.SleId).HasColumnName("SLE_Id");
            entity.Property(e => e.SleApdid).HasColumnName("SLE_APDId");
            entity.Property(e => e.SleCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("SLE_CreateDate");
            entity.Property(e => e.SleMessage).HasColumnName("SLE_Message");
            entity.Property(e => e.SleOperatorId).HasColumnName("SLE_OperatorId");
        });

        modelBuilder.Entity<SlItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SL_Items__3213E83F7ADED6C4");

            entity.ToTable("SL_Items", "do");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.Extraction).HasColumnName("extraction");
            entity.Property(e => e.Netto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("netto");
            entity.Property(e => e.Registry)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("registry");
            entity.Property(e => e.Vat)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("vat");
            entity.Property(e => e.VatLabel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vat_label");
            entity.Property(e => e.VatRate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("vat_rate");

            entity.HasOne(d => d.Document).WithMany(p => p.SlItems)
                .HasForeignKey(d => d.DocumentId)
                .HasConstraintName("FK__SL_Items__docume__178D7CA5");
        });

        modelBuilder.Entity<SlWorkApprocess>(entity =>
        {
            entity.HasKey(e => e.SlwId);

            entity.ToTable("SL_WorkAPProcess", "do");

            entity.Property(e => e.SlwId).HasColumnName("SLW_Id");
            entity.Property(e => e.SlwApdid).HasColumnName("SLW_APDId");
            entity.Property(e => e.SlwArchival).HasColumnName("SLW_Archival");
            entity.Property(e => e.SlwCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("SLW_CreateDate");
            entity.Property(e => e.SlwDocumentId).HasColumnName("SLW_DocumentId");
            entity.Property(e => e.SlwLocalFileName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("SLW_LocalFileName");
            entity.Property(e => e.SlwMessage).HasColumnName("SLW_Message");
            entity.Property(e => e.SlwOcrOriginId).HasColumnName("SLW_OcrOriginId");
            entity.Property(e => e.SlwOperatorId).HasColumnName("SLW_OperatorId");
            entity.Property(e => e.SlwStatus).HasColumnName("SLW_Status");
        });

        modelBuilder.Entity<Sysdiagram>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sysdiagrams", "do");

            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.DiagramId).HasColumnName("diagram_id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.PrincipalId).HasColumnName("principal_id");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
