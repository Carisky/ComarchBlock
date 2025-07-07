using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class DelegacjeStawki
{
    public int DgsId { get; set; }

    public string? DgsKraj { get; set; }

    public int? DgsDataO { get; set; }

    public string? DgsWaluta { get; set; }

    public decimal? DgsDieta { get; set; }

    public decimal? DgsLimitNaNocleg { get; set; }

    public decimal? DgsRyczaltZaNocleg { get; set; }

    public decimal? DgsRyczaltZaPrzejazd { get; set; }

    public decimal? DgsRyczaltZaDojazdDworzec { get; set; }

    public byte? DgsStrefa { get; set; }

    public short? DgsStrefaNumer { get; set; }

    public string? DgsStrefaNazwa { get; set; }

    public short? DgsTypNumer { get; set; }

    public string? DgsTypNazwa { get; set; }
}
