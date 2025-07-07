using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class PhysicalSource1
{
    public int MpsId { get; set; }

    public DateTime? MpsTsinsert { get; set; }

    public string? MpsModifiedBy { get; set; }

    public string? MpsConnectionString { get; set; }

    public string? MpsConnectionStringOld { get; set; }

    public string? MpsFolderName { get; set; }

    public string? MpsFolderNameOld { get; set; }

    public string? MpsAction { get; set; }

    public int? MpsIsMigrated { get; set; }

    public DateTime? MpsTsmigrate { get; set; }

    public int? MpsPsid { get; set; }

    public int? MpsLsid { get; set; }
}
