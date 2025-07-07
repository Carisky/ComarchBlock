using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymNarzedzium
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

    public DateTime NdzTsinsert { get; set; }

    public DateTime NdzTsupdate { get; set; }

    public DateTime NdzTimeFrom { get; set; }

    public DateTime? NdzTimeTo { get; set; }

    public int NdzChecksumKimball1 { get; set; }

    public int NdzChecksumKimball2 { get; set; }

    public int? NdzUpdateSubTransformationId { get; set; }

    public int? NdzUpdateTransformationId { get; set; }

    public int? NdzInsertSubTransformationId { get; set; }

    public int? NdzInsertTransformationId { get; set; }

    public byte[] NdzRowVersion { get; set; } = null!;

    public int NdzZasgid { get; set; }

    public string NdzZasdirtyOrgId { get; set; } = null!;

    public string? NdzRodzajZasobu { get; set; }

    public string? NdzStatus { get; set; }

    public string? NdzPrzyczynaLikwidacji { get; set; }

    public string? NdzNumerNdz { get; set; }

    public int? BudgetMemberId { get; set; }
}
