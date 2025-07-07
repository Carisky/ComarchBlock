using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KonfProdElem
{
    public int KpeId { get; set; }

    public int? KpeKpnid { get; set; }

    public short? KpeObiTyp { get; set; }

    public int? KpeObiFirma { get; set; }

    public int? KpeObiNumer { get; set; }

    public short? KpeObiLp { get; set; }

    public byte? KpeTypPytania { get; set; }

    public short? KpePozycja { get; set; }

    public string? KpeTresc { get; set; }

    public int? KpeAtkId { get; set; }

    public string? KpeOdpowiedz { get; set; }

    public short? KpeOdpTyp { get; set; }

    public int? KpeOdpFirma { get; set; }

    public int? KpeOdpNumer { get; set; }

    public short? KpeOdpLp { get; set; }

    public byte? KpeEdycja { get; set; }

    public byte? KpeWymagaj { get; set; }

    public byte? KpeKopiuj { get; set; }

    public virtual KonfProdNag? KpeKpn { get; set; }
}
