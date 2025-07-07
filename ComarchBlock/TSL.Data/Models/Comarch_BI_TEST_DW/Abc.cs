using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class Abc
{
    public int MagazynId { get; set; }

    public int ProduktId { get; set; }

    public decimal? Marza { get; set; }

    public decimal? MarzaNarastajaco { get; set; }

    public long? Ranking { get; set; }

    public decimal? Procent { get; set; }

    public decimal? ProcentNarastajaco { get; set; }

    public string FlagaAbc { get; set; } = null!;
}
