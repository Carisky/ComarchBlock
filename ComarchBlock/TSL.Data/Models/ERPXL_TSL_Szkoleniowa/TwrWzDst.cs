using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TwrWzDst
{
    public short WtdGrpTyp { get; set; }

    public int? WtdGrpFirma { get; set; }

    public int WtdGrpNumer { get; set; }

    public short WtdGrpLp { get; set; }

    public short? WtdKntTyp { get; set; }

    public int? WtdKntFirma { get; set; }

    public int? WtdKntNumer { get; set; }

    public short? WtdKntLp { get; set; }

    public short WtdKlasaKnt { get; set; }

    public int? WtdDataAkt { get; set; }

    public int? WtdCzas { get; set; }

    public int? WtdOplataSpozZakup { get; set; }

    public decimal? WtdMrpEoq { get; set; }

    public decimal? WtdIloscZam { get; set; }

    public virtual TwrWzorce TwrWzorce { get; set; } = null!;
}
