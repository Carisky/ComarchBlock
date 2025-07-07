using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class GrupyJezykObcy
{
    public int GruJGruJid { get; set; }

    public int GruJGruId { get; set; }

    public short GruJJezykId { get; set; }

    public string GruJNazwa { get; set; } = null!;

    public virtual Grupy GruJGru { get; set; } = null!;
}
