using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class LogActionTranslation
{
    public int LatId { get; set; }

    public string LatLanguage { get; set; } = null!;

    public string? LatValue { get; set; }
}
