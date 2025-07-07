using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PrcRole
{
    public int PrRId { get; set; }

    public short PrRPrcTyp { get; set; }

    public int? PrRPrcFirma { get; set; }

    public int PrRPrcNumer { get; set; }

    public short PrRPrcLp { get; set; }

    public int PrRFrSid { get; set; }

    public int PrRRolId { get; set; }

    public int PrRDataOd { get; set; }

    public int PrRDataDo { get; set; }

    public int? PrROptimaId { get; set; }
}
