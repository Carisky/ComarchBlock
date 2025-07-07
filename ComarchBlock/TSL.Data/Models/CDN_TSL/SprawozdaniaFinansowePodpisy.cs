using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class SprawozdaniaFinansowePodpisy
{
    public int SfpSfpid { get; set; }

    public int? SfpSfnid { get; set; }

    public string? SfpNazwa { get; set; }

    public int? SfpPodpis { get; set; }

    public int? SfpOdmowa { get; set; }

    public string? SfpOdcisk { get; set; }

    public DateTime? SfpTsOblicz { get; set; }

    public int? SfpOpeZalId { get; set; }

    public int? SfpStaZalId { get; set; }

    public DateTime SfpTsZal { get; set; }

    public int? SfpOpeModId { get; set; }

    public int? SfpStaModId { get; set; }

    public DateTime SfpTsMod { get; set; }

    public string SfpOpeModKod { get; set; } = null!;

    public string SfpOpeModNazwisko { get; set; } = null!;

    public string SfpOpeZalKod { get; set; } = null!;

    public string SfpOpeZalNazwisko { get; set; } = null!;
}
