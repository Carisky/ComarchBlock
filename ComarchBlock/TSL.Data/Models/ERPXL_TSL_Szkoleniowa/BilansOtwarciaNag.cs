using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class BilansOtwarciaNag
{
    public short? BonGidtyp { get; set; }

    public int? BonGidfirma { get; set; }

    public int BonGidnumer { get; set; }

    public short? BonGidlp { get; set; }

    public int? BonRokMiesiac { get; set; }

    public int? BonOkrPoczatek { get; set; }

    public string? BonOkrSymbol { get; set; }

    public byte? BonTyp { get; set; }

    public int? BonDataWprow { get; set; }

    public int? BonNumer { get; set; }

    public byte? BonStatus { get; set; }

    public string? BonOpis { get; set; }

    public short? BonOpewtyp { get; set; }

    public int? BonOpewfirma { get; set; }

    public int? BonOpewnumer { get; set; }

    public short? BonOpewlp { get; set; }

    public short? BonOpeatyp { get; set; }

    public int? BonOpeafirma { get; set; }

    public int? BonOpeanumer { get; set; }

    public short? BonOpealp { get; set; }

    public short? BonOpeztyp { get; set; }

    public int? BonOpezfirma { get; set; }

    public int? BonOpeznumer { get; set; }

    public short? BonOpezlp { get; set; }

    public string? BonCechaOpis { get; set; }

    public byte? BonZapisyZbufora { get; set; }

    public virtual ICollection<BilansOtwarciaElem> BilansOtwarciaElems { get; set; } = new List<BilansOtwarciaElem>();
}
