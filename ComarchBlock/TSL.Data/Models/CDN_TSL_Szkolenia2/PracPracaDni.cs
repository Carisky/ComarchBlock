using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PracPracaDni
{
    public int PprPprId { get; set; }

    public int PprPraId { get; set; }

    public DateTime PprData { get; set; }

    public int? PprOpeZalId { get; set; }

    public int? PprStaZalId { get; set; }

    public DateTime PprTsZal { get; set; }

    public int? PprOpeModId { get; set; }

    public int? PprStaModId { get; set; }

    public DateTime PprTsMod { get; set; }

    public string PprOpeModKod { get; set; } = null!;

    public string PprOpeModNazwisko { get; set; } = null!;

    public string PprOpeZalKod { get; set; } = null!;

    public string PprOpeZalNazwisko { get; set; } = null!;

    public byte PprZrodlo { get; set; }

    public string? PprImportRowId { get; set; }

    public virtual PracKod PprPra { get; set; } = null!;

    public virtual ICollection<PracPracaDniGodz> PracPracaDniGodzs { get; set; } = new List<PracPracaDniGodz>();
}
