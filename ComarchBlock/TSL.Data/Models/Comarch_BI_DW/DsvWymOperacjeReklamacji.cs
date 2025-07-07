using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymOperacjeReklamacji
{
    public int RkopChecksumKimball1 { get; set; }

    public int RkopChecksumKimball2 { get; set; }

    public string RkopDirtyOrgId { get; set; } = null!;

    public int RkopId { get; set; }

    public int? RkopInsertSubTransformationId { get; set; }

    public int RkopInsertTransformationId { get; set; }

    public string RkopNazwa { get; set; } = null!;

    public string? RkopOpis { get; set; }

    public string RkopOrgId { get; set; } = null!;

    public string? RkopParCleanOrgId { get; set; }

    public string? RkopParDirtyOrgId { get; set; }

    public int? RkopParGid { get; set; }

    public int? RkopRowId { get; set; }

    public byte[] RkopRowVersion { get; set; } = null!;

    public DateTime RkopTimeFrom { get; set; }

    public DateTime? RkopTimeTo { get; set; }

    public DateTime RkopTsinsert { get; set; }

    public DateTime RkopTsupdate { get; set; }

    public int? RkopUpdateSubTransformationId { get; set; }

    public int RkopUpdateTransformationId { get; set; }

    public int RkopZrodgid { get; set; }
}
