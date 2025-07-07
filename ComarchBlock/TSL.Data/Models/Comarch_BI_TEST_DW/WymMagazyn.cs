using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymMagazyn
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MagDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MagDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MagDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int MagId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MagKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MagKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MagOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MagParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MagParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MagParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int MagRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] MagRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MagSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MagTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MagTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int MagZrodgid { get; set; }

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
    /// Identyfikator pracownika odpowiedzialnego za magazyn. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int? MagOdpowiedzialnyId { get; set; }

    /// <summary>
    /// Adres magazynu
    /// </summary>
    public string? MagAdres { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MagAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MagAktualneOrgParId { get; set; }

    /// <summary>
    /// kolumna techniczna
    /// </summary>
    public int? MagAktywny { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? MagAnalityka { get; set; }

    /// <summary>
    /// Kod pocztowy magazynu
    /// </summary>
    public string? MagKodPocztowy { get; set; }

    /// <summary>
    /// Miasto, w którym znajduje się magazyn
    /// </summary>
    public string? MagMiasto { get; set; }

    /// <summary>
    /// Nazwa magazynu
    /// </summary>
    public string? MagNazwa { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? MagOpis { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public string? MagOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MagOrgParId { get; set; }

    /// <summary>
    /// Pojemność magazynu
    /// </summary>
    public decimal? MagPojemnosc { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? MagPoprzednikId { get; set; }

    /// <summary>
    /// Rodzaj magazynu, skład celny lub magazyn
    /// </summary>
    public string? MagRodzaj { get; set; }

    /// <summary>
    /// Symbol magazynu
    /// </summary>
    public string? MagSymbol { get; set; }

    /// <summary>
    /// Typ magazynu
    /// </summary>
    public string? MagTyp { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? MagWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? MagWymTyp { get; set; }

    /// <summary>
    /// Parametr analizy ABC/XYZ
    /// </summary>
    public decimal? MagAnalizaA { get; set; }

    /// <summary>
    /// Parametr analizy ABC/XYZ
    /// </summary>
    public decimal? MagAnalizaB { get; set; }

    /// <summary>
    /// Parametr analizy ABC/XYZ
    /// </summary>
    public decimal? MagAnalizaC { get; set; }

    /// <summary>
    /// Parametr analizy ABC/XYZ
    /// </summary>
    public decimal? MagAnalizaX { get; set; }

    /// <summary>
    /// Parametr analizy ABC/XYZ
    /// </summary>
    public decimal? MagAnalizaY { get; set; }

    /// <summary>
    /// Parametr analizy ABC/XYZ
    /// </summary>
    public decimal? MagAnalizaZ { get; set; }

    /// <summary>
    /// Informacja, czy magazyn ma być brany pod uwagę w analizie ABC\XYZ
    /// </summary>
    public byte? MagAnalizaAbcxyz { get; set; }

    public string? MagAktywnyOpis { get; set; }

    /// <summary>
    /// Informacja, czy magazyn jest oznaczony jako wewnętrzny
    /// </summary>
    public string? MagWewnetrzny { get; set; }

    /// <summary>
    /// Informacja, czy magazyn jest oznaczony jako oddziałowy
    /// </summary>
    public string? MagOddzialowy { get; set; }

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentows { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdMagGs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdMagProdGs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdMagPwgs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdMagRelGs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdMagRwgs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjaZkdMagSklGs { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktMagazynyNormatywy> FktMagazynyNormatywies { get; set; } = new List<FktMagazynyNormatywy>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMags { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrMagDs { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrMags { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynySrednieRuchyDokMag> FktMagazynySrednieRuchyDokMags { get; set; } = new List<FktMagazynySrednieRuchyDokMag>();

    public virtual ICollection<FktMagazynySrednie> FktMagazynySrednies { get; set; } = new List<FktMagazynySrednie>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanies { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktOferty> FktOferties { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjes { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowas { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpMagGidpwNavigations { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZpPzpMagGs { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanes { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabatyRetro> FktRabatyRetros { get; set; } = new List<FktRabatyRetro>();

    public virtual ICollection<FktRezerwacje> FktRezerwacjes { get; set; } = new List<FktRezerwacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmags { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual WymPracownik? MagOdpowiedzialny { get; set; }

    public virtual WymZrodloDanych MagZrodg { get; set; } = null!;
}
