using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdIoTregulyDefinicji
{
    public int PirdId { get; set; }

    public int? PirdDefZdarzeniaId { get; set; }

    public int? PirdRegulaId { get; set; }

    public int? PirdDataDolaczenia { get; set; }

    public int? PirdOpeDolaczajacy { get; set; }

    public virtual ProdIoTzdarzeniaDefinicje? PirdDefZdarzenia { get; set; }
}
