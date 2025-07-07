using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class WypElem
{
    public int WpeId { get; set; }

    public int? WpeWplid { get; set; }

    public int? WpePewid { get; set; }

    public int? WpeKodRsa { get; set; }

    public string? WpeKodRca { get; set; }

    public int? WpePozPitfirma { get; set; }

    public int? WpePozPitprac { get; set; }

    public int? WpeDataOd { get; set; }

    public int? WpeDataDo { get; set; }

    public short? WpeZrdTyp { get; set; }

    public int? WpeZrdNumer { get; set; }

    public string? WpeOpis { get; set; }

    public virtual Wyplaty? WpeWpl { get; set; }
}
