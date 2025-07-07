using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class SbSession
{
    public int SbsId { get; set; }

    public int SbsDcdid { get; set; }

    public Guid SbsGuid { get; set; }

    public byte SbsStatus { get; set; }

    public DateTime SbsLastActivityTime { get; set; }
}
