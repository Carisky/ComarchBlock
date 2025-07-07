using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DetalCeny
{
    public int DdfCDdfCid { get; set; }

    public int DdfCDstaId { get; set; }

    public int DdfCDfCid { get; set; }

    public virtual DetalStanowiska DdfCDsta { get; set; } = null!;
}
