using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class DaneRynkowe
{
    public int DrkId { get; set; }

    public int? DrkDrnId { get; set; }

    public int? DrkSlwId { get; set; }

    public int? DrkCenaLp { get; set; }

    public int? DrkTsdata { get; set; }

    public string? DrkKomentarz { get; set; }

    public short? DrkOpeTypM { get; set; }

    public int? DrkOpeFirmaM { get; set; }

    public int? DrkOpeNumerM { get; set; }

    public short? DrkOpeLpM { get; set; }

    public virtual ICollection<DaneRynkoweCeny> DaneRynkoweCenies { get; set; } = new List<DaneRynkoweCeny>();

    public virtual DaneRynkoweNotowanium? DrkDrn { get; set; }
}
