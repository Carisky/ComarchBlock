using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class BudzetPrjElemOkresy
{
    public int BpeoId { get; set; }

    public int? BpeoBpeid { get; set; }

    public int? BpeoPozycja { get; set; }

    public int? BpeoDataOd { get; set; }

    public int? BpeoDataDo { get; set; }

    public string? BpeoNaglowek { get; set; }

    public decimal? BpeoUmowa { get; set; }

    public decimal? BpeoBudzet { get; set; }

    public decimal? BpeoKontrakt { get; set; }

    public decimal? BpeoKosztyRzeczywiste { get; set; }

    public decimal? BpeoKosztyZamowien { get; set; }

    public decimal? BpeoKosztyWynagrodzen { get; set; }

    public decimal? BpeoKosztyInne { get; set; }

    public decimal? BpeoPrzychodyPlanowane { get; set; }

    public decimal? BpeoPrzychodyPlanowaneEdycja { get; set; }

    public decimal? BpeoPrzychodyRzeczywiste { get; set; }

    public decimal? BpeoPrzychodyInne { get; set; }

    public decimal? BpeoWartoscPrzedNarzutem { get; set; }

    public decimal? BpeoWartoscPoNarzucie { get; set; }

    public virtual BudzetPrjElem? BpeoBpe { get; set; }
}
