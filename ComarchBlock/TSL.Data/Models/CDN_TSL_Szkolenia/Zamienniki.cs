using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class Zamienniki
{
    public int ZamZamId { get; set; }

    public int ZamTwrId { get; set; }

    public int ZamZamTwrId { get; set; }

    public int? ZamLp { get; set; }

    public virtual Towary ZamTwr { get; set; } = null!;
}
