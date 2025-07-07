using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class VatTab7
{
    public int Va7Va7Id { get; set; }

    public int Va7VaNid { get; set; }

    public int Va7RokMiesiac { get; set; }

    public short Va7RodzajZakupu { get; set; }

    public decimal Va7Stawka { get; set; }

    public short Va7Flaga { get; set; }

    public decimal Va7Zrodlowa { get; set; }

    public decimal Va7Netto { get; set; }

    public decimal Va7Vat { get; set; }

    public short Va7Odliczenia { get; set; }

    public virtual VatNag Va7VaN { get; set; } = null!;
}
