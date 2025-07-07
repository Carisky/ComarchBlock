using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdIoTkomunikaty
{
    public int PikoId { get; set; }

    public string? PikoTresc { get; set; }

    public int? PikoOpeWnumer { get; set; }

    public int? PikoDataCzasW { get; set; }

    public int? PikoOpeMnumer { get; set; }

    public int? PikoDataCzasM { get; set; }

    public byte? PikoArchiwalny { get; set; }

    public virtual ICollection<ProdIoTkomunikatyZdarzenium> ProdIoTkomunikatyZdarzenia { get; set; } = new List<ProdIoTkomunikatyZdarzenium>();
}
