using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class StackColumnValue
{
    public int ScvId { get; set; }

    public int ScvTblid { get; set; }

    public int ScvFldid { get; set; }

    public string ScvValue { get; set; } = null!;

    public virtual Field ScvFld { get; set; } = null!;

    public virtual Table ScvTbl { get; set; } = null!;
}
