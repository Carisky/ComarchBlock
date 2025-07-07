using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DodatkiUmowy
{
    public int DouDouId { get; set; }

    public int DouDodId { get; set; }

    public int DouUmwId { get; set; }

    public string? DouImportRowId { get; set; }

    public virtual Dodatki DouDod { get; set; } = null!;

    public virtual Umowy DouUmw { get; set; } = null!;
}
