using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class Table1
{
    public int MtbId { get; set; }

    public DateTime? MtbTsinsert { get; set; }

    public string? MtbModifiedBy { get; set; }

    public string? MtbTableName { get; set; }

    public string? MtbAction { get; set; }

    public int? MtbIsMigrated { get; set; }

    public DateTime? MtbTsmigrate { get; set; }

    public string? MtbTableNameOld { get; set; }

    public int? MtbTblid { get; set; }
}
