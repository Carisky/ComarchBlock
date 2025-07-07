using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkOsclosedDoc
{
    public int WocDwdid { get; set; }

    public int WocDcdid { get; set; }

    public bool? WocIsActive { get; set; }

    public byte WocPermissionSource { get; set; }

    public virtual DfConfOsdictionary WocDcd { get; set; } = null!;

    public virtual DfWork WocDwd { get; set; } = null!;
}
