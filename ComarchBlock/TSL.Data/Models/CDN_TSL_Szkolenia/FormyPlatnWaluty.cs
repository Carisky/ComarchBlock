using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class FormyPlatnWaluty
{
    public int FpwFpwid { get; set; }

    public int FpwFplId { get; set; }

    public int FpwBraId { get; set; }

    public virtual BnkRachunki FpwBra { get; set; } = null!;

    public virtual FormyPlatnosci FpwFpl { get; set; } = null!;
}
