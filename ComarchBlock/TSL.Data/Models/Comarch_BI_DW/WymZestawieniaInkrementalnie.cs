using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymZestawieniaInkrementalnie
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
    public int? ZstiDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZstiDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZstiDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int ZstiId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZstiKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZstiKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZstiOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZstiOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZstiParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZstiParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZstiRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] ZstiRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZstiSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZstiTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZstiTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZstiZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZstiAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZstiAktualneOrgParId { get; set; }

    public int? ZstiAktywny { get; set; }

    public string? ZstiDefinicja { get; set; }

    public string? ZstiFunkcja { get; set; }

    public int? ZstiIdKonta { get; set; }

    public string? ZstiLisc { get; set; }

    public decimal ZstiMnoznik { get; set; }

    public string? ZstiNazwa { get; set; }

    public string? ZstiNumeracja { get; set; }

    public string? ZstiOpis { get; set; }

    public string? ZstiOrgAtrId { get; set; }

    public int? ZstiPoprzednikId { get; set; }

    public string? ZstiPoziom { get; set; }

    public int? ZstiPoziomNr { get; set; }

    public string? ZstiPozycjaChar { get; set; }

    public decimal? ZstiPozycjaNr { get; set; }

    public string? ZstiPrezentacja { get; set; }

    public string? ZstiSaldoDwustronnie { get; set; }

    public int? ZstiSyntetyka { get; set; }

    public int? ZstiTypPozycji { get; set; }

    public int? ZstiWymFirma { get; set; }

    public int? ZstiWymTyp { get; set; }

    public string? ZstiZknNazwa { get; set; }

    public int? ZstiZknNumer { get; set; }

    public int? ZstiZnak { get; set; }

    public string? ZstiZnakPozycji { get; set; }

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();

    public virtual WymZrodloDanych ZstiZrodg { get; set; } = null!;
}
