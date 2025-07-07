using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class AutoRozlicz
{
    public int AuRAuRid { get; set; }

    public int AuRAuEid { get; set; }

    public int AuRRokMies { get; set; }

    public decimal AuRPrzejMiesiac { get; set; }

    public decimal AuRPrzejRok { get; set; }

    public decimal AuRKosztMiesiac { get; set; }

    public decimal AuRKosztRok { get; set; }

    public decimal AuRKsiegMiesiac { get; set; }

    public decimal AuRKsiegRok { get; set; }

    public int? AuRKatId { get; set; }

    public string AuRKategoria { get; set; } = null!;

    public string AuRRejestr { get; set; } = null!;

    public int? AuRVaNid { get; set; }

    public int? AuRKprid { get; set; }

    public int? AuRDekId { get; set; }

    public int? AuROpeZalId { get; set; }

    public int? AuRStaZalId { get; set; }

    public DateTime AuRTsZal { get; set; }

    public int? AuROpeModId { get; set; }

    public int? AuRStaModId { get; set; }

    public DateTime AuRTsMod { get; set; }

    public string AuROpeModKod { get; set; } = null!;

    public string AuROpeModNazwisko { get; set; } = null!;

    public string AuROpeZalKod { get; set; } = null!;

    public string AuROpeZalNazwisko { get; set; } = null!;

    public int AuRKorektaVat { get; set; }

    public int? AuRZakId { get; set; }

    public virtual AutoEwid AuRAuE { get; set; } = null!;

    public virtual Kategorie? AuRKat { get; set; }
}
