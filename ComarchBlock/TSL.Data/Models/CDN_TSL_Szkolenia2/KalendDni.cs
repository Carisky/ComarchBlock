using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class KalendDni
{
    public int KadKadId { get; set; }

    public int KadKalId { get; set; }

    public DateTime KadData { get; set; }

    public int KadTypDnia { get; set; }

    public int? KadOdwId { get; set; }

    public int? KadOpeZalId { get; set; }

    public int? KadStaZalId { get; set; }

    public DateTime KadTsZal { get; set; }

    public int? KadOpeModId { get; set; }

    public int? KadStaModId { get; set; }

    public DateTime KadTsMod { get; set; }

    public string KadOpeModKod { get; set; } = null!;

    public string KadOpeModNazwisko { get; set; } = null!;

    public string KadOpeZalKod { get; set; } = null!;

    public string KadOpeZalNazwisko { get; set; } = null!;

    public string? KadImportRowId { get; set; }

    public virtual Kalendarze KadKal { get; set; } = null!;

    public virtual OpisyDniWolne? KadOdw { get; set; }
}
