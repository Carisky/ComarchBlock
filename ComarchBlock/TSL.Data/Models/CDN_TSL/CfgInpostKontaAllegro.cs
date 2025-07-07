using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class CfgInpostKontaAllegro
{
    public int CikaCikaid { get; set; }

    public string CikaLogin { get; set; } = null!;

    public string CikaUserId { get; set; } = null!;

    public byte CikaDomyslne { get; set; }
}
