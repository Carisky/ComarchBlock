using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class UserWym02119
{
    public int WymId { get; set; }

    public string? WymNazwa { get; set; }

    public string WymOrgId { get; set; } = null!;

    public string WymDirtyOrgId { get; set; } = null!;

    public string? WymOpis { get; set; }

    public string? WymLevel1Nazwa { get; set; }

    public int? WymLevel1Id { get; set; }

    public string? WymLevel1OrgId { get; set; }

    public string? WymLevel1DirtyOrgId { get; set; }

    public string? WymLevel2Nazwa { get; set; }

    public int? WymLevel2Id { get; set; }

    public string? WymLevel2OrgId { get; set; }

    public string? WymLevel2DirtyOrgId { get; set; }
}
