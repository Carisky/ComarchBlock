using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DeklVuek
{
    public int DvuDvuid { get; set; }

    public int DvuByloJest { get; set; }

    public string DvuByloJestString { get; set; } = null!;

    public int DvuDkNid { get; set; }

    public string DvuKraj { get; set; } = null!;

    public decimal? DvuKwota { get; set; }

    public int DvuLp { get; set; }

    public string DvuNip { get; set; } = null!;

    public string? DvuNip2 { get; set; }

    public int? DvuTt { get; set; }

    public string? DvuTtstring { get; set; }

    public int DvuTyp { get; set; }

    public int DvuZnumer { get; set; }

    public virtual DeklNag DvuDkN { get; set; } = null!;
}
