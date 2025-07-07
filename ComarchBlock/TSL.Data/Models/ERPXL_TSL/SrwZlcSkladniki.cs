using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SrwZlcSkladniki
{
    public int SzsId { get; set; }

    public int? SzsSznid { get; set; }

    public int? SzsSzcid { get; set; }

    public short? SzsTwrTyp { get; set; }

    public int? SzsTwrNumer { get; set; }

    public string? SzsOpis { get; set; }

    public byte? SzsSprzedazKoszt { get; set; }

    public decimal? SzsIlosc { get; set; }

    public decimal? SzsCenaPoczatkowa { get; set; }

    public decimal? SzsWartoscPoczatkowa { get; set; }

    public decimal? SzsRabat { get; set; }

    public decimal? SzsCenaPoRabacie { get; set; }

    public decimal? SzsWartoscPoRabacie { get; set; }

    public string? SzsGrupaPod { get; set; }

    public decimal? SzsStawkaPod { get; set; }

    public byte? SzsFlagaVat { get; set; }

    public short? SzsCenaSpr { get; set; }

    public decimal? SzsCenaZakupu { get; set; }

    public string? SzsWaluta { get; set; }

    public decimal? SzsRabatPromocyjny { get; set; }

    public decimal? SzsRabatKorekta { get; set; }

    public int? SzsPromocje { get; set; }

    public short? SzsPozycja { get; set; }

    public string? SzsTwrNazwa { get; set; }

    public int? SzsMagZnumer { get; set; }

    public int? SzsZewnetrznySys { get; set; }

    public int? SzsZewnetrznyId { get; set; }

    public int? SzsSreid { get; set; }

    public byte? SzsCzescZamienna { get; set; }
}
