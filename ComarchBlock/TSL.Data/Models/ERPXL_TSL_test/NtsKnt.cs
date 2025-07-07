using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class NtsKnt
{
    public int NtKNtNnumer { get; set; }

    public short NtKLp { get; set; }

    public short? NtKKntTyp { get; set; }

    public int? NtKKntNumer { get; set; }

    public virtual NtsNag NtKNtNnumerNavigation { get; set; } = null!;
}
