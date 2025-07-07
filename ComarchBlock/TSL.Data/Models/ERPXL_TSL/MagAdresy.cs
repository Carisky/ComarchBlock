using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class MagAdresy
{
    public int MgAId { get; set; }

    public int? MgAMgOid { get; set; }

    public string? MgASegment1 { get; set; }

    public string? MgASegment2 { get; set; }

    public string? MgASegment3 { get; set; }

    public string? MgASegment4 { get; set; }

    public int? MgAMpaid { get; set; }

    public string? MgAOpis { get; set; }

    public int? MgACzasModyfikacji { get; set; }

    public int? MgAOpeMnumer { get; set; }
}
