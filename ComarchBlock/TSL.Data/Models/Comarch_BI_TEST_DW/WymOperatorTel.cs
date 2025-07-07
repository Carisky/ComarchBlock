using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymOperatorTel
{
    public int? OperDataDo { get; set; }

    public int? OperDataOd { get; set; }

    public string OperDirtyOrgId { get; set; } = null!;

    public int OperId { get; set; }

    public int? OperKimball1CheckSum { get; set; }

    public int? OperKimball2CheckSum { get; set; }

    public string OperOrgId { get; set; } = null!;

    public string? OperOrgParId { get; set; }

    public string? OperParDirtyOrgId { get; set; }

    public int? OperParId { get; set; }

    public int OperRowId { get; set; }

    public byte[] OperRowVersion { get; set; } = null!;

    public int? OperSubTransformationId { get; set; }

    public DateTime OperTsinsert { get; set; }

    public DateTime OperTsupdate { get; set; }

    public int OperZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? OperAktualneOrgId { get; set; }

    public string? OperAktualneOrgParId { get; set; }

    public int? OperAktywny { get; set; }

    public string? OperNazwa { get; set; }

    public string? OperOpis { get; set; }

    public string? OperOrgAtrId { get; set; }

    public int? OperPoprzednikId { get; set; }

    public string? OperTyp { get; set; }

    public int? OperWymFirma { get; set; }

    public int? OperWymTyp { get; set; }

    public virtual WymZrodloDanych OperZrodg { get; set; } = null!;
}
