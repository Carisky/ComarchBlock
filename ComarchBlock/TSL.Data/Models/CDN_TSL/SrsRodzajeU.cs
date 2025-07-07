using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class SrsRodzajeU
{
    public int SrRSrRid { get; set; }

    public string SrRKod { get; set; } = null!;

    public string SrRNazwa { get; set; } = null!;

    public byte SrRNieaktywny { get; set; }

    public int? SrROpeZalId { get; set; }

    public int? SrRStaZalId { get; set; }

    public DateTime SrRTsZal { get; set; }

    public int? SrROpeModId { get; set; }

    public int? SrRStaModId { get; set; }

    public DateTime SrRTsMod { get; set; }

    public string SrROpeModKod { get; set; } = null!;

    public string SrROpeModNazwisko { get; set; } = null!;

    public string SrROpeZalKod { get; set; } = null!;

    public string SrROpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<TwrAtrybuty> TwrAtrybuties { get; set; } = new List<TwrAtrybuty>();
}
