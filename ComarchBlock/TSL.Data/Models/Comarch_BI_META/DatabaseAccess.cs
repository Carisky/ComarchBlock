using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class DatabaseAccess
{
    public int DbaId { get; set; }

    public string DbaDbtid { get; set; } = null!;

    public string DbaDatid { get; set; } = null!;

    public string DbaServerName { get; set; } = null!;

    public string DbaDatabaseName { get; set; } = null!;

    public string? DbaUserName { get; set; }

    public string? DbaUserPassword { get; set; }

    public virtual DatabaseAuthorizationType DbaDat { get; set; } = null!;

    public virtual DatabaseType DbaDbt { get; set; } = null!;
}
