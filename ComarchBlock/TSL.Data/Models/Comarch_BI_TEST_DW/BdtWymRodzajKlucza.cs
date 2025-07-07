using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymRodzajKlucza
{
    public int RklId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? RklRowId { get; set; }

    public int? RklWymTyp { get; set; }

    public int? RklWymFirma { get; set; }

    public int? RklPoprzednikId { get; set; }

    public string? RklOrgAtrId { get; set; }

    public string? RklOpis { get; set; }

    public string? RklNazwa { get; set; }

    public int? RklAktywny { get; set; }

    public string? RklAktualneOrgParId { get; set; }

    public string? RklAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int RklZrodgid { get; set; }

    public DateTime RklTsupdate { get; set; }

    public DateTime RklTsinsert { get; set; }

    public int? RklSubTransformationId { get; set; }

    public byte[] RklRowVersion { get; set; } = null!;

    public int? RklParId { get; set; }

    public string? RklParDirtyOrgId { get; set; }

    public string? RklOrgParId { get; set; }

    public string RklOrgId { get; set; } = null!;

    public int? RklKimball2CheckSum { get; set; }

    public int? RklKimball1CheckSum { get; set; }

    public string RklDirtyOrgId { get; set; } = null!;

    public int? RklDataOd { get; set; }

    public int? RklDataDo { get; set; }
}
