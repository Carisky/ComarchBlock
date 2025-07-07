using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymTerminWaznosciTyp
{
    public int TerminTypId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? TerminTypRowId { get; set; }

    public int? TerminTypWymTyp { get; set; }

    public int? TerminTypWymFirma { get; set; }

    public int? TerminTypPoprzednikId { get; set; }

    public string? TerminTypOrgAtrId { get; set; }

    public string? TerminTypOpis { get; set; }

    public string? TerminTypNazwa { get; set; }

    public int? TerminTypAktywny { get; set; }

    public string? TerminTypAktualneOrgParId { get; set; }

    public string? TerminTypAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int TerminTypZrodgid { get; set; }

    public DateTime TerminTypTsupdate { get; set; }

    public DateTime TerminTypTsinsert { get; set; }

    public int? TerminTypSubTransformationId { get; set; }

    public byte[] TerminTypRowVersion { get; set; } = null!;

    public int? TerminTypParId { get; set; }

    public string? TerminTypParDirtyOrgId { get; set; }

    public string? TerminTypOrgParId { get; set; }

    public string TerminTypOrgId { get; set; } = null!;

    public int? TerminTypKimball2CheckSum { get; set; }

    public int? TerminTypKimball1CheckSum { get; set; }

    public string TerminTypDirtyOrgId { get; set; } = null!;

    public int? TerminTypDataOd { get; set; }

    public int? TerminTypDataDo { get; set; }

    public int? SubWsadInsertId { get; set; }
}
