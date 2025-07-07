using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class OsoPlatElem
{
    public int OseId { get; set; }

    public int? OseOsnid { get; set; }

    public short? OseLp { get; set; }

    public int? OseBnKnumer { get; set; }

    public byte? OseNrb { get; set; }

    public string? OseKonto { get; set; }

    public decimal? OseKwota { get; set; }

    public decimal? OseProcent { get; set; }

    public byte? OseFormaNr { get; set; }

    public int? OseWalutaNumer { get; set; }

    public int? OseRodzajListyPlac { get; set; }

    public int? OseOpeWnumer { get; set; }

    public int? OseCzasWprowadzenia { get; set; }

    public int? OseOpeMnumer { get; set; }

    public int? OseCzasModyfikacji { get; set; }

    public virtual OsoPlatNag? OseOsn { get; set; }
}
