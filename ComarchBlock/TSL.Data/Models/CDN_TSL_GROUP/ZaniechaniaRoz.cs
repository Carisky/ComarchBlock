using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class ZaniechaniaRoz
{
    public int ZarZarId { get; set; }

    public int ZarZanId { get; set; }

    public int ZarWplId { get; set; }

    public decimal ZarKwota { get; set; }

    public DateTime ZarData { get; set; }

    public virtual Zaniechanium ZarZan { get; set; } = null!;
}
