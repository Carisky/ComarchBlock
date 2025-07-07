using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class OkresyZwolSkl
{
    public int OzsOzsId { get; set; }

    public int OzsPraId { get; set; }

    public int OzsRok { get; set; }

    public int OzsMiesiac { get; set; }

    public string? OzsImportRowId { get; set; }

    public virtual PracKod OzsPra { get; set; } = null!;
}
