using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class PracEtaty
{
    public int PrePreId { get; set; }

    public int? PreZrgId { get; set; }

    public int PrePraId { get; set; }

    public short? PrePodmiotTyp { get; set; }

    public int? PreDzlId { get; set; }

    public int? PreCntId { get; set; }

    public int? PreKalId { get; set; }

    public int? PreEtatwpId { get; set; }

    public int PreUbztyuId { get; set; }

    public byte PreTypPracownika { get; set; }

    public int? PreWlascicielId { get; set; }

    public int? PreBnaId { get; set; }

    public int? PreFplId { get; set; }

    public string PreKod { get; set; } = null!;

    public string PreNazwisko { get; set; } = null!;

    public string PreImie1 { get; set; } = null!;

    public string PrePesel { get; set; } = null!;

    public int PreEtarodzajZatrudnienia { get; set; }

    public DateTime PreDataOd { get; set; }

    public DateTime PreDataDo { get; set; }

    public DateTime? PreZatrudnionyOd { get; set; }

    public DateTime? PreZatrudnionyDo { get; set; }

    public string PreRachunekNr { get; set; } = null!;

    public short PreIban { get; set; }

    public byte PreZestCzasuPracy { get; set; }

    public byte PreWypNaKonto { get; set; }

    public string PreNrwAktach { get; set; } = null!;

    public byte PreFiltr { get; set; }

    public string PreNazwRodowe { get; set; } = null!;

    public string PreImie2 { get; set; } = null!;

    public string PreImieOjca { get; set; } = null!;

    public string PreImieMatki { get; set; } = null!;

    public string PreNazwRodoweM { get; set; } = null!;

    public DateTime? PreDataUr { get; set; }

    public string PreMiejsceUr { get; set; } = null!;

    public string PreObywatelstwo { get; set; } = null!;

    public string PrePlec { get; set; } = null!;

    public string PreStanCywilny { get; set; } = null!;

    public string PreMldkraj { get; set; } = null!;

    public string PreMldwojewodztwo { get; set; } = null!;

    public string PreMldpowiat { get; set; } = null!;

    public string PreMldgmina { get; set; } = null!;

    public string PreMldulica { get; set; } = null!;

    public string PreMldnrDomu { get; set; } = null!;

    public string PreMldnrLokalu { get; set; } = null!;

    public string PreMldmiasto { get; set; } = null!;

    public string PreMldkodPocztowy { get; set; } = null!;

    public string PreMldpoczta { get; set; } = null!;

    public string PreMldadres2 { get; set; } = null!;

    public int PreMldgminaKod { get; set; }

    public string PreHdktelefon1 { get; set; } = null!;

    public string PreHdktelefon2 { get; set; } = null!;

    public string PreNipKraj { get; set; } = null!;

    public string PreNipE { get; set; } = null!;

    public string PreDowOsobisty { get; set; } = null!;

    public string PreDowGdzie { get; set; } = null!;

    public DateTime? PreDowKiedy { get; set; }

    public DateTime? PreDowWaznyDo { get; set; }

    public string PreDowKto { get; set; } = null!;

    public string PrePaszport { get; set; } = null!;

    public string PreKorkraj { get; set; } = null!;

    public string PreKorwojewodztwo { get; set; } = null!;

    public string PreKorpowiat { get; set; } = null!;

    public string PreKorgmina { get; set; } = null!;

    public string PreKorulica { get; set; } = null!;

    public string PreKornrDomu { get; set; } = null!;

    public string PreKornrLokalu { get; set; } = null!;

    public string PreKormiasto { get; set; } = null!;

    public string PreKorkodPocztowy { get; set; } = null!;

    public string PreKorpoczta { get; set; } = null!;

    public string PreKoradres2 { get; set; } = null!;

    public string PreZamkraj { get; set; } = null!;

    public string PreZamwojewodztwo { get; set; } = null!;

    public string PreZampowiat { get; set; } = null!;

    public string PreZamgmina { get; set; } = null!;

    public string PreZamulica { get; set; } = null!;

    public string PreZamnrDomu { get; set; } = null!;

    public string PreZamnrLokalu { get; set; } = null!;

    public string PreZammiasto { get; set; } = null!;

    public string PreZamkodPocztowy { get; set; } = null!;

    public string PreZampoczta { get; set; } = null!;

    public string PreZamadres2 { get; set; } = null!;

    public string PreHdkfax { get; set; } = null!;

    public string PreHdkteleks { get; set; } = null!;

    public string PreHdkskrytkaPoczt { get; set; } = null!;

    public string PreHdkwypOsoba { get; set; } = null!;

    public string PreHdkwypAdres { get; set; } = null!;

    public string PreHdkwypTelefon { get; set; } = null!;

    public string PreAdresCentrum { get; set; } = null!;

    public decimal PrePodmnoznikKoszty { get; set; }

    public decimal PrePodmnoznikUlga { get; set; }

    public int PrePodkosztyTytul { get; set; }

    public decimal PrePodprocKosztyUzysk { get; set; }

    public int PrePodzaniechPodat { get; set; }

    public int? PrePodurzSkarbId { get; set; }

    public decimal? PreRefundacjaKwota { get; set; }

    public DateTime? PreRefundOd { get; set; }

    public DateTime? PreRefundDo { get; set; }

    public string PreHdkwojStosunek { get; set; } = null!;

    public string PreHdkwojStopien { get; set; } = null!;

    public string PreHdkwojSpecjal { get; set; } = null!;

    public string PreHdkwojWku { get; set; } = null!;

    public string PreHdkwojNrKsiaz { get; set; } = null!;

    public string PreHdkwojPrzydzial { get; set; } = null!;

    public int PreEtastosunekPracy { get; set; }

    public DateTime? PreEtadataZawarcia { get; set; }

    public string PreEtarodzajUmowy { get; set; } = null!;

    public int PreEtarozwiazUmowy { get; set; }

    public string PreEtamiejsce { get; set; } = null!;

    public short PreEtaetatL { get; set; }

    public short PreEtaetatM { get; set; }

    public byte PreEtaminimalna { get; set; }

    public DateTime? PreEtadataRozpocz { get; set; }

    public decimal PreEtastawka { get; set; }

    public byte PreEtastawkaGodz { get; set; }

    public byte PreEtastawkaL { get; set; }

    public byte PreEtastawkaM { get; set; }

    public byte PreEtawymiar { get; set; }

    public byte PreEtastandard { get; set; }

    public decimal PreEtagwarantProcMin { get; set; }

    public string PreKartaPobytu { get; set; } = null!;

    public int PreStNiepelnosp { get; set; }

    public DateTime? PreNiepelnospOd { get; set; }

    public DateTime? PreNiepelnospDo { get; set; }

    public int PreKodPokrew { get; set; }

    public byte PreWspolGosp { get; set; }

    public int PreKodNiezdol { get; set; }

    public DateTime? PreNiezdolOd { get; set; }

    public DateTime? PreNiezdolDo { get; set; }

    public int PreKodStGorniczego { get; set; }

    public DateTime? PreGorniczeOd { get; set; }

    public DateTime? PreGorniczeDo { get; set; }

    public int PreKodWyksztal { get; set; }

    public string PreWarSzczegolne { get; set; } = null!;

    public DateTime? PreWarSzczegolneOd { get; set; }

    public DateTime? PreWarSzczegolneDo { get; set; }

    public string PreKodKasyChorych { get; set; } = null!;

    public DateTime? PreKasaChData { get; set; }

    public DateTime? PreUbzzusOd { get; set; }

    public byte PreUbzjestEmerytal { get; set; }

    public byte PreUbzjestRentowe { get; set; }

    public byte PreUbzjestChorobowe { get; set; }

    public byte PreUbzjestWypad { get; set; }

    public DateTime? PreUbzzdrowOd { get; set; }

    public DateTime? PreUbzemerOd { get; set; }

    public DateTime? PreUbzrentOd { get; set; }

    public DateTime? PreUbzchorOd { get; set; }

    public DateTime? PreUbzzdrowDobrOd { get; set; }

    public decimal PreUbzzdrowKwotaPierwSkl { get; set; }

    public DateTime? PreUbzemerDo { get; set; }

    public DateTime? PreUbzrentDo { get; set; }

    public DateTime? PreUbzchorDo { get; set; }

    public DateTime? PreUbzwypadDo { get; set; }

    public DateTime? PreUbzzdrowDo { get; set; }

    public int? PreUbzemerKod { get; set; }

    public int? PreUbzrentKod { get; set; }

    public int? PreUbzchorKod { get; set; }

    public int? PreUbzwypadKod { get; set; }

    public int? PreUbzzdrowKod { get; set; }

    public byte PreUbzjestDobrEmerytal { get; set; }

    public byte PreUbzjestDobrRentowe { get; set; }

    public byte PreUbzjestDobrChorobowe { get; set; }

    public byte PreUbzjestDobrZdrow { get; set; }

    public int? PrePrzekroczRok { get; set; }

    public byte? PrePrzekroczMiesiac { get; set; }

    public decimal? PrePrzekroczKwota { get; set; }

    public byte? PrePrzekroczInformacja { get; set; }

    public byte? PrePrzekroczenie { get; set; }

    public int PrePrawoEr { get; set; }

    public string PreHdkuwagi { get; set; } = null!;

    public byte PreHdkprawoJazdy { get; set; }

    public string PreHdkprawoJazdyKat { get; set; } = null!;

    public string PreHdkemail { get; set; } = null!;

    public string PreHdkurl { get; set; } = null!;

    public int? PreMstIdMld { get; set; }

    public int? PreMstIdZam { get; set; }

    public int? PreMstIdKor { get; set; }

    public int? PreMstPocztaMld { get; set; }

    public int? PreMstPocztaZam { get; set; }

    public int? PreMstPocztaKor { get; set; }

    public int? PreMstMiejsceUr { get; set; }

    public DateTime? PreAbsdata { get; set; }

    public int PreAbschor35 { get; set; }

    public int PreAbschor90 { get; set; }

    public int PreAbschor6M { get; set; }

    public int PreAbsop60 { get; set; }

    public int PreAbsop14 { get; set; }

    public int PreAbsop30 { get; set; }

    public byte PreAbsurlMiesKorekta { get; set; }

    public int PreAbsurlMies { get; set; }

    public byte PreAbschorMiesKorekta { get; set; }

    public DateTime? PreAbsprawoZasChorOd { get; set; }

    public DateTime? PreAbsfinansowanePracodawcaOd { get; set; }

    public byte PreIndywDra { get; set; }

    public int? PreKatId { get; set; }

    public string PreKategoriaOpis { get; set; } = null!;

    public string PreKontoKsiegowe { get; set; } = null!;

    public DateTime? PreWaznoscBadanOkres { get; set; }

    public DateTime? PreLimitNadgodzin { get; set; }

    public byte PreIndywLimitNadgodzin { get; set; }

    public int PreKodWyksztPfron { get; set; }

    public DateTime? PreHdkwiekEmerData { get; set; }

    public string PreAdresDzialu { get; set; } = null!;

    public string PreOpis { get; set; } = null!;

    public DateTime PreEtanormaDobowa { get; set; }

    public byte PreHdkrodzajMiejsc { get; set; }

    public byte PreUbzograniczSklZdrow { get; set; }

    public int PreAbslimitLiczbaDni { get; set; }

    public byte PreAbsprocWynChorFlaga { get; set; }

    public decimal PreAbsprocWynChor { get; set; }

    public decimal PreEtapodstZdrowMnoznik { get; set; }

    public byte PreEtaindywProcWypad { get; set; }

    public decimal PreEtaindywProcWypadProcent { get; set; }

    public byte PreHdkgusglowneMiejscePracy { get; set; }

    public byte PreHdkguspierwszaPraca { get; set; }

    public byte PreHdkgusporaNocna { get; set; }

    public byte PreHdkguspracSezonowy { get; set; }

    public byte PreNieRozliczac { get; set; }

    public int? PreDabId { get; set; }

    public byte PreNieNaliczacFp { get; set; }

    public byte PreNieNaliczacFgsp { get; set; }

    public byte PrePelneDaneAdresowePfron { get; set; }

    public byte PrePomocPublicznaPfron { get; set; }

    public byte PreWzrostZatrudnieniaPfron { get; set; }

    public byte PreZatrudRozwUmowyPfron { get; set; }

    public byte PreAbsfinansowanePracodawca { get; set; }

    public int PreAbsfinansowanePracodawcaDni { get; set; }

    public int PreKodFep { get; set; }

    public DateTime? PreFepod { get; set; }

    public DateTime? PreFepdo { get; set; }

    public DateTime? PreFpod { get; set; }

    public DateTime? PreFpdo { get; set; }

    public DateTime? PreFgspod { get; set; }

    public DateTime? PreFgspdo { get; set; }

    public byte PreOddelegowany { get; set; }

    public decimal PreOddelegowanyDieta { get; set; }

    public string PreOddelegowanyWaluta { get; set; } = null!;

    public byte PreOddelegowanyZus { get; set; }

    public byte PreOddelegowanyFis { get; set; }

    public DateTime? PreWychPodstEmerRentOd { get; set; }

    public decimal PreWychPodstEmerRentMax { get; set; }

    public byte PreRodzajDokumentu { get; set; }

    public byte PrePodnieLiczKoszty50 { get; set; }

    public int? PreEtadkmIdStanowisko { get; set; }

    public int? PreEtadkmIdFunkcja { get; set; }

    public int? PreDkmIdKodZawodu { get; set; }

    public string? PreKodZawoduSymbol { get; set; }

    public int? PreEtadkmIdWypowPowod { get; set; }

    public int? PreDkmIdPracodawca { get; set; }

    public byte PreTymczasowy { get; set; }

    public int? PreZastepowanyId { get; set; }

    public string PreZastepowany { get; set; } = null!;

    public byte PreZastepowanyLista { get; set; }

    public byte PreAbspierwszyLimit { get; set; }

    public string PrePrzelozony { get; set; } = null!;

    public byte PreZamZamiastMld { get; set; }

    public string PreTelefonSms { get; set; } = null!;

    public int PreFlotaPrawa { get; set; }

    public int? PreFlotaOperator { get; set; }

    public string PreMldkodKraju { get; set; } = null!;

    public string PreZamkodKraju { get; set; } = null!;

    public string PreKorkodKraju { get; set; } = null!;

    public byte PrePodnierezydent { get; set; }

    public int PrePodnipZagranicznyRodzaj { get; set; }

    public string PrePodnipZagraniczny { get; set; } = null!;

    public string PreKontoKsiegowe2 { get; set; } = null!;

    public byte PrePrmpracaRodzic { get; set; }

    public decimal PrePrmstawka { get; set; }

    public byte PrePrmwymiar { get; set; }

    public byte PrePrmminimalna { get; set; }

    public int? PrePrmkalId { get; set; }

    public short PrePrmetatL { get; set; }

    public short PrePrmetatM { get; set; }

    public byte PreNieGenPodwZasMacierz { get; set; }

    public string PreOddelegowanyKraj { get; set; } = null!;

    public string PreOddelegowanyWalutaDieta { get; set; } = null!;

    public int? PreZakId { get; set; }

    public int PreHdkgussymbolWykszt { get; set; }

    public int PreHdkgussymbolSystemuCzP { get; set; }

    public decimal PrePrzychPoprzRok { get; set; }

    public string PreKodWygasniecia { get; set; } = null!;

    public string PreKodPodstPrawRozw { get; set; } = null!;

    public string PrePodstPrawRozw { get; set; } = null!;

    public int PreStronaInicjujaca { get; set; }

    public byte PreNauczyciel { get; set; }

    public DateTime? PreObowPrzechDokDo { get; set; }

    public string PreObywatelKodKraju { get; set; } = null!;

    public DateTime? PrePpkokresOd { get; set; }

    public DateTime? PrePpkokresDo { get; set; }

    public decimal PrePpksklPodstPrac { get; set; }

    public decimal PrePpksklDodatPrac { get; set; }

    public byte PrePpkobnizenieSkladki { get; set; }

    public DateTime? PrePpkdataObnizenia { get; set; }

    public decimal PrePpksklDodatFirma { get; set; }

    public DateTime? PrePpkdataSkladkiDodatkowej { get; set; }

    public byte PrePpkindywSklDodatFirma { get; set; }

    public byte PrePpkprzekazDaneKontaktowe { get; set; }

    public byte PrePodzwolPit26 { get; set; }

    public int? PreBnaIdMikro { get; set; }

    public string PreRachunekNrMikro { get; set; } = null!;

    public short PreIbanmikro { get; set; }

    public decimal PrePodkartaPodPrzychod { get; set; }

    public decimal PrePodkartaPodDochod { get; set; }

    public decimal PrePodryczaltPrzychod { get; set; }

    public decimal PrePodryczaltDochod { get; set; }

    public decimal PrePodzasOgolnePrzychod { get; set; }

    public decimal PrePodzasOgolneDochod { get; set; }

    public int? PreMalzonekId { get; set; }

    public byte PreSynchronizacjaTna { get; set; }

    public byte PreLogowanieTna { get; set; }

    public byte PreOddelegowanyPropOdl { get; set; }

    public short PrePodzwolPit { get; set; }

    public byte PrePodniePobierZalFis { get; set; }

    public int PrePodzwolPitrok { get; set; }

    public byte PrePodniePomnDochUlga { get; set; }

    public short PreUbzformaOpodat { get; set; }

    public byte PreUbzoplacZdrowPrzychUbRok { get; set; }

    public byte PreUbzprzychWlascDekl { get; set; }

    public decimal PreUbzdochodUbMies { get; set; }

    public decimal PreUbzprzychodBiezRok { get; set; }

    public decimal PreUbzprzychodUbRok { get; set; }

    public byte PrePodnieStosPrzedlZalFis { get; set; }

    public byte PreUbzwlascFormaOpodatSkala { get; set; }

    public short PreUbzwlascFormaOpodatSkalaDane { get; set; }

    public int? PreUbzwlascFormaOpodatSkalaBazId { get; set; }

    public byte PreUbzwlascFormaOpodatLiniowy { get; set; }

    public short PreUbzwlascFormaOpodatLiniowyDane { get; set; }

    public int? PreUbzwlascFormaOpodatLiniowyBazId { get; set; }

    public byte PreUbzwlascFormaOpodatLiniowySklZdrow { get; set; }

    public byte PreUbzwlascFormaOpodatRyczalt { get; set; }

    public short PreUbzwlascFormaOpodatRyczaltDane { get; set; }

    public int? PreUbzwlascFormaOpodatRyczaltBazId { get; set; }

    public byte PreUbzwlascFormaOpodatRyczaltUbRok { get; set; }

    public byte PreUbzwlascFormaOpodatKarta { get; set; }

    public int PreUbzwlascFormaOpodatKartaIlosc { get; set; }

    public byte PreUbzwlascFormaOpodatBrak { get; set; }

    public int PreUbzwlascFormaOpodatBrakIlosc { get; set; }

    public byte PreUbzwlascFormaOpodatSkalaSklZdrow { get; set; }

    public byte PreUbzwlascFormaOpodatRyczaltSklZdrow { get; set; }

    public short PrePodulgaMnoznikL { get; set; }

    public short PrePodulgaMnoznikM { get; set; }

    public string? PreImportRowId { get; set; }

    public int? PreOpeZalId { get; set; }

    public int? PreStaZalId { get; set; }

    public DateTime PreTsZal { get; set; }

    public int? PreOpeModId { get; set; }

    public int? PreStaModId { get; set; }

    public DateTime PreTsMod { get; set; }

    public string PreOpeModKod { get; set; } = null!;

    public string PreOpeModNazwisko { get; set; } = null!;

    public string PreOpeZalKod { get; set; } = null!;

    public string PreOpeZalNazwisko { get; set; } = null!;

    public short PrePodprogiPodatkowe { get; set; }

    public byte PrePodulgaDodatkowa { get; set; }

    public virtual BnkNazwy? PreBna { get; set; }

    public virtual BnkNazwy? PreBnaIdMikroNavigation { get; set; }

    public virtual Centra? PreCnt { get; set; }

    public virtual DaneKadMod? PreDkmIdKodZawoduNavigation { get; set; }

    public virtual DaneKadMod? PreDkmIdPracodawcaNavigation { get; set; }

    public virtual Dzialy? PreDzl { get; set; }

    public virtual DaneKadMod? PreEtadkmIdFunkcjaNavigation { get; set; }

    public virtual DaneKadMod? PreEtadkmIdStanowiskoNavigation { get; set; }

    public virtual DaneKadMod? PreEtadkmIdWypowPowodNavigation { get; set; }

    public virtual FormyPlatnosci? PreFpl { get; set; }

    public virtual Kalendarze? PreKal { get; set; }

    public virtual Kategorie? PreKat { get; set; }

    public virtual PracKod PrePra { get; set; } = null!;

    public virtual Kalendarze? PrePrmkal { get; set; }

    public virtual TytUbezp PreUbztyu { get; set; } = null!;

    public virtual PracKod? PreWlasciciel { get; set; }

    public virtual Zaklady? PreZak { get; set; }

    public virtual PracKod? PreZastepowanyNavigation { get; set; }

    public virtual ZestawyRegul? PreZrg { get; set; }

    public virtual ICollection<Progi> Progis { get; set; } = new List<Progi>();
}
