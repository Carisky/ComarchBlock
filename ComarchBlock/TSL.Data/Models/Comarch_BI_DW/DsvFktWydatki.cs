using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktWydatki
{
    public int WydAlokacjaId { get; set; }

    public int? WydBudzetId { get; set; }

    public int WydCzdgid { get; set; }

    public string WydDirtyOrgId { get; set; } = null!;

    public long WydId { get; set; }

    public int? WydInsertSubTransformationId { get; set; }

    public int WydInsertTransformationId { get; set; }

    public int? WydKntId { get; set; }

    public decimal? WydMwartosc { get; set; }

    public string? WydOpis { get; set; }

    public string WydOrgId { get; set; } = null!;

    public int? WydPrcId { get; set; }

    public int? WydRejonId { get; set; }

    public int? WydRwdId { get; set; }

    public int? WydSamId { get; set; }

    public DateTime WydTsinsert { get; set; }

    public DateTime WydTsupdate { get; set; }

    public int? WydUpdateSubTransformationId { get; set; }

    public int WydUpdateTransformationId { get; set; }

    public int? WydWzwId { get; set; }

    public int WydZrodgid { get; set; }

    public int? WydStrPrwId { get; set; }

    public int WydDlggid { get; set; }
}
