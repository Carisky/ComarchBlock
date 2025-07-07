using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class AnalyticObjectAttachInfo
{
    public int AoaiId { get; set; }

    public string AoaiObjId { get; set; } = null!;

    public string AoaiObjName { get; set; } = null!;

    public string AoaiAotid { get; set; } = null!;

    public string AoaiParentId { get; set; } = null!;

    public string AoaiParentName { get; set; } = null!;

    public string AoaiAttachedToObjId { get; set; } = null!;

    public string AoaiAttachedToObjName { get; set; } = null!;

    public bool AoaiIsVisible { get; set; }

    public bool AoaiIsAttached { get; set; }

    public string? AoaiData { get; set; }

    public DateTime AoaiTsinsert { get; set; }

    public DateTime AoaiTsupdate { get; set; }

    public string AoaiInfoKind { get; set; } = null!;
}
