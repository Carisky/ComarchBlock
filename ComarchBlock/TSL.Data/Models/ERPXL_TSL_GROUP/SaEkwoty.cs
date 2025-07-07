using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SaEkwoty
{
    public short? SeKGidtyp { get; set; }

    public int? SeKGidfirma { get; set; }

    public int SeKGidnumer { get; set; }

    public short SeKGidlp { get; set; }

    public short SeKSubGidlp { get; set; }

    public string? SeKNazwa { get; set; }

    public short? SeKTyp { get; set; }

    public short? SeKRodzaj { get; set; }

    public int? SeKKcid { get; set; }

    public short? SeKVat { get; set; }

    public short? SeKClo { get; set; }

    public short? SeKAkcyza { get; set; }

    public decimal? SeKKwota { get; set; }

    public string? SeKWaluta { get; set; }

    public string? SeKGrupaPod { get; set; }

    public decimal? SeKStawkaPod { get; set; }

    public byte? SeKFlagaVat { get; set; }

    public decimal? SeKZrodlowa { get; set; }

    public string? SeKOpis { get; set; }

    public byte? SeKPomin { get; set; }

    public short? SeKPlatnosci { get; set; }

    public string? SeKPcn { get; set; }

    public string? SeKKrajPoch { get; set; }
}
