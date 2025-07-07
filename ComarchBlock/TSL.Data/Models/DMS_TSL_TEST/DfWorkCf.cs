using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkCf
{
    public int DwcId { get; set; }

    public int DwcDwdid { get; set; }

    public int DwcDkoid { get; set; }

    public int? DwcValueInt { get; set; }

    public float? DwcValueReal { get; set; }

    public DateTime? DwcValueDate { get; set; }

    public int? DwcValueListPos { get; set; }

    public int? DwcGidid { get; set; }

    public int? DwcGidtype { get; set; }

    public string? DwcNumber { get; set; }

    public string? DwcValueString { get; set; }

    public decimal? DwcValueDecimal { get; set; }

    public DateTime? DwcModificationData { get; set; }

    public int? DwcDdsid { get; set; }

    public int? DwcDcdid { get; set; }

    public bool DwcLastUsedCalculationMode { get; set; }

    public string? DwcValueStringId { get; set; }

    public virtual DfWork DwcDwd { get; set; } = null!;
}
