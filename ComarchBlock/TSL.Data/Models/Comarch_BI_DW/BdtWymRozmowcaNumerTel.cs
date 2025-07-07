using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymRozmowcaNumerTel
{
    public int RzmNrId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? RzmNrRowId { get; set; }

    public int? RzmNrWymTyp { get; set; }

    public int? RzmNrWymFirma { get; set; }

    public int? RzmNrPoprzednikId { get; set; }

    public string? RzmNrOrgAtrId { get; set; }

    public string? RzmNrOpis { get; set; }

    public string? RzmNrNumerTel { get; set; }

    public string? RzmNrNazwa { get; set; }

    public int? RzmNrAktywny { get; set; }

    public string? RzmNrAktualneOrgParId { get; set; }

    public string? RzmNrAktualneOrgId { get; set; }

    public int? RzmNrRzmNzwId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int RzmNrZrodgid { get; set; }

    public DateTime RzmNrTsupdate { get; set; }

    public DateTime RzmNrTsinsert { get; set; }

    public int? RzmNrSubTransformationId { get; set; }

    public byte[] RzmNrRowVersion { get; set; } = null!;

    public int? RzmNrParId { get; set; }

    public string? RzmNrParDirtyOrgId { get; set; }

    public string? RzmNrOrgParId { get; set; }

    public string RzmNrOrgId { get; set; } = null!;

    public int? RzmNrKimball2CheckSum { get; set; }

    public int? RzmNrKimball1CheckSum { get; set; }

    public string RzmNrDirtyOrgId { get; set; } = null!;

    public int? RzmNrDataOd { get; set; }

    public int? RzmNrDataDo { get; set; }
}
