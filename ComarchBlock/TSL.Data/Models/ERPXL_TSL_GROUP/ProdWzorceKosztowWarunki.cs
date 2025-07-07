using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdWzorceKosztowWarunki
{
    public int PwwId { get; set; }

    public int? PwwPwkid { get; set; }

    public short? PwwLp { get; set; }

    public string? PwwKod { get; set; }

    public string? PwwNazwa { get; set; }

    public byte? PwwWymagany { get; set; }

    public byte? PwwWielowartosciowy { get; set; }

    public string? PwwOpis { get; set; }

    public virtual ProdWzorceKosztow? PwwPwk { get; set; }
}
