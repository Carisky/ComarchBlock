using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KonfProdGrupy
{
    public int KpgId { get; set; }

    public string? KpgNazwa { get; set; }

    public string? KpgOpis { get; set; }

    public virtual ICollection<KonfProdGrupyElem> KonfProdGrupyElems { get; set; } = new List<KonfProdGrupyElem>();

    public virtual ICollection<KonfProdGrupyStruktura> KonfProdGrupyStrukturas { get; set; } = new List<KonfProdGrupyStruktura>();

    public virtual ICollection<KonfProdLinki> KonfProdLinkis { get; set; } = new List<KonfProdLinki>();
}
