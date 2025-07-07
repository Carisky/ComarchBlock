using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrwReceptury
{
    public int SreId { get; set; }

    public int? SreObiTyp { get; set; }

    public int? SreObiNumer { get; set; }

    public string? SreKod { get; set; }

    public string? SreNazwa { get; set; }

    public int? SreOpdnumer { get; set; }

    public int? SreDataDodania { get; set; }

    public int? SreOpmnumer { get; set; }

    public int? SreDataModyfikacji { get; set; }

    public int? SreOpanumer { get; set; }

    public int? SreDataArchiwizacji { get; set; }

    public byte? SreDomyslna { get; set; }

    public byte? SreArchiwalna { get; set; }
}
