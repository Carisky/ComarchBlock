using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class BnkSposobyLogowanium
{
    public int BslBslid { get; set; }

    public int BslBnaId { get; set; }

    public int BslOpeId { get; set; }

    public byte BslTypLogowania { get; set; }

    public string BslLogin { get; set; } = null!;

    public byte BslTypCertyfikatu { get; set; }

    public virtual BnkNazwy BslBna { get; set; } = null!;
}
