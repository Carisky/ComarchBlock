using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class PracPitMy
{
    public int PpmPpmid { get; set; }

    public int PpmPraId { get; set; }

    public short PpmRok { get; set; }

    public short PpmMiesiac { get; set; }

    public byte PpmZablokowane { get; set; }

    public virtual PracKod PpmPra { get; set; } = null!;

    public virtual ICollection<PracPitDzialalnosci> PracPitDzialalnoscis { get; set; } = new List<PracPitDzialalnosci>();

    public virtual ICollection<PracPitKwoty> PracPitKwoties { get; set; } = new List<PracPitKwoty>();
}
