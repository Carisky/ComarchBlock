using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymZestawieniaBudzet
{
    public int ZstId { get; set; }

    public string ZstOrgId { get; set; } = null!;

    public int? ZstParId { get; set; }

    public string? ZstPelnaNazwa { get; set; }

    public string? ZstZnakpozycji { get; set; }
}
