using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class UserWym02110
{
    public int WymId { get; set; }

    public string? WymNazwa { get; set; }

    public string WymOrgId { get; set; } = null!;

    public string WymDirtyOrgId { get; set; } = null!;

    public string? WymOpis { get; set; }
}
