using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdWzorceKosztow
{
    public int PwkId { get; set; }

    public string? PwkKod { get; set; }

    public string? PwkNazwa { get; set; }

    public int? PwkOpeW { get; set; }

    public int? PwkOpeM { get; set; }

    public int? PwkDataW { get; set; }

    public int? PwkDataM { get; set; }

    public byte? PwkDostepnyDla { get; set; }

    public byte? PwkDomyslny { get; set; }

    public int? PwkKategoria { get; set; }

    public byte? PwkKlucz { get; set; }

    public string? PwkOpis { get; set; }

    public byte? PwkArchiwalny { get; set; }

    public byte? PwkEdycja { get; set; }

    public virtual ICollection<ProdWzorceKosztowWarunki> ProdWzorceKosztowWarunkis { get; set; } = new List<ProdWzorceKosztowWarunki>();

    public virtual OpeKarty? PwkOpeWNavigation { get; set; }
}
