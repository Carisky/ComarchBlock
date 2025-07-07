using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymGustowaryGr
{
    public int GustwrGrRowId { get; set; }

    public int GustwrGrId { get; set; }

    public string GustwrGrNazwa { get; set; } = null!;

    public string? GustwrGrOpis { get; set; }

    public virtual ICollection<FktJgospodarczeGu> FktJgospodarczeGus { get; set; } = new List<FktJgospodarczeGu>();

    public virtual ICollection<FktLudnoscGu> FktLudnoscGus { get; set; } = new List<FktLudnoscGu>();
}
