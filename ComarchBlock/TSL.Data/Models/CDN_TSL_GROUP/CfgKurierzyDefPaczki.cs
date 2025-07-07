using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class CfgKurierzyDefPaczki
{
    public int CkpCkpid { get; set; }

    public int CkpCkkid { get; set; }

    public decimal CkpWaga { get; set; }

    public decimal CkpWysokosc { get; set; }

    public decimal CkpSzerokosc { get; set; }

    public decimal CkpDlugosc { get; set; }

    public string CkpSposobPakowania { get; set; } = null!;

    public string CkpSposobPakowaniaKey { get; set; } = null!;

    public int CkpGabaryt { get; set; }

    public int CkpOstroznie { get; set; }

    public int CkpNiestandardowa { get; set; }

    public virtual CfgKurierzy CkpCkk { get; set; } = null!;
}
