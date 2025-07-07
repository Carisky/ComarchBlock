using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymListyPlac
{
    public int LplRowId { get; set; }

    public int LplId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int LplZrodgid { get; set; }

    public string LplOrgId { get; set; } = null!;

    public string LplDirtyOrgId { get; set; } = null!;

    public string? LplNazwa { get; set; }

    public string? LplOpis { get; set; }

    public string? LplParDirtyOrgId { get; set; }

    public string? LplParCleanOrgId { get; set; }

    public int? LplParGid { get; set; }

    public DateTime LplTsinsert { get; set; }

    public DateTime LplTsupdate { get; set; }

    public DateTime LplTimeFrom { get; set; }

    public DateTime? LplTimeTo { get; set; }

    public int LplChecksumKimball1 { get; set; }

    public int LplChecksumKimball2 { get; set; }

    public int LplUpdateSubTransformationId { get; set; }

    public int? LplUpdateTransformationId { get; set; }

    public int LplInsertSubTransformationId { get; set; }

    public int? LplInsertTransformationId { get; set; }

    public byte[] LplRowVersion { get; set; } = null!;

    public string? LplListaPlac { get; set; }

    public string? LplWyplata { get; set; }

    public string? LplElementWyplaty { get; set; }

    public string? LplTypWyplaty { get; set; }

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplaties { get; set; } = new List<FktPracownikWyplaty>();

    public virtual WymZrodloDanych LplZrodg { get; set; } = null!;
}
