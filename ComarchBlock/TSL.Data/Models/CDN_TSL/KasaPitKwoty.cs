using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KasaPitKwoty
{
    public int KpkKpkid { get; set; }

    public int? KpkKptId { get; set; }

    public DateTime KpkData { get; set; }

    public int KpkTyp { get; set; }

    public int? KpkVaNid { get; set; }

    public int? KpkVaTid { get; set; }

    public int? KpkEdnid { get; set; }

    public decimal KpkKwota { get; set; }

    public decimal? KpkVat { get; set; }
}
