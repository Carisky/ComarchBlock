using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class SrwPlanDokumenty
{
    public int SedSppid { get; set; }

    public int SedSrUid { get; set; }

    public short SedDokTyp { get; set; }

    public int? SedDokFirma { get; set; }

    public int SedDokNumer { get; set; }

    public short SedDokLp { get; set; }

    public virtual SrwPlanElem SrwPlanElem { get; set; } = null!;
}
