using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class SprawozdaniaFinansoweZalaczniki
{
    public int SfzSfzid { get; set; }

    public int? SfzSfnid { get; set; }

    public int? SfzDabid { get; set; }

    public string? SfzNazwa { get; set; }

    public int? SfzTyp { get; set; }

    public int? SfzWlasny { get; set; }

    public DateTime? SfzTsOblicz { get; set; }

    public int? SfzOpeZalId { get; set; }

    public int? SfzStaZalId { get; set; }

    public DateTime SfzTsZal { get; set; }

    public int? SfzOpeModId { get; set; }

    public int? SfzStaModId { get; set; }

    public DateTime SfzTsMod { get; set; }

    public string SfzOpeModKod { get; set; } = null!;

    public string SfzOpeModNazwisko { get; set; } = null!;

    public string SfzOpeZalKod { get; set; } = null!;

    public string SfzOpeZalNazwisko { get; set; } = null!;
}
