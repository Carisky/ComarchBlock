using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class FieldSettingsForUser
{
    public int FseId { get; set; }

    public int FseFldid { get; set; }

    public int FseUsrid { get; set; }

    public bool FseVisible { get; set; }

    public bool FseReadOnly { get; set; }

    public DateTime? FseInsert { get; set; }

    public DateTime? FseUpdate { get; set; }

    public virtual Field FseFld { get; set; } = null!;

    public virtual ApplicationUser FseUsr { get; set; } = null!;
}
