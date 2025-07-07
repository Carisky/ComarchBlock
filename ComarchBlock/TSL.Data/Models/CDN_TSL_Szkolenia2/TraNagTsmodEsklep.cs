using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TraNagTsmodEsklep
{
    public int TrNtsTrNid { get; set; }

    public int TrNtsStatus { get; set; }

    public int? TrNtsStatusPlat { get; set; }

    public int? TrNtsStatusDost { get; set; }

    public DateTime? TrNtsDataPlanowanaDostawy { get; set; }

    public DateTime TrNtsTsModEsklep { get; set; }

    public DateTime? TrNtsDataPrzyjecia { get; set; }

    public DateTime? TrNtsDataPotwierdzenia { get; set; }

    public DateTime? TrNtsDataRealizacji { get; set; }

    public DateTime? TrNtsTsModList { get; set; }

    public virtual TraNag TrNtsTrN { get; set; } = null!;
}
