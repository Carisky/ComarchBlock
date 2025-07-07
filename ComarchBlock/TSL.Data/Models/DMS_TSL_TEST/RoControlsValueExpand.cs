using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class RoControlsValueExpand
{
    public int DfhId { get; set; }

    public int DshId { get; set; }

    public int DwdId { get; set; }

    public int DkoId { get; set; }

    public int DwcId { get; set; }

    public string? DkoName { get; set; }

    public DateTime? DwcValueDate { get; set; }

    public decimal? DwcValueDecimal { get; set; }

    public int? DwcValueInt { get; set; }

    public float? DwcValueReal { get; set; }

    public string? DwcValueString { get; set; }

    public string? DctName { get; set; }

    public int? DwcValueListPos { get; set; }
}
