using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class ParametersTranslation
{
    public int PtlId { get; set; }

    public int PtlParameterId { get; set; }

    public string PtlLocaleId { get; set; } = null!;

    public string PtlTranslation { get; set; } = null!;

    public virtual Parameter PtlParameter { get; set; } = null!;
}
