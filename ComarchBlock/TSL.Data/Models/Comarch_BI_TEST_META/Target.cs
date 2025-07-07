using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class Target
{
    public int TgId { get; set; }

    public string TgMeasureName { get; set; } = null!;

    public string TgCubeName { get; set; } = null!;

    public string TgMeasureGroup { get; set; } = null!;

    public int TgPrcId { get; set; }

    public DateTime TgDate { get; set; }

    public bool TgIsNewMeasure { get; set; }

    public bool TgInvertedValues { get; set; }

    public bool TgBilancedZero { get; set; }

    public string TgXmlDefinition { get; set; } = null!;

    public string? TgCaption { get; set; }

    public virtual Process TgPrc { get; set; } = null!;
}
