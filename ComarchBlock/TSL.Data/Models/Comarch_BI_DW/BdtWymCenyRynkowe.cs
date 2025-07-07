using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymCenyRynkowe
{
    public int CenaRynId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? CenaRynRowId { get; set; }

    public int? CenaRynWymTyp { get; set; }

    public int? CenaRynWymFirma { get; set; }

    public int? CenaRynPoprzednikId { get; set; }

    public string? CenaRynOrgParId { get; set; }

    public string? CenaRynOrgAtrId { get; set; }

    public string? CenaRynOpis { get; set; }

    public int? CenaRynNumer { get; set; }

    public string? CenaRynNazwa { get; set; }

    public int? CenaRynAktywny { get; set; }

    public string? CenaRynAktualneOrgParId { get; set; }

    public string? CenaRynAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int CenaRynZrodgid { get; set; }

    public DateTime CenaRynTsupdate { get; set; }

    public DateTime CenaRynTsinsert { get; set; }

    public int? CenaRynSubTransformationId { get; set; }

    public byte[] CenaRynRowVersion { get; set; } = null!;

    public int? CenaRynParId { get; set; }

    public string? CenaRynParDirtyOrgId { get; set; }

    public string? CenaRynParCleanOrgId { get; set; }

    public string CenaRynOrgId { get; set; } = null!;

    public int? CenaRynKimball2CheckSum { get; set; }

    public int? CenaRynKimball1CheckSum { get; set; }

    public string CenaRynDirtyOrgId { get; set; } = null!;

    public int? CenaRynDataOd { get; set; }

    public int? CenaRynDataDo { get; set; }
}
