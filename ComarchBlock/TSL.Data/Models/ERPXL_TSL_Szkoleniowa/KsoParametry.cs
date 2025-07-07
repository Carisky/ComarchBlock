using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KsoParametry
{
    public short? KspGidtyp { get; set; }

    public int? KspGidfirma { get; set; }

    public int KspGidnumer { get; set; }

    public short KspGidlp { get; set; }

    public int KspKlpid { get; set; }

    public string? KspWyrazenie { get; set; }

    public virtual KsoElem KsoElem { get; set; } = null!;

    public virtual KluczeParametry KspKlp { get; set; } = null!;
}
