using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class DaneBinarneGrupy
{
    public int DbgId { get; set; }

    public int? DbgOjciec { get; set; }

    public string? DbgNazwa { get; set; }

    public string? DbgOpis { get; set; }

    public virtual ICollection<DaneBinarne> DaneBinarnes { get; set; } = new List<DaneBinarne>();
}
