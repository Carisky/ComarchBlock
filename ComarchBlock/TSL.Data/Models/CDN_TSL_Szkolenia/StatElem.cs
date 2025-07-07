using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class StatElem
{
    public int StEStEid { get; set; }

    public int StELiczbaElemEksp { get; set; }

    public int StELiczbaElemImp { get; set; }

    public int StEStNid { get; set; }

    public short StETypElem { get; set; }
}
