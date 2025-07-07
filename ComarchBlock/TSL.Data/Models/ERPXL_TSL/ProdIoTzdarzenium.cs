using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdIoTzdarzenium
{
    public int PczzId { get; set; }

    public int? PczzPczuid { get; set; }

    public int? PczzDefZdarzeniaId { get; set; }

    public int? PczzTimestamp { get; set; }

    public string? PczzZdarzenie { get; set; }

    public virtual ProdIoTzdarzeniaDefinicje? PczzDefZdarzenia { get; set; }

    public virtual ProdIoTczujniki? PczzPczu { get; set; }
}
