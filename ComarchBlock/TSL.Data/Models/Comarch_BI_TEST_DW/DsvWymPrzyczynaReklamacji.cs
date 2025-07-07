using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymPrzyczynaReklamacji
{
    public int PreklRowId { get; set; }

    public int PreklId { get; set; }

    public int PreklZrodgid { get; set; }

    public string PreklOrgId { get; set; } = null!;

    public string PreklDirtyOrgId { get; set; } = null!;

    public string PreklNazwa { get; set; } = null!;

    public string? PreklOpis { get; set; }

    public string? PreklParDirtyOrgId { get; set; }

    public string? PreklParCleanOrgId { get; set; }

    public int? PreklParGid { get; set; }

    public DateTime PreklTsinsert { get; set; }

    public DateTime PreklTsupdate { get; set; }

    public DateTime PreklTimeFrom { get; set; }

    public DateTime? PreklTimeTo { get; set; }

    public int PreklChecksumKimball1 { get; set; }

    public int PreklChecksumKimball2 { get; set; }

    public int PreklUpdateSubTransformationId { get; set; }

    public int? PreklUpdateTransformationId { get; set; }

    public int PreklInsertSubTransformationId { get; set; }

    public int? PreklInsertTransformationId { get; set; }

    public byte[] PreklRowVersion { get; set; } = null!;

    public string? PreklPrzyczyna { get; set; }
}
