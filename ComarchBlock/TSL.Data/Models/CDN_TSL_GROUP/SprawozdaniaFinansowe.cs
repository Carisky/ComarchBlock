using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class SprawozdaniaFinansowe
{
    public int SfsSfsid { get; set; }

    public int? SfsDabid { get; set; }

    public int? SfsConfigDabid { get; set; }

    public int? SfsUpodabid { get; set; }

    public string? SfsSchemaVersion { get; set; }

    public int SfsActive { get; set; }

    public DateTime? SfsDateTo { get; set; }

    public DateTime? SfsPreparationDate { get; set; }

    public string? SfsCompanyName { get; set; }

    public int? SfsType { get; set; }

    public int? SfsStatus { get; set; }

    public string? SfsUpodescription { get; set; }

    public string? SfsUpocode { get; set; }

    public string? SfsReferenceNumber { get; set; }

    public DateTime? SfsTsOblicz { get; set; }

    public int? SfsOpeZalId { get; set; }

    public int? SfsStaZalId { get; set; }

    public DateTime SfsTsZal { get; set; }

    public int? SfsOpeModId { get; set; }

    public int? SfsStaModId { get; set; }

    public DateTime SfsTsMod { get; set; }

    public string SfsOpeModKod { get; set; } = null!;

    public string SfsOpeModNazwisko { get; set; } = null!;

    public string SfsOpeZalKod { get; set; } = null!;

    public string SfsOpeZalNazwisko { get; set; } = null!;
}
