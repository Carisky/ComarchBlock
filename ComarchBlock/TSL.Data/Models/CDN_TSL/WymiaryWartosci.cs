using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class WymiaryWartosci
{
    public int WyWWyWid { get; set; }

    public int? WyWWyyId { get; set; }

    public int? WyWSourceType { get; set; }

    public string? WyWSrcguid { get; set; }

    public string? WyWGuid { get; set; }

    public string? WyWWartosc { get; set; }

    public int? WyWDokumentTyp { get; set; }

    public int? WyWDokumentId { get; set; }

    public int? WyWSlownikId { get; set; }

    public int? WyWLpPozycji { get; set; }

    public decimal? WyWKwotaPozycji { get; set; }

    public decimal? WyWProcent { get; set; }

    public decimal? WyWKwota { get; set; }
}
