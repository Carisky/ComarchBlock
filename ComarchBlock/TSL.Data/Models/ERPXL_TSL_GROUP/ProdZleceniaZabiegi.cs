using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdZleceniaZabiegi
{
    public int PzzId { get; set; }

    public int? PzzTechnologiaZabieg { get; set; }

    public short? PzzLp { get; set; }

    public int? PzzPczId { get; set; }

    public string? PzzKod { get; set; }

    public string? PzzNazwa { get; set; }

    public decimal? PzzIlosc { get; set; }

    public string? PzzNrInstrukcji { get; set; }

    public string? PzzOpis { get; set; }

    public byte? PzzWykonano { get; set; }

    public int? PzzDataWykonania { get; set; }

    public int? PzzOpeW { get; set; }

    public virtual ProdCzynnosci? PzzPcz { get; set; }
}
