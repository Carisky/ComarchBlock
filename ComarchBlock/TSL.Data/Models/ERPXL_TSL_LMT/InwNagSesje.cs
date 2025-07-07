using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class InwNagSesje
{
    public int InSId { get; set; }

    public int? InSSesjaId { get; set; }

    public int? InSInNid { get; set; }

    public byte? InSTyp { get; set; }
}
