using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SekDokTypy
{
    public int SdtId { get; set; }

    public int? SdtProcesSpd { get; set; }

    public int? SdtProcesSwd { get; set; }

    public int? SdtProcesSww { get; set; }

    public string? SdtNazwa { get; set; }

    public short? SdtArchiwalny { get; set; }

    public byte? SdtWartoscDom { get; set; }

    public string? SdtOpis { get; set; }

    public virtual ICollection<SekTypySerie> SekTypySeries { get; set; } = new List<SekTypySerie>();
}
