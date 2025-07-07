using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PicoWaluty
{
    public int PwLId { get; set; }

    public int? PwLPckId { get; set; }

    public string? PwLSymbolM { get; set; }

    public string? PwLSymbolL { get; set; }

    public short? PwLLp { get; set; }

    public int? PwLKursTs { get; set; }

    public decimal? PwLKursM { get; set; }

    public decimal? PwLKursL { get; set; }

    public int? PwLTsarchiwizacji { get; set; }

    public short? PwLOpeMtyp { get; set; }

    public int? PwLOpeMnumer { get; set; }

    public int? PwLCzasModyfikacji { get; set; }

    public virtual PicoKonfig? PwLPck { get; set; }
}
