using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class DstOpisy
{
    public short? DsODstTyp { get; set; }

    public int? DsODstFirma { get; set; }

    public int DsODstNumer { get; set; }

    public short DsODstLp { get; set; }

    public byte? DsOTyp { get; set; }

    public string? DsOOpis { get; set; }

    public virtual Dostawy DsODstNumerNavigation { get; set; } = null!;
}
