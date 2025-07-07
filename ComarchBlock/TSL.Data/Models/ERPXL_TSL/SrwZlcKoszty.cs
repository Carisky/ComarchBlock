using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SrwZlcKoszty
{
    public int SzkId { get; set; }

    public int? SzkSznid { get; set; }

    public string? SzkKod { get; set; }

    public string? SzkNazwa { get; set; }

    public string? SzkDokument { get; set; }

    public decimal? SzkWartosc { get; set; }

    public string? SzkOpis { get; set; }

    public int? SzkDataDodania { get; set; }

    public int? SzkOpeNumerD { get; set; }

    public virtual SrwZlcNag? SzkSzn { get; set; }
}
