using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymLokataStatus
{
    public int LokStRowId { get; set; }

    public int LokStId { get; set; }

    public int LokStZrodgid { get; set; }

    public string LokStOrgId { get; set; } = null!;

    public string LokStDirtyOrgId { get; set; } = null!;

    public string LokStNazwa { get; set; } = null!;

    public string? LokStOpis { get; set; }

    public string? LokStParDirtyOrgId { get; set; }

    public string? LokStParCleanOrgId { get; set; }

    public int? LokStParGid { get; set; }

    public DateTime LokStTsinsert { get; set; }

    public DateTime LokStTsupdate { get; set; }

    public DateTime LokStTimeFrom { get; set; }

    public DateTime? LokStTimeTo { get; set; }

    public int LokStChecksumKimball1 { get; set; }

    public int LokStChecksumKimball2 { get; set; }

    public int LokStUpdateTransformationId { get; set; }

    public int? LokStUpdateSubTransformationId { get; set; }

    public int LokStInsertTransformationId { get; set; }

    public int? LokStInsertSubTransformationId { get; set; }

    public byte[] LokStRowVersion { get; set; } = null!;

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual WymZrodloDanych LokStZrodg { get; set; } = null!;
}
