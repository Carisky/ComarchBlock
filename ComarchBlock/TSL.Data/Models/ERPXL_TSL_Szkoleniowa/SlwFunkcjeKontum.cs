using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SlwFunkcjeKontum
{
    public int SfkId { get; set; }

    public byte? SfkOperator { get; set; }

    public string? SfkFunkcjaKonta { get; set; }

    public byte? SfkZnak { get; set; }

    public int? SfkSdpkid { get; set; }

    public virtual SlwDefPowiazaniaKont? SfkSdpk { get; set; }
}
