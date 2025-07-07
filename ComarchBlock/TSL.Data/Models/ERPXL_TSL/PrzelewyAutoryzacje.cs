using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PrzelewyAutoryzacje
{
    public int PpaId { get; set; }

    public int? PpaPpnid { get; set; }

    public int? PpaOpeNumer { get; set; }

    public int? PpaData { get; set; }

    public string? PpaPodpis { get; set; }

    public virtual OpeKarty? PpaOpeNumerNavigation { get; set; }

    public virtual PrzelewyNag? PpaPpn { get; set; }
}
