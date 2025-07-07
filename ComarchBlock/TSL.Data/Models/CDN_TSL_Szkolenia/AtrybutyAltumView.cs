using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class AtrybutyAltumView
{
    public string? PraImportRowId { get; set; }

    public string? AtkImportRowId { get; set; }

    public int AthAthId { get; set; }

    public DateTime AthDataOd { get; set; }

    public DateTime AthDataDo { get; set; }

    public string AthWartosc { get; set; } = null!;

    public string? AthImportRowId { get; set; }
}
