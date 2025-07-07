using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class BudzetView
{
    public int BuVAccId { get; set; }

    public int BuVOobId { get; set; }

    public string BuVAccNumer { get; set; } = null!;

    public string BuVAccNumerIdx { get; set; } = null!;

    public string BuVAccNazwa { get; set; } = null!;

    public decimal? BuVPlanKwotaWn { get; set; }

    public decimal? BuVPlanKwotaMa { get; set; }

    public decimal BuVRealKwotaWn { get; set; }

    public decimal BuVRealKwotaMa { get; set; }

    public decimal? BuVPrzekKwotaWn { get; set; }

    public decimal? BuVPrzekKwotaMa { get; set; }
}
