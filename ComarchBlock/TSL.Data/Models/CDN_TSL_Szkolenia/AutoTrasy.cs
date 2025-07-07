using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class AutoTrasy
{
    public int AuTAuTid { get; set; }

    public string AuTKod { get; set; } = null!;

    public string? AuTTrasa { get; set; }

    public string AuTCel { get; set; } = null!;

    public decimal AuTDlugosc { get; set; }

    public byte AuTMiasto { get; set; }

    public int? AuTOpeZalId { get; set; }

    public int? AuTStaZalId { get; set; }

    public DateTime AuTTsZal { get; set; }

    public int? AuTOpeModId { get; set; }

    public int? AuTStaModId { get; set; }

    public DateTime AuTTsMod { get; set; }

    public string AuTOpeModKod { get; set; } = null!;

    public string AuTOpeModNazwisko { get; set; } = null!;

    public string AuTOpeZalKod { get; set; } = null!;

    public string AuTOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<AutoPrzejazd> AutoPrzejazds { get; set; } = new List<AutoPrzejazd>();
}
