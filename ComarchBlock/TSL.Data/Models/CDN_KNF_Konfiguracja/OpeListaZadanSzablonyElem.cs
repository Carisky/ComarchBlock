using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OpeListaZadanSzablonyElem
{
    public int OpZseOpZseid { get; set; }

    public int OpZseSzablonId { get; set; }

    public int OpZseLp { get; set; }

    public string OpZseOpis { get; set; } = null!;

    public virtual OpeListaZadanSzablony OpZseSzablon { get; set; } = null!;
}
