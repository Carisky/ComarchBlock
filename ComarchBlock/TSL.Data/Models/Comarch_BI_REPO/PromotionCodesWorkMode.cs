using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class PromotionCodesWorkMode
{
    public int PcwmId { get; set; }

    public int? PcwmCodeId { get; set; }

    public int? PcwmWorkModeId { get; set; }

    public virtual PromotionCode? PcwmCode { get; set; }

    public virtual WorkMode? PcwmWorkMode { get; set; }
}
