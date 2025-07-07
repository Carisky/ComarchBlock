using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class Comarch_BI_TEST_LOGContext : DbContext
{
    public Comarch_BI_TEST_LOGContext(DbContextOptions<Comarch_BI_TEST_LOGContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CorrectionsLog> CorrectionsLogs { get; set; }

    public virtual DbSet<DbVersion> DbVersions { get; set; }

    public virtual DbSet<DictionaryEventsLog> DictionaryEventsLogs { get; set; }

    public virtual DbSet<DqException> DqExceptions { get; set; }

    public virtual DbSet<DqOutput> DqOutputs { get; set; }

    public virtual DbSet<DqParameter> DqParameters { get; set; }

    public virtual DbSet<DqRule> DqRules { get; set; }

    public virtual DbSet<Error> Errors { get; set; }

    public virtual DbSet<ErrorList> ErrorLists { get; set; }

    public virtual DbSet<EtlImportResult> EtlImportResults { get; set; }

    public virtual DbSet<EtlServiceLog> EtlServiceLogs { get; set; }

    public virtual DbSet<FtpAnalizeResult> FtpAnalizeResults { get; set; }

    public virtual DbSet<FtpAnalizeStatus> FtpAnalizeStatuses { get; set; }

    public virtual DbSet<FtpAnalizeType> FtpAnalizeTypes { get; set; }

    public virtual DbSet<FtpFilesAnalize> FtpFilesAnalizes { get; set; }

    public virtual DbSet<FtpFilesAnalizeStatus> FtpFilesAnalizeStatuses { get; set; }

    public virtual DbSet<FtpFilesExtension> FtpFilesExtensions { get; set; }

    public virtual DbSet<FtpMatchingFile> FtpMatchingFiles { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Level> Levels { get; set; }

    public virtual DbSet<LogAction> LogActions { get; set; }

    public virtual DbSet<LogActionGroup> LogActionGroups { get; set; }

    public virtual DbSet<LogActionTranslation> LogActionTranslations { get; set; }

    public virtual DbSet<NextHighVaue> NextHighVaues { get; set; }

    public virtual DbSet<OperationType> OperationTypes { get; set; }

    public virtual DbSet<PendingChange> PendingChanges { get; set; }

    public virtual DbSet<Process> Processes { get; set; }

    public virtual DbSet<ProcessEvent> ProcessEvents { get; set; }

    public virtual DbSet<ProcessMeasurementLog> ProcessMeasurementLogs { get; set; }

    public virtual DbSet<ProcessType> ProcessTypes { get; set; }

    public virtual DbSet<ProfilerEntriesProperty> ProfilerEntriesProperties { get; set; }

    public virtual DbSet<ProfilerEntry> ProfilerEntries { get; set; }

    public virtual DbSet<SamplesLog> SamplesLogs { get; set; }

    public virtual DbSet<ServiceLog> ServiceLogs { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<TemporaryProcessEvent> TemporaryProcessEvents { get; set; }

    public virtual DbSet<TerminationStatusType> TerminationStatusTypes { get; set; }

    public virtual DbSet<Transformation> Transformations { get; set; }

    public virtual DbSet<TransformationType> TransformationTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CorrectionsLog>(entity =>
        {
            entity.HasKey(e => e.ClgId);

            entity.Property(e => e.ClgId).HasColumnName("CLG_ID");
            entity.Property(e => e.ClgCorrectionId).HasColumnName("CLG_CorrectionID");
            entity.Property(e => e.ClgFactTableId).HasColumnName("CLG_FactTableID");
            entity.Property(e => e.ClgFieldId).HasColumnName("CLG_FieldID");
            entity.Property(e => e.ClgFieldName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLG_FieldName");
            entity.Property(e => e.ClgFieldRole)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLG_FieldRole");
            entity.Property(e => e.ClgModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("CLG_ModificationDate");
            entity.Property(e => e.ClgNewValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CLG_NewValue");
            entity.Property(e => e.ClgOldValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CLG_OldValue");
            entity.Property(e => e.ClgTsinsert)
                .HasColumnType("datetime")
                .HasColumnName("CLG_TSInsert");
            entity.Property(e => e.ClgUpdater)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLG_Updater");
        });

        modelBuilder.Entity<DbVersion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DbVersion", "log");

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

        modelBuilder.Entity<DictionaryEventsLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK_Dictionary_Event_Logs");

            entity.ToTable("Dictionary_Events_Logs");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.NewValue)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DqException>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DQ_Exceptions");

            entity.Property(e => e.DqeDateFrom).HasColumnName("DQE_DateFrom");
            entity.Property(e => e.DqeDateTo).HasColumnName("DQE_DateTo");
            entity.Property(e => e.DqeDqcode).HasColumnName("DQE_DQCode");
            entity.Property(e => e.DqeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DQE_ID");
            entity.Property(e => e.DqeIsActive).HasColumnName("DQE_IsActive");
            entity.Property(e => e.DqeName1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DQE_Name1");
            entity.Property(e => e.DqeName2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DQE_Name2");
            entity.Property(e => e.DqeOperator1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DQE_Operator1");
            entity.Property(e => e.DqeOperator2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DQE_Operator2");
            entity.Property(e => e.DqeValue1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DQE_Value1");
            entity.Property(e => e.DqeValue2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DQE_Value2");
        });

        modelBuilder.Entity<DqOutput>(entity =>
        {
            entity.HasKey(e => e.DqoId).HasName("PK__DQ_Outpu__B687A16B3BFFE745");

            entity.ToTable("DQ_Output");

            entity.Property(e => e.DqoId).HasColumnName("DQO_ID");
            entity.Property(e => e.DqoColumnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DQO_ColumnName");
            entity.Property(e => e.DqoDescription)
                .HasMaxLength(300)
                .HasColumnName("DQO_Description");
            entity.Property(e => e.DqoDiff)
                .HasColumnType("decimal(25, 10)")
                .HasColumnName("DQO_Diff");
            entity.Property(e => e.DqoDqrcode).HasColumnName("DQO_DQRCode");
            entity.Property(e => e.DqoExecutionDate)
                .HasColumnType("datetime")
                .HasColumnName("DQO_ExecutionDate");
            entity.Property(e => e.DqoExpectedValue)
                .HasColumnType("decimal(25, 10)")
                .HasColumnName("DQO_ExpectedValue");
            entity.Property(e => e.DqoResult).HasColumnName("DQO_Result");
            entity.Property(e => e.DqoRuleStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DQO_RuleStatus");
            entity.Property(e => e.DqoTableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DQO_TableName");
            entity.Property(e => e.DqoTransformationId).HasColumnName("DQO_TransformationID");
            entity.Property(e => e.DqoValue)
                .HasColumnType("decimal(25, 10)")
                .HasColumnName("DQO_Value");

            entity.HasOne(d => d.DqoDqrcodeNavigation).WithMany(p => p.DqOutputs)
                .HasForeignKey(d => d.DqoDqrcode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DQ_Output_DQ_Rules");
        });

        modelBuilder.Entity<DqParameter>(entity =>
        {
            entity.HasKey(e => e.DqpId);

            entity.ToTable("DQ_Parameters");

            entity.Property(e => e.DqpId).HasColumnName("DQP_ID");
            entity.Property(e => e.DqpDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DQP_Description");
            entity.Property(e => e.DqpDqrcode).HasColumnName("DQP_DQRCode");
            entity.Property(e => e.DqpName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DQP_Name");
            entity.Property(e => e.DqpValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DQP_Value");
        });

        modelBuilder.Entity<DqRule>(entity =>
        {
            entity.HasKey(e => e.DqrCode);

            entity.ToTable("DQ_Rules");

            entity.Property(e => e.DqrCode)
                .ValueGeneratedNever()
                .HasColumnName("DQR_Code");
            entity.Property(e => e.DqrActive).HasColumnName("DQR_Active");
            entity.Property(e => e.DqrDependent).HasColumnName("DQR_Dependent");
            entity.Property(e => e.DqrDescription)
                .HasMaxLength(600)
                .HasColumnName("DQR_Description");
            entity.Property(e => e.DqrExpectedValue)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("DQR_ExpectedValue");
            entity.Property(e => e.DqrIsStandard).HasColumnName("DQR_IsStandard");
            entity.Property(e => e.DqrLevel)
                .HasMaxLength(50)
                .HasColumnName("DQR_Level");
            entity.Property(e => e.DqrName)
                .HasMaxLength(100)
                .HasColumnName("DQR_Name");
            entity.Property(e => e.DqrOrder).HasColumnName("DQR_Order");
            entity.Property(e => e.DqrType)
                .HasMaxLength(50)
                .HasColumnName("DQR_Type");
            entity.Property(e => e.DqrWarningFrom).HasColumnName("DQR_WarningFrom");
            entity.Property(e => e.DqrWarningTo).HasColumnName("DQR_WarningTo");
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.ToTable("Error");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.InnerMessage)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Level)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Message)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<ErrorList>(entity =>
        {
            entity.HasKey(e => e.EliId).HasName("PK_ErrorList_1");

            entity.ToTable("ErrorList");

            entity.Property(e => e.EliId).HasColumnName("ELI_ID");
            entity.Property(e => e.EliDescription).HasColumnName("ELI_Description");
            entity.Property(e => e.EliErrorCode).HasColumnName("ELI_ErrorCode");
            entity.Property(e => e.EliLanId)
                .HasMaxLength(50)
                .HasColumnName("ELI_LAN_ID");
            entity.Property(e => e.EliMessage).HasColumnName("ELI_Message");
            entity.Property(e => e.EliTableLinkId).HasColumnName("ELI_TableLinkId");
        });

        modelBuilder.Entity<EtlImportResult>(entity =>
        {
            entity.HasKey(e => e.EirId);

            entity.HasIndex(e => e.EirPevtid, "IX_EIR_PEVTID");

            entity.Property(e => e.EirId)
                .ValueGeneratedNever()
                .HasColumnName("EIR_ID");
            entity.Property(e => e.EirDeletedRowBegin)
                .HasColumnType("datetime")
                .HasColumnName("EIR_DeletedRowBegin");
            entity.Property(e => e.EirDeletedRowCount).HasColumnName("EIR_DeletedRowCount");
            entity.Property(e => e.EirDeletedRowEnd)
                .HasColumnType("datetime")
                .HasColumnName("EIR_DeletedRowEnd");
            entity.Property(e => e.EirEtlcnid).HasColumnName("EIR_ETLCNID");
            entity.Property(e => e.EirFtpFileId).HasColumnName("EIR_FtpFileID");
            entity.Property(e => e.EirInsertedAtTransRowCount).HasColumnName("EIR_InsertedAtTransRowCount");
            entity.Property(e => e.EirInsertedRowCount).HasColumnName("EIR_InsertedRowCount");
            entity.Property(e => e.EirInvalidRowCount).HasColumnName("EIR_InvalidRowCount");
            entity.Property(e => e.EirInvalidRows)
                .HasColumnType("text")
                .HasColumnName("EIR_InvalidRows");
            entity.Property(e => e.EirInvalidRowsSchema)
                .HasColumnType("text")
                .HasColumnName("EIR_InvalidRowsSchema");
            entity.Property(e => e.EirPevtid).HasColumnName("EIR_PEVTID");
            entity.Property(e => e.EirReadRowCount).HasColumnName("EIR_ReadRowCount");
            entity.Property(e => e.EirRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("EIR_RowVersion");
            entity.Property(e => e.EirTableLinkId).HasColumnName("EIR_TableLinkID");
            entity.Property(e => e.EirUpdatedAtTransRowCount).HasColumnName("EIR_UpdatedAtTransRowCount");
            entity.Property(e => e.EirUpdatedRowCount).HasColumnName("EIR_UpdatedRowCount");

            entity.HasOne(d => d.EirPevt).WithMany(p => p.EtlImportResults)
                .HasForeignKey(d => d.EirPevtid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EIR_PPEVTID_ProcesseEvents");
        });

        modelBuilder.Entity<EtlServiceLog>(entity =>
        {
            entity.HasKey(e => e.SloId);

            entity.Property(e => e.SloId).HasColumnName("SLO_Id");
            entity.Property(e => e.SloAction)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SLO_Action");
            entity.Property(e => e.SloCompanyId).HasColumnName("SLO_CompanyId");
            entity.Property(e => e.SloController)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("SLO_Controller");
            entity.Property(e => e.SloDate)
                .HasColumnType("datetime")
                .HasColumnName("SLO_Date");
            entity.Property(e => e.SloDetails)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("SLO_Details");
            entity.Property(e => e.SloDuration).HasColumnName("SLO_Duration");
            entity.Property(e => e.SloException)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("SLO_Exception");
            entity.Property(e => e.SloLevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SLO_Level");
            entity.Property(e => e.SloLogger)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SLO_Logger");
            entity.Property(e => e.SloMessage)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("SLO_Message");
            entity.Property(e => e.SloThread)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SLO_Thread");
            entity.Property(e => e.SloUser)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SLO_User");
        });

        modelBuilder.Entity<FtpAnalizeResult>(entity =>
        {
            entity.HasKey(e => e.FarId).HasName("PK__FtpAnalizeResult__42E1EEFE");

            entity.ToTable("FtpAnalizeResult");

            entity.Property(e => e.FarId).HasColumnName("FAR_ID");
            entity.Property(e => e.FarAnalizeDirectory)
                .IsUnicode(false)
                .HasColumnName("FAR_AnalizeDirectory");
            entity.Property(e => e.FarAnalizedFilesCount).HasColumnName("FAR_AnalizedFilesCount");
            entity.Property(e => e.FarFasId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FAR_FAS_ID");
            entity.Property(e => e.FarFatId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FAR_FAT_ID");
            entity.Property(e => e.FarFilesCount).HasColumnName("FAR_FilesCount");
            entity.Property(e => e.FarInvalidFilesCount).HasColumnName("FAR_InvalidFilesCount");
            entity.Property(e => e.FarOmittedFilesCout).HasColumnName("FAR_OmittedFilesCout");
            entity.Property(e => e.FarProcid).HasColumnName("FAR_PROCID");
            entity.Property(e => e.FarRightFilesCount).HasColumnName("FAR_RightFilesCount");

            entity.HasOne(d => d.FarFas).WithMany(p => p.FtpAnalizeResults)
                .HasForeignKey(d => d.FarFasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FtpAnalizeResult_FtpAnalizeStatus");

            entity.HasOne(d => d.FarFat).WithMany(p => p.FtpAnalizeResults)
                .HasForeignKey(d => d.FarFatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FtpAnalizeResult_FtpAnalizeType");

            entity.HasOne(d => d.FarProc).WithMany(p => p.FtpAnalizeResults)
                .HasForeignKey(d => d.FarProcid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FtpAnalizeResult_Processes");
        });

        modelBuilder.Entity<FtpAnalizeStatus>(entity =>
        {
            entity.HasKey(e => e.FasId).HasName("PK__FtpAnalizeStatus__3B40CD36");

            entity.ToTable("FtpAnalizeStatus");

            entity.Property(e => e.FasId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FAS_ID");
            entity.Property(e => e.FasName)
                .IsUnicode(false)
                .HasColumnName("FAS_Name");
        });

        modelBuilder.Entity<FtpAnalizeType>(entity =>
        {
            entity.HasKey(e => e.FatId).HasName("PK__FtpAnalizeType__3D2915A8");

            entity.ToTable("FtpAnalizeType");

            entity.Property(e => e.FatId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FAT_ID");
            entity.Property(e => e.FatName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FAT_Name");
        });

        modelBuilder.Entity<FtpFilesAnalize>(entity =>
        {
            entity.HasKey(e => e.FfaId).HasName("PK__FtpFilesAnalize__47A6A41B");

            entity.ToTable("FtpFilesAnalize");

            entity.Property(e => e.FfaId).HasColumnName("FFA_ID");
            entity.Property(e => e.FfaAnalizeMessage)
                .IsUnicode(false)
                .HasColumnName("FFA_AnalizeMessage");
            entity.Property(e => e.FfaDirectoryName)
                .IsUnicode(false)
                .HasColumnName("FFA_DirectoryName");
            entity.Property(e => e.FfaFarId).HasColumnName("FFA_FAR_ID");
            entity.Property(e => e.FfaFfeId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FFA_FFE_ID");
            entity.Property(e => e.FfaFfsId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FFA_FFS_ID");
            entity.Property(e => e.FfaFileCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("FFA_FileCreationDate");
            entity.Property(e => e.FfaFileDataDate)
                .HasColumnType("datetime")
                .HasColumnName("FFA_FileDataDate");
            entity.Property(e => e.FfaFileName)
                .IsUnicode(false)
                .HasColumnName("FFA_FileName");
            entity.Property(e => e.FfaFileSize)
                .IsUnicode(false)
                .HasColumnName("FFA_FileSize");
            entity.Property(e => e.FfaTableLinkId).HasColumnName("FFA_TableLinkID");

            entity.HasOne(d => d.FfaFar).WithMany(p => p.FtpFilesAnalizes)
                .HasForeignKey(d => d.FfaFarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FtpFilesAnalize_FtpAnalizeResult");

            entity.HasOne(d => d.FfaFfe).WithMany(p => p.FtpFilesAnalizes)
                .HasForeignKey(d => d.FfaFfeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FtpFilesAnalize_FtpFilesExtensions");

            entity.HasOne(d => d.FfaFfs).WithMany(p => p.FtpFilesAnalizes)
                .HasForeignKey(d => d.FfaFfsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FtpFilesAnalize_FtpFilesAnalizeStatus");
        });

        modelBuilder.Entity<FtpFilesAnalizeStatus>(entity =>
        {
            entity.HasKey(e => e.FfsId).HasName("PK__FtpFilesAnalizeS__3F115E1A");

            entity.ToTable("FtpFilesAnalizeStatus");

            entity.Property(e => e.FfsId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FFS_ID");
            entity.Property(e => e.FfsName)
                .IsUnicode(false)
                .HasColumnName("FFS_Name");
        });

        modelBuilder.Entity<FtpFilesExtension>(entity =>
        {
            entity.HasKey(e => e.FfeId).HasName("PK__FtpFilesExtensio__40F9A68C");

            entity.Property(e => e.FfeId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FFE_ID");
            entity.Property(e => e.FfeName)
                .IsUnicode(false)
                .HasColumnName("FFE_Name");
        });

        modelBuilder.Entity<FtpMatchingFile>(entity =>
        {
            entity.HasKey(e => e.FmfId);

            entity.Property(e => e.FmfId).HasColumnName("FMF_ID");
            entity.Property(e => e.FmfFileDate)
                .HasColumnType("datetime")
                .HasColumnName("FMF_FileDate");
            entity.Property(e => e.FmfFileExtension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FMF_FileExtension");
            entity.Property(e => e.FmfFileName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("FMF_FileName");
            entity.Property(e => e.FmfFullPath)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("FMF_FullPath");
            entity.Property(e => e.FmfHasCorrectStructure).HasColumnName("FMF_HasCorrectStructure");
            entity.Property(e => e.FmfInsertTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FMF_InsertTime");
            entity.Property(e => e.FmfIsCorrectlyAssigned).HasColumnName("FMF_IsCorrectlyAssigned");
            entity.Property(e => e.FmfIsLoaded).HasColumnName("FMF_IsLoaded");
            entity.Property(e => e.FmfRegexUsed)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("FMF_RegexUsed");
            entity.Property(e => e.FmfTlnid).HasColumnName("FMF_TLNID");
            entity.Property(e => e.FmfTrnid).HasColumnName("FMF_TRNID");

            entity.HasOne(d => d.FmfTrn).WithMany(p => p.FtpMatchingFiles)
                .HasForeignKey(d => d.FmfTrnid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FtpMatchingFiles_Transformations");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.LanId);

            entity.Property(e => e.LanId)
                .HasMaxLength(50)
                .HasColumnName("LAN_ID");
            entity.Property(e => e.LanCodePage).HasColumnName("LAN_CodePage");
            entity.Property(e => e.LanDescription).HasColumnName("LAN_Description");
            entity.Property(e => e.LanName)
                .HasMaxLength(255)
                .HasColumnName("LAN_Name");
        });

        modelBuilder.Entity<Level>(entity =>
        {
            entity.HasKey(e => e.LvlId);

            entity.Property(e => e.LvlId)
                .ValueGeneratedNever()
                .HasColumnName("LVL_ID");
            entity.Property(e => e.LvlName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LVL_Name");
        });

        modelBuilder.Entity<LogAction>(entity =>
        {
            entity.HasKey(e => e.LacId);

            entity.Property(e => e.LacId).HasColumnName("LAC_Id");
            entity.Property(e => e.LacActionId)
                .HasComment("Id of action to group action with different translations")
                .HasColumnName("LAC_ActionId");
            entity.Property(e => e.LacActionName)
                .HasMaxLength(120)
                .HasComment("Name of Action")
                .HasColumnName("LAC_ActionName");
            entity.Property(e => e.LacDateTime)
                .HasComment("Action start date")
                .HasColumnType("datetime")
                .HasColumnName("LAC_DateTime");
            entity.Property(e => e.LacDuration)
                .HasComment("Duration of action in miliseconds")
                .HasColumnName("LAC_Duration");
            entity.Property(e => e.LacException)
                .HasComment("Stack trace of excetion if occured")
                .HasColumnName("LAC_Exception");
            entity.Property(e => e.LacLogActionGroupId).HasColumnName("LAC_LogActionGroupId");
            entity.Property(e => e.LacMessage).HasColumnName("LAC_Message");
            entity.Property(e => e.LacObjectId)
                .HasComment("Object ID which is subject of action")
                .HasColumnName("LAC_ObjectId");
            entity.Property(e => e.LacParameters)
                .HasMaxLength(500)
                .HasComment("ToString() on arguments, additional data for action")
                .HasColumnName("LAC_Parameters");
            entity.Property(e => e.LacSessionId)
                .HasComment("Foreign key to dbo.Sessions")
                .HasColumnName("LAC_SessionId");
            entity.Property(e => e.LacSeverityId)
                .HasComment("Foreign key to dbo.Levels")
                .HasColumnName("LAC_SeverityId");
            entity.Property(e => e.LacShowInRecent)
                .HasDefaultValue(true)
                .HasColumnName("LAC_ShowInRecent");

            entity.HasOne(d => d.LacLogActionGroup).WithMany(p => p.LogActions)
                .HasForeignKey(d => d.LacLogActionGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogActions_LogActionGroup");

            entity.HasOne(d => d.LacSession).WithMany(p => p.LogActions)
                .HasForeignKey(d => d.LacSessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogActions_Sessions");

            entity.HasOne(d => d.LacSeverity).WithMany(p => p.LogActions)
                .HasForeignKey(d => d.LacSeverityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogActions_Levels");
        });

        modelBuilder.Entity<LogActionGroup>(entity =>
        {
            entity.HasKey(e => e.LagId).HasName("PK_LogActionAreas");

            entity.Property(e => e.LagId)
                .ValueGeneratedNever()
                .HasColumnName("LAG_Id");
            entity.Property(e => e.LabProcessType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Foreign key to process type")
                .HasColumnName("LAB_ProcessType");
            entity.Property(e => e.LagName)
                .HasMaxLength(80)
                .HasComment("Action Group name")
                .HasColumnName("LAG_Name");

            entity.HasOne(d => d.LabProcessTypeNavigation).WithMany(p => p.LogActionGroups)
                .HasForeignKey(d => d.LabProcessType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogActionGroup_ProcessTypes");
        });

        modelBuilder.Entity<LogActionTranslation>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.LatId).HasColumnName("LAT_Id");
            entity.Property(e => e.LatLanguage)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LAT_Language");
            entity.Property(e => e.LatValue)
                .HasMaxLength(500)
                .HasColumnName("LAT_Value");
        });

        modelBuilder.Entity<NextHighVaue>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<OperationType>(entity =>
        {
            entity.HasKey(e => e.OtOperation).HasName("PK__OperationTypes__634EBE90");

            entity.Property(e => e.OtOperation)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("OT_Operation");
        });

        modelBuilder.Entity<PendingChange>(entity =>
        {
            entity.HasKey(e => e.PcId).HasName("PK_PendingChanges_Key");

            entity.Property(e => e.PcId).HasColumnName("PC_ID");
            entity.Property(e => e.PcChangedObjId).HasColumnName("PC_ChangedObjID");
            entity.Property(e => e.PcChangedObjTable).HasColumnName("PC_ChangedObjTable");
            entity.Property(e => e.PcModificationTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PC_ModificationTime");
            entity.Property(e => e.PcOtOperation)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PC_OT_Operation");
            entity.Property(e => e.PcPropertyName).HasColumnName("PC_PropertyName");
            entity.Property(e => e.PcPropertyNewVal).HasColumnName("PC_PropertyNewVal");
            entity.Property(e => e.PcPropertyOldVal).HasColumnName("PC_PropertyOldVal");
            entity.Property(e => e.PcUser).HasColumnName("PC_User");

            entity.HasOne(d => d.PcOtOperationNavigation).WithMany(p => p.PendingChanges)
                .HasForeignKey(d => d.PcOtOperation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PendingChanges_OperationTypes");
        });

        modelBuilder.Entity<Process>(entity =>
        {
            entity.HasKey(e => e.ProcId);

            entity.Property(e => e.ProcId)
                .ValueGeneratedNever()
                .HasColumnName("PROC_ID");
            entity.Property(e => e.ProcExecutionEnd)
                .HasColumnType("datetime")
                .HasColumnName("PROC_ExecutionEnd");
            entity.Property(e => e.ProcExecutionStart)
                .HasColumnType("datetime")
                .HasColumnName("PROC_ExecutionStart");
            entity.Property(e => e.ProcName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PROC_Name");
            entity.Property(e => e.ProcRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("PROC_RowVersion");
            entity.Property(e => e.ProcTerminationStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROC_TerminationStatus");
            entity.Property(e => e.ProcTrnid).HasColumnName("PROC_TRNID");
            entity.Property(e => e.ProcType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROC_Type");

            entity.HasOne(d => d.ProcTerminationStatusNavigation).WithMany(p => p.Processes)
                .HasForeignKey(d => d.ProcTerminationStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROC_TerminationStatus_TerminationStatusTypes");

            entity.HasOne(d => d.ProcTrn).WithMany(p => p.Processes)
                .HasForeignKey(d => d.ProcTrnid)
                .HasConstraintName("FK_PROC_TRNID_Transformations");

            entity.HasOne(d => d.ProcTypeNavigation).WithMany(p => p.Processes)
                .HasForeignKey(d => d.ProcType)
                .HasConstraintName("FK_PROC_Type_ProcessTypes");
        });

        modelBuilder.Entity<ProcessEvent>(entity =>
        {
            entity.HasKey(e => e.PevtId);

            entity.Property(e => e.PevtId)
                .ValueGeneratedNever()
                .HasColumnName("PEVT_ID");
            entity.Property(e => e.PevtContext)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PEVT_Context");
            entity.Property(e => e.PevtException).HasColumnName("PEVT_Exception");
            entity.Property(e => e.PevtExecutionEnd)
                .HasColumnType("datetime")
                .HasColumnName("PEVT_ExecutionEnd");
            entity.Property(e => e.PevtExecutionStart)
                .HasColumnType("datetime")
                .HasColumnName("PEVT_ExecutionStart");
            entity.Property(e => e.PevtIsPackage).HasColumnName("PEVT_IsPackage");
            entity.Property(e => e.PevtIsTask).HasColumnName("PEVT_IsTask");
            entity.Property(e => e.PevtLevel).HasColumnName("PEVT_Level");
            entity.Property(e => e.PevtLoggerName)
                .HasMaxLength(512)
                .HasDefaultValue("<None>")
                .HasColumnName("PEVT_LoggerName");
            entity.Property(e => e.PevtMessage)
                .HasDefaultValue("<None>")
                .HasColumnName("PEVT_Message");
            entity.Property(e => e.PevtNodeDepth).HasColumnName("PEVT_NodeDepth");
            entity.Property(e => e.PevtParent).HasColumnName("PEVT_Parent");
            entity.Property(e => e.PevtProcid)
                .HasDefaultValue(-1L)
                .HasColumnName("PEVT_PROCID");
            entity.Property(e => e.PevtRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("PEVT_RowVersion");
            entity.Property(e => e.PevtSubTransformationId).HasColumnName("PEVT_SubTransformationID");
            entity.Property(e => e.PevtTableLinkId).HasColumnName("PEVT_TableLinkId");
            entity.Property(e => e.PevtTsinsert)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PEVT_TSInsert");

            entity.HasOne(d => d.PevtLevelNavigation).WithMany(p => p.ProcessEvents)
                .HasForeignKey(d => d.PevtLevel)
                .HasConstraintName("FK_PEVT_Level_ProcessEvents");

            entity.HasOne(d => d.PevtProc).WithMany(p => p.ProcessEvents)
                .HasForeignKey(d => d.PevtProcid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEVT_PROCID_Processes");
        });

        modelBuilder.Entity<ProcessMeasurementLog>(entity =>
        {
            entity.HasKey(e => e.PmlId).HasName("PK__ProcessM__8DE5FDE815DA3E5D");

            entity.ToTable("ProcessMeasurementLog");

            entity.Property(e => e.PmlId).HasColumnName("PML_ID");
            entity.Property(e => e.PmlCompression)
                .HasMaxLength(255)
                .HasColumnName("PML_Compression");
            entity.Property(e => e.PmlCounterCategory)
                .HasMaxLength(200)
                .HasColumnName("PML_CounterCategory");
            entity.Property(e => e.PmlCounterName)
                .HasMaxLength(200)
                .HasColumnName("PML_CounterName");
            entity.Property(e => e.PmlFinishDate)
                .HasColumnType("datetime")
                .HasColumnName("PML_FinishDate");
            entity.Property(e => e.PmlInstance)
                .HasMaxLength(200)
                .HasColumnName("PML_Instance");
            entity.Property(e => e.PmlInterval).HasColumnName("PML_Interval");
            entity.Property(e => e.PmlPreCompressionSize).HasColumnName("PML_PreCompressionSize");
            entity.Property(e => e.PmlProcessName)
                .HasMaxLength(200)
                .HasColumnName("PML_ProcessName");
            entity.Property(e => e.PmlStartDate)
                .HasColumnType("datetime")
                .HasColumnName("PML_StartDate");
            entity.Property(e => e.PmlTrnid).HasColumnName("PML_TRNID");

            entity.HasOne(d => d.PmlTrn).WithMany(p => p.ProcessMeasurementLogs)
                .HasForeignKey(d => d.PmlTrnid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PML_TRN");
        });

        modelBuilder.Entity<ProcessType>(entity =>
        {
            entity.HasKey(e => e.ProtId);

            entity.Property(e => e.ProtId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROT_ID");
            entity.Property(e => e.ProtName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROT_Name");
        });

        modelBuilder.Entity<ProfilerEntriesProperty>(entity =>
        {
            entity.HasKey(e => e.PepId).HasName("PK__Profiler__21FF546011158940");

            entity.Property(e => e.PepId).HasColumnName("PEP_Id");
            entity.Property(e => e.PepEntryId).HasColumnName("PEP_EntryId");
            entity.Property(e => e.PepName).HasColumnName("PEP_Name");
            entity.Property(e => e.PepValue).HasColumnName("PEP_Value");

            entity.HasOne(d => d.PepEntry).WithMany(p => p.ProfilerEntriesProperties)
                .HasForeignKey(d => d.PepEntryId)
                .HasConstraintName("FK_ProfilerEntries");
        });

        modelBuilder.Entity<ProfilerEntry>(entity =>
        {
            entity.HasKey(e => e.PenId).HasName("PK__Profiler__67EE5EB60D44F85C");

            entity.Property(e => e.PenId).HasColumnName("PEN_Id");
            entity.Property(e => e.PenApplicationName).HasColumnName("PEN_ApplicationName");
            entity.Property(e => e.PenBegin).HasColumnName("PEN_Begin");
            entity.Property(e => e.PenBeginTime)
                .HasColumnType("datetime")
                .HasColumnName("PEN_BeginTime");
            entity.Property(e => e.PenClientIp).HasColumnName("PEN_ClientIP");
            entity.Property(e => e.PenConnectionId).HasColumnName("PEN_ConnectionId");
            entity.Property(e => e.PenEndTime)
                .HasColumnType("datetime")
                .HasColumnName("PEN_EndTime");
            entity.Property(e => e.PenEventClass).HasColumnName("PEN_EventClass");
            entity.Property(e => e.PenLanguage).HasColumnName("PEN_Language");
            entity.Property(e => e.PenLevel).HasColumnName("PEN_Level");
            entity.Property(e => e.PenMessage).HasColumnName("PEN_Message");
            entity.Property(e => e.PenModel).HasColumnName("PEN_Model");
            entity.Property(e => e.PenPassword).HasColumnName("PEN_Password");
            entity.Property(e => e.PenSessionId).HasColumnName("PEN_SessionId");
            entity.Property(e => e.PenUsername).HasColumnName("PEN_Username");
        });

        modelBuilder.Entity<SamplesLog>(entity =>
        {
            entity.HasKey(e => new { e.SmplPmlid, e.SmplIndex }).HasName("PK__SamplesL__E8D849811A9EF37A");

            entity.ToTable("SamplesLog");

            entity.Property(e => e.SmplPmlid).HasColumnName("SMPL_PMLID");
            entity.Property(e => e.SmplIndex).HasColumnName("SMPL_Index");
            entity.Property(e => e.SmplValue).HasColumnName("SMPL_Value");

            entity.HasOne(d => d.SmplPml).WithMany(p => p.SamplesLogs)
                .HasForeignKey(d => d.SmplPmlid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMPL_PML");
        });

        modelBuilder.Entity<ServiceLog>(entity =>
        {
            entity.HasKey(e => e.SloId);

            entity.Property(e => e.SloId).HasColumnName("SLO_Id");
            entity.Property(e => e.SloAction)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SLO_Action");
            entity.Property(e => e.SloCompanyId).HasColumnName("SLO_CompanyId");
            entity.Property(e => e.SloController)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("SLO_Controller");
            entity.Property(e => e.SloDate)
                .HasColumnType("datetime")
                .HasColumnName("SLO_Date");
            entity.Property(e => e.SloDetails)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("SLO_Details");
            entity.Property(e => e.SloDuration).HasColumnName("SLO_Duration");
            entity.Property(e => e.SloException)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("SLO_Exception");
            entity.Property(e => e.SloLevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SLO_Level");
            entity.Property(e => e.SloLogger)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SLO_Logger");
            entity.Property(e => e.SloMessage)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("SLO_Message");
            entity.Property(e => e.SloThread)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SLO_Thread");
            entity.Property(e => e.SloUser)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SLO_User");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.SesId);

            entity.Property(e => e.SesId)
                .ValueGeneratedNever()
                .HasColumnName("SES_ID");
            entity.Property(e => e.SesCompanyId).HasColumnName("SES_CompanyId");
            entity.Property(e => e.SesCompanyName)
                .HasMaxLength(100)
                .HasColumnName("SES_CompanyName");
            entity.Property(e => e.SesDescription)
                .HasMaxLength(150)
                .HasColumnName("SES_Description");
            entity.Property(e => e.SesLoginDate)
                .HasColumnType("datetime")
                .HasColumnName("SES_LoginDate");
            entity.Property(e => e.SesLogoutDate)
                .HasColumnType("datetime")
                .HasColumnName("SES_LogoutDate");
            entity.Property(e => e.SesMachineIp)
                .HasMaxLength(15)
                .HasColumnName("SES_MachineIP");
            entity.Property(e => e.SesMachineName)
                .HasMaxLength(150)
                .HasColumnName("SES_MachineName");
            entity.Property(e => e.SesRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SES_RowVersion");
            entity.Property(e => e.SesUserId).HasColumnName("SES_UserId");
            entity.Property(e => e.SesUserLogin)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("SES_UserLogin");
        });

        modelBuilder.Entity<TemporaryProcessEvent>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TpeDeletedRowBegin)
                .HasColumnType("datetime")
                .HasColumnName("TPE_DeletedRowBegin");
            entity.Property(e => e.TpeDeletedRowCount).HasColumnName("TPE_DeletedRowCount");
            entity.Property(e => e.TpeDeletedRowEnd)
                .HasColumnType("datetime")
                .HasColumnName("TPE_DeletedRowEnd");
            entity.Property(e => e.TpeExecutionEnd)
                .HasColumnType("datetime")
                .HasColumnName("TPE_ExecutionEnd");
            entity.Property(e => e.TpeExecutionStart)
                .HasColumnType("datetime")
                .HasColumnName("TPE_ExecutionStart");
            entity.Property(e => e.TpeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TPE_ID");
            entity.Property(e => e.TpeInsertedAtTransRowCount).HasColumnName("TPE_InsertedAtTransRowCount");
            entity.Property(e => e.TpeInsertedRowCount).HasColumnName("TPE_InsertedRowCount");
            entity.Property(e => e.TpeInvalidRowCount).HasColumnName("TPE_InvalidRowCount");
            entity.Property(e => e.TpeLevel).HasColumnName("TPE_Level");
            entity.Property(e => e.TpeMessage).HasColumnName("TPE_Message");
            entity.Property(e => e.TpeReadRowCount).HasColumnName("TPE_ReadRowCount");
            entity.Property(e => e.TpeTransformationId).HasColumnName("TPE_TransformationID");
            entity.Property(e => e.TpeUpdatedAtTransRowCount).HasColumnName("TPE_UpdatedAtTransRowCount");
            entity.Property(e => e.TpeUpdatedRowCount).HasColumnName("TPE_UpdatedRowCount");
        });

        modelBuilder.Entity<TerminationStatusType>(entity =>
        {
            entity.HasKey(e => e.TstId);

            entity.Property(e => e.TstId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TST_ID");
            entity.Property(e => e.TstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TST_Name");
        });

        modelBuilder.Entity<Transformation>(entity =>
        {
            entity.HasKey(e => e.TrnId);

            entity.Property(e => e.TrnId)
                .ValueGeneratedNever()
                .HasColumnName("TRN_ID");
            entity.Property(e => e.TrnExecutionEnd)
                .HasColumnType("datetime")
                .HasColumnName("TRN_ExecutionEnd");
            entity.Property(e => e.TrnExecutionStart)
                .HasColumnType("datetime")
                .HasColumnName("TRN_ExecutionStart");
            entity.Property(e => e.TrnParametersSet)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TRN_ParametersSet");
            entity.Property(e => e.TrnRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TRN_RowVersion");
            entity.Property(e => e.TrnSesid).HasColumnName("TRN_SESID");
            entity.Property(e => e.TrnTerminationStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TRN_TerminationStatus");
            entity.Property(e => e.TrnTrntid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TRN_TRNTID");
            entity.Property(e => e.TrnTsinsert)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TRN_TSInsert");

            entity.HasOne(d => d.TrnSes).WithMany(p => p.Transformations)
                .HasForeignKey(d => d.TrnSesid)
                .HasConstraintName("FK_TRN_SESIDID_Sessions");

            entity.HasOne(d => d.TrnTerminationStatusNavigation).WithMany(p => p.Transformations)
                .HasForeignKey(d => d.TrnTerminationStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRN_TerminationStatus_TerminationStatusTypes");

            entity.HasOne(d => d.TrnTrnt).WithMany(p => p.Transformations)
                .HasForeignKey(d => d.TrnTrntid)
                .HasConstraintName("FK_TRN_TRNTID_TransformationTypes");
        });

        modelBuilder.Entity<TransformationType>(entity =>
        {
            entity.HasKey(e => e.TrntId);

            entity.Property(e => e.TrntId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TRNT_ID");
            entity.Property(e => e.TrntName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRNT_Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
