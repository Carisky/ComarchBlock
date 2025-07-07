using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymCzasRok
{
    public int CzrId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? CzrRowId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? CzrWymTyp { get; set; }

    public int? CzrWymFirma { get; set; }

    public int? CzrPoprzednikId { get; set; }

    public int? CzrOrgParId { get; set; }

    public string? CzrOrgAtrId { get; set; }

    public string? CzrOpis { get; set; }

    public string? CzrNazwa { get; set; }

    public int? CzrCzrrok { get; set; }

    public int? CzrAktywny { get; set; }

    public int? CzrAktualneOrgParId { get; set; }

    public int? CzrAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int CzrZrodgid { get; set; }

    public DateTime CzrTsupdate { get; set; }

    public DateTime CzrTsinsert { get; set; }

    public int? CzrSubTransformationId { get; set; }

    public byte[] CzrRowVersion { get; set; } = null!;

    public int? CzrParId { get; set; }

    public string? CzrParDirtyOrgId { get; set; }

    public string? CzrParCleanOrgId { get; set; }

    public int? CzrOrgId { get; set; }

    public int? CzrKimball2CheckSum { get; set; }

    public int? CzrKimball1CheckSum { get; set; }

    public string? CzrDirtyOrgId { get; set; }

    public int? CzrDataOd { get; set; }

    public int? CzrDataDo { get; set; }
}
