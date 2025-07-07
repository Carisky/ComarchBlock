using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class PracPlanDni
{
    public int PplPplId { get; set; }

    public int PplPraId { get; set; }

    public DateTime PplData { get; set; }

    public int PplTypDnia { get; set; }

    public int? PplOdwId { get; set; }

    public int? PplOpeZalId { get; set; }

    public int? PplStaZalId { get; set; }

    public DateTime PplTsZal { get; set; }

    public int? PplOpeModId { get; set; }

    public int? PplStaModId { get; set; }

    public DateTime PplTsMod { get; set; }

    public string PplOpeModKod { get; set; } = null!;

    public string PplOpeModNazwisko { get; set; } = null!;

    public string PplOpeZalKod { get; set; } = null!;

    public string PplOpeZalNazwisko { get; set; } = null!;

    public byte PplZrodlo { get; set; }

    public string? PplImportRowId { get; set; }

    public virtual OpisyDniWolne? PplOdw { get; set; }

    public virtual PracKod PplPra { get; set; } = null!;

    public virtual ICollection<PracPlanDniGodz> PracPlanDniGodzs { get; set; } = new List<PracPlanDniGodz>();
}
