using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymCzasTydzien
{
    public int CztId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? CztRowId { get; set; }

    public string? TydzienRoboczyName { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? CztWymTyp { get; set; }

    public int? CztWymFirma { get; set; }

    public int? CztPoprzednikId { get; set; }

    public int? CztOrgParId { get; set; }

    public string? CztOrgAtrId { get; set; }

    public string? CztOpis { get; set; }

    public int? CztNrTygodnia { get; set; }

    public string? CztNazwa { get; set; }

    public int? CztCzrid { get; set; }

    public int? CztAktywny { get; set; }

    public int? CztAktualneOrgParId { get; set; }

    public int? CztAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int CztZrodgid { get; set; }

    public DateTime CztTsupdate { get; set; }

    public DateTime CztTsinsert { get; set; }

    public int? CztSubTransformationId { get; set; }

    public byte[] CztRowVersion { get; set; } = null!;

    public int? CztParId { get; set; }

    public string? CztParDirtyOrgId { get; set; }

    public string? CztParCleanOrgId { get; set; }

    public int? CztOrgId { get; set; }

    public int? CztKimball2CheckSum { get; set; }

    public int? CztKimball1CheckSum { get; set; }

    public string? CztDirtyOrgId { get; set; }

    public int? CztDataOd { get; set; }

    public int? CztDataDo { get; set; }
}
