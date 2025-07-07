using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ZamElemListView
{
    public short? ZaElvGidtyp { get; set; }

    public int? ZaElvGidfirma { get; set; }

    public int ZaElvGidnumer { get; set; }

    public short ZaElvGidlp { get; set; }

    public string ZaElvDokument { get; set; } = null!;

    public int? ZaElvTwrNumer { get; set; }

    public short? ZaElvTwrTyp { get; set; }

    public string? ZaElvTwrKod { get; set; }

    public string? ZaElvTwrNazwa { get; set; }

    public int ZaElvKntNumer { get; set; }

    public string ZaElvKntAkronim { get; set; } = null!;

    public string ZaElvKntNazwa { get; set; } = null!;

    public string ZaElvKntMiasto { get; set; } = null!;

    public string ZaElvKnDakronim { get; set; } = null!;

    public string ZaElvKnDnazwa { get; set; } = null!;

    public string ZaElvKnDmiasto { get; set; } = null!;

    public int? ZaElvDataWystawienia { get; set; }

    public int? ZaElvDataRealizacji { get; set; }

    public int? ZaElvDataWaznosci { get; set; }

    public string ZaElvRodzajOferty { get; set; } = null!;

    public string? ZaElvStan { get; set; }

    public int? ZaElvMagNumer { get; set; }

    public string ZaElvMagKod { get; set; } = null!;

    public int? ZaElvMagDnumer { get; set; }

    public string ZaElvMagDkod { get; set; } = null!;

    public string? ZaElvDokumentObcy { get; set; }

    public decimal? ZaElvIlosc { get; set; }

    public decimal? ZaElvIloscDoRealizacji { get; set; }

    public decimal? ZaElvIloscZrealizowana { get; set; }

    public decimal ZaElvIloscDoRealBezZasobu { get; set; }

    public decimal? ZaElvIloscZarezerwowana { get; set; }

    public decimal? ZaElvCenaKoncowa { get; set; }

    public decimal? ZaElvWartoscPoRabacie { get; set; }

    public decimal? ZaElvRabat { get; set; }

    public int? ZaElvKpnid { get; set; }

    public short? ZaElvReEtyp { get; set; }

    public short? ZaElvZstTyp { get; set; }

    public string? ZaElvWaluta { get; set; }

    public byte? ZaElvJmFormat { get; set; }

    public byte? ZaElvPrecyzjaCeny { get; set; }

    public byte? ZaElvTwrJmcalkowita { get; set; }
}
