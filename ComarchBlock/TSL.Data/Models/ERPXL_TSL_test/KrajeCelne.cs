using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KrajeCelne
{
    public string KpcKod { get; set; } = null!;

    public string? KpcNazwa { get; set; }

    public string? KpcNazwaPl { get; set; }

    public int? KpcGkrId { get; set; }

    public int KpcId { get; set; }
}
