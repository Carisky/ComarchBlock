using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SkladnikiCelne
{
    public int? SkcKcid { get; set; }

    public short SkcTwrTyp { get; set; }

    public int? SkcTwrFirma { get; set; }

    public int SkcTwrNumer { get; set; }

    public short SkcTwrLp { get; set; }

    public virtual KategorieCelne? SkcKc { get; set; }

    public virtual TwrKarty SkcTwrNumerNavigation { get; set; } = null!;
}
