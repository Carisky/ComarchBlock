using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymZestawieniaBudzet
{
    public int ZstId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? ZstRowId { get; set; }

    public string? ZstZnakpozycji { get; set; }

    public string? ZstPelnaNazwa { get; set; }

    public string ZstOrgId { get; set; } = null!;

    public int? ZstParId { get; set; }
}
