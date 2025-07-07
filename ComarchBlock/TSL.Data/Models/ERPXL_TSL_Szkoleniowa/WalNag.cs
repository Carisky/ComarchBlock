using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class WalNag
{
    public string WaNSymbol { get; set; } = null!;

    public short WaNId { get; set; }

    public string? WaNKontoPlus { get; set; }

    public string? WaNKontoMinus { get; set; }

    public string? WaNNazwa { get; set; }

    public string? WaNPanstwo { get; set; }

    public string? WaNSlownie1 { get; set; }

    public string? WaNSlownie2 { get; set; }

    public int? WaNAktywna { get; set; }

    public byte? WaNWsk { get; set; }

    public string? WaNSymbolEmu { get; set; }

    public decimal? WaNParytet { get; set; }

    public byte? WaNCzySystemowaOptima { get; set; }

    public virtual ICollection<RejestryDomyslne> RejestryDomyslnes { get; set; } = new List<RejestryDomyslne>();

    public virtual ICollection<WalElem> WalElems { get; set; } = new List<WalElem>();
}
