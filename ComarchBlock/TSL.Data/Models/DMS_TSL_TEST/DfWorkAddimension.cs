using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkAddimension
{
    public int AddId { get; set; }

    public int AddAdhid { get; set; }

    public string AddName { get; set; } = null!;

    public int AddNatSystemId { get; set; }

    public virtual DfWorkAdheader AddAdh { get; set; } = null!;

    public virtual ICollection<DfWorkAdvalue> DfWorkAdvalues { get; set; } = new List<DfWorkAdvalue>();
}
