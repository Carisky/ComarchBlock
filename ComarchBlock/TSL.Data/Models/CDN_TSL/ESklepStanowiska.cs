using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class ESklepStanowiska
{
    public int EssEssid { get; set; }

    public string EssNazwa { get; set; } = null!;

    public byte EssTyp { get; set; }

    public string EssAsserwer { get; set; } = null!;

    public string EssHash { get; set; } = null!;

    public string EssIdKlienta { get; set; } = null!;

    public int EssIdIsklep { get; set; }

    public string EssDomyslnaWaluta { get; set; } = null!;

    public int EssDomyslnyMagazyn { get; set; }

    public byte EssExpZasoby { get; set; }

    public byte EssWyslijStanWszystkieMag { get; set; }

    public byte EssStanyNaDzien { get; set; }

    public byte EssWyslijCechyPartii { get; set; }

    public int EssTwGnumer { get; set; }

    public int EssSchematNumeracjiRo { get; set; }

    public string EssSchematNumeracjiRoseria { get; set; } = null!;

    public byte EssExpGrup { get; set; }

    public byte EssExpGrupTyp { get; set; }

    public int EssNrCeny { get; set; }

    public int EssNrCenyDomyslnej { get; set; }

    public byte EssEsklepCena0 { get; set; }

    public byte EssExpCennik { get; set; }

    public byte EssExpCennikTyp { get; set; }

    public int EssKosztPrzesylki { get; set; }

    public int EssFormaPlatnosciEspos1 { get; set; }

    public int EssFormaPlatnosciEspos2 { get; set; }

    public int EssFormaPlatnosciEspos3 { get; set; }

    public int EssFormaPlatnosciEspos4 { get; set; }

    public int EssFormaPlatnosciEspos5 { get; set; }

    public byte EssKntSprawdzNip { get; set; }

    public byte EssKntSprawdzEmail { get; set; }

    public string EssKntGrupa { get; set; } = null!;

    public string EssDaneFirmyNazwa { get; set; } = null!;

    public string EssDaneFirmyOpis { get; set; } = null!;

    public string EssDaneFirmyUlica { get; set; } = null!;

    public string EssDaneFirmyNrDomu { get; set; } = null!;

    public string EssDaneFirmyNrMieszkania { get; set; } = null!;

    public string EssDaneFirmyMiasto { get; set; } = null!;

    public string EssDaneFirmyKodPocztowy { get; set; } = null!;

    public string EssDaneFirmyWojewodztwo { get; set; } = null!;

    public string EssDaneFirmyTelefon { get; set; } = null!;

    public string EssDaneFirmyEmail { get; set; } = null!;

    public string EssDaneFirmyUrl { get; set; } = null!;

    public string EssDaneFirmyGg { get; set; } = null!;

    public string EssDaneFirmySkype { get; set; } = null!;

    public int EssDaneFirmyLogo { get; set; }

    public string EssDaneFirmyRok { get; set; } = null!;

    public string EssDaneFirmyGsm { get; set; } = null!;

    public string EssDaneFirmyFacebook { get; set; } = null!;

    public byte EssFakturaPdf { get; set; }

    public int EssTsSynchro { get; set; }

    public int EssTsSynchroPotw { get; set; }

    public int EssTsSynchroTwr { get; set; }

    public int EssTsSynchroTwrPotw { get; set; }

    public int EssTsSynchroKnt { get; set; }

    public int EssTsSynchroKntPotw { get; set; }

    public int EssTsSynchroGrup { get; set; }

    public int EssTsSynchroGrupPotw { get; set; }

    public int EssTsSynchroSlowniki { get; set; }

    public int EssTsSynchroZestawyTwr { get; set; }

    public int EssTsSynchroZestawyTwrPotw { get; set; }

    public int EssTsSynchroKntOptima { get; set; }

    public int EssTsSynchroKntOptimaPotw { get; set; }

    public int EssTsSynchroBin { get; set; }

    public int EssTsSynchroBinPotw { get; set; }

    public byte EssStanSynchronizacji { get; set; }

    public byte EssTypSklepu { get; set; }

    public byte EssNieaktywny { get; set; }

    public int EssOstatnieDabId { get; set; }

    public byte EssKontrolaLimituPlat { get; set; }

    public byte EssPierwszaSynchroLoginy { get; set; }

    public byte EssPierwszaSynchroZgody { get; set; }

    public byte EssPierwszaSynchroDefAtr { get; set; }

    public byte EssPomijajKosztyDostawyZeroweParagon { get; set; }

    public byte EssPomijajKosztyDostawyZeroweFaktura { get; set; }

    public int EssOstatnieTwrId { get; set; }

    public decimal EssWersjaProt { get; set; }

    public int EssOstatnieRabatyPusto { get; set; }

    public string? EssGuidZamowienia { get; set; }

    public byte EssStatusZamowienia { get; set; }

    public virtual ICollection<ESklepFormyPlatnosci> ESklepFormyPlatnoscis { get; set; } = new List<ESklepFormyPlatnosci>();

    public virtual ICollection<ESklepMagazyny> ESklepMagazynies { get; set; } = new List<ESklepMagazyny>();

    public virtual ICollection<ESklepWaluty> ESklepWaluties { get; set; } = new List<ESklepWaluty>();

    public virtual ICollection<KntEsklepy> KntEsklepies { get; set; } = new List<KntEsklepy>();

    public virtual ICollection<KntEsklepyPrzedstawiciele> KntEsklepyPrzedstawicieles { get; set; } = new List<KntEsklepyPrzedstawiciele>();

    public virtual ICollection<RejestracjaZgodTrescEsklepy> RejestracjaZgodTrescEsklepies { get; set; } = new List<RejestracjaZgodTrescEsklepy>();

    public virtual ICollection<TwrEsklep> TwrEskleps { get; set; } = new List<TwrEsklep>();
}
