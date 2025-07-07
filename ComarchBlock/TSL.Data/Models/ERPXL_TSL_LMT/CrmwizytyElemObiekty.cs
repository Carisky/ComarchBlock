using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class CrmwizytyElemObiekty
{
    public short CwoCwetyp { get; set; }

    public int CwoCwenumer { get; set; }

    public short CwoCwelp { get; set; }

    public short CwoObiTyp { get; set; }

    public int CwoObiNumer { get; set; }

    public short CwoObiLp { get; set; }

    public virtual CrmwizytyElem CrmwizytyElem { get; set; } = null!;
}
