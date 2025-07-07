using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class Setting
{
    public int SetId { get; set; }

    public int? SetEnumid { get; set; }

    public int? SetDepid { get; set; }

    public string SetName { get; set; } = null!;

    public string SetDatid { get; set; } = null!;

    public string? SetCustomValue { get; set; }

    public DateTime SetTsinsert { get; set; }

    public DateTime SetTsupdate { get; set; }

    public byte[] SetRowVersion { get; set; } = null!;

    public virtual Department? SetDep { get; set; }

    public virtual EnumeratorValue? SetEnum { get; set; }
}
