using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class OpeKarty
{
    public short? OpeGidtyp { get; set; }

    public int? OpeGidfirma { get; set; }

    public int OpeGidnumer { get; set; }

    public short? OpeGidlp { get; set; }

    public short? OpeStaTyp { get; set; }

    public int? OpeStaFirma { get; set; }

    public int? OpeStaNumer { get; set; }

    public short? OpeStaLp { get; set; }

    public int? OpeFrSid { get; set; }

    public string? OpeIdent { get; set; }

    public string? OpeNazwisko { get; set; }

    public string? OpeHaslo { get; set; }

    public string? OpeHasloChk { get; set; }

    public string? OpeIdentBaza { get; set; }

    public string? OpeHasloBaza { get; set; }

    public byte? OpeAdministrator { get; set; }

    public short? OpeZablokowane { get; set; }

    public byte? OpeKierownik { get; set; }

    public string? OpeNtsid { get; set; }

    public string? OpeNtkonto { get; set; }

    public byte? OpeNtlogin { get; set; }

    public short? OpeKaRtyp { get; set; }

    public int? OpeKaRfirma { get; set; }

    public int? OpeKaRnumer { get; set; }

    public short? OpeKaRlp { get; set; }

    public byte? OpeBuforKasowy { get; set; }

    public byte? OpeWsk { get; set; }

    public short? OpePrcTyp { get; set; }

    public int? OpePrcFirma { get; set; }

    public int? OpePrcNumer { get; set; }

    public short? OpePrcLp { get; set; }

    public int? OpeModuly { get; set; }

    public int? OpeModuly2 { get; set; }

    public byte? OpeDyrektor { get; set; }

    public byte? OpeWidziCenyZakupu { get; set; }

    public byte? OpeWidziKosztyZlecenia { get; set; }

    public decimal? OpeLimitKredytu { get; set; }

    public decimal? OpeLimitPoTerminie { get; set; }

    public byte? OpeGotowkaPotw { get; set; }

    public int? OpeZamPotw { get; set; }

    public byte? OpeLokatorTyp { get; set; }

    public decimal? OpeLokatorCzas { get; set; }

    public byte? OpeOknaTryb { get; set; }

    public byte? OpePodsumowania { get; set; }

    public byte? OpePlusyNaDrzewach { get; set; }

    public byte? OpeMultiLogowanie { get; set; }

    public byte? OpeFiltryObowiazkowe { get; set; }

    public byte? OpeSerwerWydr { get; set; }

    public string? OpeSerwerDrukarka { get; set; }

    public byte? OpeEdycjaBudzetu { get; set; }

    public byte? OpeDefiniowanieBudzetu { get; set; }

    public int? OpeOkresObrachunkowy { get; set; }

    public byte? OpePracaTerminalowa { get; set; }

    public byte? OpeLogCoWyswietlac { get; set; }

    public byte? OpeLogZamknij { get; set; }

    public int? OpePlatnosci { get; set; }

    public byte? OpeAtrybutyZmianaKlawiatury { get; set; }

    public byte? OpePriorytetRez { get; set; }

    public string? OpeNrKasjera { get; set; }

    public byte? OpeZamykanieOkresu { get; set; }

    public byte? OpeStrukturaMagazynu { get; set; }

    public byte? OpeLimitBezOgraniczenia { get; set; }

    public byte? OpePodgladDokumentow { get; set; }

    public byte? OpeRozliczenieKampanii { get; set; }

    public int? OpeCzasModyfikacji { get; set; }

    public int? OpeOpeMnumer { get; set; }

    public byte? OpeDostepDoParamRejestrow { get; set; }

    public byte? OpeAktualizacjaCen { get; set; }

    public byte? OpeRozdzielZasoby { get; set; }

    public byte? OpeRaportyAbcxyz { get; set; }

    public byte? OpeAktualizacjaAdresowKontrahenta { get; set; }

    public byte? OpeZaawansowaneParamKsiegowe { get; set; }

    public byte? OpeOdtwierdzanieOpisuAnalit { get; set; }

    public byte? OpeRoznicowyVatnaFaKoncowe { get; set; }

    public byte? OpeAtrybutyWizytyOddzialowe { get; set; }

    public byte? OpeZmianaPrzyczynyKorNaZatwDok { get; set; }

    public byte? OpeOtwieraniePotwierdzonychUmow { get; set; }

    public byte? OpePotwierdzeniePrzejazdu { get; set; }

    public byte? OpeStrukturaKosztowDodZak { get; set; }

    public byte? OpeOpisAnalitycznyDokWbuforze { get; set; }

    public string? OpeSsologin { get; set; }

    public string? OpeSsotoken { get; set; }

    public byte? OpeKorektyIlosciowoWartosciowe { get; set; }

    public byte? OpeAkceptacjaWydatkow { get; set; }

    public byte? OpeZatwierdzanieDelegacji { get; set; }

    public byte? OpeCofniecieZatwierdzeniaAkceptacji { get; set; }

    public int? OpePrezentujWszystkoPl { get; set; }

    public int? OpeAktualizacjaWszystkoPl { get; set; }

    public int? OpePrezentujInformacje { get; set; }

    public int? OpeAktualizacjaInformacji { get; set; }

    public decimal? OpeRabatOperatora { get; set; }

    public byte? OpeZamykanieDokumentowAwdZwm { get; set; }

    public byte? OpeCenaPotwZs { get; set; }

    public byte? OpeCenaPotwZz { get; set; }

    public byte? OpeZmFormPlatNaDom { get; set; }

    public byte? OpeModPolecenWyjazdu { get; set; }

    public byte? OpeWgladListaWno { get; set; }

    public byte? OpePulpitOperatora { get; set; }

    public byte? OpeOtwieranieOkresuRetro { get; set; }

    public byte? OpeObslugaPropozycjiKompensat { get; set; }

    public int? OpePomiarCzasow { get; set; }

    public byte? OpeLimitBezOgraniczeniaZam { get; set; }

    public decimal? OpeLimitKredytuZam { get; set; }

    public byte? OpeGenerowanieJpk { get; set; }

    public byte? OpeAktywnoscEiP { get; set; }

    public byte? OpeZarzadzaniePulpitami { get; set; }

    public byte? OpeRealizacjaUmpoPrzekroczeniuIlosciNaPoz { get; set; }

    public byte? OpeZarzadzanieWyglademList { get; set; }

    public int? OpeMesdostepnosc { get; set; }

    public byte? OpeOdliczanieFaZalNaPotw { get; set; }

    public byte? OpeEdycjaCenySpiElem { get; set; }

    public byte? OpeEdycjaStawkiVatnaSpi { get; set; }

    public byte? OpeRabatOperatoraBezOgraniczen { get; set; }

    public byte? OpeEdycjaWartosciBudzetu { get; set; }

    public byte? OpePropozycjaPaczkiPrzelewow { get; set; }

    public byte? OpeAkceptacjaPaczkiPrzelewow { get; set; }

    public byte? OpeZatwierdzanieDokPodWzgledem { get; set; }

    public byte? OpeDokNiepotwBst { get; set; }

    public byte? OpeDostepDoWzorcowAnalit { get; set; }

    public byte? OpeDostepDoWzorcowAnalitPodrz { get; set; }

    public string? OpeUserOutlook { get; set; }

    public string? OpeUserGoogle { get; set; }

    public byte? OpeWylaczSynchr { get; set; }

    public byte? OpeMenuTryb { get; set; }

    public byte? OpeMenuIlosc { get; set; }

    public int? OpeDataWprowadzeniaHasla { get; set; }

    public byte? OpeUzywajKomunikatora { get; set; }

    public byte? OpeLogZapisujKomunikaty { get; set; }

    public byte? OpePytanieOpodzialPlat { get; set; }

    public byte? OpeAdministratorDo { get; set; }

    public byte? OpeAnonimizujBezBlokad { get; set; }

    public byte? OpeBezZmianyHasla { get; set; }

    public int? OpeDokPotw { get; set; }

    public byte? OpeMesobslugaCech { get; set; }

    public int? OpeJezyk { get; set; }

    public byte? OpeAnonimizacja { get; set; }

    public byte? OpePlatnosciWzPz { get; set; }

    public byte? OpeMesgenerowanieDok { get; set; }

    public byte? OpePrzerywanieSesji { get; set; }

    public byte? OpeMetodaKasowa { get; set; }

    public byte? OpeParametrWgRozliczenia { get; set; }

    public string? OpeBipointLogin { get; set; }

    public byte? OpeKorektaDanych { get; set; }

    public byte? OpeEdycjaDatySpr { get; set; }

    public byte? OpeMeswidokZalacznikow { get; set; }

    public byte? OpeModDatyKsiegowania { get; set; }

    public byte? OpeDoczytujRekordy { get; set; }

    public byte? OpeMesedycjaTerminowRealizacji { get; set; }

    public byte? OpeTlumaczenie { get; set; }

    public byte? OpeEsprawozdaniaFinansowe { get; set; }

    public byte? OpeEdycjaNrObcego { get; set; }

    public byte? OpeMeszadaniaWgniazdachRoboczych { get; set; }

    public byte? OpeZezwalajNaOtwieranieZakonUmow { get; set; }

    public int? OpeEdycjaPcn { get; set; }

    public byte? OpeMesadministrator { get; set; }

    public byte? OpeOperacjeNaPotwierdzonychZsr { get; set; }

    public byte? OpeMeskontrolaJakosci { get; set; }

    public byte? OpeMesdodawanieIusuwanieParam { get; set; }

    public byte? OpeBlokowanieDostaw { get; set; }

    public byte? OpeEdycjaPotwPkj { get; set; }

    public byte? OpeLoginShipping { get; set; }

    public byte? OpeRozpoznawanieTwarzy { get; set; }

    public byte? OpeEdycjaOplatySpoz { get; set; }

    public byte? OpeMesobslugaOpcje { get; set; }

    public byte? OpeEdycjaZatwierdzonychNot { get; set; }

    public byte? OpeMesnrKartyWg { get; set; }

    public int? OpeMesnrKartyAtkId { get; set; }

    public byte? OpeTransakcjaUjemnyStan { get; set; }

    public byte? OpeTransakcjaWyplataSrodkow { get; set; }

    public byte? OpeApfinoWindykacja { get; set; }

    public byte? OpeKseFwysylanie { get; set; }

    public byte? OpeKseFedycjaNumeru { get; set; }

    public byte? OpeKseFtoken { get; set; }

    public byte? OpeZwijanieListyDokZwTryb { get; set; }

    public byte? OpeZwijanieListyDokZwPoziom { get; set; }

    public byte? OpeKseFpobieranieFaktur { get; set; }

    public byte? OpeInfoKoniecAkcjiAi { get; set; }

    public byte? OpeChatErp { get; set; }

    public int? OpeNieudaneLogowania { get; set; }

    public int? OpeNieudaneLogowanieCzas { get; set; }

    public string? OpeNieudaneLogowanieZrodlo { get; set; }

    public virtual ICollection<BstNag> BstNags { get; set; } = new List<BstNag>();

    public virtual ICollection<Cdcloginy> Cdcloginies { get; set; } = new List<Cdcloginy>();

    public virtual ICollection<IstotneOpcje> IstotneOpcjes { get; set; } = new List<IstotneOpcje>();

    public virtual ICollection<KntKontakty> KntKontakties { get; set; } = new List<KntKontakty>();

    public virtual ICollection<NtsNag> NtsNags { get; set; } = new List<NtsNag>();

    public virtual ICollection<OpeCentra> OpeCentras { get; set; } = new List<OpeCentra>();

    public virtual ICollection<OpeOpisy> OpeOpisies { get; set; } = new List<OpeOpisy>();

    public virtual ICollection<OpeSkillGrupa> OpeSkillGrupas { get; set; } = new List<OpeSkillGrupa>();

    public virtual ICollection<OpeZakazy> OpeZakazies { get; set; } = new List<OpeZakazy>();

    public virtual ICollection<ProdRekomendacjeWzorce> ProdRekomendacjeWzorces { get; set; } = new List<ProdRekomendacjeWzorce>();

    public virtual ICollection<ProdRekomendacje> ProdRekomendacjes { get; set; } = new List<ProdRekomendacje>();

    public virtual ICollection<ProdWzorceKosztow> ProdWzorceKosztows { get; set; } = new List<ProdWzorceKosztow>();

    public virtual ICollection<PrzelewyAutoryzacje> PrzelewyAutoryzacjes { get; set; } = new List<PrzelewyAutoryzacje>();

    public virtual ICollection<PrzelewyElem> PrzelewyElems { get; set; } = new List<PrzelewyElem>();

    public virtual ICollection<UstawieniaList> UstawieniaLists { get; set; } = new List<UstawieniaList>();

    public virtual ICollection<ZlecWewElem> ZlecWewElems { get; set; } = new List<ZlecWewElem>();
}
