using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymZaleganieTyp
{
    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? ZaleganieTypDataDo { get; set; }

    public int? ZaleganieTypDataOd { get; set; }

    public string ZaleganieTypDirtyOrgId { get; set; } = null!;

    public int ZaleganieTypId { get; set; }

    public int? ZaleganieTypKimball1CheckSum { get; set; }

    public int? ZaleganieTypKimball2CheckSum { get; set; }

    public string ZaleganieTypOrgId { get; set; } = null!;

    public string? ZaleganieTypOrgParId { get; set; }

    public string? ZaleganieTypParDirtyOrgId { get; set; }

    public int? ZaleganieTypParId { get; set; }

    public int ZaleganieTypRowId { get; set; }

    public byte[] ZaleganieTypRowVersion { get; set; } = null!;

    public int? ZaleganieTypSubTransformationId { get; set; }

    public DateTime ZaleganieTypTsinsert { get; set; }

    public DateTime ZaleganieTypTsupdate { get; set; }

    public int ZaleganieTypZrodgid { get; set; }

    public string? ZaleganieTypAktualneOrgId { get; set; }

    public string? ZaleganieTypAktualneOrgParId { get; set; }

    public int? ZaleganieTypAktywny { get; set; }

    public string? ZaleganieTypNazwa { get; set; }

    public string? ZaleganieTypOpis { get; set; }

    public string? ZaleganieTypOrgAtrId { get; set; }

    public int? ZaleganieTypPoprzednikId { get; set; }

    public int? ZaleganieTypWymFirma { get; set; }

    public int? ZaleganieTypWymTyp { get; set; }

    public virtual ICollection<WymZaleganie> WymZaleganies { get; set; } = new List<WymZaleganie>();

    public virtual WymZrodloDanych ZaleganieTypZrodg { get; set; } = null!;
}
