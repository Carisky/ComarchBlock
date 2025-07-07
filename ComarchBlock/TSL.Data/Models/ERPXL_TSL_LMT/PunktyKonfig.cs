using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PunktyKonfig
{
    public int PuKId { get; set; }

    public short? PuKObiTyp { get; set; }

    public int? PuKObiNumer { get; set; }

    public int? PuKOkresOd { get; set; }

    public int? PuKOkresDo { get; set; }

    public decimal? PuKPunkty { get; set; }

    public decimal? PuKWartoscPunkt { get; set; }

    public byte? PuKWartoscNbpunkt { get; set; }

    public byte? PuKSposobLiczPunkt { get; set; }

    public byte? PuKNagroda { get; set; }

    public decimal? PuKNagrodaPunkty { get; set; }

    public int? PuKOpeNumerU { get; set; }

    public int? PuKDataUtworzenia { get; set; }

    public int? PuKOpeNumerM { get; set; }

    public int? PuKDataModyfikacji { get; set; }
}
