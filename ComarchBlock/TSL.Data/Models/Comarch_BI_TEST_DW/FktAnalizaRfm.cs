using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

/// <summary>
/// Tabela z danymi do analizy RFM
/// </summary>
public partial class FktAnalizaRfm
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long RfmId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int RfmZrodgid { get; set; }

    /// <summary>
    /// Data sprzedaży. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int RfmCzdid { get; set; }

    /// <summary>
    /// Data sprzedaży. Relacja do wymiaru WYM_CzasMiesiac
    /// </summary>
    public int? RfmCzmid { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta. Realcja do wymiaru Kontrahent.
    /// </summary>
    public int? RfmKntId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RfmCleanOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RfmDirtyOrgId { get; set; } = null!;

    public string? RfmOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int RfmUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RfmUpdateSubTransformationId { get; set; }

    public int RfmInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RfmInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RfmTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RfmTsupdate { get; set; }

    /// <summary>
    /// Wskaźnik aktualności
    /// </summary>
    public int RfmRecency { get; set; }

    /// <summary>
    /// Wskaźnik częstości
    /// </summary>
    public int RfmFrequency { get; set; }

    /// <summary>
    /// Wskaźnik wartości
    /// </summary>
    public int RfmMonetary { get; set; }

    /// <summary>
    /// Wskaźnik RFM
    /// </summary>
    public int? RfmWskaznikRfm { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int RfmAlokacjaId { get; set; }

    public virtual WymAlokacja RfmAlokacja { get; set; } = null!;

    public virtual WymCzasDzien RfmCzd { get; set; } = null!;

    public virtual WymCzasMiesiac? RfmCzm { get; set; }

    public virtual WymKontrahent? RfmKnt { get; set; }

    public virtual WymZrodloDanych RfmZrodg { get; set; } = null!;
}
