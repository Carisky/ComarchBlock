using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DaneKadStr
{
    public int DktDktId { get; set; }

    public string DktKod { get; set; } = null!;

    public byte DktRodzaj { get; set; }

    public int DktPoziom { get; set; }

    public int DktWybieralny { get; set; }

    public string DktOpis { get; set; } = null!;

    public string DktZjeId { get; set; } = null!;
}
