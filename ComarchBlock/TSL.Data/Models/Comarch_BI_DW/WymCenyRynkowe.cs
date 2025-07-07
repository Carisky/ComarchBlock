using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymCenyRynkowe
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CenaRynDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CenaRynDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CenaRynDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int CenaRynId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CenaRynKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CenaRynKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CenaRynOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CenaRynParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CenaRynParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CenaRynParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int CenaRynRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] CenaRynRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CenaRynSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CenaRynTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CenaRynTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int CenaRynZrodgid { get; set; }

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
    public string? CenaRynAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CenaRynAktualneOrgParId { get; set; }

    public int? CenaRynAktywny { get; set; }

    public string? CenaRynNazwa { get; set; }

    public int? CenaRynNumer { get; set; }

    public string? CenaRynOpis { get; set; }

    public string? CenaRynOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CenaRynOrgParId { get; set; }

    public int? CenaRynPoprzednikId { get; set; }

    public int? CenaRynWymFirma { get; set; }

    public int? CenaRynWymTyp { get; set; }

    public virtual WymZrodloDanych CenaRynZrodg { get; set; } = null!;
}
