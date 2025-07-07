using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class InwOdc
{
    public int InOId { get; set; }

    public int? InOInAid { get; set; }

    public int? InOTstamp { get; set; }

    public short? InOOpeTyp { get; set; }

    public int? InOOpeFirma { get; set; }

    public int? InOOpeNumer { get; set; }

    public short? InOOpeLp { get; set; }

    public string? InONazwa { get; set; }

    public string? InOOpis { get; set; }

    public byte? InOStan { get; set; }

    public int? InOZewnetrznySys { get; set; }

    public int? InOZewnetrzneId { get; set; }

    public string? InOGuid { get; set; }

    public virtual InwArk? InOInA { get; set; }

    public virtual ICollection<InwOdcTwr> InwOdcTwrs { get; set; } = new List<InwOdcTwr>();
}
