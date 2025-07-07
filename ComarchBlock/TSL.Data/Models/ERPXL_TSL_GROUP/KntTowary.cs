using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class KntTowary
{
    public short KtwKntTyp { get; set; }

    public int? KtwKntFirma { get; set; }

    public int KtwKntNumer { get; set; }

    public short? KtwKntLp { get; set; }

    public short KtwTwrTyp { get; set; }

    public int? KtwTwrFirma { get; set; }

    public int KtwTwrNumer { get; set; }

    public short? KtwTwrLp { get; set; }

    public decimal? KtwIlosc { get; set; }

    public int? KtwTstamp { get; set; }

    public virtual ICollection<KntZasoby> KntZasobies { get; set; } = new List<KntZasoby>();

    public virtual TwrKarty KtwTwrNumerNavigation { get; set; } = null!;
}
