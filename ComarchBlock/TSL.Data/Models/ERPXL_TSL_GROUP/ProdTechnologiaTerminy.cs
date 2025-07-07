using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdTechnologiaTerminy
{
    public int PtrId { get; set; }

    public int? PtrTechnologiaId { get; set; }

    public int? PtrTerminOd { get; set; }

    public int? PtrTerminDo { get; set; }

    public virtual ProdTechnologium? PtrTechnologia { get; set; }
}
