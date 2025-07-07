using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class ContextTranslation
{
    public int CtlId { get; set; }

    public int CtlContextId { get; set; }

    public string CtlLocaleId { get; set; } = null!;

    public string? CtlTranslation { get; set; }

    public virtual Context CtlContext { get; set; } = null!;
}
