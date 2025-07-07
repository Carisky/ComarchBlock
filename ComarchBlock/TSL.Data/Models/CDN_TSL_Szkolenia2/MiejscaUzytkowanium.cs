using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class MiejscaUzytkowanium
{
    public int MuzMuzId { get; set; }

    public string MuzNazwa { get; set; } = null!;

    public byte MuzNieaktywne { get; set; }
}
