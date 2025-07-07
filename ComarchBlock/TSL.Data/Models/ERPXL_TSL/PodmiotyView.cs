using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PodmiotyView
{
    public short? PodvGidtyp { get; set; }

    public int? PodvGidfirma { get; set; }

    public int PodvGidnumer { get; set; }

    public short? PodvGidlp { get; set; }

    public string? PodvAkronim { get; set; }

    public string? PodvNazwa1 { get; set; }

    public string? PodvNazwa2 { get; set; }

    public string? PodvNazwa3 { get; set; }

    public string? PodvKodp { get; set; }

    public string? PodvMiasto { get; set; }

    public string? PodvUlica { get; set; }

    public string? PodvAdres { get; set; }

    public string? PodvNipPrefiks { get; set; }

    public string? PodvNipE { get; set; }

    public int? PodvKntStatus { get; set; }
}
