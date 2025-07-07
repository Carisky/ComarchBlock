using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class ApplicationRightsTranslation
{
    public int ArtId { get; set; }

    public int ArtRightId { get; set; }

    public string ArtLocaleId { get; set; } = null!;

    public string ArtTranslation { get; set; } = null!;

    public virtual ApplicationRight ArtRight { get; set; } = null!;
}
