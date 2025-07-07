using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Pdonaruszenium
{
    public int PdonId { get; set; }

    public short? PdonInsTyp { get; set; }

    public int? PdonInsNumer { get; set; }

    public int? PdonLiczbaRekordow { get; set; }

    public int? PdonDataNaruszenia { get; set; }

    public int? PdonDataZgloszenia { get; set; }

    public string? PdonCharakterNaruszenia { get; set; }

    public string? PdonKategoriaOsob { get; set; }

    public string? PdonKonsekwencje { get; set; }

    public string? PdonZastosowaneSrodki { get; set; }

    public string? PdonPrzyczyna { get; set; }

    public string? PdonSzczegoly { get; set; }

    public int? PdonCzasUtworzenia { get; set; }

    public int? PdonOpeNumerW { get; set; }

    public int? PdonCzasModyfikacji { get; set; }

    public int? PdonOpeNumerM { get; set; }
}
