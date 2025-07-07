using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PicoDaneA
{
    public int PcAId { get; set; }

    public int? PcAPicoId { get; set; }

    public short? PcATyp { get; set; }

    public DateTime? PcAData { get; set; }

    public string? PcAOpis { get; set; }

    public byte[]? PcADane { get; set; }
}
