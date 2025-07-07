using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class WyplatyElem
{
    public int WyEWyEid { get; set; }

    public int WyEWyNid { get; set; }

    public int? WyEKatId { get; set; }

    public string WyEKategoria { get; set; } = null!;

    public decimal WyEWartosc { get; set; }

    public byte WyEKoszt { get; set; }

    public byte WyEGotowka { get; set; }

    public byte WyEOpodatkowany { get; set; }

    public byte WyEUbEmeryt { get; set; }

    public byte WyEUbRentow { get; set; }

    public byte WyEUbChorob { get; set; }

    public byte WyEUbWypadk { get; set; }

    public byte WyEUbZdrowo { get; set; }

    public byte WyEPotracenie { get; set; }

    public virtual Kategorie? WyEKat { get; set; }

    public virtual WyplatyNag WyEWyN { get; set; } = null!;
}
