using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class MemDokElem
{
    public short MdeGidtyp { get; set; }

    public int? MdeGidfirma { get; set; }

    public int MdeGidnumer { get; set; }

    public short MdeGidlp { get; set; }

    public int? MdeSymbolId { get; set; }

    public byte? MdeKwotaWym { get; set; }

    public byte? MdeNieSumuj { get; set; }

    public string? MdePodmiotWym { get; set; }

    public byte? MdePodmiotRodzaj { get; set; }

    public string? MdeOpis { get; set; }

    public int? MdeRodzajKosztu { get; set; }

    public virtual MemDokNag MdeGidnumerNavigation { get; set; } = null!;

    public virtual MemSymbole? MdeSymbol { get; set; }
}
