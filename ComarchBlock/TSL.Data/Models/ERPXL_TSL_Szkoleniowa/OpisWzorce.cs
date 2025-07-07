using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class OpisWzorce
{
    public int OwwId { get; set; }

    public string? OwwKod { get; set; }

    public string? OwwNazwa { get; set; }

    public byte? OwwArchiwalny { get; set; }

    public byte? OwwRodzaj { get; set; }

    public int? OwwOpeWpr { get; set; }

    public int? OwwDataWpr { get; set; }

    public int? OwwOpeModyf { get; set; }

    public int? OwwDataModyf { get; set; }

    public short? OwwObttyp { get; set; }

    public int? OwwObtnumer { get; set; }

    public int? OwwPozycja { get; set; }

    public int? OwwFrsId { get; set; }
}
