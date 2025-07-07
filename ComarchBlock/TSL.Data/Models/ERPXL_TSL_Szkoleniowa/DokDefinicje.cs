using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class DokDefinicje
{
    public int DokId { get; set; }

    public short? DokGidtyp { get; set; }

    public int? DokFrsId { get; set; }

    public string? DokSymbol { get; set; }

    public string? DokNazwa { get; set; }

    public string? DokWaluta { get; set; }

    public short? DokKursLp { get; set; }

    public byte? DokRabatOdWartKsieg { get; set; }

    public byte? DokPlatnosci { get; set; }

    public byte? DokPltWaluta { get; set; }

    public byte? DokNettoBrutto { get; set; }

    public byte? DokRezerwacje { get; set; }

    public byte? DokRezerwujZasoby { get; set; }

    public byte? DokUwzgledniajRezerwacje { get; set; }

    public byte? DokChronologiaRezerwacji { get; set; }

    public byte? DokJedenMagazyn { get; set; }

    public short? DokMagZtyp { get; set; }

    public int? DokMagZfirma { get; set; }

    public int? DokMagZnumer { get; set; }

    public short? DokMagZlp { get; set; }

    public short? DokMagDtyp { get; set; }

    public int? DokMagDfirma { get; set; }

    public int? DokMagDnumer { get; set; }

    public short? DokMagDlp { get; set; }

    public short? DokMagKtyp { get; set; }

    public int? DokMagKfirma { get; set; }

    public int? DokMagKnumer { get; set; }

    public short? DokMagKlp { get; set; }

    public short? DokSerTyp { get; set; }

    public int? DokSerFirma { get; set; }

    public int? DokSerNumer { get; set; }

    public short? DokSerLp { get; set; }

    public short? DokSerKtyp { get; set; }

    public int? DokSerKfirma { get; set; }

    public int? DokSerKnumer { get; set; }

    public short? DokSerKlp { get; set; }

    public short? DokSerPtyp { get; set; }

    public int? DokSerPfirma { get; set; }

    public int? DokSerPnumer { get; set; }

    public short? DokSerPlp { get; set; }

    public byte? DokIloscXcena { get; set; }

    public int? DokDataRealizacji { get; set; }

    public int? DokPltData { get; set; }

    public int? DokRezDataAkt { get; set; }

    public int? DokRezDataWaznosci { get; set; }

    public byte? DokZamPrzeliczWart { get; set; }

    public byte? DokRealizujWcalosci { get; set; }

    public byte? DokPrecyzjaCeny { get; set; }

    public byte? DokAktualizujCenyZak { get; set; }

    public byte? DokMagPreferowane { get; set; }

    public byte? DokAutoPotwierdzanie { get; set; }

    public byte? DokAutoMagazynowe { get; set; }

    public byte? DokWystPrawo { get; set; }

    public byte? DokZatwPrawo { get; set; }

    public byte? DokAnulPrawo { get; set; }

    public byte? DokPoprzednieZaNprawo { get; set; }

    public byte? DokPoprzednieTrNprawo { get; set; }

    public byte? DokKntLimitPrawo { get; set; }

    public byte? DokCenyRabatyPrawo { get; set; }

    public byte? DokAutomatyczneKompensaty { get; set; }

    public byte? DokProduktOdSkladnikow { get; set; }

    public byte? DokProstaAvista { get; set; }

    public byte? DokZlcCenaNaPw { get; set; }

    public byte? DokZlcPrzezDokMag { get; set; }

    public byte? DokNieSprzedawajPonizejMarzy { get; set; }

    public byte? DokTylkoKraj { get; set; }

    public byte? DokKosztUslugi { get; set; }

    public byte? DokDefZnadrzednego { get; set; }

    public short? DokOpeZalTyp { get; set; }

    public int? DokOpeZalFirma { get; set; }

    public int? DokOpeZalNumer { get; set; }

    public short? DokOpeZalLp { get; set; }

    public int? DokDataZal { get; set; }

    public short? DokOpeModTyp { get; set; }

    public int? DokOpeModFirma { get; set; }

    public int? DokOpeModNumer { get; set; }

    public short? DokOpeModLp { get; set; }

    public int? DokDataMod { get; set; }

    public byte? DokCentrum { get; set; }

    public byte? DokLokalizacja { get; set; }

    public byte? DokKontrahentDoc { get; set; }

    public byte? DokKategoriaFin { get; set; }

    public byte? DokRodzajKategorii { get; set; }

    public int? DokRodzajKategoriiKw { get; set; }

    public byte? DokEdycjaKategorii { get; set; }

    public short? DokDataControllingowa { get; set; }

    public byte? DokDataKsiegowania { get; set; }

    public byte? DokProjekt { get; set; }

    public byte? DokPustaLista { get; set; }

    public byte? DokWyszukiwanieWlasciciela { get; set; }

    public byte? DokJedenSkladnikRobocizna { get; set; }

    public byte? DokPrzepisujOpisZlecenia { get; set; }

    public byte? DokAutoKaucje { get; set; }

    public byte? DokObslugaSad { get; set; }

    public byte? DokAutoWyposazenie { get; set; }

    public byte? DokAktualizujCenySpr { get; set; }

    public byte? DokLaczPozycjeMag { get; set; }

    public int? DokMagDoRnumer { get; set; }

    public int? DokMagRemNumer { get; set; }

    public int? DokMagPoRnumer { get; set; }

    public byte? DokKosztUstalony { get; set; }

    public short? DokCenaBazowa { get; set; }

    public byte? DokZgodnaWaluta { get; set; }

    public byte? DokPowielaniePozycji { get; set; }

    public decimal? DokProwizjaTaxFree { get; set; }

    public byte? DokPrzeliczajAktualizowaneCeny { get; set; }

    public byte? DokGenerujZapisWterminarzu { get; set; }

    public byte? DokPrzydzielDoRezerwacji { get; set; }

    public int? DokStopkaWydruku { get; set; }

    public byte? DokAutomatyczneMmp { get; set; }

    public byte? DokPodzialPzi { get; set; }

    public byte? DokPominKosztZ { get; set; }

    public byte? DokPominKosztK { get; set; }

    public byte? DokPominClo { get; set; }

    public byte? DokPominAkcyze { get; set; }

    public byte? DokKursDlaDostawy { get; set; }

    public byte? DokTypRozbiciaKwot { get; set; }

    public byte? DokAutoWydruk { get; set; }

    public byte? DokAutoWydrukPytaj { get; set; }

    public byte? DokPodglPrawo { get; set; }

    public short? DokScztyp { get; set; }

    public int? DokSczfirma { get; set; }

    public int? DokScznumer { get; set; }

    public short? DokSczlp { get; set; }

    public byte? DokZrodloTowarow { get; set; }

    public byte? DokVatEksportowy { get; set; }

    public short? DokSchTyp { get; set; }

    public int? DokSchNumer { get; set; }

    public string? DokDziennik { get; set; }

    public short? DokDziennikOkreslonyWschemacie { get; set; }

    public byte? DokUjecieJednoT { get; set; }

    public byte? DokUjecieDwuT { get; set; }

    public byte? DokZeroweWartosci { get; set; }

    public byte? DokLimitUwzglDokBezPlat { get; set; }

    public byte? DokLimitUwzglZam { get; set; }

    public byte? DokLimitUwzglSaldoKntGlownego { get; set; }

    public short? DokKntTyp { get; set; }

    public int? DokKntNumer { get; set; }

    public int? DokPlanDostepneMetody { get; set; }

    public byte? DokPlanDomyslne { get; set; }

    public byte? DokPrzeplanDomyslne { get; set; }

    public byte? DokPlanZgrubne { get; set; }

    public byte? DokAutoPrzeplanujNizsze { get; set; }

    public int? DokPlanRozpocznijOd { get; set; }

    public int? DokPlanCzasTrwania { get; set; }

    public byte? DokPlanCzasTrwaniaJedn { get; set; }

    public byte? DokAktualizujPoKnt { get; set; }

    public byte? DokAktualizujPoDaty { get; set; }

    public byte? DokAktualizujPoSpDost { get; set; }

    public byte? DokAktualizujPoWlascicielu { get; set; }

    public byte? DokAktualizujPoPlatnosc { get; set; }

    public byte? DokAktualizujPoMagazynie { get; set; }

    public byte? DokReklUwzgledniajMag { get; set; }

    public byte? DokPlacePozaNorma { get; set; }

    public byte? DokPlacePomniejszenieZus { get; set; }

    public byte? DokPlacePomniejszenieProporcjonalne { get; set; }

    public byte? DokPlacePomniejszenieUrlopMies { get; set; }

    public int? DokCzasModyfikacji { get; set; }

    public int? DokCzasPodniesienia { get; set; }

    public byte? DokRodzajDatyKursu { get; set; }

    public short? DokIleDniKurs { get; set; }

    public byte? DokKntOgolne { get; set; }

    public byte? DokZmianaDatElem { get; set; }

    public byte? DokRezerwacjeNiepotw { get; set; }

    public byte? DokNumerAnulowanego { get; set; }

    public byte? DokPrzydzialReczny { get; set; }

    public byte? DokWiazanieZamowien { get; set; }

    public byte? DokPrzywracajRezerwacje { get; set; }

    public byte? DokKontrolujIlosciPrzyGenZam { get; set; }

    public byte? DokAutoWydrukPytajZapis { get; set; }

    public byte? DokLaczPozycjeWprodukcji { get; set; }

    public byte? DokPrzeliczDomyslne { get; set; }

    public byte? DokGenerujZatwPrzyZamykaniuZp { get; set; }

    public byte? DokStosujPromocjePakietowe { get; set; }

    public byte? DokAnulPrawoZpotwParam { get; set; }

    public byte? DokDokPrzyjeciaPoDokWydania { get; set; }

    public byte? DokGenerowanieDokFws { get; set; }

    public byte? DokGenerowanieDokFwz { get; set; }

    public byte? DokGenerowanieZamowienia { get; set; }

    public int? DokRealizacja { get; set; }

    public int? DokPanelPomocniczy { get; set; }

    public byte? DokZatwBezDanych { get; set; }

    public byte? DokEdycjaPoUruchProd { get; set; }

    public byte? DokDataZmagazynowego { get; set; }

    public byte? DokDataZmagazynowegoTyp { get; set; }

    public byte? DokDataNaSpinaczu { get; set; }

    public byte? DokWymagajZgodnejJednostki { get; set; }

    public int? DokPplskladnikiMps { get; set; }

    public byte? DokPplsposobPrzeliczenia { get; set; }

    public byte? DokPplproduktyZdefTechnologia { get; set; }

    public byte? DokPpldoProdukcjiPodst { get; set; }

    public byte? DokPpldoZamowieniaPodst { get; set; }

    public byte? DokPploptymalizacjaDoProdukcji { get; set; }

    public byte? DokPploptymalizacjaDoZamowienia { get; set; }

    public byte? DokPpluwzglednijBom { get; set; }

    public byte? DokPplprzeliczajPotwierdzony { get; set; }

    public int? DokPlanProdukcjiOkresPlanistycznyOd { get; set; }

    public int? DokPlanProdukcjiOkresPlanistycznyCzasTrwania { get; set; }

    public byte? DokPlanProdukcjiOkresPlanistycznyCzasTrwJedn { get; set; }

    public byte? DokPpliloscOgolnieDostepna { get; set; }

    public byte? DokPpliloscWdrodze { get; set; }

    public short? DokRealizacjaUruchamiaj { get; set; }

    public short? DokRealizacjaRejestruj { get; set; }

    public byte? DokPodmianaMaterialow { get; set; }

    public byte? DokProdPrzyOtwOknaZawijajDrzewoOperacji { get; set; }

    public byte? DokDataOperacjiKdz { get; set; }

    public byte? DokTypCenyNabycia { get; set; }

    public byte? DokGenerowKdzpodczasKorygowania { get; set; }

    public byte? DokDozwolonyOpisDokWbuforze { get; set; }

    public byte? DokOkresPlanistycznyZpp { get; set; }

    public byte? DokOkresPlanistycznyIloscOkresow { get; set; }

    public byte? DokAutoGenerowanieDokKdz { get; set; }

    public byte? DokRealizacjaWgPlanu { get; set; }

    public int? DokAdnotacjaNaNiezatwierdzonym { get; set; }

    public byte? DokModyfikacjaKwotVataVista { get; set; }

    public byte? DokDataPromocji { get; set; }

    public byte? DokAutoRozliczZal { get; set; }

    public byte? DokPlatnosciRozszerzone { get; set; }

    public byte? DokWsteczOdDatyRz { get; set; }

    public int? DokCzasPomniejszeniaDaty { get; set; }

    public byte? DokWsteczOdDatyUstalonej { get; set; }

    public int? DokCzasPomniejszeniaDatyUstalonej { get; set; }

    public byte? DokRezZasTylkoAktywne { get; set; }

    public int? DokPrzepnijZasoby { get; set; }

    public byte? DokOdliczanieFaZal { get; set; }

    public byte? DokPrzesunOperacjePoRealizacji { get; set; }

    public byte? DokPrzesunNaZwolnionych { get; set; }

    public byte? DokUsunNiesparowane { get; set; }

    public byte? DokOsobneElementyDostawZdp { get; set; }

    public byte? DokSpiCenaWartosc { get; set; }

    public byte? DokSpiZgodnoscKnt { get; set; }

    public byte? DokSpiZgodnoscKursu { get; set; }

    public byte? DokSpiKoryguj { get; set; }

    public byte? DokSpiKontrolaMarzy { get; set; }

    public short? DokSpiCenaMarza { get; set; }

    public short? DokBstpominPowiazane { get; set; }

    public byte? DokNaliczajPunktyLojal { get; set; }

    public byte? DokWymiaryZrodzica { get; set; }

    public byte? DokOpisZrodzica { get; set; }

    public byte? DokDostepDoWzorcow { get; set; }

    public byte? DokDostepDoWzorcowAnalitPodrz { get; set; }

    public byte? DokNieKsiegowac { get; set; }

    public byte? DokBlokadaZatwZniezgodnymNip { get; set; }

    public byte? DokGenerujRwpodczasRealizacji { get; set; }

    public byte? DokGenerujPwpodczasRealizacji { get; set; }

    public byte? DokElementyNaKorektach { get; set; }

    public byte? DokGenerujZleceniaPrzyPlanowaniu { get; set; }

    public byte? DokGenerujJednNaWieleMag { get; set; }

    public short? DokIloscElemKor { get; set; }

    public byte? DokZerowaIloscRealizacji { get; set; }

    public byte? DokPolaczOperacjeTpZpolprod { get; set; }

    public byte? DokGenerujFaktAvistaEbc { get; set; }

    public byte? DokSpiNieKsiegujSpiete { get; set; }

    public byte? DokAutoGenerowaniePkj { get; set; }

    public byte? DokZakresRezerwacjiDlaProduktow { get; set; }

    public byte? DokDzielWzwm { get; set; }

    public byte? DokBstOptymalizacjaZam { get; set; }

    public byte? DokWymagajPodaniaStanuOperacji { get; set; }

    public byte? DokRodzajPaczki { get; set; }

    public byte? DokSposobLaczeniaDoPaczki { get; set; }

    public byte? DokUwzgJednLogProdukty { get; set; }

    public byte? DokUwzgJednLogMaterialy { get; set; }

    public byte? DokWyborMagazynuNaPozycji { get; set; }

    public byte? DokProdZakonczenieWgPlanu { get; set; }

    public byte? DokKseFczyWysylac { get; set; }

    public byte? DokKseFautomatycznie { get; set; }

    public byte? DokKseFweryfikuj { get; set; }

    public byte? DokKseFpobierajUpo { get; set; }

    public short? DokPosTerminRozpRls { get; set; }

    public byte? DokPlanWskazaneZasoby { get; set; }

    public virtual FrmStruktura? DokFrs { get; set; }

    public virtual ICollection<DokRelacje> DokRelacjes { get; set; } = new List<DokRelacje>();

    public virtual ICollection<Wymiary> DoWWyms { get; set; } = new List<Wymiary>();
}
