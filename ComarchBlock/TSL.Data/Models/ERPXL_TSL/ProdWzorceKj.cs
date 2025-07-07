using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdWzorceKj
{
    public int WkjId { get; set; }

    public string? WkjKod { get; set; }

    public string? WkjNazwa { get; set; }

    public int? WkjOpeW { get; set; }

    public int? WkjDataW { get; set; }

    public int? WkjOpeM { get; set; }

    public int? WkjDataM { get; set; }

    public byte? WkjArchiwalny { get; set; }

    public string? WkjUrl { get; set; }

    public string? WkjOpis { get; set; }

    public virtual ICollection<ProdWzorceKjtowary> ProdWzorceKjtowaries { get; set; } = new List<ProdWzorceKjtowary>();
}
