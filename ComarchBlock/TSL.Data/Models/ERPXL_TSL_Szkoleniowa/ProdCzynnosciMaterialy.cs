using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdCzynnosciMaterialy
{
    public int PcmPczid { get; set; }

    public int PcmTwrNumer { get; set; }

    public decimal? PcmIlosc { get; set; }

    public decimal? PcmZrealizowana { get; set; }

    public string? PcmJm { get; set; }

    public int PcmKlasaCechy { get; set; }

    public string PcmCecha { get; set; } = null!;

    public int? PcmTechnologiaZasob { get; set; }
}
