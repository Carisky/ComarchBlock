using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymNarzedzium
{
    public int NdzRowId { get; set; }

    public int NdzId { get; set; }

    public int NdzZrodgid { get; set; }

    public string NdzOrgId { get; set; } = null!;

    public string NdzDirtyOrgId { get; set; } = null!;

    public string NdzNazwa { get; set; } = null!;

    public string? NdzOpis { get; set; }

    public string? NdzParDirtyOrgId { get; set; }

    public string? NdzParCleanOrgId { get; set; }

    public int? NdzParGid { get; set; }

    public int NdzZasgid { get; set; }

    public string NdzZasdirtyOrgId { get; set; } = null!;

    public string? NdzRodzajZasobu { get; set; }

    public string? NdzStatus { get; set; }

    public string? NdzPrzyczynaLikwidacji { get; set; }

    public string? NdzNumerNdz { get; set; }
}
