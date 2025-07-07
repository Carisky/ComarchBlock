using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DetalStanTwrEan
{
    public int DstwEDstwEid { get; set; }

    public int DstwEDstwrId { get; set; }

    public string DstwEEan { get; set; } = null!;

    public string DstwEOpis { get; set; } = null!;

    public byte DstwEDomyslny { get; set; }

    public string DstwEJm { get; set; } = null!;

    public virtual DetalStanTowary DstwEDstwr { get; set; } = null!;
}
