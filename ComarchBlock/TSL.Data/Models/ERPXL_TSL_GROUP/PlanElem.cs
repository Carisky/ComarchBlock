using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PlanElem
{
    public int PleId { get; set; }

    public int? PlePlan { get; set; }

    public int? PleOkres { get; set; }

    public short? PleTwrTyp { get; set; }

    public int? PleTwrNumer { get; set; }

    public decimal? PleIloscPoprzednia { get; set; }

    public decimal? PleIlosc { get; set; }

    public string? PleJmZ { get; set; }

    public byte? PleTypJm { get; set; }

    public byte? PleJmFormat { get; set; }

    public byte? PleJmFormatZ { get; set; }

    public decimal? PlePrzeliczM { get; set; }

    public decimal? PlePrzeliczL { get; set; }

    public int? PleTechnologia { get; set; }
}
