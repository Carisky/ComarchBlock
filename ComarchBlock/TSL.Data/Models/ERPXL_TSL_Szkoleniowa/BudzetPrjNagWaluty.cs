using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class BudzetPrjNagWaluty
{
    public int BpnwId { get; set; }

    public int? BpnwBpnid { get; set; }

    public string? BpnwWaluta { get; set; }

    public decimal? BpnwKursM { get; set; }

    public decimal? BpnwKursL { get; set; }

    public virtual BudzetPrjNag? BpnwBpn { get; set; }
}
