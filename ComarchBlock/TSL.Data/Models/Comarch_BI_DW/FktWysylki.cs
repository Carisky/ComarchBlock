using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktWysylki
{
    public int WysId { get; set; }

    public int WysZrodgid { get; set; }

    public int WysCzdgid { get; set; }

    public string WysOrgId { get; set; } = null!;

    public string WysDirtyOrgId { get; set; } = null!;

    public string? WysOpis { get; set; }

    public int? WysUpdateTransformationId { get; set; }

    public int WysUpdateSubTransformationId { get; set; }

    public int? WysInsertTransformationId { get; set; }

    public int WysInsertSubTransformationId { get; set; }

    public DateTime WysTsinsert { get; set; }

    public DateTime WysTsupdate { get; set; }

    public int WysAlokacjaGid { get; set; }

    public int WysBudzetGid { get; set; }

    public int WysDokNumerGid { get; set; }

    public int WysCzddostawaOdGid { get; set; }

    public int WysWysygid { get; set; }

    public int WysCzddostawaDoGid { get; set; }

    public int WysTragid { get; set; }

    public int WysKntGid { get; set; }

    public int WysSamgid { get; set; }

    public decimal? WysMwagaBrutto { get; set; }

    public decimal? WysMwagaNetto { get; set; }

    public decimal? WysMobjetosc { get; set; }

    public decimal? WysMrzeczIloscPaczek { get; set; }

    public decimal? WysMkoszt { get; set; }
}
