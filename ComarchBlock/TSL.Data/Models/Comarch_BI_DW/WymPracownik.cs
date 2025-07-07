using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymPracownik
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PrcDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PrcDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PrcDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int PrcId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PrcKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PrcKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PrcOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PrcParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PrcParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PrcParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PrcRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] PrcRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PrcSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PrcTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PrcTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PrcZrodgid { get; set; }

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
    /// Relacja do wymiaru WYM_StrukturaFirmy
    /// </summary>
    public int? PrcStrFirmyId { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? FaktyOpiekun { get; set; }

    /// <summary>
    /// Adres pracownika
    /// </summary>
    public string? PrcAdres { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PrcAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PrcAktualneOrgParId { get; set; }

    /// <summary>
    /// Informacja czy pracownik ma zaznaczony check &apos;Archiwalny&apos;. Nie - archiwalny, Tak - aktywny
    /// </summary>
    public string? PrcAktywny { get; set; }

    /// <summary>
    /// E-mail pracownika
    /// </summary>
    public string? PrcEmail { get; set; }

    /// <summary>
    /// Kod pocztowy miejscowości w której mieszka pracownik
    /// </summary>
    public string? PrcKodPocztowy { get; set; }

    /// <summary>
    /// Miasto pracownika
    /// </summary>
    public string? PrcMiasto { get; set; }

    /// <summary>
    /// Akronim pracownika
    /// </summary>
    public string PrcNazwa { get; set; } = null!;

    /// <summary>
    /// Nazwisko pracownika
    /// </summary>
    public string? PrcNazwisko { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? PrcOpis { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? PrcOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PrcOrgParId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? PrcPoprzednikId { get; set; }

    /// <summary>
    /// Akronim pracownika
    /// </summary>
    public string? PrcSymbol { get; set; }

    /// <summary>
    /// Telefon pracownika
    /// </summary>
    public string? PrcTelefon { get; set; }

    /// <summary>
    /// Telefon domowy pracownika
    /// </summary>
    public string? PrcTelefonDomowy { get; set; }

    /// <summary>
    /// Telefon komórkowy pracownika
    /// </summary>
    public string? PrcTelefonKom { get; set; }

    /// <summary>
    /// Telefon wewnętrzny pracownika
    /// </summary>
    public string? PrcTelefonWew { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? PrcWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? PrcWymTyp { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? FaktyPracownik { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? FaktyOpiekunspinacz { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? FaktyPrc { get; set; }

    public DateTime? PrcDataUrodzenia { get; set; }

    public int? PrcOptimaId { get; set; }

    public string? PrcPlec { get; set; }

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktKoszty> FktKosztyKosztOpiekuns { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztPracowniks { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktOferty> FktOferties { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkis { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsOpiekunSpinaczs { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsOpiekuns { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazyPlsPracowniks { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkOpiekunSpinaczs { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkOpiekuns { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKosztyPkPracowniks { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprOpiekunSpinaczs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprOpiekuns { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprPracowniks { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktTransport> FktTransports { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktWizyty> FktWizyties { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhOpiekuns { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhPrcs { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmOpiekuns { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmPrcs { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazOpiekuns { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazPrcs { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual WymStrukturaFirmy? PrcStrFirmy { get; set; }

    public virtual WymZrodloDanych PrcZrodg { get; set; } = null!;

    public virtual ICollection<WymFlotaTrasa> WymFlotaTrasas { get; set; } = new List<WymFlotaTrasa>();

    public virtual ICollection<WymKontrahent> WymKontrahents { get; set; } = new List<WymKontrahent>();

    public virtual ICollection<WymMagazyn> WymMagazyns { get; set; } = new List<WymMagazyn>();

    public virtual ICollection<WymOperator> WymOperators { get; set; } = new List<WymOperator>();

    public virtual ICollection<WymProdukt> WymProdukts { get; set; } = new List<WymProdukt>();

    public virtual ICollection<WymProjekt> WymProjekts { get; set; } = new List<WymProjekt>();

    public virtual ICollection<WymRejon> WymRejons { get; set; } = new List<WymRejon>();

    public virtual ICollection<WymWmsmagazyn> WymWmsmagazyns { get; set; } = new List<WymWmsmagazyn>();
}
