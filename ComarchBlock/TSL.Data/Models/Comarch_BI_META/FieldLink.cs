using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class FieldLink
{
    public int FllId { get; set; }

    public int? FllFldid { get; set; }

    public int? FllPsrcid { get; set; }

    public int? FllTlnid { get; set; }

    public int? FllRelationLookUpFieldId { get; set; }

    public bool FllUseAtSourceDerivedExpression { get; set; }

    public string? FllAtSourceDerivedExpression { get; set; }

    public bool FllUseAtDestinationDerivedExpression { get; set; }

    public string? FllAtDestinationDerivedExpression { get; set; }

    public string? FllSourceFieldName { get; set; }

    public string? FllSourceFieldExpression { get; set; }

    public bool FllIsSourceField { get; set; }

    public byte? FllUpdtatePriority { get; set; }

    public DateTime FllTsinsert { get; set; }

    public DateTime FllTsupdate { get; set; }

    public byte[] FllRowVersion { get; set; } = null!;

    public virtual Field? FllFld { get; set; }

    public virtual PhysicalSource? FllPsrc { get; set; }

    public virtual Field? FllRelationLookUpField { get; set; }

    public virtual TableLink? FllTln { get; set; }
}
