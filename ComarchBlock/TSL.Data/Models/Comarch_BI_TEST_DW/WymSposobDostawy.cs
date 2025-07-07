using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymSposobDostawy
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpdDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpdDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string SpdDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int SpdId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpdKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpdKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string SpdOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SpdParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SpdParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpdParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int SpdRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] SpdRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpdSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime SpdTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime SpdTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int SpdZrodgid { get; set; }

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
    public string? SpdAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SpdAktualneOrgParId { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? SpdAktywny { get; set; }

    /// <summary>
    /// Nazwa sposobu dostawy
    /// </summary>
    public string? SpdNazwa { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? SpdOpis { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? SpdOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SpdOrgParId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? SpdPoprzednikId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? SpdWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? SpdWymTyp { get; set; }

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktRabatyRetro> FktRabatyRetros { get; set; } = new List<FktRabatyRetro>();

    public virtual WymZrodloDanych SpdZrodg { get; set; } = null!;

    public virtual ICollection<WymDokumentNumerZapOfert> WymDokumentNumerZapOferts { get; set; } = new List<WymDokumentNumerZapOfert>();

    public virtual ICollection<WymDokumentNumer> WymDokumentNumers { get; set; } = new List<WymDokumentNumer>();

    public virtual ICollection<WymKontrahent> WymKontrahents { get; set; } = new List<WymKontrahent>();

    public virtual ICollection<WymWizyty> WymWizyties { get; set; } = new List<WymWizyty>();
}
