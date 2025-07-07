using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymGuswynFinansowy
{
    public int GuswynRowId { get; set; }

    public int GuswynId { get; set; }

    public string GuswynNazwa { get; set; } = null!;

    public string? GuswynOpis { get; set; }

    public virtual ICollection<FktJgospodarczeGu> FktJgospodarczeGus { get; set; } = new List<FktJgospodarczeGu>();

    public virtual ICollection<FktLudnoscGu> FktLudnoscGus { get; set; } = new List<FktLudnoscGu>();
}
