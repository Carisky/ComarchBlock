using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrtZestElem
{
    public int SzeId { get; set; }

    public int? SzeSrtZestNumer { get; set; }

    public string? SzeSrtZestAkronim { get; set; }

    public byte? SzeRodzaj { get; set; }

    public int? SzeDataPrzylaczenia { get; set; }

    public int? SzeDataOdlaczenia { get; set; }

    public string? SzeNazwa { get; set; }

    public int? SzeSrtNumer { get; set; }

    public string? SzeSrtAkronim { get; set; }

    public decimal? SzePodstawaBilansowa { get; set; }

    public decimal? SzePodstawaPodatkowa { get; set; }

    public decimal? SzePodstawaBilansowaSys { get; set; }

    public decimal? SzePodstawaPodatkowaSys { get; set; }

    public string? SzeWaluta { get; set; }

    public short? SzeNrKursu { get; set; }

    public decimal? SzeKursM { get; set; }

    public decimal? SzeKursL { get; set; }

    public byte? SzeKurs { get; set; }

    public string? SzeOpis { get; set; }

    public int? SzeDataEksp { get; set; }

    public int? SzeDataLikw { get; set; }

    public int? SzeDataRozp { get; set; }

    public int? SzeDataRozpAm { get; set; }

    public string? SzeOrgWaluta { get; set; }

    public decimal? SzeAmortyzacjaBilansowa { get; set; }

    public decimal? SzeAmorytzacjaPodatkowa { get; set; }

    public decimal? SzeAmortyzacjaBilansowaSys { get; set; }

    public decimal? SzeAmortyzacjaPodatkowaSys { get; set; }

    public byte? SzeTorBilansowy { get; set; }

    public byte? SzeTorPodatkowy { get; set; }
}
