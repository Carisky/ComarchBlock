using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KluczeParametry
{
    public int KlpId { get; set; }

    public int? KlpKlnid { get; set; }

    public string? KlpNazwa { get; set; }

    public virtual KluczeNag? KlpKln { get; set; }

    public virtual ICollection<KsoParametry> KsoParametries { get; set; } = new List<KsoParametry>();
}
