using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SymboleKont
{
    public int SmkId { get; set; }

    public int? SmkNumer { get; set; }

    public string? SmkNazwa { get; set; }

    public string? SmkOpis { get; set; }

    public string? SmkKonto { get; set; }

    public virtual ICollection<KntKontum> KntKonta { get; set; } = new List<KntKontum>();
}
