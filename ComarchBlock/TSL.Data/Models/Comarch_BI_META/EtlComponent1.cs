using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class EtlComponent1
{
    public int MecId { get; set; }

    public DateTime? MecTsinsert { get; set; }

    public string? MecModifiedBy { get; set; }

    public string? MecName { get; set; }

    public string? MecAction { get; set; }

    public int? MecIsMigrated { get; set; }

    public DateTime? MecTsmigrate { get; set; }

    public string? MecNameOld { get; set; }

    public int? MecEcid { get; set; }
}
