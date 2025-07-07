using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class ZadaniaWtle
{
    public int ZwtZwtId { get; set; }

    public int ZwtOpeId { get; set; }

    public short ZwtTyp { get; set; }

    public DateTime ZwtDataRekomendowanyStart { get; set; }

    public string? ZwtParametry { get; set; }

    public DateTime? ZwtDataOstatniaAktualizacja { get; set; }

    public bool ZwtWykonywanie { get; set; }

    public Guid ZwtBazGuid { get; set; }

    public virtual Operatorzy ZwtOpe { get; set; } = null!;
}
