using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class MarkiJezykObcy
{
    public int MrkJMrkJid { get; set; }

    public int MrkJMrkId { get; set; }

    public short MrkJJezykId { get; set; }

    public string MrkJOpisHtml { get; set; } = null!;

    public string MrkJOpisKrotki { get; set; } = null!;

    public string MrkJMetaTytul { get; set; } = null!;

    public string MrkJMetaSlowaKluczowe { get; set; } = null!;

    public string MrkJMetaOpis { get; set; } = null!;

    public string MrkJNazwaNag { get; set; } = null!;

    public virtual Marki MrkJMrk { get; set; } = null!;
}
