using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymCechaTransakcji
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ChtDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ChtDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ChtDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int ChtId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ChtKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ChtKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ChtOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ChtParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ChtParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ChtParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ChtRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] ChtRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ChtSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ChtTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ChtTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ChtZrodgid { get; set; }

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
    public string? ChtAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ChtAktualneOrgParId { get; set; }

    public int? ChtAktywny { get; set; }

    public string? ChtNazwa { get; set; }

    public string? ChtOpis { get; set; }

    public string? ChtOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ChtOrgParId { get; set; }

    public int? ChtPoprzednikId { get; set; }

    public int? ChtWymFirma { get; set; }

    public int? ChtWymTyp { get; set; }

    public virtual WymZrodloDanych ChtZrodg { get; set; } = null!;

    public virtual ICollection<WymDokumentNumerZapOfert> WymDokumentNumerZapOferts { get; set; } = new List<WymDokumentNumerZapOfert>();

    public virtual ICollection<WymDokumentNumer> WymDokumentNumers { get; set; } = new List<WymDokumentNumer>();

    public virtual ICollection<WymUmowa> WymUmowas { get; set; } = new List<WymUmowa>();

    public virtual ICollection<WymWizyty> WymWizyties { get; set; } = new List<WymWizyty>();
}
