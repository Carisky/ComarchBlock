using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class MagazynZakazy
{
    public int MaZMaZid { get; set; }

    public int MaZMagId { get; set; }

    public int MaZOpeId { get; set; }

    public virtual Magazyny MaZMag { get; set; } = null!;
}
