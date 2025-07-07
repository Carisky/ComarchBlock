using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfCfcardDokFlow
{
    /// <summary>
    /// Primary key
    /// </summary>
    public int DkoId { get; set; }

    /// <summary>
    /// Relacja do tabeli nagłówkowej
    /// </summary>
    public int DkoDshid { get; set; }

    /// <summary>
    /// Relacja do tabeli typów kontrolek
    /// </summary>
    public int DkoDctid { get; set; }

    /// <summary>
    /// Pozycja kontrolki na panelu „Karta obiegu”
    /// </summary>
    public int DkoPos { get; set; }

    /// <summary>
    /// Id kontrolki „Dokument elektroniczny”
    /// </summary>
    public int? DkoDkoid { get; set; }

    /// <summary>
    /// Nazwa kolumny tabeli nagłówkowej podpięte dokumentu, z której będą pobierane wartości inicjujące kontrolkę
    /// </summary>
    public string? DkoColumnName { get; set; }

    /// <summary>
    /// Czy kontrolka ma być tylko do odczytu na etapach innych niż pierwszy
    /// </summary>
    public bool DkoReadOnly { get; set; }

    /// <summary>
    /// Ilość miejsc po przecinku dla kontrolki typu Decimal
    /// </summary>
    public byte? DkoDecimalPrecision { get; set; }

    /// <summary>
    /// Czy kontrolka data ma prezentować datę i czas
    /// </summary>
    public bool? DkoDateAndTime { get; set; }

    /// <summary>
    /// relacja do tabeli konfiguracyjnej dokumentu elektroniczne
    /// </summary>
    public int? DkoDdeid { get; set; }

    public bool? DkoGridView { get; set; }

    public bool? DkoAccDynamic { get; set; }

    public int? DkoType { get; set; }

    public bool DkoArchival { get; set; }

    public int? DkoMultiLine { get; set; }

    public bool? DkoScrollBars { get; set; }

    public int? DkoMaxLength { get; set; }

    public int DkoColor { get; set; }

    public short DkoSize { get; set; }

    public string? DkoName { get; set; }

    public bool DkoIsRequired { get; set; }

    public string? DkoSqlQuery { get; set; }

    public byte DkoExpectedSqlQueryResultColumnsCount { get; set; }

    public byte? DkoInitType { get; set; }

    public byte? DkoListWorkMode { get; set; }

    public int? DkoWorkMode { get; set; }

    public bool DkoCanGenerateWithoutAd { get; set; }

    public byte? DkoShowOnlyActiveDocuments { get; set; }

    public bool DkoDontCloseDocumentDialogAfterSave { get; set; }

    public string? DkoExecutableFile { get; set; }

    public string? DkoExecutableIisfile { get; set; }

    public string? DkoStoredProcedure { get; set; }

    public string? DkoErpStoredProcedure { get; set; }

    public bool? DkoAskBeforeExecute { get; set; }

    public bool? DkoSaveBeforeExecute { get; set; }

    public bool? DkoCanNotify { get; set; }

    public string? DkoConfirmMessage { get; set; }

    public string? DkoValueExpression { get; set; }

    public byte DkoExpectedValueExpressionResultColumnsCount { get; set; }

    public byte? DkoExpressionEngineType { get; set; }

    public bool DkoFillEntireRow { get; set; }

    public bool DkoControlPositionedInNewLine { get; set; }

    public string? DkoTitle { get; set; }

    public bool DkoAttachmentVersioning { get; set; }

    public bool DkoSignPdf { get; set; }

    public int? DkoInitSqlCompanyId { get; set; }

    public int? DkoExpressionCompanyId { get; set; }

    public int? DkoErpControlCompanyId { get; set; }

    public int? DkoCompanyId { get; set; }

    public int? DkoErpdepartmentId { get; set; }

    public int? DkoRowsCount { get; set; }

    public bool DkoStaysInRelatedHistory { get; set; }

    public bool DkoHideRowRemoving { get; set; }

    public bool DkoHideRowAdding { get; set; }

    public bool DkoIsSearchForAnyStringModeEnabled { get; set; }

    public bool DkoIsInitiatedEveryTime { get; set; }

    public bool DkoIsAttachmentMappingToErpXl { get; set; }

    public bool DkoLastUsedCalculationMode { get; set; }

    public int? DkoCfsid { get; set; }

    public bool DkoDocumentsManagerAsSource { get; set; }

    public string? DkoCsScriptNameInit { get; set; }

    public string? DkoCsScriptGeneratedInit { get; set; }

    public string? DkoCsScriptUserInit { get; set; }

    public string? DkoCsScriptReferencesInit { get; set; }

    public bool DkoCsScriptHostingInit { get; set; }

    public string? DkoCsScriptNameChange { get; set; }

    public string? DkoCsScriptGeneratedChange { get; set; }

    public string? DkoCsScriptUserChange { get; set; }

    public string? DkoCsScriptReferencesChange { get; set; }

    public string? DkoDisplayName { get; set; }

    public Guid? DkoGuid { get; set; }

    public byte DkoIdentifierType { get; set; }

    public string? DkoCeedocumentType { get; set; }

    public string? DkoCeeconfigurationId { get; set; }

    public string? DkoCeeconfigurationName { get; set; }

    public string? DkoAttachmentLocation { get; set; }

    public bool? DkoAttachmentRepositoryAsSource { get; set; }

    public bool? DkoUseDefaultRepositoryLogin { get; set; }

    public virtual ICollection<DfConfCfctrlDictionary> DfConfCfctrlDictionaries { get; set; } = new List<DfConfCfctrlDictionary>();

    public virtual ICollection<DfConfCfrelatedControl> DfConfCfrelatedControlDrcDkos { get; set; } = new List<DfConfCfrelatedControl>();

    public virtual ICollection<DfConfCfrelatedControl> DfConfCfrelatedControlDrcRelatedControls { get; set; } = new List<DfConfCfrelatedControl>();

    public virtual ICollection<DfConfDsctrlCondition> DfConfDsctrlConditions { get; set; } = new List<DfConfDsctrlCondition>();

    public virtual DfConfCfcontrolSection? DkoCfs { get; set; }

    public virtual DfConfCfctrlType DkoDct { get; set; } = null!;

    public virtual DfConfCfcardDokFlow? DkoDko { get; set; }

    public virtual DfConfDshead DkoDsh { get; set; } = null!;

    public virtual ICollection<DfConfCfcardDokFlow> InverseDkoDko { get; set; } = new List<DfConfCfcardDokFlow>();
}
