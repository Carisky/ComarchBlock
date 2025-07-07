using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DetalZakazyMagazyn
{
    public int DzmDzmid { get; set; }

    public int DzmMagId { get; set; }

    public int DzmDstaId { get; set; }

    public virtual Magazyny DzmMag { get; set; } = null!;
}
