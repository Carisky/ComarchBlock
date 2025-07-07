using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class KluczeElem
{
    public int KleId { get; set; }

    public int? KleKlnid { get; set; }

    public string? KleNazwa { get; set; }

    public string? KleNazwa2 { get; set; }

    public decimal? KleWspolczynnik { get; set; }

    public virtual KluczeNag? KleKln { get; set; }
}
