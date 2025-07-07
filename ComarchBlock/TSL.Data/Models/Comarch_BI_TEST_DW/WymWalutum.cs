using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymWalutum
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SubWsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WalutaDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WalutaDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WalutaDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int WalutaId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WalutaKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WalutaKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WalutaOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? WalutaOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? WalutaParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WalutaParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int WalutaRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] WalutaRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WalutaSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WalutaTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WalutaTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int WalutaZrodgid { get; set; }

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
    public string? WalutaAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? WalutaAktualneOrgParId { get; set; }

    /// <summary>
    /// &apos;1&apos;
    /// </summary>
    public int? WalutaAktywny { get; set; }

    /// <summary>
    /// Nazwa waluty
    /// </summary>
    public string? WalutaNazwa { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? WalutaOpis { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? WalutaOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? WalutaPoprzednikId { get; set; }

    /// <summary>
    /// Symbol waluty
    /// </summary>
    public string? WalutaSymbol { get; set; }

    /// <summary>
    /// 1 - dla waluty systemowej, 0 dla pozostałych
    /// </summary>
    public int? WalutaSystemowa { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? WalutaWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? WalutaWymTyp { get; set; }

    public virtual ICollection<FktCennik> FktCenniks { get; set; } = new List<FktCennik>();

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKursyWalut> FktKursyWaluts { get; set; } = new List<FktKursyWalut>();

    public virtual ICollection<FktLimityKontrahentow> FktLimityKontrahentows { get; set; } = new List<FktLimityKontrahentow>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktOferty> FktOferties { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkis { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSrednies { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKas { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanes { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSrodkiTrwale> FktSrodkiTrwales { get; set; } = new List<FktSrodkiTrwale>();

    public virtual ICollection<FktUmowy> FktUmowies { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowyDokPowiazane> FktUmowyDokPowiazanes { get; set; } = new List<FktUmowyDokPowiazane>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmags { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();

    public virtual WymZrodloDanych WalutaZrodg { get; set; } = null!;
}
