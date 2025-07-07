using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TraElem
{
    public int TrETrEid { get; set; }

    public int TrETrNid { get; set; }

    public int? TrEZwrId { get; set; }

    public int? TrETrEidProd { get; set; }

    public int? TrEPdRid { get; set; }

    public int TrELp { get; set; }

    public int TrELpPow { get; set; }

    public int? TrELpPowRel { get; set; }

    public int TrETypDokumentu { get; set; }

    public byte TrEAktywny { get; set; }

    public DateTime TrEDataDok { get; set; }

    public decimal? TrERabatPromocyjny { get; set; }

    public decimal? TrERabatKorekta { get; set; }

    public int? TrEPromocje { get; set; }

    public DateTime TrEDataOpe { get; set; }

    public short? TrEPodmiotTyp { get; set; }

    public int? TrEPodId { get; set; }

    public int? TrEKatId { get; set; }

    public string TrEKategoria { get; set; } = null!;

    public int? TrETwrId { get; set; }

    public int? TrEMagId { get; set; }

    public string TrETwrNazwa { get; set; } = null!;

    public string TrETwrEan { get; set; } = null!;

    public string TrETwrNumerKat { get; set; } = null!;

    public string TrETwrKod { get; set; } = null!;

    public string TrETwrOpis { get; set; } = null!;

    public string TrETwrSww { get; set; } = null!;

    public byte TrETwrTyp { get; set; }

    public string TrETwrKodDostawcy { get; set; } = null!;

    public decimal TrEStawka { get; set; }

    public short TrEFlaga { get; set; }

    public decimal TrEZrodlowa { get; set; }

    public int TrETwCnumer { get; set; }

    public byte TrETypNb { get; set; }

    public decimal TrECena0 { get; set; }

    public decimal TrERabat { get; set; }

    public decimal TrECenaW { get; set; }

    public string TrEWaluta { get; set; } = null!;

    public byte TrEKaucja { get; set; }

    public byte? TrEWyborDostaw { get; set; }

    public int TrEKursNumer { get; set; }

    public decimal TrEKursL { get; set; }

    public decimal TrEKursM { get; set; }

    public decimal TrECenaT { get; set; }

    public decimal TrEIlosc { get; set; }

    public decimal TrEIloscKw { get; set; }

    public string TrEJm { get; set; } = null!;

    public string TrEJmZ { get; set; } = null!;

    public byte TrEJmCalkowite { get; set; }

    public decimal TrEJmprzelicznikL { get; set; }

    public decimal TrEJmprzelicznikM { get; set; }

    public decimal TrEIloscJm { get; set; }

    public decimal TrEIloscJmkw { get; set; }

    public decimal TrEWartoscNetto { get; set; }

    public decimal TrEWartoscBrutto { get; set; }

    public decimal? TrEWartoscZakupu { get; set; }

    public decimal TrEKosztUslugi { get; set; }

    public decimal TrEKosztKgo { get; set; }

    public decimal TreAkcyzaJmpomPrzelicznikL { get; set; }

    public int TreAkcyzaJmpomPrzelicznikM { get; set; }

    public decimal TrEAkcyzaOpal { get; set; }

    public decimal TrEAkcyzaStawka { get; set; }

    public int? TrEAkcyzaDeAid { get; set; }

    public string TrEAkcyzaKod { get; set; } = null!;

    public string TrEAkcyzaWartosc { get; set; } = null!;

    public string TrESjrodzajPaliwa { get; set; } = null!;

    public string TrESjsystemCertyfikacji { get; set; } = null!;

    public string TrESjpopiol { get; set; } = null!;

    public string TrESjsiarka { get; set; } = null!;

    public string TrESjczesciLotne { get; set; } = null!;

    public string TrESjwartoscOpalowa { get; set; } = null!;

    public string TrESjzdolnoscSpiekania { get; set; } = null!;

    public string TrESjwymiarZiarna { get; set; } = null!;

    public string TrESjzawartoscPodziarna { get; set; } = null!;

    public string TrESjzawartoscNadziarna { get; set; } = null!;

    public string TrESjzawartoscWilgoci { get; set; } = null!;

    public byte TreOdwrotneObciazenie { get; set; }

    public string TrEKodCn { get; set; } = null!;

    public decimal TrEWartoscZakupuWylicz { get; set; }

    public decimal TrECena0Wd { get; set; }

    public decimal TrECenaWwd { get; set; }

    public decimal TrEWartoscNettoWal { get; set; }

    public decimal TrEWartoscBruttoWal { get; set; }

    public int? TrEWartoscTymczasowa { get; set; }

    public int? TrEAtr1DeAid { get; set; }

    public string TrEAtr1Kod { get; set; } = null!;

    public string TrEAtr1Wartosc { get; set; } = null!;

    public int? TrEAtr2DeAid { get; set; }

    public string TrEAtr2Kod { get; set; } = null!;

    public string TrEAtr2Wartosc { get; set; } = null!;

    public int? TrEAtr3DeAid { get; set; }

    public string TrEAtr3Kod { get; set; } = null!;

    public string TrEAtr3Wartosc { get; set; } = null!;

    public int? TrEAtr4DeAid { get; set; }

    public string TrEAtr4Kod { get; set; } = null!;

    public string TrEAtr4Wartosc { get; set; } = null!;

    public int? TrEAtr5DeAid { get; set; }

    public string TrEAtr5Kod { get; set; } = null!;

    public string TrEAtr5Wartosc { get; set; } = null!;

    public decimal TrEProg { get; set; }

    public byte TrEUpustTyp { get; set; }

    public decimal TrEUpust { get; set; }

    public decimal TrEUpustKnt { get; set; }

    public byte TrEUpustKntTyp { get; set; }

    public byte TrEIfa24mag { get; set; }

    public byte TrEIfa24 { get; set; }

    public int TrEZtwId { get; set; }

    public int TrEZestawWiazanie { get; set; }

    public byte TrEZtwGlowny { get; set; }

    public string TrEZtwKod { get; set; } = null!;

    public decimal TrEZtwIlosc { get; set; }

    public decimal TrEDoZwrotu { get; set; }

    public int TrEUslugaZlozonaId { get; set; }

    public byte TrEUslugaZlozona { get; set; }

    public int TrEPatrEid { get; set; }

    public decimal TrEKwroznicaKursowa { get; set; }

    public byte TreCenaZczteremaMiejscami { get; set; }

    public decimal TrEFakZalKwotaMax { get; set; }

    public int TreUstawAtrSql { get; set; }

    public int TreUstawAtrSqldokTyp { get; set; }

    public byte TrESplitPay { get; set; }

    public int TrEKv7id { get; set; }

    public int TrECzySaCechyWymagane { get; set; }

    public decimal TrEOplataCukrowaPrzelicznikMl { get; set; }

    public decimal TrEOplataCukrowaOdCukrowStala { get; set; }

    public decimal TrEOplataCukrowaOdCukrowZmienna { get; set; }

    public decimal TrEOplataCukrowaOdKofeinyTaurynyStala { get; set; }

    public decimal TrEOplataCukrowaOdCukrowZawartoscGram { get; set; }

    public byte TrEOplataCukrowaOdCukrowZawartoscSokow20 { get; set; }

    public byte TrEOplataCukrowaOdCukrowZawartoscRoztwor { get; set; }

    public byte TrEOplataCukrowaOdSubstancjiSlodzacych { get; set; }

    public byte TrEOplataCukrowaOdKofeinyTauryny { get; set; }

    public string TrEOplataCukrowaNumerPartiiTowaru { get; set; } = null!;

    public decimal TrEOplataCukrowaDoliczDoCeny { get; set; }

    public byte TrEStawkaOss { get; set; }

    public string TrEKrajPochodzenia { get; set; } = null!;

    public virtual PodmiotyView? PodmiotyView { get; set; }

    public virtual ICollection<PrmHistorium> PrmHistoria { get; set; } = new List<PrmHistorium>();

    public virtual ICollection<ProdElem> ProdElems { get; set; } = new List<ProdElem>();

    public virtual Kategorie? TrEKat { get; set; }

    public virtual TraNag TrETrN { get; set; } = null!;

    public virtual Towary? TrETwr { get; set; }

    public virtual ICollection<TraElemKwotyCelne> TraElemKwotyCelnes { get; set; } = new List<TraElemKwotyCelne>();

    public virtual ICollection<TraSelemDost> TraSelemDosts { get; set; } = new List<TraSelemDost>();
}
