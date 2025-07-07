using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KntKody
{
    public int KnPId { get; set; }

    public string KnPKodP { get; set; } = null!;

    public string KnPMiasto { get; set; } = null!;

    public int? KnPSzerGeog { get; set; }

    public int? KnPDlugGeog { get; set; }

    public int? KnPRegion { get; set; }

    public string? KnPWojewodztwo { get; set; }

    public string? KnPPowiat { get; set; }

    public string? KnPGmina { get; set; }

    public string? KnPKraj { get; set; }

    public virtual ICollection<Rejony> KkrRejons { get; set; } = new List<Rejony>();
}
