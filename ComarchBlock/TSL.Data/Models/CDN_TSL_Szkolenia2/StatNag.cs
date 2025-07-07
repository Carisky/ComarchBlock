using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class StatNag
{
    public int StNStNid { get; set; }

    public string StNZrodlo { get; set; } = null!;

    public DateTime? StNDataEksport { get; set; }

    public DateTime? StNDataImport { get; set; }

    public int StNLiczbaSlowEksp { get; set; }

    public int StNLiczbaSlowImp { get; set; }

    public int StNLiczbaDokEksp { get; set; }

    public int StNLiczbaDokImp { get; set; }

    public int? StNOperator { get; set; }

    public string? StNLog { get; set; }
}
