using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdOperacjePauzy
{
    public int PpyId { get; set; }

    public int? PpyPczid { get; set; }

    public int? PpyTerminStart { get; set; }

    public int? PpyTerminKoniec { get; set; }

    public int? PpyCzasRozliczeniowy { get; set; }

    public int? PpyPrzyczynaPauzy { get; set; }

    public int? PpyOpeNumer { get; set; }

    public int? PpyDataDodania { get; set; }

    public virtual ProdCzynnosci? PpyPcz { get; set; }
}
