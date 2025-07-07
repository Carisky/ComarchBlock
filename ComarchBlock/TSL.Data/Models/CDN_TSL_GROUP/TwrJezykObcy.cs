using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class TwrJezykObcy
{
    public int TwrJTwrJid { get; set; }

    public int TwrJTwrId { get; set; }

    public int TwrJESklepId { get; set; }

    public short TwrJJezykId { get; set; }

    public string TwrJNazwa { get; set; } = null!;

    public string TwrJNazwaHtml { get; set; } = null!;

    public string TwrJOpis { get; set; } = null!;

    public string TwrJOpisHtml { get; set; } = null!;

    public string TwrJOpisKrotki { get; set; } = null!;

    public string TwrJMetaTytul { get; set; } = null!;

    public string TwrJMetaSlowaKluczowe { get; set; } = null!;

    public string TwrJMetaOpis { get; set; } = null!;

    public string TwrJLink { get; set; } = null!;

    public string TwrJSzukaj { get; set; } = null!;

    public virtual Towary TwrJTwr { get; set; } = null!;
}
