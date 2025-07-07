using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class KalendDniGodz
{
    public int KdgKdgId { get; set; }

    public int KdgKadId { get; set; }

    public int KdgLp { get; set; }

    public DateTime KdgOdGodziny { get; set; }

    public DateTime KdgDoGodziny { get; set; }

    public int KdgStrefa { get; set; }

    public int? KdgDzlId { get; set; }

    public int? KdgPrjId { get; set; }

    public string? KdgImportRowId { get; set; }
}
