using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class OsoNieobecnosci
{
    public int OnbId { get; set; }

    public int? OnbOsoNumer { get; set; }

    public int? OnbUmoNumer { get; set; }

    public int? OnbOkresOd { get; set; }

    public int? OnbOkresDo { get; set; }

    public int? OnbDefinicja { get; set; }

    public byte? OnbStan { get; set; }

    public short? OnbDni { get; set; }

    public int? OnbCzas { get; set; }

    public byte? OnbNaZadanie { get; set; }

    public int? OnbPrzyczyna { get; set; }

    public int? OnbKodRca { get; set; }

    public int? OnbKodRsa { get; set; }

    public byte? OnbKontynuowacZasilek { get; set; }

    public byte? OnbPrzedluzonyZasilek { get; set; }

    public int? OnbZwolChoroba { get; set; }

    public string? OnbZwolSeria { get; set; }

    public string? OnbZwolNumer { get; set; }

    public int? OnbZwolData { get; set; }

    public int? OnbZwolDostarczono { get; set; }

    public byte? OnbZwolPomniejszaj { get; set; }

    public string? OnbOpis { get; set; }

    public int? OnbOpMnumer { get; set; }

    public int? OnbCzasModyfikacji { get; set; }

    public virtual PrcKarty? OnbOsoNumerNavigation { get; set; }
}
