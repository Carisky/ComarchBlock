using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymDelegacja
{
    public int DlgRowId { get; set; }

    public int DlgId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int DlgZrodgid { get; set; }

    public string DlgOrgId { get; set; } = null!;

    public string DlgDirtyOrgId { get; set; } = null!;

    public string DlgNazwa { get; set; } = null!;

    public string? DlgOpis { get; set; }

    public string? DlgParDirtyOrgId { get; set; }

    public string? DlgParCleanOrgId { get; set; }

    public int? DlgParGid { get; set; }

    public DateTime DlgTsinsert { get; set; }

    public DateTime DlgTsupdate { get; set; }

    public DateTime DlgTimeFrom { get; set; }

    public DateTime? DlgTimeTo { get; set; }

    public int DlgChecksumKimball1 { get; set; }

    public int DlgChecksumKimball2 { get; set; }

    public int DlgUpdateSubTransformationId { get; set; }

    public int? DlgUpdateTransformationId { get; set; }

    public int DlgInsertSubTransformationId { get; set; }

    public int? DlgInsertTransformationId { get; set; }

    public byte[] DlgRowVersion { get; set; } = null!;

    public string? DlgStatus { get; set; }

    public string? DlgRodzaj { get; set; }

    /// <summary>
    /// Miejsce rozpoczęcia Delegacji
    /// </summary>
    public string? DlgMiejsce { get; set; }

    /// <summary>
    ///  Miejsce zakończenia Delegacji 
    /// </summary>
    public string? DlgCel { get; set; }

    public string? DlgPelnyNumer { get; set; }

    public virtual WymZrodloDanych DlgZrodg { get; set; } = null!;

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkis { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKas { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktWizyty> FktWizyties { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktWydatki> FktWydatkis { get; set; } = new List<FktWydatki>();
}
