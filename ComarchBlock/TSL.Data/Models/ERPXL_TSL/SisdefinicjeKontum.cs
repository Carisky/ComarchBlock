using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SisdefinicjeKontum
{
    public int SiskSisnumer { get; set; }

    public short SiskLp { get; set; }

    public string? SiskKonto { get; set; }

    public string? SiskKlasaKonta { get; set; }

    public int? SiskZknnumer { get; set; }

    public string? SiskZknpozycja { get; set; }

    public virtual Sisdefinicje SiskSisnumerNavigation { get; set; } = null!;
}
