using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class RodzinaZwolOkresy
{
    public int RzoRzoId { get; set; }

    public int RzoRdzId { get; set; }

    public DateTime RzoOkresOd { get; set; }

    public DateTime RzoOkresDo { get; set; }

    public int? RzoPnbId { get; set; }

    public string? RzoImportRowId { get; set; }

    public virtual Rodzina RzoRdz { get; set; } = null!;
}
