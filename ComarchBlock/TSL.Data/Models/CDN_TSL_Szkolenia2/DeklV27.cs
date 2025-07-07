using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DeklV27
{
    public int V27V27id { get; set; }

    public int V27DkNid { get; set; }

    public decimal? V27Kwota { get; set; }

    public int V27Lp { get; set; }

    public string V27Nip { get; set; } = null!;

    public string? V27Nazwa { get; set; }

    public int V27Numer { get; set; }

    public byte V27Zmiana { get; set; }

    public int V27Typ { get; set; }

    public virtual DeklNag V27DkN { get; set; } = null!;
}
