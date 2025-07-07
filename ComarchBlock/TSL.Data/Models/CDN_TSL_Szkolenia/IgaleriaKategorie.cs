using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class IgaleriaKategorie
{
    public int IgkIgkid { get; set; }

    public int IgkParentId { get; set; }

    public string IgkNazwa { get; set; } = null!;

    public byte IgkAktywna { get; set; }
}
