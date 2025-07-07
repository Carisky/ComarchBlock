using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfSession
{
    public int SId { get; set; }

    public string SOperator { get; set; } = null!;

    public int SOperatorid { get; set; }

    public Guid SGuid { get; set; }

    public DateTime SLastaccess { get; set; }

    public byte SApptype { get; set; }

    public string? SIpAddress { get; set; }
}
