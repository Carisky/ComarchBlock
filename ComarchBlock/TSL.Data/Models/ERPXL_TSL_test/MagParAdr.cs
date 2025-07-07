using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class MagParAdr
{
    public int MpaId { get; set; }

    public string? MpaKod { get; set; }

    public string? MpaNazwa { get; set; }

    public decimal? MpaDlugosc { get; set; }

    public decimal? MpaSzerokosc { get; set; }

    public decimal? MpaWysokosc { get; set; }

    public decimal? MpaNosnosc { get; set; }

    public byte? MpaRodzaj { get; set; }

    public byte? MpaPriorytetS { get; set; }

    public byte? MpaPriorytetP { get; set; }

    public int? MpaCzasModyfikacji { get; set; }

    public int? MpaOpeMnumer { get; set; }

    public virtual ICollection<MagParJednostki> MagParJednostkis { get; set; } = new List<MagParJednostki>();
}
