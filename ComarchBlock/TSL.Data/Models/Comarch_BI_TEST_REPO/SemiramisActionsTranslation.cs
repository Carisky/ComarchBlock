using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class SemiramisActionsTranslation
{
    public int SatId { get; set; }

    public int SatActionId { get; set; }

    public string SatLocaleId { get; set; } = null!;

    public string SatTranslation { get; set; } = null!;

    public virtual SemiramisAction SatAction { get; set; } = null!;
}
