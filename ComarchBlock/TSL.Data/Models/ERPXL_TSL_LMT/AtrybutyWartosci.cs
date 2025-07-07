using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class AtrybutyWartosci
{
    public int AtWId { get; set; }

    public int AtWAtKid { get; set; }

    public string AtWWartosc { get; set; } = null!;

    public int? AtWOddZrdId { get; set; }

    public int? AtWCzasModyfikacji { get; set; }

    public short? AtWLp { get; set; }

    public virtual AtrybutyKlasy AtWAtK { get; set; } = null!;
}
