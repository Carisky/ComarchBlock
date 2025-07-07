using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DokumentyKsiegowaneView
{
    public int DksTyp { get; set; }

    public int DksDksId { get; set; }

    public int? DksDekId { get; set; }

    public int? DksKprid { get; set; }

    public int? DksRycId { get; set; }

    public string DksTypStr { get; set; } = null!;

    public string? DksNumer { get; set; }

    public DateTime? DksData { get; set; }

    public decimal? DksKwota { get; set; }
}
