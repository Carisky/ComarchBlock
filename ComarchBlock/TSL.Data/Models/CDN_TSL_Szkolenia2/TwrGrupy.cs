using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TwrGrupy
{
    public int TwGTwGid { get; set; }

    public short TwGGidtyp { get; set; }

    public int? TwGGidfirma { get; set; }

    public int TwGGidnumer { get; set; }

    public short? TwGGidlp { get; set; }

    public short TwGGrOtyp { get; set; }

    public int? TwGGrOfirma { get; set; }

    public int TwGGrOnumer { get; set; }

    public short? TwGGrOlp { get; set; }

    public string TwGKod { get; set; } = null!;

    public string TwGNazwa { get; set; } = null!;

    public int? TwGCzasModyfikacji { get; set; }

    public int? TwGESklepLp { get; set; }

    public virtual ICollection<TwrGrupyJezykObcy> TwrGrupyJezykObcies { get; set; } = new List<TwrGrupyJezykObcy>();
}
