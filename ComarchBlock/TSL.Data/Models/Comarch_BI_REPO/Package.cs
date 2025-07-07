using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Package
{
    public int PkgId { get; set; }

    public string? PkgName { get; set; }

    public int? PkgPrice { get; set; }

    public int PkgWorkModeId { get; set; }

    public int? PkgUserCount { get; set; }

    public int? PkgDbspace { get; set; }

    public int? PkgMaxReport { get; set; }

    public int? PkgMaxDashboard { get; set; }

    public int? PkgIsExtend { get; set; }

    public int? PkgXlId { get; set; }

    public double? PkgPriceEur { get; set; }

    public double? PkgAnnualPrice { get; set; }

    public double? PkgAnnualPriceEur { get; set; }
}
