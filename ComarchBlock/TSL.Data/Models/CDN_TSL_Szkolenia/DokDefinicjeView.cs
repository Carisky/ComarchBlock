using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DokDefinicjeView
{
    public int DdfVDdfId { get; set; }

    public int DdfVKlasa { get; set; }

    public string DdfVSymbol { get; set; } = null!;

    public string DdfVNazwa { get; set; } = null!;

    public byte DdfVNieaktywna { get; set; }

    public string DdfVNumeracja { get; set; } = null!;

    public byte DdfVSeriaOperatora { get; set; }

    public int DdfVKierunekOrg { get; set; }

    public DateTime? DdfVTsExport { get; set; }

    public string? DdfVImportAppId { get; set; }

    public string? DdfVImportRowId { get; set; }

    public int? DdfVOpeZalId { get; set; }

    public int? DdfVStaZalId { get; set; }

    public DateTime DdfVTsZal { get; set; }

    public int? DdfVOpeModId { get; set; }

    public int? DdfVStaModId { get; set; }

    public DateTime DdfVTsMod { get; set; }
}
