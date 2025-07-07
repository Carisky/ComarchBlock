using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdIoTczujniki
{
    public int PczuId { get; set; }

    public string? PczuNumer { get; set; }

    public string? PczuNazwa { get; set; }

    public string? PczuOpis { get; set; }

    public byte? PczuArchiwalny { get; set; }

    public int? PczuOpeWnumer { get; set; }

    public int? PczuOpeMnumer { get; set; }

    public int? PczuDataCzasW { get; set; }

    public int? PczuDataCzasM { get; set; }

    public virtual ICollection<ProdIoTzdarzenium> ProdIoTzdarzenia { get; set; } = new List<ProdIoTzdarzenium>();

    public virtual ICollection<ProdObiektyCzujniki> ProdObiektyCzujnikis { get; set; } = new List<ProdObiektyCzujniki>();
}
