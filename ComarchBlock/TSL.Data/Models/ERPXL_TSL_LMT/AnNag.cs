using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class AnNag
{
    public short? AnNGidtyp { get; set; }

    public int? AnNGidfirma { get; set; }

    public int AnNGidnumer { get; set; }

    public short? AnNGidlp { get; set; }

    public string? AnNAkronim { get; set; }

    public short? AnNStGtyp { get; set; }

    public int? AnNStGfirma { get; set; }

    public int? AnNStGnumer { get; set; }

    public short? AnNStGlp { get; set; }

    public short? AnNOpeTyp { get; set; }

    public int? AnNOpeFirma { get; set; }

    public int? AnNOpeNumer { get; set; }

    public short? AnNOpeLp { get; set; }

    public short? AnNStaTyp { get; set; }

    public int? AnNStaFirma { get; set; }

    public int? AnNStaNumer { get; set; }

    public short? AnNStaLp { get; set; }

    public string? AnNNazwa1 { get; set; }

    public string? AnNWyrazenie1 { get; set; }

    public string? AnNFormat1 { get; set; }

    public decimal? AnNProg1A { get; set; }

    public decimal? AnNProg1B { get; set; }

    public string? AnNNazwa2 { get; set; }

    public string? AnNWyrazenie2 { get; set; }

    public string? AnNFormat2 { get; set; }

    public decimal? AnNProg2A { get; set; }

    public decimal? AnNProg2B { get; set; }

    public string? AnNNazwa3 { get; set; }

    public string? AnNWyrazenie3 { get; set; }

    public string? AnNFormat3 { get; set; }

    public decimal? AnNProg3A { get; set; }

    public decimal? AnNProg3B { get; set; }

    public string? AnNNazwa4 { get; set; }

    public string? AnNWyrazenie4 { get; set; }

    public string? AnNFormat4 { get; set; }

    public decimal? AnNProg4A { get; set; }

    public decimal? AnNProg4B { get; set; }

    public string? AnNNazwa5 { get; set; }

    public string? AnNWyrazenie5 { get; set; }

    public string? AnNFormat5 { get; set; }

    public decimal? AnNProg5A { get; set; }

    public decimal? AnNProg5B { get; set; }

    public string? AnNNazwa6 { get; set; }

    public string? AnNWyrazenie6 { get; set; }

    public string? AnNFormat6 { get; set; }

    public decimal? AnNProg6A { get; set; }

    public decimal? AnNProg6B { get; set; }

    public byte? AnNElementy { get; set; }

    public string? AnNOpis { get; set; }

    public virtual ICollection<AnElem> AnElems { get; set; } = new List<AnElem>();
}
