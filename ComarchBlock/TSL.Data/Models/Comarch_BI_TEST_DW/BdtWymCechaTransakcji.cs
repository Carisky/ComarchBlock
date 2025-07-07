using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymCechaTransakcji
{
    public int ChtId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? ChtRowId { get; set; }

    public int? ChtWymTyp { get; set; }

    public int? ChtWymFirma { get; set; }

    public int? ChtPoprzednikId { get; set; }

    public string? ChtOrgParId { get; set; }

    public string? ChtOrgAtrId { get; set; }

    public string? ChtOpis { get; set; }

    public string? ChtNazwa { get; set; }

    public int? ChtAktywny { get; set; }

    public string? ChtAktualneOrgParId { get; set; }

    public string? ChtAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int ChtZrodgid { get; set; }

    public DateTime ChtTsupdate { get; set; }

    public DateTime ChtTsinsert { get; set; }

    public int? ChtSubTransformationId { get; set; }

    public byte[] ChtRowVersion { get; set; } = null!;

    public int? ChtParId { get; set; }

    public string? ChtParDirtyOrgId { get; set; }

    public string? ChtParCleanOrgId { get; set; }

    public string ChtOrgId { get; set; } = null!;

    public int? ChtKimball2CheckSum { get; set; }

    public int? ChtKimball1CheckSum { get; set; }

    public string ChtDirtyOrgId { get; set; } = null!;

    public int? ChtDataOd { get; set; }

    public int? ChtDataDo { get; set; }
}
