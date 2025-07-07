using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class AkordProgre
{
    public int AkpAkpId { get; set; }

    public int AkpAdfId { get; set; }

    public decimal AkpIlosc { get; set; }

    public decimal AkpStawka { get; set; }

    public DateTime? AkpCzas { get; set; }

    public string? AkpImportRowId { get; set; }

    public virtual AkordDefinicja AkpAdf { get; set; } = null!;
}
