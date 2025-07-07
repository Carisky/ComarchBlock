using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DetalRoliczeniaZaleglosci
{
    public int DrzDrzid { get; set; }

    public int DrzDsdrzid { get; set; }

    public int DrzBzdId { get; set; }

    public int DrzDszkbid { get; set; }

    public int DrzStanDetalId { get; set; }

    public decimal DrzKwota { get; set; }

    public int? DrzStanSynchronizacji { get; set; }

    public DateTime? DrzTsExport { get; set; }
}
