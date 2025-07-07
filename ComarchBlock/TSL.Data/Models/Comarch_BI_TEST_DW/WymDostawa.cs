using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymDostawa
{
    public int? DostPartid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int DostRowId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int DostId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int DostZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DostOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DostDirtyOrgId { get; set; } = null!;

    public string DostNazwa { get; set; } = null!;

    public string? DostOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DostParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DostParCleanOrgId { get; set; }

    public int? DostParGid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DostTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DostTsupdate { get; set; }

    public DateTime DostTimeFrom { get; set; }

    public DateTime? DostTimeTo { get; set; }

    public int DostChecksumKimball1 { get; set; }

    public int DostChecksumKimball2 { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int DostUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DostUpdateSubTransformationId { get; set; }

    public int DostInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DostInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] DostRowVersion { get; set; } = null!;

    public string? DostCecha { get; set; }

    public string? DostEan { get; set; }

    public string? DostPolozenieWmag { get; set; }

    public int? DostDokNumerId { get; set; }

    public int? DostCechyId { get; set; }

    public int? DostDataWaznosciId { get; set; }

    public string? DostOrgAtrId { get; set; }

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentows { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual WymCechy? DostCechy { get; set; }

    public virtual WymCzasDzien? DostDataWaznosci { get; set; }

    public virtual WymDokumentNumer? DostDokNumer { get; set; }

    public virtual WymPartium? DostPart { get; set; }

    public virtual WymZrodloDanych DostZrodg { get; set; } = null!;

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMags { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynySrednie> FktMagazynySrednies { get; set; } = new List<FktMagazynySrednie>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanies { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktRezerwacje> FktRezerwacjes { get; set; } = new List<FktRezerwacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();
}
