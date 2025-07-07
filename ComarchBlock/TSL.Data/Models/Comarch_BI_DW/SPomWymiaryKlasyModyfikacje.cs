using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class SPomWymiaryKlasyModyfikacje
{
    public string PomWmkDirtyOrgId { get; set; } = null!;

    public int PomWmkId { get; set; }

    public int? PomWmkInsertSubTransformationId { get; set; }

    public int PomWmkInsertTransformationId { get; set; }

    public string? PomWmkOpis { get; set; }

    public int PomWmkOrgId { get; set; }

    public DateTime PomWmkTsinsert { get; set; }

    public DateTime PomWmkTsupdate { get; set; }

    public int? PomWmkUpdateSubTransformationId { get; set; }

    public int PomWmkUpdateTransformationId { get; set; }

    public int PomWmkCzdgid { get; set; }

    public int PomWmkZrodgid { get; set; }

    public string? PomWmkNazwa { get; set; }

    public int? PomWmkTyp { get; set; }

    public int? PomWmkWymTyp { get; set; }

    public string? PomWmkGidTyp { get; set; }

    public int? PomWmkElement { get; set; }

    public string? PomWmkTypDanych { get; set; }

    public string? PomWmkPoprzedniaNazwa { get; set; }

    public string? PomWmkModyfikacja { get; set; }

    public int PomWmkTransId { get; set; }

    public virtual WymCzasDzien PomWmkCzdg { get; set; } = null!;

    public virtual WymZrodloDanych PomWmkZrodg { get; set; } = null!;
}
