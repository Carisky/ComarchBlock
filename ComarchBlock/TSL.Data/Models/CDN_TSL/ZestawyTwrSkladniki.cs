using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class ZestawyTwrSkladniki
{
    public int ZtsZtsid { get; set; }

    public int ZtsZtwId { get; set; }

    public int? ZtsTwrId { get; set; }

    public byte ZtsTypRabatu { get; set; }

    public decimal ZtsWartosc { get; set; }

    public string ZtsWaluta { get; set; } = null!;

    public decimal ZtsIlosc { get; set; }

    public string ZtsJm { get; set; } = null!;

    public virtual Towary? ZtsTwr { get; set; }

    public virtual ZestawyTwr ZtsZtw { get; set; } = null!;
}
