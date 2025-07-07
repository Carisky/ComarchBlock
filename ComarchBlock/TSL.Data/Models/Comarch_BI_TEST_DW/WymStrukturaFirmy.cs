using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymStrukturaFirmy
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StrFrmDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StrFrmDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string StrFrmDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int StrFrmId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StrFrmKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StrFrmKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string StrFrmOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? StrFrmOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? StrFrmParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StrFrmParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int StrFrmRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] StrFrmRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StrFrmSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime StrFrmTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime StrFrmTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int StrFrmZrodgid { get; set; }

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
    public string? StrFrmAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? StrFrmAktualneOrgParId { get; set; }

    public int? StrFrmAktywny { get; set; }

    public string? StrFrmKonto { get; set; }

    public string? StrFrmNazwa { get; set; }

    public string? StrFrmOlapSecurity { get; set; }

    public string? StrFrmOpis { get; set; }

    public string? StrFrmOrgAtrId { get; set; }

    public int? StrFrmPoprzednikId { get; set; }

    public int? StrFrmTyp { get; set; }

    public string? StrFrmUrl { get; set; }

    public int? StrFrmWymFirma { get; set; }

    public int? StrFrmWymTyp { get; set; }

    public string? StrFrmNazwaPar { get; set; }

    public int? StrFrmOptimaId { get; set; }

    public string? Hierarchy5Level1Name { get; set; }

    public string? Hierarchy5Level1OrgId { get; set; }

    public int? Hierarchy5Level1Id { get; set; }

    public string? Hierarchy5Level2Name { get; set; }

    public string? Hierarchy5Level2OrgId { get; set; }

    public int? Hierarchy5Level2Id { get; set; }

    public string? Hierarchy5Level3Name { get; set; }

    public string? Hierarchy5Level3OrgId { get; set; }

    public int? Hierarchy5Level3Id { get; set; }

    public string? Hierarchy5Level4Name { get; set; }

    public string? Hierarchy5Level4OrgId { get; set; }

    public int? Hierarchy5Level4Id { get; set; }

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

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

    public virtual ICollection<FktPracownikLimityNieobecnosci> FktPracownikLimityNieobecnoscis { get; set; } = new List<FktPracownikLimityNieobecnosci>();

    public virtual ICollection<FktPracownikNieobecnosci> FktPracownikNieobecnoscis { get; set; } = new List<FktPracownikNieobecnosci>();

    public virtual ICollection<FktPracownikObecnosci> FktPracownikObecnoscis { get; set; } = new List<FktPracownikObecnosci>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjes { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszruta { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowas { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZlecenia { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKoszties { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZps { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanes { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktReklamacje> FktReklamacjes { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktUmowy> FktUmowies { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktWm> FktWms { get; set; } = new List<FktWm>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmags { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();

    public virtual WymZrodloDanych StrFrmZrodg { get; set; } = null!;

    public virtual ICollection<WymPracownik> WymPracowniks { get; set; } = new List<WymPracownik>();

    public virtual ICollection<WymProdukt> WymProdukts { get; set; } = new List<WymProdukt>();
}
