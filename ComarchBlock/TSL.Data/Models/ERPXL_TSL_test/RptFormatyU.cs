using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class RptFormatyU
{
    public int RpFuRpWid { get; set; }

    public int RpFuId { get; set; }

    public byte? RpFuNaEkran { get; set; }

    public int? RpFuStrony { get; set; }

    public int? RpFuKopie { get; set; }

    public byte? RpFuSortujKopie { get; set; }

    public byte? RpFuIgnorujFiltrApp { get; set; }

    public byte? RpFuIgnorujKluczApp { get; set; }

    public int? RpFuMarginesL { get; set; }

    public int? RpFuMarginesG { get; set; }

    public byte? RpFuPobierzUstawieniaStanowiska { get; set; }

    public string? RpFuDrukarkaDomyslna { get; set; }

    public byte? RpFuDostepnyPrzezSerwer { get; set; }

    public byte? RpFuDrukujDomyslniePrzezSerwer { get; set; }

    public string? RpFuDrukarkaDomyslnaSerwerowa { get; set; }

    public byte? RpFuEco { get; set; }

    public int? RpFuKopiaElektroniczna { get; set; }

    public byte? RpFuDomyslnyB2b { get; set; }

    public byte? RpFuZapisujHistorie { get; set; }

    public byte? RpFuDomyslnyMes { get; set; }
}
