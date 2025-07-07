using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PrzelewyNagPodpisy
{
    public int PpnpPpnid { get; set; }

    public string? PpnpPlikZlecenia { get; set; }

    public string? PpnpPlikSkrot { get; set; }

    public string? PpnpMsgId { get; set; }

    public int? PpnpExpId { get; set; }

    public byte? PpnpLoginTyp { get; set; }

    public virtual PrzelewyNag PpnpPpn { get; set; } = null!;
}
