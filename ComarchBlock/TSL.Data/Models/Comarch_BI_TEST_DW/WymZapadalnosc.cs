using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymZapadalnosc
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SubWsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadUpdateId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZapDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int ZapId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZapOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZapParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZapRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] ZapRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZapTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZapTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZapZrodgid { get; set; }

    public int? ZapTypId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZapAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZapAktualneOrgParId { get; set; }

    public int? ZapAktywny { get; set; }

    public int? ZapDo { get; set; }

    public string? ZapNazwa { get; set; }

    public int? ZapOd { get; set; }

    public string? ZapOpis { get; set; }

    public string? ZapOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZapOrgParId { get; set; }

    public int? ZapPoprzednikId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZapTypOrgId { get; set; } = null!;

    public int? ZapWymFirma { get; set; }

    public int? ZapWymTyp { get; set; }

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual WymZapadalnoscTyp? ZapTyp { get; set; }

    public virtual WymZrodloDanych ZapZrodg { get; set; } = null!;
}
