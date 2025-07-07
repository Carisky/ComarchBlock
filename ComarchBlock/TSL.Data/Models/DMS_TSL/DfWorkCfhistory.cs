using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkCfhistory
{
    public int DwjId { get; set; }

    public int DwjDwcid { get; set; }

    public int DwjDwdid { get; set; }

    public int DwjDkoid { get; set; }

    public int? DwjValueInt { get; set; }

    public float? DwjValueReal { get; set; }

    public DateTime? DwjValueDate { get; set; }

    public int? DwjValueListPos { get; set; }

    public int? DwjGidid { get; set; }

    public int? DwjGidtype { get; set; }

    public string? DwjNumber { get; set; }

    public string? DwjValueString { get; set; }

    public decimal? DwjValueDecimal { get; set; }

    public DateTime? DwjModificationData { get; set; }

    public int? DwjDdsid { get; set; }

    public int? DwjDcdid { get; set; }
}
