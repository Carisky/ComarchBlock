using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class Relation1
{
    public int MreId { get; set; }

    public int? MreFirstFieldId { get; set; }

    public DateTime? MreTsinsert { get; set; }

    public DateTime? MreTsmigrate { get; set; }

    public int? MreIsMigrated { get; set; }

    public string? MreAction { get; set; }

    public string? MreModifiedBy { get; set; }

    public int? MreRelid { get; set; }
}
