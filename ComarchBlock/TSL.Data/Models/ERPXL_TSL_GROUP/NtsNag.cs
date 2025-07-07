using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class NtsNag
{
    public short? NtNGidtyp { get; set; }

    public int? NtNGidfirma { get; set; }

    public int NtNGidnumer { get; set; }

    public short? NtNGidlp { get; set; }

    public short? NtNOpeTyp { get; set; }

    public int? NtNOpeFirma { get; set; }

    public int? NtNOpeNumer { get; set; }

    public short? NtNOpeLp { get; set; }

    public short? NtNMagTyp { get; set; }

    public int? NtNMagFirma { get; set; }

    public int? NtNMagNumer { get; set; }

    public short? NtNMagLp { get; set; }

    public short? NtNTypDoc { get; set; }

    public string? NtNNazwa { get; set; }

    public decimal? NtNSuma { get; set; }

    public string? NtNOpis { get; set; }

    public string? NtNWaluta { get; set; }

    public decimal? NtNDodajProcent { get; set; }

    public virtual OpeKarty? NtNOpeNumerNavigation { get; set; }

    public virtual ICollection<NtsElem> NtsElems { get; set; } = new List<NtsElem>();

    public virtual ICollection<NtsKnt> NtsKnts { get; set; } = new List<NtsKnt>();
}
