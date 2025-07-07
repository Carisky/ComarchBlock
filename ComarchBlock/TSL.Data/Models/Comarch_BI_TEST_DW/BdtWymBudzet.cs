using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymBudzet
{
    public int BudzetId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? BudzetRowId { get; set; }

    public int? BudzetWymTyp { get; set; }

    public int? BudzetWymFirma { get; set; }

    public string? BudzetTyp { get; set; }

    public int? BudzetPoprzednikId { get; set; }

    public string? BudzetOrgParId { get; set; }

    public string? BudzetOrgAtrId { get; set; }

    public string? BudzetOpis { get; set; }

    public string BudzetNazwa { get; set; } = null!;

    public int? BudzetAktywny { get; set; }

    public string? BudzetAktualneOrgParId { get; set; }

    public string? BudzetAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int BudzetZrodgid { get; set; }

    public DateTime BudzetTsupdate { get; set; }

    public DateTime BudzetTsinsert { get; set; }

    public int? BudzetSubTransformationId { get; set; }

    public byte[] BudzetRowVersion { get; set; } = null!;

    public int? BudzetParId { get; set; }

    public string? BudzetParDirtyOrgId { get; set; }

    public string? BudzetParCleanOrgId { get; set; }

    public string BudzetOrgId { get; set; } = null!;

    public int? BudzetKimball2CheckSum { get; set; }

    public int? BudzetKimball1CheckSum { get; set; }

    public string BudzetDirtyOrgId { get; set; } = null!;

    public int? BudzetDataOd { get; set; }

    public int? BudzetDataDo { get; set; }
}
