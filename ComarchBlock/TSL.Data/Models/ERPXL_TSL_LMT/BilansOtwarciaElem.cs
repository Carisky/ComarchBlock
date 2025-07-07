using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class BilansOtwarciaElem
{
    public short BoeGidtyp { get; set; }

    public int? BoeGidfirma { get; set; }

    public int BoeGidnumer { get; set; }

    public short BoeGidlp { get; set; }

    public byte? BoeStatus { get; set; }

    public string? BoeKonto { get; set; }

    public decimal? BoeKwotaDebet { get; set; }

    public decimal? BoeKwotaBodebet { get; set; }

    public decimal? BoeKwotaCredit { get; set; }

    public decimal? BoeKwotaBocredit { get; set; }

    public string? BoeOpis { get; set; }

    public short? BoeKntTyp { get; set; }

    public int? BoeKntNumer { get; set; }

    public virtual ICollection<BilansOtwarciaSelem> BilansOtwarciaSelems { get; set; } = new List<BilansOtwarciaSelem>();

    public virtual BilansOtwarciaNag BoeGidnumerNavigation { get; set; } = null!;
}
