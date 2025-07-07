using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class SPomOpisyAnalityczne
{
    public string? PomWymDirtyOrgId { get; set; }

    public long PomWymId { get; set; }

    public int? PomWymInsertSubTransformationId { get; set; }

    public string PomWymObjOrgId { get; set; } = null!;

    public string? PomWymOpis { get; set; }

    public DateTime PomWymTsinsert { get; set; }

    public DateTime PomWymTsupdate { get; set; }

    public int? PomWymUpdateSubTransformationId { get; set; }

    public int PomWymUpdateTransformationId { get; set; }

    public int? WsadInsertId { get; set; }

    public int PomWymCzdgid { get; set; }

    public int PomWymZrodgid { get; set; }

    public int? PomWymAktywny { get; set; }

    public int? PomWymKierunek { get; set; }

    public int? PomWymObjGidBudzet { get; set; }

    public int? PomWymObjGidDokLp { get; set; }

    public int? PomWymObjGidLp { get; set; }

    public int? PomWymObjGidNumer { get; set; }

    public int? PomWymObjGidTyp { get; set; }

    public string? PomWymOrgParId { get; set; }

    public decimal? PomWymProcent { get; set; }

    public int? PomWymTypKwoty { get; set; }

    public int? PomWymTypWymiaru { get; set; }

    public decimal? PomWymWartosc { get; set; }

    public int? PomWymWymFirma { get; set; }

    public int? PomWymWymId { get; set; }

    public string? PomWymWymOrgId { get; set; }

    public virtual WymCzasDzien PomWymCzdg { get; set; } = null!;

    public virtual WymZrodloDanych PomWymZrodg { get; set; } = null!;
}
