using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Rozliczenium
{
    public int R2Id { get; set; }

    public short? R2Dok1Typ { get; set; }

    public int? R2Dok1Numer { get; set; }

    public short? R2Dok1Lp { get; set; }

    public int? R2Dekret1Numer { get; set; }

    public short? R2Dekret1Lp { get; set; }

    public short? R2Dekret1Dc { get; set; }

    public byte? R2Dekret1Dod { get; set; }

    public string? R2Waluta1 { get; set; }

    public decimal? R2KwotaWal1 { get; set; }

    public short? R2Dok2Typ { get; set; }

    public int? R2Dok2Numer { get; set; }

    public short? R2Dok2Lp { get; set; }

    public int? R2Dekret2Numer { get; set; }

    public short? R2Dekret2Lp { get; set; }

    public short? R2Dekret2Dc { get; set; }

    public byte? R2Dekret2Dod { get; set; }

    public string? R2Waluta2 { get; set; }

    public decimal? R2KwotaWal2 { get; set; }

    public decimal? R2KwotaSys { get; set; }

    public int? R2DataRozliczenia { get; set; }

    public int? R2DataRozrachunku { get; set; }

    public int? R2OpeNumerRl { get; set; }

    public int? R2OpeNumerRz { get; set; }

    public decimal? R2Rk { get; set; }

    public byte? R2Rkstrona { get; set; }

    public int? R2ParId { get; set; }

    public int? R2Gidfirma { get; set; }

    public byte? R2Wycena { get; set; }

    public byte? R2WycenaWskazanie { get; set; }

    public decimal? R2PozostajeZwyc { get; set; }

    public decimal? R2PozostajeZwycSys { get; set; }

    public int? R2WycenaParId { get; set; }

    public int? R2CzasModyfikacji { get; set; }

    public int? R2ZewnetrznySys { get; set; }

    public int? R2ZewnetrznyId { get; set; }

    public short? R2ZewnetrznyTyp { get; set; }
}
