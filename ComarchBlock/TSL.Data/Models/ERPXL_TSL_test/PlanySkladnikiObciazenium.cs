using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PlanySkladnikiObciazenium
{
    public int PsoId { get; set; }

    public int? PsoPogid { get; set; }

    public short? PsoObiTyp { get; set; }

    public int? PsoObiNumer { get; set; }

    public virtual ICollection<PlanyElementySkladnikow> PlanyElementySkladnikows { get; set; } = new List<PlanyElementySkladnikow>();

    public virtual PlanyObciazeniaGniazd? PsoPog { get; set; }
}
