using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class DtsZmienne
{
    public int DzmId { get; set; }

    public int? DzmDzeid { get; set; }

    public string? DzmNazwaParametru { get; set; }

    public string? DzmWartoscParametru { get; set; }

    public string? DzmOpisParametru { get; set; }

    public short? DzmTypParametru { get; set; }

    public string? DzmFormatParametru { get; set; }
}
