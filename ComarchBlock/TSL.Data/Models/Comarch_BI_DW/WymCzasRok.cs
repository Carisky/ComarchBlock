using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymCzasRok
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzrDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzrDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CzrDirtyOrgId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int CzrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzrKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzrKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzrOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CzrParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CzrParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzrParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzrRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] CzrRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzrSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CzrTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CzrTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int CzrZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SubWsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadUpdateId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzrAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzrAktualneOrgParId { get; set; }

    public int? CzrAktywny { get; set; }

    public int? CzrCzrrok { get; set; }

    public string? CzrNazwa { get; set; }

    public string? CzrOpis { get; set; }

    public string? CzrOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CzrOrgParId { get; set; }

    public int? CzrPoprzednikId { get; set; }

    public int? CzrWymFirma { get; set; }

    public int? CzrWymTyp { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    public virtual WymZrodloDanych CzrZrodg { get; set; } = null!;

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();
}
