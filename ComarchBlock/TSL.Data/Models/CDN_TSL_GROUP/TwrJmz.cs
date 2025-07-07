using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class TwrJmz
{
    public int TwJzTwJzid { get; set; }

    public int TwJzTwrId { get; set; }

    public string TwJzJm { get; set; } = null!;

    public decimal TwJzJmprzelicznikL { get; set; }

    public decimal TwJzJmprzelicznikM { get; set; }

    public int TwJzESklepId { get; set; }

    public byte TwJzESklepDomyslna { get; set; }

    public byte TwJzCenaJednostkowa { get; set; }

    public int? TwJzLp { get; set; }

    public short? TwJzWysCm { get; set; }

    public short? TwJzSzerCm { get; set; }

    public short? TwJzDlugCm { get; set; }

    public virtual Towary TwJzTwr { get; set; } = null!;
}
