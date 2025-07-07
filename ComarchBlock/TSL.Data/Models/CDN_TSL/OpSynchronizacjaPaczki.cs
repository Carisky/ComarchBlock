using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class OpSynchronizacjaPaczki
{
    public int SnpId { get; set; }

    public string SnpNazwa { get; set; } = null!;

    public short SnpTryb { get; set; }
}
