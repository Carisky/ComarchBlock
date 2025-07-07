using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class OcFilelock
{
    public int OcfId { get; set; }

    public string OcfResourceId { get; set; } = null!;

    public string OcfFilePath { get; set; } = null!;

    public string OcfFileProcessId { get; set; } = null!;

    public string OcfInstanceId { get; set; } = null!;

    public string OcfMachineName { get; set; } = null!;

    public string OcfWindowsLogin { get; set; } = null!;

    public int OcfProcessId { get; set; }

    public int OcfApdid { get; set; }

    public int OcfOperatorId { get; set; }

    public DateTime OcfLockDate { get; set; }

    public DateTime OcfLockExpiration { get; set; }
}
