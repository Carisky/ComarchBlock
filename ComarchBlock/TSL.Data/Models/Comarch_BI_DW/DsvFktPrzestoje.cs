using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktPrzestoje
{
    public int PrzDataZakonczeniaCzdgid { get; set; }

    public int PrzZasgid { get; set; }

    public int PrzJczgid { get; set; }

    public int PrzDataRozpoczeciaCzdgid { get; set; }

    public int PrzPrprzgid { get; set; }

    public int PrzOddgid { get; set; }

    public int PrzPrzyprzgid { get; set; }

    public int PrzTprzgid { get; set; }

    public int PrzId { get; set; }

    public int PrzZrodgid { get; set; }

    public int PrzCzdgid { get; set; }

    public string PrzOrgId { get; set; } = null!;

    public string PrzDirtyOrgId { get; set; } = null!;

    public string? PrzOpis { get; set; }

    public DateTime PrzTsinsert { get; set; }

    public DateTime PrzTsupdate { get; set; }

    public int PrzUpdateSubTransformationId { get; set; }

    public int? PrzUpdateTransformationId { get; set; }

    public int PrzInsertSubTransformationId { get; set; }

    public int? PrzInsertTransformationId { get; set; }

    public int? PrzMczasPrzestoju { get; set; }

    public int PrzBudzetGid { get; set; }

    public int PrzAlokacjaGid { get; set; }
}
