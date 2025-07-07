using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProgiPromocje
{
    public int PrpId { get; set; }

    public int? PrpPrmId { get; set; }

    public byte? PrpRodzaj { get; set; }

    public decimal? PrpWartosc { get; set; }

    public int? PrpMinIloscPoz { get; set; }

    public byte? PrpEdycjaGratisow { get; set; }

    public string? PrpJmZ { get; set; }

    public string? PrpGuid { get; set; }

    public virtual ICollection<ProgiTwrPromocje> ProgiTwrPromocjes { get; set; } = new List<ProgiTwrPromocje>();

    public virtual PrmKarty? PrpPrm { get; set; }
}
