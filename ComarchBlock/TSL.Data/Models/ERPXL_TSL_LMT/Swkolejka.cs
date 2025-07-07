using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Swkolejka
{
    public int SwkPolecenieId { get; set; }

    public int SwkId { get; set; }

    public short? SwkNumerKolejki { get; set; }

    public string? SwkWartosci { get; set; }

    public virtual Swpolecenium SwkPolecenie { get; set; } = null!;
}
