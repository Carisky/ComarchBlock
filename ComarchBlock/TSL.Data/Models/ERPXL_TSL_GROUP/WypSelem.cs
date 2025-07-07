using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class WypSelem
{
    public int WpsWplid { get; set; }

    public int WpsWpeid { get; set; }

    public int WpsPesid { get; set; }

    public byte WpsTyp { get; set; }

    public int WpsZrdId { get; set; }

    public decimal? WpsWartosc { get; set; }

    public byte? WpsEdytowany { get; set; }

    public short? WpsDniKalendarzowe { get; set; }

    public short? WpsDniRobocze { get; set; }

    public int? WpsCzas { get; set; }
}
