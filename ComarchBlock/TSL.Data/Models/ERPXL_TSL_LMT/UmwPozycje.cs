using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class UmwPozycje
{
    public int UmPId { get; set; }

    public int? UmPUmNid { get; set; }

    public short? UmPPozycja { get; set; }

    public short? UmPTwrTyp { get; set; }

    public int? UmPTwrFirma { get; set; }

    public int? UmPTwrNumer { get; set; }

    public short? UmPTwrLp { get; set; }

    public string? UmPTwrNazwa { get; set; }

    public string? UmPOpis { get; set; }

    public decimal? UmPIlosc { get; set; }

    public string? UmPJmZ { get; set; }

    public byte? UmPTypJm { get; set; }

    public byte? UmPJmFormat { get; set; }

    public byte? UmPJmFormatZ { get; set; }

    public decimal? UmPPrzeliczM { get; set; }

    public decimal? UmPPrzeliczL { get; set; }

    public string? UmPGrupaPod { get; set; }

    public decimal? UmPStawkaPod { get; set; }

    public byte? UmPFlagaVat { get; set; }

    public decimal? UmPZrodlowa { get; set; }

    public string? UmPWaluta { get; set; }

    public short? UmPNrKursu { get; set; }

    public short? UmPCenaSpr { get; set; }

    public decimal? UmPCenaKatalogowa { get; set; }

    public decimal? UmPCenaOferowana { get; set; }

    public decimal? UmPCenaUzgodniona { get; set; }

    public short? UmPRodzajCenyBazowej { get; set; }

    public decimal? UmPWartoscPoRabacie { get; set; }

    public byte? UmPPrecyzjaCeny { get; set; }

    public short? UmPPrecyzjaCenyPocz { get; set; }

    public byte? UmPRownanie { get; set; }

    public decimal? UmPRabat { get; set; }

    public decimal? UmPRabatPromocyjny { get; set; }

    public decimal? UmPRabatKorekta { get; set; }

    public int? UmPPromocje { get; set; }

    public decimal? UmPNadwyzkaTwr { get; set; }

    public decimal? UmPKgojednostkowe { get; set; }

    public short? UmPZstTyp { get; set; }

    public int? UmPZstFirma { get; set; }

    public int? UmPZstNumer { get; set; }

    public short? UmPZstLp { get; set; }

    public int? UmPCzasModyfikacji { get; set; }

    public short? UmPCchTyp { get; set; }

    public int? UmPCchFirma { get; set; }

    public int? UmPCchNumer { get; set; }

    public short? UmPCchLp { get; set; }

    public string? UmPCecha { get; set; }

    public short? UmPReEtyp { get; set; }

    public int? UmPReEfirma { get; set; }

    public int? UmPReEnumer { get; set; }

    public short? UmPReElp { get; set; }

    public byte? UmPPozycjaSkopiowana { get; set; }

    public int? UmPMagNumer { get; set; }

    public virtual UmwNag? UmPUmN { get; set; }
}
