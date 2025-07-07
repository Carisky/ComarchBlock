using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktFlotum
{
    public int FloAlokacjaGid { get; set; }

    public int FloBudzetGid { get; set; }

    public int FloCzdgid { get; set; }

    public int FloCzggid { get; set; }

    public string FloDirtyOrgId { get; set; } = null!;

    public int FloFlsgid { get; set; }

    public int FloFltgid { get; set; }

    public int FloId { get; set; }

    public int FloInsertSubTransformationId { get; set; }

    public int? FloInsertTransformationId { get; set; }

    public int FloJczgid { get; set; }

    public decimal? FloMczasTrwania { get; set; }

    public decimal? FloMdystans { get; set; }

    public decimal? FloMpredkoscMax { get; set; }

    public string? FloOpis { get; set; }

    public string FloOrgId { get; set; } = null!;

    public int FloPrcGid { get; set; }

    public DateTime FloTsinsert { get; set; }

    public DateTime FloTsupdate { get; set; }

    public int FloUpdateSubTransformationId { get; set; }

    public int? FloUpdateTransformationId { get; set; }

    public int FloZrodgid { get; set; }
}
