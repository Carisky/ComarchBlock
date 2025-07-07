using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TwrGrupy
{
    public short TwGGidtyp { get; set; }

    public int? TwGGidfirma { get; set; }

    public int TwGGidnumer { get; set; }

    public short? TwGGidlp { get; set; }

    public short TwGGrOtyp { get; set; }

    public int? TwGGrOfirma { get; set; }

    public int TwGGrOnumer { get; set; }

    public short? TwGGrOlp { get; set; }

    public string? TwGKod { get; set; }

    public string? TwGNazwa { get; set; }

    public int? TwGCzasModyfikacji { get; set; }

    public int TwGSyncId { get; set; }

    public int? TwGKategoriaBiid { get; set; }

    public virtual ICollection<PicoSzybkaSprzedaz> PicoSzybkaSprzedazs { get; set; } = new List<PicoSzybkaSprzedaz>();
}
