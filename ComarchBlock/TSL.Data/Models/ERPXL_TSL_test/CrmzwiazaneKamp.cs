using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class CrmzwiazaneKamp
{
    public int CzkId { get; set; }

    public int? CzkCknnumer { get; set; }

    public short? CzkCknlp { get; set; }

    public int? CzkCknzwNumer { get; set; }

    public short? CzkCknzwLp { get; set; }

    public int? CzkData { get; set; }

    public int? CzkDataMod { get; set; }

    public byte? CzkStatus { get; set; }

    public byte? CzkWarunek { get; set; }

    public int? CzkFiaskoId { get; set; }

    public int? CzkTermin { get; set; }

    public virtual CrmkampNag? CzkCknnumerNavigation { get; set; }

    public virtual CrmkampNag? CzkCknzwNumerNavigation { get; set; }
}
