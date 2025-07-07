using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class CrmkntEtapyTwr
{
    public int CptId { get; set; }

    public int? CptCekid { get; set; }

    public int? CptCktid { get; set; }

    public decimal? CptPrzychodIlosc { get; set; }

    public virtual CrmkntEtapy? CptCek { get; set; }

    public virtual CrmkampTwr? CptCkt { get; set; }
}
