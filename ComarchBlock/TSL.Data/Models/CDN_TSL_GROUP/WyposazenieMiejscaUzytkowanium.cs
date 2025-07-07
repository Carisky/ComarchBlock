using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class WyposazenieMiejscaUzytkowanium
{
    public int WyMuWyMuid { get; set; }

    public int WyMuWypId { get; set; }

    public DateTime? WyMuDataOd { get; set; }

    public DateTime? WyMuDataDo { get; set; }

    public string WyMuNazwa { get; set; } = null!;

    public virtual Wyposazenie WyMuWyp { get; set; } = null!;
}
