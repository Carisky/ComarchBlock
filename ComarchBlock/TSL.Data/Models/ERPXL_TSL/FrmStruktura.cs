using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class FrmStruktura
{
    public int FrsId { get; set; }

    public short FrsGidtyp { get; set; }

    public int FrsGidfirma { get; set; }

    public int FrsGidnumer { get; set; }

    public short FrsGidlp { get; set; }

    public short FrsGrotyp { get; set; }

    public int FrsGrofirma { get; set; }

    public int FrsGronumer { get; set; }

    public short FrsGrolp { get; set; }

    public short? FrsStrTyp { get; set; }

    public byte? FrsWarstwa { get; set; }

    public int? FrsFrSprawa { get; set; }

    public int FrsArchiwalny { get; set; }

    public int FrsAktywnyOd { get; set; }

    public int FrsAktywnyDo { get; set; }

    public byte? FrsOddzial { get; set; }

    public string? FrsNazwa { get; set; }

    public string? FrsOpis { get; set; }

    public string? FrsKonto { get; set; }

    public string? FrsUrl { get; set; }

    public int? FrsPokazywacSeriePico { get; set; }

    public byte? FrsRejestryZrodzica { get; set; }

    public byte? FrsSerieZrodzica { get; set; }

    public byte? FrsMagazynyZrodzica { get; set; }

    public byte? FrsDokumentyZrodzica { get; set; }

    public byte? FrsPlatnosciZrodzica { get; set; }

    public short? FrsSctyp { get; set; }

    public int? FrsScfirma { get; set; }

    public int? FrsScnumer { get; set; }

    public short? FrsSclp { get; set; }

    public short? FrsSertyp { get; set; }

    public int? FrsSerfirma { get; set; }

    public int? FrsSernumer { get; set; }

    public short? FrsSerlp { get; set; }

    public short? FrsMagTyp { get; set; }

    public int? FrsMagFirma { get; set; }

    public int? FrsMagNumer { get; set; }

    public short? FrsMagLp { get; set; }

    public short? FrsPrcTyp { get; set; }

    public int? FrsPrcFirma { get; set; }

    public int? FrsPrcNumer { get; set; }

    public short? FrsPrcLp { get; set; }

    public short? FrsZakLp { get; set; }

    public short? FrsSprLp { get; set; }

    public short? FrsFormPlatNumer { get; set; }

    public byte? FrsLskorzystaj { get; set; }

    public byte? FrsLsautoZaplata { get; set; }

    public byte? FrsLsautoSpinacz { get; set; }

    public byte? FrsLsautoDruk { get; set; }

    public byte? FrsLsautoZamowienie { get; set; }

    public byte? FrsLszachowajKontrahenta { get; set; }

    public string? FrsRaportyOlap { get; set; }

    public int? FrsOptimaId { get; set; }

    public short? FrsFrmTyp { get; set; }

    public int? FrsFrmFirma { get; set; }

    public int? FrsFrmNumer { get; set; }

    public short? FrsFrmLp { get; set; }

    public short? FrsDetKnGtyp { get; set; }

    public int? FrsDetKnGnumer { get; set; }

    public byte? FrsDetPotwierdzenieIlosci { get; set; }

    public byte? FrsDetDrukujParagon { get; set; }

    public short? FrsDetDokumentyZdni { get; set; }

    public byte? FrsDetGenerujFs { get; set; }

    public byte? FrsDetPlatnosci { get; set; }

    public byte? FrsDetProponujDok { get; set; }

    public byte? FrsDetKntDocelowy { get; set; }

    public byte? FrsDetKolektor { get; set; }

    public byte? FrsDetPokazujZerowe { get; set; }

    public int? FrsMagZwrNumer { get; set; }

    public byte? FrsDodatkiZrodzica { get; set; }

    public int? FrsLokalizacja { get; set; }

    public int? FrsKaRnumer { get; set; }

    public int? FrsCenaDomyslna { get; set; }

    public byte? FrsCenyZrodzica { get; set; }

    public byte? FrsRejestryVatZrodzica { get; set; }

    public byte? FrsDetRodzajAkwizytora { get; set; }

    public byte? FrsDetGenerujRs { get; set; }

    public short? FrsProdCzasWyswietlania { get; set; }

    public byte? FrsProdRozpocznijPoWczytaniu { get; set; }

    public byte? FrsProdTylkoWykonanie { get; set; }

    public byte? FrsProdZakonczenieWgPlanu { get; set; }

    public byte? FrsProdWykonanieBezEdycji { get; set; }

    public byte? FrsProdAutoryzacja { get; set; }

    public byte? FrsProdZaokraglanieMat { get; set; }

    public byte? FrsProdZaokraglanieProdukt { get; set; }

    public byte? FrsDetObslugaZestawow { get; set; }

    public string? FrsSymbol { get; set; }

    public int? FrsCzasModyfikacji { get; set; }

    public byte? FrsProdRealizacjaEtapu { get; set; }

    public int? FrsProdListaKonfliktow { get; set; }

    public byte? FrsProdukcjaZrodzica { get; set; }

    public byte? FrsProdPokazPierwszeNiezrealizowane { get; set; }

    public byte? FrsProdPokazZadaniaOperatora { get; set; }

    public byte? FrsOperacjeTylkoZeZwolnionych { get; set; }

    public byte? FrsDataPlanJakoPriorytet { get; set; }

    public byte? FrsPrezentujMagOddzial { get; set; }

    public byte? FrsPrezentujMagZablok { get; set; }

    public byte? FrsPizrodzica { get; set; }

    public byte? FrsMeszrodzica { get; set; }

    public byte? FrsMessposobUruchamiania { get; set; }

    public byte? FrsMesuruchamianieRealizacji { get; set; }

    public byte? FrsMesuruchomZakonczPoWczytaniu { get; set; }

    public byte? FrsMesterminZakonczeniaWgPlanu { get; set; }

    public byte? FrsMeszakonczenieRealizacji { get; set; }

    public byte? FrsMeswylogujPoUruchomieniu { get; set; }

    public byte? FrsMeswylogujPo { get; set; }

    public int? FrsMeswylogujPoCzas { get; set; }

    public byte? FrsMeswylogujPoJedn { get; set; }

    public byte? FrsMestylkoZeZwolnionych { get; set; }

    public byte? FrsMesprzeliczMaterialyPoZmianieOperacji { get; set; }

    public byte? FrsMesgenerujDokumentyPotwierdzone { get; set; }

    public byte? FrsMesgenerujDokumentyWtle { get; set; }

    public byte? FrsMeszamykajDokumentyPrzyZatwierdzaniu { get; set; }

    public byte? FrsMesautoPrzypisanieOperatora { get; set; }

    public byte? FrsMesblokujZeroweRealizacje { get; set; }

    public byte? FrsMesuruchamianieRealizacjiWieleOp { get; set; }

    public byte? FrsMessposobUruchamianiaWieleOp { get; set; }

    public byte? FrsMeszakonczenieRealizacjiWieleOp { get; set; }

    public byte? FrsMespokazTylkoPierwszaOp { get; set; }

    public byte? FrsMesliczacOd { get; set; }

    public int? FrsMesliczacOdCzas { get; set; }

    public byte? FrsMesliczacOdCzasJedn { get; set; }

    public byte? FrsBlokujDlaPozycjiZpw { get; set; }

    public byte? FrsWykonujDlaPwwbuforze { get; set; }

    public byte? FrsProdGenerujRwnaglowkowe { get; set; }

    public byte? FrsProdAutoWiazanieRw { get; set; }

    public byte? FrsProdRedukcjaNiezwiazanychIlosci { get; set; }

    public byte? FrsRodzajeBonowZrodzica { get; set; }

    public byte? FrsMesopcjeRw { get; set; }

    public byte? FrsProdAutoNadawanieStanow { get; set; }

    public byte? FrsProdGenerowanieZsrdlaPrzestoju { get; set; }

    public short? FrsProdZsrkntTyp { get; set; }

    public int? FrsProdZsrkntFirma { get; set; }

    public int? FrsProdZsrkntNumer { get; set; }

    public short? FrsProdZsrkntLp { get; set; }

    public byte? FrsMesblokujJesliNiezakonczone { get; set; }

    public byte? FrsMestylkoWlasne { get; set; }

    public byte? FrsProdBlokadaZmniejszaniaIlosci { get; set; }

    public byte? FrsProdPauza { get; set; }

    public byte? FrsMeskonfiguracjaList { get; set; }

    public virtual ICollection<DokDefinicje> DokDefinicjes { get; set; } = new List<DokDefinicje>();

    public virtual ICollection<FrmObiekty> FrmObiekties { get; set; } = new List<FrmObiekty>();

    public virtual ICollection<FrmStrukturaTel> FrmStrukturaTels { get; set; } = new List<FrmStrukturaTel>();

    public virtual ICollection<FrsPromocje> FrsPromocjes { get; set; } = new List<FrsPromocje>();

    public virtual ICollection<FrsZamienniki> FrsZamiennikis { get; set; } = new List<FrsZamienniki>();

    public virtual ICollection<KntLimity> KntLimities { get; set; } = new List<KntLimity>();

    public virtual ICollection<OpeCentra> OpeCentras { get; set; } = new List<OpeCentra>();

    public virtual ICollection<ProdRekomendacje> ProdRekomendacjes { get; set; } = new List<ProdRekomendacje>();

    public virtual ICollection<ProdZmianyGanttum> ProdZmianyGantta { get; set; } = new List<ProdZmianyGanttum>();

    public virtual ICollection<RejestryDomyslne> RejestryDomyslnes { get; set; } = new List<RejestryDomyslne>();

    public virtual ICollection<Sent> Sents { get; set; } = new List<Sent>();

    public virtual ICollection<ClbkKarty> ClbfClbks { get; set; } = new List<ClbkKarty>();

    public virtual ICollection<RetroKarty> RtFRtKs { get; set; } = new List<RetroKarty>();
}
