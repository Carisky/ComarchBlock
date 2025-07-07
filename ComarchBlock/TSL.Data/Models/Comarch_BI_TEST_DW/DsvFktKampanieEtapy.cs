using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktKampanieEtapy
{
    public int KmpAlokacjaId { get; set; }

    public int KmpBudzetId { get; set; }

    public string KmpCleanOrgId { get; set; } = null!;

    public int KmpCrmetapId { get; set; }

    public int KmpCrmkampId { get; set; }

    public int KmpCzdid { get; set; }

    public int? KmpDataDoId { get; set; }

    public int? KmpDataOdId { get; set; }

    public string KmpDirtyOrgId { get; set; } = null!;

    public long KmpId { get; set; }

    public int? KmpInsertSubTransformationId { get; set; }

    public int KmpInsertTransformationId { get; set; }

    public decimal? KmpMiloscP { get; set; }

    public decimal? KmpMkosztP { get; set; }

    public decimal? KmpMliczbaProspektow { get; set; }

    public decimal? KmpMlkntAktWinnychKamp { get; set; }

    public decimal? KmpMlkntNaktWinnychKamp { get; set; }

    public decimal? KmpMprzychodO { get; set; }

    public decimal? KmpMprzychodP { get; set; }

    public decimal? KmpMszansaP { get; set; }

    public int KmpOpeId { get; set; }

    public string? KmpOpis { get; set; }

    public string? KmpOrgAtrId { get; set; }

    public DateTime KmpTsinsert { get; set; }

    public DateTime KmpTsupdate { get; set; }

    public int? KmpUpdateSubTransformationId { get; set; }

    public int KmpUpdateTransformationId { get; set; }

    public int KmpZrodgid { get; set; }
}
