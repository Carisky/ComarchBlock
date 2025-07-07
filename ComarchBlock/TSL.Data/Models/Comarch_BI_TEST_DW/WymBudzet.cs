using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymBudzet
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? BudzetDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? BudzetDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string BudzetDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int BudzetId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? BudzetKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? BudzetKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string BudzetOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? BudzetParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? BudzetParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? BudzetParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int BudzetRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] BudzetRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? BudzetSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime BudzetTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime BudzetTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int BudzetZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SubWsadInsertId { get; set; }

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

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? BudzetAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? BudzetAktualneOrgParId { get; set; }

    /// <summary>
    /// Informacja, czy budżet jest aktywny
    /// </summary>
    public int? BudzetAktywny { get; set; }

    /// <summary>
    /// Nazwa budżetu
    /// </summary>
    public string BudzetNazwa { get; set; } = null!;

    /// <summary>
    /// Kolumna niewykozrystywana
    /// </summary>
    public string? BudzetOpis { get; set; }

    /// <summary>
    /// Kolumna niewykozrystywana
    /// </summary>
    public string? BudzetOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? BudzetOrgParId { get; set; }

    /// <summary>
    /// Kolumna niewykozrystywana
    /// </summary>
    public int? BudzetPoprzednikId { get; set; }

    /// <summary>
    /// Typ budżetu
    /// </summary>
    public string? BudzetTyp { get; set; }

    /// <summary>
    /// Kolumna niewykozrystywana
    /// </summary>
    public int? BudzetWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykozrystywana
    /// </summary>
    public int? BudzetWymTyp { get; set; }

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentows { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual WymZrodloDanych BudzetZrodg { get; set; } = null!;

    public virtual ICollection<FktAnkiety> FktAnkieties { get; set; } = new List<FktAnkiety>();

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktFlotum> FktFlota { get; set; } = new List<FktFlotum>();

    public virtual ICollection<FktJednostkiPomocnicze> FktJednostkiPomocniczes { get; set; } = new List<FktJednostkiPomocnicze>();

    public virtual ICollection<FktKampanieEtapy> FktKampanieEtapies { get; set; } = new List<FktKampanieEtapy>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjas { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjes { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktMagazynyNormatywy> FktMagazynyNormatywies { get; set; } = new List<FktMagazynyNormatywy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMags { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanies { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktMarszrutum> FktMarszruta { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktOferty> FktOferties { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkis { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSrednies { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKas { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktPracownikCzasPracy> FktPracownikCzasPracies { get; set; } = new List<FktPracownikCzasPracy>();

    public virtual ICollection<FktPracownikEtaty> FktPracownikEtaties { get; set; } = new List<FktPracownikEtaty>();

    public virtual ICollection<FktPracownikLimityNieobecnosci> FktPracownikLimityNieobecnoscis { get; set; } = new List<FktPracownikLimityNieobecnosci>();

    public virtual ICollection<FktPracownikNieobecnosci> FktPracownikNieobecnoscis { get; set; } = new List<FktPracownikNieobecnosci>();

    public virtual ICollection<FktPracownikObecnosci> FktPracownikObecnoscis { get; set; } = new List<FktPracownikObecnosci>();

    public virtual ICollection<FktPracownikUmowyKwoty> FktPracownikUmowyKwoties { get; set; } = new List<FktPracownikUmowyKwoty>();

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplaties { get; set; } = new List<FktPracownikWyplaty>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjes { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszruta { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowas { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZlecenia { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKoszties { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZps { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanes { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPrzestoje> FktPrzestojes { get; set; } = new List<FktPrzestoje>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRaportyWizyt> FktRaportyWizyts { get; set; } = new List<FktRaportyWizyt>();

    public virtual ICollection<FktReklamacje> FktReklamacjes { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktRezerwacje> FktRezerwacjes { get; set; } = new List<FktRezerwacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktTransport> FktTransports { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktUmowy> FktUmowies { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowyDokPowiazane> FktUmowyDokPowiazanes { get; set; } = new List<FktUmowyDokPowiazane>();

    public virtual ICollection<FktWizyty> FktWizyties { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktWizytyElement> FktWizytyElements { get; set; } = new List<FktWizytyElement>();

    public virtual ICollection<FktWm> FktWms { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWydatki> FktWydatkis { get; set; } = new List<FktWydatki>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmags { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZapytaniaOfertowe> FktZapytaniaOfertowes { get; set; } = new List<FktZapytaniaOfertowe>();

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();
}
