using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class WyposazeniePowiazanium
{
    public int WypPWypPid { get; set; }

    public int? WypPWypId { get; set; }

    public int? WypPDokumentTyp { get; set; }

    public int? WypPDokumentId { get; set; }

    public DateTime? WypPDataDok { get; set; }

    public string? WypPNumer { get; set; }

    public decimal WypPKwota { get; set; }

    public string? WypPOpis { get; set; }

    public virtual Wyposazenie? WypPWyp { get; set; }
}
