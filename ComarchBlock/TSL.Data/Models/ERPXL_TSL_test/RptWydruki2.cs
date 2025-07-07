using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class RptWydruki2
{
    public int RpW2Id { get; set; }

    public short? RpW2Rodzaj { get; set; }

    public string? RpW2Nazwa { get; set; }

    public string? RpW2Warunek { get; set; }

    public string? RpW2WarunekAuto { get; set; }

    public string? RpW2Opis { get; set; }

    public int? RpW2KopiaElektroniczna { get; set; }

    public virtual ICollection<RptFormaty2> RptFormaty2s { get; set; } = new List<RptFormaty2>();
}
