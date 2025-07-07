using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class OatrybutyHist
{
    public int AthAthId { get; set; }

    public int AthPrcId { get; set; }

    public int? AthAtkId { get; set; }

    public int AthOatId { get; set; }

    public string AthWartosc { get; set; } = null!;

    public DateTime AthDataOd { get; set; }

    public DateTime AthDataDo { get; set; }

    public string? AthImportRowId { get; set; }

    public virtual Oatrybuty AthOat { get; set; } = null!;
}
