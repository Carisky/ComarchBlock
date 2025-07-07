using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Katalogi
{
    public int KtlKtlId { get; set; }

    public int? KtlSsid { get; set; }

    public string KtlSymbol { get; set; } = null!;

    public string KtlNazwa { get; set; } = null!;

    public string? KtlNumeracja { get; set; }

    public string KtlIbard24 { get; set; } = null!;

    public long? KtlIbard24Id { get; set; }

    public byte KtlDomyslny { get; set; }

    public int? KtlOpeZalId { get; set; }

    public int? KtlStaZalId { get; set; }

    public DateTime KtlTsZal { get; set; }

    public int? KtlOpeModId { get; set; }

    public int? KtlStaModId { get; set; }

    public DateTime KtlTsMod { get; set; }

    public string KtlOpeModKod { get; set; } = null!;

    public string KtlOpeModNazwisko { get; set; } = null!;

    public string KtlOpeZalKod { get; set; } = null!;

    public string KtlOpeZalNazwisko { get; set; } = null!;
}
