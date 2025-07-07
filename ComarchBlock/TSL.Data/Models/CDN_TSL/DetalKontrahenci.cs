using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DetalKontrahenci
{
    public int DkntDkntId { get; set; }

    public int DkntOptimaId { get; set; }

    public int DkntDskntId { get; set; }

    public int DkntStanDetalId { get; set; }

    public string DkntKod { get; set; } = null!;

    public string DkntEan { get; set; } = null!;

    public string DkntNazwa1 { get; set; } = null!;

    public string DkntNazwa2 { get; set; } = null!;

    public string DkntNazwa3 { get; set; } = null!;

    public string DkntKraj { get; set; } = null!;

    public string DkntWojewodztwo { get; set; } = null!;

    public string DkntPowiat { get; set; } = null!;

    public string DkntGmina { get; set; } = null!;

    public string DkntUlica { get; set; } = null!;

    public string DkntNrDomu { get; set; } = null!;

    public string DkntNrLokalu { get; set; } = null!;

    public string DkntMiasto { get; set; } = null!;

    public string DkntKodPocztowy { get; set; } = null!;

    public string DkntPoczta { get; set; } = null!;

    public string DkntAdres2 { get; set; } = null!;

    public string DkntNipKraj { get; set; } = null!;

    public string DkntNipE { get; set; } = null!;

    public string DkntNip { get; set; } = null!;

    public string DkntRegon { get; set; } = null!;

    public string DkntPesel { get; set; } = null!;

    public string DkntTelefon { get; set; } = null!;

    public string DkntOpis { get; set; } = null!;

    public string DkntOsobaOdbierajaca { get; set; } = null!;

    public int DkntStanSynchronizacji { get; set; }

    public DateTime DkntTsMod { get; set; }

    public int DkntOpeId { get; set; }

    public int DkntAdresId { get; set; }

    public int DkntAdresId2 { get; set; }

    public string DkntTelefon1 { get; set; } = null!;

    public string DkntEMail { get; set; } = null!;

    public string DkntUrl { get; set; } = null!;

    public string DkntFax { get; set; } = null!;

    public byte DkntFinalny { get; set; }

    public byte DkntRodzajDostawca { get; set; }

    public byte DkntRodzajOdbiorca { get; set; }

    public byte DkntRodzajKonkurencja { get; set; }

    public byte DkntRodzajPartner { get; set; }

    public byte DkntRodzajPotencjalny { get; set; }
}
