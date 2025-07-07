using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ZestKselem
{
    public short? ZkeGidtyp { get; set; }

    public int? ZkeGidfirma { get; set; }

    public int ZkeGidnumer { get; set; }

    public short ZkeGidlp { get; set; }

    public string? ZkeNazwa { get; set; }

    public short? ZkePozycja1 { get; set; }

    public short? ZkePozycja2 { get; set; }

    public short? ZkePozycja3 { get; set; }

    public short? ZkePozycja4 { get; set; }

    public short? ZkePozycja5 { get; set; }

    public short? ZkePozycja6 { get; set; }

    public short? ZkePozycja7 { get; set; }

    public short? ZkePozycja8 { get; set; }

    public short? ZkePozycja9 { get; set; }

    public short? ZkePozycja10 { get; set; }

    public byte? ZkeZnak { get; set; }

    public byte? ZkeBufor { get; set; }

    public int? ZkeSfeid { get; set; }

    public byte? ZkeSfpominEksport { get; set; }

    public virtual ICollection<ZestKsdef> ZestKsdefs { get; set; } = new List<ZestKsdef>();

    public virtual ICollection<ZestKswyniki> ZestKswynikis { get; set; } = new List<ZestKswyniki>();

    public virtual ZestKsnag ZkeGidnumerNavigation { get; set; } = null!;
}
