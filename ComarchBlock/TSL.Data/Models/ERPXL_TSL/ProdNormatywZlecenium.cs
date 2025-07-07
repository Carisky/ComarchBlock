using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdNormatywZlecenium
{
    public int NzpId { get; set; }

    public int? NzpNormatywId { get; set; }

    public int? NzpZlecenie { get; set; }

    public int? NzpZasob { get; set; }

    public int? NzpTimeStamp { get; set; }

    public virtual ProdNormatywRealizacja? NzpNormatyw { get; set; }
}
