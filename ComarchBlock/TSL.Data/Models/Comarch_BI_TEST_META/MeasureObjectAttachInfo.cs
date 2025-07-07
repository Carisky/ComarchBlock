using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class MeasureObjectAttachInfo
{
    public int MoaiId { get; set; }

    public string MoaiObjId { get; set; } = null!;

    public string MoaiObjName { get; set; } = null!;

    public string MoaiAotid { get; set; } = null!;

    public string MoaiParentId { get; set; } = null!;

    public string MoaiParentName { get; set; } = null!;

    public string MoaiAttachedToObjId { get; set; } = null!;

    public string MoaiAttachedToObjName { get; set; } = null!;

    public bool MoaiIsVisible { get; set; }

    public bool MoaiIsAttached { get; set; }

    public string? MoaiData { get; set; }

    public DateTime MoaiTsinsert { get; set; }

    public DateTime MoaiTsupdate { get; set; }

    public string MoaiInfoKind { get; set; } = null!;
}
