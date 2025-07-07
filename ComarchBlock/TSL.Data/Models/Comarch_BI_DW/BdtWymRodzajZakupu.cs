using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymRodzajZakupu
{
    public int RdzId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? RdzRowId { get; set; }

    public string? RdzOrgParId { get; set; }

    public string? RdzOpis { get; set; }

    public string RdzNazwa { get; set; } = null!;

    public string? RdzAktualneOrgId { get; set; }

    public int RdzZrodgid { get; set; }

    public int RdzUpdateTransformationId { get; set; }

    public int? RdzUpdateSubTransformationId { get; set; }

    public DateTime RdzTsupdate { get; set; }

    public DateTime RdzTsinsert { get; set; }

    public DateTime? RdzTimeTo { get; set; }

    public DateTime RdzTimeFrom { get; set; }

    public byte[] RdzRowVersion { get; set; } = null!;

    public int? RdzParGid { get; set; }

    public string? RdzParDirtyOrgId { get; set; }

    public string? RdzParCleanOrgId { get; set; }

    public string RdzOrgId { get; set; } = null!;

    public int RdzInsertTransformationId { get; set; }

    public int? RdzInsertSubTransformationId { get; set; }

    public string RdzDirtyOrgId { get; set; } = null!;

    public int RdzChecksumKimball2 { get; set; }

    public int RdzChecksumKimball1 { get; set; }
}
