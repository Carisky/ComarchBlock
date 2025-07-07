using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SlwDefPowiazaniaKont
{
    public int SdpkId { get; set; }

    public byte? SdpkTypKonta { get; set; }

    public int? SdpkSlwId { get; set; }

    public virtual Slowniki? SdpkSlw { get; set; }

    public virtual ICollection<SlwFunkcjeKontum> SlwFunkcjeKonta { get; set; } = new List<SlwFunkcjeKontum>();
}
