using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class CorrectionType
{
    public string CtpId { get; set; } = null!;

    public string CtpName { get; set; } = null!;

    public virtual ICollection<Correction> Corrections { get; set; } = new List<Correction>();
}
