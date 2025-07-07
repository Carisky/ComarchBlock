using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DevDsvdynamicTable
{
    public string DtabId { get; set; } = null!;

    public string? DtabName { get; set; }

    public string? DtabFriendlyName { get; set; }

    public string? DtabDatabaseName { get; set; }

    public string? DtabDatabaseSchemaName { get; set; }

    public string? DtabQuery { get; set; }

    public string? DtabType { get; set; }

    public string? DtabViewReferenceId { get; set; }
}
