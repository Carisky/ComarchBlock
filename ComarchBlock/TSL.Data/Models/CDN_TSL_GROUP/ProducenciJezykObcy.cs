using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class ProducenciJezykObcy
{
    public int PrdJPrdJid { get; set; }

    public int PrdJPrdId { get; set; }

    public short PrdJJezykId { get; set; }

    public string PrdJOpisHtml { get; set; } = null!;

    public string PrdJOpisKrotki { get; set; } = null!;

    public string PrdJMetaTytul { get; set; } = null!;

    public string PrdJMetaSlowaKluczowe { get; set; } = null!;

    public string PrdJMetaOpis { get; set; } = null!;

    public string PrdJNazwaNag { get; set; } = null!;

    public virtual Producenci PrdJPrd { get; set; } = null!;
}
