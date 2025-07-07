using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfCfmultiLineCtrlColumn
{
    public int DmcId { get; set; }

    public int DmcDkoid { get; set; }

    public int DmcDctid { get; set; }

    public string DmcName { get; set; } = null!;

    public int? DmcMapToErpcontrol { get; set; }

    public bool? DmcDateAndTime { get; set; }

    public int? DmcDmlid { get; set; }

    public int? DmcErpdocumentType { get; set; }

    public bool? DmcMapFromControls { get; set; }

    public int DmcPosition { get; set; }

    public bool DmcArchival { get; set; }

    public int? DmcCompanyId { get; set; }

    public bool? DmcShowOnlyActiveDocuments { get; set; }

    public bool DmcDontCloseDocumentDialogAfterSave { get; set; }

    public bool? DmcIsReadOnly { get; set; }

    public string? DmcDisplayName { get; set; }

    public string? DmcCeedocumentType { get; set; }

    public string? DmcCeedocumentConfigurationId { get; set; }

    public string? DmcCeedocumentConfigurationName { get; set; }

    public byte DmcIdentifierType { get; set; }

    public byte? DmcDecimalPrecision { get; set; }
}
