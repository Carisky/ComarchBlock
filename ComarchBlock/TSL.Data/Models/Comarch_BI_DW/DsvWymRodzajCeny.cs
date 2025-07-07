using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymRodzajCeny
{
    public int? RodzCenRowId { get; set; }

    public int RodzCenId { get; set; }

    public int RodzCenZrodgid { get; set; }

    public string RodzCenOrgId { get; set; } = null!;

    public string RodzCenDirtyOrgId { get; set; } = null!;

    public string RodzCenNazwa { get; set; } = null!;

    public string? RodzCenOpis { get; set; }

    public string? RodzCenParDirtyOrgId { get; set; }

    public string? RodzCenParCleanOrgId { get; set; }

    public int? RodzCenParGid { get; set; }

    public DateTime RodzCenTsinsert { get; set; }

    public DateTime RodzCenTsupdate { get; set; }

    public DateTime RodzCenTimeFrom { get; set; }

    public DateTime? RodzCenTimeTo { get; set; }

    public int RodzCenChecksumKimball1 { get; set; }

    public int RodzCenChecksumKimball2 { get; set; }

    public int RodzCenUpdateSubTransformationId { get; set; }

    public int? RodzCenUpdateTransformationId { get; set; }

    public int RodzCenInsertSubTransformationId { get; set; }

    public int? RodzCenInsertTransformationId { get; set; }

    public byte[] RodzCenRowVersion { get; set; } = null!;
}
