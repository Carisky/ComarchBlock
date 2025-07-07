using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class DataMiningModelViewParameter
{
    public int DmmvpId { get; set; }

    public string DmmvpDmmname { get; set; } = null!;

    public string DmmvpName { get; set; } = null!;

    public string? DmmvpDescription { get; set; }

    public string DmmvpDatid { get; set; } = null!;

    public string? DmmvpFriendlyName { get; set; }

    public string? DmmvpDefaultValue { get; set; }

    public string? DmmvpValue { get; set; }
}
