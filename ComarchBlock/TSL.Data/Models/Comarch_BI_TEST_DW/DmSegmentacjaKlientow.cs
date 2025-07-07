using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DmSegmentacjaKlientow
{
    public int KntId { get; set; }

    public string KntZrodlo { get; set; } = null!;

    public string KntNazwa { get; set; } = null!;

    public string KntGrupaCenowa { get; set; } = null!;

    public string KntBranza { get; set; } = null!;

    public string KntRodzaj { get; set; } = null!;

    public int KntObszarId { get; set; }

    public int KntMiejscowoscId { get; set; }

    public int KntSposobDostawyId { get; set; }

    public int KntGeoId { get; set; }

    public string KntPodmiot { get; set; } = null!;

    public int Wartosc { get; set; }

    public int Marza { get; set; }
}
