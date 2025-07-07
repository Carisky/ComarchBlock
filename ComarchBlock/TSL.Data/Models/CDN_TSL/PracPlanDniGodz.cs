using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class PracPlanDniGodz
{
    public int PglPglId { get; set; }

    public int PglPplId { get; set; }

    public int PglLp { get; set; }

    public DateTime PglOdGodziny { get; set; }

    public DateTime PglDoGodziny { get; set; }

    public int PglStrefa { get; set; }

    public int PglDzlId { get; set; }

    public int PglPrjId { get; set; }

    public string PglUwagiPlanu { get; set; } = null!;

    public string? PglImportRowId { get; set; }

    public virtual PracPlanDni PglPpl { get; set; } = null!;
}
