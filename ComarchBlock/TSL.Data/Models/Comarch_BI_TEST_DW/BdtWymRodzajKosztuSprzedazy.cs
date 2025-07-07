using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymRodzajKosztuSprzedazy
{
    public int RksId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? RksRowId { get; set; }

    public int? RksWymTyp { get; set; }

    public int? RksWymFirma { get; set; }

    public int? RksPoprzednikId { get; set; }

    public string? RksOrgParId { get; set; }

    public string? RksOrgAtrId { get; set; }

    public string? RksOpis { get; set; }

    public string RksNazwa { get; set; } = null!;

    public int? RksAktywny { get; set; }

    public string? RksAktualneOrgParId { get; set; }

    public string? RksAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int RksZrodgid { get; set; }

    public DateTime RksTsupdate { get; set; }

    public DateTime RksTsinsert { get; set; }

    public int? RksSubTransformationId { get; set; }

    public byte[] RksRowVersion { get; set; } = null!;

    public int? RksParId { get; set; }

    public string? RksParDirtyOrgId { get; set; }

    public string? RksParCleanOrgId { get; set; }

    public string RksOrgId { get; set; } = null!;

    public int? RksKimball2CheckSum { get; set; }

    public int? RksKimball1CheckSum { get; set; }

    public string RksDirtyOrgId { get; set; } = null!;

    public int? RksDataOd { get; set; }

    public int? RksDataDo { get; set; }
}
