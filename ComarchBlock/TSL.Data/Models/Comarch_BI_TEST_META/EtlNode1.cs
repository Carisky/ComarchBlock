using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class EtlNode1
{
    public int MenId { get; set; }

    public DateTime? MenTsinsert { get; set; }

    public string? MenModifiedBy { get; set; }

    public string? MenName { get; set; }

    public string? MenAction { get; set; }

    public int? MenIsMigrated { get; set; }

    public DateTime? MenTsmigrate { get; set; }

    public string? MenNameOld { get; set; }

    public int? MenEnid { get; set; }

    public int? MenParentEtlid { get; set; }

    public int? MenParentOldEtlid { get; set; }

    public int? MenIndex { get; set; }

    public int? MenIndexOld { get; set; }
}
