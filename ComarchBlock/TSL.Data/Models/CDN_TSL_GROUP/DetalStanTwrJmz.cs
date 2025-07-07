using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DetalStanTwrJmz
{
    public int DstjzDstjzid { get; set; }

    public int DstjzDstwrId { get; set; }

    public string DstjzJm { get; set; } = null!;

    public decimal DstjzJmprzelicznikL { get; set; }

    public decimal DstjzJmprzelicznikM { get; set; }

    public virtual DetalStanTowary DstjzDstwr { get; set; } = null!;
}
