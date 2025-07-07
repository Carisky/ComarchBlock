using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class SenditTypyPaczek
{
    public DateTime StpData { get; set; }

    public string StpSposobPakowaniaKey { get; set; } = null!;

    public string StpSposobPakowania { get; set; } = null!;
}
