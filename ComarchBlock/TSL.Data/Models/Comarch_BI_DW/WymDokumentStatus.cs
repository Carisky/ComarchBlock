using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymDokumentStatus
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokStatDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokStatDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DokStatDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int DokStatId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokStatKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokStatKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DokStatOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokStatOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokStatParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokStatParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int DokStatRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] DokStatRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokStatSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DokStatTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DokStatTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int DokStatZrodgid { get; set; }

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
    public string? DokStatAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokStatAktualneOrgParId { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? DokStatAktywny { get; set; }

    /// <summary>
    /// Nazwa statusu dokumentu
    /// </summary>
    public string? DokStatNazwa { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? DokStatOpis { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? DokStatOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? DokStatPoprzednikId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? DokStatWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? DokStatWymTyp { get; set; }

    public virtual WymZrodloDanych DokStatZrodg { get; set; } = null!;

    public virtual ICollection<WymDokumentNumer> WymDokumentNumerDokNumerDokStatusRozliczenia { get; set; } = new List<WymDokumentNumer>();

    public virtual ICollection<WymDokumentNumer> WymDokumentNumerDokNumerDokStatuses { get; set; } = new List<WymDokumentNumer>();

    public virtual ICollection<WymDokumentNumerZapOfert> WymDokumentNumerZapOferts { get; set; } = new List<WymDokumentNumerZapOfert>();

    public virtual ICollection<WymWizyty> WymWizyties { get; set; } = new List<WymWizyty>();
}
