using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymWniosek
{
    public int WnoRowId { get; set; }

    public int WnoId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int WnoZrodgid { get; set; }

    public string WnoOrgId { get; set; } = null!;

    public string WnoDirtyOrgId { get; set; } = null!;

    public string WnoNazwa { get; set; } = null!;

    public string? WnoOpis { get; set; }

    public string? WnoParDirtyOrgId { get; set; }

    public string? WnoParCleanOrgId { get; set; }

    public int? WnoParGid { get; set; }

    public DateTime WnoTsinsert { get; set; }

    public DateTime WnoTsupdate { get; set; }

    public DateTime WnoTimeFrom { get; set; }

    public DateTime? WnoTimeTo { get; set; }

    public int WnoChecksumKimball1 { get; set; }

    public int WnoChecksumKimball2 { get; set; }

    public int WnoUpdateSubTransformationId { get; set; }

    public int? WnoUpdateTransformationId { get; set; }

    public int WnoInsertSubTransformationId { get; set; }

    public int? WnoInsertTransformationId { get; set; }

    public byte[] WnoRowVersion { get; set; } = null!;

    public string? WnoStatus { get; set; }

    public string? WnoTyp { get; set; }

    public string? WnoPelnyNumer { get; set; }

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkis { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual WymZrodloDanych WnoZrodg { get; set; } = null!;
}
