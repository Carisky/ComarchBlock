using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdPlanyMaterialyDoZamowienium
{
    public int PptzPptgid { get; set; }

    public decimal? PptzIloscDoZamowienia { get; set; }

    public decimal? PptzIloscZwiazana { get; set; }

    public virtual ICollection<ProdPlanyMaterialy> PptgPpts { get; set; } = new List<ProdPlanyMaterialy>();
}
