using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TwrAtrybuty
{
    public int TwATwAid { get; set; }

    public int TwADeAid { get; set; }

    public int? TwATwrId { get; set; }

    public int? TwASrUid { get; set; }

    public int? TwASrRid { get; set; }

    public int? TwASrZid { get; set; }

    public byte TwAZalezny { get; set; }

    public byte? TwAEsklep { get; set; }

    public string TwAWartoscTxt { get; set; } = null!;

    public byte TwACzyKopiowac { get; set; }

    public byte TwACzyKod { get; set; }

    public byte TwACzyPrzenosic { get; set; }

    public byte TwACzyDrukowac { get; set; }

    public int? TwADabid { get; set; }

    public byte TwACzyObowiazkowySerwis { get; set; }

    public byte TwACzyObowiazkowyDostawy { get; set; }

    public byte TwACzyPrzenosicNaDostawy { get; set; }

    public int? TwARodzajId { get; set; }

    public int? TwAUrzId { get; set; }

    public int? TwASourceId { get; set; }

    public short TwAJezykId { get; set; }

    public int? TwALp { get; set; }

    public byte TwAAtrybutGrupujacyFantom { get; set; }

    public virtual DefAtrybuty TwADeA { get; set; } = null!;

    public virtual SrsRodzajeU? TwASrR { get; set; }

    public virtual SrsUrzadzenium? TwASrU { get; set; }

    public virtual SrsZlecenium? TwASrZ { get; set; }

    public virtual Towary? TwATwr { get; set; }

    public virtual ICollection<TwrKntAtrybuty> TwrKntAtrybuties { get; set; } = new List<TwrKntAtrybuty>();
}
