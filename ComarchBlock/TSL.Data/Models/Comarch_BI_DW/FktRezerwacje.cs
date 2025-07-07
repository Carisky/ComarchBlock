using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktRezerwacje
{
    /// <summary>
    /// Relation to dimension FIRMA
    /// </summary>
    public int RezFirmaGid { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int RezBudzetGid { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int RezAlokacjaGid { get; set; }

    /// <summary>
    /// Relation to dimension Czynnosc
    /// </summary>
    public int RezCzngid { get; set; }

    /// <summary>
    /// Relation to dimension RezerwacjaNumer
    /// </summary>
    public int RezRengid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int RezCzwgid { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int RezCechaGid { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn
    /// </summary>
    public int RezMagGid { get; set; }

    /// <summary>
    /// Relation to dimension Dostawa
    /// </summary>
    public int RezDostGid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int RezKntGid { get; set; }

    /// <summary>
    /// Relation to dimension Rejon
    /// </summary>
    public int RezRejongid { get; set; }

    /// <summary>
    /// Relation to dimension Produkt
    /// </summary>
    public int RezProdGid { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int RezDokNumerGid { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int RezId { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int RezCzdgid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int RezZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RezOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RezDirtyOrgId { get; set; } = null!;

    public string? RezOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RezTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RezTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RezUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RezUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RezInsertSubTransformationId { get; set; }

    public int? RezInsertTransformationId { get; set; }

    public decimal? RezMiloscSpr { get; set; }

    public decimal? RezMiloscDoRealizacjiSpr { get; set; }

    public decimal? RezMiloscMagSpr { get; set; }

    public decimal? RezMiloscPozostalaSpr { get; set; }

    public decimal? RezMiloscZkp { get; set; }

    public decimal? RezMiloscDoRealizacjiZkp { get; set; }

    public decimal? RezMiloscMagZkp { get; set; }

    public decimal? RezMiloscPozostalaZkp { get; set; }

    /// <summary>
    /// Relation to dimension Technologia
    /// </summary>
    public int RezTchgid { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int RezPrmgid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? RezStrPrwId { get; set; }

    public int RezAbcgid { get; set; }

    public int RezZasgid { get; set; }

    public virtual WymCzasDzien RezCzdg { get; set; } = null!;

    public virtual WymCzasDzien RezCzwg { get; set; } = null!;
}
