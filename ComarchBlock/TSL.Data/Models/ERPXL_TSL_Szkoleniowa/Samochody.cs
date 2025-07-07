using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Samochody
{
    public int SaMId { get; set; }

    public string? SaMNrRej { get; set; }

    public int? SaMMarka { get; set; }

    public string? SaMModel { get; set; }

    public string? SaMKolor { get; set; }

    public string? SaMOpis { get; set; }

    public decimal? SaMLadownosc { get; set; }

    public short? SaMKntTyp { get; set; }

    public int? SaMKntNumer { get; set; }

    public short? SaMKierTyp { get; set; }

    public int? SaMKierNumer { get; set; }

    public short? SaMKierLp { get; set; }

    public byte? SaMDomyslny { get; set; }

    public short? SaMRokProd { get; set; }

    public int? SaMDataWazBadTech { get; set; }

    public string? SaMNrPolisy { get; set; }

    public int? SaMDataWazPolisy { get; set; }

    public decimal? SaMObjetosc { get; set; }

    public int? SaMCzasModyfikacji { get; set; }

    public short? SaMOddzialowy { get; set; }

    public decimal? SaMMocSilnika { get; set; }
}
