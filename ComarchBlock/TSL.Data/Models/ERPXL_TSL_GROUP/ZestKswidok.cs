using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ZestKswidok
{
    public short? ZkoGidtyp { get; set; }

    public int? ZkoGidfirma { get; set; }

    public int ZkoGidnumer { get; set; }

    public short? ZkoGidlp { get; set; }

    public short? ZkoZkntyp { get; set; }

    public int? ZkoZknfirma { get; set; }

    public int? ZkoZknnumer { get; set; }

    public short? ZkoZknlp { get; set; }

    public string? ZkoNazwa { get; set; }

    public string? ZkoOpis { get; set; }

    public short? ZkoStatyp { get; set; }

    public int? ZkoStafirma { get; set; }

    public int? ZkoStanumer { get; set; }

    public short? ZkoStalp { get; set; }

    public virtual ICollection<ZestKskolumny> ZestKskolumnies { get; set; } = new List<ZestKskolumny>();

    public virtual ICollection<ZestKszmienne> ZestKszmiennes { get; set; } = new List<ZestKszmienne>();
}
