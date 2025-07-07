using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfApfolderPath
{
    public int ApfApdid { get; set; }

    public int ApfDcdid { get; set; }

    public string ApfFolderPath { get; set; } = null!;

    public string? ApfWindowsLogin { get; set; }

    public virtual DfConfApdictionary ApfApd { get; set; } = null!;

    public virtual DfConfOsdictionary ApfDcd { get; set; } = null!;
}
