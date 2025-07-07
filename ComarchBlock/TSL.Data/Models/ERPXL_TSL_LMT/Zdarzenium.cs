using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Zdarzenium
{
    public int ZdaId { get; set; }

    public string? ZdaKomputer { get; set; }

    public int? ZdaCzas { get; set; }

    public int? ZdaGodzina { get; set; }

    public int? ZdaWatek { get; set; }

    public string? ZdaZdarzenie { get; set; }
}
