using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class TwrGrupyJezykObcy
{
    public int TwGjTwGjid { get; set; }

    public int TwGjTwGid { get; set; }

    public short TwGjJezykId { get; set; }

    public string TwGjNazwa { get; set; } = null!;

    public string TwGjOpisHtml { get; set; } = null!;

    public string TwGjOpisKrotki { get; set; } = null!;

    public string TwGjMetaTytul { get; set; } = null!;

    public string TwGjMetaSlowaKluczowe { get; set; } = null!;

    public string TwGjMetaOpis { get; set; } = null!;

    public string TwGjLink { get; set; } = null!;

    public string TwGjSzukaj { get; set; } = null!;

    public string TwGjNazwaNag { get; set; } = null!;

    public virtual TwrGrupy TwGjTwG { get; set; } = null!;
}
