using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymAtrybuty
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AtrybutyDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AtrybutyDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AtrybutyDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int AtrybutyId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AtrybutyKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AtrybutyKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AtrybutyOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? AtrybutyOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? AtrybutyParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AtrybutyParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int AtrybutyRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] AtrybutyRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AtrybutySubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime AtrybutyTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime AtrybutyTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int AtrybutyZrodgid { get; set; }

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

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? AtrybutyAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? AtrybutyAktualneOrgParId { get; set; }

    /// <summary>
    /// Informacja, czy atrybut jest aktywny
    /// </summary>
    public int? AtrybutyAktywny { get; set; }

    /// <summary>
    /// kolumna techniczna
    /// </summary>
    public string? AtrybutyCastomRollup { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? AtrybutyKategoria { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? AtrybutyKonto { get; set; }

    /// <summary>
    /// Dla klasy atrybutu jej nazwa, dla atrybutu jego wartość
    /// </summary>
    public string? AtrybutyNazwa { get; set; }

    /// <summary>
    /// Dla klasy atrybutu jej nazwa, dla atrybutu jego wartość
    /// </summary>
    public string? AtrybutyOpis { get; set; }

    /// <summary>
    /// Identyfikator atrybutu
    /// </summary>
    public int? AtrybutyOrgAtkId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? AtrybutyOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? AtrybutyPoprzednikId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? AtrybutyRoot { get; set; }

    /// <summary>
    /// Dla klasy atrybutu 1. dla atrybutu 3
    /// </summary>
    public int? AtrybutyTyp { get; set; }

    /// <summary>
    /// kolumna techniczna
    /// </summary>
    public int? AtrybutyTypWymiaru { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? AtrybutyWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? AtrybutyWymTyp { get; set; }

    public int? AtrybutyFormat { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int AtrybutyCzdgid { get; set; }

    public virtual WymCzasDzien AtrybutyCzdg { get; set; } = null!;

    public virtual WymZrodloDanych AtrybutyZrodg { get; set; } = null!;
}
