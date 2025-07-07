using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdCzynnosciRealizujaceTechnologie
{
    public int PtcId { get; set; }

    public string? PtcKod { get; set; }

    public string? PtcNazwa { get; set; }

    public int? PtcCzasRozliczeniowy { get; set; }

    public int PczId { get; set; }

    public int? PczCzasrealizacji { get; set; }

    public int PzaId { get; set; }

    public decimal? PzaIloscTechnologiczna { get; set; }

    public decimal? PzaIlosc { get; set; }

    public int PtzId { get; set; }

    public string? PtzKod { get; set; }

    public string? PtzNazwa { get; set; }

    public decimal? PtzIlosc { get; set; }

    public int? PczPzlid { get; set; }

    public byte? PtzTypZasobu { get; set; }
}
