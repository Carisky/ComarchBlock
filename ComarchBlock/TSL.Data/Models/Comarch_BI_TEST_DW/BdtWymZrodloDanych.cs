using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymZrodloDanych
{
    public int ZrodId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? ZrodRowId { get; set; }

    public DateTime ZrodTsupdate { get; set; }

    public DateTime ZrodTsinsert { get; set; }

    public byte[] ZrodRowVersion { get; set; } = null!;

    public string ZrodOrgId { get; set; } = null!;

    public string ZrodOpis { get; set; } = null!;

    public string ZrodNazwa { get; set; } = null!;

    public int ZrodGid { get; set; }
}
