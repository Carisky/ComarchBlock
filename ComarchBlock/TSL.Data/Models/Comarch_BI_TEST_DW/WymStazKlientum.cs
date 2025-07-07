using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymStazKlientum
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string StazDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int StazId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? StazOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? StazParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? StazParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int StazRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] StazRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime StazTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime StazTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int StazZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SubWsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadUpdateId { get; set; }

    public int? StazTypId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? StazAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? StazAktualneOrgParId { get; set; }

    public int? StazAktywny { get; set; }

    public int? StazDo { get; set; }

    public string? StazNazwa { get; set; }

    public int? StazOd { get; set; }

    public string? StazOpis { get; set; }

    public string? StazOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? StazOrgParId { get; set; }

    public int? StazPoprzednikId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string StazTypOrgId { get; set; } = null!;

    public int? StazWymFirma { get; set; }

    public int? StazWymTyp { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzKndStazs { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzKntStazs { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzProdStazs { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktKoszty> FktKosztyKosztAkwStazs { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztKndStazs { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztKntStazs { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztProdStazs { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsAkwStazs { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsKndStazs { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsKntStazs { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsProdStazs { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkAkwStazs { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkKndStazs { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkKntStazs { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkProdStazs { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprAkwStazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprKndStazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprKntStazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprProdStazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktZakupy> FktZakupyZkpKndStazs { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpKntStazs { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpProdStazs { get; set; } = new List<FktZakupy>();

    public virtual WymStazKlientaTyp? StazTyp { get; set; }

    public virtual WymZrodloDanych StazZrodg { get; set; } = null!;
}
