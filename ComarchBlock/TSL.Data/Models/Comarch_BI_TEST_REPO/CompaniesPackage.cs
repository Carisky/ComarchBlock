using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class CompaniesPackage
{
    public int CopCompanyId { get; set; }

    public string CopPackageId { get; set; } = null!;

    public int? CopNumberExtend { get; set; }

    public int CopMonthTime { get; set; }
}
