using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TrwaleMiejscaUzytkowanium
{
    public int SrMuSrMuid { get; set; }

    public int SrMuSrTid { get; set; }

    public DateTime? SrMuDataOd { get; set; }

    public DateTime? SrMuDataDo { get; set; }

    public string SrMuNazwa { get; set; } = null!;

    public virtual Trwale SrMuSrT { get; set; } = null!;
}
