using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class CorrectionRule
{
    public int CrrId { get; set; }

    public string CrrCrrtid { get; set; } = null!;

    public DateTime CrrRuleDate { get; set; }

    public int CrrFieldId { get; set; }

    public string CrrValueAfter { get; set; } = null!;

    public DateTime CrrDateFrom { get; set; }

    public DateTime CrrDateTo { get; set; }

    public bool CrrEnabled { get; set; }

    public string CrrWhere { get; set; } = null!;

    public DateTime? CrrRuleDisabledDate { get; set; }

    public int? CrrUsrid { get; set; }

    public virtual ICollection<CorrectionRuleValueToReplace> CorrectionRuleValueToReplaces { get; set; } = new List<CorrectionRuleValueToReplace>();

    public virtual Field CrrField { get; set; } = null!;

    public virtual ApplicationUser? CrrUsr { get; set; }
}
