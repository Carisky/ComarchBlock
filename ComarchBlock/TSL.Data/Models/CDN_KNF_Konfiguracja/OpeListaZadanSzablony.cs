using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OpeListaZadanSzablony
{
    public int OpZsOpZsid { get; set; }

    public string OpZsOpis { get; set; } = null!;

    public int OpZsDlaEwid { get; set; }

    public int OpZsDlaKp { get; set; }

    public int OpZsDlaKh { get; set; }

    public int OpZsCykl { get; set; }

    public int OpZsCyklCo { get; set; }

    public int OpZsCyklDzien { get; set; }

    public DateTime? OpZsCyklStart { get; set; }

    public int OpZsNieaktywny { get; set; }

    public int? OpZsOpeZalId { get; set; }

    public DateTime OpZsTsZal { get; set; }

    public string OpZsOpeZalKod { get; set; } = null!;

    public string OpZsOpeZalNazwisko { get; set; } = null!;

    public int? OpZsOpeModId { get; set; }

    public DateTime OpZsTsMod { get; set; }

    public string OpZsOpeModKod { get; set; } = null!;

    public string OpZsOpeModNazwisko { get; set; } = null!;

    public int? OpZsStaZalId { get; set; }

    public int? OpZsStaModId { get; set; }

    public virtual ICollection<OpeListaZadanSzablonyBazy> OpeListaZadanSzablonyBazies { get; set; } = new List<OpeListaZadanSzablonyBazy>();

    public virtual ICollection<OpeListaZadanSzablonyElem> OpeListaZadanSzablonyElems { get; set; } = new List<OpeListaZadanSzablonyElem>();
}
