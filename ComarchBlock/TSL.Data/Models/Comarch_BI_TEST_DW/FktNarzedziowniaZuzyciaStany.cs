using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktNarzedziowniaZuzyciaStany
{
    /// <summary>
    /// Relation to dimension Narzedzia
    /// </summary>
    public int NzsNdzgid { get; set; }

    public int NzsId { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int NzsCzdgid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int NzsZrodgid { get; set; }

    public string NzsOrgId { get; set; } = null!;

    public string NzsDirtyOrgId { get; set; } = null!;

    public string? NzsOpis { get; set; }

    public DateTime NzsTsinsert { get; set; }

    public DateTime NzsTsupdate { get; set; }

    public int NzsUpdateSubTransformationId { get; set; }

    public int? NzsUpdateTransformationId { get; set; }

    public int NzsInsertSubTransformationId { get; set; }

    public int? NzsInsertTransformationId { get; set; }

    public decimal? NzsProcent { get; set; }

    public virtual WymCzasDzien NzsCzdg { get; set; } = null!;

    public virtual WymNarzedzium NzsNdzg { get; set; } = null!;

    public virtual WymZrodloDanych NzsZrodg { get; set; } = null!;
}
