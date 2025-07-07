using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktKursyWalut
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int KrwId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int KrwZrodgid { get; set; }

    /// <summary>
    /// Identyfikator daty dla której obowiązuje kurs. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int KrwCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KrwOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KrwDirtyOrgId { get; set; } = null!;

    public string? KrwOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int KrwUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KrwUpdateSubTransformationId { get; set; }

    public int KrwInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KrwInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KrwTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KrwTsupdate { get; set; }

    /// <summary>
    /// Średni kurs NBP waluty na dany dzień.
    /// </summary>
    public decimal? KrwSredniNbp { get; set; }

    /// <summary>
    /// Identyfikator waluty. Relacja do wymiaru WYM_Waluta
    /// </summary>
    public int KrwWalutaId { get; set; }

    public virtual WymCzasDzien KrwCzd { get; set; } = null!;

    public virtual WymWalutum KrwWaluta { get; set; } = null!;

    public virtual WymZrodloDanych KrwZrodg { get; set; } = null!;
}
