using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SrcPowObiektyAtrMiary
{
    public string? ObjectGidtyp { get; set; }

    public string FieldFactTable { get; set; } = null!;

    public string FactTableName { get; set; } = null!;

    public int FactTableId { get; set; }

    public string FieldDimensionTable { get; set; } = null!;

    public string DimensionTableName { get; set; } = null!;

    public int DimensionTableId { get; set; }

    public string? FactCustomProperty { get; set; }

    public string? DimensionCustomProperty { get; set; }
}
