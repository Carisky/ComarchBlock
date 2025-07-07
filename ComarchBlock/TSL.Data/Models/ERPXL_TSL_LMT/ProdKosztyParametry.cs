using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdKosztyParametry
{
    public int KopId { get; set; }

    public int? KopPkoid { get; set; }

    public short? KopLp { get; set; }

    public byte? KopTyp { get; set; }

    public string? KopNazwa { get; set; }

    public string? KopWyrazenie { get; set; }

    public int? KopSlpId { get; set; }

    public virtual ProdKoszty? KopPko { get; set; }
}
