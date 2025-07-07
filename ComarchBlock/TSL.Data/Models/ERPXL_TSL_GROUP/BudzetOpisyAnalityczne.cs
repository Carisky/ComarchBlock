using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class BudzetOpisyAnalityczne
{
    public short? PomWymObjGidTyp { get; set; }

    public int? PomWymObjGidFirma { get; set; }

    public int? PomWymObjGidNumer { get; set; }

    public int? PomWymObjGidLp { get; set; }

    public int? PomWymObjGidDokLp { get; set; }

    public string? PomWymAuditUser { get; set; }

    public int? PomWymAuditTime { get; set; }

    public int? PomWymWsadInsertId { get; set; }

    public string? PomWymWymOrgId { get; set; }

    public string? PomWymObjOrgId { get; set; }

    public short? PomWymKierunek { get; set; }

    public short? PomWymTypKwoty { get; set; }

    public short? PomWymTypWymiaru { get; set; }

    public int? PomWymWymFirma { get; set; }

    public short? PomWymAktywny { get; set; }

    public decimal? PomWymWartosc { get; set; }

    public decimal? PomWymProcent { get; set; }
}
