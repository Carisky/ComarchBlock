using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class OatrybutyGrupy
{
    public int AtgAtgId { get; set; }

    public string AtgNazwa { get; set; } = null!;

    public virtual ICollection<OatrybutyGrupyLinki> OatrybutyGrupyLinkis { get; set; } = new List<OatrybutyGrupyLinki>();
}
