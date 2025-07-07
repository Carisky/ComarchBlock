using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// Program Lojalnościowy
/// </summary>
public partial class FktProgramLojalnosciowy
{
    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int PrlKntGid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension. Data odstąpinia od programu lojalnościowego.
    /// </summary>
    public int PrlCzdodgid { get; set; }

    public int PrlId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PrlZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension. Data przystąpienia do programu lojalnościowego.
    /// </summary>
    public int PrlCzdgid { get; set; }

    public string PrlOrgId { get; set; } = null!;

    public string PrlDirtyOrgId { get; set; } = null!;

    public string? PrlOpis { get; set; }

    public DateTime PrlTsinsert { get; set; }

    public DateTime PrlTsupdate { get; set; }

    public int PrlUpdateSubTransformationId { get; set; }

    public int? PrlUpdateTransformationId { get; set; }

    public int PrlInsertSubTransformationId { get; set; }

    public int? PrlInsertTransformationId { get; set; }

    /// <summary>
    /// Korekta punktów w programie lojalnościowym
    /// </summary>
    public decimal? PrlMpunktyKorekta { get; set; }

    /// <summary>
    /// Punkty przyznane w programie lojalnościowym
    /// </summary>
    public decimal? PrlMpunkty { get; set; }

    /// <summary>
    /// Punkty odebrane w programie lojalnościowym
    /// </summary>
    public decimal? PrlMpunktyOdebr { get; set; }

    /// <summary>
    /// Punkty naliczone w programie lojalnościowym
    /// </summary>
    public decimal? PrlMpunktyNalicz { get; set; }

    public virtual WymCzasDzien PrlCzdg { get; set; } = null!;

    public virtual WymCzasDzien PrlCzdodg { get; set; } = null!;
}
