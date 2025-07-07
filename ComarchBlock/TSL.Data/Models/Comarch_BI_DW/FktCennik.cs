using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// Tabela faktów przechowująca informacje o zdefiniowanych cennikach
/// </summary>
public partial class FktCennik
{
    /// <summary>
    /// Identyfikator daty zakonczenia obowiązywania cennika. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int CenDataZakonczeniaId { get; set; }

    /// <summary>
    /// Identyfikator waluty. Relacja do wymiaru WYM_Waluta
    /// </summary>
    public int CenWalutaId { get; set; }

    /// <summary>
    /// Identyfikator daty rozpoczęcia obowiązywania cennika. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int CenDataRozpoczeciaId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int CenProdId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Cennik
    /// </summary>
    public int CenCennikId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int CenId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int CenZrodgid { get; set; }

    /// <summary>
    /// Identyfikator daty rozpoczęcia obowiązywania cennika. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int CenCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CenCleanOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CenDirtyOrgId { get; set; } = null!;

    public string? CenOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int CenUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CenUpdateSubTransformationId { get; set; }

    public int CenInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CenInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CenTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CenTsupdate { get; set; }

    /// <summary>
    /// Cena netto
    /// </summary>
    public decimal? CenMcenaNetto { get; set; }

    /// <summary>
    /// Cena brutto
    /// </summary>
    public decimal? CenMcenaBrutto { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int CenKntId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int CenOperatorId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int CenAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int CenPrmgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int CenOpemgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int CenOpezgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int CenOpewgid { get; set; }

    /// <summary>
    /// Powiązanie z tabelą atrybutów
    /// </summary>
    public string? CenOrgAtrId { get; set; }

    /// <summary>
    /// Cena brutto towaru dla konkretnego cennika
    /// </summary>
    public decimal? CenMcenaBruttoCennik { get; set; }

    /// <summary>
    /// Cena netto towaru dla konkretnego cennika
    /// </summary>
    public decimal? CenMcenaNettoCennik { get; set; }

    public virtual WymCzasDzien CenCzd { get; set; } = null!;

    public virtual WymCzasDzien CenDataRozpoczecia { get; set; } = null!;

    public virtual WymCzasDzien CenDataZakonczenia { get; set; } = null!;
}
