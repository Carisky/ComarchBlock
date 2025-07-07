using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdPlanyDokumenty
{
    public int PpdPplid { get; set; }

    public short PpdDokTyp { get; set; }

    public int PpdDokNumer { get; set; }

    public int? PpdDataZwiazania { get; set; }

    public int PpdPptgid { get; set; }

    public virtual ProdPlany PpdPpl { get; set; } = null!;
}
