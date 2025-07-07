using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class AutoKoszty
{
    public int AuKAuKid { get; set; }

    public int AuKAuEid { get; set; }

    public int AuKRokMies { get; set; }

    public int AuKLp { get; set; }

    public int? AuKVaNid { get; set; }

    public DateTime AuKDataZap { get; set; }

    public string AuKDokument { get; set; } = null!;

    public int? AuKKatId { get; set; }

    public string AuKKategoria { get; set; } = null!;

    public decimal AuKWartosc { get; set; }

    public int? AuKOpeZalId { get; set; }

    public int? AuKStaZalId { get; set; }

    public DateTime AuKTsZal { get; set; }

    public int? AuKOpeModId { get; set; }

    public int? AuKStaModId { get; set; }

    public DateTime AuKTsMod { get; set; }

    public string AuKOpeModKod { get; set; } = null!;

    public string AuKOpeModNazwisko { get; set; } = null!;

    public string AuKOpeZalKod { get; set; } = null!;

    public string AuKOpeZalNazwisko { get; set; } = null!;

    public virtual AutoEwid AuKAuE { get; set; } = null!;

    public virtual Kategorie? AuKKat { get; set; }
}
