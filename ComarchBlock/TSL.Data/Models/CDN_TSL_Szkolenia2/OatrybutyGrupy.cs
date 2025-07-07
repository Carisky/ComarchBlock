using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class OatrybutyGrupy
{
    public int AtgAtgId { get; set; }

    public string AtgNazwa { get; set; } = null!;

    public virtual ICollection<OatrybutyGrupyLinki> OatrybutyGrupyLinkis { get; set; } = new List<OatrybutyGrupyLinki>();
}
