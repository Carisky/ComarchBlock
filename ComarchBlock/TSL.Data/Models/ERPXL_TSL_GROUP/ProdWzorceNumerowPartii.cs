using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdWzorceNumerowPartii
{
    public int WnpId { get; set; }

    public string? WnpKod { get; set; }

    public string? WnpNazwa { get; set; }

    public byte? WnpRodzaj { get; set; }

    public string? WnpSql { get; set; }

    public byte? WnpWspolnySeparator { get; set; }

    public int? WnpSeparator { get; set; }
}
