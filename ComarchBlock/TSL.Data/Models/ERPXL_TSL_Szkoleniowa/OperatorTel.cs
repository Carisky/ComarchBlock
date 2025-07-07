using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class OperatorTel
{
    public string OptelOrgId { get; set; } = null!;

    public string? OptelOrgParId { get; set; }

    public string? OptelNazwa { get; set; }

    public string? OptelTyp { get; set; }

    public virtual ICollection<BilingTel> BilingTels { get; set; } = new List<BilingTel>();

    public virtual ICollection<RegulyNormTel> RegulyNormTels { get; set; } = new List<RegulyNormTel>();
}
