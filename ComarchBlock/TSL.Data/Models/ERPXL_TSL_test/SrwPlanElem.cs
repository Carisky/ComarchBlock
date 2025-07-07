using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class SrwPlanElem
{
    public int SpeSppid { get; set; }

    public int SpeSrUid { get; set; }

    public virtual SrwPlanPrzegladu SpeSpp { get; set; } = null!;

    public virtual ICollection<SrwPlanDokumenty> SrwPlanDokumenties { get; set; } = new List<SrwPlanDokumenty>();
}
