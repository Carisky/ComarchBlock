using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SrwZlcCzynnosci
{
    public int SzcId { get; set; }

    public int? SzcSznid { get; set; }

    public int? SzcSzuid { get; set; }

    public short? SzcPozycja { get; set; }

    public short? SzcTwrTyp { get; set; }

    public int? SzcTwrNumer { get; set; }

    public byte? SzcGenerujZadania { get; set; }

    public byte? SzcSprzedazKoszt { get; set; }

    public byte? SzcZrealizowano { get; set; }

    public string? SzcOpis { get; set; }

    public int? SzcCzasWykonania { get; set; }

    public byte? SzcCzasWykonaniaJedn { get; set; }

    public int? SzcCzasRealizacji { get; set; }

    public byte? SzcCzasRealizacjiJedn { get; set; }

    public decimal? SzcIlosc { get; set; }

    public decimal? SzcCenaPoczatkowa { get; set; }

    public decimal? SzcWartoscPoczatkowa { get; set; }

    public decimal? SzcRabat { get; set; }

    public decimal? SzcCenaPoRabacie { get; set; }

    public decimal? SzcWartoscPoRabacie { get; set; }

    public string? SzcGrupaPod { get; set; }

    public decimal? SzcStawkaPod { get; set; }

    public byte? SzcFlagaVat { get; set; }

    public short? SzcCenaSpr { get; set; }

    public decimal? SzcCenaZakupu { get; set; }

    public string? SzcWaluta { get; set; }

    public decimal? SzcRabatPromocyjny { get; set; }

    public decimal? SzcRabatKorekta { get; set; }

    public int? SzcPromocje { get; set; }

    public string? SzcTwrNazwa { get; set; }

    public int? SzcSlwStatus { get; set; }

    public int? SzcCzasModyfikacji { get; set; }

    public int? SzcZewnetrznySys { get; set; }

    public int? SzcZewnetrznyId { get; set; }

    public int? SzcSreid { get; set; }

    public int? SzcBlokadaEdycji { get; set; }

    public virtual ICollection<SrwZlcCzynnosciTerminy> SrwZlcCzynnosciTerminies { get; set; } = new List<SrwZlcCzynnosciTerminy>();

    public virtual SrwZlcNag? SzcSzn { get; set; }
}
