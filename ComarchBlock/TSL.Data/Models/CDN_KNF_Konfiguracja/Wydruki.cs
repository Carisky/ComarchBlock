using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Wydruki
{
    public byte WdrStandardowy { get; set; }

    public int WdrId { get; set; }

    public int? WdrRpWid { get; set; }

    public int? WdrRpFid { get; set; }

    public string WdrNazwa { get; set; } = null!;

    public byte WdrRodzaj { get; set; }

    public byte WdrTyp { get; set; }

    public byte WdrPodTyp { get; set; }

    public byte? WdrTypObslugiZaznaczen { get; set; }

    public byte? WdrObslugaKolejki { get; set; }

    public byte? WdrSeryjny { get; set; }

    public string WdrDefinicja { get; set; } = null!;

    public int? WdrRozmiarDefinicji { get; set; }

    public byte? WdrKompresja { get; set; }

    public byte? WdrUkryjDefinicje { get; set; }

    public string? WdrParametry { get; set; }

    public string? WdrWarunek { get; set; }

    public string? WdrWarunekAuto { get; set; }

    public byte? WdrIgnorujFiltrApp { get; set; }

    public byte? WdrIgnorujKluczApp { get; set; }

    public byte? WdrDomyslnyTypUrzadzenia { get; set; }

    public string? WdrDrukarkaDomyslna { get; set; }

    public byte? WdrDomyslnyFormatEksportu { get; set; }

    public int? WdrIloscKopii { get; set; }

    public byte? WdrSortujKopie { get; set; }

    public int? WdrMarginesL { get; set; }

    public int? WdrMarginesG { get; set; }

    public short? WdrDuplex { get; set; }

    public byte? WdrEco { get; set; }

    public string? WdrOpis { get; set; }

    public string? WdrWersja { get; set; }

    public string? WdrAutor { get; set; }

    public string? WdrHaslo { get; set; }

    public string? WdrHasloChk { get; set; }

    public string? WdrEdycja { get; set; }

    public byte WdrKopiaEl { get; set; }

    public byte WdrKopiaElGdzie { get; set; }

    public byte WdrPodpisCyfrowy { get; set; }

    public byte WdrOdswiezDanePoWykonaniu { get; set; }

    public byte WdrZrodloDanychFirmy { get; set; }

    public string? WdrWzorzecNazwyPlikuWynikowego { get; set; }

    public byte WdrLaczPdf { get; set; }

    public byte WdrETeczka { get; set; }

    public int WdrETeczkaCzesc { get; set; }

    public int? WdrOpeZalId { get; set; }

    public DateTime WdrTsZal { get; set; }

    public int? WdrOpeModId { get; set; }

    public DateTime WdrTsMod { get; set; }

    public string WdrOpeModKod { get; set; } = null!;

    public string WdrOpeModNazwisko { get; set; } = null!;

    public string WdrOpeZalKod { get; set; } = null!;

    public string WdrOpeZalNazwisko { get; set; } = null!;
}
