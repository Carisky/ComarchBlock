using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Sesje
{
    public int? SesAktywna { get; set; }

    public int SesSesjaId { get; set; }

    public string? SesOpeIdent { get; set; }

    public string? SesModul { get; set; }

    public string? SesKomputer { get; set; }

    public int? SesInstancja { get; set; }

    public string? SesNrWersji { get; set; }

    public int? SesStart { get; set; }

    public int? SesStop { get; set; }

    public short? SesClarionSpid { get; set; }

    public short? SesAdospid { get; set; }

    public string? SesJezyk { get; set; }

    public byte? SesSesjaZew { get; set; }

    public int? SesFrsId { get; set; }

    public string? SesOpePident { get; set; }
}
