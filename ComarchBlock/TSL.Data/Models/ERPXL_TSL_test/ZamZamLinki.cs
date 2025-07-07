using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ZamZamLinki
{
    public short ZzlZzgidTyp { get; set; }

    public int? ZzlZzgidFirma { get; set; }

    public int ZzlZzgidNumer { get; set; }

    public short ZzlZzgidLp { get; set; }

    public short ZzlZsgidTyp { get; set; }

    public int? ZzlZsgidFirma { get; set; }

    public int ZzlZsgidNumer { get; set; }

    public short ZzlZsgidLp { get; set; }

    public short? ZzlKierunek { get; set; }

    public decimal? ZzlZwiazanaIlosc { get; set; }
}
