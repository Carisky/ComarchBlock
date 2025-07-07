using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DaneKadModRelacje
{
    public int DkrDkrId { get; set; }

    public int DkrDkmId1 { get; set; }

    public int DkrDkmId2 { get; set; }

    public string? DkrDkmNazwa { get; set; }

    public byte? DkrDkmRobotnicze { get; set; }

    public byte DkrRodzaj { get; set; }

    public virtual DaneKadMod DkrDkmId1Navigation { get; set; } = null!;

    public virtual DaneKadMod DkrDkmId2Navigation { get; set; } = null!;
}
