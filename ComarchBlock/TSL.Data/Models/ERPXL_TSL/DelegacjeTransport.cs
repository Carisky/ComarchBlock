using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class DelegacjeTransport
{
    public int DgtId { get; set; }

    public int? DgtSrodekTransId { get; set; }

    public int? DgtSamId { get; set; }

    public string? DgtNrRejOpis { get; set; }

    public int? DgtDlgnumer { get; set; }
}
