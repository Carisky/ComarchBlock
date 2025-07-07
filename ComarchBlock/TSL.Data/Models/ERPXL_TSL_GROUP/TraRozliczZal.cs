using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class TraRozliczZal
{
    public short TrzZalTyp { get; set; }

    public int TrzZalNumer { get; set; }

    public short TrzKonTyp { get; set; }

    public int TrzKonNumer { get; set; }

    public decimal TrzStawkaPod { get; set; }

    public byte TrzFlagaVat { get; set; }

    public decimal TrzZrodlowa { get; set; }

    public short TrzDeklRok { get; set; }

    public short TrzDeklMiesiac { get; set; }

    public byte TrzRodzajZakupu { get; set; }

    public byte TrzOdliczeniaVat { get; set; }

    public byte TrzRozliczac { get; set; }

    public byte TrzStruktura { get; set; }

    public byte TrzRozliczacP { get; set; }

    public decimal? TrzKwotaRozliczona { get; set; }

    public virtual TraNag TrzKonNumerNavigation { get; set; } = null!;
}
