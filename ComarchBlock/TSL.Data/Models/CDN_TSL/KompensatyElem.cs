using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KompensatyElem
{
    public int KpeKpeid { get; set; }

    public int KpeKpnid { get; set; }

    public int KpeBrkid { get; set; }

    public virtual BnkRozKwoty KpeBrk { get; set; } = null!;

    public virtual KompensatyNag KpeKpn { get; set; } = null!;
}
