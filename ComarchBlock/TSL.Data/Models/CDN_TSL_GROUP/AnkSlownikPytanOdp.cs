using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class AnkSlownikPytanOdp
{
    public int AnkSpOAnkSpOid { get; set; }

    public int AnkSpOAnkSpId { get; set; }

    public int? AnkSpOAnkSoNid { get; set; }

    public int? AnkSpOAnkSoEid { get; set; }

    public int AnkSpOLp { get; set; }

    public byte AnkSpOMode { get; set; }

    public decimal AnkSpOPunkty { get; set; }

    public string AnkSpOWartosc { get; set; } = null!;

    public virtual AnkSlownikPytan AnkSpOAnkSp { get; set; } = null!;
}
