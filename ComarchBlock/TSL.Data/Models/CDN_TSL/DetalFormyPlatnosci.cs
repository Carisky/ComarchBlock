using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DetalFormyPlatnosci
{
    public int DfplDfplId { get; set; }

    public int DfplDstaId { get; set; }

    public int DfplFplId { get; set; }

    public string DfplNazwa { get; set; } = null!;

    public string DfplNazwaDetal { get; set; } = null!;

    public byte DfplDomyslna { get; set; }
}
