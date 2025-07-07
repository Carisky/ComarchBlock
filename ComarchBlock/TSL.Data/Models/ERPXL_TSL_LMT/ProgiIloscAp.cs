using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProgiIloscAp
{
    public int PiaId { get; set; }

    public int? PiaObiNumer { get; set; }

    public short? PiaObiTyp { get; set; }

    public decimal? PiaPrzedzialOd { get; set; }

    public decimal? PiaPrzedzialDo { get; set; }

    public byte? PiaCzyIloscRzeczywista { get; set; }

    public byte? PiaCzyOpis { get; set; }

    public string? PiaOpisTresc { get; set; }

    public byte? PiaCzyGrafika { get; set; }

    public string? PiaGrafikaSciezka { get; set; }

    public byte? PiaCzyKolor { get; set; }

    public int? PiaKolorNumer { get; set; }

    public int? PiaDostepnoscFlaga { get; set; }

    public int? PiaCzasModyfikacji { get; set; }
}
