using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TraElemKorZbiorcza
{
    public int TreZTreZid { get; set; }

    public int TreZTrNid { get; set; }

    public decimal TreZStawka { get; set; }

    public short TreZFlaga { get; set; }

    public decimal TreZZrodlowa { get; set; }

    public decimal TreZWartoscFaktur { get; set; }

    public decimal TreZRabat { get; set; }

    public string TreZWaluta { get; set; } = null!;

    public virtual TraNag TreZTrN { get; set; } = null!;
}
