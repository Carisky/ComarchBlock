using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymRealizacjeReklamacji
{
    public int RkreChecksumKimball1 { get; set; }

    public int RkreChecksumKimball2 { get; set; }

    public string RkreDirtyOrgId { get; set; } = null!;

    public int RkreId { get; set; }

    public int RkreInsertSubTransformationId { get; set; }

    public int? RkreInsertTransformationId { get; set; }

    public string RkreNazwa { get; set; } = null!;

    public string? RkreOpis { get; set; }

    public string RkreOrgId { get; set; } = null!;

    public string? RkreParCleanOrgId { get; set; }

    public string? RkreParDirtyOrgId { get; set; }

    public int? RkreParGid { get; set; }

    public int? RkreRowId { get; set; }

    public byte[] RkreRowVersion { get; set; } = null!;

    public DateTime RkreTimeFrom { get; set; }

    public DateTime? RkreTimeTo { get; set; }

    public DateTime RkreTsinsert { get; set; }

    public DateTime RkreTsupdate { get; set; }

    public int RkreUpdateSubTransformationId { get; set; }

    public int? RkreUpdateTransformationId { get; set; }

    public int RkreZrodgid { get; set; }
}
