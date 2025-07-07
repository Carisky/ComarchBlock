using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymLokatum
{
    public int LktRowId { get; set; }

    public int LktId { get; set; }

    public int LktZrodgid { get; set; }

    public string LktOrgId { get; set; } = null!;

    public string LktDirtyOrgId { get; set; } = null!;

    public string LktNazwa { get; set; } = null!;

    public string? LktOpis { get; set; }

    public string? LktParDirtyOrgId { get; set; }

    public string? LktParCleanOrgId { get; set; }

    public int? LktParGid { get; set; }

    public DateTime LktTsinsert { get; set; }

    public DateTime LktTsupdate { get; set; }

    public DateTime LktTimeFrom { get; set; }

    public DateTime? LktTimeTo { get; set; }

    public int LktChecksumKimball1 { get; set; }

    public int LktChecksumKimball2 { get; set; }

    public int LktUpdateTransformationId { get; set; }

    public int? LktUpdateSubTransformationId { get; set; }

    public int LktInsertTransformationId { get; set; }

    public int? LktInsertSubTransformationId { get; set; }

    public byte[] LktRowVersion { get; set; } = null!;

    public string? LktKod { get; set; }

    public string? LktOkres { get; set; }

    public int? LktDlugosc { get; set; }

    public string? LktTyp { get; set; }

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual WymZrodloDanych LktZrodg { get; set; } = null!;
}
