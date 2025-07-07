using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdOkresy
{
    public int PokId { get; set; }

    public short? PokObiTyp { get; set; }

    public int? PokObiNumer { get; set; }

    public int? PokDataOd { get; set; }

    public int? PokDataDo { get; set; }

    public int? PokOkresOd { get; set; }

    public int? PokCzasOd { get; set; }

    public int? PokOkresDo { get; set; }

    public int? PokOkres { get; set; }

    public int? PokTypOkresu { get; set; }

    public short? PokDostepny { get; set; }

    public string? PokNazwa { get; set; }

    public string? PokOpis { get; set; }

    public int? PokCzasDostawy { get; set; }

    public byte? PokSposobDostawy { get; set; }

    public int? PokOpWnumer { get; set; }

    public int? PokDataWystawienia { get; set; }

    public int? PokOpMnumer { get; set; }

    public int? PokCzasModyfikacji { get; set; }

    public short? PokTyp { get; set; }

    public int? PokRodzajPracy { get; set; }

    public int? PokCzasPrzerwy { get; set; }

    public byte? PokPriorytetOkresu { get; set; }

    public byte? PokDni { get; set; }

    public int? PokTypDnia { get; set; }

    public byte? PokPrzestoj { get; set; }

    public byte? PokPlanowanyPrzestoj { get; set; }

    public int? PokPrzyczynaPrzestoju { get; set; }

    public int? PokCzasTrwaniaOkresu { get; set; }

    public byte? PokCzasTrwaniaOkresuJedn { get; set; }

    public byte? PokPochodzenie { get; set; }

    public int? PokStatus { get; set; }

    public byte? PokGenerowanieZsrdlaPrzestoju { get; set; }
}
