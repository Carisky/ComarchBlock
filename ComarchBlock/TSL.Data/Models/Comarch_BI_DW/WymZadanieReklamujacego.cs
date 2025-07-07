using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymZadanieReklamujacego
{
    public int RzrkRowId { get; set; }

    public int RzrkId { get; set; }

    public int RzrkZrodgid { get; set; }

    public string RzrkOrgId { get; set; } = null!;

    public string RzrkDirtyOrgId { get; set; } = null!;

    public string RzrkNazwa { get; set; } = null!;

    public string? RzrkOpis { get; set; }

    public string? RzrkParDirtyOrgId { get; set; }

    public string? RzrkParCleanOrgId { get; set; }

    public int? RzrkParGid { get; set; }

    public DateTime RzrkTsinsert { get; set; }

    public DateTime RzrkTsupdate { get; set; }

    public DateTime RzrkTimeFrom { get; set; }

    public DateTime? RzrkTimeTo { get; set; }

    public int RzrkChecksumKimball1 { get; set; }

    public int RzrkChecksumKimball2 { get; set; }

    public int RzrkUpdateTransformationId { get; set; }

    public int? RzrkUpdateSubTransformationId { get; set; }

    public int RzrkInsertTransformationId { get; set; }

    public int? RzrkInsertSubTransformationId { get; set; }

    public byte[] RzrkRowVersion { get; set; } = null!;

    public virtual WymZrodloDanych RzrkZrodg { get; set; } = null!;
}
