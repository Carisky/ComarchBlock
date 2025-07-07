using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class AutoEwid
{
    public int AuEAuEid { get; set; }

    public string AuERejestracja { get; set; } = null!;

    public string AuEMarka { get; set; } = null!;

    public byte AuEKlasaPoj { get; set; }

    public short AuEPojemnosc { get; set; }

    public byte AuEPracownik { get; set; }

    public short AuELimit { get; set; }

    public int? AuEPrcId { get; set; }

    public string AuEPrcNazwisko { get; set; } = null!;

    public string AuEPrcAdres { get; set; } = null!;

    public string AuEOpis { get; set; } = null!;

    public byte AuENieaktywny { get; set; }

    public int? AuEOpeZalId { get; set; }

    public int? AuEStaZalId { get; set; }

    public DateTime AuETsZal { get; set; }

    public int? AuEOpeModId { get; set; }

    public int? AuEStaModId { get; set; }

    public DateTime AuETsMod { get; set; }

    public string AuEOpeModKod { get; set; } = null!;

    public string AuEOpeModNazwisko { get; set; } = null!;

    public string AuEOpeZalKod { get; set; } = null!;

    public string AuEOpeZalNazwisko { get; set; } = null!;

    public DateTime? AuEDataRoz { get; set; }

    public DateTime? AuEDataZak { get; set; }

    public int? AuEZakId { get; set; }

    public virtual PracKod? AuEPrc { get; set; }

    public virtual ICollection<AutoKoszty> AutoKoszties { get; set; } = new List<AutoKoszty>();

    public virtual ICollection<AutoPrzejazd> AutoPrzejazds { get; set; } = new List<AutoPrzejazd>();

    public virtual ICollection<AutoRozlicz> AutoRozliczs { get; set; } = new List<AutoRozlicz>();
}
