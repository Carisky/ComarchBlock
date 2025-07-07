using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class SPomAtrybuty
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long PomAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PomAtrInsertSubTransformationId { get; set; }

    public int PomAtrInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PomAtrTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PomAtrTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PomAtrUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PomAtrUpdateTransformationId { get; set; }

    public int PomAtrCzdgid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PomAtrZrodgid { get; set; }

    public int? PomAtrAktywny { get; set; }

    public string? PomAtrAtkId { get; set; }

    public int? PomAtrAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PomAtrAtrOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PomAtrDirtyOrgId { get; set; } = null!;

    public string? PomAtrNazwa { get; set; }

    public int? PomAtrObjLp { get; set; }

    public int? PomAtrObjNumer { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PomAtrObjOrgId { get; set; } = null!;

    public int? PomAtrObjSubLp { get; set; }

    public int? PomAtrObjTyp { get; set; }

    public string? PomAtrOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PomAtrOrgId { get; set; } = null!;

    public int? PomAtrTypWymiaru { get; set; }

    public string? PomAtrWartosc { get; set; }

    public int? PomAtrWymFirma { get; set; }

    public int? PomAtrWymTyp { get; set; }

    public virtual WymCzasDzien PomAtrCzdg { get; set; } = null!;

    public virtual WymZrodloDanych PomAtrZrodg { get; set; } = null!;
}
