using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymGeografium
{
    public int GeoId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? GeoRowId { get; set; }

    public string? GeoGrupaKrajow { get; set; }

    public int? GeoKrajId { get; set; }

    public string? GeoKrajKod { get; set; }

    public string? GeoKraj { get; set; }

    public string? GeoGmina { get; set; }

    public string? GeoPowiat { get; set; }

    public string? GeoWojewodztwo { get; set; }

    public int? GeoGmiid { get; set; }

    public int? GeoPowid { get; set; }

    public int? GeoWojid { get; set; }

    public byte[] GeoRowVersion { get; set; } = null!;

    public int? GeoInsertSubTransformationId { get; set; }

    public int GeoInsertTransformationId { get; set; }

    public int? GeoUpdateSubTransformationId { get; set; }

    public int GeoUpdateTransformationId { get; set; }

    public int GeoChecksumKimball2 { get; set; }

    public int GeoChecksumKimball1 { get; set; }

    public DateTime? GeoTimeTo { get; set; }

    public DateTime GeoTimeFrom { get; set; }

    public DateTime GeoTsupdate { get; set; }

    public DateTime GeoTsinsert { get; set; }

    public int? GeoParGid { get; set; }

    public string? GeoParOrgId { get; set; }

    public string? GeoParDirtyOrgId { get; set; }

    public string? GeoOpis { get; set; }

    public string GeoNazwa { get; set; } = null!;

    public string GeoDirtyOrgId { get; set; } = null!;

    public string GeoOrgId { get; set; } = null!;

    public int GeoZrodgid { get; set; }
}
