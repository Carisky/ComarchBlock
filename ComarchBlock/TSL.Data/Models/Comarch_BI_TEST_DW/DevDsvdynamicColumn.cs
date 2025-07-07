using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevDsvdynamicColumn
{
    public string DcolId { get; set; } = null!;

    public string? DcolDatabaseName { get; set; }

    public string? DcolName { get; set; }

    public string? DcolFriendlyName { get; set; }

    public bool? DcolIsPrimaryKey { get; set; }

    public string? DcolParentTableReferenceId { get; set; }

    public string? DcolViewReferenceId { get; set; }
}
