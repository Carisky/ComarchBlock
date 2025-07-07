using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class UserImage
{
    public int UimId { get; set; }

    public string? UimImage { get; set; }

    public string? UimImageMin { get; set; }

    public virtual User1 Uim { get; set; } = null!;
}
