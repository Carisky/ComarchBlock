using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymFormyPlatnosciTyp
{
    public int FormPlatTypId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? FormPlatTypRowId { get; set; }

    public int? FormPlatTypWymTyp { get; set; }

    public int? FormPlatTypWymFirma { get; set; }

    public int? FormPlatTypPoprzednikId { get; set; }

    public string? FormPlatTypOrgParId { get; set; }

    public string? FormPlatTypOrgAtrId { get; set; }

    public string? FormPlatTypOpis { get; set; }

    public string? FormPlatTypNazwa { get; set; }

    public int? FormPlatTypAktywny { get; set; }

    public string? FormPlatTypAktualneOrgParId { get; set; }

    public string? FormPlatTypAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int FormPlatTypZrodgid { get; set; }

    public DateTime FormPlatTypTsupdate { get; set; }

    public DateTime FormPlatTypTsinsert { get; set; }

    public int? FormPlatTypSubTransformationId { get; set; }

    public byte[] FormPlatTypRowVersion { get; set; } = null!;

    public int? FormPlatTypParId { get; set; }

    public string? FormPlatTypParDirtyOrgId { get; set; }

    public string? FormPlatTypParCleanOrgId { get; set; }

    public string FormPlatTypOrgId { get; set; } = null!;

    public int? FormPlatTypKimball2CheckSum { get; set; }

    public int? FormPlatTypKimball1CheckSum { get; set; }

    public string FormPlatTypDirtyOrgId { get; set; } = null!;

    public int? FormPlatTypDataOd { get; set; }

    public int? FormPlatTypDataDo { get; set; }
}
