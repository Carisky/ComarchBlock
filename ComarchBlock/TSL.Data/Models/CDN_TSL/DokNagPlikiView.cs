using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DokNagPlikiView
{
    public int DnPDnPid { get; set; }

    public int? DnPDoNid { get; set; }

    public short DnPWersja { get; set; }

    public short DnPFileMode { get; set; }

    public DateTime DnPDataDok { get; set; }

    public int? DnPTyp { get; set; }

    public int? DnPArchiwalny { get; set; }

    public string? DnPNazwaPliku { get; set; }

    public string? DnPSciezka { get; set; }

    public short? DnPWbazie { get; set; }

    public int DnPDlaOcr { get; set; }

    public int? DnPStaEditId { get; set; }

    public int? DnPOpeEditId { get; set; }

    public int? DnPOpeZalId { get; set; }

    public int? DnPStaZalId { get; set; }

    public DateTime DnPTsZal { get; set; }

    public int? DnPOpeModId { get; set; }

    public int? DnPStaModId { get; set; }

    public DateTime DnPTsMod { get; set; }

    public string DnPOpeModKod { get; set; } = null!;

    public string DnPOpeModNazwisko { get; set; } = null!;

    public string DnPOpeZalKod { get; set; } = null!;

    public string DnPOpeZalNazwisko { get; set; } = null!;
}
