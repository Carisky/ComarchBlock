using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class AutoPrzejazd
{
    public int AuPAuPid { get; set; }

    public int AuPAuEid { get; set; }

    public int AuPRokMies { get; set; }

    public int AuPLp { get; set; }

    public DateTime AuPDataZap { get; set; }

    public int? AuPAuTid { get; set; }

    public string? AuPTrasa { get; set; }

    public string AuPCel { get; set; } = null!;

    public decimal AuPDlugosc { get; set; }

    public byte AuPMiasto { get; set; }

    public decimal AuPStawka { get; set; }

    public int? AuPOpeZalId { get; set; }

    public int? AuPStaZalId { get; set; }

    public DateTime AuPTsZal { get; set; }

    public int? AuPOpeModId { get; set; }

    public int? AuPStaModId { get; set; }

    public DateTime AuPTsMod { get; set; }

    public string AuPOpeModKod { get; set; } = null!;

    public string AuPOpeModNazwisko { get; set; } = null!;

    public string AuPOpeZalKod { get; set; } = null!;

    public string AuPOpeZalNazwisko { get; set; } = null!;

    public decimal? AuPPoczStanL { get; set; }

    public decimal? AuPKonStanL { get; set; }

    public int? AuPPrcId { get; set; }

    public string? AuPPrcNazwisko { get; set; }

    public string? AuPPrcAdres { get; set; }

    public int? AuPPrcTyp { get; set; }

    public int? AuPOpiekunTyp { get; set; }

    public int? AuPOpiekunId { get; set; }

    public int AuPPotwierdzil { get; set; }

    public DateTime? AuPDataPotw { get; set; }

    public virtual AutoEwid AuPAuE { get; set; } = null!;

    public virtual AutoTrasy? AuPAuT { get; set; }
}
