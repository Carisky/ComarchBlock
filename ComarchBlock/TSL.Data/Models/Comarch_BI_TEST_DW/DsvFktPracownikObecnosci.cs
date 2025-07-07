using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktPracownikObecnosci
{
    public int? PobPrcGid { get; set; }

    public int PobObegid { get; set; }

    public int PobProjektId { get; set; }

    public int PobStrFrmId { get; set; }

    public int PobId { get; set; }

    public int PobCzdgid { get; set; }

    public int PobZrodgid { get; set; }

    public string PobOrgId { get; set; } = null!;

    public string PobDirtyOrgId { get; set; } = null!;

    public string? PobOpis { get; set; }

    public DateTime PobTsinsert { get; set; }

    public DateTime PobTsupdate { get; set; }

    public int PobUpdateSubTransformationId { get; set; }

    public int? PobUpdateTransformationId { get; set; }

    public int PobInsertSubTransformationId { get; set; }

    public int? PobInsertTransformationId { get; set; }

    public decimal? PobMliczbaDni { get; set; }

    public decimal? PobMliczbaGodzin { get; set; }

    public int PobPerspektywaId { get; set; }

    public int PobAlokacjaId { get; set; }

    public int PobBudzetId { get; set; }
}
