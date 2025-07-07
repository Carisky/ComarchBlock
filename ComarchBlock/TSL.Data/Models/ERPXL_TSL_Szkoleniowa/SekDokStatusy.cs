using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SekDokStatusy
{
    public int SdsId { get; set; }

    public string? SdsNazwa { get; set; }

    public string? SdsKomentarzStatus { get; set; }

    public string? SdsKomentarz { get; set; }

    public byte? SdsArchiwalny { get; set; }

    public byte? SdsAkcja { get; set; }

    public string? SdsEmailTemat { get; set; }

    public string? SdsEmailTresc { get; set; }

    public byte? SdsPredefiniowany { get; set; }

    public byte? SdsOpisAnalit { get; set; }
}
