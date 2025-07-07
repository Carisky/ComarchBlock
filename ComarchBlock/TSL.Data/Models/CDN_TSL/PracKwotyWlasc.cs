using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class PracKwotyWlasc
{
    public int PkwPkwId { get; set; }

    public int PkwPraId { get; set; }

    public short PkwTyp { get; set; }

    public short PkwMiesiac { get; set; }

    public short PkwRok { get; set; }

    public decimal PkwWartosc { get; set; }

    public virtual PracKod PkwPra { get; set; } = null!;
}
