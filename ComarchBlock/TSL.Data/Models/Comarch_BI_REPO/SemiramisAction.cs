using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SemiramisAction
{
    public int SeaId { get; set; }

    public string SeaName { get; set; } = null!;

    public string? SeaLinkParameterName { get; set; }

    public virtual ICollection<SemiramisActionsTranslation> SemiramisActionsTranslations { get; set; } = new List<SemiramisActionsTranslation>();

    public virtual ICollection<SemiramisLinkHierarchy> SemiramisLinkHierarchies { get; set; } = new List<SemiramisLinkHierarchy>();
}
