using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PodtypWyplatum
{
    public int PtwPtwId { get; set; }

    public int PtwTwpId { get; set; }

    public int PtwParentSts { get; set; }

    public string PtwParentNazwa { get; set; } = null!;

    public int PtwParentId { get; set; }

    public virtual TypWyplatum PtwTwp { get; set; } = null!;
}
