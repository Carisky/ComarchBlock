using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymStazKlientaTyp
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazTypDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazTypDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string StazTypDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int StazTypId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazTypKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazTypKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string StazTypOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? StazTypOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? StazTypParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazTypParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int StazTypRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] StazTypRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazTypSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime StazTypTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime StazTypTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int StazTypZrodgid { get; set; }

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
    public string? StazTypAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? StazTypAktualneOrgParId { get; set; }

    public int? StazTypAktywny { get; set; }

    public string? StazTypNazwa { get; set; }

    public string? StazTypOpis { get; set; }

    public string? StazTypOrgAtrId { get; set; }

    public int? StazTypPoprzednikId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StazTypWsadDeleteId { get; set; }

    public int? StazTypWymFirma { get; set; }

    public int? StazTypWymTyp { get; set; }

    public virtual WymZrodloDanych StazTypZrodg { get; set; } = null!;

    public virtual ICollection<WymStazKlientum> WymStazKlienta { get; set; } = new List<WymStazKlientum>();
}
