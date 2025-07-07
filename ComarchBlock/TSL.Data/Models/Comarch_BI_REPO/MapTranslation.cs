using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class MapTranslation
{
    public string MtCode { get; set; } = null!;

    public string MtEn { get; set; } = null!;

    public string MtPl { get; set; } = null!;

    public string MtDe { get; set; } = null!;

    public string MtFr { get; set; } = null!;

    public string? MtEs { get; set; }
}
