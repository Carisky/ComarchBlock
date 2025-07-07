using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymDekretDziennik
{
    public int DtdzId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? DtdzRowId { get; set; }

    public string? DtdzStatus { get; set; }

    public int? DtdzWymTyp { get; set; }

    public int? DtdzWymFirma { get; set; }

    public int? DtdzPoprzednikId { get; set; }

    public string? DtdzOrgParId { get; set; }

    public string? DtdzOrgAtrId { get; set; }

    public string? DtdzOpis { get; set; }

    public string? DtdzNazwa { get; set; }

    public int? DtdzAktywny { get; set; }

    public string? DtdzAktualneOrgParId { get; set; }

    public string? DtdzAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int DtdzZrodgid { get; set; }

    public DateTime DtdzTsupdate { get; set; }

    public DateTime DtdzTsinsert { get; set; }

    public int? DtdzSubTransformationId { get; set; }

    public byte[] DtdzRowVersion { get; set; } = null!;

    public int? DtdzParId { get; set; }

    public string? DtdzParDirtyOrgId { get; set; }

    public string? DtdzParCleanOrgId { get; set; }

    public string DtdzOrgId { get; set; } = null!;

    public int? DtdzKimball2CheckSum { get; set; }

    public int? DtdzKimball1CheckSum { get; set; }

    public string DtdzDirtyOrgId { get; set; } = null!;

    public int? DtdzDataOd { get; set; }

    public int? DtdzDataDo { get; set; }
}
