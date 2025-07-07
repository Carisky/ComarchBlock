using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymLokalizacja
{
    public int LokId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? LokRowId { get; set; }

    public int? LokWymTyp { get; set; }

    public int? LokWymFirma { get; set; }

    public string? LokSymbol { get; set; }

    public int? LokPoprzednikId { get; set; }

    public string? LokOrgParId { get; set; }

    public string? LokOrgAtrId { get; set; }

    public string? LokOpis { get; set; }

    public string? LokNazwa { get; set; }

    public int? LokAktywny { get; set; }

    public string? LokAktualneOrgParId { get; set; }

    public string? LokAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int LokZrodgid { get; set; }

    public DateTime LokTsupdate { get; set; }

    public DateTime LokTsinsert { get; set; }

    public int? LokSubTransformationId { get; set; }

    public byte[] LokRowVersion { get; set; } = null!;

    public int? LokParId { get; set; }

    public string? LokParDirtyOrgId { get; set; }

    public string? LokParCleanOrgId { get; set; }

    public string LokOrgId { get; set; } = null!;

    public int? LokKimball2CheckSum { get; set; }

    public int? LokKimball1CheckSum { get; set; }

    public string LokDirtyOrgId { get; set; } = null!;

    public int? LokDataOd { get; set; }

    public int? LokDataDo { get; set; }

    public int? LokOptimaId { get; set; }
}
