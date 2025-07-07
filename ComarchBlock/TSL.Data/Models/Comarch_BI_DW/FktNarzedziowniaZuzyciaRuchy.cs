using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktNarzedziowniaZuzyciaRuchy
{
    /// <summary>
    /// Relation to dimension Narzedzia
    /// </summary>
    public int NzrNdzgid { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int NzrDokNumerGid { get; set; }

    public int NzrId { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int NzrCzdgid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int NzrZrodgid { get; set; }

    public string NzrOrgId { get; set; } = null!;

    public string NzrDirtyOrgId { get; set; } = null!;

    public string? NzrOpis { get; set; }

    public DateTime NzrTsinsert { get; set; }

    public DateTime NzrTsupdate { get; set; }

    public int NzrUpdateSubTransformationId { get; set; }

    public int? NzrUpdateTransformationId { get; set; }

    public int NzrInsertSubTransformationId { get; set; }

    public int? NzrInsertTransformationId { get; set; }

    public decimal? NzrProcent { get; set; }

    public decimal? NzrProcentProd { get; set; }

    public decimal? NzrProcentMat { get; set; }

    public virtual WymCzasDzien NzrCzdg { get; set; } = null!;
}
