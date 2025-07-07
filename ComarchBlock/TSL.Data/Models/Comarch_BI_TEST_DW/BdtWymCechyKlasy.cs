using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymCechyKlasy
{
    public int CechaKlId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? CechaKlRowId { get; set; }

    public int? CechaKlZlisty { get; set; }

    public int? CechaKlZamknieta { get; set; }

    public int? CechaKlWymTyp { get; set; }

    public int? CechaKlWymFirma { get; set; }

    public int? CechaKlPoprzednikId { get; set; }

    public string? CechaKlOrgParId { get; set; }

    public string? CechaKlOrgAtrId { get; set; }

    public string? CechaKlOpis { get; set; }

    public string? CechaKlNazwa { get; set; }

    public int? CechaKlAktywny { get; set; }

    public string? CechaKlAktualneOrgParId { get; set; }

    public string? CechaKlAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int CechaKlZrodgid { get; set; }

    public DateTime CechaKlTsupdate { get; set; }

    public DateTime CechaKlTsinsert { get; set; }

    public int? CechaKlSubTransformationId { get; set; }

    public byte[] CechaKlRowVersion { get; set; } = null!;

    public int? CechaKlParId { get; set; }

    public string? CechaKlParDirtyOrgId { get; set; }

    public string? CechaKlParCleanOrgId { get; set; }

    public string CechaKlOrgId { get; set; } = null!;

    public int? CechaKlKimball2CheckSum { get; set; }

    public int? CechaKlKimball1CheckSum { get; set; }

    public string CechaKlDirtyOrgId { get; set; } = null!;

    public int? CechaKlDataOd { get; set; }

    public int? CechaKlDataDo { get; set; }
}
