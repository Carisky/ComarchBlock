using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymOperacjeReklamacji
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int RkopRowId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int RkopId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int RkopZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RkopOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RkopDirtyOrgId { get; set; } = null!;

    public string RkopNazwa { get; set; } = null!;

    public string? RkopOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? RkopParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? RkopParCleanOrgId { get; set; }

    public int? RkopParGid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RkopTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RkopTsupdate { get; set; }

    public DateTime RkopTimeFrom { get; set; }

    public DateTime? RkopTimeTo { get; set; }

    public int RkopChecksumKimball1 { get; set; }

    public int RkopChecksumKimball2 { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int RkopUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RkopUpdateSubTransformationId { get; set; }

    public int RkopInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RkopInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] RkopRowVersion { get; set; } = null!;

    public virtual ICollection<FktReklamacjeRealizacje> FktReklamacjeRealizacjes { get; set; } = new List<FktReklamacjeRealizacje>();

    public virtual WymZrodloDanych RkopZrodg { get; set; } = null!;
}
