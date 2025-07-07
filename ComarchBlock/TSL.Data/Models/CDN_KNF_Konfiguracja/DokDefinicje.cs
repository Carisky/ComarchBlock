using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class DokDefinicje
{
    public int DdfDdfId { get; set; }

    public int DdfKlasa { get; set; }

    public string DdfSymbol { get; set; } = null!;

    public string DdfNazwa { get; set; } = null!;

    public byte DdfNieaktywna { get; set; }

    public string DdfNumeracja { get; set; } = null!;

    public byte DdfSeriaOperatora { get; set; }

    public int DdfKierunekOrg { get; set; }

    public int? DdfPowDdfId { get; set; }

    public string? DdfPowSeria { get; set; }

    public int? DdfKatalogObdId { get; set; }

    public DateTime? DdfTsExport { get; set; }

    public string? DdfImportAppId { get; set; }

    public string? DdfImportRowId { get; set; }

    public int? DdfOpeZalId { get; set; }

    public int? DdfStaZalId { get; set; }

    public DateTime DdfTsZal { get; set; }

    public int? DdfOpeModId { get; set; }

    public int? DdfStaModId { get; set; }

    public DateTime DdfTsMod { get; set; }

    public string DdfOpeModKod { get; set; } = null!;

    public string DdfOpeModNazwisko { get; set; } = null!;

    public string DdfOpeZalKod { get; set; } = null!;

    public string DdfOpeZalNazwisko { get; set; } = null!;
}
