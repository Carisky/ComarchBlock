using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class TwrWzCeny
{
    public short WtcGrpTyp { get; set; }

    public int? WtcGrpFirma { get; set; }

    public int WtcGrpNumer { get; set; }

    public short WtcGrpLp { get; set; }

    public string? WtcWaluta { get; set; }

    public short? WtcNrKursu { get; set; }

    public decimal? WtcMarza { get; set; }

    public decimal? WtcZaok { get; set; }

    public decimal? WtcOffset { get; set; }

    public byte? WtcRodzajPodstawy { get; set; }

    public byte? WtcAktualizacja { get; set; }

    public byte? WtcPriorytet { get; set; }

    public short? WtcKntTyp { get; set; }

    public int? WtcKntFirma { get; set; }

    public int? WtcKntNumer { get; set; }

    public short? WtcKntLp { get; set; }

    public virtual TwrWzorce TwrWzorce { get; set; } = null!;
}
