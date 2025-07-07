using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktZamienniki
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int ZamId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZamZrodgid { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int ZamCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZamOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZamDirtyOrgId { get; set; } = null!;

    public string? ZamOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZamUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZamUpdateSubTransformationId { get; set; }

    public int ZamInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZamInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZamTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZamTsupdate { get; set; }

    public string? ZamRodzaj { get; set; }

    /// <summary>
    /// Licznik przelicznika
    /// </summary>
    public int? ZamPrzelicznikL { get; set; }

    /// <summary>
    /// Mianownik przelicznika
    /// </summary>
    public int? ZamPrzelicznikM { get; set; }

    /// <summary>
    /// Identyfikator towaru głównego. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int ZamProdId { get; set; }

    /// <summary>
    /// Identyfikator zamiennika. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int ZamZamiennikId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int ZamAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int ZamPrmgid { get; set; }

    public virtual WymCzasDzien ZamCzd { get; set; } = null!;
}
