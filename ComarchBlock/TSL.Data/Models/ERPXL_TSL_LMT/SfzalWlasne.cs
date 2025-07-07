using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SfzalWlasne
{
    public int SfzwId { get; set; }

    public int? SfzwSfnid { get; set; }

    public string? SfzwNazwa { get; set; }

    public string? SfzwModyfikuje { get; set; }

    public string? SfzwOpis { get; set; }

    public byte[]? SfzwPlik { get; set; }

    public virtual Sfnag? SfzwSfn { get; set; }
}
