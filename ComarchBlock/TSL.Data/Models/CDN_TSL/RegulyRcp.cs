using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class RegulyRcp
{
    public int RrgRrgId { get; set; }

    public string RrgOpis { get; set; } = null!;

    public int RrgIloscMinZrodlo { get; set; }

    public byte RrgAkcja { get; set; }

    public int RrgMetodaModyf { get; set; }

    public int RrgIloscMinCel { get; set; }

    public string RrgZjeId { get; set; } = null!;

    public virtual ICollection<ZestawyRegulElem> ZestawyRegulElems { get; set; } = new List<ZestawyRegulElem>();
}
