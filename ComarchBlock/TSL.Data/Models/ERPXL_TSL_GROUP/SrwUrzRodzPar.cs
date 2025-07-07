using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrwUrzRodzPar
{
    public int SrpId { get; set; }

    public int? SrpSurid { get; set; }

    public int? SrpSudid { get; set; }

    public short? SrpLp { get; set; }

    public virtual SrwUrzParDef? SrpSud { get; set; }

    public virtual SrwUrzRodzaje? SrpSur { get; set; }
}
