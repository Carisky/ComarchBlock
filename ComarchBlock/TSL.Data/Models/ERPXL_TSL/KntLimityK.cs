using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KntLimityK
{
    public int KlkId { get; set; }

    public short? KlkKntTyp { get; set; }

    public int? KlkKntNumer { get; set; }

    public decimal? KlkMaxLimitWart { get; set; }

    public decimal? KlkLimitPoTerminie { get; set; }

    public int? KlkDataOd { get; set; }

    public int? KlkDataDo { get; set; }

    public string? KlkWaluta { get; set; }

    public short? KlkNrKursu { get; set; }

    public decimal? KlkKursM { get; set; }

    public decimal? KlkKursL { get; set; }

    public string? KlkPrzeliczajWg { get; set; }

    public int? KlkCzasUtworzenia { get; set; }

    public int? KlkOpeUtworzyl { get; set; }

    public int? KlkCzasModyfikacji { get; set; }

    public int? KlkOpeModyfikowal { get; set; }

    public byte? KlkPrzeliczajWgTyp { get; set; }
}
