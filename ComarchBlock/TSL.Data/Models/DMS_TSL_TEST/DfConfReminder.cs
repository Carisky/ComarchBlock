using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfReminder
{
    public int CrId { get; set; }

    public string CrGuid { get; set; } = null!;

    public DateTime CrGenerationTime { get; set; }

    public string CrUserId { get; set; } = null!;

    public bool CrUsed { get; set; }
}
