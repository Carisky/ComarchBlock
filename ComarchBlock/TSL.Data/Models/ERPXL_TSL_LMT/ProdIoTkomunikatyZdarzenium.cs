using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdIoTkomunikatyZdarzenium
{
    public int PikzId { get; set; }

    public int? PikzDefZdarzeniaId { get; set; }

    public int? PikzKomunikatIoTid { get; set; }

    public virtual ProdIoTzdarzeniaDefinicje? PikzDefZdarzenia { get; set; }

    public virtual ProdIoTkomunikaty? PikzKomunikatIoT { get; set; }
}
