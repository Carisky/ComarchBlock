using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PicoRelacje
{
    public int PcRId { get; set; }

    public short PcRObityp { get; set; }

    public int PcRObinumer { get; set; }

    public short? PcRObi2typ { get; set; }

    public int? PcRObi2numer { get; set; }

    public byte? PcRDostepny { get; set; }

    public virtual PicoKonfig PcR { get; set; } = null!;
}
