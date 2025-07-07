using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymMaterial
{
    public int MatRowId { get; set; }

    public int MatId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int MatZrodgid { get; set; }

    public string MatOrgId { get; set; } = null!;

    public string MatDirtyOrgId { get; set; } = null!;

    public string MatNazwa { get; set; } = null!;

    public string? MatOpis { get; set; }

    public string? MatParDirtyOrgId { get; set; }

    public string? MatParCleanOrgId { get; set; }

    public int? MatParGid { get; set; }

    public DateTime MatTsinsert { get; set; }

    public DateTime MatTsupdate { get; set; }

    public DateTime MatTimeFrom { get; set; }

    public DateTime? MatTimeTo { get; set; }

    public int MatChecksumKimball1 { get; set; }

    public int MatChecksumKimball2 { get; set; }

    public int MatUpdateSubTransformationId { get; set; }

    public int? MatUpdateTransformationId { get; set; }

    public int MatInsertSubTransformationId { get; set; }

    public int? MatInsertTransformationId { get; set; }

    public byte[] MatRowVersion { get; set; } = null!;

    public string? MatKod { get; set; }

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowas { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual WymZrodloDanych MatZrodg { get; set; } = null!;
}
