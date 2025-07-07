using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymKodZakonczenium
{
    public int KdzChecksumKimball1 { get; set; }

    public int KdzChecksumKimball2 { get; set; }

    public string KdzDirtyOrgId { get; set; } = null!;

    public int KdzId { get; set; }

    public int? KdzInsertSubTransformationId { get; set; }

    public int KdzInsertTransformationId { get; set; }

    public string? KdzKod { get; set; }

    public string KdzNazwa { get; set; } = null!;

    public string? KdzOpis { get; set; }

    public string KdzOrgId { get; set; } = null!;

    public string? KdzParCleanOrgId { get; set; }

    public string? KdzParDirtyOrgId { get; set; }

    public int? KdzParGid { get; set; }

    public int? KdzRowId { get; set; }

    public byte[] KdzRowVersion { get; set; } = null!;

    public string? KdzStatus { get; set; }

    public DateTime KdzTimeFrom { get; set; }

    public DateTime? KdzTimeTo { get; set; }

    public DateTime KdzTsinsert { get; set; }

    public DateTime KdzTsupdate { get; set; }

    public int? KdzUpdateSubTransformationId { get; set; }

    public int KdzUpdateTransformationId { get; set; }

    public int KdzZrodgid { get; set; }
}
