using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class SerieKalPozGodz
{
    public int SkpSkpId { get; set; }

    public int SkpSlpId { get; set; }

    public int SkpLp { get; set; }

    public DateTime? SkpOdGodziny { get; set; }

    public DateTime? SkpDoGodziny { get; set; }

    public int SkpStrefa { get; set; }

    public virtual SerieKalPoz SkpSlp { get; set; } = null!;
}
