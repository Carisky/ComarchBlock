using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PicoLogElem
{
    public int PcEId { get; set; }

    public int? PcEPcNid { get; set; }

    public short? PcEStatus { get; set; }

    public DateTime? PcEDataStart { get; set; }

    public short? PcEObiTyp { get; set; }

    public string? PcEObiIdent { get; set; }

    public int? PcEKod { get; set; }

    public string? PcEOpis { get; set; }

    public DateTime? PcEDataKoniec { get; set; }

    public int? PcEOjciec { get; set; }

    public virtual PicoLogNag? PcEPcN { get; set; }
}
