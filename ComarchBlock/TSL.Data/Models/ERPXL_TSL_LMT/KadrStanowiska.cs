using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class KadrStanowiska
{
    public int KstId { get; set; }

    public string? KstNazwa { get; set; }

    public string? KstKslId { get; set; }

    public string? KstSymbol { get; set; }

    public string? KstKodZawodu { get; set; }

    public int? KstCentrumPodleglosci { get; set; }

    public byte? KstArchiwalny { get; set; }

    public byte? KstStanowiskoRobotnicze { get; set; }

    public byte? KstWymiarEtatuL { get; set; }

    public byte? KstWymiarEtatuM { get; set; }

    public int? KstRodzajUmowy { get; set; }

    public int? KstZaszeregowania { get; set; }

    public string? KstNrKategorii { get; set; }

    public string? KstNazwaZaszeregowania { get; set; }

    public byte? KstTypStawki { get; set; }

    public decimal? KstStawkaProponowana { get; set; }

    public byte? KstStawkaPropMiesGodz { get; set; }

    public decimal? KstStawkaZakresOd { get; set; }

    public decimal? KstStawkaZakresDo { get; set; }

    public byte? KstStawkaZakresMiesGodz { get; set; }

    public byte? KstKontrolaStawki { get; set; }

    public byte? KstProporDoEtatu { get; set; }

    public byte? KstMinimalneWynagrodzenie { get; set; }

    public int? KstHarmonogram { get; set; }

    public int? KstWymPozWyksztalcenia { get; set; }

    public int? KstSpecjalizacja { get; set; }

    public int? KstKierunek { get; set; }

    public int? KstBranza { get; set; }

    public byte? KstStazWymagany { get; set; }

    public string? KstOpis { get; set; }

    public string? KstOpisDodatkowy { get; set; }

    public int? KstSzczegolneWarunki { get; set; }

    public virtual ICollection<KadrStaSlowniki> KadrStaSlownikis { get; set; } = new List<KadrStaSlowniki>();
}
