using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// Tabela faktów przechowująca informację o zapytaniach ofertowych (sprzedaż, zakupy)
/// </summary>
public partial class FktZapytaniaOfertowe
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int ZosId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZosZrodgid { get; set; }

    /// <summary>
    /// Data zapytania ofertowego. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZosCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZosOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZosDirtyOrgId { get; set; } = null!;

    public string? ZosOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZosUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZosUpdateSubTransformationId { get; set; }

    public int ZosInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZosInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZosTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZosTsupdate { get; set; }

    public string? ZosOrgAtrId { get; set; }

    public int? ZosObszar { get; set; }

    /// <summary>
    /// Identyfikator adresu Kontrahenta Docelowego. Relacja do wymiaru WYM_Adres
    /// </summary>
    public int ZosKndAdrId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta docelowego. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZosKnDid { get; set; }

    /// <summary>
    /// Identyfikator Akwizytora. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZosAkwId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int ZosBudzetId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta głównego. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZosKntId { get; set; }

    /// <summary>
    /// Identyfikator operatora modyfikującego zapytanie. Relacja do wymiaru WYM_Operator
    /// </summary>
    public int ZosOperId { get; set; }

    /// <summary>
    /// Identyfikator opiekuna kontrahenta. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int ZosOpiekunId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu zapytania ofertowego. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int ZosDokZapOfeId { get; set; }

    /// <summary>
    /// Różnica w dniach pomiędzy datą wystawienia oferty a datą przyjęcia zapytania ofertowego.
    /// </summary>
    public decimal? ZosMczasRealizacji { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Rejon
    /// </summary>
    public int ZosRejonId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt.
    /// </summary>
    public int ZosProdId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int ZosAlokacjaId { get; set; }

    public string? ZosOrgAtrNagId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int ZosPrmgid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? ZosStrPrwId { get; set; }

    public virtual WymCzasDzien ZosCzd { get; set; } = null!;
}
