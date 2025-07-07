using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class CrmetapyTwr
{
    public int CetId { get; set; }

    public int? CetCkenumer { get; set; }

    public short? CetCkelp { get; set; }

    public int? CetCktid { get; set; }

    public decimal? CetPrzychodIlosc { get; set; }

    public virtual CrmkampEtapy? CrmkampEtapy { get; set; }
}
