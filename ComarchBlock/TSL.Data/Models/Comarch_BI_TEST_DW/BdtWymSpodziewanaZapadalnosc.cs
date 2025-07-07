using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymSpodziewanaZapadalnosc
{
    public int SpZapId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? SpZapRowId { get; set; }

    public int? SpZapWymTyp { get; set; }

    public int? SpZapWymFirma { get; set; }

    public string SpZapTypOrgId { get; set; } = null!;

    public int? SpZapPoprzednikId { get; set; }

    public string? SpZapOrgParId { get; set; }

    public string? SpZapOrgAtrId { get; set; }

    public string? SpZapOpis { get; set; }

    public int? SpZapOd { get; set; }

    public string? SpZapNazwa { get; set; }

    public int? SpZapDo { get; set; }

    public int? SpZapAktywny { get; set; }

    public string? SpZapAktualneOrgParId { get; set; }

    public string? SpZapAktualneOrgId { get; set; }

    public int? SpZapTypId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int SpZapZrodgid { get; set; }

    public DateTime SpZapTsupdate { get; set; }

    public DateTime SpZapTsinsert { get; set; }

    public int? SpZapSubTransformationId { get; set; }

    public byte[] SpZapRowVersion { get; set; } = null!;

    public int? SpZapParId { get; set; }

    public string? SpZapParDirtyOrgId { get; set; }

    public string? SpZapParCleanOrgId { get; set; }

    public string SpZapOrgId { get; set; } = null!;

    public int? SpZapKimball2CheckSum { get; set; }

    public int? SpZapKimball1CheckSum { get; set; }

    public string SpZapDirtyOrgId { get; set; } = null!;

    public int? SpZapDataOd { get; set; }

    public int? SpZapDataDo { get; set; }
}
