using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class TwrAplikacje
{
    public int TapObiNumer { get; set; }

    public short TapObiTyp { get; set; }

    public byte? TapIMall { get; set; }

    public int? TapGrupaiMall { get; set; }

    public byte? TapStatus { get; set; }

    public byte? TapDostepnosc { get; set; }

    public byte? TapKontrolaStanow { get; set; }

    public byte? TapPodlegaRabatowaniu { get; set; }

    public byte? TapIndywKosztDst { get; set; }

    public int? TapFlagi { get; set; }

    public int? TapCzasModyfikacji { get; set; }

    public decimal? TapKosztDstWartosc { get; set; }

    public int? TapGrupaeSklep { get; set; }

    public int? TapZapowiedzDataOd { get; set; }

    public int? TapTwrNadrzedny { get; set; }

    public byte? TapZapytajOcene { get; set; }

    public decimal? TapIloscMinZam { get; set; }

    public int? TapWszystkoPlId { get; set; }

    public int? TapWszystkoPlNr { get; set; }

    public string? TapWszystkoPlLink { get; set; }

    public string? TapWszystkoPlStatus { get; set; }

    public int? TapWszystkoPlJm { get; set; }

    public int? TapWszystkoPlCzasR { get; set; }

    public int? TapWszystkoPlCennik { get; set; }

    public int? TapWszystkoPlWarGw { get; set; }

    public int? TapWszystkoPlWarRekl { get; set; }

    public int? TapWszystkoPlWarZwr { get; set; }

    public int? TapWszystkoPlKategoria { get; set; }

    public int? TapWszystkoPlIlosc { get; set; }

    public int? TapWszystkoPlIloscSpr { get; set; }

    public string? TapWszystkoPlOpisy { get; set; }
}
