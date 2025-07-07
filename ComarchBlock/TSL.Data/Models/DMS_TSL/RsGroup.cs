using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class RsGroup
{
    public int RgrId { get; set; }

    public string RgrName { get; set; } = null!;

    public bool? RgrArchival { get; set; }
}
