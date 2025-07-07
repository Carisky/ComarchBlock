using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymRozmowcaNazwaTel
{
    public int RzmNzwId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? RzmNzwRowId { get; set; }

    public int? RzmNzwWymTyp { get; set; }

    public int? RzmNzwWymFirma { get; set; }

    public int? RzmNzwPoprzednikId { get; set; }

    public string? RzmNzwOrgAtrId { get; set; }

    public string? RzmNzwOpis { get; set; }

    public string? RzmNzwNazwa { get; set; }

    public int? RzmNzwAktywny { get; set; }

    public string? RzmNzwAktualneOrgParId { get; set; }

    public string? RzmNzwAktualneOrgId { get; set; }

    public int? RzmNzwRzmRodzId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int RzmNzwZrodgid { get; set; }

    public DateTime RzmNzwTsupdate { get; set; }

    public DateTime RzmNzwTsinsert { get; set; }

    public int? RzmNzwSubTransformationId { get; set; }

    public byte[] RzmNzwRowVersion { get; set; } = null!;

    public int? RzmNzwParId { get; set; }

    public string? RzmNzwParDirtyOrgId { get; set; }

    public string? RzmNzwOrgParId { get; set; }

    public string RzmNzwOrgId { get; set; } = null!;

    public int? RzmNzwKimball2CheckSum { get; set; }

    public int? RzmNzwKimball1CheckSum { get; set; }

    public string RzmNzwDirtyOrgId { get; set; } = null!;

    public int? RzmNzwDataOd { get; set; }

    public int? RzmNzwDataDo { get; set; }
}
