using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class LgLanguage
{
    public int LgsLhdid { get; set; }

    public string LgsKey { get; set; } = null!;

    public string LgsPhrase { get; set; } = null!;

    public int LgsType { get; set; }

    public virtual LgHead LgsLhd { get; set; } = null!;
}
