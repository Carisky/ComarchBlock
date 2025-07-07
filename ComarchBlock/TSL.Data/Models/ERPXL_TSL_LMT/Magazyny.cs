using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Magazyny
{
    public short? MagGidtyp { get; set; }

    public int? MagGidfirma { get; set; }

    public int MagGidnumer { get; set; }

    public short? MagGidlp { get; set; }

    public string? MagKod { get; set; }

    public string? MagNazwa { get; set; }

    public string? MagKodP { get; set; }

    public string? MagMiasto { get; set; }

    public string? MagUlica { get; set; }

    public string? MagAdres { get; set; }

    public short? MagPrcTyp { get; set; }

    public int? MagPrcFirma { get; set; }

    public int? MagPrcNumer { get; set; }

    public short? MagPrcLp { get; set; }

    public decimal? MagPojemnosc { get; set; }

    public string? MagKonto { get; set; }

    public string? MagOpis { get; set; }

    public byte? MagWewnetrzny { get; set; }

    public byte? MagPico { get; set; }

    public byte? MagZarzadzanie { get; set; }

    public short? MagKntTyp { get; set; }

    public int? MagKntFirma { get; set; }

    public int? MagKntNumer { get; set; }

    public short? MagKntLp { get; set; }

    public byte? MagZablokowany { get; set; }

    public int? MagDataInw { get; set; }

    public string? MagKontoInw { get; set; }

    public string? MagKraj { get; set; }

    public int? MagCzasModyfikacji { get; set; }

    public int? MagOpeMnumer { get; set; }

    public decimal? MagAnalizaA { get; set; }

    public decimal? MagAnalizaB { get; set; }

    public decimal? MagAnalizaX { get; set; }

    public decimal? MagAnalizaY { get; set; }

    public byte? MagAnalizaAbcxyz { get; set; }

    public byte? MagWms { get; set; }

    public short? MagSposobPracyZwms { get; set; }

    public byte? MagRealizujTylkoRezZas { get; set; }

    public int? MagWmsnumer { get; set; }

    public byte? MagWmsrodzaj { get; set; }

    public byte? MagSposobGenDokMagWms { get; set; }

    public int? MagPcKid { get; set; }

    public byte? MagRezerwujZasoby { get; set; }

    public byte? MagKontrolaIlosciWzwm { get; set; }

    public byte? MagRealizujwPos { get; set; }

    public virtual ICollection<AiprognozaPopytu> AiprognozaPopytus { get; set; } = new List<AiprognozaPopytu>();

    public virtual ICollection<DokMagazyny> DokMagazynies { get; set; } = new List<DokMagazyny>();

    public virtual ICollection<InwMagTwr> InwMagTwrs { get; set; } = new List<InwMagTwr>();

    public virtual ICollection<InwMag> InwMags { get; set; } = new List<InwMag>();

    public virtual ICollection<KntMagazyny> KntMagazynies { get; set; } = new List<KntMagazyny>();

    public virtual ICollection<MagOsobyOdpowiedzialne> MagOsobyOdpowiedzialnes { get; set; } = new List<MagOsobyOdpowiedzialne>();

    public virtual ICollection<MagWybor> MagWybors { get; set; } = new List<MagWybor>();

    public virtual ICollection<ProdPlanyMag> ProdPlanyMags { get; set; } = new List<ProdPlanyMag>();

    public virtual ICollection<RezMagazyny> RezMagazynies { get; set; } = new List<RezMagazyny>();

    public virtual ICollection<TwrZasoby> TwrZasobies { get; set; } = new List<TwrZasoby>();

    public virtual ICollection<Kbnnag> KbnmKbnns { get; set; } = new List<Kbnnag>();
}
