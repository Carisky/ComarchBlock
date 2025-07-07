using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class ZestawyRegulElem
{
    public int ZreZreId { get; set; }

    public int ZreLp { get; set; }

    public int? ZreZrgId { get; set; }

    public int? ZreRrgId { get; set; }

    public int ZreIloscMinZrodlo { get; set; }

    public int ZreAkcja { get; set; }

    public byte ZreMetodaModyf { get; set; }

    public int ZreIloscMinCel { get; set; }

    public virtual RegulyRcp? ZreRrg { get; set; }

    public virtual ZestawyRegul? ZreZrg { get; set; }
}
