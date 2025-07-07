using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class TableLink
{
    public int TlnId { get; set; }

    public int? TlnPsrcid { get; set; }

    public int? TlnTblid { get; set; }

    public string TlnTbtid { get; set; } = null!;

    public string? TlnTsuid { get; set; }

    public string? TlnDescription { get; set; }

    public string? TlnCustomFileName { get; set; }

    public string? TlnCustomFilePath { get; set; }

    public bool? TlnIsAutoTranslated { get; set; }

    public string? TlnSheetName { get; set; }

    public string? TlnCustomQuery { get; set; }

    /// <summary>
    /// Kod sql do deklarowania i inicjowania zmiennych wykorzystywanych w CustomQuery
    /// </summary>
    public string? TlnInitQuerySection { get; set; }

    public bool TlnUseCustomQueryAndPath { get; set; }

    public string? TlnCustomTableName { get; set; }

    public bool TlnUseCustomName { get; set; }

    public bool? TlnNeedsTranslationConfirmation { get; set; }

    public int? TlnTranslationDescriptionFieldId { get; set; }

    public int? TlnTranslationField1FieldId { get; set; }

    public int? TlnTranslationField2FieldId { get; set; }

    public int? TlnTranslationField3FieldId { get; set; }

    public int? TlnForwardThreshold { get; set; }

    public int? TlnBackwardThreshold { get; set; }

    public string? TlnBeforeProc { get; set; }

    public string? TlnAfterProc { get; set; }

    public bool TlnRunAfterProc { get; set; }

    public bool TlnRunBeforeProc { get; set; }

    public DateTime TlnTsinsert { get; set; }

    public DateTime TlnTsupdate { get; set; }

    public byte[] TlnRowVersion { get; set; } = null!;

    public bool TlnDropIndexBeforeImport { get; set; }

    public bool TlnGenerateDynamicSelect { get; set; }

    public string? TlnExtraQuery { get; set; }

    public bool TlnIsMissingOrgIdsReportingActive { get; set; }

    public bool? TlnHasLocalFtpConfiguration { get; set; }

    public bool? TlnIsForStaticFiles { get; set; }

    public int? TlnFcfid { get; set; }

    public bool TlnLoadInRealTime { get; set; }

    public int TlnOrgIdFieldSorting { get; set; }

    public int TlnAutoTranslationKind { get; set; }

    public string? TlnCustomPatternLookup { get; set; }

    public bool TlnIgnoreOrgIdCase { get; set; }

    public string? TlnCustomFileSeparator { get; set; }

    public bool TlnUseCustomQueryAsView { get; set; }

    public string? TlnName { get; set; }

    public bool TlnHasColumnNamesInFirstRow { get; set; }

    public bool TlnHasRegexMapping { get; set; }

    public string? TlnAssignedRegex { get; set; }

    public string TlnFillMode { get; set; } = null!;

    public bool TlnThresholdEnabled { get; set; }

    public int? TlnEprmid { get; set; }

    public string? TlnXmlSchemaPath { get; set; }

    public bool? TlnUseCorrectionRules { get; set; }

    public int? TlnCodePage { get; set; }

    public string? TlnTextQualifier { get; set; }

    public string? TlnMetaQuery { get; set; }

    public virtual ICollection<EtlNode> EtlNodes { get; set; } = new List<EtlNode>();

    public virtual ICollection<FieldLink> FieldLinks { get; set; } = new List<FieldLink>();

    public virtual FtpConfiguration? TlnFcf { get; set; }

    public virtual PhysicalSource? TlnPsrc { get; set; }

    public virtual Table? TlnTbl { get; set; }

    public virtual TableType TlnTbt { get; set; } = null!;

    public virtual Field? TlnTranslationDescriptionField { get; set; }

    public virtual Field? TlnTranslationField1Field { get; set; }

    public virtual Field? TlnTranslationField2Field { get; set; }

    public virtual Field? TlnTranslationField3Field { get; set; }

    public virtual ThresholdUnit? TlnTsu { get; set; }
}
