using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymWyplataKategorium
{
    public int WktRowId { get; set; }

    public int WktId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int WktZrodgid { get; set; }

    public string WktOrgId { get; set; } = null!;

    public string WktDirtyOrgId { get; set; } = null!;

    public string WktNazwa { get; set; } = null!;

    public string? WktOpis { get; set; }

    public string? WktParDirtyOrgId { get; set; }

    public string? WktParOrgId { get; set; }

    public int? WktParId { get; set; }

    public DateTime WktTsinsert { get; set; }

    public DateTime WktTsupdate { get; set; }

    public DateTime WktTimeFrom { get; set; }

    public DateTime? WktTimeTo { get; set; }

    public int WktChecksumKimball1 { get; set; }

    public int WktChecksumKimball2 { get; set; }

    public int? WktUpdateSubTransformationId { get; set; }

    public int? WktUpdateTransformationId { get; set; }

    public int? WktInsertSubTransformationId { get; set; }

    public int? WktInsertTransformationId { get; set; }

    public byte[] WktRowVersion { get; set; } = null!;

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplatyKwtWktwypEles { get; set; } = new List<FktPracownikWyplaty>();

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplatyKwtWktwyps { get; set; } = new List<FktPracownikWyplaty>();

    public virtual WymZrodloDanych WktZrodg { get; set; } = null!;
}
