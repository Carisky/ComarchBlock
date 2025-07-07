using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SchematRodzajDaty
{
    public short ScrGidtyp { get; set; }

    public int? ScrGidfirma { get; set; }

    public int ScrGidnumer { get; set; }

    public short ScrGidlp { get; set; }

    public short? ScrLp { get; set; }

    public byte? ScrRodzajDaty { get; set; }

    public string? ScrWarunek { get; set; }

    public string? ScrWarunekSymb { get; set; }

    public byte? ScrWarunekTyp { get; set; }

    public virtual Schematy Schematy { get; set; } = null!;
}
