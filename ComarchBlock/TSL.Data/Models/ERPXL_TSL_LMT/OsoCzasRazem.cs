using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class OsoCzasRazem
{
    public int OcrId { get; set; }

    public int? OcrOsoNumer { get; set; }

    public int? OcrOsUnumer { get; set; }

    public int? OcrRodzajPracy { get; set; }

    public int? OcrDataOd { get; set; }

    public int? OcrDataDo { get; set; }

    public int? OcrNorma { get; set; }

    public int? OcrPraca { get; set; }

    public int? OcrPonad { get; set; }

    public int? OcrPonizej { get; set; }

    public int? OcrNadgodziny50 { get; set; }

    public int? OcrNadgodziny100 { get; set; }

    public int? OcrGodzinyNocne { get; set; }

    public byte? OcrDniPracy { get; set; }

    public byte? OcrDniWolne { get; set; }

    public byte? OcrDniSwieta { get; set; }

    public int? OcrOpMnumer { get; set; }

    public int? OcrCzasModyfikacji { get; set; }

    public virtual PrcKarty? OcrOsoNumerNavigation { get; set; }
}
