using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class ContextsAction
{
    public int CtaId { get; set; }

    public int CtaType { get; set; }

    public string? CtaName { get; set; }

    public string? CtaCube { get; set; }
}
