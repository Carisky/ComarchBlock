using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfRbdictionary
{
    public int RbdId { get; set; }

    public string RbdProgramName { get; set; } = null!;

    public string RbdProgramGenerated { get; set; } = null!;

    public string RbdProgramUser { get; set; } = null!;

    public string? RbdProgramReferences { get; set; }

    public string? RbdAssemblyName { get; set; }

    public DateTime? RbdProgramDate { get; set; }
}
