using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdCzynnosciTerminy
{
    public int PctId { get; set; }

    public int PctCzynnosc { get; set; }

    public int? PctTerminOd { get; set; }

    public int? PctTerminDo { get; set; }

    public int? PctCzasRozliczeniowy { get; set; }

    public virtual ProdCzynnosci PctCzynnoscNavigation { get; set; } = null!;
}
