using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymSprawy
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SprawyDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SprawyDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string SprawyDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int SprawyId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SprawyKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SprawyKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string SprawyOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SprawyParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SprawyParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SprawyParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int SprawyRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] SprawyRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SprawySubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime SprawyTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime SprawyTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int SprawyZrodgid { get; set; }

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
    public string? SprawyAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SprawyAktualneOrgParId { get; set; }

    public int? SprawyAktywny { get; set; }

    public string SprawyNazwa { get; set; } = null!;

    public string? SprawyNumer { get; set; }

    public string? SprawyNumerSeryjny { get; set; }

    public string? SprawyOpis { get; set; }

    public string? SprawyOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SprawyOrgParId { get; set; }

    public int? SprawyPoprzednikId { get; set; }

    public int? SprawyPriorytet { get; set; }

    public string? SprawyRozliczenie { get; set; }

    public string? SprawyStatus { get; set; }

    public string? SprawyStreszczenie { get; set; }

    public int? SprawyWymFirma { get; set; }

    public int? SprawyWymTyp { get; set; }

    public virtual WymZrodloDanych SprawyZrodg { get; set; } = null!;
}
