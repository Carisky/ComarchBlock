using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class PracPracaDniGodz
{
    public int PgrPgrId { get; set; }

    public int PgrPprId { get; set; }

    public int PgrLp { get; set; }

    public DateTime PgrOdGodziny { get; set; }

    public DateTime PgrDoGodziny { get; set; }

    public int PgrStrefa { get; set; }

    public int PgrDzlId { get; set; }

    public int PgrPrjId { get; set; }

    public string PgrUwagi { get; set; } = null!;

    public int PgrOdbNadg { get; set; }

    public string? PgrImportRowId { get; set; }

    public virtual PracPracaDni PgrPpr { get; set; } = null!;
}
