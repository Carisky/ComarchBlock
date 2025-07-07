using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymCrmetapy
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CrmetapDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CrmetapDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CrmetapDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int CrmetapId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CrmetapKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CrmetapKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CrmetapOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CrmetapParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CrmetapParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CrmetapParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int CrmetapRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] CrmetapRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CrmetapSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CrmetapTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CrmetapTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int CrmetapZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SubWsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadUpdateId { get; set; }

    public int? CrmetapKampaniaId { get; set; }

    public string? CrmetapAkcja { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CrmetapAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CrmetapAktualneOrgParId { get; set; }

    public int? CrmetapAktywny { get; set; }

    public string? CrmetapNazwa { get; set; }

    public string? CrmetapOpis { get; set; }

    public string? CrmetapOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CrmetapOrgParId { get; set; }

    public int? CrmetapPoprzednikId { get; set; }

    public int? CrmetapPozycja { get; set; }

    public int? CrmetapSzansa { get; set; }

    public string? CrmetapUrl { get; set; }

    public string? CrmetapWymaganaAkcja { get; set; }

    public string? CrmetapWymaganaTransakcja { get; set; }

    public int? CrmetapWymFirma { get; set; }

    public int? CrmetapWymTyp { get; set; }

    public string? CrmetapKod { get; set; }

    public virtual WymCrmkampanium? CrmetapKampania { get; set; }

    public virtual WymZrodloDanych CrmetapZrodg { get; set; } = null!;

    public virtual ICollection<FktKampanieEtapy> FktKampanieEtapies { get; set; } = new List<FktKampanieEtapy>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamCrmetapZrds { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamCrmetaps { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();
}
