using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class PracSchorzenium
{
    public int PrsPrsId { get; set; }

    public int PrsPraId { get; set; }

    public int PrsDkmId { get; set; }

    public DateTime PrsDataOd { get; set; }

    public DateTime PrsDataDo { get; set; }

    public int? PrsOpeZalId { get; set; }

    public int? PrsStaZalId { get; set; }

    public DateTime PrsTsZal { get; set; }

    public int? PrsOpeModId { get; set; }

    public int? PrsStaModId { get; set; }

    public DateTime PrsTsMod { get; set; }

    public string PrsOpeModKod { get; set; } = null!;

    public string PrsOpeModNazwisko { get; set; } = null!;

    public string PrsOpeZalKod { get; set; } = null!;

    public string PrsOpeZalNazwisko { get; set; } = null!;

    public string? PrsImportRowId { get; set; }

    public virtual DaneKadMod PrsDkm { get; set; } = null!;

    public virtual PracKod PrsPra { get; set; } = null!;
}
