using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymSpodziewanaZapadalnoscTyp
{
    public int SpZapTypId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? SpZapTypRowId { get; set; }

    public int? SpZapTypWymTyp { get; set; }

    public int? SpZapTypWymFirma { get; set; }

    public int? SpZapTypPoprzednikId { get; set; }

    public string? SpZapTypOrgAtrId { get; set; }

    public string? SpZapTypOpis { get; set; }

    public string? SpZapTypNazwa { get; set; }

    public int? SpZapTypAktywny { get; set; }

    public string? SpZapTypAktualneOrgParId { get; set; }

    public string? SpZapTypAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int SpZapTypZrodgid { get; set; }

    public DateTime SpZapTypTsupdate { get; set; }

    public DateTime SpZapTypTsinsert { get; set; }

    public int? SpZapTypSubTransformationId { get; set; }

    public byte[] SpZapTypRowVersion { get; set; } = null!;

    public int? SpZapTypParId { get; set; }

    public string? SpZapTypParDirtyOrgId { get; set; }

    public string? SpZapTypOrgParId { get; set; }

    public string SpZapTypOrgId { get; set; } = null!;

    public int? SpZapTypKimball2CheckSum { get; set; }

    public int? SpZapTypKimball1CheckSum { get; set; }

    public string SpZapTypDirtyOrgId { get; set; } = null!;

    public int? SpZapTypDataOd { get; set; }

    public int? SpZapTypDataDo { get; set; }
}
