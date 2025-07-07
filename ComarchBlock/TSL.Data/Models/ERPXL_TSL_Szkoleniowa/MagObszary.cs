using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class MagObszary
{
    public int MgOId { get; set; }

    public short? MgOMagTyp { get; set; }

    public int? MgOMagNumer { get; set; }

    public string? MgOKod { get; set; }

    public string? MgONazwa { get; set; }

    public byte? MgOTowary { get; set; }

    public int? MgOCzasModyfikacji { get; set; }

    public int? MgOOpeMnumer { get; set; }

    public virtual ICollection<MagTwrObszary> MagTwrObszaries { get; set; } = new List<MagTwrObszary>();
}
