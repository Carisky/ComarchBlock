using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Oatrybuty
{
    public int OatOatId { get; set; }

    public int OatPrcId { get; set; }

    public int? OatAtkId { get; set; }

    public string OatWartosc { get; set; } = null!;

    public string OatNazwaKlasy { get; set; } = null!;

    public DateTime OatOkresOd { get; set; }

    public DateTime OatOkresDo { get; set; }

    public int? OatOpeZalId { get; set; }

    public int? OatStaZalId { get; set; }

    public DateTime OatTsZal { get; set; }

    public int? OatOpeModId { get; set; }

    public int? OatStaModId { get; set; }

    public DateTime OatTsMod { get; set; }

    public string OatOpeModKod { get; set; } = null!;

    public string OatOpeModNazwisko { get; set; } = null!;

    public string OatOpeZalKod { get; set; } = null!;

    public string OatOpeZalNazwisko { get; set; } = null!;

    public string? OatImportRowId { get; set; }

    public virtual OatrybutyKlasy? OatAtk { get; set; }

    public virtual PracKod OatPrc { get; set; } = null!;

    public virtual ICollection<OatrybutyHist> OatrybutyHists { get; set; } = new List<OatrybutyHist>();
}
