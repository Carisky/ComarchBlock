using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class MemSymbole
{
    public int MesSymbolId { get; set; }

    public byte? MesTyp { get; set; }

    public string? MesSymbol { get; set; }

    public string? MesOpis { get; set; }

    public virtual ICollection<MemDokElem> MemDokElems { get; set; } = new List<MemDokElem>();
}
