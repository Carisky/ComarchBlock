using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class BnkZdarzeniaPodpisy
{
    public int BzdPBzdPid { get; set; }

    public int BzdPBzdId { get; set; }

    public int BzdPOpeId { get; set; }

    public DateTime BzdPData { get; set; }

    public string BzdPCertyfikatNazwa { get; set; } = null!;

    public string BzdPPodpis { get; set; } = null!;

    public virtual BnkZdarzenium BzdPBzd { get; set; } = null!;
}
