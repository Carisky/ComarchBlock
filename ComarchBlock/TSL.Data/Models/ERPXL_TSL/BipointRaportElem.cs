using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class BipointRaportElem
{
    public int BreId { get; set; }

    public int? BreBrdid { get; set; }

    public short? BreLp { get; set; }

    public int? BreRaportId { get; set; }

    public string? BreKontekst { get; set; }

    public string? BreNazwa { get; set; }

    public int? BreTstamp { get; set; }

    public int? BreKontekstId { get; set; }

    public virtual BipointRaportDef? BreBrd { get; set; }
}
