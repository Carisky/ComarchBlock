using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymWojewodztwo
{
    public int WojId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? WojRowId { get; set; }

    public int? WojWymTyp { get; set; }

    public int? WojWymFirma { get; set; }

    public int? WojPoprzednikId { get; set; }

    public string? WojOrgParId { get; set; }

    public string? WojOrgAtrId { get; set; }

    public string? WojOpis { get; set; }

    public string? WojNazwa { get; set; }

    public int? WojAktywny { get; set; }

    public string? WojAktualneOrgParId { get; set; }

    public string? WojAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int WojZrodgid { get; set; }

    public DateTime WojTsupdate { get; set; }

    public DateTime WojTsinsert { get; set; }

    public int? WojSubTransformationId { get; set; }

    public byte[] WojRowVersion { get; set; } = null!;

    public int? WojParId { get; set; }

    public string? WojParDirtyOrgId { get; set; }

    public string? WojParCleanOrgId { get; set; }

    public string WojOrgId { get; set; } = null!;

    public int? WojKimball2CheckSum { get; set; }

    public int? WojKimball1CheckSum { get; set; }

    public string WojDirtyOrgId { get; set; } = null!;

    public int? WojDataOd { get; set; }

    public int? WojDataDo { get; set; }

    public int? SubWsadInsertId { get; set; }
}
