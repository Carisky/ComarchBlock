using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymPlacaSkladnik
{
    public int PskRowId { get; set; }

    public int PskId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PskZrodgid { get; set; }

    public string PskOrgId { get; set; } = null!;

    public string PskDirtyOrgId { get; set; } = null!;

    public string PskNazwa { get; set; } = null!;

    public string? PskOpis { get; set; }

    public string? PskParDirtyOrgId { get; set; }

    public string? PskParCleanOrgId { get; set; }

    public int? PskParGid { get; set; }

    public DateTime PskTsinsert { get; set; }

    public DateTime PskTsupdate { get; set; }

    public DateTime PskTimeFrom { get; set; }

    public DateTime? PskTimeTo { get; set; }

    public int PskChecksumKimball1 { get; set; }

    public int PskChecksumKimball2 { get; set; }

    public int PskUpdateSubTransformationId { get; set; }

    public int? PskUpdateTransformationId { get; set; }

    public int PskInsertSubTransformationId { get; set; }

    public int? PskInsertTransformationId { get; set; }

    public byte[] PskRowVersion { get; set; } = null!;

    public bool? PskPracodawca { get; set; }

    public string? PskParent { get; set; }

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplaties { get; set; } = new List<FktPracownikWyplaty>();

    public virtual WymZrodloDanych PskZrodg { get; set; } = null!;
}
