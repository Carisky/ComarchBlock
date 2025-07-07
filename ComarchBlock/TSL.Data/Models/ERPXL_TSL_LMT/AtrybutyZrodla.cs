using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class AtrybutyZrodla
{
    public int AtzId { get; set; }

    public string? AtzNazwa { get; set; }

    public string? AtzOpis { get; set; }

    public string? AtzNazwaObDoc { get; set; }

    public string? AtzSql { get; set; }

    public byte? AtzAktywne { get; set; }

    public int? AtzPredefiniowane { get; set; }

    public virtual ICollection<AtrybutyZrodlaObiekty> AtrybutyZrodlaObiekties { get; set; } = new List<AtrybutyZrodlaObiekty>();
}
