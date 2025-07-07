using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdObiektyCzujniki
{
    public int PocId { get; set; }

    public int? PocPczuid { get; set; }

    public int? PocPobid { get; set; }

    public int? PocAktywnyOd { get; set; }

    public int? PocAktywnyDo { get; set; }

    public int? PocOpeDolaczajacy { get; set; }

    public virtual ProdIoTczujniki? PocPczu { get; set; }

    public virtual ProdObiekty? PocPob { get; set; }
}
