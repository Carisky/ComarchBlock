using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymStrefaTel
{
    public int? StrefaDataDo { get; set; }

    public int? StrefaDataOd { get; set; }

    public string StrefaDirtyOrgId { get; set; } = null!;

    public int StrefaId { get; set; }

    public int? StrefaKimball1CheckSum { get; set; }

    public int? StrefaKimball2CheckSum { get; set; }

    public string StrefaOrgId { get; set; } = null!;

    public string? StrefaOrgParId { get; set; }

    public string? StrefaParDirtyOrgId { get; set; }

    public int? StrefaParId { get; set; }

    public int StrefaRowId { get; set; }

    public byte[] StrefaRowVersion { get; set; } = null!;

    public int? StrefaSubTransformationId { get; set; }

    public DateTime StrefaTsinsert { get; set; }

    public DateTime StrefaTsupdate { get; set; }

    public int StrefaZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? StrefaAktualneOrgId { get; set; }

    public string? StrefaAktualneOrgParId { get; set; }

    public int? StrefaAktywny { get; set; }

    public string? StrefaNazwa { get; set; }

    public string? StrefaOpis { get; set; }

    public string? StrefaOrgAtrId { get; set; }

    public int? StrefaPoprzednikId { get; set; }

    public int? StrefaWymFirma { get; set; }

    public int? StrefaWymTyp { get; set; }

    public virtual WymZrodloDanych StrefaZrodg { get; set; } = null!;
}
