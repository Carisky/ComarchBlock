using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Sfzalaczniki
{
    public int SfzId { get; set; }

    public int? SfzSfnid { get; set; }

    public string? SfzNazwa { get; set; }

    public int? SfzTyp { get; set; }

    public byte[]? SfzPlik { get; set; }

    public virtual Sfnag? SfzSfn { get; set; }
}
