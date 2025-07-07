using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymRodzajKosztu
{
    public int RodzKosztChecksumKimball1 { get; set; }

    public int RodzKosztChecksumKimball2 { get; set; }

    public string RodzKosztDirtyOrgId { get; set; } = null!;

    public int RodzKosztId { get; set; }

    public int? RodzKosztInsertSubTransformationId { get; set; }

    public int RodzKosztInsertTransformationId { get; set; }

    public string RodzKosztNazwa { get; set; } = null!;

    public string? RodzKosztOpis { get; set; }

    public string RodzKosztOrgId { get; set; } = null!;

    public string? RodzKosztParCleanOrgId { get; set; }

    public string? RodzKosztParDirtyOrgId { get; set; }

    public int? RodzKosztParGid { get; set; }

    public int? RodzKosztRowId { get; set; }

    public byte[] RodzKosztRowVersion { get; set; } = null!;

    public DateTime RodzKosztTimeFrom { get; set; }

    public DateTime? RodzKosztTimeTo { get; set; }

    public DateTime RodzKosztTsinsert { get; set; }

    public DateTime RodzKosztTsupdate { get; set; }

    public int? RodzKosztUpdateSubTransformationId { get; set; }

    public int RodzKosztUpdateTransformationId { get; set; }

    public int RodzKosztZrodgid { get; set; }
}
