using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class DataMiningTransaltion
{
    public int DmtId { get; set; }

    public string DmtName { get; set; } = null!;

    public string DmtFriendlyNameTranslated { get; set; } = null!;

    public string DmtDescriptionTranslated { get; set; } = null!;

    public string DmtCollationName { get; set; } = null!;

    public string DmtObjectType { get; set; } = null!;

    public string DmtStructureName { get; set; } = null!;

    public string? DmtModelName { get; set; }
}
