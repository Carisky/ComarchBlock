using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfRbaccess
{
    public int RbaRbdid { get; set; }

    public int RbaDcdid { get; set; }

    public virtual DfConfRbdictionary RbaRbd { get; set; } = null!;
}
