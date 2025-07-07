using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PicoLogNag
{
    public int PcNId { get; set; }

    public int? PcNPcKid { get; set; }

    public short? PcNStatus { get; set; }

    public short? PcNTyp { get; set; }

    public DateTime? PcNDataStart { get; set; }

    public DateTime? PcNDataKoniec { get; set; }

    public string? PcNKomputer { get; set; }

    public int? PcNPoziom { get; set; }

    public virtual ICollection<PicoLogElem> PicoLogElems { get; set; } = new List<PicoLogElem>();
}
