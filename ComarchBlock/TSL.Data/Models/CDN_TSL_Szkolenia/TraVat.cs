using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TraVat
{
    public int TrVTrVid { get; set; }

    public int TrVTrNid { get; set; }

    public int? TrVTrNidFinalna { get; set; }

    public decimal TrVStawka { get; set; }

    public short TrVFlaga { get; set; }

    public decimal TrVZrodlowa { get; set; }

    public decimal TrVNetto { get; set; }

    public decimal TrVVat { get; set; }

    public decimal TrVNettoWal { get; set; }

    public decimal TrVVatwal { get; set; }

    public byte TrVTyp { get; set; }

    public virtual TraNag TrVTrN { get; set; } = null!;
}
