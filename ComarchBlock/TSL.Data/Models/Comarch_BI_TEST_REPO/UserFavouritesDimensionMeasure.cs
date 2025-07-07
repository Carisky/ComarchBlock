using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class UserFavouritesDimensionMeasure
{
    public int UfdmId { get; set; }

    public int UfdmUserId { get; set; }

    public string UfdmSourceIdentifier { get; set; } = null!;

    public bool UfdmIsInMemory { get; set; }

    public virtual User1 UfdmUser { get; set; } = null!;

    public virtual ICollection<UserFavouritesDimensionMeasureItem> UserFavouritesDimensionMeasureItems { get; set; } = new List<UserFavouritesDimensionMeasureItem>();
}
