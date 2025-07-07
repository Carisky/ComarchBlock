using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymPreliminarz
{
    public int PrlvRowId { get; set; }

    public int PrlvId { get; set; }

    public int PrlvZrodgid { get; set; }

    public string PrlvOrgId { get; set; } = null!;

    public string PrlvDirtyOrgId { get; set; } = null!;

    public string? PrlvParCleanOrgId { get; set; }

    public string? PrlvParDirtyOrgId { get; set; }

    public int? PrlvParGid { get; set; }

    public string PrlvNazwa { get; set; } = null!;

    public string? PrlvOpis { get; set; }

    public DateTime PrlvTsinsert { get; set; }

    public DateTime PrlvTsupdate { get; set; }

    public int? PrlvUpdateTransformationId { get; set; }

    public int PrlvUpdateSubTransformationId { get; set; }

    public int? PrlvInsertTransformationId { get; set; }

    public int PrlvInsertSubTransformationId { get; set; }

    public DateTime PrlvTimeFrom { get; set; }

    public DateTime? PrlvTimeTo { get; set; }

    public int PrlvChecksumKimball1 { get; set; }

    public int PrlvChecksumKimball2 { get; set; }

    public byte[] PrlvRowVersion { get; set; } = null!;

    public string? PrlvDokumentObcy { get; set; }

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkis { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual WymZrodloDanych PrlvZrodg { get; set; } = null!;
}
