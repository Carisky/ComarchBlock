using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Swzmienne
{
    public int SwzPolecenieId { get; set; }

    public string SwzNazwa { get; set; } = null!;

    public string? SwzTyp { get; set; }

    public byte? SwzNumeryczna { get; set; }

    public string? SwzWartosc { get; set; }

    public string? SwzFormat { get; set; }

    public virtual Swpolecenium SwzPolecenie { get; set; } = null!;
}
