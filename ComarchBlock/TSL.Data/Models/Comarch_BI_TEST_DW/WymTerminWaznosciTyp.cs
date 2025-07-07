using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymTerminWaznosciTyp
{
    public int? SubWsadInsertId { get; set; }

    public int? TerminTypDataDo { get; set; }

    public int? TerminTypDataOd { get; set; }

    public string TerminTypDirtyOrgId { get; set; } = null!;

    public int TerminTypId { get; set; }

    public int? TerminTypKimball1CheckSum { get; set; }

    public int? TerminTypKimball2CheckSum { get; set; }

    public string TerminTypOrgId { get; set; } = null!;

    public string? TerminTypOrgParId { get; set; }

    public string? TerminTypParDirtyOrgId { get; set; }

    public int? TerminTypParId { get; set; }

    public int TerminTypRowId { get; set; }

    public byte[] TerminTypRowVersion { get; set; } = null!;

    public int? TerminTypSubTransformationId { get; set; }

    public DateTime TerminTypTsinsert { get; set; }

    public DateTime TerminTypTsupdate { get; set; }

    public int TerminTypZrodgid { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? TerminTypAktualneOrgId { get; set; }

    public string? TerminTypAktualneOrgParId { get; set; }

    public int? TerminTypAktywny { get; set; }

    public string? TerminTypNazwa { get; set; }

    public string? TerminTypOpis { get; set; }

    public string? TerminTypOrgAtrId { get; set; }

    public int? TerminTypPoprzednikId { get; set; }

    public int? TerminTypWymFirma { get; set; }

    public int? TerminTypWymTyp { get; set; }

    public virtual WymZrodloDanych TerminTypZrodg { get; set; } = null!;

    public virtual ICollection<WymTerminWaznosci> WymTerminWaznoscis { get; set; } = new List<WymTerminWaznosci>();
}
