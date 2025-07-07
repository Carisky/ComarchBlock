using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymAdre
{
    public int? AdrRejonid { get; set; }

    public int? AdrMiejscowoscId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int AdrRowId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int AdrId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int AdrZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AdrOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AdrDirtyOrgId { get; set; } = null!;

    public string AdrNazwa { get; set; } = null!;

    public string? AdrOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? AdrParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? AdrParCleanOrgId { get; set; }

    public int? AdrParGid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime AdrTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime AdrTsupdate { get; set; }

    public DateTime AdrTimeFrom { get; set; }

    public DateTime? AdrTimeTo { get; set; }

    public int AdrChecksumKimball1 { get; set; }

    public int AdrChecksumKimball2 { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int AdrUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AdrUpdateSubTransformationId { get; set; }

    public int AdrInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AdrInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] AdrRowVersion { get; set; } = null!;

    public string? AdrAkronim { get; set; }

    public string? AdrKodPocztowy { get; set; }

    public string? AdrTelefon { get; set; }

    public string? AdrAdres { get; set; }

    public string? AdrNip { get; set; }

    public decimal? AdrDlugGeog { get; set; }

    public decimal? AdrSzerGeog { get; set; }

    public decimal? AdrOdleglosc { get; set; }

    public string? AdrEmail { get; set; }

    /// <summary>
    /// Relation to dimension Geografia
    /// </summary>
    public int? AdrGeoid { get; set; }

    public string? AdrAktualny { get; set; }

    public virtual WymGeografium? AdrGeo { get; set; }

    public virtual WymMiejscowosc? AdrMiejscowosc { get; set; }

    public virtual WymRejon? AdrRejon { get; set; }

    public virtual WymZrodloDanych AdrZrodg { get; set; } = null!;

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();
}
