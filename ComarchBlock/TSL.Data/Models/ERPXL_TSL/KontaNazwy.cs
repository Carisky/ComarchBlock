using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KontaNazwy
{
    public int KkzKksNumer { get; set; }

    public int KkzCharSet { get; set; }

    public string? KkzNazwa { get; set; }

    public virtual Kontum KkzKksNumerNavigation { get; set; } = null!;
}
