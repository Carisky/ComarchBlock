using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class UserFavouritesDimensionMeasureItem
{
    public int UfiId { get; set; }

    public string UfiItemUniqueName { get; set; } = null!;

    public int UfiParentId { get; set; }

    public string UfiNodeType { get; set; } = null!;

    public virtual UserFavouritesDimensionMeasure UfiParent { get; set; } = null!;
}
