using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktDekretyAgr
{
    public int? DtaZrodgid { get; set; }

    public long DtaId { get; set; }

    public string? DtaPomId { get; set; }

    public int? DtaTypDekretu { get; set; }

    public int? DtaCzmid { get; set; }

    public decimal? DtaMkwotaWn { get; set; }

    public decimal? DtaMkwotaMa { get; set; }

    public int? WsadInsertId { get; set; }

    public int? DtaCzdWprowadzeniaId { get; set; }
}
