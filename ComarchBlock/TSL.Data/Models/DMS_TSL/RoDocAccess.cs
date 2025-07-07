using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class RoDocAccess
{
    public int DfhId { get; set; }

    public int DshId { get; set; }

    public int DwdId { get; set; }

    public int DwsId { get; set; }

    public string? DwdFullNumber { get; set; }

    public string? DdsName { get; set; }

    public DateTime DwdCreateDate { get; set; }

    public int? DwdMonth { get; set; }

    public int? DwdYear { get; set; }

    public int DwdDcdownerId { get; set; }

    public int? DcdId { get; set; }
}
