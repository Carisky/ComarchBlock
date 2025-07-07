using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KntKontum
{
    public short KktKntTyp { get; set; }

    public int KktKntNumer { get; set; }

    public int KktSmkid { get; set; }

    public int KktOkresId { get; set; }

    public int? KktKksnumer { get; set; }

    public byte? KktZalozKonto { get; set; }

    public string? KktKonto { get; set; }

    public virtual SymboleKont KktSmk { get; set; } = null!;
}
