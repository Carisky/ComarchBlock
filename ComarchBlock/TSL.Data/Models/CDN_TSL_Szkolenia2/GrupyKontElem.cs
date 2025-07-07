using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class GrupyKontElem
{
    public int GkeGkeid { get; set; }

    public int GkeGknid { get; set; }

    public int GkeAccId { get; set; }

    public virtual Kontum GkeAcc { get; set; } = null!;

    public virtual GrupyKontNag GkeGkn { get; set; } = null!;
}
