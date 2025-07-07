using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymGmina
{
    public int GminaId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? GminaRowId { get; set; }

    public int? GminaWymTyp { get; set; }

    public int? GminaWymFirma { get; set; }

    public int? GminaPoprzednikId { get; set; }

    public string? GminaOrgAtrId { get; set; }

    public string? GminaOpis { get; set; }

    public string GminaNazwa { get; set; } = null!;

    public int? GminaAktywny { get; set; }

    public string? GminaAktualneOrgParId { get; set; }

    public string? GminaAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int GminaZrodgid { get; set; }

    public DateTime GminaTsupdate { get; set; }

    public DateTime GminaTsinsert { get; set; }

    public int? GminaSubTransformationId { get; set; }

    public byte[] GminaRowVersion { get; set; } = null!;

    public int? GminaParId { get; set; }

    public string? GminaParDirtyOrgId { get; set; }

    public string? GminaOrgParId { get; set; }

    public string GminaOrgId { get; set; } = null!;

    public int? GminaKimball2CheckSum { get; set; }

    public int? GminaKimball1CheckSum { get; set; }

    public string GminaDirtyOrgId { get; set; } = null!;

    public int? GminaDataOd { get; set; }

    public int? GminaDataDo { get; set; }
}
