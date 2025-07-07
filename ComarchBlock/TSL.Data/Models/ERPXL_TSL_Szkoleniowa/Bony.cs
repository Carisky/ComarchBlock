using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Bony
{
    public int BbonId { get; set; }

    public int? BbonRboId { get; set; }

    public short? BbonStan { get; set; }

    public string? BbonNumer { get; set; }

    public decimal? BbonKwota { get; set; }

    public int? BbonTerminOd { get; set; }

    public int? BbonTerminDo { get; set; }

    public decimal? BbonKwotaZrealizowana { get; set; }

    public int? BbonDataWystawienia { get; set; }

    public int? BbonDataZatwierdzenia { get; set; }

    public int? BbonDataWydania { get; set; }

    public int? BbonDataBlokady { get; set; }

    public int? BbonOpeWnumer { get; set; }

    public int? BbonOpeMnumer { get; set; }

    public int? BbonOpeZnumer { get; set; }

    public int? BbonOpeWydalNumer { get; set; }

    public int? BbonOpeBnumer { get; set; }

    public int? BbonPrzyczynaBlokady { get; set; }

    public string? BbonOpis { get; set; }
}
