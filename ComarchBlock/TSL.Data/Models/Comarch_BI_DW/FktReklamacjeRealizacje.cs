using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktReklamacjeRealizacje
{
    public int ReklrRkopid { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int ReklrId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ReklrZrodgid { get; set; }

    public int ReklrCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ReklrOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ReklrDirtyOrgId { get; set; } = null!;

    public string? ReklrOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ReklrUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ReklrUpdateSubTransformationId { get; set; }

    public int ReklrInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ReklrInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ReklrTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ReklrTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ReklrElemOrgId { get; set; }

    public string? ReklrOrgAtrId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int ReklrAlokacjaId { get; set; }

    public int ReklrRkreid { get; set; }

    public virtual WymCzasDzien ReklrCzd { get; set; } = null!;
}
