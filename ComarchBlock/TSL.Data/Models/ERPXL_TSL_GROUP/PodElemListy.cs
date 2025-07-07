using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PodElemListy
{
    public short PelPontyp { get; set; }

    public int PelPonnumer { get; set; }

    public short PelPoelp { get; set; }

    public int PelPenid { get; set; }

    public int PelDpkid { get; set; }

    public short? PelLpKolumny { get; set; }

    public string? PelWartoscString { get; set; }

    public virtual PodElemNagListy PodElemNagListy { get; set; } = null!;
}
