using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class CfgKurierzyPobranieFormyPlat
{
    public int CkfCkfid { get; set; }

    public int CkfCkkid { get; set; }

    public int CkfFplId { get; set; }

    public virtual CfgKurierzy CkfCkk { get; set; } = null!;

    public virtual FormyPlatnosci CkfFpl { get; set; } = null!;
}
