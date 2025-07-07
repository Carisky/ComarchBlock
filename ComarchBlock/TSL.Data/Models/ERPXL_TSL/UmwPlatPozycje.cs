using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class UmwPlatPozycje
{
    public int UppId { get; set; }

    public short? UppUplTyp { get; set; }

    public int? UppUplFirma { get; set; }

    public int? UppUplNumer { get; set; }

    public short? UppUplLp { get; set; }

    public int? UppUmPid { get; set; }

    public decimal? UppIlosc { get; set; }
}
