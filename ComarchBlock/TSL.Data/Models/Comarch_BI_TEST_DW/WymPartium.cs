using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymPartium
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PartRowId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int PartId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PartZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PartOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PartDirtyOrgId { get; set; } = null!;

    public string PartNazwa { get; set; } = null!;

    public string? PartOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PartParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PartParCleanOrgId { get; set; }

    public int? PartParGid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PartTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PartTsupdate { get; set; }

    public DateTime PartTimeFrom { get; set; }

    public DateTime? PartTimeTo { get; set; }

    public int PartChecksumKimball1 { get; set; }

    public int PartChecksumKimball2 { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PartUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PartUpdateSubTransformationId { get; set; }

    public int PartInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PartInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] PartRowVersion { get; set; } = null!;

    public string? PartEan { get; set; }

    public string? PartCecha { get; set; }

    public int? PartCechyId { get; set; }

    public int? PartDataWaznosciId { get; set; }

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentows { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMags { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynySrednie> FktMagazynySrednies { get; set; } = new List<FktMagazynySrednie>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZps { get; set; } = new List<FktProdukcjaZp>();

    public virtual WymCechy? PartCechy { get; set; }

    public virtual WymCzasDzien? PartDataWaznosci { get; set; }

    public virtual WymZrodloDanych PartZrodg { get; set; } = null!;

    public virtual ICollection<WymDostawa> WymDostawas { get; set; } = new List<WymDostawa>();
}
