using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfCfCtrlAnalitycalDescription
{
    public int DadId { get; set; }

    public int DadDkoId { get; set; }

    public string? DadPropertyName { get; set; }

    public int? DadReferencedControlId { get; set; }

    public int? DadControlTypeId { get; set; }

    public int? DadRequired { get; set; }

    public int? DadReferencedColumnId { get; set; }

    public int? DadGroup { get; set; }
}
