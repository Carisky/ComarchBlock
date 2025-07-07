using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymCzasTydzien
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CztDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CztDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CztDirtyOrgId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int CztId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CztKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CztKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CztOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CztParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CztParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CztParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CztRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] CztRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CztSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CztTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CztTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int CztZrodgid { get; set; }

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
    public int? CztAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CztAktualneOrgParId { get; set; }

    public int? CztAktywny { get; set; }

    public int? CztCzrid { get; set; }

    public string? CztNazwa { get; set; }

    public int? CztNrTygodnia { get; set; }

    public string? CztOpis { get; set; }

    public string? CztOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CztOrgParId { get; set; }

    public int? CztPoprzednikId { get; set; }

    public int? CztWymFirma { get; set; }

    public int? CztWymTyp { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    public virtual WymZrodloDanych CztZrodg { get; set; } = null!;
}
