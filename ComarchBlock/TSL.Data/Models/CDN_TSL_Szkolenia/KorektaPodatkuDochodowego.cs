using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class KorektaPodatkuDochodowego
{
    public int KpdKpdid { get; set; }

    public string KpdNumer { get; set; } = null!;

    public DateTime KpdData { get; set; }

    public decimal KpdKoszty { get; set; }

    public decimal KpdPrzychody { get; set; }

    public int? KpdReNid { get; set; }

    public short KpdBufor { get; set; }

    public int? KpdKprid { get; set; }

    public virtual RemanentNag? KpdReN { get; set; }
}
