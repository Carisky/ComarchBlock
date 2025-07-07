using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class OatrybutyGrupyLinki
{
    public int AglAglId { get; set; }

    public int AglAtgId { get; set; }

    public int AglAtkId { get; set; }

    public int AglLp { get; set; }

    public string AglNazwaKlasy { get; set; } = null!;

    public virtual OatrybutyGrupy AglAtg { get; set; } = null!;

    public virtual OatrybutyKlasy AglAtk { get; set; } = null!;
}
