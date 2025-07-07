using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymKonwersacja
{
    public int KonwRowId { get; set; }

    public int KonwId { get; set; }

    public int KonwZrodgid { get; set; }

    public string KonwOrgId { get; set; } = null!;

    public string KonwDirtyOrgId { get; set; } = null!;

    public string? KonwParCleanOrgId { get; set; }

    public string? KonwParDirtyOrgId { get; set; }

    public int? KonwParGid { get; set; }

    public string KonwNazwa { get; set; } = null!;

    public string? KonwOpis { get; set; }

    public DateTime KonwTsinsert { get; set; }

    public DateTime KonwTsupdate { get; set; }

    public int? KonwUpdateTransformationId { get; set; }

    public int KonwUpdateSubTransformationId { get; set; }

    public int? KonwInsertTransformationId { get; set; }

    public int KonwInsertSubTransformationId { get; set; }

    public DateTime KonwTimeFrom { get; set; }

    public DateTime? KonwTimeTo { get; set; }

    public int KonwChecksumKimball1 { get; set; }

    public int KonwChecksumKimball2 { get; set; }

    public byte[] KonwRowVersion { get; set; } = null!;

    public string? KonwKlasyfikacja { get; set; }

    public string? KonwKategoria { get; set; }

    public int KonwOpeid { get; set; }

    public virtual ICollection<FktWizytyElement> FktWizytyElements { get; set; } = new List<FktWizytyElement>();

    public virtual WymOperator KonwOpe { get; set; } = null!;

    public virtual WymZrodloDanych KonwZrodg { get; set; } = null!;
}
