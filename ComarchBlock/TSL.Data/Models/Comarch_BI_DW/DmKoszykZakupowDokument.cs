using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DmKoszykZakupowDokument
{
    public int SprDokNumerId { get; set; }

    public string? GrupaCenowa { get; set; }

    public string? KontrahentRodzaj { get; set; }

    public string? KontrahentPodmiot { get; set; }

    public string? KontrahentBranza { get; set; }

    public string? KontrahentZrodlo { get; set; }

    public int MiejscowoscId { get; set; }

    public int GeoId { get; set; }

    public int ObszarId { get; set; }

    public string? Podmiot { get; set; }

    public int SposobDostawyId { get; set; }
}
