using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class PracaSzczeg
{
    public int SzpSzpid { get; set; }

    public int SzpSzczeg2 { get; set; }

    public int SzpPoziom { get; set; }

    public int SzpWybieralny { get; set; }

    public string SzpOpis { get; set; } = null!;

    public string SzpZjeId { get; set; } = null!;
}
