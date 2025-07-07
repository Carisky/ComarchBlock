using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SlownikiAplikacje
{
    public int SlaId { get; set; }

    public int? SlaPckId { get; set; }

    public int? SlaMapId { get; set; }

    public string? SlaZrdId { get; set; }

    public string? SlaNazwa { get; set; }

    public int? SlaTyp { get; set; }

    public byte? SlaMapowanie { get; set; }

    public int? SlaMapTyp { get; set; }
}
