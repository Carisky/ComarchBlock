using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SrsCennikCzynnosci
{
    public int SccId { get; set; }

    public int? SccSsCid { get; set; }

    public short? SccKntTyp { get; set; }

    public int? SccKntFirma { get; set; }

    public int? SccKntNumer { get; set; }

    public short? SccKntLp { get; set; }

    public byte? SccRodzajKosztu { get; set; }

    public decimal? SccCzasWykonania { get; set; }

    public decimal? SccKosztHczynnosci { get; set; }

    public decimal? SccKosztCzynnosci { get; set; }

    public decimal? SccIlosc { get; set; }

    public virtual SrsCzynnosci? SccSsC { get; set; }
}
