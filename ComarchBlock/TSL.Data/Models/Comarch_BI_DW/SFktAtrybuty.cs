using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class SFktAtrybuty
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AtrDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long AtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AtrInsertSubTransformationId { get; set; }

    public string? AtrOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AtrOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime AtrTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime AtrTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AtrUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int AtrUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    public int AtrCzdgid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int AtrZrodgid { get; set; }

    public int? AtrKierunek { get; set; }

    public int? AtrObjLp { get; set; }

    public int? AtrObjNumer { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AtrObjOrgId { get; set; } = null!;

    public int? AtrObjSubLp { get; set; }

    public int? AtrObjTyp { get; set; }

    public string? AtrOrgAtrId { get; set; }

    public string? AtrOrgWymId { get; set; }

    public int? AtrTypKwoty { get; set; }

    public int? AtrWymFirma { get; set; }

    public int? AtrWymTyp { get; set; }

    public virtual WymCzasDzien AtrCzdg { get; set; } = null!;

    public virtual WymZrodloDanych AtrZrodg { get; set; } = null!;
}
