using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdOperacjePominiete
{
    public int PoppId { get; set; }

    public int? PoppPczid { get; set; }

    public int? PoppPrzyczynaPominiecia { get; set; }

    public int? PoppOpeNumer { get; set; }

    public int? PoppDataPominiecia { get; set; }
}
