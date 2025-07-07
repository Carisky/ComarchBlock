using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class RoStageActive
{
    public int DfhId { get; set; }

    public int DshId { get; set; }

    public int DwdId { get; set; }

    public int DwsId { get; set; }

    public int DdsId { get; set; }

    public DateTime DwsCreateDate { get; set; }

    public bool DwsIsCurrent { get; set; }

    public string? DdsName { get; set; }

    public int? DwsDcdpersonId { get; set; }
}
