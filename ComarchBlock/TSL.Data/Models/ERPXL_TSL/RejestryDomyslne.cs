using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class RejestryDomyslne
{
    public int RdwId { get; set; }

    public short? RdwWanId { get; set; }

    public int? RdwKarNumer { get; set; }

    public int? RdwFrsId { get; set; }

    public virtual FrmStruktura? RdwFrs { get; set; }

    public virtual Rejestry? RdwKarNumerNavigation { get; set; }

    public virtual WalNag? RdwWan { get; set; }
}
