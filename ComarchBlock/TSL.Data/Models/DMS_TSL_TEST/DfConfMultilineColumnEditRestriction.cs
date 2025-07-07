using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfMultilineColumnEditRestriction
{
    public int MerDkoid { get; set; }

    public int MerDdsid { get; set; }

    public int MerDmcid { get; set; }

    public bool MerBlockEdit { get; set; }

    public bool MerIsArchival { get; set; }
}
