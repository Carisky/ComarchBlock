using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SadKwoty
{
    public short? SaKGidtyp { get; set; }

    public int? SaKGidfirma { get; set; }

    public int SaKGidnumer { get; set; }

    public short SaKGidlp { get; set; }

    public string? SaKNazwa { get; set; }

    public short? SaKTyp { get; set; }

    public short? SaKRodzaj { get; set; }

    public short? SaKVat { get; set; }

    public short? SaKClo { get; set; }

    public short? SaKAkcyza { get; set; }

    public decimal? SaKKwota { get; set; }

    public string? SaKWaluta { get; set; }

    public string? SaKOpis { get; set; }

    public byte? SaKPomin { get; set; }

    public short? SaKTrNtyp { get; set; }

    public int? SaKTrNfirma { get; set; }

    public int? SaKTrNnumer { get; set; }

    public short? SaKTrNlp { get; set; }

    public short? SaKPlatnosci { get; set; }

    public string? SaKKod { get; set; }

    public virtual SadNag SaKGidnumerNavigation { get; set; } = null!;
}
