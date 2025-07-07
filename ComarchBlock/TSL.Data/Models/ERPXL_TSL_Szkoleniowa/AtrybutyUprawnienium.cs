using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class AtrybutyUprawnienium
{
    public int AtUAtkId { get; set; }

    public int AtUOpeNumer { get; set; }

    public byte? AtUPrawa { get; set; }

    public int? AtUDataModyfikacji { get; set; }
}
