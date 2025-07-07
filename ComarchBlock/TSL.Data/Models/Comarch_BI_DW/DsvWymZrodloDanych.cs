using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymZrodloDanych
{
    public int ZrodGid { get; set; }

    public int ZrodId { get; set; }

    public string ZrodNazwa { get; set; } = null!;

    public string ZrodOpis { get; set; } = null!;

    public string ZrodOrgId { get; set; } = null!;

    public byte[] ZrodRowVersion { get; set; } = null!;

    public DateTime ZrodTsinsert { get; set; }

    public DateTime ZrodTsupdate { get; set; }
}
