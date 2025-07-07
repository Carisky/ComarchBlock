using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class LgHead
{
    public int LhdId { get; set; }

    public string? LhdName { get; set; }

    public string LhdCulture { get; set; } = null!;

    public virtual ICollection<LgLanguage> LgLanguages { get; set; } = new List<LgLanguage>();
}
