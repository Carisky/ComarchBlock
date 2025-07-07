using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class UmwTypy
{
    public int UmTId { get; set; }

    public string? UmTKod { get; set; }

    public string? UmTNazwa { get; set; }

    public byte? UmTCzyPozycjeTwr { get; set; }

    public int? UmTRodzajId { get; set; }

    public int? UmTOjciecId { get; set; }

    public decimal? UmTNadwyzkaTwr { get; set; }

    public byte? UmTKontrolujIlosc { get; set; }
}
