using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktMagazynyNormatywy
{
    public long MnrId { get; set; }

    public int MnrAbcid { get; set; }

    public int MnrAlokacjaId { get; set; }

    public int? MnrBudzetId { get; set; }

    public int? MnrWymTyp { get; set; }

    public int? MnrTypKwoty { get; set; }

    public string? MnrOrgWymId { get; set; }

    public string? MnrOrgAtrId { get; set; }

    public int? MnrKierunek { get; set; }

    public decimal? MnrMiloscZam { get; set; }

    public decimal? MnrMiloscMin { get; set; }

    public decimal? MnrMiloscMax { get; set; }

    public int MnrZrodgid { get; set; }

    public int MnrProdId { get; set; }

    public int MnrMagId { get; set; }

    public int MnrFirmaId { get; set; }

    public int MnrCzmid { get; set; }

    public int MnrCzdid { get; set; }

    public int? WsadInsertId { get; set; }

    public int MnrUpdateTransformationId { get; set; }

    public int? MnrUpdateSubTransformationId { get; set; }

    public DateTime MnrTsupdate { get; set; }

    public DateTime MnrTsinsert { get; set; }

    public string MnrOrgId { get; set; } = null!;

    public string? MnrOpis { get; set; }

    public int? MnrInsertSubTransformationId { get; set; }

    public string MnrDirtyOrgId { get; set; } = null!;

    public int MnrPrmgid { get; set; }
}
