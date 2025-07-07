using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymCzasDzien
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int CzdId { get; set; }

    public string? CzdNazwa { get; set; }

    public string? CzdOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int CzdOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzdRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] CzdRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CzdTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CzdTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzdAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzdAktualneOrgParId { get; set; }

    public int? CzdAktywny { get; set; }

    public int? CzdCzmid { get; set; }

    public int? CzdCzrid { get; set; }

    public int? CzdCztid { get; set; }

    public DateTime? CzdData { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzdDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzdDataOd { get; set; }

    public string? CzdDzienKod { get; set; }

    public string? CzdDzienNazwa { get; set; }

    public string? CzdDzienRoku { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzdKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzdKimball2CheckSum { get; set; }

    public string? CzdKodWtygodniu { get; set; }

    public string? CzdNazwaWtygodniu { get; set; }

    public int? CzdNrMiesiaca { get; set; }

    public int? CzdNrTygodnia { get; set; }

    public int? CzdNrWmiesiacu { get; set; }

    public int? CzdNrWroku { get; set; }

    public int? CzdNrWtygodniu { get; set; }

    public int? CzdNumerWkwartale { get; set; }

    public string? CzdOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzdOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzdParId { get; set; }

    public int? CzdPoprzednikId { get; set; }

    public string? CzdRoboczy { get; set; }

    public int? CzdWymFirma { get; set; }

    public int? CzdWymTyp { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadUpdateId { get; set; }

    public int? CzdCztisogid { get; set; }

    public int? CzdTydzienNazwaIso { get; set; }

    public string? CzdOkresObrach { get; set; }

    public int? CzdPoczatekOkresuObrach { get; set; }

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentows { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual ICollection<FctAttributeMeasure> FctAttributeMeasures { get; set; } = new List<FctAttributeMeasure>();

    public virtual ICollection<FktAnalizaRfm> FktAnalizaRfms { get; set; } = new List<FktAnalizaRfm>();

    public virtual ICollection<FktAnkiety> FktAnkieties { get; set; } = new List<FktAnkiety>();

    public virtual ICollection<FktCennik> FktCennikCenCzds { get; set; } = new List<FktCennik>();

    public virtual ICollection<FktCennik> FktCennikCenDataRozpoczecia { get; set; } = new List<FktCennik>();

    public virtual ICollection<FktCennik> FktCennikCenDataZakonczenia { get; set; } = new List<FktCennik>();

    public virtual ICollection<FktDekrety> FktDekretyDtCzdWprowadzenia { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDekrety> FktDekretyDtCzds { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzCzdprzyjecia { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzCzds { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzCzdwystawienia { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupuKdzCzdzakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktDokumenty> FktDokumenties { get; set; } = new List<FktDokumenty>();

    public virtual ICollection<FktFlotum> FktFlota { get; set; } = new List<FktFlotum>();

    public virtual ICollection<FktKampanieEtapy> FktKampanieEtapyKmpCzds { get; set; } = new List<FktKampanieEtapy>();

    public virtual ICollection<FktKampanieEtapy> FktKampanieEtapyKmpDataDos { get; set; } = new List<FktKampanieEtapy>();

    public virtual ICollection<FktKampanieEtapy> FktKampanieEtapyKmpDataOds { get; set; } = new List<FktKampanieEtapy>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdCzdgs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdCzdpgs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdCzdprgs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdCzdrelGs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdCzdrgs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdCzdrzgs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdCzdwgs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamCzds { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamDataDos { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamDataOds { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamDataRozpoczeciaKnts { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamDataZakonczeniaKnts { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKoszty> FktKosztyKosztCzds { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztCzdterminPlats { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztCzs { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztCzws { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztDataDokumentus { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKursyWalut> FktKursyWaluts { get; set; } = new List<FktKursyWalut>();

    public virtual ICollection<FktLimityKontrahentow> FktLimityKontrahentows { get; set; } = new List<FktLimityKontrahentow>();

    public virtual ICollection<FktMagazynyNormatywy> FktMagazynyNormatywies { get; set; } = new List<FktMagazynyNormatywy>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmCzds { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmDataDostawyMagNavigations { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmDataDostawyNavigations { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmDataWplywuNavigations { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmDataZgloszeniaNavigations { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrCzdmags { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrCzds { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrDataDostawyMagNavigations { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrDataDostawyNavigations { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrDataWplywuNavigations { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrDataZgloszeniaNavigations { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynySrednieRuchyDokMag> FktMagazynySrednieRuchyDokMags { get; set; } = new List<FktMagazynySrednieRuchyDokMag>();

    public virtual ICollection<FktMagazynySrednie> FktMagazynySrednies { get; set; } = new List<FktMagazynySrednie>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanyMgsCzds { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanyMgsDataDostawyNavigations { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPmrszCzdgs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPmrszDataZamknieciaDokGs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPmrszTrozRzeczCzynnosciCzdgs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPrmszTrozPlanCzynnosciCzdgs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPrmszTrozPlanZasobuCzdgs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPrmszTrozRzeczZasobuCzdgs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPrmszTzakonPlanCzynnosciCzdgs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPrmszTzakonPlanZasobuCzdgs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPrmszTzakonRzeczCzynnosciCzdgs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPrmszTzakonRzeczZasobuCzdgs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktNarzedziowniaZuzyciaRuchy> FktNarzedziowniaZuzyciaRuchies { get; set; } = new List<FktNarzedziowniaZuzyciaRuchy>();

    public virtual ICollection<FktNarzedziowniaZuzyciaStany> FktNarzedziowniaZuzyciaStanies { get; set; } = new List<FktNarzedziowniaZuzyciaStany>();

    public virtual ICollection<FktNarzedziownium> FktNarzedziowniumNrzCzdgs { get; set; } = new List<FktNarzedziownium>();

    public virtual ICollection<FktNarzedziownium> FktNarzedziowniumNrzTerminWydaniaNavigations { get; set; } = new List<FktNarzedziownium>();

    public virtual ICollection<FktNarzedziownium> FktNarzedziowniumNrzTerminZdaniaNavigations { get; set; } = new List<FktNarzedziownium>();

    public virtual ICollection<FktOferty> FktOfertyOfeCzdreals { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktOferty> FktOfertyOfeCzds { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktOferty> FktOfertyOfeCzdwazs { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktParametryEtl> FktParametryEtls { get; set; } = new List<FktParametryEtl>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezacePlbCzds { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezacePlbCzdterminPlats { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezacePlbDataWystawieniaNavigations { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDzienPndCzds { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDzienPndCzdterminPlats { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapCzddataOtwarcia { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapCzds { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapCzdterminPlats { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapCzdtermins { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczoneZapDataWystawienia { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkiRzrCzds { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkiRzrCzdterminPlats { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkiRzrDataWystawienia { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsCzdprzyjeciaWydania { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsCzds { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsCzdterminPlats { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsDataDokumentus { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSrednies { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKaStkCzds { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKaStkCzdts { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKaStkDataOtwarcia { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKaStkDataZamkniecia { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktPomFunkcjeKontaMap> FktPomFunkcjeKontaMaps { get; set; } = new List<FktPomFunkcjeKontaMap>();

    public virtual ICollection<FktPomZestawieniaFunkcjeMap> FktPomZestawieniaFunkcjeMaps { get; set; } = new List<FktPomZestawieniaFunkcjeMap>();

    public virtual ICollection<FktPracownikEtaty> FktPracownikEtaties { get; set; } = new List<FktPracownikEtaty>();

    public virtual ICollection<FktPracownikLimityNieobecnosci> FktPracownikLimityNieobecnosciPloCzdgs { get; set; } = new List<FktPracownikLimityNieobecnosci>();

    public virtual ICollection<FktPracownikLimityNieobecnosci> FktPracownikLimityNieobecnosciPloCzdidoNavigations { get; set; } = new List<FktPracownikLimityNieobecnosci>();

    public virtual ICollection<FktPracownikLimityNieobecnosci> FktPracownikLimityNieobecnosciPloCzdidwaznyOdNavigations { get; set; } = new List<FktPracownikLimityNieobecnosci>();

    public virtual ICollection<FktPracownikNieobecnosci> FktPracownikNieobecnosciPnoCzdgiddoNavigations { get; set; } = new List<FktPracownikNieobecnosci>();

    public virtual ICollection<FktPracownikNieobecnosci> FktPracownikNieobecnosciPnoCzdgs { get; set; } = new List<FktPracownikNieobecnosci>();

    public virtual ICollection<FktPracownikObecnosci> FktPracownikObecnoscis { get; set; } = new List<FktPracownikObecnosci>();

    public virtual ICollection<FktPracownikUmowyKwoty> FktPracownikUmowyKwotyUstCzddogs { get; set; } = new List<FktPracownikUmowyKwoty>();

    public virtual ICollection<FktPracownikUmowyKwoty> FktPracownikUmowyKwotyUstCzdgs { get; set; } = new List<FktPracownikUmowyKwoty>();

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplatyKwtCzdgs { get; set; } = new List<FktPracownikWyplaty>();

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplatyKwtCzdrs { get; set; } = new List<FktPracownikWyplaty>();

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplatyKwtCzdzs { get; set; } = new List<FktPracownikWyplaty>();

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplatyKwtCzms { get; set; } = new List<FktPracownikWyplaty>();

    public virtual ICollection<FktProdukcjaDokumenty> FktProdukcjaDokumenties { get; set; } = new List<FktProdukcjaDokumenty>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjePkkCzdgs { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjePkkCzdrozpNavigations { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjePkkCzdzakNavigations { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszrutumPmaCzds { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszrutumPmaCzdzaks { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszrutumPmaDataDokumentus { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowaPsmCzdkoszts { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowaPsmCzds { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKosztyPrzCzdzaks { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKosztyPzkCzdans { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKosztyPzkCzdplanWpros { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKosztyPzkCzdplanZaks { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKosztyPzkCzdprzypisaniaKosztus { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKosztyPzkCzds { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKosztyPzkCzdwpros { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZleceniumPrzCzdans { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZleceniumPrzCzdplanWpros { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZleceniumPrzCzdplanZaks { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZleceniumPrzCzds { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZleceniumPrzCzdwpros { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZleceniumPrzCzdzaks { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpCzdgs { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpCzdrozpGs { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpCzdzakGs { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktProgramLojalnosciowy> FktProgramLojalnosciowyPrlCzdgs { get; set; } = new List<FktProgramLojalnosciowy>();

    public virtual ICollection<FktProgramLojalnosciowy> FktProgramLojalnosciowyPrlCzdodgs { get; set; } = new List<FktProgramLojalnosciowy>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanes { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPrzestoje> FktPrzestojePrzCzdgs { get; set; } = new List<FktPrzestoje>();

    public virtual ICollection<FktPrzestoje> FktPrzestojePrzDataRozpoczeciaCzdgs { get; set; } = new List<FktPrzestoje>();

    public virtual ICollection<FktPrzestoje> FktPrzestojePrzDataZakonczeniaCzdgs { get; set; } = new List<FktPrzestoje>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkCzds { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkDataDokumentus { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatCzdfakts { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatCzdplans { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatCzds { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatCzs { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatCzws { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatDataDokumentus { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabatyRetroAgregacje> FktRabatyRetroAgregacjes { get; set; } = new List<FktRabatyRetroAgregacje>();

    public virtual ICollection<FktRabatyRetro> FktRabatyRetros { get; set; } = new List<FktRabatyRetro>();

    public virtual ICollection<FktRaportyWizyt> FktRaportyWizytRaweCzdgs { get; set; } = new List<FktRaportyWizyt>();

    public virtual ICollection<FktRaportyWizyt> FktRaportyWizytRaweCzds { get; set; } = new List<FktRaportyWizyt>();

    public virtual ICollection<FktReklamacjeRealizacje> FktReklamacjeRealizacjes { get; set; } = new List<FktReklamacjeRealizacje>();

    public virtual ICollection<FktReklamacje> FktReklamacjeReklCzds { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktReklamacje> FktReklamacjeReklCzzgs { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktRezerwacje> FktRezerwacjeRezCzdgs { get; set; } = new List<FktRezerwacje>();

    public virtual ICollection<FktRezerwacje> FktRezerwacjeRezCzwgs { get; set; } = new List<FktRezerwacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprCzddataRozs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprCzdprzyjeciaWydania { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprCzds { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprCzdterminPlats { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprCzs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprCzws { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprDataDokumentus { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprSpiczddataRozOrgs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprSpiczddataWystawienia { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprSpiczdprzyjeciaWydaniaOrgs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprSpiczdterminPlatOrgs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprSpiczdzakupuOrgs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSrodkiTrwale> FktSrodkiTrwaleSrTrCzdgiddokNavigations { get; set; } = new List<FktSrodkiTrwale>();

    public virtual ICollection<FktSrodkiTrwale> FktSrodkiTrwaleSrTrCzdgidlikwNavigations { get; set; } = new List<FktSrodkiTrwale>();

    public virtual ICollection<FktSrodkiTrwale> FktSrodkiTrwaleSrTrCzdgs { get; set; } = new List<FktSrodkiTrwale>();

    public virtual ICollection<FktTransport> FktTransportTrsCzddstDos { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktTransport> FktTransportTrsCzddstOds { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktTransport> FktTransportTrsCzds { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktTransport> FktTransportTrsCzdwys { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktUmowyDokPowiazane> FktUmowyDokPowiazanes { get; set; } = new List<FktUmowyDokPowiazane>();

    public virtual ICollection<FktUmowyDokumenty> FktUmowyDokumenties { get; set; } = new List<FktUmowyDokumenty>();

    public virtual ICollection<FktUmowy> FktUmowyUmyCzds { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowy> FktUmowyUmyDataPots { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowy> FktUmowyUmyDataRozs { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowy> FktUmowyUmyDataZaks { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowy> FktUmowyUmyDataZaws { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktWizytyElement> FktWizytyElementWzECzdgs { get; set; } = new List<FktWizytyElement>();

    public virtual ICollection<FktWizytyElement> FktWizytyElementWzECzps { get; set; } = new List<FktWizytyElement>();

    public virtual ICollection<FktWizytyElement> FktWizytyElementWzECzws { get; set; } = new List<FktWizytyElement>();

    public virtual ICollection<FktWizyty> FktWizytyWizCzds { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktWizyty> FktWizytyWizDataOdrzucenia { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktWizyty> FktWizytyWizDataZakonczenia { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktWizyty> FktWizytyWizTerminRozpoczecia { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktWizyty> FktWizytyWizTerminZakonczenia { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktWm> FktWmWmsfCzdergs { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWm> FktWmWmsfCzdewgs { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWm> FktWmWmsfCzdgs { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWm> FktWmWmsfCzdzgs { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWydatki> FktWydatkis { get; set; } = new List<FktWydatki>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnosciZptCzds { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnosciZptCzdterminPlats { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnosciZptDataDokumentus { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZakupy> FktZakupyZkpCzdKsiegowania { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpCzdPrzyjecia { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpCzdWplywus { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpCzdWystawienia { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpCzdZakupus { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpCzddataRozs { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpCzdplans { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpCzds { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpCzdterminPlats { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpDataDokumentus { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpDataWplywuNavigations { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpDataZgloszeniaNavigations { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpSpiczddataRozOrgs { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpSpiczdksiegowaniaOrgs { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpSpiczdprzyjeciaOrgs { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpSpiczdterminPlatOrgs { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpSpiczdwplywuOrgs { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpSpiczdwystawieniaOrgs { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupy> FktZakupyZkpSpiczdzakupuOrgs { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZamienniki> FktZamiennikis { get; set; } = new List<FktZamienniki>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakCzdfakts { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakCzdplans { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakCzds { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhCzdfakts { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhCzdplans { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhCzds { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmCzdfakts { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmCzdplans { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmCzds { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazCzdfakts { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazCzdplans { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazCzds { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZapytaniaOfertowe> FktZapytaniaOfertowes { get; set; } = new List<FktZapytaniaOfertowe>();

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();

    public virtual ICollection<FktZestawieniaKsiegoweErp> FktZestawieniaKsiegoweErps { get; set; } = new List<FktZestawieniaKsiegoweErp>();

    public virtual ICollection<SFktAtrybuty> SFktAtrybuties { get; set; } = new List<SFktAtrybuty>();

    public virtual ICollection<SFktKosztySprzedazy> SFktKosztySprzedazies { get; set; } = new List<SFktKosztySprzedazy>();

    public virtual ICollection<SFktOpisyAnalityczne> SFktOpisyAnalitycznes { get; set; } = new List<SFktOpisyAnalityczne>();

    public virtual ICollection<SFktRabatySprzedazy> SFktRabatySprzedazies { get; set; } = new List<SFktRabatySprzedazy>();

    public virtual ICollection<SPomAtrybuty> SPomAtrybuties { get; set; } = new List<SPomAtrybuty>();

    public virtual ICollection<SPomOpisyAnalityczne> SPomOpisyAnalitycznes { get; set; } = new List<SPomOpisyAnalityczne>();

    public virtual ICollection<SPomPropagacjaAtrybutow> SPomPropagacjaAtrybutows { get; set; } = new List<SPomPropagacjaAtrybutow>();

    public virtual ICollection<SPomWymiaryKlasy> SPomWymiaryKlasies { get; set; } = new List<SPomWymiaryKlasy>();

    public virtual ICollection<SPomWymiaryKlasyModyfikacje> SPomWymiaryKlasyModyfikacjes { get; set; } = new List<SPomWymiaryKlasyModyfikacje>();

    public virtual ICollection<WymAtrybuty> WymAtrybuties { get; set; } = new List<WymAtrybuty>();

    public virtual ICollection<WymCennik> WymCenniks { get; set; } = new List<WymCennik>();

    public virtual ICollection<WymDostawa> WymDostawas { get; set; } = new List<WymDostawa>();

    public virtual ICollection<WymPartium> WymPartia { get; set; } = new List<WymPartium>();

    public virtual ICollection<WymProdukt> WymProdukts { get; set; } = new List<WymProdukt>();

    public virtual ICollection<WymPromocje> WymPromocjePrmDataRozpoczecia { get; set; } = new List<WymPromocje>();

    public virtual ICollection<WymPromocje> WymPromocjePrmDataZakonczenia { get; set; } = new List<WymPromocje>();

    public virtual ICollection<WymRabatRetro> WymRabatRetroRetroDataRozpoczecia { get; set; } = new List<WymRabatRetro>();

    public virtual ICollection<WymRabatRetro> WymRabatRetroRetroDataZakonczenia { get; set; } = new List<WymRabatRetro>();

    public virtual ICollection<WymRaportyWizyt> WymRaportyWizytRawDataArchiwizacjiNavigations { get; set; } = new List<WymRaportyWizyt>();

    public virtual ICollection<WymRaportyWizyt> WymRaportyWizytRawDataUtworzeniaNavigations { get; set; } = new List<WymRaportyWizyt>();

    public virtual ICollection<WymSrodekTrwaly> WymSrodekTrwalySrtDataEkspNavigations { get; set; } = new List<WymSrodekTrwaly>();

    public virtual ICollection<WymSrodekTrwaly> WymSrodekTrwalySrtDataLikwNavigations { get; set; } = new List<WymSrodekTrwaly>();
}
