using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class RsResource
{
    public int RrsId { get; set; }

    public string RrsName { get; set; } = null!;

    public int? RrsRgrid { get; set; }

    public bool? RrsArchival { get; set; }

    public bool? RrsIsGlobal { get; set; }
}
