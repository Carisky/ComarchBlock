using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class SerieKalPoz
{
    public int SlpSlpId { get; set; }

    public int SlpSlnId { get; set; }

    public int SlpTypDnia { get; set; }

    public int SlpLp { get; set; }

    public int? SlpOdwId { get; set; }

    public virtual ICollection<SerieKalPozGodz> SerieKalPozGodzs { get; set; } = new List<SerieKalPozGodz>();

    public virtual OpisyDniWolne? SlpOdw { get; set; }

    public virtual SerieKalNag SlpSln { get; set; } = null!;
}
