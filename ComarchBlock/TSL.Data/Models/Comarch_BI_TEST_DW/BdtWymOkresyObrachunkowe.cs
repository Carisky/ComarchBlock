using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymOkresyObrachunkowe
{
    public int OkrId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? OkrRowId { get; set; }

    public int? FaktOkr { get; set; }

    public int? OkrWymTyp { get; set; }

    public int? OkrWymFirma { get; set; }

    public int? OkrPoprzednikId { get; set; }

    public int? OkrPoczatek { get; set; }

    public string? OkrOrgAtrId { get; set; }

    public string? OkrOpis { get; set; }

    public string? OkrNazwa { get; set; }

    public int? OkrKoniec { get; set; }

    public string? OkrBiezacy { get; set; }

    public int? OkrAktywny { get; set; }

    public string? OkrAktualneOrgParId { get; set; }

    public string? OkrAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int OkrZrodgid { get; set; }

    public DateTime OkrTsupdate { get; set; }

    public DateTime OkrTsinsert { get; set; }

    public int? OkrSubTransformationId { get; set; }

    public byte[] OkrRowVersion { get; set; } = null!;

    public int? OkrParId { get; set; }

    public string? OkrParDirtyOrgId { get; set; }

    public string? OkrOrgParId { get; set; }

    public string OkrOrgId { get; set; } = null!;

    public int? OkrKimball2CheckSum { get; set; }

    public int? OkrKimball1CheckSum { get; set; }

    public string OkrDirtyOrgId { get; set; } = null!;

    public int? OkrDataOd { get; set; }

    public int? OkrDataDo { get; set; }
}
