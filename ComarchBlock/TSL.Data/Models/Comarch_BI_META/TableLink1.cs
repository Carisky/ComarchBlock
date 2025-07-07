using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class TableLink1
{
    public int MtlId { get; set; }

    public DateTime? MtlTsinsert { get; set; }

    public string? MtlModifiedBy { get; set; }

    public string? MtlName { get; set; }

    public string? MtlNameOld { get; set; }

    public string? MtlAction { get; set; }

    public int? MtlIsMigrated { get; set; }

    public DateTime? MtlTsmigrate { get; set; }

    public int? MtlTlid { get; set; }

    public int? MtlPsid { get; set; }

    public int? MtlTblid { get; set; }
}
