using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymPartium
{
    public string? PartCecha { get; set; }

    public int? PartCechyId { get; set; }

    public int PartChecksumKimball1 { get; set; }

    public int PartChecksumKimball2 { get; set; }

    public int? PartDataWaznosciId { get; set; }

    public string PartDirtyOrgId { get; set; } = null!;

    public string? PartEan { get; set; }

    public int PartId { get; set; }

    public int? PartInsertSubTransformationId { get; set; }

    public int PartInsertTransformationId { get; set; }

    public string PartNazwa { get; set; } = null!;

    public string? PartOpis { get; set; }

    public string? PartOrgId { get; set; }

    public string? PartParCleanOrgId { get; set; }

    public string? PartParDirtyOrgId { get; set; }

    public int? PartParGid { get; set; }

    public int? PartRowId { get; set; }

    public byte[] PartRowVersion { get; set; } = null!;

    public DateTime PartTimeFrom { get; set; }

    public DateTime? PartTimeTo { get; set; }

    public DateTime PartTsinsert { get; set; }

    public DateTime PartTsupdate { get; set; }

    public int? PartUpdateSubTransformationId { get; set; }

    public int PartUpdateTransformationId { get; set; }

    public int PartZrodgid { get; set; }
}
