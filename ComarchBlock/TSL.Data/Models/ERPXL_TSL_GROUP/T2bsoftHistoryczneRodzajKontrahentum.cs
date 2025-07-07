using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class T2bsoftHistoryczneRodzajKontrahentum
{
    public long HrkId { get; set; }

    public int? HrkKntNumer { get; set; }

    public string? HrkAkronim { get; set; }

    public int? HrkPtold { get; set; }

    public int? HrkOtold { get; set; }

    public int? HrkDpold { get; set; }

    public int? HrkRodzajKntOld { get; set; }

    public int? HrkOstatniaTrn { get; set; }

    public int? HrkCzyNowaTrn { get; set; }

    public int? HrkPtnew { get; set; }

    public int? HrkOtnew { get; set; }

    public int? HrkDpnew { get; set; }

    public int? HrkRodzajKntNew { get; set; }
}
