using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class WfDefAkcje
{
    public int WdaId { get; set; }

    public int? WdaWdpid { get; set; }

    public string? WdaNazwa { get; set; }

    public int? WdaKluczowa { get; set; }

    public short? WdaWstecz { get; set; }

    public string? WdaParametry { get; set; }

    public int? WdaWdpuruchomId { get; set; }

    public byte? WdaDozwoloneInneAkcje { get; set; }

    public byte? WdaUruchomGdyZamkniety { get; set; }

    public byte? WdaArchiwizujEmail { get; set; }
}
