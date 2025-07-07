using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymPaczka
{
    public int PaczRowId { get; set; }

    public int PaczId { get; set; }

    public int PaczZrodgid { get; set; }

    public string PaczOrgId { get; set; } = null!;

    public string PaczDirtyOrgId { get; set; } = null!;

    public string? PaczParCleanOrgId { get; set; }

    public string? PaczParDirtyOrgId { get; set; }

    public int? PaczParGid { get; set; }

    public string PaczRodzaj { get; set; } = null!;

    public string? PaczOpis { get; set; }

    public DateTime PaczTsinsert { get; set; }

    public DateTime PaczTsupdate { get; set; }

    public int? PaczUpdateTransformationId { get; set; }

    public int PaczUpdateSubTransformationId { get; set; }

    public int? PaczInsertTransformationId { get; set; }

    public int PaczInsertSubTransformationId { get; set; }

    public DateTime PaczTimeFrom { get; set; }

    public DateTime? PaczTimeTo { get; set; }

    public int PaczChecksumKimball1 { get; set; }

    public int PaczChecksumKimball2 { get; set; }

    public byte[] PaczRowVersion { get; set; } = null!;

    public string? PaczStan { get; set; }

    public string? PaczListPrzewozowy { get; set; }

    public string? PaczNaKoszt { get; set; }

    public string? PaczKurier { get; set; }

    public string? PaczRodzajPrzesylki { get; set; }

    public virtual ICollection<FktTransport> FktTransports { get; set; } = new List<FktTransport>();

    public virtual WymZrodloDanych PaczZrodg { get; set; } = null!;
}
