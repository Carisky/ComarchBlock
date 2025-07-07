using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class SPomWymiaryKlasy
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PomWmkDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long PomWmkId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PomWmkInsertSubTransformationId { get; set; }

    public int PomWmkInsertTransformationId { get; set; }

    public string? PomWmkOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PomWmkOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PomWmkTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PomWmkTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PomWmkUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PomWmkUpdateTransformationId { get; set; }

    public int PomWmkCzdgid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PomWmkZrodgid { get; set; }

    public string? PomWmkNazwa { get; set; }

    public int? PomWmkTyp { get; set; }

    public int? PomWmkWymTyp { get; set; }

    public string? PomWmkPoprzedniaNazwa { get; set; }

    public string PomWmkModyfikacja { get; set; } = null!;

    /// <summary>
    /// Kolumna przechowuje informację o orginalnym Ob_GIDTyp do którego dopinany jest atrybut analityczny
    /// </summary>
    public string? PomWmkGidtyp { get; set; }

    /// <summary>
    /// Wartosc kolumny AtOElement wskazująca na poziom atrybutu przenoszonego.
    /// </summary>
    public int? PomWmkElement { get; set; }

    /// <summary>
    /// Typ danych jakie przechowywane są w atrybucie.
    /// </summary>
    public string? PomWmkTypDanych { get; set; }

    public virtual WymCzasDzien PomWmkCzdg { get; set; } = null!;

    public virtual WymZrodloDanych PomWmkZrodg { get; set; } = null!;
}
