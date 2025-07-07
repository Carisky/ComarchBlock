using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class DaneRynkoweCeny
{
    public int DrcDrkId { get; set; }

    public short DrcNumerCeny { get; set; }

    public string? DrcWaluta { get; set; }

    public short? DrcNrKursu { get; set; }

    public decimal? DrcKursL { get; set; }

    public decimal? DrcKursM { get; set; }

    public decimal? DrcCena { get; set; }

    public decimal? DrcCenaWal { get; set; }

    public virtual DaneRynkowe DrcDrk { get; set; } = null!;
}
