using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymKategorieFinansowe
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KatFinDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KatFinDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KatFinDirtyOrgId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int KatFinId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KatFinKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KatFinKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KatFinOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KatFinOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KatFinParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KatFinParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int KatFinRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] KatFinRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KatFinSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KatFinTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KatFinTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int KatFinZrodgid { get; set; }

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
    public string? KatFinAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KatFinAktualneOrgParId { get; set; }

    public int? KatFinAktywny { get; set; }

    public string? KatFinCustomRollup { get; set; }

    public int? KatFinKategoria { get; set; }

    public string? KatFinKonto { get; set; }

    public string? KatFinNazwa { get; set; }

    public string? KatFinOpis { get; set; }

    public string? KatFinOrgAtrId { get; set; }

    public string? KatFinOrgWart { get; set; }

    public int? KatFinPoprzednikId { get; set; }

    public int? KatFinTyp { get; set; }

    public int? KatFinWymFirma { get; set; }

    public int? KatFinWymTyp { get; set; }

    public string? KatFinArchiwalny { get; set; }

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZlecenia { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKoszties { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();

    public virtual WymZrodloDanych KatFinZrodg { get; set; } = null!;
}
