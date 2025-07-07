using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfApiKey
{
    public int ApkId { get; set; }

    public int ApkDcdid { get; set; }

    public int ApkCmdid { get; set; }

    public int ApkAppid { get; set; }

    public Guid ApkGuid { get; set; }

    public bool? ApkRevoked { get; set; }

    public virtual DfApplication ApkApp { get; set; } = null!;

    public virtual DfConfCmdictionary ApkCmd { get; set; } = null!;

    public virtual DfConfOsdictionary ApkDcd { get; set; } = null!;
}
