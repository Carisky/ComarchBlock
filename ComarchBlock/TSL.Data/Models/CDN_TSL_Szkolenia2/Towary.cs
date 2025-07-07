using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Towary
{
    public int TwrTwrId { get; set; }

    public byte TwrTyp { get; set; }

    public short TwrProdukt { get; set; }

    public string TwrKod { get; set; } = null!;

    public byte TwrAutoKodGrupaTowarowa { get; set; }

    public string TwrAutoKodSeria { get; set; } = null!;

    public string TwrAutoKodWartosc { get; set; } = null!;

    public int TwrAutoKodNumer { get; set; }

    public string TwrPlu { get; set; } = null!;

    public string TwrNumerKat { get; set; } = null!;

    public string TwrSww { get; set; } = null!;

    public string TwrEan { get; set; } = null!;

    public string TwrNazwa { get; set; } = null!;

    public string TwrNazwaFiskalna { get; set; } = null!;

    public int TwrTwGgidnumer { get; set; }

    public string TwrUrl { get; set; } = null!;

    public int? TwrKatId { get; set; }

    public string TwrKategoria { get; set; } = null!;

    public int? TwrKatZakId { get; set; }

    public string TwrKategoriaZak { get; set; } = null!;

    public string TwrOpis { get; set; } = null!;

    public byte TwrEdycjaNazwy { get; set; }

    public byte TwrKopiujOpis { get; set; }

    public byte TwrEdycjaOpisu { get; set; }

    public string TwrJm { get; set; } = null!;

    public byte TwrJmcalkowite { get; set; }

    public string TwrJmz { get; set; } = null!;

    public decimal TwrJmprzelicznikL { get; set; }

    public decimal TwrJmprzelicznikM { get; set; }

    public byte TwrKaucja { get; set; }

    public int TwrTwCnumer { get; set; }

    public byte TwrUdostepniajWcenniku { get; set; }

    public string TwrWaluta { get; set; } = null!;

    public int TwrKursNumer { get; set; }

    public decimal TwrKursL { get; set; }

    public decimal TwrKursM { get; set; }

    public decimal TwrMinCenaMarza { get; set; }

    public byte TwrTypMinimum { get; set; }

    public decimal TwrKosztUslugiWal { get; set; }

    public decimal TwrKosztUslugi { get; set; }

    public byte TwrKosztUslugiTyp { get; set; }

    public decimal TwrKosztKgo { get; set; }

    public int? TwrSonid { get; set; }

    public int? TwrKntId { get; set; }

    public string TwrKodDostawcy { get; set; } = null!;

    public string TwrProducentKod { get; set; } = null!;

    public decimal TwrIloscMin { get; set; }

    public string TwrIloscMinJm { get; set; } = null!;

    public decimal TwrIloscMax { get; set; }

    public string TwrIloscMaxJm { get; set; } = null!;

    public decimal TwrIloscZam { get; set; }

    public string TwrIloscZamJm { get; set; } = null!;

    public decimal TwrStawka { get; set; }

    public short TwrFlaga { get; set; }

    public decimal TwrZrodlowa { get; set; }

    public decimal TwrStawkaExport { get; set; }

    public short TwrFlagaExport { get; set; }

    public decimal TwrZrodlowaExport { get; set; }

    public decimal TwrStawkaZak { get; set; }

    public short TwrFlagaZak { get; set; }

    public decimal TwrZrodlowaZak { get; set; }

    public byte TwrProg { get; set; }

    public byte TwrUpust { get; set; }

    public byte TwrUpustData { get; set; }

    public int? TwrUpustDataOd { get; set; }

    public int? TwrUpustDataDo { get; set; }

    public byte TwrUpustGodz { get; set; }

    public int? TwrUpustGodzOd { get; set; }

    public int? TwrUpustGodzDo { get; set; }

    public byte TwrBezRabatu { get; set; }

    public decimal TwrMarzaMin { get; set; }

    public byte TwrNieAktywny { get; set; }

    public byte? TwrEsklep { get; set; }

    public int? TwrKcnid { get; set; }

    public decimal TwrMasa { get; set; }

    public byte TwrSent { get; set; }

    public decimal TwrJmsentPrzelicznikL { get; set; }

    public decimal TwrJmsentPrzelicznikM { get; set; }

    public decimal TwrSentMasaBrutto { get; set; }

    public string TwrSentKodOdpadu { get; set; } = null!;

    public int? TwrPrdId { get; set; }

    public int? TwrMrkId { get; set; }

    public short TwrEsklepBezRabatu { get; set; }

    public short TwrEsklepStatus { get; set; }

    public short TwrEsklepDostepnosc { get; set; }

    public byte TwrEsklepKalkulacjaDostaw { get; set; }

    public decimal TwrEsklepKalkulacjaDostawWartosc { get; set; }

    public byte TwrEsklepFlagaNowosc { get; set; }

    public byte TwrEsklepFlagaPromocja { get; set; }

    public byte TwrEsklepFlagaProduktzGazetki { get; set; }

    public byte TwrEsklepFlagaProduktPolecany { get; set; }

    public byte TwrEsklepFlagaWyprzedaz { get; set; }

    public byte TwrEsklepFlagaSuperJakosc { get; set; }

    public byte TwrEsklepFlagaSuperCena { get; set; }

    public byte TwrEsklepFlagaNajlepiejOceniany { get; set; }

    public byte TwrEsklepFlagaRekomendacjaSprzedawcy { get; set; }

    public int? TwrEsklepFantomId { get; set; }

    public decimal? TwrWagaKg { get; set; }

    public string TwrKrajPochodzenia { get; set; } = null!;

    public decimal TwrJmPomPrzelicznikL { get; set; }

    public decimal TwrJmPomPrzelicznikM { get; set; }

    public int? TwrOpeZalId { get; set; }

    public int? TwrStaZalId { get; set; }

    public DateTime TwrTsZal { get; set; }

    public int? TwrOpeModId { get; set; }

    public int? TwrStaModId { get; set; }

    public DateTime? TwrTsXl { get; set; }

    public DateTime TwrTsMod { get; set; }

    public string TwrOpeModKod { get; set; } = null!;

    public string TwrOpeModNazwisko { get; set; } = null!;

    public string TwrOpeZalKod { get; set; } = null!;

    public string TwrOpeZalNazwisko { get; set; } = null!;

    public short? TwrGidtyp { get; set; }

    public int? TwrGidfirma { get; set; }

    public int? TwrGidnumer { get; set; }

    public short? TwrGidlp { get; set; }

    public byte TwrAkcyza { get; set; }

    public decimal TwrAkcyzaJmpomPrzelicznikL { get; set; }

    public int TwrAkcyzaJmpomPrzelicznikM { get; set; }

    public decimal TwrAkcyzaOpal { get; set; }

    public decimal TwrAkcyzaStawka { get; set; }

    public string TwrSjrodzajPaliwa { get; set; } = null!;

    public string TwrSjsystemCertyfikacji { get; set; } = null!;

    public string TwrSjpopiol { get; set; } = null!;

    public string TwrSjpopiolMin { get; set; } = null!;

    public string TwrSjpopiolMax { get; set; } = null!;

    public string TwrSjsiarka { get; set; } = null!;

    public string TwrSjsiarkaMin { get; set; } = null!;

    public string TwrSjsiarkaMax { get; set; } = null!;

    public string TwrSjczesciLotne { get; set; } = null!;

    public string TwrSjczesciLotneMin { get; set; } = null!;

    public string TwrSjczesciLotneMax { get; set; } = null!;

    public string TwrSjwartoscOpalowa { get; set; } = null!;

    public string TwrSjwartoscOpalowaMin { get; set; } = null!;

    public string TwrSjwartoscOpalowaMax { get; set; } = null!;

    public string TwrSjzdolnoscSpiekania { get; set; } = null!;

    public string TwrSjzdolnoscSpiekaniaMin { get; set; } = null!;

    public string TwrSjzdolnoscSpiekaniaMax { get; set; } = null!;

    public string TwrSjwymiarZiarna { get; set; } = null!;

    public string TwrSjwymiarZiarnaMin { get; set; } = null!;

    public string TwrSjwymiarZiarnaMax { get; set; } = null!;

    public string TwrSjzawartoscPodziarna { get; set; } = null!;

    public string TwrSjzawartoscPodziarnaMin { get; set; } = null!;

    public string TwrSjzawartoscPodziarnaMax { get; set; } = null!;

    public string TwrSjzawartoscNadziarna { get; set; } = null!;

    public string TwrSjzawartoscNadziarnaMin { get; set; } = null!;

    public string TwrSjzawartoscNadziarnaMax { get; set; } = null!;

    public string TwrSjzawartoscWilgoci { get; set; } = null!;

    public string TwrSjzawartoscWilgociMin { get; set; } = null!;

    public string TwrSjzawartoscWilgociMax { get; set; } = null!;

    public byte TwrOdwrotneObciazenie { get; set; }

    public byte TwrMobile { get; set; }

    public byte TwrPobieranieSkladnikowFsuslugaZlozona { get; set; }

    public decimal TwRKosztUslugiOld { get; set; }

    public string TwRWalutaZakOld { get; set; } = null!;

    public decimal TwRKursLzakOld { get; set; }

    public decimal TwRKursMzakOld { get; set; }

    public byte TwrCenaZczteremaMiejscami { get; set; }

    public byte TwrSplitPay { get; set; }

    public int TwrKv7id { get; set; }

    public short? TwrOpiekunTyp { get; set; }

    public int? TwrOpiekunId { get; set; }

    public short? TwrJmwysCm { get; set; }

    public short? TwrJmszerCm { get; set; }

    public short? TwrJmdlugCm { get; set; }

    public byte TwrOplataCukrowa { get; set; }

    public decimal TwrOplataCukrowaPrzelicznikMl { get; set; }

    public byte TwrOplataCukrowaOdCukrowZawartoscSokow20 { get; set; }

    public byte TwrOplataCukrowaOdSubstancjiSlodzacych { get; set; }

    public decimal TwrOplataCukrowaOdCukrowStala { get; set; }

    public decimal TwrOplataCukrowaOdCukrowZmienna { get; set; }

    public byte TwrOplataCukrowaOdKofeinyTauryny { get; set; }

    public decimal TwrOplataCukrowaOdKofeinyTaurynyStala { get; set; }

    public decimal TwrOplataCukrowaSuma { get; set; }

    public decimal TwrOplataCukrowaOdCukrowZawartoscGram { get; set; }

    public byte TwrOplataCukrowaOdCukrowZawartoscRoztwor { get; set; }

    public byte TwRMiejsceDodania { get; set; }

    public virtual ICollection<IgaleriaAtrWartosci> IgaleriaAtrWartoscis { get; set; } = new List<IgaleriaAtrWartosci>();

    public virtual ICollection<PodArkuszInwenElem> PodArkuszInwenElems { get; set; } = new List<PodArkuszInwenElem>();

    public virtual ICollection<ProdElem> ProdElems { get; set; } = new List<ProdElem>();

    public virtual ICollection<ProdReceptury> ProdRecepturies { get; set; } = new List<ProdReceptury>();

    public virtual ICollection<ProdSkladniki> ProdSkladnikis { get; set; } = new List<ProdSkladniki>();

    public virtual ICollection<RemanentElem> RemanentElems { get; set; } = new List<RemanentElem>();

    public virtual ICollection<SchematyOpakElem> SchematyOpakElems { get; set; } = new List<SchematyOpakElem>();

    public virtual ICollection<TraElem> TraElems { get; set; } = new List<TraElem>();

    public virtual ICollection<TraSelem> TraSelems { get; set; } = new List<TraSelem>();

    public virtual ICollection<TwrAtrybuty> TwrAtrybuties { get; set; } = new List<TwrAtrybuty>();

    public virtual ICollection<TwrCeny> TwrCenies { get; set; } = new List<TwrCeny>();

    public virtual ICollection<TwrEan> TwrEans { get; set; } = new List<TwrEan>();

    public virtual ICollection<TwrEsklep> TwrEskleps { get; set; } = new List<TwrEsklep>();

    public virtual ICollection<TwrIlosci> TwrIloscis { get; set; } = new List<TwrIlosci>();

    public virtual ICollection<TwrJezykObcy> TwrJezykObcies { get; set; } = new List<TwrJezykObcy>();

    public virtual ICollection<TwrJmz> TwrJmzs { get; set; } = new List<TwrJmz>();

    public virtual Kategorie? TwrKat { get; set; }

    public virtual Kategorie? TwrKatZak { get; set; }

    public virtual KodyCn? TwrKcn { get; set; }

    public virtual Kontrahenci? TwrKnt { get; set; }

    public virtual ICollection<TwrStawkiVat> TwrStawkiVats { get; set; } = new List<TwrStawkiVat>();

    public virtual TwrTsmodEsklep? TwrTsmodEsklep { get; set; }

    public virtual ICollection<TwrZasoby> TwrZasobies { get; set; } = new List<TwrZasoby>();

    public virtual ICollection<Zamienniki> Zamiennikis { get; set; } = new List<Zamienniki>();

    public virtual ICollection<ZestawyTwrSkladniki> ZestawyTwrSkladnikis { get; set; } = new List<ZestawyTwrSkladniki>();

    public virtual ICollection<ZestawyTwr> ZestawyTwrs { get; set; } = new List<ZestawyTwr>();
}
