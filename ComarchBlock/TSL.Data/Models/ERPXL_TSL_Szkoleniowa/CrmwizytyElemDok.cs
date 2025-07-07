using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class CrmwizytyElemDok
{
    public short CwdCwetyp { get; set; }

    public int CwdCwenumer { get; set; }

    public short CwdCwelp { get; set; }

    public short CwdDokTyp { get; set; }

    public virtual CrmwizytyElem CrmwizytyElem { get; set; } = null!;
}
