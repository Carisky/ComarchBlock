using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class EnumeratorValue
{
    public int EnumId { get; set; }

    public string EnumEnumeratorName { get; set; } = null!;

    public string EnumValue { get; set; } = null!;

    public virtual ICollection<Setting> Settings { get; set; } = new List<Setting>();
}
