using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymZapadalnoscTyp
{
    public int ZapTypId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? ZapTypRowId { get; set; }

    public int? ZapTypWymTyp { get; set; }

    public int? ZapTypWymFirma { get; set; }

    public int? ZapTypPoprzednikId { get; set; }

    public string? ZapTypOrgAtrId { get; set; }

    public string? ZapTypOpis { get; set; }

    public string? ZapTypNazwa { get; set; }

    public int? ZapTypAktywny { get; set; }

    public string? ZapTypAktualneOrgParId { get; set; }

    public string? ZapTypAktualneOrgId { get; set; }

    public int ZapTypZrodgid { get; set; }

    public DateTime ZapTypTsupdate { get; set; }

    public DateTime ZapTypTsinsert { get; set; }

    public int? ZapTypSubTransformationId { get; set; }

    public byte[] ZapTypRowVersion { get; set; } = null!;

    public int? ZapTypParId { get; set; }

    public string? ZapTypParDirtyOrgId { get; set; }

    public string? ZapTypOrgParId { get; set; }

    public string ZapTypOrgId { get; set; } = null!;

    public int? ZapTypKimball2CheckSum { get; set; }

    public int? ZapTypKimball1CheckSum { get; set; }

    public string ZapTypDirtyOrgId { get; set; } = null!;

    public int? ZapTypDataOd { get; set; }

    public int? ZapTypDataDo { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }
}
