using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class CorrectionState
{
    public string CstId { get; set; } = null!;

    public string CstName { get; set; } = null!;

    public virtual ICollection<Correction> Corrections { get; set; } = new List<Correction>();
}
