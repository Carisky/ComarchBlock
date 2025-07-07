using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymZapadalnosc
{
    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? ZapAktualneOrgId { get; set; }

    public string? ZapAktualneOrgParId { get; set; }

    public int? ZapAktywny { get; set; }

    public int? ZapDataDo { get; set; }

    public int? ZapDataOd { get; set; }

    public string ZapDirtyOrgId { get; set; } = null!;

    public int? ZapDo { get; set; }

    public int ZapId { get; set; }

    public int? ZapKimball1CheckSum { get; set; }

    public int? ZapKimball2CheckSum { get; set; }

    public string? ZapNazwa { get; set; }

    public int? ZapOd { get; set; }

    public string? ZapOpis { get; set; }

    public string? ZapOrgAtrId { get; set; }

    public string ZapOrgId { get; set; } = null!;

    public string? ZapOrgParId { get; set; }

    public string? ZapParDirtyOrgId { get; set; }

    public int? ZapParId { get; set; }

    public int? ZapPoprzednikId { get; set; }

    public int? ZapRowId { get; set; }

    public byte[] ZapRowVersion { get; set; } = null!;

    public int? ZapSubTransformationId { get; set; }

    public DateTime ZapTsinsert { get; set; }

    public DateTime ZapTsupdate { get; set; }

    public int? ZapTypId { get; set; }

    public string ZapTypOrgId { get; set; } = null!;

    public int? ZapWymFirma { get; set; }

    public int? ZapWymTyp { get; set; }

    public int ZapZrodgid { get; set; }
}
