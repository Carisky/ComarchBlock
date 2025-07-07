using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class KatalogiView
{
    public int KtlVDonTyp { get; set; }

    public int KtlVKtlId { get; set; }

    public string KtlVSymbol { get; set; } = null!;

    public string KtlVNazwa { get; set; } = null!;

    public string? KtlVNumeracja { get; set; }

    public int? KtlVOpeZalId { get; set; }

    public int? KtlVStaZalId { get; set; }

    public DateTime KtlVTsZal { get; set; }

    public int? KtlVOpeModId { get; set; }

    public int? KtlVStaModId { get; set; }

    public DateTime KtlVTsMod { get; set; }

    public int? KtlVSsid { get; set; }
}
