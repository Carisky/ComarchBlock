using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class NtsElem
{
    public short? NtEGidtyp { get; set; }

    public int? NtEGidfirma { get; set; }

    public int NtEGidnumer { get; set; }

    public short NtEGidlp { get; set; }

    public short? NtETwrTyp { get; set; }

    public int? NtETwrFirma { get; set; }

    public int? NtETwrNumer { get; set; }

    public short? NtETwrLp { get; set; }

    public decimal? NtEIlosc { get; set; }

    public decimal? NtECena { get; set; }

    public decimal? NtERabat { get; set; }

    public virtual NtsNag NtEGidnumerNavigation { get; set; } = null!;
}
