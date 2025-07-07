using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SlwTypyInwentaryzacjiPo
{
    public int SltiId { get; set; }

    public int? SltiSlwId { get; set; }

    public string? SltiGuid { get; set; }

    public int? SltiRodzOdc { get; set; }

    public byte? SltiDodPoz { get; set; }

    public byte? SltiOtwPoz { get; set; }

    public byte? SltiWyswRozbZamk { get; set; }

    public byte? SltiOpeOtwPoz { get; set; }

    public byte? SltiIloscDoc { get; set; }

    public byte? SltiSortKat { get; set; }

    public virtual Slowniki? SltiSlw { get; set; }
}
