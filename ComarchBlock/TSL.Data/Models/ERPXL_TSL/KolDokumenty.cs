using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KolDokumenty
{
    public int KdoId { get; set; }

    public short? KdoDokTyp { get; set; }

    public int? KdoDokNumer { get; set; }

    public short? KdoOpeTyp { get; set; }

    public int? KdoOpeNumer { get; set; }

    public int? KdoCzasWyslania { get; set; }

    public int? KdoCzasOddania { get; set; }

    public short? KdoStan { get; set; }
}
