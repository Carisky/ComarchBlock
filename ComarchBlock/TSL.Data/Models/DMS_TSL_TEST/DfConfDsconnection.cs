using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfDsconnection
{
    public int DscId { get; set; }

    public int DscDssfromId { get; set; }

    public int DscDsstoId { get; set; }

    public bool DscArchival { get; set; }

    public string? DscGuid { get; set; }

    public virtual DfConfDsscheme DscDssfrom { get; set; } = null!;

    public virtual DfConfDsscheme DscDssto { get; set; } = null!;
}
