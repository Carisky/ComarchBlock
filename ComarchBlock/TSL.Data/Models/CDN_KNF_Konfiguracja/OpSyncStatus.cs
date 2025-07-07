using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OpSyncStatus
{
    public string NazwaTabeli { get; set; } = null!;

    public int OpMaxSyncedId { get; set; }

    public int EpMaxSyncedId { get; set; }

    public int OpMaxMapaId { get; set; }

    public int EpMaxMapaId { get; set; }

    public int EpMaxFullSyncId { get; set; }
}
