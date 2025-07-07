using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktKampanieEtapy
{
    public int? KmpDataOdId { get; set; }

    public int? KmpDataDoId { get; set; }

    public int KmpCrmetapId { get; set; }

    public int KmpOpeId { get; set; }

    public int KmpCrmkampId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long KmpId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int KmpZrodgid { get; set; }

    public int KmpCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KmpCleanOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KmpDirtyOrgId { get; set; } = null!;

    public string? KmpOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int KmpUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KmpUpdateSubTransformationId { get; set; }

    public int KmpInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KmpInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KmpTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KmpTsupdate { get; set; }

    public decimal? KmpMprzychodP { get; set; }

    public decimal? KmpMiloscP { get; set; }

    public decimal? KmpMkosztP { get; set; }

    public decimal? KmpMszansaP { get; set; }

    public decimal? KmpMlkntAktWinnychKamp { get; set; }

    public decimal? KmpMlkntNaktWinnychKamp { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int KmpBudzetId { get; set; }

    public string? KmpOrgAtrId { get; set; }

    public decimal? KmpMprzychodO { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int KmpAlokacjaId { get; set; }

    public decimal? KmpMliczbaProspektow { get; set; }

    public virtual WymAlokacja KmpAlokacja { get; set; } = null!;

    public virtual WymBudzet KmpBudzet { get; set; } = null!;

    public virtual WymCrmetapy KmpCrmetap { get; set; } = null!;

    public virtual WymCrmkampanium KmpCrmkamp { get; set; } = null!;

    public virtual WymCzasDzien KmpCzd { get; set; } = null!;

    public virtual WymCzasDzien? KmpDataDo { get; set; }

    public virtual WymCzasDzien? KmpDataOd { get; set; }

    public virtual WymOperator KmpOpe { get; set; } = null!;

    public virtual WymZrodloDanych KmpZrodg { get; set; } = null!;
}
