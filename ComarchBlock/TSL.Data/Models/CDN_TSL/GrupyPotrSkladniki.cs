using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class GrupyPotrSkladniki
{
    public int GpsGpsId { get; set; }

    public int GpsGprId { get; set; }

    public int GpsParentSts { get; set; }

    public string GpsParentNazwa { get; set; } = null!;

    public int GpsParentId { get; set; }

    public byte? GpsRodzaj { get; set; }

    public int GpsPriorytet { get; set; }

    public string? GpsImportRowId { get; set; }

    public virtual GrupyPotracen GpsGpr { get; set; } = null!;
}
