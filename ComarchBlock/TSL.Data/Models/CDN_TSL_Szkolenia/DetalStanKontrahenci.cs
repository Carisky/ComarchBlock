using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DetalStanKontrahenci
{
    public int DskntDskntId { get; set; }

    public int DskntOptimaId { get; set; }

    public string DskntKod { get; set; } = null!;

    public string DskntEan { get; set; } = null!;

    public string DskntNazwa1 { get; set; } = null!;

    public string DskntNazwa2 { get; set; } = null!;

    public string DskntNazwa3 { get; set; } = null!;

    public string DskntKraj { get; set; } = null!;

    public string DskntWojewodztwo { get; set; } = null!;

    public string DskntPowiat { get; set; } = null!;

    public string DskntGmina { get; set; } = null!;

    public string DskntUlica { get; set; } = null!;

    public string DskntNrDomu { get; set; } = null!;

    public string DskntNrLokalu { get; set; } = null!;

    public string DskntMiasto { get; set; } = null!;

    public string DskntKodPocztowy { get; set; } = null!;

    public string DskntPoczta { get; set; } = null!;

    public string DskntAdres2 { get; set; } = null!;

    public string DskntNipKraj { get; set; } = null!;

    public string DskntNipE { get; set; } = null!;

    public string DskntNip { get; set; } = null!;

    public string DskntRegon { get; set; } = null!;

    public string DskntPesel { get; set; } = null!;

    public byte DskntNieAktywny { get; set; }

    public int DskntStanSynchronizacji { get; set; }

    public string DskntTelefon { get; set; } = null!;

    public string DskntOpis { get; set; } = null!;

    public string DskntOsobaOdbierajaca { get; set; } = null!;

    public DateTime DskntTsMod { get; set; }

    public int DskntOpeId { get; set; }

    public virtual ICollection<DetalStanTraNag> DetalStanTraNags { get; set; } = new List<DetalStanTraNag>();
}
