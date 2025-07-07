using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymKategorieRynkowe
{
    public int KatRynId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? KatRynRowId { get; set; }

    public int? KatRynWymTyp { get; set; }

    public int? KatRynWymFirma { get; set; }

    public int? KatRynPoprzednikId { get; set; }

    public string? KatRynOrgParId { get; set; }

    public string? KatRynOrgAtrId { get; set; }

    public string? KatRynOpis { get; set; }

    public string? KatRynNazwa { get; set; }

    public int? KatRynAktywny { get; set; }

    public string? KatRynAktualneOrgParId { get; set; }

    public string? KatRynAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int KatRynZrodgid { get; set; }

    public DateTime KatRynTsupdate { get; set; }

    public DateTime KatRynTsinsert { get; set; }

    public int? KatRynSubTransformationId { get; set; }

    public byte[] KatRynRowVersion { get; set; } = null!;

    public int? KatRynParId { get; set; }

    public string? KatRynParDirtyOrgId { get; set; }

    public string? KatRynParCleanOrgId { get; set; }

    public string KatRynOrgId { get; set; } = null!;

    public int? KatRynKimball2CheckSum { get; set; }

    public int? KatRynKimball1CheckSum { get; set; }

    public string KatRynDirtyOrgId { get; set; } = null!;

    public int? KatRynDataOd { get; set; }

    public int? KatRynDataDo { get; set; }
}
