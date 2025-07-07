using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymCechy
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CechaDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CechaDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CechaDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int CechaId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CechaKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CechaKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CechaOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CechaParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CechaParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CechaParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int CechaRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] CechaRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CechaSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CechaTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CechaTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int CechaZrodgid { get; set; }

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

    public int? CechaKlasaId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CechaAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CechaAktualneOrgParId { get; set; }

    public int? CechaAktywny { get; set; }

    public string? CechaNazwa { get; set; }

    public string? CechaOpis { get; set; }

    public string? CechaOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CechaOrgParId { get; set; }

    public int? CechaPoprzednikId { get; set; }

    public int? CechaWymFirma { get; set; }

    public int? CechaWymTyp { get; set; }

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentows { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual WymCechyKlasy? CechaKlasa { get; set; }

    public virtual WymZrodloDanych CechaZrodg { get; set; } = null!;

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMags { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynySrednie> FktMagazynySrednies { get; set; } = new List<FktMagazynySrednie>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanies { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktOferty> FktOferties { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmags { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<WymDostawa> WymDostawas { get; set; } = new List<WymDostawa>();

    public virtual ICollection<WymPartium> WymPartia { get; set; } = new List<WymPartium>();
}
