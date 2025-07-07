using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymGustowary
{
    public int GustwrRowId { get; set; }

    public int GustwrId { get; set; }

    public string GustwrNazwa { get; set; } = null!;

    public string? GustwrOpis { get; set; }

    public virtual ICollection<FktJgospodarczeGu> FktJgospodarczeGus { get; set; } = new List<FktJgospodarczeGu>();

    public virtual ICollection<FktLudnoscGu> FktLudnoscGus { get; set; } = new List<FktLudnoscGu>();
}
