using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Operatorzy
{
    public int OpeOpeId { get; set; }

    public byte OpeBlokadaVatDoVat7 { get; set; }

    public byte OpeAkceptacjaDelegacji { get; set; }

    public byte OpePrawoZmianyZapKbzamRapKb { get; set; }

    public byte OpePrawoImportuZapKbotwRapKb { get; set; }

    public byte OpePokazOpisKontrahentaNaDokumentach { get; set; }

    public byte OpeUdostepnianieWydrukWpodgladzie { get; set; }

    public byte OpeOdblokowanieZlecen { get; set; }

    public byte OpeDostepDoZadanInnychOpe { get; set; }

    public byte OpeBlokadaDanychPlacowych { get; set; }

    public byte OpeBlokadaDanychPlacowychStawka { get; set; }

    public byte OpeZmianaPoprzedniegoCzasu { get; set; }

    public byte OpeBlokadaAnulWyplaty { get; set; }

    public byte OpeBlokadaAnulNieobecIzestCzas { get; set; }

    public byte OpeUdostepnianieAnalWpodgladzie { get; set; }

    public string OpeKod { get; set; } = null!;

    public string OpeNazwisko { get; set; } = null!;

    public string OpeHaslo { get; set; } = null!;

    public string OpeHasloChk { get; set; } = null!;

    public string OpeNtsid { get; set; } = null!;

    public string OpeNtkonto { get; set; } = null!;

    public byte OpeNtlogin { get; set; }

    public byte OpeAdministrator { get; set; }

    public int? OpeStartowa { get; set; }

    public string OpeBuforNazwa { get; set; } = null!;

    public byte OpeKsiegaGlowna { get; set; }

    public byte OpeBuforVatspr { get; set; }

    public byte OpeBuforVatzak { get; set; }

    public byte OpeBuforKasa { get; set; }

    public byte OpeBuforOkres { get; set; }

    public byte OpeBuforAmortyz { get; set; }

    public byte OpeBuforPlace { get; set; }

    public byte OpeBuforEwid { get; set; }

    public byte OpeZakazCenyZak { get; set; }

    public byte OpeZmianyOffLine { get; set; }

    public byte OpeTylkoStartowa { get; set; }

    public byte OpeKlasycznaKlawiatura { get; set; }

    public byte OpePowiadamianie { get; set; }

    public string OpeNumerSms { get; set; } = null!;

    public string OpeEmail { get; set; } = null!;

    public string OpeTelefon { get; set; } = null!;

    public string OpeNazwaKomputera { get; set; } = null!;

    public byte OpeInfoPoUruchomieniu { get; set; }

    public byte OpeInfoRazDziennie { get; set; }

    public byte OpeZmianaLimituKred { get; set; }

    public byte OpePlatnosciSprzedazTrwaly { get; set; }

    public byte OpeZmianaAtrNaZatwDok { get; set; }

    public byte OpePlatnosciSprzedazBufor { get; set; }

    public byte OpeZmianaKategorii { get; set; }

    public byte OpeKierownik { get; set; }

    public byte OpeBlokadaZmianTowaru { get; set; }

    public byte OpeBlokadaZmianMagazynu { get; set; }

    public byte OpeBlokadaZmianMagazynuListy { get; set; }

    public byte OpeBlokadaZmianCenFa { get; set; }

    public byte OpeBlokadaZmianCenFpf { get; set; }

    public byte OpeBlokadaZmianCenPa { get; set; }

    public byte OpeBlokadaZmianCenRo { get; set; }

    public byte OpeBlokadaZmianCenZd { get; set; }

    public byte OpeBlokadaZmianCenFz { get; set; }

    public byte OpeBlokadaFapadoBufora { get; set; }

    public byte OpeBlokadaPonownejFiskFapa { get; set; }

    public byte OpeZapisFapapoWydruku { get; set; }

    public byte OpeZapisWzpoWydruku { get; set; }

    public byte OpeZamkniecieDnia { get; set; }

    public byte OpeAktualizacjaKntHaMag { get; set; }

    public byte OpeZmianaOpisuHaMag { get; set; }

    public byte OpeMinMarzaHaMag { get; set; }

    public byte OpeBlokadaAnulowaniaHaMag { get; set; }

    public byte OpeRozliczanieZlistyHaMag { get; set; }

    public string OpeSymbolDlaNumeracji { get; set; } = null!;

    public string OpeMagazyn { get; set; } = null!;

    public string OpeHasloPm { get; set; } = null!;

    public string OpeKasa { get; set; } = null!;

    public string OpeBank { get; set; } = null!;

    public string OpeParametr { get; set; } = null!;

    public short OpeNieaktywny { get; set; }

    public string OpeKodDlaDf { get; set; } = null!;

    public byte OpeKonfigProgressLoga { get; set; }

    public byte OpeRaportProgressLoga { get; set; }

    public byte OpeBlokadaPlac { get; set; }

    public byte OpeBlokadaTylkoWynagrodzen { get; set; }

    public short OpeZmianaProcesuDomyslnego { get; set; }

    public short OpeModyfikacjaProcesow { get; set; }

    public short OpeDostepDoSkrzynkiInnychOperatorow { get; set; }

    public byte OpeDostepDoKontInnychOperatorow { get; set; }

    public short OpePrawoOdblokowaniaKontaktu { get; set; }

    public short OpeListaZadanDostepDoListyZadanInnychOpe { get; set; }

    public short OpeListaZadanPrawoDoModZadanInnychOpe { get; set; }

    public short OpeListaZadanDodanoZadPowitalne { get; set; }

    public byte? OpeKopiaBezpieczenstwa { get; set; }

    public short OpePrawoDoZamianEfaktury { get; set; }

    public byte OpeKotrolaCzesciPobranych { get; set; }

    public int OpeDetalFunkcjaPrac { get; set; }

    public byte OpeUproszczoneFakturowanie { get; set; }

    public byte OpePrawoDoPobrCzesciMagSerw { get; set; }

    public byte OpePrawoDoPobrCzesciMagLok { get; set; }

    public string OpeOpis { get; set; } = null!;

    public DateTime? OpeInfoData { get; set; }

    public DateTime? OpeDataZmianyHasla { get; set; }

    public byte OpeBlokadaCzasuPracy { get; set; }

    public byte OpeBlokadaSeryjnegoUsuwania { get; set; }

    public byte OpePrawoDoOdblokowaniaEdeklaracji { get; set; }

    public DateTime? OpeDataRss { get; set; }

    public byte OpePrawoUsuwaniaMaili { get; set; }

    public byte OpeWyswietlajInformacje { get; set; }

    public byte OpeWyswietlajOferteComarch { get; set; }

    public DateTime? OpeWyswietlajInformacjeTsMod { get; set; }

    public DateTime? OpePanelInformacjeTsOstatnieOtwarcie { get; set; }

    public DateTime? OpePanelAktualizacjeTsOstatnieOtwarcie { get; set; }

    public short? OpeGidtyp { get; set; }

    public int? OpeGidfirma { get; set; }

    public int? OpeGidnumer { get; set; }

    public short? OpeGidlp { get; set; }

    public byte OpePelneMenu { get; set; }

    public byte OpeModulKp { get; set; }

    public byte OpeModulKh { get; set; }

    public byte OpeModulSt { get; set; }

    public byte OpeModulFa { get; set; }

    public byte OpeModulMag { get; set; }

    public byte OpeModulPk { get; set; }

    public byte OpeModulPkxl { get; set; }

    public byte OpeModulAnl { get; set; }

    public byte OpeModulCrm { get; set; }

    public byte OpeModulCrmp { get; set; }

    public byte OpeModulKhp { get; set; }

    public byte OpeModulDet { get; set; }

    public byte OpeModulBiu { get; set; }

    public byte OpeModulSrw { get; set; }

    public byte OpeModulObd { get; set; }

    public byte OpeModulKb { get; set; }

    public byte OpeModulKbp { get; set; }

    public byte OpeModulHap { get; set; }

    public string OpeSsologin { get; set; } = null!;

    public string? OpeSsotoken { get; set; }

    public string OpeIbard24Login { get; set; } = null!;

    public string? OpeIbard24Haslo { get; set; }

    public byte OpeIbard24Wyloguj { get; set; }

    public byte OpeUzywaAnalizBi { get; set; }

    public byte OpeAnalizyBiAdministrator { get; set; }

    public byte OpeAnalizyBiSubskrypcje { get; set; }

    public byte OpeAnalizyBiDodawaniePol { get; set; }

    public byte OpeAnalizyBiDrukowanie { get; set; }

    public byte OpeAnalizyBiEksport { get; set; }

    public byte OpeAnalizyBiModyfikacjaZapytania { get; set; }

    public byte OpeAnalizyBiImportRaportu { get; set; }

    public byte OpeKrdPobieranieRaportow { get; set; }

    public byte OpeCrmDostepDoZadanInnychOperatorowRo { get; set; }

    public byte OpeCrmUczestnikMaPrawoZmieniacZadanie { get; set; }

    public byte OpeKontrolaPlatnosciWz { get; set; }

    public byte OpePlatnoscNaWz { get; set; }

    public string? OpeKontoDomenowe { get; set; }

    public string? OpeKontoDomenoweSid { get; set; }

    public byte OpeBlokadaZmianyKwotyWplaty { get; set; }

    public byte OpeHistTowUstawiajTypDok { get; set; }

    public byte OpeHistTowUstawiajKntMag { get; set; }

    public byte OpePrawoScalaniaKnt { get; set; }

    public byte OpePrawoEksportuJpk { get; set; }

    public byte OpePrawoEksportuSprawozdanFinansowych { get; set; }

    public byte OpeComarchPpk { get; set; }

    public string? OpeDziennikSymbolRk { get; set; }

    public string? OpeDziennikSymbolKomp { get; set; }

    public byte OpeBlokadaDokMmzMagMob { get; set; }

    public byte OpeUdostepnianieWydrukowBip { get; set; }

    public byte OpeAnkietyDostepDoAnkietInnychOperatorow { get; set; }

    public byte OpeAnkietyPrawoDoOdblokowaniaAnkietyZatwierdzonej { get; set; }

    public byte OpeAutoUruchamianieKalkulatora { get; set; }

    public byte OpePrawoDostepuDoRejestrowRodo { get; set; }

    public byte OpePrawoAnonimizacjiDanychOsobowych { get; set; }

    public byte OpeZgodyPodmiotu { get; set; }

    public byte OpePrawoDoUdostPlikowObdDlaOcr { get; set; }

    public byte OpeObdDlaOcrUdostepniajDomyslnie { get; set; }

    public int? OpeOpeZalId { get; set; }

    public int? OpeStaZalId { get; set; }

    public DateTime? OpeTsZal { get; set; }

    public int? OpeOpeModId { get; set; }

    public int? OpeStaModId { get; set; }

    public DateTime? OpeTsMod { get; set; }

    public string OpeOpeModKod { get; set; } = null!;

    public string OpeOpeModNazwisko { get; set; } = null!;

    public string OpeOpeZalKod { get; set; } = null!;

    public string OpeOpeZalNazwisko { get; set; } = null!;

    public string? OpeNowosciWwersji { get; set; }

    public byte OpePrawoDoListyPropozycjiFakturCykl { get; set; }

    public byte OpeApfinoPrawoDoZglaszaniaFinansowania { get; set; }

    public byte OpeApfinoPrawoDoZglaszaniaWindykacji { get; set; }

    public byte OpeApfinoPrawoDoPrzekazywaniaFaktur { get; set; }

    public byte OpeApfinoPrawoDoSprawdzaniaKntWrejDluzn { get; set; }

    public byte OpeWysylanieFakturDoKseF { get; set; }

    public byte OpeAutomatyczneWysylanieFakturDoKseF { get; set; }

    public byte OpeUwierzytelnienieZaPomocaToken { get; set; }

    public byte OpePrawoGenerowaniaHaselPdf { get; set; }

    public byte OpeKseFPrawoDoOdbieraniaeFaktur { get; set; }

    public byte OpeKseFPrawoDoOdbieraniaeFakturZakupu { get; set; }

    public byte OpeKseFPrawoDoOdbieraniaeFakturSprzedazy { get; set; }

    public byte OpeIKsg24PrawoDoPrzegladaniaIdodawaniaKlientow { get; set; }

    public byte OpeIKsg24PrawoDoKorespondowaniaZklientamiBiura { get; set; }

    public byte OpePrawoDoChatErp { get; set; }

    public int? OpeDabId { get; set; }

    public string? OpeSsohash { get; set; }

    public virtual ICollection<BazModulyOperatora> BazModulyOperatoras { get; set; } = new List<BazModulyOperatora>();

    public virtual ICollection<BazPrzypomnienium> BazPrzypomnienia { get; set; } = new List<BazPrzypomnienium>();

    public virtual ICollection<BazZakazy> BazZakazies { get; set; } = new List<BazZakazy>();

    public virtual ICollection<KatrybutyKlasyZakaz> KatrybutyKlasyZakazs { get; set; } = new List<KatrybutyKlasyZakaz>();

    public virtual ICollection<KatrybutyKolumny> KatrybutyKolumnies { get; set; } = new List<KatrybutyKolumny>();

    public virtual ICollection<OfertySzablonyDomyslne> OfertySzablonyDomyslnes { get; set; } = new List<OfertySzablonyDomyslne>();

    public virtual ICollection<OpeInfoBaza> OpeInfoBazas { get; set; } = new List<OpeInfoBaza>();

    public virtual ICollection<OpeInformacje> OpeInformacjes { get; set; } = new List<OpeInformacje>();

    public virtual ICollection<OpeUstawienium> OpeUstawienia { get; set; } = new List<OpeUstawienium>();

    public virtual ICollection<ProZakazy> ProZakazies { get; set; } = new List<ProZakazy>();

    public virtual ICollection<Rcsesje> Rcsesjes { get; set; } = new List<Rcsesje>();

    public virtual ICollection<SekEtapOperatorzy> SekEtapOperatorzies { get; set; } = new List<SekEtapOperatorzy>();

    public virtual ICollection<Sync> SyncSncApfinoOpes { get; set; } = new List<Sync>();

    public virtual ICollection<Sync> SyncSncDetalOpes { get; set; } = new List<Sync>();

    public virtual ICollection<Sync> SyncSncEsklepOpes { get; set; } = new List<Sync>();

    public virtual ICollection<Sync> SyncSncXlopes { get; set; } = new List<Sync>();

    public virtual ICollection<ZadaniaWtle> ZadaniaWtles { get; set; } = new List<ZadaniaWtle>();
}
