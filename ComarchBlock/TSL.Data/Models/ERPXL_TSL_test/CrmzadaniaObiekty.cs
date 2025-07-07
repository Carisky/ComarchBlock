using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class CrmzadaniaObiekty
{
    public int CzoCdzId { get; set; }

    public int CzoSseNumer { get; set; }

    public short CzoSseLp { get; set; }

    public short CzoObiTyp { get; set; }

    public int CzoObiNumer { get; set; }

    public int? CzoDataUtworzenia { get; set; }
}
