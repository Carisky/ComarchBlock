using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class AkordyHistWartosci
{
    public int AhwAhwId { get; set; }

    public int AhwAkhId { get; set; }

    public decimal AhwIlosc { get; set; }

    public DateTime? AhwCzas { get; set; }

    public short AhwMiesiac { get; set; }

    public int AhwRok { get; set; }

    public decimal AhwKwota { get; set; }

    public decimal AhwUdzial { get; set; }

    public int AhwZmiana { get; set; }

    public string? AhwImportRowId { get; set; }

    public virtual AkordyHist AhwAkh { get; set; } = null!;
}
