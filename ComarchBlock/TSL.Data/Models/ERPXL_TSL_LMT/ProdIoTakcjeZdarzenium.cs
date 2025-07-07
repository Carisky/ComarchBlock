using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdIoTakcjeZdarzenium
{
    public int PiazId { get; set; }

    public int? PiazObiNumer { get; set; }

    public short? PiazObiTyp { get; set; }

    public int? PiazLp { get; set; }

    public short? PiazAkcjaTyp { get; set; }

    public int? PiazAkcjaNumer { get; set; }

    public int? PiazDodanyObiekt { get; set; }
}
