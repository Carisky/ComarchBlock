using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymStazKlientum
{
    public int StazId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? StazRowId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? StazWymTyp { get; set; }

    public int? StazWymFirma { get; set; }

    public string StazTypOrgId { get; set; } = null!;

    public int? StazPoprzednikId { get; set; }

    public string? StazOrgParId { get; set; }

    public string? StazOrgAtrId { get; set; }

    public string? StazOpis { get; set; }

    public int? StazOd { get; set; }

    public string? StazNazwa { get; set; }

    public int? StazDo { get; set; }

    public int? StazAktywny { get; set; }

    public string? StazAktualneOrgParId { get; set; }

    public string? StazAktualneOrgId { get; set; }

    public int? StazTypId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int StazZrodgid { get; set; }

    public DateTime StazTsupdate { get; set; }

    public DateTime StazTsinsert { get; set; }

    public int? StazSubTransformationId { get; set; }

    public byte[] StazRowVersion { get; set; } = null!;

    public int? StazParId { get; set; }

    public string? StazParDirtyOrgId { get; set; }

    public string? StazParCleanOrgId { get; set; }

    public string? StazOrgId { get; set; }

    public int? StazKimball2CheckSum { get; set; }

    public int? StazKimball1CheckSum { get; set; }

    public string StazDirtyOrgId { get; set; } = null!;

    public int? StazDataOd { get; set; }

    public int? StazDataDo { get; set; }
}
