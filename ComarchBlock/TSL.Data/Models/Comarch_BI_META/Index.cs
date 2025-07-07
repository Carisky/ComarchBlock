using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class Index
{
    public int IndId { get; set; }

    public int? IndTblid { get; set; }

    public string IndLogicalName { get; set; } = null!;

    public virtual Table? IndTbl { get; set; }

    public virtual ICollection<IndexField> IndexFields { get; set; } = new List<IndexField>();

    public virtual ICollection<IndexIncludedField> IndexIncludedFields { get; set; } = new List<IndexIncludedField>();
}
