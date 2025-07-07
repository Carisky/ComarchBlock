using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Olapxmldatum
{
    public int OlxOwiid { get; set; }

    public byte OlxTyp { get; set; }

    public int OlxId { get; set; }

    public string? OlxDefinicja { get; set; }

    public byte[]? OlxDefinicjabin { get; set; }

    public virtual OlapWidoki OlxOwi { get; set; } = null!;
}
