using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class SFktKosztySprzedazy
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KsprDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long KsprId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KsprInsertSubTransformationId { get; set; }

    public string? KsprOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KsprOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KsprTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KsprTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KsprUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int KsprUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    public int KsprCzdgid { get; set; }

    public int KsprRksgid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int KsprZrodgid { get; set; }

    public decimal? KsprMkoszt { get; set; }

    public int? KsprKierunek { get; set; }

    public string? KsprOrgAtrId { get; set; }

    public string? KsprOrgWymId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KsprPrmOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KsprRksOrgId { get; set; }

    public int? KsprTypKwoty { get; set; }

    public int? KsprWymTyp { get; set; }

    public int KsprDokNumerGid { get; set; }

    public int? KsprPozycjaId { get; set; }

    public int? KsprSubPozycjaId { get; set; }

    public int KsprDokWysylkiGid { get; set; }

    public virtual WymCzasDzien KsprCzdg { get; set; } = null!;

    public virtual WymDokumentNumer KsprDokNumerG { get; set; } = null!;

    public virtual WymDokumentNumer KsprDokWysylkiG { get; set; } = null!;

    public virtual WymRodzajKosztuSprzedazy KsprRksg { get; set; } = null!;

    public virtual WymZrodloDanych KsprZrodg { get; set; } = null!;
}
