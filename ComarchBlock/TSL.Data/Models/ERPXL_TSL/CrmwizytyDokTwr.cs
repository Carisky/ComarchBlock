using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class CrmwizytyDokTwr
{
    public short CdtCwetyp { get; set; }

    public int CdtCwenumer { get; set; }

    public short CdtCwelp { get; set; }

    public int CdtTwrNumer { get; set; }

    public decimal? CdtIlosc { get; set; }

    public byte? CdtWymagaj { get; set; }

    public virtual TwrKarty CdtTwrNumerNavigation { get; set; } = null!;

    public virtual CrmwizytyElem CrmwizytyElem { get; set; } = null!;
}
