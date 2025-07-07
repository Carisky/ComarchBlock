using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class CorrectionRuleValueToReplace
{
    public int CrvId { get; set; }

    public int CrvCrrid { get; set; }

    public string CrvValueBefore { get; set; } = null!;

    public string CrvDirtyOrgId { get; set; } = null!;

    public string? CrvDtdgid { get; set; }

    public bool CrvEnabled { get; set; }

    public virtual CorrectionRule CrvCrr { get; set; } = null!;
}
