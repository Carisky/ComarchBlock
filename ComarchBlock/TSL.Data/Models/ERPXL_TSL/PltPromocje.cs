using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PltPromocje
{
    public int PprId { get; set; }

    public int? PprPrmId { get; set; }

    public int? PprPltId { get; set; }

    public decimal? PprWartosc { get; set; }

    public int? PprTerminMaks { get; set; }

    public byte? PprTyp { get; set; }

    public int? PprDataOd { get; set; }

    public int? PprDataDo { get; set; }

    public virtual PrmKarty? PprPrm { get; set; }
}
