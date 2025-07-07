using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymWyplataKategorium
{
    public int WktChecksumKimball1 { get; set; }

    public int WktChecksumKimball2 { get; set; }

    public string WktDirtyOrgId { get; set; } = null!;

    public int WktId { get; set; }

    public int? WktInsertSubTransformationId { get; set; }

    public int? WktInsertTransformationId { get; set; }

    public string WktNazwa { get; set; } = null!;

    public string? WktOpis { get; set; }

    public string WktOrgId { get; set; } = null!;

    public string? WktParDirtyOrgId { get; set; }

    public int? WktParId { get; set; }

    public string? WktParOrgId { get; set; }

    public int? WktRowId { get; set; }

    public byte[] WktRowVersion { get; set; } = null!;

    public DateTime WktTimeFrom { get; set; }

    public DateTime? WktTimeTo { get; set; }

    public DateTime WktTsinsert { get; set; }

    public DateTime WktTsupdate { get; set; }

    public int? WktUpdateSubTransformationId { get; set; }

    public int? WktUpdateTransformationId { get; set; }

    public int WktZrodgid { get; set; }
}
