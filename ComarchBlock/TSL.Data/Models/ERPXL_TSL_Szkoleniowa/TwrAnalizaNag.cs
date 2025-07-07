using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TwrAnalizaNag
{
    public int TanId { get; set; }

    public int? TanOkresId { get; set; }

    public byte? TanRodzaj { get; set; }

    public byte? TanStan { get; set; }

    public int? TanDataUtw { get; set; }

    public int? TanOpeUtw { get; set; }

    public int? TanDataMod { get; set; }

    public int? TanOpeMod { get; set; }

    public int? TanDataZat { get; set; }

    public int? TanOpeZat { get; set; }

    public string? TanOpis { get; set; }

    public virtual ICollection<TwrAnalizaElem> TwrAnalizaElems { get; set; } = new List<TwrAnalizaElem>();

    public virtual ICollection<TwrAnalizaMag> TwrAnalizaMags { get; set; } = new List<TwrAnalizaMag>();
}
