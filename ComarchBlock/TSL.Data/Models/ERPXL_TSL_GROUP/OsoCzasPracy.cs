using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class OsoCzasPracy
{
    public int OcpId { get; set; }

    public int? OcpOsoNumer { get; set; }

    public int? OcpOsUnumer { get; set; }

    public int? OcpRodzajPracy { get; set; }

    public int? OcpOkresOd { get; set; }

    public int? OcpOkresDo { get; set; }

    public int? OcpCzasPrzerwy { get; set; }

    public byte? OcpNadgodziny { get; set; }

    public virtual PrcKarty? OcpOsoNumerNavigation { get; set; }
}
