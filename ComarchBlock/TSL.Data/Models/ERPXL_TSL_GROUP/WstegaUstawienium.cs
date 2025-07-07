using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class WstegaUstawienium
{
    public int? WstOpeNumer { get; set; }

    public string? WstModul { get; set; }

    public byte? WstTyp { get; set; }

    public string? WstWartosc1 { get; set; }

    public string? WstWartosc2 { get; set; }

    public virtual OpeKarty? WstOpeNumerNavigation { get; set; }
}
