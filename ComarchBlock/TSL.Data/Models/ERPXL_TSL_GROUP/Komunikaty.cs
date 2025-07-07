using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Komunikaty
{
    public long KomId { get; set; }

    public string? KomOpeIdent { get; set; }

    public int? KomFrsId { get; set; }

    public string? KomModul { get; set; }

    public short? KomTypKom { get; set; }

    public int? KomIdKom { get; set; }

    public string? KomTresc { get; set; }

    public string? KomSzczegoly { get; set; }

    public byte[]? KomObraz { get; set; }

    public int? KomRozmiar { get; set; }

    public int? KomCzas { get; set; }

    public string? KomSciezka { get; set; }
}
