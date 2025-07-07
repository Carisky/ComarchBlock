using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktDekretyAgr
{
    public int DtaId { get; set; }

    public int? WsadInsertId { get; set; }

    public decimal? DtaMkwotaMa { get; set; }

    public decimal? DtaMkwotaWn { get; set; }

    public int? DtaCzmid { get; set; }

    public int? DtaTypDekretu { get; set; }

    public string? DtaPomId { get; set; }

    public int? DtaZrodgid { get; set; }

    public int DtaCzdWprowadzeniaId { get; set; }
}
