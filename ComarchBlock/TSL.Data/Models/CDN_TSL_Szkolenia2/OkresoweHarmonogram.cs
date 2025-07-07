using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class OkresoweHarmonogram
{
    public int OkHOkHid { get; set; }

    public int OkHOkEid { get; set; }

    public DateTime OkHData { get; set; }

    public decimal OkHKwota { get; set; }

    public virtual OkresoweElem OkHOkE { get; set; } = null!;
}
