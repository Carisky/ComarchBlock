using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class AkordyHist
{
    public int AkhAkhId { get; set; }

    public int AkhAkrId { get; set; }

    public int AkhAdfId { get; set; }

    public string? AkhNazwa { get; set; }

    public DateTime AkhOkresOd { get; set; }

    public DateTime AkhOkresDo { get; set; }

    public decimal? AkhIlosc { get; set; }

    public DateTime? AkhCzas { get; set; }

    public short AkhMiesiac { get; set; }

    public int AkhRok { get; set; }

    public decimal AkhStawka { get; set; }

    public byte AkhProporcjonalnie { get; set; }

    public decimal AkhWspolczynnik { get; set; }

    public string? AkhImportRowId { get; set; }

    public int? AkhOpeZalId { get; set; }

    public int? AkhStaZalId { get; set; }

    public DateTime AkhTsZal { get; set; }

    public int? AkhOpeModId { get; set; }

    public int? AkhStaModId { get; set; }

    public DateTime AkhTsMod { get; set; }

    public string AkhOpeModKod { get; set; } = null!;

    public string AkhOpeModNazwisko { get; set; } = null!;

    public string AkhOpeZalKod { get; set; } = null!;

    public string AkhOpeZalNazwisko { get; set; } = null!;

    public virtual AkordDefinicja AkhAdf { get; set; } = null!;

    public virtual Akordy AkhAkr { get; set; } = null!;

    public virtual ICollection<AkordyHistWartosci> AkordyHistWartoscis { get; set; } = new List<AkordyHistWartosci>();
}
