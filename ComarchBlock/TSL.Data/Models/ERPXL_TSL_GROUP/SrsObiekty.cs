using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrsObiekty
{
    public short? SobGidtyp { get; set; }

    public int? SobGidfirma { get; set; }

    public int SobGidnumer { get; set; }

    public short? SobGidlp { get; set; }

    public short? SobKntTyp { get; set; }

    public int? SobKntFirma { get; set; }

    public int? SobKntNumer { get; set; }

    public short? SobKntLp { get; set; }

    public short? SobKntTypW { get; set; }

    public int? SobKntFirmaW { get; set; }

    public int? SobKntNumerW { get; set; }

    public short? SobKntLpW { get; set; }

    public short? SobKnOtyp { get; set; }

    public int? SobKnOfirma { get; set; }

    public int? SobKnOnumer { get; set; }

    public short? SobKnOlp { get; set; }

    public string? SobMiasto { get; set; }

    public int? SobRegionId { get; set; }

    public int? SobStatusId { get; set; }

    public int? SobStanId { get; set; }

    public int? SobGodzOtwarciaId1 { get; set; }

    public int? SobGodzOtwarciaId2 { get; set; }

    public int? SobGodzOtwarciaId3 { get; set; }

    public decimal? SobIloscKm { get; set; }

    public short? SobUrzTyp { get; set; }

    public int? SobUrzFirma { get; set; }

    public int? SobUrzNumer { get; set; }

    public short? SobUrzLp { get; set; }

    public short? SobPrcTypS { get; set; }

    public int? SobPrcFirmaS { get; set; }

    public int? SobPrcNumerS { get; set; }

    public short? SobPrcLpS { get; set; }

    public short? SobPrcTypO { get; set; }

    public int? SobPrcFirmaO { get; set; }

    public int? SobPrcNumerO { get; set; }

    public short? SobPrcLpO { get; set; }

    public int? SobAktywny { get; set; }

    public int? SobAktualny { get; set; }

    public int? SobTsdeaktywacji { get; set; }

    public string? SobOpis { get; set; }

    public virtual ICollection<LokalizacjeDok> LokalizacjeDoks { get; set; } = new List<LokalizacjeDok>();
}
