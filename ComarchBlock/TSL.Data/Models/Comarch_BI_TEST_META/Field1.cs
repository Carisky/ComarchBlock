using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class Field1
{
    public int MflId { get; set; }

    public DateTime? MflTsinsert { get; set; }

    public string? MflModifiedBy { get; set; }

    public int? MflTblid { get; set; }

    public string? MflAction { get; set; }

    public string? MflFieldNameOld { get; set; }

    public string? MflFieldNameNew { get; set; }

    public int? MflIsMigrated { get; set; }

    public DateTime? MflTsmigrate { get; set; }

    public int? MflFldid { get; set; }
}
