using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class RptFormaty2
{
    public int RpF2RpWid { get; set; }

    public int RpF2Id { get; set; }

    public int? RpF2Lp { get; set; }

    public string? RpF2Nazwa { get; set; }

    public byte? RpF2NaEkran { get; set; }

    public string? RpF2Haslo { get; set; }

    public string? RpF2HasloChk { get; set; }

    public int? RpF2Strony { get; set; }

    public int? RpF2Kopie { get; set; }

    public byte? RpF2SortujKopie { get; set; }

    public byte? RpF2Typ { get; set; }

    public byte? RpF2IgnorujFiltrApp { get; set; }

    public byte? RpF2IgnorujKluczApp { get; set; }

    public byte? RpF2Kompresja { get; set; }

    public string? RpF2Skrypt { get; set; }

    public string? RpF2NrWersji { get; set; }

    public string? RpF2Autor { get; set; }

    public int? RpF2DataUtw { get; set; }

    public int? RpF2DataMod { get; set; }

    public string? RpF2Opis { get; set; }

    public short? RpF2Zaznaczenia { get; set; }

    public short? RpF2Kolejka { get; set; }

    public int? RpF2MarginesL { get; set; }

    public int? RpF2MarginesG { get; set; }

    public byte? RpF2PobierzUstawieniaStanowiska { get; set; }

    public string? RpF2DrukarkaDomyslna { get; set; }

    public byte? RpF2DostepnyPrzezSerwer { get; set; }

    public byte? RpF2DrukujDomyslniePrzezSerwer { get; set; }

    public string? RpF2DrukarkaDomyslnaSerwerowa { get; set; }

    public byte? RpF2Eco { get; set; }

    public byte? RpF2UkryjDefinicje { get; set; }

    public int? RpF2RozmiarDefinicji { get; set; }

    public int? RpF2KopiaElektroniczna { get; set; }

    public byte? RpF2DomyslnyB2b { get; set; }

    public byte? RpF2ZapisujHistorie { get; set; }

    public byte? RpF2DomyslnyMes { get; set; }

    public virtual RptWydruki2 RpF2RpW { get; set; } = null!;

    public virtual ICollection<RptDefinicje2> RptDefinicje2s { get; set; } = new List<RptDefinicje2>();

    public virtual ICollection<RptParametry2> RptParametry2s { get; set; } = new List<RptParametry2>();
}
