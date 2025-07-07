using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class PltPromocje
{
    public int PprId { get; set; }

    public int? PprPrmId { get; set; }

    public int? PprPltId { get; set; }

    public decimal? PprWartosc { get; set; }

    public virtual PrmKarty? PprPrm { get; set; }
}
