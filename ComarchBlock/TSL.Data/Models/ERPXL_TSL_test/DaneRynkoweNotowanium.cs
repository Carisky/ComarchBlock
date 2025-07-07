using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class DaneRynkoweNotowanium
{
    public int DrnId { get; set; }

    public int? DrnTsotwarcie { get; set; }

    public int? DrnTszamkniecie { get; set; }

    public short? DrnAktywny { get; set; }

    public short? DrnFlagaZapisu { get; set; }

    public string? DrnOpis { get; set; }

    public short? DrnOpeTypO { get; set; }

    public int? DrnOpeFirmaO { get; set; }

    public int? DrnOpeNumerO { get; set; }

    public short? DrnOpeLpO { get; set; }

    public short? DrnOpeTypZ { get; set; }

    public int? DrnOpeFirmaZ { get; set; }

    public int? DrnOpeNumerZ { get; set; }

    public short? DrnOpeLpZ { get; set; }

    public virtual ICollection<DaneRynkowe> DaneRynkowes { get; set; } = new List<DaneRynkowe>();
}
