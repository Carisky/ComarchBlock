using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KntVat
{
    public int KnVNumer { get; set; }

    public short? KnVKnAtyp { get; set; }

    public int? KnVKnAfirma { get; set; }

    public int? KnVKnAnumer { get; set; }

    public short? KnVKnAlp { get; set; }

    public string? KnVNip { get; set; }

    public int? KnVData { get; set; }

    public short? KnVVatwynik { get; set; }

    public string? KnVRequestId { get; set; }
}
