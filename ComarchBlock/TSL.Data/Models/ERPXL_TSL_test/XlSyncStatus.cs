using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class XlSyncStatus
{
    public string NazwaTabeli { get; set; } = null!;

    public int XlMaxSyncedId { get; set; }

    public int EpMaxSyncedId { get; set; }

    public int XlMaxMapaId { get; set; }

    public int EpMaxMapaId { get; set; }

    public int EpMaxFullSyncId { get; set; }
}
