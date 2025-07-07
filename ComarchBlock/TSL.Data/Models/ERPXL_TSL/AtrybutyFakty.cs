using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class AtrybutyFakty
{
    public int AtFObtyp { get; set; }

    public short AtFElement { get; set; }

    public int AtFKosId { get; set; }

    public int AtFFakId { get; set; }

    public virtual Fakty AtFFak { get; set; } = null!;

    public virtual Kostki AtFKos { get; set; } = null!;

    public virtual ICollection<AtrybutyObiektyFakty> AtrybutyObiektyFakties { get; set; } = new List<AtrybutyObiektyFakty>();
}
