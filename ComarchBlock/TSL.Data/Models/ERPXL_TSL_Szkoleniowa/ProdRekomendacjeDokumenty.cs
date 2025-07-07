using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdRekomendacjeDokumenty
{
    public int PredPrepid { get; set; }

    public short PredDokTyp { get; set; }

    public int PredDokNumer { get; set; }

    public int PredDokLp { get; set; }

    public int? PredDataZwiazania { get; set; }

    public virtual ProdRekomendacjeProdukty PredPrep { get; set; } = null!;
}
