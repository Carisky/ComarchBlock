using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PlanOkre
{
    public int PloId { get; set; }

    public int? PloPlan { get; set; }

    public int? PloOkresOd { get; set; }

    public int? PloOkresDo { get; set; }

    public string? PloNazwa { get; set; }
}
