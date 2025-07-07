using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Sfpodpisy
{
    public int SfpId { get; set; }

    public int? SfpSfnid { get; set; }

    public string? SfpNazwa { get; set; }

    public byte? SfpPodpis { get; set; }

    public byte? SfpOdmowa { get; set; }

    public string? SfpOdcisk { get; set; }

    public virtual Sfnag? SfpSfn { get; set; }
}
