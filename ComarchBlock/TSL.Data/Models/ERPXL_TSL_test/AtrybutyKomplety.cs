using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class AtrybutyKomplety
{
    public int AkpId { get; set; }

    public string? AkpNazwa { get; set; }

    public int? AkpOptimaId { get; set; }

    public int? AkpCzasModyfikacji { get; set; }

    public virtual ICollection<AtrKompletyLinki> AtrKompletyLinkis { get; set; } = new List<AtrKompletyLinki>();
}
