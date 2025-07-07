using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PlaceElementySkladniki
{
    public int PesId { get; set; }

    public int? PesPewid { get; set; }

    public short? PesLpltyp { get; set; }

    public byte? PesNaliczPoElem { get; set; }

    public int? PesPredefiniowany { get; set; }

    public int? PesLp { get; set; }

    public string? PesKod { get; set; }

    public string? PesNazwa { get; set; }

    public byte? PesTyp { get; set; }

    public string? PesSql { get; set; }
}
